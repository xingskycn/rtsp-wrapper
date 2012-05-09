// -------------------------------------------------------------------------
//  Managed wrapper for MediaSubsessionIterator
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class MediaSubsessionIterator : ICppObject {

		private static readonly IMediaSubsessionIterator impl = Libs.live555.GetClass<IMediaSubsessionIterator,_MediaSubsessionIterator,MediaSubsessionIterator> ("MediaSubsessionIterator");
		public CppInstancePtr Native { get; protected set; }
		public static bool operator!=(MediaSubsessionIterator a, MediaSubsessionIterator b) { return !(a == b); }
		public static bool operator==(MediaSubsessionIterator a, MediaSubsessionIterator b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as MediaSubsessionIterator); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class MediaSubsessionIterator")]
		public partial interface IMediaSubsessionIterator : ICppClassOverridable<MediaSubsessionIterator> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr MediaSubsessionIterator (CppInstancePtr @this, [MangleAs ("class MediaSubsessionIterator const &")] MediaSubsessionIterator arg0);
			[Constructor] CppInstancePtr MediaSubsessionIterator (CppInstancePtr @this, [MangleAs ("class MediaSession &")] MediaSession session);
			[Virtual] [Destructor] void Destruct (CppInstancePtr @this);
			[return: MangleAs ("class MediaSubsession *")] MediaSubsession next (CppInstancePtr @this);
			void reset (CppInstancePtr @this);
		}
		public unsafe struct _MediaSubsessionIterator {
			public MediaSession fOurSession;
			public MediaSubsession fNextPtr;
		}





		public MediaSubsessionIterator (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public MediaSubsessionIterator (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public MediaSubsessionIterator (MediaSession session)
		{
			__cxxi_LayoutClass ();
			Native = impl.MediaSubsessionIterator (impl.Alloc (this), session);
		}
		public MediaSubsession Next ()
		{
			return impl.next (Native);
		}
		public void Reset ()
		{
			impl.reset (Native);
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

