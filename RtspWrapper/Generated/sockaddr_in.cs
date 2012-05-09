// -------------------------------------------------------------------------
//  Managed wrapper for sockaddr_in
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class sockaddr_in : ICppObject {

		private static readonly Isockaddr_in impl = Libs.live555.GetClass<Isockaddr_in,_sockaddr_in,sockaddr_in> ("sockaddr_in");
		public CppInstancePtr Native { get; protected set; }
		public static bool operator!=(sockaddr_in a, sockaddr_in b) { return !(a == b); }
		public static bool operator==(sockaddr_in a, sockaddr_in b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as sockaddr_in); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("struct sockaddr_in")]
		public partial interface Isockaddr_in : ICppClassOverridable<sockaddr_in> {
			[Artificial] [Inline] [Destructor] void Destruct (CppInstancePtr @this);
			[Artificial] [Inline] [Constructor] CppInstancePtr sockaddr_in (CppInstancePtr @this, [MangleAs ("struct sockaddr_in const &")] sockaddr_in arg0);
			[Artificial] [Inline] [Constructor] CppInstancePtr sockaddr_in (CppInstancePtr @this);
			CppField<short> sin_family { get; }
			CppField<ushort> sin_port { get; }
			CppField<in_addr> sin_addr { get; }
			CppField<Char[]> sin_zero { get; }
		}
		public unsafe struct _sockaddr_in {
			public short sin_family;
			public ushort sin_port;
			public in_addr._in_addr sin_addr;
			public fixed Char sin_zero [8];
		}

		public short sin_family {
			get {
				return impl.sin_family [Native];
			}
			set {
				impl.sin_family [Native] = value;
			}
		}
		public ushort sin_port {
			get {
				return impl.sin_port [Native];
			}
			set {
				impl.sin_port [Native] = value;
			}
		}
		public in_addr sin_addr {
			get {
				return impl.sin_addr [Native];
			}
			set {
				impl.sin_addr [Native] = value;
			}
		}
		public Char[] sin_zero {
			get {
				return impl.sin_zero [Native];
			}
			set {
				impl.sin_zero [Native] = value;
			}
		}




		public sockaddr_in (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public sockaddr_in (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
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

