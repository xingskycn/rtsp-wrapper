// -------------------------------------------------------------------------
//  Managed wrapper for MediaSink
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class MediaSink : Medium {

		private static readonly IMediaSink impl = Libs.live555.GetClass<IMediaSink,_MediaSink,MediaSink> ("MediaSink");
		public static bool operator!=(MediaSink a, MediaSink b) { return !(a == b); }
		public static bool operator==(MediaSink a, MediaSink b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as MediaSink); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class MediaSink")]
		public partial interface IMediaSink : ICppClassOverridable<MediaSink> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr MediaSink (CppInstancePtr @this, [MangleAs ("class MediaSink const &")] MediaSink arg0);
			[Static] [return: MangleAs ("int  unsigned")] uint lookupByName ([MangleAs ("class UsageEnvironment &")] UsageEnvironment env, [MangleAs ("char  const *")] string sinkName, [MangleAs ("class MediaSink * &")] MediaSink resultSink);
			[return: MangleAs ("int  unsigned")] uint startPlaying (CppInstancePtr @this, [MangleAs ("class MediaSource &")] MediaSource source, [MangleAs ("delegate FramedSource::OnCloseFunc *")] FramedSource.OnCloseFunc afterFunc, [MangleAs ("void  *")] IntPtr afterClientData);
			[Virtual] void stopPlaying (CppInstancePtr @this);
			[Virtual] [Const] [return: MangleAs ("int  unsigned")] uint isRTPSink (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("class FramedSource *")] FramedSource source (CppInstancePtr @this);
			[Constructor] [Protected] CppInstancePtr MediaSink (CppInstancePtr @this, [MangleAs ("class UsageEnvironment &")] UsageEnvironment env);
			[Virtual] [Destructor] [Protected] void Destruct (CppInstancePtr @this);
			[Virtual] [Protected] [return: MangleAs ("int  unsigned")] uint sourceIsCompatibleWithUs (CppInstancePtr @this, MediaSource source);
			[Virtual] [Protected] [return: MangleAs ("int  unsigned")] uint continuePlaying (CppInstancePtr @this);
			[Static] [Protected] void onSourceClosure ([MangleAs ("void  *")] IntPtr clientData);
			CppField<FramedSource> fSource { get; }
		}
		public unsafe struct _MediaSink {
			public FramedSource fSource;
			public FramedSource.OnCloseFunc fAfterFunc;
			public IntPtr fAfterClientData;
		}

		protected FramedSource fSource {
			get {
				return impl.fSource [Native];
			}
			set {
				impl.fSource [Native] = value;
			}
		}




		public MediaSink (CppTypeInfo subClass)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public MediaSink (CppInstancePtr native)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public static uint LookupByName (UsageEnvironment env, string sinkName, MediaSink resultSink)
		{
			return impl.lookupByName (env, sinkName, resultSink);
		}
		public uint StartPlaying (MediaSource source, FramedSource.OnCloseFunc afterFunc, IntPtr afterClientData)
		{
			return impl.startPlaying (Native, source, new WeakDelegate<FramedSource.OnCloseFunc>(afterFunc), afterClientData);
		}
		[OverrideNative ("stopPlaying")]
		public virtual void StopPlaying ()
		{
			impl.stopPlaying (Native);
		}
		protected MediaSink (UsageEnvironment env)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = impl.MediaSink (impl.Alloc (this), env);
		}
		[OverrideNative ("sourceIsCompatibleWithUs")]
		protected virtual uint SourceIsCompatibleWithUs (MediaSource source)
		{
			return impl.sourceIsCompatibleWithUs (Native, source);
		}
		[OverrideNative ("continuePlaying")]
		protected virtual uint ContinuePlaying ()
		{
			return impl.continuePlaying (Native);
		}
		protected static void OnSourceClosure (IntPtr clientData)
		{
			impl.onSourceClosure (clientData);
		}

		public virtual uint IsRTPSink {
			[OverrideNative ("isRTPSink")] get {
				return impl.isRTPSink (Native);
			}
		}

		public FramedSource Source {
			get {
				return impl.source (Native);
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

