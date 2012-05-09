// -------------------------------------------------------------------------
//  Managed wrapper for BasicTaskScheduler
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class BasicTaskScheduler : BasicTaskScheduler0 {

		private static readonly IBasicTaskScheduler impl = Libs.live555.GetClass<IBasicTaskScheduler,_BasicTaskScheduler,BasicTaskScheduler> ("BasicTaskScheduler");
		public static bool operator!=(BasicTaskScheduler a, BasicTaskScheduler b) { return !(a == b); }
		public static bool operator==(BasicTaskScheduler a, BasicTaskScheduler b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as BasicTaskScheduler); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class BasicTaskScheduler")]
		public partial interface IBasicTaskScheduler : ICppClassOverridable<BasicTaskScheduler> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr BasicTaskScheduler (CppInstancePtr @this, [MangleAs ("class BasicTaskScheduler const &")] BasicTaskScheduler arg0);
			[Static] [return: MangleAs ("class BasicTaskScheduler *")] BasicTaskScheduler createNew ();
			[Virtual] [Destructor] void Destruct (CppInstancePtr @this);
			[Constructor] [Protected] CppInstancePtr BasicTaskScheduler (CppInstancePtr @this);
			CppField<int> fMaxNumSockets { get; }
			CppField<IntPtr> fReadSet { get; }
			CppField<IntPtr> fWriteSet { get; }
			CppField<IntPtr> fExceptionSet { get; }
		}
		public unsafe struct _BasicTaskScheduler {
			public int fMaxNumSockets;
			public IntPtr fReadSet;
			public IntPtr fWriteSet;
			public IntPtr fExceptionSet;
		}

		protected int fMaxNumSockets {
			get {
				return impl.fMaxNumSockets [Native];
			}
			set {
				impl.fMaxNumSockets [Native] = value;
			}
		}
		protected IntPtr fReadSet {
			get {
				return impl.fReadSet [Native];
			}
			set {
				impl.fReadSet [Native] = value;
			}
		}
		protected IntPtr fWriteSet {
			get {
				return impl.fWriteSet [Native];
			}
			set {
				impl.fWriteSet [Native] = value;
			}
		}
		protected IntPtr fExceptionSet {
			get {
				return impl.fExceptionSet [Native];
			}
			set {
				impl.fExceptionSet [Native] = value;
			}
		}




		public BasicTaskScheduler (CppTypeInfo subClass)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public BasicTaskScheduler (CppInstancePtr native)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public static BasicTaskScheduler CreateNew ()
		{
			return impl.createNew ();
		}
		protected BasicTaskScheduler ()
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = impl.BasicTaskScheduler (impl.Alloc (this));
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

