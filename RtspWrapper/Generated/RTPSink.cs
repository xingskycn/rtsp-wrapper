// -------------------------------------------------------------------------
//  Managed wrapper for RTPSink
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class RTPSink : MediaSink {

		private static readonly IRTPSink impl = Libs.live555.GetClass<IRTPSink,_RTPSink,RTPSink> ("RTPSink");
		public static bool operator!=(RTPSink a, RTPSink b) { return !(a == b); }
		public static bool operator==(RTPSink a, RTPSink b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as RTPSink); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class RTPSink")]
		public partial interface IRTPSink : ICppClassOverridable<RTPSink> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr RTPSink (CppInstancePtr @this, [MangleAs ("class RTPSink const &")] RTPSink arg0);
			[Static] [return: MangleAs ("int  unsigned")] uint lookupByName ([MangleAs ("class UsageEnvironment &")] UsageEnvironment env, [MangleAs ("char  const *")] string sinkName, [MangleAs ("class RTPSink * &")] RTPSink resultSink);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint SSRC (CppInstancePtr @this);
			[return: MangleAs ("int  unsigned")] uint convertToRTPTimestamp (CppInstancePtr @this, [MangleAs ("struct timeval")] [ByVal] timeval tv);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint packetCount (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint octetCount (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("class Groupsock const &")] Groupsock groupsockBeingUsed (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  unsigned")] char rtpPayloadType (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint rtpTimestampFrequency (CppInstancePtr @this);
			[Inline] void setRTPTimestampFrequency (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint freq);
			[Inline] [Const] [return: MangleAs ("char  const *")] string rtpPayloadFormatName (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint numChannels (CppInstancePtr @this);
			[Virtual] [Const] [return: MangleAs ("char  const *")] string sdpMediaType (CppInstancePtr @this);
			[Virtual] [Const] [return: MangleAs ("char  *")] string rtpmapLine (CppInstancePtr @this);
			[Virtual] [return: MangleAs ("char  const *")] string auxSDPLine (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  short unsigned")] ushort currentSeqNo (CppInstancePtr @this);
			[return: MangleAs ("int  unsigned")] uint presetNextTimestamp (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("class RTPTransmissionStatsDB &")] RTPTransmissionStatsDB transmissionStatsDB (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint nextTimestampHasBeenPreset (CppInstancePtr @this);
			[Inline] void setStreamSocket (CppInstancePtr @this, int sockNum, [MangleAs ("char  unsigned")] char streamChannelId);
			[Inline] void addStreamSocket (CppInstancePtr @this, int sockNum, [MangleAs ("char  unsigned")] char streamChannelId);
			[Inline] void removeStreamSocket (CppInstancePtr @this, int sockNum, [MangleAs ("char  unsigned")] char streamChannelId);
			[Inline] void setServerRequestAlternativeByteHandler (CppInstancePtr @this, int socketNum, [MangleAs ("delegate ServerRequestAlternativeByteHandler *")] ServerRequestAlternativeByteHandler handler, [MangleAs ("void  *")] IntPtr clientData);
			void getTotalBitrate (CppInstancePtr @this, [MangleAs ("int  unsigned &")] ref uint outNumBytes, [MangleAs ("double  &")] ref double outElapsedTime);
			[Constructor] [Protected] CppInstancePtr RTPSink (CppInstancePtr @this, [MangleAs ("class UsageEnvironment &")] UsageEnvironment env, [MangleAs ("class Groupsock *")] Groupsock rtpGS, [MangleAs ("char  unsigned")] char rtpPayloadType, [MangleAs ("int  unsigned")] uint rtpTimestampFrequency, [MangleAs ("char  const *")] string rtpPayloadFormatName, [MangleAs ("int  unsigned")] uint numChannels);
			[Virtual] [Destructor] [Protected] void Destruct (CppInstancePtr @this);
			CppField<RTPInterface> fRTPInterface { get; }
			CppField<char> fRTPPayloadType { get; }
			CppField<uint> fPacketCount { get; }
			CppField<uint> fOctetCount { get; }
			CppField<uint> fTotalOctetCount { get; }
			CppField<timeval> fTotalOctetCountStartTime { get; }
			CppField<uint> fCurrentTimestamp { get; }
			CppField<ushort> fSeqNo { get; }
		}
		public unsafe struct _RTPSink {
			public RTPInterface._RTPInterface fRTPInterface;
			public char fRTPPayloadType;
			public uint fPacketCount;
			public uint fOctetCount;
			public uint fTotalOctetCount;
			public timeval._timeval fTotalOctetCountStartTime;
			public uint fCurrentTimestamp;
			public ushort fSeqNo;
			public uint fSSRC;
			public uint fTimestampBase;
			public uint fTimestampFrequency;
			public uint fNextTimestampHasBeenPreset;
			public string fRTPPayloadFormatName;
			public uint fNumChannels;
			public timeval._timeval fCreationTime;
			public RTPTransmissionStatsDB fTransmissionStatsDB;
		}

		protected RTPInterface fRTPInterface {
			get {
				return impl.fRTPInterface [Native];
			}
			set {
				impl.fRTPInterface [Native] = value;
			}
		}
		protected char fRTPPayloadType {
			get {
				return impl.fRTPPayloadType [Native];
			}
			set {
				impl.fRTPPayloadType [Native] = value;
			}
		}
		protected uint fPacketCount {
			get {
				return impl.fPacketCount [Native];
			}
			set {
				impl.fPacketCount [Native] = value;
			}
		}
		protected uint fOctetCount {
			get {
				return impl.fOctetCount [Native];
			}
			set {
				impl.fOctetCount [Native] = value;
			}
		}
		protected uint fTotalOctetCount {
			get {
				return impl.fTotalOctetCount [Native];
			}
			set {
				impl.fTotalOctetCount [Native] = value;
			}
		}
		protected timeval fTotalOctetCountStartTime {
			get {
				return impl.fTotalOctetCountStartTime [Native];
			}
			set {
				impl.fTotalOctetCountStartTime [Native] = value;
			}
		}
		protected uint fCurrentTimestamp {
			get {
				return impl.fCurrentTimestamp [Native];
			}
			set {
				impl.fCurrentTimestamp [Native] = value;
			}
		}
		protected ushort fSeqNo {
			get {
				return impl.fSeqNo [Native];
			}
			set {
				impl.fSeqNo [Native] = value;
			}
		}




		public RTPSink (CppTypeInfo subClass)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public RTPSink (CppInstancePtr native)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public static uint LookupByName (UsageEnvironment env, string sinkName, RTPSink resultSink)
		{
			return impl.lookupByName (env, sinkName, resultSink);
		}
		public uint ConvertToRTPTimestamp (timeval tv)
		{
			return impl.convertToRTPTimestamp (Native, tv);
		}
		public Groupsock GroupsockBeingUsed ()
		{
			return impl.groupsockBeingUsed (Native);
		}
		public void SetRTPTimestampFrequency (uint freq)
		{
			impl.setRTPTimestampFrequency (Native, freq);
		}
		[OverrideNative ("auxSDPLine")]
		public virtual string AuxSDPLine ()
		{
			return impl.auxSDPLine (Native);
		}
		public uint PresetNextTimestamp ()
		{
			return impl.presetNextTimestamp (Native);
		}
		public void SetStreamSocket (int sockNum, char streamChannelId)
		{
			impl.setStreamSocket (Native, sockNum, streamChannelId);
		}
		public void AddStreamSocket (int sockNum, char streamChannelId)
		{
			impl.addStreamSocket (Native, sockNum, streamChannelId);
		}
		public void RemoveStreamSocket (int sockNum, char streamChannelId)
		{
			impl.removeStreamSocket (Native, sockNum, streamChannelId);
		}
		public void SetServerRequestAlternativeByteHandler (int socketNum, ServerRequestAlternativeByteHandler handler, IntPtr clientData)
		{
			impl.setServerRequestAlternativeByteHandler (Native, socketNum, new WeakDelegate<ServerRequestAlternativeByteHandler>(handler), clientData);
		}
		public void GetTotalBitrate (ref uint outNumBytes, ref double outElapsedTime)
		{
			impl.getTotalBitrate (Native, ref outNumBytes, ref outElapsedTime);
		}
		protected RTPSink (UsageEnvironment env, Groupsock rtpGS, char rtpPayloadType, uint rtpTimestampFrequency, string rtpPayloadFormatName, uint numChannels)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = impl.RTPSink (impl.Alloc (this), env, rtpGS, rtpPayloadType, rtpTimestampFrequency, rtpPayloadFormatName, numChannels);
		}

		public uint SSRC {
			get {
				return impl.SSRC (Native);
			}
		}

		public uint PacketCount {
			get {
				return impl.packetCount (Native);
			}
		}

		public uint OctetCount {
			get {
				return impl.octetCount (Native);
			}
		}

		public char RtpPayloadType {
			get {
				return impl.rtpPayloadType (Native);
			}
		}

		public uint RtpTimestampFrequency {
			get {
				return impl.rtpTimestampFrequency (Native);
			}
		}

		public string RtpPayloadFormatName {
			get {
				return impl.rtpPayloadFormatName (Native);
			}
		}

		public uint NumChannels {
			get {
				return impl.numChannels (Native);
			}
		}

		public virtual string SdpMediaType {
			[OverrideNative ("sdpMediaType")] get {
				return impl.sdpMediaType (Native);
			}
		}

		public virtual string RtpmapLine {
			[OverrideNative ("rtpmapLine")] get {
				return impl.rtpmapLine (Native);
			}
		}

		public ushort CurrentSeqNo {
			get {
				return impl.currentSeqNo (Native);
			}
		}

		public RTPTransmissionStatsDB TransmissionStatsDB {
			get {
				return impl.transmissionStatsDB (Native);
			}
		}

		public uint NextTimestampHasBeenPreset {
			get {
				return impl.nextTimestampHasBeenPreset (Native);
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

