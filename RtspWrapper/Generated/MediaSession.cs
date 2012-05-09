// -------------------------------------------------------------------------
//  Managed wrapper for MediaSession
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class MediaSession : Medium {

		private static readonly IMediaSession impl = Libs.live555.GetClass<IMediaSession,_MediaSession,MediaSession> ("MediaSession");
		public static bool operator!=(MediaSession a, MediaSession b) { return !(a == b); }
		public static bool operator==(MediaSession a, MediaSession b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as MediaSession); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class MediaSession")]
		public partial interface IMediaSession : ICppClassOverridable<MediaSession> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr MediaSession (CppInstancePtr @this, [MangleAs ("class MediaSession const &")] MediaSession arg0);
			[Static] [return: MangleAs ("class MediaSession *")] MediaSession createNew ([MangleAs ("class UsageEnvironment &")] UsageEnvironment env, [MangleAs ("char  const *")] string sdpDescription);
			[Static] [return: MangleAs ("int  unsigned")] uint lookupByName ([MangleAs ("class UsageEnvironment &")] UsageEnvironment env, [MangleAs ("char  const *")] string sourceName, [MangleAs ("class MediaSession * &")] MediaSession resultSession);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint hasSubsessions (CppInstancePtr @this);
			[Inline] [return: MangleAs ("double  &")] [return: ByRef] IntPtr  playStartTime (CppInstancePtr @this);
			[Inline] [return: MangleAs ("double  &")] [return: ByRef] IntPtr  playEndTime (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  *")] string connectionEndpointName (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  const *")] string CNAME (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("struct in_addr const &")] in_addr sourceFilterAddr (CppInstancePtr @this);
			[Inline] [return: MangleAs ("float  &")] [return: ByRef] IntPtr  scale (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  *")] string mediaSessionType (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  *")] string sessionName (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  *")] string sessionDescription (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  const *")] string controlPath (CppInstancePtr @this);
			[return: MangleAs ("int  unsigned")] uint initiateByMediaType (CppInstancePtr @this, [MangleAs ("char  const *")] string mimeType, [MangleAs ("class MediaSubsession * &")] MediaSubsession resultSubsession, int useSpecialRTPoffset);
			[Constructor] [Protected] CppInstancePtr MediaSession (CppInstancePtr @this, [MangleAs ("class UsageEnvironment &")] UsageEnvironment env);
			[Virtual] [Destructor] [Protected] void Destruct (CppInstancePtr @this);
			[Virtual] [Protected] [return: MangleAs ("class MediaSubsession *")] MediaSubsession createNewMediaSubsession (CppInstancePtr @this);
			[Protected] [return: MangleAs ("int  unsigned")] uint initializeWithSDP (CppInstancePtr @this, [MangleAs ("char  const *")] string sdpDescription);
			[Protected] [return: MangleAs ("int  unsigned")] uint parseSDPLine (CppInstancePtr @this, [MangleAs ("char  const *")] string input, [MangleAs ("char  const * &")] string nextLine);
			[Protected] [return: MangleAs ("int  unsigned")] uint parseSDPLine_s (CppInstancePtr @this, [MangleAs ("char  const *")] string sdpLine);
			[Protected] [return: MangleAs ("int  unsigned")] uint parseSDPLine_i (CppInstancePtr @this, [MangleAs ("char  const *")] string sdpLine);
			[Protected] [return: MangleAs ("int  unsigned")] uint parseSDPLine_c (CppInstancePtr @this, [MangleAs ("char  const *")] string sdpLine);
			[Protected] [return: MangleAs ("int  unsigned")] uint parseSDPAttribute_type (CppInstancePtr @this, [MangleAs ("char  const *")] string sdpLine);
			[Protected] [return: MangleAs ("int  unsigned")] uint parseSDPAttribute_control (CppInstancePtr @this, [MangleAs ("char  const *")] string sdpLine);
			[Protected] [return: MangleAs ("int  unsigned")] uint parseSDPAttribute_range (CppInstancePtr @this, [MangleAs ("char  const *")] string sdpLine);
			[Protected] [return: MangleAs ("int  unsigned")] uint parseSDPAttribute_source_filter (CppInstancePtr @this, [MangleAs ("char  const *")] string sdpLine);
			[Static] [Protected] [return: MangleAs ("char  *")] string lookupPayloadFormat ([MangleAs ("char  unsigned")] char rtpPayloadType, [MangleAs ("int  unsigned &")] ref uint rtpTimestampFrequency, [MangleAs ("int  unsigned &")] ref uint numChannels);
			[Static] [Protected] [return: MangleAs ("int  unsigned")] uint guessRTPTimestampFrequency ([MangleAs ("char  const *")] string mediumName, [MangleAs ("char  const *")] string codecName);
			CppField<string> fCNAME { get; }
			CppField<MediaSubsession> fSubsessionsHead { get; }
			CppField<MediaSubsession> fSubsessionsTail { get; }
			CppField<string> fConnectionEndpointName { get; }
			CppField<double> fMaxPlayStartTime { get; }
			CppField<double> fMaxPlayEndTime { get; }
			CppField<in_addr> fSourceFilterAddr { get; }
			CppField<float> fScale { get; }
			CppField<string> fMediaSessionType { get; }
			CppField<string> fSessionName { get; }
			CppField<string> fSessionDescription { get; }
			CppField<string> fControlPath { get; }
		}
		public unsafe struct _MediaSession {
			public string fCNAME;
			public MediaSubsession fSubsessionsHead;
			public MediaSubsession fSubsessionsTail;
			public string fConnectionEndpointName;
			public double fMaxPlayStartTime;
			public double fMaxPlayEndTime;
			public in_addr._in_addr fSourceFilterAddr;
			public float fScale;
			public string fMediaSessionType;
			public string fSessionName;
			public string fSessionDescription;
			public string fControlPath;
		}

		protected string fCNAME {
			get {
				return impl.fCNAME [Native];
			}
			set {
				impl.fCNAME [Native] = value;
			}
		}
		protected MediaSubsession fSubsessionsHead {
			get {
				return impl.fSubsessionsHead [Native];
			}
			set {
				impl.fSubsessionsHead [Native] = value;
			}
		}
		protected MediaSubsession fSubsessionsTail {
			get {
				return impl.fSubsessionsTail [Native];
			}
			set {
				impl.fSubsessionsTail [Native] = value;
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
		protected double fMaxPlayStartTime {
			get {
				return impl.fMaxPlayStartTime [Native];
			}
			set {
				impl.fMaxPlayStartTime [Native] = value;
			}
		}
		protected double fMaxPlayEndTime {
			get {
				return impl.fMaxPlayEndTime [Native];
			}
			set {
				impl.fMaxPlayEndTime [Native] = value;
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
		protected float fScale {
			get {
				return impl.fScale [Native];
			}
			set {
				impl.fScale [Native] = value;
			}
		}
		protected string fMediaSessionType {
			get {
				return impl.fMediaSessionType [Native];
			}
			set {
				impl.fMediaSessionType [Native] = value;
			}
		}
		protected string fSessionName {
			get {
				return impl.fSessionName [Native];
			}
			set {
				impl.fSessionName [Native] = value;
			}
		}
		protected string fSessionDescription {
			get {
				return impl.fSessionDescription [Native];
			}
			set {
				impl.fSessionDescription [Native] = value;
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




		public MediaSession (CppTypeInfo subClass)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public MediaSession (CppInstancePtr native)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public static MediaSession CreateNew (UsageEnvironment env, string sdpDescription)
		{
			return impl.createNew (env, sdpDescription);
		}
		public static uint LookupByName (UsageEnvironment env, string sourceName, MediaSession resultSession)
		{
			return impl.lookupByName (env, sourceName, resultSession);
		}
		public ByReference<double> PlayStartTime ()
		{
			return impl.playStartTime (Native);
		}
		public ByReference<double> PlayEndTime ()
		{
			return impl.playEndTime (Native);
		}
		public ByReference<float> Scale ()
		{
			return impl.scale (Native);
		}
		public uint InitiateByMediaType (string mimeType, MediaSubsession resultSubsession, int useSpecialRTPoffset)
		{
			return impl.initiateByMediaType (Native, mimeType, resultSubsession, useSpecialRTPoffset);
		}
		protected MediaSession (UsageEnvironment env)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = impl.MediaSession (impl.Alloc (this), env);
		}
		[OverrideNative ("createNewMediaSubsession")]
		protected virtual MediaSubsession CreateNewMediaSubsession ()
		{
			return impl.createNewMediaSubsession (Native);
		}
		protected uint InitializeWithSDP (string sdpDescription)
		{
			return impl.initializeWithSDP (Native, sdpDescription);
		}
		protected uint ParseSDPLine (string input, string nextLine)
		{
			return impl.parseSDPLine (Native, input, nextLine);
		}
		protected uint ParseSDPLine_s (string sdpLine)
		{
			return impl.parseSDPLine_s (Native, sdpLine);
		}
		protected uint ParseSDPLine_i (string sdpLine)
		{
			return impl.parseSDPLine_i (Native, sdpLine);
		}
		protected uint ParseSDPLine_c (string sdpLine)
		{
			return impl.parseSDPLine_c (Native, sdpLine);
		}
		protected uint ParseSDPAttribute_type (string sdpLine)
		{
			return impl.parseSDPAttribute_type (Native, sdpLine);
		}
		protected uint ParseSDPAttribute_control (string sdpLine)
		{
			return impl.parseSDPAttribute_control (Native, sdpLine);
		}
		protected uint ParseSDPAttribute_range (string sdpLine)
		{
			return impl.parseSDPAttribute_range (Native, sdpLine);
		}
		protected uint ParseSDPAttribute_source_filter (string sdpLine)
		{
			return impl.parseSDPAttribute_source_filter (Native, sdpLine);
		}
		protected static string LookupPayloadFormat (char rtpPayloadType, ref uint rtpTimestampFrequency, ref uint numChannels)
		{
			return impl.lookupPayloadFormat (rtpPayloadType, ref rtpTimestampFrequency, ref numChannels);
		}
		protected static uint GuessRTPTimestampFrequency (string mediumName, string codecName)
		{
			return impl.guessRTPTimestampFrequency (mediumName, codecName);
		}

		public uint HasSubsessions {
			get {
				return impl.hasSubsessions (Native);
			}
		}

		public string ConnectionEndpointName {
			get {
				return impl.connectionEndpointName (Native);
			}
		}

		public string CNAME {
			get {
				return impl.CNAME (Native);
			}
		}

		public in_addr SourceFilterAddr {
			get {
				return impl.sourceFilterAddr (Native);
			}
		}

		public string MediaSessionType {
			get {
				return impl.mediaSessionType (Native);
			}
		}

		public string SessionName {
			get {
				return impl.sessionName (Native);
			}
		}

		public string SessionDescription {
			get {
				return impl.sessionDescription (Native);
			}
		}

		public string ControlPath {
			get {
				return impl.controlPath (Native);
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

