// -------------------------------------------------------------------------
//  Managed wrapper for HashTable
//  Generated from RTSPClient.xml on 05/08/2012 20:36:33
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class HashTable : ICppObject {

		private static readonly IHashTable impl = Libs.live555.GetClass<IHashTable,_HashTable,HashTable> ("HashTable");
		public CppInstancePtr Native { get; protected set; }
		public static bool operator!=(HashTable a, HashTable b) { return !(a == b); }
		public static bool operator==(HashTable a, HashTable b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as HashTable); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class HashTable")]
		public partial interface IHashTable : ICppClassOverridable<HashTable> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr HashTable (CppInstancePtr @this, [MangleAs ("class HashTable const &")] HashTable arg0);
			[Virtual] [Destructor] void Destruct (CppInstancePtr @this);
			[Static] [return: MangleAs ("class HashTable *")] HashTable create (int keyType);
			[Virtual] [return: MangleAs ("void  *")] IntPtr Add (CppInstancePtr @this, string key, IntPtr value);
			[Virtual] [return: MangleAs ("int  unsigned")] uint Remove (CppInstancePtr @this, string key);
			[Virtual] [Const] [return: MangleAs ("void  *")] IntPtr Lookup (CppInstancePtr @this, string key);
			[Virtual] [Const] [return: MangleAs ("int  unsigned")] uint numEntries (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint IsEmpty (CppInstancePtr @this);
			[return: MangleAs ("void  *")] IntPtr RemoveNext (CppInstancePtr @this);
			[Constructor] [Protected] CppInstancePtr HashTable (CppInstancePtr @this);
		}
		public unsafe struct _HashTable {
		}





		public HashTable (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public HashTable (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public static HashTable Create (int keyType)
		{
			return impl.create (keyType);
		}
		[OverrideNative ("Add")]
		public virtual IntPtr Add (string key, IntPtr value)
		{
			return impl.Add (Native, key, value);
		}
		[OverrideNative ("Remove")]
		public virtual uint Remove (string key)
		{
			return impl.Remove (Native, key);
		}
		[OverrideNative ("Lookup")]
		public virtual IntPtr Lookup (string key)
		{
			return impl.Lookup (Native, key);
		}
		public IntPtr RemoveNext ()
		{
			return impl.RemoveNext (Native);
		}
		protected HashTable ()
		{
			__cxxi_LayoutClass ();
			Native = impl.HashTable (impl.Alloc (this));
		}

		public virtual uint NumEntries {
			[OverrideNative ("numEntries")] get {
				return impl.numEntries (Native);
			}
		}

		public uint IsEmpty {
			get {
				return impl.IsEmpty (Native);
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

