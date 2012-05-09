// -------------------------------------------------------------------------
//  Managed wrapper for AddressPortLookupTable
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class AddressPortLookupTable : ICppObject {

		private static readonly IAddressPortLookupTable impl = Libs.live555.GetClass<IAddressPortLookupTable,_AddressPortLookupTable,AddressPortLookupTable> ("AddressPortLookupTable");
		public CppInstancePtr Native { get; protected set; }
		public static bool operator!=(AddressPortLookupTable a, AddressPortLookupTable b) { return !(a == b); }
		public static bool operator==(AddressPortLookupTable a, AddressPortLookupTable b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as AddressPortLookupTable); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class AddressPortLookupTable")]
		public partial interface IAddressPortLookupTable : ICppClassOverridable<AddressPortLookupTable> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr AddressPortLookupTable (CppInstancePtr @this, [MangleAs ("class AddressPortLookupTable const &")] AddressPortLookupTable arg0);
			[Constructor] CppInstancePtr AddressPortLookupTable (CppInstancePtr @this);
			[Virtual] [Destructor] void Destruct (CppInstancePtr @this);
			[return: MangleAs ("void  *")] IntPtr Add (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint address1, [MangleAs ("int  unsigned")] uint address2, [MangleAs ("class Port")] [ByVal] Port port, [MangleAs ("void  *")] IntPtr value);
			[return: MangleAs ("int  unsigned")] uint Remove (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint address1, [MangleAs ("int  unsigned")] uint address2, [MangleAs ("class Port")] [ByVal] Port port);
			[return: MangleAs ("void  *")] IntPtr Lookup (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint address1, [MangleAs ("int  unsigned")] uint address2, [MangleAs ("class Port")] [ByVal] Port port);
		}
		public unsafe struct _AddressPortLookupTable {
			public HashTable fTable;
		}





		public AddressPortLookupTable (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public AddressPortLookupTable (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public AddressPortLookupTable ()
		{
			__cxxi_LayoutClass ();
			Native = impl.AddressPortLookupTable (impl.Alloc (this));
		}
		public IntPtr Add (uint address1, uint address2, Port port, IntPtr value)
		{
			return impl.Add (Native, address1, address2, port, value);
		}
		public uint Remove (uint address1, uint address2, Port port)
		{
			return impl.Remove (Native, address1, address2, port);
		}
		public IntPtr Lookup (uint address1, uint address2, Port port)
		{
			return impl.Lookup (Native, address1, address2, port);
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

