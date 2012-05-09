// -------------------------------------------------------------------------
//  Managed wrapper for MediaSource
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class MediaSource : Medium {

		private static readonly IMediaSource impl = Libs.live555.GetClass<IMediaSource,_MediaSource,MediaSource> ("MediaSource");
		public static bool operator!=(MediaSource a, MediaSource b) { return !(a == b); }
		public static bool operator==(MediaSource a, MediaSource b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as MediaSource); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class MediaSource")]
		public partial interface IMediaSource : ICppClassOverridable<MediaSource> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr MediaSource (CppInstancePtr @this, [MangleAs ("class MediaSource const &")] MediaSource arg0);
			[Static] [return: MangleAs ("int  unsigned")] uint lookupByName ([MangleAs ("class UsageEnvironment &")] UsageEnvironment env, [MangleAs ("char  const *")] string sourceName, [MangleAs ("class MediaSource * &")] MediaSource resultSource);
			[Virtual] [Const] void getAttributes (CppInstancePtr @this);
			[Virtual] [Const] [return: MangleAs ("char  const *")] string MIMEtype (CppInstancePtr @this);
			[Virtual] [Const] [return: MangleAs ("int  unsigned")] uint isFramedSource (CppInstancePtr @this);
			[Virtual] [Const] [return: MangleAs ("int  unsigned")] uint isRTPSource (CppInstancePtr @this);
			[Virtual] [Const] [return: MangleAs ("int  unsigned")] uint isMPEG1or2VideoStreamFramer (CppInstancePtr @this);
			[Virtual] [Const] [return: MangleAs ("int  unsigned")] uint isMPEG4VideoStreamFramer (CppInstancePtr @this);
			[Virtual] [Const] [return: MangleAs ("int  unsigned")] uint isH264VideoStreamFramer (CppInstancePtr @this);
			[Virtual] [Const] [return: MangleAs ("int  unsigned")] uint isDVVideoStreamFramer (CppInstancePtr @this);
			[Virtual] [Const] [return: MangleAs ("int  unsigned")] uint isJPEGVideoSource (CppInstancePtr @this);
			[Virtual] [Const] [return: MangleAs ("int  unsigned")] uint isAMRAudioSource (CppInstancePtr @this);
			[Constructor] [Protected] CppInstancePtr MediaSource (CppInstancePtr @this, [MangleAs ("class UsageEnvironment &")] UsageEnvironment env);
			[Virtual] [Destructor] [Protected] void Destruct (CppInstancePtr @this);
		}
		public unsafe struct _MediaSource {
		}





		public MediaSource (CppTypeInfo subClass)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public MediaSource (CppInstancePtr native)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public static uint LookupByName (UsageEnvironment env, string sourceName, MediaSource resultSource)
		{
			return impl.lookupByName (env, sourceName, resultSource);
		}
		[OverrideNative ("getAttributes")]
		public virtual void GetAttributes ()
		{
			impl.getAttributes (Native);
		}
		protected MediaSource (UsageEnvironment env)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = impl.MediaSource (impl.Alloc (this), env);
		}

		public virtual string MIMEtype {
			[OverrideNative ("MIMEtype")] get {
				return impl.MIMEtype (Native);
			}
		}

		public virtual uint IsFramedSource {
			[OverrideNative ("isFramedSource")] get {
				return impl.isFramedSource (Native);
			}
		}

		public virtual uint IsRTPSource {
			[OverrideNative ("isRTPSource")] get {
				return impl.isRTPSource (Native);
			}
		}

		public virtual uint IsMPEG1or2VideoStreamFramer {
			[OverrideNative ("isMPEG1or2VideoStreamFramer")] get {
				return impl.isMPEG1or2VideoStreamFramer (Native);
			}
		}

		public virtual uint IsMPEG4VideoStreamFramer {
			[OverrideNative ("isMPEG4VideoStreamFramer")] get {
				return impl.isMPEG4VideoStreamFramer (Native);
			}
		}

		public virtual uint IsH264VideoStreamFramer {
			[OverrideNative ("isH264VideoStreamFramer")] get {
				return impl.isH264VideoStreamFramer (Native);
			}
		}

		public virtual uint IsDVVideoStreamFramer {
			[OverrideNative ("isDVVideoStreamFramer")] get {
				return impl.isDVVideoStreamFramer (Native);
			}
		}

		public virtual uint IsJPEGVideoSource {
			[OverrideNative ("isJPEGVideoSource")] get {
				return impl.isJPEGVideoSource (Native);
			}
		}

		public virtual uint IsAMRAudioSource {
			[OverrideNative ("isAMRAudioSource")] get {
				return impl.isAMRAudioSource (Native);
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

