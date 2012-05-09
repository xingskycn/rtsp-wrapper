// -------------------------------------------------------------------------
//  Managed wrapper for RTPTransmissionStats
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class RTPTransmissionStats : ICppObject {

		private static readonly IRTPTransmissionStats impl = Libs.live555.GetClass<IRTPTransmissionStats,_RTPTransmissionStats,RTPTransmissionStats> ("RTPTransmissionStats");
		public CppInstancePtr Native { get; protected set; }
		public static bool operator!=(RTPTransmissionStats a, RTPTransmissionStats b) { return !(a == b); }
		public static bool operator==(RTPTransmissionStats a, RTPTransmissionStats b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as RTPTransmissionStats); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class RTPTransmissionStats")]
		public partial interface IRTPTransmissionStats : ICppClassOverridable<RTPTransmissionStats> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr RTPTransmissionStats (CppInstancePtr @this, [MangleAs ("class RTPTransmissionStats const &")] RTPTransmissionStats arg0);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint SSRC (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("struct sockaddr_in const &")] sockaddr_in lastFromAddress (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint lastPacketNumReceived (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint firstPacketNumReported (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint totNumPacketsLost (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint jitter (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint lastSRTime (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint diffSR_RRTime (CppInstancePtr @this);
			[Const] [return: MangleAs ("int  unsigned")] uint roundTripDelay (CppInstancePtr @this);
			[Inline] [Const] [return: ByVal] timeval timeCreated (CppInstancePtr @this);
			[Inline] [Const] [return: ByVal] timeval lastTimeReceived (CppInstancePtr @this);
			void getTotalOctetCount (CppInstancePtr @this, [MangleAs ("int  unsigned &")] ref uint hi, [MangleAs ("int  unsigned &")] ref uint lo);
			void getTotalPacketCount (CppInstancePtr @this, [MangleAs ("int  unsigned &")] ref uint hi, [MangleAs ("int  unsigned &")] ref uint lo);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint oldValid (CppInstancePtr @this);
			[Const] [return: MangleAs ("int  unsigned")] uint packetsReceivedSinceLastRR (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  unsigned")] char packetLossRatio (CppInstancePtr @this);
			[Const] int packetsLostBetweenRR (CppInstancePtr @this);
			[Virtual] [Destructor] void Destruct (CppInstancePtr @this);
		}
		public unsafe struct _RTPTransmissionStats {
			public RTPSink fOurRTPSink;
			public uint fSSRC;
			public sockaddr_in._sockaddr_in fLastFromAddress;
			public uint fLastPacketNumReceived;
			public char fPacketLossRatio;
			public uint fTotNumPacketsLost;
			public uint fJitter;
			public uint fLastSRTime;
			public uint fDiffSR_RRTime;
			public timeval._timeval fTimeCreated;
			public timeval._timeval fTimeReceived;
			public uint fOldValid;
			public uint fOldLastPacketNumReceived;
			public uint fOldTotNumPacketsLost;
			public uint fFirstPacket;
			public uint fFirstPacketNumReported;
			public uint fLastOctetCount;
			public uint fTotalOctetCount_hi;
			public uint fTotalOctetCount_lo;
			public uint fLastPacketCount;
			public uint fTotalPacketCount_hi;
			public uint fTotalPacketCount_lo;
		}





		public RTPTransmissionStats (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public RTPTransmissionStats (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public void GetTotalOctetCount (ref uint hi, ref uint lo)
		{
			impl.getTotalOctetCount (Native, ref hi, ref lo);
		}
		public void GetTotalPacketCount (ref uint hi, ref uint lo)
		{
			impl.getTotalPacketCount (Native, ref hi, ref lo);
		}

		public uint SSRC {
			get {
				return impl.SSRC (Native);
			}
		}

		public sockaddr_in LastFromAddress {
			get {
				return impl.lastFromAddress (Native);
			}
		}

		public uint LastPacketNumReceived {
			get {
				return impl.lastPacketNumReceived (Native);
			}
		}

		public uint FirstPacketNumReported {
			get {
				return impl.firstPacketNumReported (Native);
			}
		}

		public uint TotNumPacketsLost {
			get {
				return impl.totNumPacketsLost (Native);
			}
		}

		public uint Jitter {
			get {
				return impl.jitter (Native);
			}
		}

		public uint LastSRTime {
			get {
				return impl.lastSRTime (Native);
			}
		}

		public uint DiffSR_RRTime {
			get {
				return impl.diffSR_RRTime (Native);
			}
		}

		public uint RoundTripDelay {
			get {
				return impl.roundTripDelay (Native);
			}
		}

		public timeval TimeCreated {
			get {
				return impl.timeCreated (Native);
			}
		}

		public timeval LastTimeReceived {
			get {
				return impl.lastTimeReceived (Native);
			}
		}

		public uint OldValid {
			get {
				return impl.oldValid (Native);
			}
		}

		public uint PacketsReceivedSinceLastRR {
			get {
				return impl.packetsReceivedSinceLastRR (Native);
			}
		}

		public char PacketLossRatio {
			get {
				return impl.packetLossRatio (Native);
			}
		}

		public int PacketsLostBetweenRR {
			get {
				return impl.packetsLostBetweenRR (Native);
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

