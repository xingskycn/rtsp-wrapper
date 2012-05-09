// -------------------------------------------------------------------------
//  Managed wrapper for OutPacketBuffer
//  Generated from RTSPClient.xml on 05/08/2012 20:36:35
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class OutPacketBuffer : ICppObject {

		private static readonly IOutPacketBuffer impl = Libs.live555.GetClass<IOutPacketBuffer,_OutPacketBuffer,OutPacketBuffer> ("OutPacketBuffer");
		public CppInstancePtr Native { get; protected set; }
		public static bool operator!=(OutPacketBuffer a, OutPacketBuffer b) { return !(a == b); }
		public static bool operator==(OutPacketBuffer a, OutPacketBuffer b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as OutPacketBuffer); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class OutPacketBuffer")]
		public partial interface IOutPacketBuffer : ICppClassOverridable<OutPacketBuffer> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr OutPacketBuffer (CppInstancePtr @this, [MangleAs ("class OutPacketBuffer const &")] OutPacketBuffer arg0);
			[Constructor] CppInstancePtr OutPacketBuffer (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint preferredPacketSize, [MangleAs ("int  unsigned")] uint maxPacketSize);
			[Destructor] void Destruct (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  unsigned *")] string curPtr (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint totalBytesAvailable (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint totalBufferSize (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  unsigned *")] string packet (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint curPacketSize (CppInstancePtr @this);
			[Inline] void increment (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint numBytes);
			void enqueue (CppInstancePtr @this, [MangleAs ("char  unsigned const *")] string from, [MangleAs ("int  unsigned")] uint numBytes);
			void enqueueWord (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint word);
			void insert (CppInstancePtr @this, [MangleAs ("char  unsigned const *")] string from, [MangleAs ("int  unsigned")] uint numBytes, [MangleAs ("int  unsigned")] uint toPosition);
			void insertWord (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint word, [MangleAs ("int  unsigned")] uint toPosition);
			void extract (CppInstancePtr @this, [MangleAs ("char  unsigned *")] string to, [MangleAs ("int  unsigned")] uint numBytes, [MangleAs ("int  unsigned")] uint fromPosition);
			[return: MangleAs ("int  unsigned")] uint extractWord (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint fromPosition);
			void skipBytes (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint numBytes);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint isPreferredSize (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint wouldOverflow (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint numBytes);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint numOverflowBytes (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint numBytes);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint isTooBigForAPacket (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint numBytes);
			void setOverflowData (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint overflowDataOffset, [MangleAs ("int  unsigned")] uint overflowDataSize, [MangleAs ("struct timeval const &")] timeval presentationTime, [MangleAs ("int  unsigned")] uint durationInMicroseconds);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint overflowDataSize (CppInstancePtr @this);
			[Inline] [Const] [return: ByVal] timeval overflowPresentationTime (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint overflowDurationInMicroseconds (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint haveOverflowData (CppInstancePtr @this);
			void useOverflowData (CppInstancePtr @this);
			void adjustPacketStart (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint numBytes);
			void resetPacketStart (CppInstancePtr @this);
			[Inline] void resetOffset (CppInstancePtr @this);
			[Inline] void resetOverflowData (CppInstancePtr @this);
		}
		public unsafe struct _OutPacketBuffer {
			public uint fPacketStart;
			public uint fCurOffset;
			public uint fPreferred;
			public uint fMax;
			public uint fLimit;
			public string fBuf;
			public uint fOverflowDataOffset;
			public uint fOverflowDataSize;
			public timeval._timeval fOverflowPresentationTime;
			public uint fOverflowDurationInMicroseconds;
		}





		public OutPacketBuffer (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public OutPacketBuffer (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public OutPacketBuffer (uint preferredPacketSize, uint maxPacketSize)
		{
			__cxxi_LayoutClass ();
			Native = impl.OutPacketBuffer (impl.Alloc (this), preferredPacketSize, maxPacketSize);
		}
		public void Increment (uint numBytes)
		{
			impl.increment (Native, numBytes);
		}
		public void Enqueue (string from, uint numBytes)
		{
			impl.enqueue (Native, from, numBytes);
		}
		public void EnqueueWord (uint word)
		{
			impl.enqueueWord (Native, word);
		}
		public void Insert (string from, uint numBytes, uint toPosition)
		{
			impl.insert (Native, from, numBytes, toPosition);
		}
		public void InsertWord (uint word, uint toPosition)
		{
			impl.insertWord (Native, word, toPosition);
		}
		public void Extract (string to, uint numBytes, uint fromPosition)
		{
			impl.extract (Native, to, numBytes, fromPosition);
		}
		public uint ExtractWord (uint fromPosition)
		{
			return impl.extractWord (Native, fromPosition);
		}
		public void SkipBytes (uint numBytes)
		{
			impl.skipBytes (Native, numBytes);
		}
		public uint WouldOverflow (uint numBytes)
		{
			return impl.wouldOverflow (Native, numBytes);
		}
		public uint NumOverflowBytes (uint numBytes)
		{
			return impl.numOverflowBytes (Native, numBytes);
		}
		public uint IsTooBigForAPacket (uint numBytes)
		{
			return impl.isTooBigForAPacket (Native, numBytes);
		}
		public void SetOverflowData (uint overflowDataOffset, uint overflowDataSize, timeval presentationTime, uint durationInMicroseconds)
		{
			impl.setOverflowData (Native, overflowDataOffset, overflowDataSize, presentationTime, durationInMicroseconds);
		}
		public void UseOverflowData ()
		{
			impl.useOverflowData (Native);
		}
		public void AdjustPacketStart (uint numBytes)
		{
			impl.adjustPacketStart (Native, numBytes);
		}
		public void ResetPacketStart ()
		{
			impl.resetPacketStart (Native);
		}
		public void ResetOffset ()
		{
			impl.resetOffset (Native);
		}
		public void ResetOverflowData ()
		{
			impl.resetOverflowData (Native);
		}

		public string CurPtr {
			get {
				return impl.curPtr (Native);
			}
		}

		public uint TotalBytesAvailable {
			get {
				return impl.totalBytesAvailable (Native);
			}
		}

		public uint TotalBufferSize {
			get {
				return impl.totalBufferSize (Native);
			}
		}

		public string Packet {
			get {
				return impl.packet (Native);
			}
		}

		public uint CurPacketSize {
			get {
				return impl.curPacketSize (Native);
			}
		}

		public uint IsPreferredSize {
			get {
				return impl.isPreferredSize (Native);
			}
		}

		public uint OverflowDataSize {
			get {
				return impl.overflowDataSize (Native);
			}
		}

		public timeval OverflowPresentationTime {
			get {
				return impl.overflowPresentationTime (Native);
			}
		}

		public uint OverflowDurationInMicroseconds {
			get {
				return impl.overflowDurationInMicroseconds (Native);
			}
		}

		public uint HaveOverflowData {
			get {
				return impl.haveOverflowData (Native);
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

