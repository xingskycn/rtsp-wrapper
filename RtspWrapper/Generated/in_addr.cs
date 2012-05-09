// -------------------------------------------------------------------------
//  Managed wrapper for in_addr
//  Generated from RTSPClient.xml on 05/08/2012 20:36:33
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class in_addr : ICppObject {

		private static readonly Iin_addr impl = Libs.live555.GetClass<Iin_addr,_in_addr,in_addr> ("in_addr");
		public CppInstancePtr Native { get; protected set; }
		public static bool operator!=(in_addr a, in_addr b) { return !(a == b); }
		public static bool operator==(in_addr a, in_addr b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as in_addr); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("struct in_addr")]
		public partial interface Iin_addr : ICppClassOverridable<in_addr> {
			[Artificial] [Inline] [Destructor] void Destruct (CppInstancePtr @this);
			[Artificial] [Inline] [Constructor] CppInstancePtr in_addr (CppInstancePtr @this, [MangleAs ("struct in_addr const &")] in_addr arg0);
			[Artificial] [Inline] [Constructor] CppInstancePtr in_addr (CppInstancePtr @this);
			CppField<IntPtr> S_un { get; }
		}
		public unsafe struct _in_addr {
			public IntPtr S_un;
		}

		public IntPtr S_un {
			get {
				return impl.S_un [Native];
			}
			set {
				impl.S_un [Native] = value;
			}
		}




		public in_addr (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public in_addr (CppInstancePtr native)
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

