// -------------------------------------------------------------------------
//  Managed wrapper for UsageEnvironment
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class UsageEnvironment : ICppObject {

		private static readonly IUsageEnvironment impl = Libs.live555.GetClass<IUsageEnvironment,_UsageEnvironment,UsageEnvironment> ("UsageEnvironment");
		public CppInstancePtr Native { get; protected set; }
		public static bool operator!=(UsageEnvironment a, UsageEnvironment b) { return !(a == b); }
		public static bool operator==(UsageEnvironment a, UsageEnvironment b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as UsageEnvironment); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class UsageEnvironment")]
		public partial interface IUsageEnvironment : ICppClassOverridable<UsageEnvironment> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr UsageEnvironment (CppInstancePtr @this, [MangleAs ("class UsageEnvironment const &")] UsageEnvironment arg0);
			void reclaim (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("class TaskScheduler &")] TaskScheduler taskScheduler (CppInstancePtr @this);
			[Virtual] [Const] [return: MangleAs ("char  const *")] string getResultMsg (CppInstancePtr @this);
			[Virtual] void setResultMsg (CppInstancePtr @this, string msg);
			[Virtual] void setResultMsg (CppInstancePtr @this, string msg1, string msg2);
			[Virtual] void setResultMsg (CppInstancePtr @this, string msg1, string msg2, string msg3);
			[Virtual] void setResultErrMsg (CppInstancePtr @this, string msg, int err);
			[Virtual] void appendToResultMsg (CppInstancePtr @this, string msg);
			[Virtual] void reportBackgroundError (CppInstancePtr @this);
			[Virtual] void internalError (CppInstancePtr @this);
			[Virtual] [Const] int getErrno (CppInstancePtr @this);
			[Constructor] [Protected] CppInstancePtr UsageEnvironment (CppInstancePtr @this, [MangleAs ("class TaskScheduler &")] TaskScheduler scheduler);
			[Virtual] [Destructor] [Protected] void Destruct (CppInstancePtr @this);
			CppField<IntPtr> liveMediaPriv { get; }
			CppField<IntPtr> groupsockPriv { get; }
		}
		public unsafe struct _UsageEnvironment {
			public IntPtr liveMediaPriv;
			public IntPtr groupsockPriv;
			public TaskScheduler fScheduler;
		}

		public IntPtr liveMediaPriv {
			get {
				return impl.liveMediaPriv [Native];
			}
			set {
				impl.liveMediaPriv [Native] = value;
			}
		}
		public IntPtr groupsockPriv {
			get {
				return impl.groupsockPriv [Native];
			}
			set {
				impl.groupsockPriv [Native] = value;
			}
		}




		public UsageEnvironment (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public UsageEnvironment (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public void Reclaim ()
		{
			impl.reclaim (Native);
		}
		[OverrideNative ("setResultMsg")]
		public virtual void SetResultMsg (string msg)
		{
			impl.setResultMsg (Native, msg);
		}
		[OverrideNative ("setResultMsg")]
		public virtual void SetResultMsg (string msg1, string msg2)
		{
			impl.setResultMsg (Native, msg1, msg2);
		}
		[OverrideNative ("setResultMsg")]
		public virtual void SetResultMsg (string msg1, string msg2, string msg3)
		{
			impl.setResultMsg (Native, msg1, msg2, msg3);
		}
		[OverrideNative ("setResultErrMsg")]
		public virtual void SetResultErrMsg (string msg, int err)
		{
			impl.setResultErrMsg (Native, msg, err);
		}
		[OverrideNative ("appendToResultMsg")]
		public virtual void AppendToResultMsg (string msg)
		{
			impl.appendToResultMsg (Native, msg);
		}
		[OverrideNative ("reportBackgroundError")]
		public virtual void ReportBackgroundError ()
		{
			impl.reportBackgroundError (Native);
		}
		[OverrideNative ("internalError")]
		public virtual void InternalError ()
		{
			impl.internalError (Native);
		}
		protected UsageEnvironment (TaskScheduler scheduler)
		{
			__cxxi_LayoutClass ();
			Native = impl.UsageEnvironment (impl.Alloc (this), scheduler);
		}

		public TaskScheduler TaskScheduler {
			get {
				return impl.taskScheduler (Native);
			}
		}

		public virtual string GetResultMsg {
			[OverrideNative ("getResultMsg")] get {
				return impl.getResultMsg (Native);
			}
		}

		public virtual int GetErrno {
			[OverrideNative ("getErrno")] get {
				return impl.getErrno (Native);
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

