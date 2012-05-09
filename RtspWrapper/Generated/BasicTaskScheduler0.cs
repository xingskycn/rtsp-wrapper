// -------------------------------------------------------------------------
//  Managed wrapper for BasicTaskScheduler0
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class BasicTaskScheduler0 : TaskScheduler {

		private static readonly IBasicTaskScheduler0 impl = Libs.live555.GetClass<IBasicTaskScheduler0,_BasicTaskScheduler0,BasicTaskScheduler0> ("BasicTaskScheduler0");
		public static bool operator!=(BasicTaskScheduler0 a, BasicTaskScheduler0 b) { return !(a == b); }
		public static bool operator==(BasicTaskScheduler0 a, BasicTaskScheduler0 b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as BasicTaskScheduler0); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class BasicTaskScheduler0")]
		public partial interface IBasicTaskScheduler0 : ICppClassOverridable<BasicTaskScheduler0> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr BasicTaskScheduler0 (CppInstancePtr @this, [MangleAs ("class BasicTaskScheduler0 const &")] BasicTaskScheduler0 arg0);
			[Virtual] [Destructor] void Destruct (CppInstancePtr @this);
			[Virtual] void SingleStep (CppInstancePtr @this, uint maxDelayTime);
			[Constructor] [Protected] CppInstancePtr BasicTaskScheduler0 (CppInstancePtr @this);
			CppField<IntPtr> fDelayQueue { get; }
			CppField<IntPtr> fHandlers { get; }
			CppField<int> fLastHandledSocketNum { get; }
			CppField<uint> fTriggersAwaitingHandling { get; }
			CppField<uint> fLastUsedTriggerMask { get; }
			CppField<FramedSource.OnCloseFunc> fTriggeredEventHandlers { get; }
			CppField<IntPtr> fTriggeredEventClientDatas { get; }
			CppField<uint> fLastUsedTriggerNum { get; }
		}
		public unsafe struct _BasicTaskScheduler0 {
			public IntPtr fDelayQueue;
			public IntPtr fHandlers;
			public int fLastHandledSocketNum;
			public uint fTriggersAwaitingHandling;
			public uint fLastUsedTriggerMask;
			[System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst=32)]
			public FramedSource.OnCloseFunc[] fTriggeredEventHandlers;
			[System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst=32)]
			public IntPtr[] fTriggeredEventClientDatas;
			public uint fLastUsedTriggerNum;
		}

		protected IntPtr fDelayQueue {
			get {
				return impl.fDelayQueue [Native];
			}
			set {
				impl.fDelayQueue [Native] = value;
			}
		}
		protected IntPtr fHandlers {
			get {
				return impl.fHandlers [Native];
			}
			set {
				impl.fHandlers [Native] = value;
			}
		}
		protected int fLastHandledSocketNum {
			get {
				return impl.fLastHandledSocketNum [Native];
			}
			set {
				impl.fLastHandledSocketNum [Native] = value;
			}
		}
		protected uint fTriggersAwaitingHandling {
			get {
				return impl.fTriggersAwaitingHandling [Native];
			}
			set {
				impl.fTriggersAwaitingHandling [Native] = value;
			}
		}
		protected uint fLastUsedTriggerMask {
			get {
				return impl.fLastUsedTriggerMask [Native];
			}
			set {
				impl.fLastUsedTriggerMask [Native] = value;
			}
		}
		protected FramedSource.OnCloseFunc fTriggeredEventHandlers {
			get {
				return impl.fTriggeredEventHandlers [Native];
			}
			set {
				impl.fTriggeredEventHandlers [Native] = value;
			}
		}
		protected IntPtr fTriggeredEventClientDatas {
			get {
				return impl.fTriggeredEventClientDatas [Native];
			}
			set {
				impl.fTriggeredEventClientDatas [Native] = value;
			}
		}
		protected uint fLastUsedTriggerNum {
			get {
				return impl.fLastUsedTriggerNum [Native];
			}
			set {
				impl.fLastUsedTriggerNum [Native] = value;
			}
		}




		public BasicTaskScheduler0 (CppTypeInfo subClass)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public BasicTaskScheduler0 (CppInstancePtr native)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("SingleStep")]
		public virtual void SingleStep (uint maxDelayTime)
		{
			impl.SingleStep (Native, maxDelayTime);
		}
		protected BasicTaskScheduler0 ()
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = impl.BasicTaskScheduler0 (impl.Alloc (this));
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

