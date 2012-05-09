// -------------------------------------------------------------------------
//  Managed wrapper for NetInterfaceTrafficStats
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class NetInterfaceTrafficStats : ICppObject {

		private static readonly INetInterfaceTrafficStats impl = Libs.live555.GetClass<INetInterfaceTrafficStats,_NetInterfaceTrafficStats,NetInterfaceTrafficStats> ("NetInterfaceTrafficStats");
		public CppInstancePtr Native { get; protected set; }
		public static bool operator!=(NetInterfaceTrafficStats a, NetInterfaceTrafficStats b) { return !(a == b); }
		public static bool operator==(NetInterfaceTrafficStats a, NetInterfaceTrafficStats b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as NetInterfaceTrafficStats); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class NetInterfaceTrafficStats")]
		public partial interface INetInterfaceTrafficStats : ICppClassOverridable<NetInterfaceTrafficStats> {
			[Artificial] [Inline] [Destructor] void Destruct (CppInstancePtr @this);
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr NetInterfaceTrafficStats (CppInstancePtr @this, [MangleAs ("class NetInterfaceTrafficStats const &")] NetInterfaceTrafficStats arg0);
			[Constructor] CppInstancePtr NetInterfaceTrafficStats (CppInstancePtr @this);
			void countPacket (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint packetSize);
			[Inline] [Const] float totNumPackets (CppInstancePtr @this);
			[Inline] [Const] float totNumBytes (CppInstancePtr @this);
			[Const] [return: MangleAs ("int  unsigned")] uint haveSeenTraffic (CppInstancePtr @this);
		}
		public unsafe struct _NetInterfaceTrafficStats {
			public float fTotNumPackets;
			public float fTotNumBytes;
		}





		public NetInterfaceTrafficStats (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public NetInterfaceTrafficStats (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public NetInterfaceTrafficStats ()
		{
			__cxxi_LayoutClass ();
			Native = impl.NetInterfaceTrafficStats (impl.Alloc (this));
		}
		public void CountPacket (uint packetSize)
		{
			impl.countPacket (Native, packetSize);
		}

		public float TotNumPackets {
			get {
				return impl.totNumPackets (Native);
			}
		}

		public float TotNumBytes {
			get {
				return impl.totNumBytes (Native);
			}
		}

		public uint HaveSeenTraffic {
			get {
				return impl.haveSeenTraffic (Native);
			}
		}


		partial void BeforeDestruct ();
		partial void AfterDestruct ();

		public virtual void Dispose ()
		{
			BeforeDestruct ();
			Native.Dispose ();
			AfterDestruct ();
		}

		private void __cxxi_LayoutClass ()
		{
			impl.TypeInfo.CompleteType ();
		}

	}
}

