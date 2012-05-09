// -------------------------------------------------------------------------
//  Managed wrapper for Port
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class Port : ICppObject {

		private static readonly IPort impl = Libs.live555.GetClass<IPort,_Port,Port> ("Port");
		public CppInstancePtr Native { get; protected set; }
		public static bool operator!=(Port a, Port b) { return !(a == b); }
		public static bool operator==(Port a, Port b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as Port); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class Port")]
		public partial interface IPort : ICppClassOverridable<Port> {
			[Artificial] [Inline] [Destructor] void Destruct (CppInstancePtr @this);
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr Port (CppInstancePtr @this, [MangleAs ("class Port const &")] Port arg0);
			[Constructor] CppInstancePtr Port (CppInstancePtr @this, [MangleAs ("int  short unsigned")] ushort num);
			[Inline] [Const] [return: MangleAs ("int  short unsigned")] ushort num (CppInstancePtr @this);
		}
		public unsafe struct _Port {
			public ushort fPortNum;
		}





		public Port (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public Port (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public Port (ushort num)
		{
			__cxxi_LayoutClass ();
			Native = impl.Port (impl.Alloc (this), num);
		}

		public ushort Num {
			get {
				return impl.num (Native);
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

