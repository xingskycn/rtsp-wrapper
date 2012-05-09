// -------------------------------------------------------------------------
//  Managed wrapper for SDESItem
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class SDESItem : ICppObject {

		private static readonly ISDESItem impl = Libs.live555.GetClass<ISDESItem,_SDESItem,SDESItem> ("SDESItem");
		public CppInstancePtr Native { get; protected set; }
		public static bool operator!=(SDESItem a, SDESItem b) { return !(a == b); }
		public static bool operator==(SDESItem a, SDESItem b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as SDESItem); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class SDESItem")]
		public partial interface ISDESItem : ICppClassOverridable<SDESItem> {
			[Artificial] [Inline] [Destructor] void Destruct (CppInstancePtr @this);
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr SDESItem (CppInstancePtr @this, [MangleAs ("class SDESItem const &")] SDESItem arg0);
			[Constructor] CppInstancePtr SDESItem (CppInstancePtr @this, [MangleAs ("char  unsigned")] char tag, [MangleAs ("char  unsigned const *")] string value);
			[Inline] [Const] [return: MangleAs ("char  unsigned const *")] string data (CppInstancePtr @this);
			[Const] [return: MangleAs ("int  unsigned")] uint totalSize (CppInstancePtr @this);
		}
		public unsafe struct _SDESItem {
			public fixed Char fData [257];
		}





		public SDESItem (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public SDESItem (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public SDESItem (char tag, string value)
		{
			__cxxi_LayoutClass ();
			Native = impl.SDESItem (impl.Alloc (this), tag, value);
		}

		public string Data {
			get {
				return impl.data (Native);
			}
		}

		public uint TotalSize {
			get {
				return impl.totalSize (Native);
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

