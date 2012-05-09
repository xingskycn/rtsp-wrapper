// -------------------------------------------------------------------------
//  Managed wrapper for BasicUsageEnvironment
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class BasicUsageEnvironment : BasicUsageEnvironment0 {

		private static readonly IBasicUsageEnvironment impl = Libs.live555.GetClass<IBasicUsageEnvironment,_BasicUsageEnvironment,BasicUsageEnvironment> ("BasicUsageEnvironment");
		public static bool operator!=(BasicUsageEnvironment a, BasicUsageEnvironment b) { return !(a == b); }
		public static bool operator==(BasicUsageEnvironment a, BasicUsageEnvironment b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as BasicUsageEnvironment); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class BasicUsageEnvironment")]
		public partial interface IBasicUsageEnvironment : ICppClassOverridable<BasicUsageEnvironment> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr BasicUsageEnvironment (CppInstancePtr @this, [MangleAs ("class BasicUsageEnvironment const &")] BasicUsageEnvironment arg0);
			[Static] [return: MangleAs ("class BasicUsageEnvironment *")] BasicUsageEnvironment createNew ([MangleAs ("class TaskScheduler &")] TaskScheduler taskScheduler);
			[Constructor] [Protected] CppInstancePtr BasicUsageEnvironment (CppInstancePtr @this, [MangleAs ("class TaskScheduler &")] TaskScheduler taskScheduler);
			[Virtual] [Destructor] [Protected] void Destruct (CppInstancePtr @this);
		}
		public unsafe struct _BasicUsageEnvironment {
		}





		public BasicUsageEnvironment (CppTypeInfo subClass)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public BasicUsageEnvironment (CppInstancePtr native)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public static BasicUsageEnvironment CreateNew (TaskScheduler taskScheduler)
		{
			return impl.createNew (taskScheduler);
		}
		protected BasicUsageEnvironment (TaskScheduler taskScheduler)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = impl.BasicUsageEnvironment (impl.Alloc (this), taskScheduler);
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

