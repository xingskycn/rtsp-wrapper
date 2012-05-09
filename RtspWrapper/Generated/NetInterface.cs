// -------------------------------------------------------------------------
//  Managed wrapper for NetInterface
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class NetInterface : ICppObject {

		private static readonly INetInterface impl = Libs.live555.GetClass<INetInterface,_NetInterface,NetInterface> ("NetInterface");
		public CppInstancePtr Native { get; protected set; }
		public static bool operator!=(NetInterface a, NetInterface b) { return !(a == b); }
		public static bool operator==(NetInterface a, NetInterface b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as NetInterface); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class NetInterface")]
		public partial interface INetInterface : ICppClassOverridable<NetInterface> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr NetInterface (CppInstancePtr @this, [MangleAs ("class NetInterface const &")] NetInterface arg0);
			[Virtual] [Destructor] void Destruct (CppInstancePtr @this);
			[Constructor] [Protected] CppInstancePtr NetInterface (CppInstancePtr @this);
		}
		public unsafe struct _NetInterface {
		}





		public NetInterface (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public NetInterface (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		protected NetInterface ()
		{
			__cxxi_LayoutClass ();
			Native = impl.NetInterface (impl.Alloc (this));
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

