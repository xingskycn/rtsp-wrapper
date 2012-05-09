// -------------------------------------------------------------------------
//  Managed wrapper for Scope
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class Scope : ICppObject {

		private static readonly IScope impl = Libs.live555.GetClass<IScope,_Scope,Scope> ("Scope");
		public CppInstancePtr Native { get; protected set; }
		public static bool operator!=(Scope a, Scope b) { return !(a == b); }
		public static bool operator==(Scope a, Scope b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as Scope); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class Scope")]
		public partial interface IScope : ICppClassOverridable<Scope> {
			[Constructor] CppInstancePtr Scope (CppInstancePtr @this, [MangleAs ("char  unsigned")] char ttl, [MangleAs ("char  const *")] string publicKey);
			[Constructor] [CopyConstructor] CppInstancePtr Scope (CppInstancePtr @this, [MangleAs ("class Scope const &")] Scope orig);
			[Destructor] void Destruct (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  unsigned")] char ttl (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  const *")] string publicKey (CppInstancePtr @this);
			[Const] [return: MangleAs ("int  unsigned")] uint publicKeySize (CppInstancePtr @this);
		}
		public unsafe struct _Scope {
			public char fTTL;
			public string fPublicKey;
		}





		public Scope (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public Scope (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public Scope (char ttl, string publicKey)
		{
			__cxxi_LayoutClass ();
			Native = impl.Scope (impl.Alloc (this), ttl, publicKey);
		}
		public Scope (Scope orig)
		{
			__cxxi_LayoutClass ();
			Native = impl.Scope (impl.Alloc (this), orig);
		}

		public char Ttl {
			get {
				return impl.ttl (Native);
			}
		}

		public string PublicKey {
			get {
				return impl.publicKey (Native);
			}
		}

		public uint PublicKeySize {
			get {
				return impl.publicKeySize (Native);
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

