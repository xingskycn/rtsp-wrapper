// -------------------------------------------------------------------------
//  Managed wrapper for MediaSubsession
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class MediaSubsession : ICppObject {

		private static readonly IMediaSubsession impl = Libs.live555.GetClass<IMediaSubsession,_MediaSubsession,MediaSubsession> ("MediaSubsession");
		public CppInstancePtr Native { get; protected set; }
		public static bool operator!=(MediaSubsession a, MediaSubsession b) { return !(a == b); }
		public static bool operator==(MediaSubsession a, MediaSubsession b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as MediaSubsession); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class MediaSubsession")]
		public partial interface IMediaSubsession : ICppClassOverridable<MediaSubsession> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr MediaSubsession (CppInstancePtr @this, [MangleAs ("class MediaSubsession const &")] MediaSubsession arg0);
			[Inline] [return: MangleAs ("class MediaSession &")] MediaSession parentSession (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  short unsigned")] ushort clientPortNum (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  unsigned")] char rtpPayloadFormat (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  const *")] string savedSDPLines (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  const *")] string mediumName (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  const *")] string codecName (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  const *")] string protocolName (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  const *")] string controlPath (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint isSSM (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  short unsigned")] ushort videoWidth (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  short unsigned")] ushort videoHeight (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint videoFPS (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint numChannels (CppInstancePtr @this);
			[Inline] [return: MangleAs ("float  &")] [return: ByRef] IntPtr  scale (CppInstancePtr @this);
			[Inline] [return: MangleAs ("class RTPSource *")] RTPSource rtpSource (CppInstancePtr @this);
			[Inline] [return: MangleAs ("class RTCPInstance *")] RTCPInstance rtcpInstance (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint rtpTimestampFrequency (CppInstancePtr @this);
			[Inline] [return: MangleAs ("class FramedSource *")] FramedSource readSource (CppInstancePtr @this);
			void addFilter (CppInstancePtr @this, [MangleAs ("class FramedFilter *")] FramedFilter filter);
			[Const] double playStartTime (CppInstancePtr @this);
			[Const] double playEndTime (CppInstancePtr @this);
			[Inline] [return: MangleAs ("double  &")] [return: ByRef] IntPtr  _playStartTime (CppInstancePtr @this);
			[Inline] [return: MangleAs ("double  &")] [return: ByRef] IntPtr  _playEndTime (CppInstancePtr @this);
			[return: MangleAs ("int  unsigned")] uint initiate (CppInstancePtr @this, int useSpecialRTPoffset);
			void deInitiate (CppInstancePtr @this);
			[return: MangleAs ("int  unsigned")] uint setClientPortNum (CppInstancePtr @this, [MangleAs ("int  short unsigned")] ushort portNum);
			[Inline] void receiveRawMP3ADUs (CppInstancePtr @this);
			[Inline] [return: MangleAs ("char  * &")] string connectionEndpointName (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint bandwidth (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint fmtp_auxiliarydatasizelength (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint fmtp_constantduration (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint fmtp_constantsize (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint fmtp_crc (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint fmtp_ctsdeltalength (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint fmtp_de_interleavebuffersize (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint fmtp_dtsdeltalength (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint fmtp_indexdeltalength (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint fmtp_indexlength (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint fmtp_interleaving (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint fmtp_maxdisplacement (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint fmtp_objecttype (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint fmtp_octetalign (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint fmtp_profile_level_id (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint fmtp_robustsorting (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint fmtp_sizelength (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint fmtp_streamstateindication (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint fmtp_streamtype (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint fmtp_cpresent (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint fmtp_randomaccessindication (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  const *")] string fmtp_config (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  const *")] string fmtp_configuration (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  const *")] string fmtp_mode (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  const *")] string fmtp_spropparametersets (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  const *")] string fmtp_emphasis (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  const *")] string fmtp_channelorder (CppInstancePtr @this);
			[Const] [return: MangleAs ("int  unsigned")] uint connectionEndpointAddress (CppInstancePtr @this);
			void setDestinations (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint defaultDestAddress);
			[Inline] [Const] [return: MangleAs ("char  const *")] string sessionId (CppInstancePtr @this);
			void setSessionId (CppInstancePtr @this, [MangleAs ("char  const *")] string value);
			double getNormalPlayTime (CppInstancePtr @this, [MangleAs ("struct timeval const &")] timeval presentationTime);
			[Constructor] [Protected] CppInstancePtr MediaSubsession (CppInstancePtr @this, [MangleAs ("class MediaSession &")] MediaSession parent);
			[Virtual] [Destructor] [Protected] void Destruct (CppInstancePtr @this);
			[Inline] [Protected] [return: MangleAs ("class UsageEnvironment &")] UsageEnvironment env (CppInstancePtr @this);
			[Inline] [Protected] void setNext (CppInstancePtr @this, [MangleAs ("class MediaSubsession *")] MediaSubsession next);
			[Protected] [return: MangleAs ("int  unsigned")] uint parseSDPLine_c (CppInstancePtr @this, [MangleAs ("char  const *")] string sdpLine);
			[Protected] [return: MangleAs ("int  unsigned")] uint parseSDPLine_b (CppInstancePtr @this, [MangleAs ("char  const *")] string sdpLine);
			[Protected] [return: MangleAs ("int  unsigned")] uint parseSDPAttribute_rtpmap (CppInstancePtr @this, [MangleAs ("char  const *")] string sdpLine);
			[Protected] [return: MangleAs ("int  unsigned")] uint parseSDPAttribute_control (CppInstancePtr @this, [MangleAs ("char  const *")] string sdpLine);
			[Protected] [return: MangleAs ("int  unsigned")] uint parseSDPAttribute_range (CppInstancePtr @this, [MangleAs ("char  const *")] string sdpLine);
			[Protected] [return: MangleAs ("int  unsigned")] uint parseSDPAttribute_fmtp (CppInstancePtr @this, [MangleAs ("char  const *")] string sdpLine);
			[Protected] [return: MangleAs ("int  unsigned")] uint parseSDPAttribute_source_filter (CppInstancePtr @this, [MangleAs ("char  const *")] string sdpLine);
			[Protected] [return: MangleAs ("int  unsigned")] uint parseSDPAttribute_x_dimensions (CppInstancePtr @this, [MangleAs ("char  const *")] string sdpLine);
			[Protected] [return: MangleAs ("int  unsigned")] uint parseSDPAttribute_framerate (CppInstancePtr @this, [MangleAs ("char  const *")] string sdpLine);
			[Virtual] [Protected] [return: MangleAs ("int  unsigned")] uint createSourceObjects (CppInstancePtr @this, int useSpecialRTPoffset);
			CppField<ushort> serverPortNum { get; }
			CppField<char> rtpChannelId { get; }
			CppField<char> rtcpChannelId { get; }
			CppField<MediaSink> sink { get; }
			CppField<IntPtr> miscPtr { get; }
			CppField<IntPtr> rtpInfo { get; }
			CppField<MediaSession> fParent { get; }
			CppField<MediaSubsession> fNext { get; }
			CppField<string> fConnectionEndpointName { get; }
			CppField<ushort> fClientPortNum { get; }
			CppField<char> fRTPPayloadFormat { get; }
			CppField<string> fSavedSDPLines { get; }
			CppField<string> fMediumName { get; }
			CppField<string> fCodecName { get; }
			CppField<string> fProtocolName { get; }
			CppField<uint> fRTPTimestampFrequency { get; }
			CppField<string> fControlPath { get; }
			CppField<in_addr> fSourceFilterAddr { get; }
			CppField<uint> fBandwidth { get; }
			CppField<uint> fAuxiliarydatasizelength { get; }
			CppField<uint> fConstantduration { get; }
			CppField<uint> fConstantsize { get; }
			CppField<uint> fCRC { get; }
			CppField<uint> fCtsdeltalength { get; }
			CppField<uint> fDe_interleavebuffersize { get; }
			CppField<uint> fDtsdeltalength { get; }
			CppField<uint> fIndexdeltalength { get; }
			CppField<uint> fIndexlength { get; }
			CppField<uint> fInterleaving { get; }
			CppField<uint> fMaxdisplacement { get; }
			CppField<uint> fObjecttype { get; }
			CppField<uint> fOctetalign { get; }
			CppField<uint> fProfile_level_id { get; }
			CppField<uint> fRobustsorting { get; }
			CppField<uint> fSizelength { get; }
			CppField<uint> fStreamstateindication { get; }
			CppField<uint> fStreamtype { get; }
			CppField<uint> fCpresent { get; }
			CppField<uint> fRandomaccessindication { get; }
			CppField<string> fConfig { get; }
			CppField<string> fMode { get; }
			CppField<string> fSpropParameterSets { get; }
			CppField<string> fEmphasis { get; }
			CppField<string> fChannelOrder { get; }
			CppField<double> fPlayStartTime { get; }
			CppField<double> fPlayEndTime { get; }
			CppField<ushort> fVideoWidth { get; }
			CppField<ushort> fVideoHeight { get; }
			CppField<uint> fVideoFPS { get; }
			CppField<uint> fNumChannels { get; }
			CppField<float> fScale { get; }
			CppField<double> fNPT_PTS_Offset { get; }
			CppField<Groupsock> fRTPSocket { get; }
			CppField<Groupsock> fRTCPSocket { get; }
			CppField<RTPSource> fRTPSource { get; }
			CppField<RTCPInstance> fRTCPInstance { get; }
			CppField<FramedSource> fReadSource { get; }
			CppField<uint> fReceiveRawMP3ADUs { get; }
			CppField<string> fSessionId { get; }
		}
		public unsafe struct _MediaSubsession {
			public ushort serverPortNum;
			public char rtpChannelId;
			public char rtcpChannelId;
			public MediaSink sink;
			public IntPtr miscPtr;
			public IntPtr rtpInfo;
			public MediaSession fParent;
			public MediaSubsession fNext;
			public string fConnectionEndpointName;
			public ushort fClientPortNum;
			public char fRTPPayloadFormat;
			public string fSavedSDPLines;
			public string fMediumName;
			public string fCodecName;
			public string fProtocolName;
			public uint fRTPTimestampFrequency;
			public string fControlPath;
			public in_addr._in_addr fSourceFilterAddr;
			public uint fBandwidth;
			public uint fAuxiliarydatasizelength;
			public uint fConstantduration;
			public uint fConstantsize;
			public uint fCRC;
			public uint fCtsdeltalength;
			public uint fDe_interleavebuffersize;
			public uint fDtsdeltalength;
			public uint fIndexdeltalength;
			public uint fIndexlength;
			public uint fInterleaving;
			public uint fMaxdisplacement;
			public uint fObjecttype;
			public uint fOctetalign;
			public uint fProfile_level_id;
			public uint fRobustsorting;
			public uint fSizelength;
			public uint fStreamstateindication;
			public uint fStreamtype;
			public uint fCpresent;
			public uint fRandomaccessindication;
			public string fConfig;
			public string fMode;
			public string fSpropParameterSets;
			public string fEmphasis;
			public string fChannelOrder;
			public double fPlayStartTime;
			public double fPlayEndTime;
			public ushort fVideoWidth;
			public ushort fVideoHeight;
			public uint fVideoFPS;
			public uint fNumChannels;
			public float fScale;
			public double fNPT_PTS_Offset;
			public Groupsock fRTPSocket;
			public Groupsock fRTCPSocket;
			public RTPSource fRTPSource;
			public RTCPInstance fRTCPInstance;
			public FramedSource fReadSource;
			public uint fReceiveRawMP3ADUs;
			public string fSessionId;
		}

		public ushort serverPortNum {
			get {
				return impl.serverPortNum [Native];
			}
			set {
				impl.serverPortNum [Native] = value;
			}
		}
		public char rtpChannelId {
			get {
				return impl.rtpChannelId [Native];
			}
			set {
				impl.rtpChannelId [Native] = value;
			}
		}
		public char rtcpChannelId {
			get {
				return impl.rtcpChannelId [Native];
			}
			set {
				impl.rtcpChannelId [Native] = value;
			}
		}
		public MediaSink sink {
			get {
				return impl.sink [Native];
			}
			set {
				impl.sink [Native] = value;
			}
		}
		public IntPtr miscPtr {
			get {
				return impl.miscPtr [Native];
			}
			set {
				impl.miscPtr [Native] = value;
			}
		}
		public IntPtr rtpInfo {
			get {
				return impl.rtpInfo [Native];
			}
			set {
				impl.rtpInfo [Native] = value;
			}
		}
		protected MediaSession fParent {
			get {
				return impl.fParent [Native];
			}
			set {
				impl.fParent [Native] = value;
			}
		}
		protected MediaSubsession fNext {
			get {
				return impl.fNext [Native];
			}
			set {
				impl.fNext [Native] = value;
			}
		}
		protected string fConnectionEndpointName {
			get {
				return impl.fConnectionEndpointName [Native];
			}
			set {
				impl.fConnectionEndpointName [Native] = value;
			}
		}
		protected ushort fClientPortNum {
			get {
				return impl.fClientPortNum [Native];
			}
			set {
				impl.fClientPortNum [Native] = value;
			}
		}
		protected char fRTPPayloadFormat {
			get {
				return impl.fRTPPayloadFormat [Native];
			}
			set {
				impl.fRTPPayloadFormat [Native] = value;
			}
		}
		protected string fSavedSDPLines {
			get {
				return impl.fSavedSDPLines [Native];
			}
			set {
				impl.fSavedSDPLines [Native] = value;
			}
		}
		protected string fMediumName {
			get {
				return impl.fMediumName [Native];
			}
			set {
				impl.fMediumName [Native] = value;
			}
		}
		protected string fCodecName {
			get {
				return impl.fCodecName [Native];
			}
			set {
				impl.fCodecName [Native] = value;
			}
		}
		protected string fProtocolName {
			get {
				return impl.fProtocolName [Native];
			}
			set {
				impl.fProtocolName [Native] = value;
			}
		}
		protected uint fRTPTimestampFrequency {
			get {
				return impl.fRTPTimestampFrequency [Native];
			}
			set {
				impl.fRTPTimestampFrequency [Native] = value;
			}
		}
		protected string fControlPath {
			get {
				return impl.fControlPath [Native];
			}
			set {
				impl.fControlPath [Native] = value;
			}
		}
		protected in_addr fSourceFilterAddr {
			get {
				return impl.fSourceFilterAddr [Native];
			}
			set {
				impl.fSourceFilterAddr [Native] = value;
			}
		}
		protected uint fBandwidth {
			get {
				return impl.fBandwidth [Native];
			}
			set {
				impl.fBandwidth [Native] = value;
			}
		}
		protected uint fAuxiliarydatasizelength {
			get {
				return impl.fAuxiliarydatasizelength [Native];
			}
			set {
				impl.fAuxiliarydatasizelength [Native] = value;
			}
		}
		protected uint fConstantduration {
			get {
				return impl.fConstantduration [Native];
			}
			set {
				impl.fConstantduration [Native] = value;
			}
		}
		protected uint fConstantsize {
			get {
				return impl.fConstantsize [Native];
			}
			set {
				impl.fConstantsize [Native] = value;
			}
		}
		protected uint fCRC {
			get {
				return impl.fCRC [Native];
			}
			set {
				impl.fCRC [Native] = value;
			}
		}
		protected uint fCtsdeltalength {
			get {
				return impl.fCtsdeltalength [Native];
			}
			set {
				impl.fCtsdeltalength [Native] = value;
			}
		}
		protected uint fDe_interleavebuffersize {
			get {
				return impl.fDe_interleavebuffersize [Native];
			}
			set {
				impl.fDe_interleavebuffersize [Native] = value;
			}
		}
		protected uint fDtsdeltalength {
			get {
				return impl.fDtsdeltalength [Native];
			}
			set {
				impl.fDtsdeltalength [Native] = value;
			}
		}
		protected uint fIndexdeltalength {
			get {
				return impl.fIndexdeltalength [Native];
			}
			set {
				impl.fIndexdeltalength [Native] = value;
			}
		}
		protected uint fIndexlength {
			get {
				return impl.fIndexlength [Native];
			}
			set {
				impl.fIndexlength [Native] = value;
			}
		}
		protected uint fInterleaving {
			get {
				return impl.fInterleaving [Native];
			}
			set {
				impl.fInterleaving [Native] = value;
			}
		}
		protected uint fMaxdisplacement {
			get {
				return impl.fMaxdisplacement [Native];
			}
			set {
				impl.fMaxdisplacement [Native] = value;
			}
		}
		protected uint fObjecttype {
			get {
				return impl.fObjecttype [Native];
			}
			set {
				impl.fObjecttype [Native] = value;
			}
		}
		protected uint fOctetalign {
			get {
				return impl.fOctetalign [Native];
			}
			set {
				impl.fOctetalign [Native] = value;
			}
		}
		protected uint fProfile_level_id {
			get {
				return impl.fProfile_level_id [Native];
			}
			set {
				impl.fProfile_level_id [Native] = value;
			}
		}
		protected uint fRobustsorting {
			get {
				return impl.fRobustsorting [Native];
			}
			set {
				impl.fRobustsorting [Native] = value;
			}
		}
		protected uint fSizelength {
			get {
				return impl.fSizelength [Native];
			}
			set {
				impl.fSizelength [Native] = value;
			}
		}
		protected uint fStreamstateindication {
			get {
				return impl.fStreamstateindication [Native];
			}
			set {
				impl.fStreamstateindication [Native] = value;
			}
		}
		protected uint fStreamtype {
			get {
				return impl.fStreamtype [Native];
			}
			set {
				impl.fStreamtype [Native] = value;
			}
		}
		protected uint fCpresent {
			get {
				return impl.fCpresent [Native];
			}
			set {
				impl.fCpresent [Native] = value;
			}
		}
		protected uint fRandomaccessindication {
			get {
				return impl.fRandomaccessindication [Native];
			}
			set {
				impl.fRandomaccessindication [Native] = value;
			}
		}
		protected string fConfig {
			get {
				return impl.fConfig [Native];
			}
			set {
				impl.fConfig [Native] = value;
			}
		}
		protected string fMode {
			get {
				return impl.fMode [Native];
			}
			set {
				impl.fMode [Native] = value;
			}
		}
		protected string fSpropParameterSets {
			get {
				return impl.fSpropParameterSets [Native];
			}
			set {
				impl.fSpropParameterSets [Native] = value;
			}
		}
		protected string fEmphasis {
			get {
				return impl.fEmphasis [Native];
			}
			set {
				impl.fEmphasis [Native] = value;
			}
		}
		protected string fChannelOrder {
			get {
				return impl.fChannelOrder [Native];
			}
			set {
				impl.fChannelOrder [Native] = value;
			}
		}
		protected double fPlayStartTime {
			get {
				return impl.fPlayStartTime [Native];
			}
			set {
				impl.fPlayStartTime [Native] = value;
			}
		}
		protected double fPlayEndTime {
			get {
				return impl.fPlayEndTime [Native];
			}
			set {
				impl.fPlayEndTime [Native] = value;
			}
		}
		protected ushort fVideoWidth {
			get {
				return impl.fVideoWidth [Native];
			}
			set {
				impl.fVideoWidth [Native] = value;
			}
		}
		protected ushort fVideoHeight {
			get {
				return impl.fVideoHeight [Native];
			}
			set {
				impl.fVideoHeight [Native] = value;
			}
		}
		protected uint fVideoFPS {
			get {
				return impl.fVideoFPS [Native];
			}
			set {
				impl.fVideoFPS [Native] = value;
			}
		}
		protected uint fNumChannels {
			get {
				return impl.fNumChannels [Native];
			}
			set {
				impl.fNumChannels [Native] = value;
			}
		}
		protected float fScale {
			get {
				return impl.fScale [Native];
			}
			set {
				impl.fScale [Native] = value;
			}
		}
		protected double fNPT_PTS_Offset {
			get {
				return impl.fNPT_PTS_Offset [Native];
			}
			set {
				impl.fNPT_PTS_Offset [Native] = value;
			}
		}
		protected Groupsock fRTPSocket {
			get {
				return impl.fRTPSocket [Native];
			}
			set {
				impl.fRTPSocket [Native] = value;
			}
		}
		protected Groupsock fRTCPSocket {
			get {
				return impl.fRTCPSocket [Native];
			}
			set {
				impl.fRTCPSocket [Native] = value;
			}
		}
		protected RTPSource fRTPSource {
			get {
				return impl.fRTPSource [Native];
			}
			set {
				impl.fRTPSource [Native] = value;
			}
		}
		protected RTCPInstance fRTCPInstance {
			get {
				return impl.fRTCPInstance [Native];
			}
			set {
				impl.fRTCPInstance [Native] = value;
			}
		}
		protected FramedSource fReadSource {
			get {
				return impl.fReadSource [Native];
			}
			set {
				impl.fReadSource [Native] = value;
			}
		}
		protected uint fReceiveRawMP3ADUs {
			get {
				return impl.fReceiveRawMP3ADUs [Native];
			}
			set {
				impl.fReceiveRawMP3ADUs [Native] = value;
			}
		}
		protected string fSessionId {
			get {
				return impl.fSessionId [Native];
			}
			set {
				impl.fSessionId [Native] = value;
			}
		}




		public MediaSubsession (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public MediaSubsession (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public MediaSession ParentSession ()
		{
			return impl.parentSession (Native);
		}
		public ByReference<float> Scale ()
		{
			return impl.scale (Native);
		}
		public RTPSource RtpSource ()
		{
			return impl.rtpSource (Native);
		}
		public RTCPInstance RtcpInstance ()
		{
			return impl.rtcpInstance (Native);
		}
		public FramedSource ReadSource ()
		{
			return impl.readSource (Native);
		}
		public void AddFilter (FramedFilter filter)
		{
			impl.addFilter (Native, filter);
		}
		public ByReference<double> _playStartTime ()
		{
			return impl._playStartTime (Native);
		}
		public ByReference<double> _playEndTime ()
		{
			return impl._playEndTime (Native);
		}
		public uint Initiate (int useSpecialRTPoffset)
		{
			return impl.initiate (Native, useSpecialRTPoffset);
		}
		public void DeInitiate ()
		{
			impl.deInitiate (Native);
		}
		public uint SetClientPortNum (ushort portNum)
		{
			return impl.setClientPortNum (Native, portNum);
		}
		public void ReceiveRawMP3ADUs ()
		{
			impl.receiveRawMP3ADUs (Native);
		}
		public string ConnectionEndpointName ()
		{
			return impl.connectionEndpointName (Native);
		}
		public void SetDestinations (uint defaultDestAddress)
		{
			impl.setDestinations (Native, defaultDestAddress);
		}
		public double GetNormalPlayTime (timeval presentationTime)
		{
			return impl.getNormalPlayTime (Native, presentationTime);
		}
		protected MediaSubsession (MediaSession parent)
		{
			__cxxi_LayoutClass ();
			Native = impl.MediaSubsession (impl.Alloc (this), parent);
		}
		protected UsageEnvironment Env ()
		{
			return impl.env (Native);
		}
		protected void SetNext (MediaSubsession next)
		{
			impl.setNext (Native, next);
		}
		protected uint ParseSDPLine_c (string sdpLine)
		{
			return impl.parseSDPLine_c (Native, sdpLine);
		}
		protected uint ParseSDPLine_b (string sdpLine)
		{
			return impl.parseSDPLine_b (Native, sdpLine);
		}
		protected uint ParseSDPAttribute_rtpmap (string sdpLine)
		{
			return impl.parseSDPAttribute_rtpmap (Native, sdpLine);
		}
		protected uint ParseSDPAttribute_control (string sdpLine)
		{
			return impl.parseSDPAttribute_control (Native, sdpLine);
		}
		protected uint ParseSDPAttribute_range (string sdpLine)
		{
			return impl.parseSDPAttribute_range (Native, sdpLine);
		}
		protected uint ParseSDPAttribute_fmtp (string sdpLine)
		{
			return impl.parseSDPAttribute_fmtp (Native, sdpLine);
		}
		protected uint ParseSDPAttribute_source_filter (string sdpLine)
		{
			return impl.parseSDPAttribute_source_filter (Native, sdpLine);
		}
		protected uint ParseSDPAttribute_x_dimensions (string sdpLine)
		{
			return impl.parseSDPAttribute_x_dimensions (Native, sdpLine);
		}
		protected uint ParseSDPAttribute_framerate (string sdpLine)
		{
			return impl.parseSDPAttribute_framerate (Native, sdpLine);
		}
		[OverrideNative ("createSourceObjects")]
		protected virtual uint CreateSourceObjects (int useSpecialRTPoffset)
		{
			return impl.createSourceObjects (Native, useSpecialRTPoffset);
		}

		public ushort ClientPortNum {
			get {
				return impl.clientPortNum (Native);
			}
		}

		public char RtpPayloadFormat {
			get {
				return impl.rtpPayloadFormat (Native);
			}
		}

		public string SavedSDPLines {
			get {
				return impl.savedSDPLines (Native);
			}
		}

		public string MediumName {
			get {
				return impl.mediumName (Native);
			}
		}

		public string CodecName {
			get {
				return impl.codecName (Native);
			}
		}

		public string ProtocolName {
			get {
				return impl.protocolName (Native);
			}
		}

		public string ControlPath {
			get {
				return impl.controlPath (Native);
			}
		}

		public uint IsSSM {
			get {
				return impl.isSSM (Native);
			}
		}

		public ushort VideoWidth {
			get {
				return impl.videoWidth (Native);
			}
		}

		public ushort VideoHeight {
			get {
				return impl.videoHeight (Native);
			}
		}

		public uint VideoFPS {
			get {
				return impl.videoFPS (Native);
			}
		}

		public uint NumChannels {
			get {
				return impl.numChannels (Native);
			}
		}

		public uint RtpTimestampFrequency {
			get {
				return impl.rtpTimestampFrequency (Native);
			}
		}

		public double PlayStartTime {
			get {
				return impl.playStartTime (Native);
			}
		}

		public double PlayEndTime {
			get {
				return impl.playEndTime (Native);
			}
		}

		public uint Bandwidth {
			get {
				return impl.bandwidth (Native);
			}
		}

		public uint Fmtp_auxiliarydatasizelength {
			get {
				return impl.fmtp_auxiliarydatasizelength (Native);
			}
		}

		public uint Fmtp_constantduration {
			get {
				return impl.fmtp_constantduration (Native);
			}
		}

		public uint Fmtp_constantsize {
			get {
				return impl.fmtp_constantsize (Native);
			}
		}

		public uint Fmtp_crc {
			get {
				return impl.fmtp_crc (Native);
			}
		}

		public uint Fmtp_ctsdeltalength {
			get {
				return impl.fmtp_ctsdeltalength (Native);
			}
		}

		public uint Fmtp_de_interleavebuffersize {
			get {
				return impl.fmtp_de_interleavebuffersize (Native);
			}
		}

		public uint Fmtp_dtsdeltalength {
			get {
				return impl.fmtp_dtsdeltalength (Native);
			}
		}

		public uint Fmtp_indexdeltalength {
			get {
				return impl.fmtp_indexdeltalength (Native);
			}
		}

		public uint Fmtp_indexlength {
			get {
				return impl.fmtp_indexlength (Native);
			}
		}

		public uint Fmtp_interleaving {
			get {
				return impl.fmtp_interleaving (Native);
			}
		}

		public uint Fmtp_maxdisplacement {
			get {
				return impl.fmtp_maxdisplacement (Native);
			}
		}

		public uint Fmtp_objecttype {
			get {
				return impl.fmtp_objecttype (Native);
			}
		}

		public uint Fmtp_octetalign {
			get {
				return impl.fmtp_octetalign (Native);
			}
		}

		public uint Fmtp_profile_level_id {
			get {
				return impl.fmtp_profile_level_id (Native);
			}
		}

		public uint Fmtp_robustsorting {
			get {
				return impl.fmtp_robustsorting (Native);
			}
		}

		public uint Fmtp_sizelength {
			get {
				return impl.fmtp_sizelength (Native);
			}
		}

		public uint Fmtp_streamstateindication {
			get {
				return impl.fmtp_streamstateindication (Native);
			}
		}

		public uint Fmtp_streamtype {
			get {
				return impl.fmtp_streamtype (Native);
			}
		}

		public uint Fmtp_cpresent {
			get {
				return impl.fmtp_cpresent (Native);
			}
		}

		public uint Fmtp_randomaccessindication {
			get {
				return impl.fmtp_randomaccessindication (Native);
			}
		}

		public string Fmtp_config {
			get {
				return impl.fmtp_config (Native);
			}
		}

		public string Fmtp_configuration {
			get {
				return impl.fmtp_configuration (Native);
			}
		}

		public string Fmtp_mode {
			get {
				return impl.fmtp_mode (Native);
			}
		}

		public string Fmtp_spropparametersets {
			get {
				return impl.fmtp_spropparametersets (Native);
			}
		}

		public string Fmtp_emphasis {
			get {
				return impl.fmtp_emphasis (Native);
			}
		}

		public string Fmtp_channelorder {
			get {
				return impl.fmtp_channelorder (Native);
			}
		}

		public uint ConnectionEndpointAddress {
			get {
				return impl.connectionEndpointAddress (Native);
			}
		}

		public string SessionId {
			get {
				return impl.sessionId (Native);
			}
			set {
				impl.setSessionId (Native, value);
			}
		}


		partial void BeforeDestruct ();
		partial void AfterDestruct ();

		public virtual void Dispose ()
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

