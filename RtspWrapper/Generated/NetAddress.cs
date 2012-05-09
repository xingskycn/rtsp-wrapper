// -------------------------------------------------------------------------
//  Managed wrapper for NetAddress
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class NetAddress : ICppObject {

		private static readonly INetAddress impl = Libs.live555.GetClass<INetAddress,_NetAddress,NetAddress> ("NetAddress");
		public CppInstancePtr Native { get; protected set; }
		public static bool operator!=(NetAddress a, NetAddress b) { return !(a == b); }
		public static bool operator==(NetAddress a, NetAddress b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as NetAddress); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class NetAddress")]
		public partial interface INetAddress : ICppClassOverridable<NetAddress> {
			[Constructor] CppInstancePtr NetAddress (CppInstancePtr @this, [MangleAs ("char  unsigned const *")] string data, [MangleAs ("int  unsigned")] uint length);
			[Constructor] CppInstancePtr NetAddress (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint length);
			[Constructor] [CopyConstructor] CppInstancePtr NetAddress (CppInstancePtr @this, [MangleAs ("class NetAddress const &")] NetAddress orig);
			[Virtual] [Destructor] void Destruct (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint length (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  unsigned const *")] string data (CppInstancePtr @this);
		}
		public unsafe struct _NetAddress {
			public uint fLength;
			public string fData;
		}





		public NetAddress (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public NetAddress (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public NetAddress (string data, uint length)
		{
			__cxxi_LayoutClass ();
			Native = impl.NetAddress (impl.Alloc (this), data, length);
		}
		public NetAddress (uint length)
		{
			__cxxi_LayoutClass ();
			Native = impl.NetAddress (impl.Alloc (this), length);
		}
		public NetAddress (NetAddress orig)
		{
			__cxxi_LayoutClass ();
			Native = impl.NetAddress (impl.Alloc (this), orig);
		}

		public uint Length {
			get {
				return impl.length (Native);
			}
		}

		public string Data {
			get {
				return impl.data (Native);
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

