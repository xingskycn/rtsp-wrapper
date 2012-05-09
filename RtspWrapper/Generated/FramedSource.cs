// -------------------------------------------------------------------------
//  Managed wrapper for FramedSource
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class FramedSource : MediaSource {

		private static readonly IFramedSource impl = Libs.live555.GetClass<IFramedSource,_FramedSource,FramedSource> ("FramedSource");
		public static bool operator!=(FramedSource a, FramedSource b) { return !(a == b); }
		public static bool operator==(FramedSource a, FramedSource b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as FramedSource); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class FramedSource")]
		public partial interface IFramedSource : ICppClassOverridable<FramedSource> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr FramedSource (CppInstancePtr @this, [MangleAs ("class FramedSource const &")] FramedSource arg0);
			[Static] [return: MangleAs ("int  unsigned")] uint lookupByName ([MangleAs ("class UsageEnvironment &")] UsageEnvironment env, [MangleAs ("char  const *")] string sourceName, [MangleAs ("class FramedSource * &")] FramedSource resultSource);
			void getNextFrame (CppInstancePtr @this, [MangleAs ("char  unsigned *")] string to, [MangleAs ("int  unsigned")] uint maxSize, [MangleAs ("delegate FramedSource::AfterGettingFunc *")] AfterGettingFunc afterGettingFunc, [MangleAs ("void  *")] IntPtr afterGettingClientData, [MangleAs ("delegate FramedSource::OnCloseFunc *")] OnCloseFunc onCloseFunc, [MangleAs ("void  *")] IntPtr onCloseClientData);
			[Static] void handleClosure ([MangleAs ("void  *")] IntPtr clientData);
			void stopGettingFrames (CppInstancePtr @this);
			[Virtual] [Const] [return: MangleAs ("int  unsigned")] uint maxFrameSize (CppInstancePtr @this);
			[Virtual] void doGetNextFrame (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint isCurrentlyAwaitingData (CppInstancePtr @this);
			[Static] void afterGetting ([MangleAs ("class FramedSource *")] FramedSource source);
			[Constructor] [Protected] CppInstancePtr FramedSource (CppInstancePtr @this, [MangleAs ("class UsageEnvironment &")] UsageEnvironment env);
			[Virtual] [Destructor] [Protected] void Destruct (CppInstancePtr @this);
			[Virtual] [Protected] void doStopGettingFrames (CppInstancePtr @this);
			CppField<string> fTo { get; }
			CppField<uint> fMaxSize { get; }
			CppField<uint> fFrameSize { get; }
			CppField<uint> fNumTruncatedBytes { get; }
			CppField<timeval> fPresentationTime { get; }
			CppField<uint> fDurationInMicroseconds { get; }
		}
		public unsafe struct _FramedSource {
			public string fTo;
			public uint fMaxSize;
			public uint fFrameSize;
			public uint fNumTruncatedBytes;
			public timeval._timeval fPresentationTime;
			public uint fDurationInMicroseconds;
			public FramedSource.AfterGettingFunc fAfterGettingFunc;
			public IntPtr fAfterGettingClientData;
			public FramedSource.OnCloseFunc fOnCloseFunc;
			public IntPtr fOnCloseClientData;
			public uint fIsCurrentlyAwaitingData;
		}

		protected string fTo {
			get {
				return impl.fTo [Native];
			}
			set {
				impl.fTo [Native] = value;
			}
		}
		protected uint fMaxSize {
			get {
				return impl.fMaxSize [Native];
			}
			set {
				impl.fMaxSize [Native] = value;
			}
		}
		protected uint fFrameSize {
			get {
				return impl.fFrameSize [Native];
			}
			set {
				impl.fFrameSize [Native] = value;
			}
		}
		protected uint fNumTruncatedBytes {
			get {
				return impl.fNumTruncatedBytes [Native];
			}
			set {
				impl.fNumTruncatedBytes [Native] = value;
			}
		}
		protected timeval fPresentationTime {
			get {
				return impl.fPresentationTime [Native];
			}
			set {
				impl.fPresentationTime [Native] = value;
			}
		}
		protected uint fDurationInMicroseconds {
			get {
				return impl.fDurationInMicroseconds [Native];
			}
			set {
				impl.fDurationInMicroseconds [Native] = value;
			}
		}



	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	public delegate void AfterGettingFunc ([MangleAs ("void  *")] IntPtr arg0, [MangleAs ("int  unsigned")] uint arg1, [MangleAs ("int  unsigned")] uint arg2, [MangleAs ("struct timeval")] [ByVal] timeval arg3, [MangleAs ("int  unsigned")] uint arg4);

	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	public delegate void OnCloseFunc ([MangleAs ("void  *")] IntPtr arg0);


		public FramedSource (CppTypeInfo subClass)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public FramedSource (CppInstancePtr native)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public static uint LookupByName (UsageEnvironment env, string sourceName, FramedSource resultSource)
		{
			return impl.lookupByName (env, sourceName, resultSource);
		}
		public void GetNextFrame (string to, uint maxSize, FramedSource.AfterGettingFunc afterGettingFunc, IntPtr afterGettingClientData, FramedSource.OnCloseFunc onCloseFunc, IntPtr onCloseClientData)
		{
			impl.getNextFrame (Native, to, maxSize, new WeakDelegate<FramedSource.AfterGettingFunc>(afterGettingFunc), afterGettingClientData, new WeakDelegate<FramedSource.OnCloseFunc>(onCloseFunc), onCloseClientData);
		}
		public static void HandleClosure (IntPtr clientData)
		{
			impl.handleClosure (clientData);
		}
		public void StopGettingFrames ()
		{
			impl.stopGettingFrames (Native);
		}
		[OverrideNative ("doGetNextFrame")]
		public virtual void DoGetNextFrame ()
		{
			impl.doGetNextFrame (Native);
		}
		public static void AfterGetting (FramedSource source)
		{
			impl.afterGetting (source);
		}
		protected FramedSource (UsageEnvironment env)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = impl.FramedSource (impl.Alloc (this), env);
		}
		[OverrideNative ("doStopGettingFrames")]
		protected virtual void DoStopGettingFrames ()
		{
			impl.doStopGettingFrames (Native);
		}

		public virtual uint MaxFrameSize {
			[OverrideNative ("maxFrameSize")] get {
				return impl.maxFrameSize (Native);
			}
		}

		public uint IsCurrentlyAwaitingData {
			get {
				return impl.isCurrentlyAwaitingData (Native);
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

