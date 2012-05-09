// -------------------------------------------------------------------------
//  Managed wrapper for BasicUsageEnvironment0
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class BasicUsageEnvironment0 : UsageEnvironment {

		private static readonly IBasicUsageEnvironment0 impl = Libs.live555.GetClass<IBasicUsageEnvironment0,_BasicUsageEnvironment0,BasicUsageEnvironment0> ("BasicUsageEnvironment0");
		public static bool operator!=(BasicUsageEnvironment0 a, BasicUsageEnvironment0 b) { return !(a == b); }
		public static bool operator==(BasicUsageEnvironment0 a, BasicUsageEnvironment0 b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as BasicUsageEnvironment0); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class BasicUsageEnvironment0")]
		public partial interface IBasicUsageEnvironment0 : ICppClassOverridable<BasicUsageEnvironment0> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr BasicUsageEnvironment0 (CppInstancePtr @this, [MangleAs ("class BasicUsageEnvironment0 const &")] BasicUsageEnvironment0 arg0);
			[Constructor] [Protected] CppInstancePtr BasicUsageEnvironment0 (CppInstancePtr @this, [MangleAs ("class TaskScheduler &")] TaskScheduler taskScheduler);
			[Virtual] [Destructor] [Protected] void Destruct (CppInstancePtr @this);
		}
		public unsafe struct _BasicUsageEnvironment0 {
			public fixed Char fResultMsgBuffer [1000];
			public uint fCurBufferSize;
			public uint fBufferMaxSize;
		}





		public BasicUsageEnvironment0 (CppTypeInfo subClass)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public BasicUsageEnvironment0 (CppInstancePtr native)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		protected BasicUsageEnvironment0 (TaskScheduler taskScheduler)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = impl.BasicUsageEnvironment0 (impl.Alloc (this), taskScheduler);
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

