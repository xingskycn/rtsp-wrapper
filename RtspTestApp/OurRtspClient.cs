using Live555Rtsp;
using Mono.Cxxi;

namespace RtspTestApp
{
    class OurRtspClient : RTSPClient
    {
        public StreamClientState scs = new StreamClientState();

        public OurRtspClient(CppTypeInfo subClass) 
            : base(subClass)
        {
        }

        public OurRtspClient(CppInstancePtr native) 
            : base(native)
        {
        }

        public OurRtspClient(UsageEnvironment env, string rtspURL, int verbosityLevel, string applicationName, ushort tunnelOverHTTPPortNum) 
            : base(env, rtspURL, verbosityLevel, applicationName, tunnelOverHTTPPortNum)
        {
        }
    }
}