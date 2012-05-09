// -------------------------------------------------------------------------
//  Managed wrapper for Authenticator
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class Authenticator : ICppObject {

		private static readonly IAuthenticator impl = Libs.live555.GetClass<IAuthenticator,_Authenticator,Authenticator> ("Authenticator");
		public CppInstancePtr Native { get; protected set; }
		public static bool operator!=(Authenticator a, Authenticator b) { return !(a == b); }
		public static bool operator==(Authenticator a, Authenticator b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as Authenticator); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class Authenticator")]
		public partial interface IAuthenticator : ICppClassOverridable<Authenticator> {
			[Constructor] CppInstancePtr Authenticator (CppInstancePtr @this);
			[Constructor] CppInstancePtr Authenticator (CppInstancePtr @this, [MangleAs ("char  const *")] string username, [MangleAs ("char  const *")] string password, [MangleAs ("int  unsigned")] uint passwordIsMD5);
			[Constructor] [CopyConstructor] CppInstancePtr Authenticator (CppInstancePtr @this, [MangleAs ("class Authenticator const &")] Authenticator orig);
			[Virtual] [Destructor] void Destruct (CppInstancePtr @this);
			void reset (CppInstancePtr @this);
			void setRealmAndNonce (CppInstancePtr @this, [MangleAs ("char  const *")] string realm, [MangleAs ("char  const *")] string nonce);
			void setRealmAndRandomNonce (CppInstancePtr @this, [MangleAs ("char  const *")] string realm);
			void setUsernameAndPassword (CppInstancePtr @this, [MangleAs ("char  const *")] string username, [MangleAs ("char  const *")] string password, [MangleAs ("int  unsigned")] uint passwordIsMD5);
			[Inline] [Const] [return: MangleAs ("char  const *")] string realm (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  const *")] string nonce (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  const *")] string username (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  const *")] string password (CppInstancePtr @this);
			[Const] [return: MangleAs ("char  const *")] string computeDigestResponse (CppInstancePtr @this, [MangleAs ("char  const *")] string cmd, [MangleAs ("char  const *")] string url);
			[Const] void reclaimDigestResponse (CppInstancePtr @this, [MangleAs ("char  const *")] string responseStr);
		}
		public unsafe struct _Authenticator {
			public string fRealm;
			public string fNonce;
			public string fUsername;
			public string fPassword;
			public uint fPasswordIsMD5;
		}





		public Authenticator (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public Authenticator (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public Authenticator ()
		{
			__cxxi_LayoutClass ();
			Native = impl.Authenticator (impl.Alloc (this));
		}
		public Authenticator (string username, string password, uint passwordIsMD5)
		{
			__cxxi_LayoutClass ();
			Native = impl.Authenticator (impl.Alloc (this), username, password, passwordIsMD5);
		}
		public Authenticator (Authenticator orig)
		{
			__cxxi_LayoutClass ();
			Native = impl.Authenticator (impl.Alloc (this), orig);
		}
		public void Reset ()
		{
			impl.reset (Native);
		}
		public void SetRealmAndNonce (string realm, string nonce)
		{
			impl.setRealmAndNonce (Native, realm, nonce);
		}
		public void SetRealmAndRandomNonce (string realm)
		{
			impl.setRealmAndRandomNonce (Native, realm);
		}
		public void SetUsernameAndPassword (string username, string password, uint passwordIsMD5)
		{
			impl.setUsernameAndPassword (Native, username, password, passwordIsMD5);
		}
		public string ComputeDigestResponse (string cmd, string url)
		{
			return impl.computeDigestResponse (Native, cmd, url);
		}
		public void ReclaimDigestResponse (string responseStr)
		{
			impl.reclaimDigestResponse (Native, responseStr);
		}

		public string Realm {
			get {
				return impl.realm (Native);
			}
		}

		public string Nonce {
			get {
				return impl.nonce (Native);
			}
		}

		public string Username {
			get {
				return impl.username (Native);
			}
		}

		public string Password {
			get {
				return impl.password (Native);
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

