// -------------------------------------------------------------------------
//  Managed wrapper for Medium
//  Generated from RTSPClient.xml on 05/08/2012 20:36:33
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class Medium : ICppObject {

		private static readonly IMedium impl = Libs.live555.GetClass<IMedium,_Medium,Medium> ("Medium");
		public CppInstancePtr Native { get; protected set; }
		public static bool operator!=(Medium a, Medium b) { return !(a == b); }
		public static bool operator==(Medium a, Medium b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as Medium); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class Medium")]
		public partial interface IMedium : ICppClassOverridable<Medium> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr Medium (CppInstancePtr @this, [MangleAs ("class Medium const &")] Medium arg0);
			[Static] [return: MangleAs ("int  unsigned")] uint lookupByName ([MangleAs ("class UsageEnvironment &")] UsageEnvironment env, [MangleAs ("char  const *")] string mediumName, [MangleAs ("class Medium * &")] Medium resultMedium);
			[Static] void close ([MangleAs ("class UsageEnvironment &")] UsageEnvironment env, [MangleAs ("char  const *")] string mediumName);
			[Static] void close ([MangleAs ("class Medium *")] Medium medium);
			[Inline] [Const] [return: MangleAs ("class UsageEnvironment &")] UsageEnvironment envir (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  const *")] string name (CppInstancePtr @this);
			[Virtual] [Const] [return: MangleAs ("int  unsigned")] uint isSource (CppInstancePtr @this);
			[Virtual] [Const] [return: MangleAs ("int  unsigned")] uint isSink (CppInstancePtr @this);
			[Virtual] [Const] [return: MangleAs ("int  unsigned")] uint isRTCPInstance (CppInstancePtr @this);
			[Virtual] [Const] [return: MangleAs ("int  unsigned")] uint isRTSPClient (CppInstancePtr @this);
			[Virtual] [Const] [return: MangleAs ("int  unsigned")] uint isRTSPServer (CppInstancePtr @this);
			[Virtual] [Const] [return: MangleAs ("int  unsigned")] uint isMediaSession (CppInstancePtr @this);
			[Virtual] [Const] [return: MangleAs ("int  unsigned")] uint isServerMediaSession (CppInstancePtr @this);
			[Virtual] [Const] [return: MangleAs ("int  unsigned")] uint isDarwinInjector (CppInstancePtr @this);
			[Constructor] [Protected] CppInstancePtr Medium (CppInstancePtr @this, [MangleAs ("class UsageEnvironment &")] UsageEnvironment env);
			[Virtual] [Destructor] [Protected] void Destruct (CppInstancePtr @this);
			[Inline] [Protected] [return: MangleAs ("void  * &")] IntPtr nextTask (CppInstancePtr @this);
		}
		public unsafe struct _Medium {
			public UsageEnvironment fEnviron;
			public fixed Char fMediumName [30];
			public IntPtr fNextTask;
		}





		public Medium (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public Medium (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public static uint LookupByName (UsageEnvironment env, string mediumName, Medium resultMedium)
		{
			return impl.lookupByName (env, mediumName, resultMedium);
		}
		public static void Close (UsageEnvironment env, string mediumName)
		{
			impl.close (env, mediumName);
		}
		public static void Close (Medium medium)
		{
			impl.close (medium);
		}
		protected Medium (UsageEnvironment env)
		{
			__cxxi_LayoutClass ();
			Native = impl.Medium (impl.Alloc (this), env);
		}
		protected IntPtr NextTask ()
		{
			return impl.nextTask (Native);
		}

		public UsageEnvironment Envir {
			get {
				return impl.envir (Native);
			}
		}

		public string Name {
			get {
				return impl.name (Native);
			}
		}

		public virtual uint IsSource {
			[OverrideNative ("isSource")] get {
				return impl.isSource (Native);
			}
		}

		public virtual uint IsSink {
			[OverrideNative ("isSink")] get {
				return impl.isSink (Native);
			}
		}

		public virtual uint IsRTCPInstance {
			[OverrideNative ("isRTCPInstance")] get {
				return impl.isRTCPInstance (Native);
			}
		}

		public virtual uint IsRTSPClient {
			[OverrideNative ("isRTSPClient")] get {
				return impl.isRTSPClient (Native);
			}
		}

		public virtual uint IsRTSPServer {
			[OverrideNative ("isRTSPServer")] get {
				return impl.isRTSPServer (Native);
			}
		}

		public virtual uint IsMediaSession {
			[OverrideNative ("isMediaSession")] get {
				return impl.isMediaSession (Native);
			}
		}

		public virtual uint IsServerMediaSession {
			[OverrideNative ("isServerMediaSession")] get {
				return impl.isServerMediaSession (Native);
			}
		}

		public virtual uint IsDarwinInjector {
			[OverrideNative ("isDarwinInjector")] get {
				return impl.isDarwinInjector (Native);
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

