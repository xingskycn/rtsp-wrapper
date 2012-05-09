// -------------------------------------------------------------------------
//  Managed wrapper for FramedFilter
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class FramedFilter : FramedSource {

		private static readonly IFramedFilter impl = Libs.live555.GetClass<IFramedFilter,_FramedFilter,FramedFilter> ("FramedFilter");
		public static bool operator!=(FramedFilter a, FramedFilter b) { return !(a == b); }
		public static bool operator==(FramedFilter a, FramedFilter b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as FramedFilter); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class FramedFilter")]
		public partial interface IFramedFilter : ICppClassOverridable<FramedFilter> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr FramedFilter (CppInstancePtr @this, [MangleAs ("class FramedFilter const &")] FramedFilter arg0);
			[Inline] [Const] [return: MangleAs ("class FramedSource *")] FramedSource inputSource (CppInstancePtr @this);
			[Inline] void detachInputSource (CppInstancePtr @this);
			[Constructor] [Protected] CppInstancePtr FramedFilter (CppInstancePtr @this, [MangleAs ("class UsageEnvironment &")] UsageEnvironment env, [MangleAs ("class FramedSource *")] FramedSource inputSource);
			[Virtual] [Destructor] [Protected] void Destruct (CppInstancePtr @this);
			CppField<FramedSource> fInputSource { get; }
		}
		public unsafe struct _FramedFilter {
			public FramedSource fInputSource;
		}

		protected FramedSource fInputSource {
			get {
				return impl.fInputSource [Native];
			}
			set {
				impl.fInputSource [Native] = value;
			}
		}




		public FramedFilter (CppTypeInfo subClass)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public FramedFilter (CppInstancePtr native)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public void DetachInputSource ()
		{
			impl.detachInputSource (Native);
		}
		protected FramedFilter (UsageEnvironment env, FramedSource inputSource)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = impl.FramedFilter (impl.Alloc (this), env, inputSource);
		}

		public FramedSource InputSource {
			get {
				return impl.inputSource (Native);
			}
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

