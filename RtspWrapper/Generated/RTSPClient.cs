// -------------------------------------------------------------------------
//  Managed wrapper for RTSPClient
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class RTSPClient : Medium {

		private static readonly IRTSPClient impl = Libs.live555.GetClass<IRTSPClient,_RTSPClient,RTSPClient> ("RTSPClient");
		public static bool operator!=(RTSPClient a, RTSPClient b) { return !(a == b); }
		public static bool operator==(RTSPClient a, RTSPClient b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as RTSPClient); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class RTSPClient")]
		public partial interface IRTSPClient : ICppClassOverridable<RTSPClient> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr RTSPClient (CppInstancePtr @this, [MangleAs ("class RTSPClient const &")] RTSPClient arg0);
			[Static] [return: MangleAs ("class RTSPClient *")] RTSPClient createNew ([MangleAs ("class UsageEnvironment &")] UsageEnvironment env, [MangleAs ("char  const *")] string rtspURL, int verbosityLevel, [MangleAs ("char  const *")] string applicationName, [MangleAs ("int  short unsigned")] ushort tunnelOverHTTPPortNum);
			[return: MangleAs ("int  unsigned")] uint sendDescribeCommand (CppInstancePtr @this, [MangleAs ("delegate RTSPClient::ResponseHandler *")] RTSPClient.ResponseHandler responseHandler, [MangleAs ("class Authenticator *")] Authenticator authenticator);
			[return: MangleAs ("int  unsigned")] uint sendOptionsCommand (CppInstancePtr @this, [MangleAs ("delegate RTSPClient::ResponseHandler *")] RTSPClient.ResponseHandler responseHandler, [MangleAs ("class Authenticator *")] Authenticator authenticator);
			[return: MangleAs ("int  unsigned")] uint sendAnnounceCommand (CppInstancePtr @this, [MangleAs ("char  const *")] string sdpDescription, [MangleAs ("delegate RTSPClient::ResponseHandler *")] RTSPClient.ResponseHandler responseHandler, [MangleAs ("class Authenticator *")] Authenticator authenticator);
			[return: MangleAs ("int  unsigned")] uint sendSetupCommand (CppInstancePtr @this, [MangleAs ("class MediaSubsession &")] MediaSubsession subsession, [MangleAs ("delegate RTSPClient::ResponseHandler *")] RTSPClient.ResponseHandler responseHandler, [MangleAs ("int  unsigned")] uint streamOutgoing, [MangleAs ("int  unsigned")] uint streamUsingTCP, [MangleAs ("int  unsigned")] uint forceMulticastOnUnspecified, [MangleAs ("class Authenticator *")] Authenticator authenticator);
			[return: MangleAs ("int  unsigned")] uint sendPlayCommand (CppInstancePtr @this, [MangleAs ("class MediaSession &")] MediaSession session, [MangleAs ("delegate RTSPClient::ResponseHandler *")] RTSPClient.ResponseHandler responseHandler, double start, double end, float scale, [MangleAs ("class Authenticator *")] Authenticator authenticator);
			[return: MangleAs ("int  unsigned")] uint sendPlayCommand (CppInstancePtr @this, [MangleAs ("class MediaSubsession &")] MediaSubsession subsession, [MangleAs ("delegate RTSPClient::ResponseHandler *")] RTSPClient.ResponseHandler responseHandler, double start, double end, float scale, [MangleAs ("class Authenticator *")] Authenticator authenticator);
			[return: MangleAs ("int  unsigned")] uint sendPauseCommand (CppInstancePtr @this, [MangleAs ("class MediaSession &")] MediaSession session, [MangleAs ("delegate RTSPClient::ResponseHandler *")] RTSPClient.ResponseHandler responseHandler, [MangleAs ("class Authenticator *")] Authenticator authenticator);
			[return: MangleAs ("int  unsigned")] uint sendPauseCommand (CppInstancePtr @this, [MangleAs ("class MediaSubsession &")] MediaSubsession subsession, [MangleAs ("delegate RTSPClient::ResponseHandler *")] RTSPClient.ResponseHandler responseHandler, [MangleAs ("class Authenticator *")] Authenticator authenticator);
			[return: MangleAs ("int  unsigned")] uint sendRecordCommand (CppInstancePtr @this, [MangleAs ("class MediaSession &")] MediaSession session, [MangleAs ("delegate RTSPClient::ResponseHandler *")] RTSPClient.ResponseHandler responseHandler, [MangleAs ("class Authenticator *")] Authenticator authenticator);
			[return: MangleAs ("int  unsigned")] uint sendRecordCommand (CppInstancePtr @this, [MangleAs ("class MediaSubsession &")] MediaSubsession subsession, [MangleAs ("delegate RTSPClient::ResponseHandler *")] RTSPClient.ResponseHandler responseHandler, [MangleAs ("class Authenticator *")] Authenticator authenticator);
			[return: MangleAs ("int  unsigned")] uint sendTeardownCommand (CppInstancePtr @this, [MangleAs ("class MediaSession &")] MediaSession session, [MangleAs ("delegate RTSPClient::ResponseHandler *")] RTSPClient.ResponseHandler responseHandler, [MangleAs ("class Authenticator *")] Authenticator authenticator);
			[return: MangleAs ("int  unsigned")] uint sendTeardownCommand (CppInstancePtr @this, [MangleAs ("class MediaSubsession &")] MediaSubsession subsession, [MangleAs ("delegate RTSPClient::ResponseHandler *")] RTSPClient.ResponseHandler responseHandler, [MangleAs ("class Authenticator *")] Authenticator authenticator);
			[return: MangleAs ("int  unsigned")] uint sendSetParameterCommand (CppInstancePtr @this, [MangleAs ("class MediaSession &")] MediaSession session, [MangleAs ("delegate RTSPClient::ResponseHandler *")] RTSPClient.ResponseHandler responseHandler, [MangleAs ("char  const *")] string parameterName, [MangleAs ("char  const *")] string parameterValue, [MangleAs ("class Authenticator *")] Authenticator authenticator);
			[return: MangleAs ("int  unsigned")] uint sendGetParameterCommand (CppInstancePtr @this, [MangleAs ("class MediaSession &")] MediaSession session, [MangleAs ("delegate RTSPClient::ResponseHandler *")] RTSPClient.ResponseHandler responseHandler, [MangleAs ("char  const *")] string parameterName, [MangleAs ("class Authenticator *")] Authenticator authenticator);
			[return: MangleAs ("int  unsigned")] uint changeResponseHandler (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint cseq, [MangleAs ("delegate RTSPClient::ResponseHandler *")] RTSPClient.ResponseHandler newResponseHandler);
			[Inline] [Const] int socketNum (CppInstancePtr @this);
			[Static] [return: MangleAs ("int  unsigned")] uint lookupByName ([MangleAs ("class UsageEnvironment &")] UsageEnvironment env, [MangleAs ("char  const *")] string sourceName, [MangleAs ("class RTSPClient * &")] RTSPClient resultClient);
			[Static] [return: MangleAs ("int  unsigned")] uint parseRTSPURL ([MangleAs ("class UsageEnvironment &")] UsageEnvironment env, [MangleAs ("char  const *")] string url, [MangleAs ("char  * &")] string username, [MangleAs ("char  * &")] string password, [MangleAs ("class NetAddress &")] NetAddress address, [MangleAs ("int  short unsigned &")] ref ushort portNum, [MangleAs ("char  const * *")] String[] urlSuffix);
			void setUserAgentString (CppInstancePtr @this, [MangleAs ("char  const *")] string userAgentName);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint sessionTimeoutParameter (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  const *")] string url (CppInstancePtr @this);
			[Constructor] [Protected] CppInstancePtr RTSPClient (CppInstancePtr @this, [MangleAs ("class UsageEnvironment &")] UsageEnvironment env, [MangleAs ("char  const *")] string rtspURL, int verbosityLevel, [MangleAs ("char  const *")] string applicationName, [MangleAs ("int  short unsigned")] ushort tunnelOverHTTPPortNum);
			[Virtual] [Destructor] [Protected] void Destruct (CppInstancePtr @this);
			[Protected] void setBaseURL (CppInstancePtr @this, [MangleAs ("char  const *")] string url);
		}
		public unsafe struct _RTSPClient {
			public int fVerbosityLevel;
			public ushort fTunnelOverHTTPPortNum;
			public string fUserAgentHeaderStr;
			public uint fUserAgentHeaderStrLen;
			public int fInputSocketNum;
			public int fOutputSocketNum;
			public uint fServerAddress;
			public uint fCSeq;
			public string fBaseURL;
			public Authenticator._Authenticator fCurrentAuthenticator;
			public char fTCPStreamIdCount;
			public string fLastSessionId;
			public uint fSessionTimeoutParameter;
			public string fResponseBuffer;
			public uint fResponseBytesAlreadySeen;
			public uint fResponseBufferBytesLeft;
			public IntPtr fRequestsAwaitingConnection;
			public IntPtr fRequestsAwaitingHTTPTunneling;
			public IntPtr fRequestsAwaitingResponse;
			public fixed Char fSessionCookie [33];
			public uint fSessionCookieCounter;
			public uint fHTTPTunnelingConnectionIsPending;
		}




	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	public delegate void ResponseHandler ([MangleAs ("class RTSPClient *")] RTSPClient arg0, int arg1, [MangleAs ("char  *"), MarshalAs(UnmanagedType.LPStr)] string arg2);


		public RTSPClient (CppTypeInfo subClass)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public RTSPClient (CppInstancePtr native)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public static RTSPClient CreateNew (UsageEnvironment env, string rtspURL, int verbosityLevel, string applicationName, ushort tunnelOverHTTPPortNum)
		{
			return impl.createNew (env, rtspURL, verbosityLevel, applicationName, tunnelOverHTTPPortNum);
		}
		public uint SendDescribeCommand (RTSPClient.ResponseHandler responseHandler, Authenticator authenticator)
		{
			return impl.sendDescribeCommand (Native, new WeakDelegate<RTSPClient.ResponseHandler>(responseHandler), authenticator);
		}
		public uint SendOptionsCommand (RTSPClient.ResponseHandler responseHandler, Authenticator authenticator)
		{
			return impl.sendOptionsCommand (Native, new WeakDelegate<RTSPClient.ResponseHandler>(responseHandler), authenticator);
		}
		public uint SendAnnounceCommand (string sdpDescription, RTSPClient.ResponseHandler responseHandler, Authenticator authenticator)
		{
			return impl.sendAnnounceCommand (Native, sdpDescription, new WeakDelegate<RTSPClient.ResponseHandler>(responseHandler), authenticator);
		}
		public uint SendSetupCommand (MediaSubsession subsession, RTSPClient.ResponseHandler responseHandler, uint streamOutgoing, uint streamUsingTCP, uint forceMulticastOnUnspecified, Authenticator authenticator)
		{
			return impl.sendSetupCommand (Native, subsession, new WeakDelegate<RTSPClient.ResponseHandler>(responseHandler), streamOutgoing, streamUsingTCP, forceMulticastOnUnspecified, authenticator);
		}
		public uint SendPlayCommand (MediaSession session, RTSPClient.ResponseHandler responseHandler, double start, double end, float scale, Authenticator authenticator)
		{
			return impl.sendPlayCommand (Native, session, new WeakDelegate<RTSPClient.ResponseHandler>(responseHandler), start, end, scale, authenticator);
		}
		public uint SendPlayCommand (MediaSubsession subsession, RTSPClient.ResponseHandler responseHandler, double start, double end, float scale, Authenticator authenticator)
		{
			return impl.sendPlayCommand (Native, subsession, new WeakDelegate<RTSPClient.ResponseHandler>(responseHandler), start, end, scale, authenticator);
		}
		public uint SendPauseCommand (MediaSession session, RTSPClient.ResponseHandler responseHandler, Authenticator authenticator)
		{
			return impl.sendPauseCommand (Native, session, new WeakDelegate<RTSPClient.ResponseHandler>(responseHandler), authenticator);
		}
		public uint SendPauseCommand (MediaSubsession subsession, RTSPClient.ResponseHandler responseHandler, Authenticator authenticator)
		{
			return impl.sendPauseCommand (Native, subsession, new WeakDelegate<RTSPClient.ResponseHandler>(responseHandler), authenticator);
		}
		public uint SendRecordCommand (MediaSession session, RTSPClient.ResponseHandler responseHandler, Authenticator authenticator)
		{
			return impl.sendRecordCommand (Native, session, new WeakDelegate<RTSPClient.ResponseHandler>(responseHandler), authenticator);
		}
		public uint SendRecordCommand (MediaSubsession subsession, RTSPClient.ResponseHandler responseHandler, Authenticator authenticator)
		{
			return impl.sendRecordCommand (Native, subsession, new WeakDelegate<RTSPClient.ResponseHandler>(responseHandler), authenticator);
		}
		public uint SendTeardownCommand (MediaSession session, RTSPClient.ResponseHandler responseHandler, Authenticator authenticator)
		{
			return impl.sendTeardownCommand (Native, session, new WeakDelegate<RTSPClient.ResponseHandler>(responseHandler), authenticator);
		}
		public uint SendTeardownCommand (MediaSubsession subsession, RTSPClient.ResponseHandler responseHandler, Authenticator authenticator)
		{
			return impl.sendTeardownCommand (Native, subsession, new WeakDelegate<RTSPClient.ResponseHandler>(responseHandler), authenticator);
		}
		public uint SendSetParameterCommand (MediaSession session, RTSPClient.ResponseHandler responseHandler, string parameterName, string parameterValue, Authenticator authenticator)
		{
			return impl.sendSetParameterCommand (Native, session, new WeakDelegate<RTSPClient.ResponseHandler>(responseHandler), parameterName, parameterValue, authenticator);
		}
		public uint SendGetParameterCommand (MediaSession session, RTSPClient.ResponseHandler responseHandler, string parameterName, Authenticator authenticator)
		{
			return impl.sendGetParameterCommand (Native, session, new WeakDelegate<RTSPClient.ResponseHandler>(responseHandler), parameterName, authenticator);
		}
		public uint ChangeResponseHandler (uint cseq, RTSPClient.ResponseHandler newResponseHandler)
		{
			return impl.changeResponseHandler (Native, cseq, new WeakDelegate<RTSPClient.ResponseHandler>(newResponseHandler));
		}
		public static uint LookupByName (UsageEnvironment env, string sourceName, RTSPClient resultClient)
		{
			return impl.lookupByName (env, sourceName, resultClient);
		}
		public static uint ParseRTSPURL (UsageEnvironment env, string url, string username, string password, NetAddress address, ref ushort portNum, String[] urlSuffix)
		{
			return impl.parseRTSPURL (env, url, username, password, address, ref portNum, urlSuffix);
		}
		public void SetUserAgentString (string userAgentName)
		{
			impl.setUserAgentString (Native, userAgentName);
		}
		protected RTSPClient (UsageEnvironment env, string rtspURL, int verbosityLevel, string applicationName, ushort tunnelOverHTTPPortNum)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = impl.RTSPClient (impl.Alloc (this), env, rtspURL, verbosityLevel, applicationName, tunnelOverHTTPPortNum);
		}
		protected void SetBaseURL (string url)
		{
			impl.setBaseURL (Native, url);
		}

		public int SocketNum {
			get {
				return impl.socketNum (Native);
			}
		}

		public uint SessionTimeoutParameter {
			get {
				return impl.sessionTimeoutParameter (Native);
			}
		}

		public string Url {
			get {
				return impl.url (Native);
			}
		}


		partial void BeforeDestruct ();
		partial void AfterDestruct ();

		public override void Dispose ()
		{
			BeforeDestruct ();
			impl.Destruct (Native);
			Native.Dispose ();
			AfterDestruct ();
		}

		private void __cxxi_LayoutClass ()
		{
			impl.TypeInfo.CompleteType ();
		}

	}
}

