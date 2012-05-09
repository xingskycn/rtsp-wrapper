using System;
using Live555Rtsp;

namespace RtspTestApp
{
    class StreamClientState
    {

        public StreamClientState ()
        {
        }

        ~StreamClientState ()
        {
            iter.Dispose ();
            if (session != null)
            {
                var env = session.Envir;
                env.TaskScheduler.UnscheduleDelayedTask(streamTimerTask);
                Medium.Close(session);
            }
        }

        public MediaSubsessionIterator iter;
        public MediaSession session;
        public MediaSubsession subsession;
        public IntPtr streamTimerTask;
        public double duration;
    }
}