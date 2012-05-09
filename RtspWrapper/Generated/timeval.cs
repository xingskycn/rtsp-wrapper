// -------------------------------------------------------------------------
//  Managed wrapper for timeval
//  Generated from RTSPClient.xml on 05/08/2012 20:36:33
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class timeval : ICppObject {

		private static readonly Itimeval impl = Libs.live555.GetClass<Itimeval,_timeval,timeval> ("timeval");
		public CppInstancePtr Native { get; protected set; }
		public static bool operator!=(timeval a, timeval b) { return !(a == b); }
		public static bool operator==(timeval a, timeval b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as timeval); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("struct timeval")]
		public partial interface Itimeval : ICppClassOverridable<timeval> {
			[Artificial] [Inline] [Destructor] void Destruct (CppInstancePtr @this);
			[Artificial] [Inline] [Constructor] CppInstancePtr timeval (CppInstancePtr @this, [MangleAs ("struct timeval const &")] timeval arg0);
			[Artificial] [Inline] [Constructor] CppInstancePtr timeval (CppInstancePtr @this);
			CppField<int> tv_sec { get; }
			CppField<int> tv_usec { get; }
		}
		public unsafe struct _timeval {
			public int tv_sec;
			public int tv_usec;
		}

		public int tv_sec {
			get {
				return impl.tv_sec [Native];
			}
			set {
				impl.tv_sec [Native] = value;
			}
		}
		public int tv_usec {
			get {
				return impl.tv_usec [Native];
			}
			set {
				impl.tv_usec [Native] = value;
			}
		}




		public timeval (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public timeval (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
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

