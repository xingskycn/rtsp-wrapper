// -------------------------------------------------------------------------
//  Managed wrapper for RTPReceptionStatsDB
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class RTPReceptionStatsDB : ICppObject {

		private static readonly IRTPReceptionStatsDB impl = Libs.live555.GetClass<IRTPReceptionStatsDB,_RTPReceptionStatsDB,RTPReceptionStatsDB> ("RTPReceptionStatsDB");
		public CppInstancePtr Native { get; protected set; }
		public static bool operator!=(RTPReceptionStatsDB a, RTPReceptionStatsDB b) { return !(a == b); }
		public static bool operator==(RTPReceptionStatsDB a, RTPReceptionStatsDB b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as RTPReceptionStatsDB); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class RTPReceptionStatsDB")]
		public partial interface IRTPReceptionStatsDB : ICppClassOverridable<RTPReceptionStatsDB> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr RTPReceptionStatsDB (CppInstancePtr @this, [MangleAs ("class RTPReceptionStatsDB const &")] RTPReceptionStatsDB arg0);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint totNumPacketsReceived (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint numActiveSourcesSinceLastReset (CppInstancePtr @this);
			void reset (CppInstancePtr @this);
			void noteIncomingPacket (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint SSRC, [MangleAs ("int  short unsigned")] ushort seqNum, [MangleAs ("int  unsigned")] uint rtpTimestamp, [MangleAs ("int  unsigned")] uint timestampFrequency, [MangleAs ("int  unsigned")] uint useForJitterCalculation, [MangleAs ("struct timeval &")] timeval resultPresentationTime, [MangleAs ("int  unsigned &")] ref uint resultHasBeenSyncedUsingRTCP, [MangleAs ("int  unsigned")] uint packetSize);
			void noteIncomingSR (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint SSRC, [MangleAs ("int  unsigned")] uint ntpTimestampMSW, [MangleAs ("int  unsigned")] uint ntpTimestampLSW, [MangleAs ("int  unsigned")] uint rtpTimestamp);
			void removeRecord (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint SSRC);
			[Const] [return: MangleAs ("class RTPReceptionStats *")] RTPReceptionStats lookup (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint SSRC);
			[Constructor] [Protected] CppInstancePtr RTPReceptionStatsDB (CppInstancePtr @this);
			[Virtual] [Destructor] [Protected] void Destruct (CppInstancePtr @this);
			[Protected] void add (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint SSRC, [MangleAs ("class RTPReceptionStats *")] RTPReceptionStats stats);
			CppField<uint> fNumActiveSourcesSinceLastReset { get; }
		}
		public unsafe struct _RTPReceptionStatsDB {
			public uint fNumActiveSourcesSinceLastReset;
			public HashTable fTable;
			public uint fTotNumPacketsReceived;
		}

		protected uint fNumActiveSourcesSinceLastReset {
			get {
				return impl.fNumActiveSourcesSinceLastReset [Native];
			}
			set {
				impl.fNumActiveSourcesSinceLastReset [Native] = value;
			}
		}




		public RTPReceptionStatsDB (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public RTPReceptionStatsDB (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public void Reset ()
		{
			impl.reset (Native);
		}
		public void NoteIncomingPacket (uint SSRC, ushort seqNum, uint rtpTimestamp, uint timestampFrequency, uint useForJitterCalculation, timeval resultPresentationTime, ref uint resultHasBeenSyncedUsingRTCP, uint packetSize)
		{
			impl.noteIncomingPacket (Native, SSRC, seqNum, rtpTimestamp, timestampFrequency, useForJitterCalculation, resultPresentationTime, ref resultHasBeenSyncedUsingRTCP, packetSize);
		}
		public void NoteIncomingSR (uint SSRC, uint ntpTimestampMSW, uint ntpTimestampLSW, uint rtpTimestamp)
		{
			impl.noteIncomingSR (Native, SSRC, ntpTimestampMSW, ntpTimestampLSW, rtpTimestamp);
		}
		public void RemoveRecord (uint SSRC)
		{
			impl.removeRecord (Native, SSRC);
		}
		public RTPReceptionStats Lookup (uint SSRC)
		{
			return impl.lookup (Native, SSRC);
		}
		protected RTPReceptionStatsDB ()
		{
			__cxxi_LayoutClass ();
			Native = impl.RTPReceptionStatsDB (impl.Alloc (this));
		}
		protected void Add (uint SSRC, RTPReceptionStats stats)
		{
			impl.add (Native, SSRC, stats);
		}

		public uint TotNumPacketsReceived {
			get {
				return impl.totNumPacketsReceived (Native);
			}
		}

		public uint NumActiveSourcesSinceLastReset {
			get {
				return impl.numActiveSourcesSinceLastReset (Native);
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

