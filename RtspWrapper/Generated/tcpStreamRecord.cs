// -------------------------------------------------------------------------
//  Managed wrapper for tcpStreamRecord
//  Generated from RTSPClient.xml on 05/08/2012 20:36:35
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class tcpStreamRecord : ICppObject {

		private static readonly ItcpStreamRecord impl = Libs.live555.GetClass<ItcpStreamRecord,_tcpStreamRecord,tcpStreamRecord> ("tcpStreamRecord");
		public CppInstancePtr Native { get; protected set; }
		public static bool operator!=(tcpStreamRecord a, tcpStreamRecord b) { return !(a == b); }
		public static bool operator==(tcpStreamRecord a, tcpStreamRecord b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as tcpStreamRecord); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class tcpStreamRecord")]
		public partial interface ItcpStreamRecord : ICppClassOverridable<tcpStreamRecord> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr tcpStreamRecord (CppInstancePtr @this, [MangleAs ("class tcpStreamRecord const &")] tcpStreamRecord arg0);
			[Constructor] CppInstancePtr tcpStreamRecord (CppInstancePtr @this, int streamSocketNum, [MangleAs ("char  unsigned")] char streamChannelId, [MangleAs ("class tcpStreamRecord *")] tcpStreamRecord next);
			[Virtual] [Destructor] void Destruct (CppInstancePtr @this);
			CppField<tcpStreamRecord> fNext { get; }
			CppField<int> fStreamSocketNum { get; }
			CppField<char> fStreamChannelId { get; }
		}
		public unsafe struct _tcpStreamRecord {
			public tcpStreamRecord fNext;
			public int fStreamSocketNum;
			public char fStreamChannelId;
		}

		public tcpStreamRecord fNext {
			get {
				return impl.fNext [Native];
			}
			set {
				impl.fNext [Native] = value;
			}
		}
		public int fStreamSocketNum {
			get {
				return impl.fStreamSocketNum [Native];
			}
			set {
				impl.fStreamSocketNum [Native] = value;
			}
		}
		public char fStreamChannelId {
			get {
				return impl.fStreamChannelId [Native];
			}
			set {
				impl.fStreamChannelId [Native] = value;
			}
		}




		public tcpStreamRecord (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public tcpStreamRecord (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public tcpStreamRecord (int streamSocketNum, char streamChannelId, tcpStreamRecord next)
		{
			__cxxi_LayoutClass ();
			Native = impl.tcpStreamRecord (impl.Alloc (this), streamSocketNum, streamChannelId, next);
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

