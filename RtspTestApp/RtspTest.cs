using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Live555Rtsp;

namespace RtspTestApp
{
    class RtspTest
    {
        private BasicTaskScheduler scheduler;
        private BasicUsageEnvironment env;
        private static string progName = Environment.GetCommandLineArgs ()[0];
        long rtspClientCount = 0;

        public RtspTest ()
        {
            scheduler = BasicTaskScheduler.CreateNew ();
            env = BasicUsageEnvironment.CreateNew (scheduler);    
        }

        public void OpenUrl(string url)
        {
            var client = new OurRtspClient (env, url, 1, progName, 0);

            ++rtspClientCount;

            client.SendDescribeCommand (ContinueAfterDescribe, null);
        }

        public void Start()
        {
            env.TaskScheduler.DoEventLoop (null);
        }


        private void ContinueAfterDescribe (RTSPClient rtspClient, int resultCode, string resultString)
        {
            while (true) {
                var scs = ((OurRtspClient)rtspClient).scs;

                if (resultCode != 0) {
                    Console.Error.WriteLine ("Failed to get a SDP description: " + resultString);
                    break;
                }

                var description = resultString;

                Console.Error.WriteLine ("Got a SDP description:");
                Console.Error.Write (description);

                scs.session = MediaSession.CreateNew (env, description);

                if (scs.session == null) {
                    Console.Error.WriteLine ("Failed to create a MediaSession object from the SDP description: " + env.GetResultMsg);
                    break;
                }

                if (scs.session.HasSubsessions == 0) {
                    Console.Error.WriteLine ("This session has no media subsessions (i.e., no \"m=\" lines)");
                    break;
                }

                scs.iter = new MediaSubsessionIterator (scs.session);
                SetupNextSubsession (rtspClient);
                return;
            }

            ShutdownStream (rtspClient);
        }

        private void SetupNextSubsession (RTSPClient rtspClient)
        {
            var scs = ((OurRtspClient)rtspClient).scs; // alias

            scs.subsession = scs.iter.Next ();
            if (scs.subsession != null) {
                if (scs.subsession.Initiate (0) == 0) {
                    Console.Error.WriteLine ("Failed to initiate the \"" + scs.subsession + "\" subsession: " + env.GetResultMsg);
                    SetupNextSubsession (rtspClient); // give up on this subsession; go to the next one
                } else {
                    Console.Error.WriteLine ("Initiated the \"" + scs.subsession +
                        "\" subsession (client ports " + scs.subsession.ClientPortNum + "-" + (scs.subsession.ClientPortNum + 1) + ")");

                    // Continue setting up this subsession, by sending a RTSP "SETUP" command:
                    rtspClient.SendSetupCommand (scs.subsession, ContinueAfterSetup, 0, 0, 0, null);
                }
                return;
            }

            // We've finished setting up all of the subsessions.  Now, send a RTSP "PLAY" command to start the streaming:
            scs.duration = scs.session.PlayEndTime () - scs.session.PlayStartTime ();
            rtspClient.SendPlayCommand (scs.session, ContinueAfterPlay, 0, 0, 0, null);
        }

        private void ContinueAfterSetup (RTSPClient rtspClient, int resultCode, string resultString)
        {
            do {
                var scs = ((OurRtspClient)rtspClient).scs; // alias

                if (resultCode != 0) {
                    Console.Error.WriteLine (rtspClient + "Failed to set up the \"" + scs.subsession + "\" subsession: " +
                                            env.GetResultMsg);
                    break;
                }

                Console.Error.WriteLine (rtspClient + "Set up the \"" + scs.subsession
                                        + "\" subsession (client ports " + scs.subsession.ClientPortNum + "-" +
                                        (scs.subsession.ClientPortNum + 1) + ")");

                // Having successfully setup the subsession, create a data sink for it, and call "startPlaying()" on it.
                // (This will prepare the data sink to receive data; the actual flow of data from the client won't start happening until later,
                // after we've sent a RTSP "PLAY" command.)

                scs.subsession.sink = DummySink.CreateNew (env, scs.subsession, rtspClient.Url);
                // perhaps use your own custom "MediaSink" subclass instead
                if (scs.subsession.sink == null) {
                    Console.Error.WriteLine (rtspClient + "Failed to create a data sink for the \"" + scs.subsession
                                            + "\" subsession: " + env.GetResultMsg);
                    break;
                }

                Console.Error.WriteLine (rtspClient + "Created a data sink for the \"" + scs.subsession + "\" subsession");
                scs.subsession.miscPtr = rtspClient.Native.Native;
                // a hack to let subsession handle functions get the "RTSPClient" from the subsession 
                scs.subsession.sink.StartPlaying (scs.subsession.ReadSource (), SubsessionAfterPlaying,
                                                 scs.subsession.Native.Native);
                // Also set a handler to be called if a RTCP "BYE" arrives for this subsession:
                if (scs.subsession.RtcpInstance () != null) {
                    scs.subsession.RtcpInstance ().SetByeHandler (subsessionByeHandler, scs.subsession.Native.Native, 1);
                }
            } while (false);

            // Set up the next subsession, if any:
            SetupNextSubsession (rtspClient);
        }

