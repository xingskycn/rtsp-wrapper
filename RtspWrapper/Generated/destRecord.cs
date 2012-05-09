// -------------------------------------------------------------------------
//  Managed wrapper for destRecord
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class destRecord : ICppObject {

		private static readonly IdestRecord impl = Libs.live555.GetClass<IdestRecord,_destRecord,destRecord> ("destRecord");
		public CppInstancePtr Native { get; protected set; }
		public static bool operator!=(destRecord a, destRecord b) { return !(a == b); }
		public static bool operator==(destRecord a, destRecord b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as destRecord); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class destRecord")]
		public partial interface IdestRecord : ICppClassOverridable<destRecord> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr destRecord (CppInstancePtr @this, [MangleAs ("class destRecord const &")] destRecord arg0);
			[Constructor] CppInstancePtr destRecord (CppInstancePtr @this, [MangleAs ("struct in_addr const &")] in_addr addr, [MangleAs ("class Port const &")] Port port, [MangleAs ("char  unsigned")] char ttl, [MangleAs ("class destRecord *")] destRecord next);
			[Virtual] [Destructor] void Destruct (CppInstancePtr @this);
			CppField<destRecord> fNext { get; }
			CppField<GroupEId> fGroupEId { get; }
			CppField<Port> fPort { get; }
		}
		public unsafe struct _destRecord {
			public destRecord fNext;
			public GroupEId._GroupEId fGroupEId;
			public Port._Port fPort;
		}

		public destRecord fNext {
			get {
				return impl.fNext [Native];
			}
			set {
				impl.fNext [Native] = value;
			}
		}
		public GroupEId fGroupEId {
			get {
				return impl.fGroupEId [Native];
			}
			set {
				impl.fGroupEId [Native] = value;
			}
		}
		public Port fPort {
			get {
				return impl.fPort [Native];
			}
			set {
				impl.fPort [Native] = value;
			}
		}




		public destRecord (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public destRecord (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public destRecord (in_addr addr, Port port, char ttl, destRecord next)
		{
			__cxxi_LayoutClass ();
			Native = impl.destRecord (impl.Alloc (this), addr, port, ttl, next);
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

