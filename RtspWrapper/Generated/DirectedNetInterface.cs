// -------------------------------------------------------------------------
//  Managed wrapper for DirectedNetInterface
//  Generated from RTSPClient.xml on 05/08/2012 20:36:33
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class DirectedNetInterface : NetInterface {

		private static readonly IDirectedNetInterface impl = Libs.live555.GetClass<IDirectedNetInterface,_DirectedNetInterface,DirectedNetInterface> ("DirectedNetInterface");
		public static bool operator!=(DirectedNetInterface a, DirectedNetInterface b) { return !(a == b); }
		public static bool operator==(DirectedNetInterface a, DirectedNetInterface b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as DirectedNetInterface); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class DirectedNetInterface")]
		public partial interface IDirectedNetInterface : ICppClassOverridable<DirectedNetInterface> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr DirectedNetInterface (CppInstancePtr @this, [MangleAs ("class DirectedNetInterface const &")] DirectedNetInterface arg0);
			[Virtual] [Destructor] void Destruct (CppInstancePtr @this);
			[Virtual] [return: MangleAs ("int  unsigned")] uint write (CppInstancePtr @this, string data, uint numBytes);
			[Virtual] [return: MangleAs ("int  unsigned")] uint SourceAddrOKForRelaying (CppInstancePtr @this, UsageEnvironment env, uint addr);
			[Constructor] [Protected] CppInstancePtr DirectedNetInterface (CppInstancePtr @this);
		}
		public unsafe struct _DirectedNetInterface {
		}





		public DirectedNetInterface (CppTypeInfo subClass)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public DirectedNetInterface (CppInstancePtr native)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("write")]
		public virtual uint Write (string data, uint numBytes)
		{
			return impl.write (Native, data, numBytes);
		}
		[OverrideNative ("SourceAddrOKForRelaying")]
		public virtual uint SourceAddrOKForRelaying (UsageEnvironment env, uint addr)
		{
			return impl.SourceAddrOKForRelaying (Native, env, addr);
		}
		protected DirectedNetInterface ()
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = impl.DirectedNetInterface (impl.Alloc (this));
		}


		partial void BeforeDestruct ();
		partial void AfterDestruct ();

		public override void Dispose ()
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

