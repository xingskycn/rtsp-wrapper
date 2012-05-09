using System;
using Live555Rtsp;
using Mono.Cxxi;

namespace RtspTestApp
{
    class DummySink : MediaSink
    {
        private const int RECEIVE_BUFFER_SIZE = 100000;
        private MediaSubsession fSubsession;
        private string fStreamId;
        private string fReceiveBuffer;

        public DummySink (CppTypeInfo subClass)
            : base (subClass)
        {
        }

        public DummySink (CppInstancePtr native)
            : base (native)
        {
        }

        protected DummySink (UsageEnvironment env)
            : base (env)
        {
        }

        private DummySink (UsageEnvironment env, MediaSubsession subsession, string streamId) :
            base (env)
        {
            fSubsession = subsession;
            fStreamId = streamId;
            fReceiveBuffer = new string('\0', RECEIVE_BUFFER_SIZE);
        }

        public override void Dispose ()
        {
            fReceiveBuffer = null;
            base.Dispose ();
        }

        protected override uint ContinuePlaying ()
        {
            if (fSource == null)
                return 0; // sanity check (should not happen)

            // Request the next frame of data from our input source.  "afterGettingFrame()" will get called later, when it arrives:
            fSource.GetNextFrame (fReceiveBuffer, RECEIVE_BUFFER_SIZE,
                                  afterGettingFrame, this.Native.Native,
                                  OnSourceClosure, this.Native.Native);

            return 1;
        }

        private void afterGettingFrame (IntPtr clientData, uint frameSize, uint numTruncatedBytes, timeval presentationTime, uint durationInMicroseconds)
        {
            var sink = new DummySink (clientData);
            sink.afterGettingFrame (frameSize, numTruncatedBytes, presentationTime, durationInMicroseconds);
        }

        private void afterGettingFrame (uint frameSize, uint numTruncatedBytes, timeval presentationTime, uint durationInMicroseconds)
        {

            if (fStreamId != null)
                Console.Error.Write ("Stream \"" + fStreamId + "\"; ");

            Console.Error.Write (fSubsession.MediumName + "/" + fSubsession.CodecName + ":\tReceived " + frameSize + " bytes");
            if (numTruncatedBytes > 0)
                Console.Error.Write (" (with " + numTruncatedBytes + " bytes truncated)");


            Console.Error.Write (".\tPresentation time: " + (uint)presentationTime.tv_sec + "." + (uint)presentationTime.tv_usec);
            if (fSubsession.RtpSource () != null && fSubsession.RtpSource ().HasBeenSynchronizedUsingRTCP () == 0) {
                Console.Error.Write ("!"); // mark the debugging output to indicate that this presentation time is not RTCP-synchronized
            }
            Console.Error.Write ("\n");

            // Then continue, to request the next frame of data:
            ContinuePlaying ();
        }

        public static MediaSink CreateNew (UsageEnvironment env, MediaSubsession subsession, string streamId)
        {
            return new DummySink (env, subsession, streamId);
        }
    }
}