        private void ContinueAfterPlay (RTSPClient rtspClient, int resultCode, string resultString)
        {
            do {
                var scs = ((OurRtspClient)rtspClient).scs; // alias

                if (resultCode != 0) {
                    Console.Error.WriteLine (rtspClient + "Failed to start playing session: " + resultString);
                    break;
                }

                if (scs.duration > 0) {
                    const uint delaySlop = 2;
                    // number of seconds extra to delay, after the stream's expected duration.  (This is optional.)
                    scs.duration += delaySlop;
                    var uSecsToDelay = (long)(scs.duration * 1000000);
                    scs.streamTimerTask = env.TaskScheduler.ScheduleDelayedTask (uSecsToDelay, streamTimerHandler, rtspClient.Native.Native);
                }

                Console.Error.Write (rtspClient + "Started playing session");
                if (scs.duration > 0) {
                    Console.Error.Write (" (for up to " + scs.duration + " seconds)");
                }
                Console.Error.WriteLine ("...");

                return;
            } while (false);


            // An unrecoverable error occurred with this stream.
            ShutdownStream (rtspClient);
        }

        private void SubsessionAfterPlaying (IntPtr clientData)
        {
            var subsession = new MediaSubsession (clientData);
            var rtspClient = new RTSPClient (subsession.miscPtr);

            // Begin by closing this subsession's stream:
            Medium.Close (subsession.sink);
            subsession.sink = null;

            // Next, check whether *all* subsessions' streams have now been closed:
            var session = subsession.ParentSession ();
            var iter = new MediaSubsessionIterator (session);
            while ((subsession = iter.Next ()) != null) {
                if (subsession.sink != null) return; // this subsession is still active
            }

            // All subsessions' streams have now been closed, so shutdown the client:
            ShutdownStream (rtspClient);
        }

        private void subsessionByeHandler (IntPtr clientData)
        {
            var subsession = new MediaSubsession (clientData);
            var rtspClient = new RTSPClient (subsession.miscPtr);

            Console.Error.WriteLine (rtspClient + "Received RTCP \"BYE\" on \"" + subsession + "\" subsession");

            // Now act as if the subsession had closed:
            SubsessionAfterPlaying (subsession.Native.Native);
        }

        private void streamTimerHandler (IntPtr clientData)
        {
            var rtspClient = new OurRtspClient (clientData);
            var scs = rtspClient.scs; // alias

            scs.streamTimerTask = IntPtr.Zero;

            // Shut down the stream:
            ShutdownStream (rtspClient);
        }

        private void ShutdownStream (RTSPClient rtspClient, int exitCode = 1)
        {
            var scs = ((OurRtspClient)rtspClient).scs; // alias

            if (scs.session != null) {
                var someSubsessionsWereActive = false;
                var iter = new MediaSubsessionIterator (scs.session);
                MediaSubsession subsession;

                while ((subsession = iter.Next ()) != null) {
                    if (subsession.sink != null) {
                        Medium.Close (subsession.sink);
                        subsession.sink = null;

                        if (subsession.RtcpInstance () != null) {
                            subsession.RtcpInstance ().SetByeHandler (null, IntPtr.Zero, 1);
                            // in case the server sends a RTCP "BYE" while handling "TEARDOWN"
                        }

                        someSubsessionsWereActive = true;
                    }
                }

                if (someSubsessionsWereActive) {
                    // Send a RTSP "TEARDOWN" command, to tell the server to shutdown the stream.
                    // Don't bother handling the response to the "TEARDOWN".
                    rtspClient.SendTeardownCommand (scs.session, null, null);
                }
            }

            Console.Error.WriteLine (rtspClient + "Closing the stream.");
            Medium.Close (rtspClient);
            // Note that this will also cause this stream's "StreamClientState" structure to get reclaimed.

            if (--rtspClientCount == 0) {
                // The final stream has ended, so exit the application now.
                // (Of course, if you're embedding this code into your own application, you might want to comment this out.)
                Environment.Exit (exitCode);

                // If you choose *not* to "exit()" the application (i.e., if you comment out the call to "exit()" above),
                // and you don't intend to do anything more with this "TaskScheduler" and "UsageEnvironment",
                // then you can also reclaim the (small) memory used by these objects by doing the following.
                // (However, you must not do this until after you have left the event loop.)
                /*
                  TaskScheduler* scheduler = &(env.taskScheduler());
                  env.reclaim();
                  delete scheduler;
                */
            }
        }
    }
}
