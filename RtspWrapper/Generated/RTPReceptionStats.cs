// -------------------------------------------------------------------------
//  Managed wrapper for RTPReceptionStats
//  Generated from RTSPClient.xml on 05/08/2012 20:36:35
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class RTPReceptionStats : ICppObject {

		private static readonly IRTPReceptionStats impl = Libs.live555.GetClass<IRTPReceptionStats,_RTPReceptionStats,RTPReceptionStats> ("RTPReceptionStats");
		public CppInstancePtr Native { get; protected set; }
		public static bool operator!=(RTPReceptionStats a, RTPReceptionStats b) { return !(a == b); }
		public static bool operator==(RTPReceptionStats a, RTPReceptionStats b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as RTPReceptionStats); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class RTPReceptionStats")]
		public partial interface IRTPReceptionStats : ICppClassOverridable<RTPReceptionStats> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr RTPReceptionStats (CppInstancePtr @this, [MangleAs ("class RTPReceptionStats const &")] RTPReceptionStats arg0);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint SSRC (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint numPacketsReceivedSinceLastReset (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint totNumPacketsReceived (CppInstancePtr @this);
			[Const] double totNumKBytesReceived (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint totNumPacketsExpected (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint baseExtSeqNumReceived (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint lastResetExtSeqNumReceived (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint highestExtSeqNumReceived (CppInstancePtr @this);
			[Const] [return: MangleAs ("int  unsigned")] uint jitter (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint lastReceivedSR_NTPmsw (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint lastReceivedSR_NTPlsw (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("struct timeval const &")] timeval lastReceivedSR_time (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint minInterPacketGapUS (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint maxInterPacketGapUS (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("struct timeval const &")] timeval totalInterPacketGaps (CppInstancePtr @this);
			[Constructor] [Protected] CppInstancePtr RTPReceptionStats (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint SSRC, [MangleAs ("int  short unsigned")] ushort initialSeqNum);
			[Constructor] [Protected] CppInstancePtr RTPReceptionStats (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint SSRC);
			[Virtual] [Destructor] [Protected] void Destruct (CppInstancePtr @this);
			CppField<uint> fSSRC { get; }
			CppField<uint> fNumPacketsReceivedSinceLastReset { get; }
			CppField<uint> fTotNumPacketsReceived { get; }
			CppField<uint> fTotBytesReceived_hi { get; }
			CppField<uint> fTotBytesReceived_lo { get; }
			CppField<uint> fHaveSeenInitialSequenceNumber { get; }
			CppField<uint> fBaseExtSeqNumReceived { get; }
			CppField<uint> fLastResetExtSeqNumReceived { get; }
			CppField<uint> fHighestExtSeqNumReceived { get; }
			CppField<int> fLastTransit { get; }
			CppField<uint> fPreviousPacketRTPTimestamp { get; }
			CppField<double> fJitter { get; }
			CppField<uint> fLastReceivedSR_NTPmsw { get; }
			CppField<uint> fLastReceivedSR_NTPlsw { get; }
			CppField<timeval> fLastReceivedSR_time { get; }
			CppField<timeval> fLastPacketReceptionTime { get; }
			CppField<uint> fMinInterPacketGapUS { get; }
			CppField<uint> fMaxInterPacketGapUS { get; }
			CppField<timeval> fTotalInterPacketGaps { get; }
		}
		public unsafe struct _RTPReceptionStats {
			public uint fSSRC;
			public uint fNumPacketsReceivedSinceLastReset;
			public uint fTotNumPacketsReceived;
			public uint fTotBytesReceived_hi;
			public uint fTotBytesReceived_lo;
			public uint fHaveSeenInitialSequenceNumber;
			public uint fBaseExtSeqNumReceived;
			public uint fLastResetExtSeqNumReceived;
			public uint fHighestExtSeqNumReceived;
			public int fLastTransit;
			public uint fPreviousPacketRTPTimestamp;
			public double fJitter;
			public uint fLastReceivedSR_NTPmsw;
			public uint fLastReceivedSR_NTPlsw;
			public timeval._timeval fLastReceivedSR_time;
			public timeval._timeval fLastPacketReceptionTime;
			public uint fMinInterPacketGapUS;
			public uint fMaxInterPacketGapUS;
			public timeval._timeval fTotalInterPacketGaps;
			public uint fHasBeenSynchronized;
			public uint fSyncTimestamp;
			public timeval._timeval fSyncTime;
		}

		protected uint fSSRC {
			get {
				return impl.fSSRC [Native];
			}
			set {
				impl.fSSRC [Native] = value;
			}
		}
		protected uint fNumPacketsReceivedSinceLastReset {
			get {
				return impl.fNumPacketsReceivedSinceLastReset [Native];
			}
			set {
				impl.fNumPacketsReceivedSinceLastReset [Native] = value;
			}
		}
		protected uint fTotNumPacketsReceived {
			get {
				return impl.fTotNumPacketsReceived [Native];
			}
			set {
				impl.fTotNumPacketsReceived [Native] = value;
			}
		}
		protected uint fTotBytesReceived_hi {
			get {
				return impl.fTotBytesReceived_hi [Native];
			}
			set {
				impl.fTotBytesReceived_hi [Native] = value;
			}
		}
		protected uint fTotBytesReceived_lo {
			get {
				return impl.fTotBytesReceived_lo [Native];
			}
			set {
				impl.fTotBytesReceived_lo [Native] = value;
			}
		}
		protected uint fHaveSeenInitialSequenceNumber {
			get {
				return impl.fHaveSeenInitialSequenceNumber [Native];
			}
			set {
				impl.fHaveSeenInitialSequenceNumber [Native] = value;
			}
		}
		protected uint fBaseExtSeqNumReceived {
			get {
				return impl.fBaseExtSeqNumReceived [Native];
			}
			set {
				impl.fBaseExtSeqNumReceived [Native] = value;
			}
		}
		protected uint fLastResetExtSeqNumReceived {
			get {
				return impl.fLastResetExtSeqNumReceived [Native];
			}
			set {
				impl.fLastResetExtSeqNumReceived [Native] = value;
			}
		}
		protected uint fHighestExtSeqNumReceived {
			get {
				return impl.fHighestExtSeqNumReceived [Native];
			}
			set {
				impl.fHighestExtSeqNumReceived [Native] = value;
			}
		}
		protected int fLastTransit {
			get {
				return impl.fLastTransit [Native];
			}
			set {
				impl.fLastTransit [Native] = value;
			}
		}
		protected uint fPreviousPacketRTPTimestamp {
			get {
				return impl.fPreviousPacketRTPTimestamp [Native];
			}
			set {
				impl.fPreviousPacketRTPTimestamp [Native] = value;
			}
		}
		protected double fJitter {
			get {
				return impl.fJitter [Native];
			}
			set {
				impl.fJitter [Native] = value;
			}
		}
		protected uint fLastReceivedSR_NTPmsw {
			get {
				return impl.fLastReceivedSR_NTPmsw [Native];
			}
			set {
				impl.fLastReceivedSR_NTPmsw [Native] = value;
			}
		}
		protected uint fLastReceivedSR_NTPlsw {
			get {
				return impl.fLastReceivedSR_NTPlsw [Native];
			}
			set {
				impl.fLastReceivedSR_NTPlsw [Native] = value;
			}
		}
		protected timeval fLastReceivedSR_time {
			get {
				return impl.fLastReceivedSR_time [Native];
			}
			set {
				impl.fLastReceivedSR_time [Native] = value;
			}
		}
		protected timeval fLastPacketReceptionTime {
			get {
				return impl.fLastPacketReceptionTime [Native];
			}
			set {
				impl.fLastPacketReceptionTime [Native] = value;
			}
		}
		protected uint fMinInterPacketGapUS {
			get {
				return impl.fMinInterPacketGapUS [Native];
			}
			set {
				impl.fMinInterPacketGapUS [Native] = value;
			}
		}
		protected uint fMaxInterPacketGapUS {
			get {
				return impl.fMaxInterPacketGapUS [Native];
			}
			set {
				impl.fMaxInterPacketGapUS [Native] = value;
			}
		}
		protected timeval fTotalInterPacketGaps {
			get {
				return impl.fTotalInterPacketGaps [Native];
			}
			set {
				impl.fTotalInterPacketGaps [Native] = value;
			}
		}




		public RTPReceptionStats (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public RTPReceptionStats (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		protected RTPReceptionStats (uint SSRC, ushort initialSeqNum)
		{
			__cxxi_LayoutClass ();
			Native = impl.RTPReceptionStats (impl.Alloc (this), SSRC, initialSeqNum);
		}
		protected RTPReceptionStats (uint SSRC)
		{
			__cxxi_LayoutClass ();
			Native = impl.RTPReceptionStats (impl.Alloc (this), SSRC);
		}

		public uint SSRC {
			get {
				return impl.SSRC (Native);
			}
		}

		public uint NumPacketsReceivedSinceLastReset {
			get {
				return impl.numPacketsReceivedSinceLastReset (Native);
			}
		}

		public uint TotNumPacketsReceived {
			get {
				return impl.totNumPacketsReceived (Native);
			}
		}

		public double TotNumKBytesReceived {
			get {
				return impl.totNumKBytesReceived (Native);
			}
		}

		public uint TotNumPacketsExpected {
			get {
				return impl.totNumPacketsExpected (Native);
			}
		}

		public uint BaseExtSeqNumReceived {
			get {
				return impl.baseExtSeqNumReceived (Native);
			}
		}

		public uint LastResetExtSeqNumReceived {
			get {
				return impl.lastResetExtSeqNumReceived (Native);
			}
		}

		public uint HighestExtSeqNumReceived {
			get {
				return impl.highestExtSeqNumReceived (Native);
			}
		}

		public uint Jitter {
			get {
				return impl.jitter (Native);
			}
		}

		public uint LastReceivedSR_NTPmsw {
			get {
				return impl.lastReceivedSR_NTPmsw (Native);
			}
		}

		public uint LastReceivedSR_NTPlsw {
			get {
				return impl.lastReceivedSR_NTPlsw (Native);
			}
		}

		public timeval LastReceivedSR_time {
			get {
				return impl.lastReceivedSR_time (Native);
			}
		}

		public uint MinInterPacketGapUS {
			get {
				return impl.minInterPacketGapUS (Native);
			}
		}

		public uint MaxInterPacketGapUS {
			get {
				return impl.maxInterPacketGapUS (Native);
			}
		}

		public timeval TotalInterPacketGaps {
			get {
				return impl.totalInterPacketGaps (Native);
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

