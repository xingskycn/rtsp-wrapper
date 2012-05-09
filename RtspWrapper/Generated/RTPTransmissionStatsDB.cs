// -------------------------------------------------------------------------
//  Managed wrapper for RTPTransmissionStatsDB
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class RTPTransmissionStatsDB : ICppObject {

		private static readonly IRTPTransmissionStatsDB impl = Libs.live555.GetClass<IRTPTransmissionStatsDB,_RTPTransmissionStatsDB,RTPTransmissionStatsDB> ("RTPTransmissionStatsDB");
		public CppInstancePtr Native { get; protected set; }
		public static bool operator!=(RTPTransmissionStatsDB a, RTPTransmissionStatsDB b) { return !(a == b); }
		public static bool operator==(RTPTransmissionStatsDB a, RTPTransmissionStatsDB b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as RTPTransmissionStatsDB); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class RTPTransmissionStatsDB")]
		public partial interface IRTPTransmissionStatsDB : ICppClassOverridable<RTPTransmissionStatsDB> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr RTPTransmissionStatsDB (CppInstancePtr @this, [MangleAs ("class RTPTransmissionStatsDB const &")] RTPTransmissionStatsDB arg0);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint numReceivers (CppInstancePtr @this);
			void noteIncomingRR (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint SSRC, [MangleAs ("struct sockaddr_in const &")] sockaddr_in lastFromAddress, [MangleAs ("int  unsigned")] uint lossStats, [MangleAs ("int  unsigned")] uint lastPacketNumReceived, [MangleAs ("int  unsigned")] uint jitter, [MangleAs ("int  unsigned")] uint lastSRTime, [MangleAs ("int  unsigned")] uint diffSR_RRTime);
			void removeRecord (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint SSRC);
			[Const] [return: MangleAs ("class RTPTransmissionStats *")] RTPTransmissionStats lookup (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint SSRC);
			[Virtual] [Destructor] void Destruct (CppInstancePtr @this);
		}
		public unsafe struct _RTPTransmissionStatsDB {
			public uint fNumReceivers;
			public RTPSink fOurRTPSink;
			public HashTable fTable;
		}





		public RTPTransmissionStatsDB (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public RTPTransmissionStatsDB (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public void NoteIncomingRR (uint SSRC, sockaddr_in lastFromAddress, uint lossStats, uint lastPacketNumReceived, uint jitter, uint lastSRTime, uint diffSR_RRTime)
		{
			impl.noteIncomingRR (Native, SSRC, lastFromAddress, lossStats, lastPacketNumReceived, jitter, lastSRTime, diffSR_RRTime);
		}
		public void RemoveRecord (uint SSRC)
		{
			impl.removeRecord (Native, SSRC);
		}
		public RTPTransmissionStats Lookup (uint SSRC)
		{
			return impl.lookup (Native, SSRC);
		}

		public uint NumReceivers {
			get {
				return impl.numReceivers (Native);
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

