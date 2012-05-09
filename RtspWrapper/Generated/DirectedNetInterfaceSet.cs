// -------------------------------------------------------------------------
//  Managed wrapper for DirectedNetInterfaceSet
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class DirectedNetInterfaceSet : ICppObject {

		private static readonly IDirectedNetInterfaceSet impl = Libs.live555.GetClass<IDirectedNetInterfaceSet,_DirectedNetInterfaceSet,DirectedNetInterfaceSet> ("DirectedNetInterfaceSet");
		public CppInstancePtr Native { get; protected set; }
		public static bool operator!=(DirectedNetInterfaceSet a, DirectedNetInterfaceSet b) { return !(a == b); }
		public static bool operator==(DirectedNetInterfaceSet a, DirectedNetInterfaceSet b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as DirectedNetInterfaceSet); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class DirectedNetInterfaceSet")]
		public partial interface IDirectedNetInterfaceSet : ICppClassOverridable<DirectedNetInterfaceSet> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr DirectedNetInterfaceSet (CppInstancePtr @this, [MangleAs ("class DirectedNetInterfaceSet const &")] DirectedNetInterfaceSet arg0);
			[Constructor] CppInstancePtr DirectedNetInterfaceSet (CppInstancePtr @this);
			[Virtual] [Destructor] void Destruct (CppInstancePtr @this);
			[return: MangleAs ("class DirectedNetInterface *")] DirectedNetInterface Add (CppInstancePtr @this, [MangleAs ("class DirectedNetInterface const *")] DirectedNetInterface interf);
			[return: MangleAs ("int  unsigned")] uint Remove (CppInstancePtr @this, [MangleAs ("class DirectedNetInterface const *")] DirectedNetInterface interf);
			[Inline] [return: MangleAs ("int  unsigned")] uint IsEmpty (CppInstancePtr @this);
		}
		public unsafe struct _DirectedNetInterfaceSet {
			public HashTable fTable;
		}





		public DirectedNetInterfaceSet (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public DirectedNetInterfaceSet (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public DirectedNetInterfaceSet ()
		{
			__cxxi_LayoutClass ();
			Native = impl.DirectedNetInterfaceSet (impl.Alloc (this));
		}
		public DirectedNetInterface Add (DirectedNetInterface interf)
		{
			return impl.Add (Native, interf);
		}
		public uint Remove (DirectedNetInterface interf)
		{
			return impl.Remove (Native, interf);
		}
		public uint IsEmpty ()
		{
			return impl.IsEmpty (Native);
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

