// -------------------------------------------------------------------------
//  Managed wrapper for RTPSource
//  Generated from RTSPClient.xml on 05/08/2012 20:36:35
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class RTPSource : FramedSource {

		private static readonly IRTPSource impl = Libs.live555.GetClass<IRTPSource,_RTPSource,RTPSource> ("RTPSource");
		public static bool operator!=(RTPSource a, RTPSource b) { return !(a == b); }
		public static bool operator==(RTPSource a, RTPSource b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as RTPSource); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class RTPSource")]
		public partial interface IRTPSource : ICppClassOverridable<RTPSource> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr RTPSource (CppInstancePtr @this, [MangleAs ("class RTPSource const &")] RTPSource arg0);
			[Static] [return: MangleAs ("int  unsigned")] uint lookupByName ([MangleAs ("class UsageEnvironment &")] UsageEnvironment env, [MangleAs ("char  const *")] string sourceName, [MangleAs ("class RTPSource * &")] RTPSource resultSource);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint curPacketMarkerBit (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  unsigned")] char rtpPayloadFormat (CppInstancePtr @this);
			[Virtual] [return: MangleAs ("int  unsigned")] uint hasBeenSynchronizedUsingRTCP (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("class Groupsock *")] Groupsock RTPgs (CppInstancePtr @this);
			[Virtual] void setPacketReorderingThresholdTime (CppInstancePtr @this, uint uSeconds);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint SSRC (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint timestampFrequency (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("class RTPReceptionStatsDB &")] RTPReceptionStatsDB receptionStatsDB (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint lastReceivedSSRC (CppInstancePtr @this);
			[Inline] void setStreamSocket (CppInstancePtr @this, int sockNum, [MangleAs ("char  unsigned")] char streamChannelId);
			[Inline] void setServerRequestAlternativeByteHandler (CppInstancePtr @this, int socketNum, [MangleAs ("delegate ServerRequestAlternativeByteHandler *")] ServerRequestAlternativeByteHandler handler, [MangleAs ("void  *")] IntPtr clientData);
			[Inline] void setAuxilliaryReadHandler (CppInstancePtr @this, [MangleAs ("delegate AuxHandlerFunc *")] AuxHandlerFunc handlerFunc, [MangleAs ("void  *")] IntPtr handlerClientData);
			[Inline] [Const] [return: MangleAs ("int  short unsigned")] ushort curPacketRTPSeqNum (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint curPacketRTPTimestamp (CppInstancePtr @this);
			[Constructor] [Protected] CppInstancePtr RTPSource (CppInstancePtr @this, [MangleAs ("class UsageEnvironment &")] UsageEnvironment env, [MangleAs ("class Groupsock *")] Groupsock RTPgs, [MangleAs ("char  unsigned")] char rtpPayloadFormat, [MangleAs ("int  unsigned")] uint rtpTimestampFrequency);
			[Virtual] [Destructor] [Protected] void Destruct (CppInstancePtr @this);
			CppField<RTPInterface> fRTPInterface { get; }
			CppField<ushort> fCurPacketRTPSeqNum { get; }
			CppField<uint> fCurPacketRTPTimestamp { get; }
			CppField<uint> fCurPacketMarkerBit { get; }
			CppField<uint> fCurPacketHasBeenSynchronizedUsingRTCP { get; }
			CppField<uint> fLastReceivedSSRC { get; }
		}
		public unsafe struct _RTPSource {
			public RTPInterface._RTPInterface fRTPInterface;
			public ushort fCurPacketRTPSeqNum;
			public uint fCurPacketRTPTimestamp;
			public uint fCurPacketMarkerBit;
			public uint fCurPacketHasBeenSynchronizedUsingRTCP;
			public uint fLastReceivedSSRC;
			public char fRTPPayloadFormat;
			public uint fTimestampFrequency;
			public uint fSSRC;
			public RTPReceptionStatsDB fReceptionStatsDB;
		}

		protected RTPInterface fRTPInterface {
			get {
				return impl.fRTPInterface [Native];
			}
			set {
				impl.fRTPInterface [Native] = value;
			}
		}
		protected ushort fCurPacketRTPSeqNum {
			get {
				return impl.fCurPacketRTPSeqNum [Native];
			}
			set {
				impl.fCurPacketRTPSeqNum [Native] = value;
			}
		}
		protected uint fCurPacketRTPTimestamp {
			get {
				return impl.fCurPacketRTPTimestamp [Native];
			}
			set {
				impl.fCurPacketRTPTimestamp [Native] = value;
			}
		}
		protected uint fCurPacketMarkerBit {
			get {
				return impl.fCurPacketMarkerBit [Native];
			}
			set {
				impl.fCurPacketMarkerBit [Native] = value;
			}
		}
		protected uint fCurPacketHasBeenSynchronizedUsingRTCP {
			get {
				return impl.fCurPacketHasBeenSynchronizedUsingRTCP [Native];
			}
			set {
				impl.fCurPacketHasBeenSynchronizedUsingRTCP [Native] = value;
			}
		}
		protected uint fLastReceivedSSRC {
			get {
				return impl.fLastReceivedSSRC [Native];
			}
			set {
				impl.fLastReceivedSSRC [Native] = value;
			}
		}




		public RTPSource (CppTypeInfo subClass)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public RTPSource (CppInstancePtr native)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public static uint LookupByName (UsageEnvironment env, string sourceName, RTPSource resultSource)
		{
			return impl.lookupByName (env, sourceName, resultSource);
		}
		[OverrideNative ("hasBeenSynchronizedUsingRTCP")]
		public virtual uint HasBeenSynchronizedUsingRTCP ()
		{
			return impl.hasBeenSynchronizedUsingRTCP (Native);
		}
		[OverrideNative ("setPacketReorderingThresholdTime")]
		public virtual void SetPacketReorderingThresholdTime (uint uSeconds)
		{
			impl.setPacketReorderingThresholdTime (Native, uSeconds);
		}
		public void SetStreamSocket (int sockNum, char streamChannelId)
		{
			impl.setStreamSocket (Native, sockNum, streamChannelId);
		}
		public void SetServerRequestAlternativeByteHandler (int socketNum, ServerRequestAlternativeByteHandler handler, IntPtr clientData)
		{
			impl.setServerRequestAlternativeByteHandler (Native, socketNum, new WeakDelegate<ServerRequestAlternativeByteHandler>(handler), clientData);
		}
		public void SetAuxilliaryReadHandler (AuxHandlerFunc handlerFunc, IntPtr handlerClientData)
		{
			impl.setAuxilliaryReadHandler (Native, new WeakDelegate<AuxHandlerFunc>(handlerFunc), handlerClientData);
		}
		protected RTPSource (UsageEnvironment env, Groupsock RTPgs, char rtpPayloadFormat, uint rtpTimestampFrequency)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = impl.RTPSource (impl.Alloc (this), env, RTPgs, rtpPayloadFormat, rtpTimestampFrequency);
		}

		public uint CurPacketMarkerBit {
			get {
				return impl.curPacketMarkerBit (Native);
			}
		}

		public char RtpPayloadFormat {
			get {
				return impl.rtpPayloadFormat (Native);
			}
		}

		public Groupsock RTPgs {
			get {
				return impl.RTPgs (Native);
			}
		}

		public uint SSRC {
			get {
				return impl.SSRC (Native);
			}
		}

		public uint TimestampFrequency {
			get {
				return impl.timestampFrequency (Native);
			}
		}

		public RTPReceptionStatsDB ReceptionStatsDB {
			get {
				return impl.receptionStatsDB (Native);
			}
		}

		public uint LastReceivedSSRC {
			get {
				return impl.lastReceivedSSRC (Native);
			}
		}

		public ushort CurPacketRTPSeqNum {
			get {
				return impl.curPacketRTPSeqNum (Native);
			}
		}

		public uint CurPacketRTPTimestamp {
			get {
				return impl.curPacketRTPTimestamp (Native);
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

