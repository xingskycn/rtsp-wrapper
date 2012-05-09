// -------------------------------------------------------------------------
//  Managed wrapper for TaskScheduler
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class TaskScheduler : ICppObject {

		private static readonly ITaskScheduler impl = Libs.live555.GetClass<ITaskScheduler,_TaskScheduler,TaskScheduler> ("TaskScheduler");
		public CppInstancePtr Native { get; protected set; }
		public static bool operator!=(TaskScheduler a, TaskScheduler b) { return !(a == b); }
		public static bool operator==(TaskScheduler a, TaskScheduler b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as TaskScheduler); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class TaskScheduler")]
		public partial interface ITaskScheduler : ICppClassOverridable<TaskScheduler> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr TaskScheduler (CppInstancePtr @this, [MangleAs ("class TaskScheduler const &")] TaskScheduler arg0);
			[Virtual] [Destructor] void Destruct (CppInstancePtr @this);
			[Virtual] [return: MangleAs ("void  *")] IntPtr scheduleDelayedTask (CppInstancePtr @this, long microseconds, FramedSource.OnCloseFunc proc, IntPtr clientData);
			[Virtual] void unscheduleDelayedTask (CppInstancePtr @this, IntPtr prevTask);
			[Virtual] void rescheduleDelayedTask (CppInstancePtr @this, IntPtr task, long microseconds, FramedSource.OnCloseFunc proc, IntPtr clientData);
			[Virtual] void setBackgroundHandling (CppInstancePtr @this, int socketNum, int conditionSet, TaskScheduler.BackgroundHandlerProc handlerProc, IntPtr clientData);
			[Inline] void disableBackgroundHandling (CppInstancePtr @this, int socketNum);
			[Virtual] void moveSocketHandling (CppInstancePtr @this, int oldSocketNum, int newSocketNum);
			[Virtual] void doEventLoop (CppInstancePtr @this, string watchVariable);
			[Virtual] [return: MangleAs ("int  unsigned")] uint createEventTrigger (CppInstancePtr @this, FramedSource.OnCloseFunc eventHandlerProc);
			[Virtual] void deleteEventTrigger (CppInstancePtr @this, uint eventTriggerId);
			[Virtual] void triggerEvent (CppInstancePtr @this, uint eventTriggerId, IntPtr clientData);
			[Inline] void turnOnBackgroundReadHandling (CppInstancePtr @this, int socketNum, [MangleAs ("delegate TaskScheduler::BackgroundHandlerProc *")] TaskScheduler.BackgroundHandlerProc handlerProc, [MangleAs ("void  *")] IntPtr clientData);
			[Inline] void turnOffBackgroundReadHandling (CppInstancePtr @this, int socketNum);
			[Virtual] void internalError (CppInstancePtr @this);
			[Constructor] [Protected] CppInstancePtr TaskScheduler (CppInstancePtr @this);
		}
		public unsafe struct _TaskScheduler {
		}




	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	public delegate void BackgroundHandlerProc ([MangleAs ("void  *")] IntPtr arg0, int arg1);


		public TaskScheduler (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public TaskScheduler (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("scheduleDelayedTask")]
		public virtual IntPtr ScheduleDelayedTask (long microseconds, FramedSource.OnCloseFunc proc, IntPtr clientData)
		{
			return impl.scheduleDelayedTask (Native, microseconds, new WeakDelegate<FramedSource.OnCloseFunc>(proc), clientData);
		}
		[OverrideNative ("unscheduleDelayedTask")]
		public virtual void UnscheduleDelayedTask (IntPtr prevTask)
		{
			impl.unscheduleDelayedTask (Native, prevTask);
		}
		[OverrideNative ("rescheduleDelayedTask")]
		public virtual void RescheduleDelayedTask (IntPtr task, long microseconds, FramedSource.OnCloseFunc proc, IntPtr clientData)
		{
			impl.rescheduleDelayedTask (Native, task, microseconds, new WeakDelegate<FramedSource.OnCloseFunc>(proc), clientData);
		}
		[OverrideNative ("setBackgroundHandling")]
		public virtual void SetBackgroundHandling (int socketNum, int conditionSet, TaskScheduler.BackgroundHandlerProc handlerProc, IntPtr clientData)
		{
			impl.setBackgroundHandling (Native, socketNum, conditionSet, new WeakDelegate<TaskScheduler.BackgroundHandlerProc>(handlerProc), clientData);
		}
		public void DisableBackgroundHandling (int socketNum)
		{
			impl.disableBackgroundHandling (Native, socketNum);
		}
		[OverrideNative ("moveSocketHandling")]
		public virtual void MoveSocketHandling (int oldSocketNum, int newSocketNum)
		{
			impl.moveSocketHandling (Native, oldSocketNum, newSocketNum);
		}
		[OverrideNative ("doEventLoop")]
		public virtual void DoEventLoop (string watchVariable)
		{
			impl.doEventLoop (Native, watchVariable);
		}
		[OverrideNative ("createEventTrigger")]
		public virtual uint CreateEventTrigger (FramedSource.OnCloseFunc eventHandlerProc)
		{
			return impl.createEventTrigger (Native, new WeakDelegate<FramedSource.OnCloseFunc>(eventHandlerProc));
		}
		[OverrideNative ("deleteEventTrigger")]
		public virtual void DeleteEventTrigger (uint eventTriggerId)
		{
			impl.deleteEventTrigger (Native, eventTriggerId);
		}
		[OverrideNative ("triggerEvent")]
		public virtual void TriggerEvent (uint eventTriggerId, IntPtr clientData)
		{
			impl.triggerEvent (Native, eventTriggerId, clientData);
		}
		public void TurnOnBackgroundReadHandling (int socketNum, TaskScheduler.BackgroundHandlerProc handlerProc, IntPtr clientData)
		{
			impl.turnOnBackgroundReadHandling (Native, socketNum, new WeakDelegate<TaskScheduler.BackgroundHandlerProc>(handlerProc), clientData);
		}
		public void TurnOffBackgroundReadHandling (int socketNum)
		{
			impl.turnOffBackgroundReadHandling (Native, socketNum);
		}
		[OverrideNative ("internalError")]
		public virtual void InternalError ()
		{
			impl.internalError (Native);
		}
		protected TaskScheduler ()
		{
			__cxxi_LayoutClass ();
			Native = impl.TaskScheduler (impl.Alloc (this));
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

