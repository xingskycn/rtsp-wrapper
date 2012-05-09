// -------------------------------------------------------------------------
//  Managed wrapper for GroupEId
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class GroupEId : ICppObject {

		private static readonly IGroupEId impl = Libs.live555.GetClass<IGroupEId,_GroupEId,GroupEId> ("GroupEId");
		public CppInstancePtr Native { get; protected set; }
		public static bool operator!=(GroupEId a, GroupEId b) { return !(a == b); }
		public static bool operator==(GroupEId a, GroupEId b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as GroupEId); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class GroupEId")]
		public partial interface IGroupEId : ICppClassOverridable<GroupEId> {
			[Artificial] [Inline] [Destructor] void Destruct (CppInstancePtr @this);
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr GroupEId (CppInstancePtr @this, [MangleAs ("class GroupEId const &")] GroupEId arg0);
			[Constructor] CppInstancePtr GroupEId (CppInstancePtr @this, [MangleAs ("struct in_addr const &")] in_addr groupAddr, [MangleAs ("int  short unsigned")] ushort portNum, [MangleAs ("class Scope const &")] Scope scope, [MangleAs ("int  unsigned")] uint numSuccessiveGroupAddrs);
			[Constructor] CppInstancePtr GroupEId (CppInstancePtr @this, [MangleAs ("struct in_addr const &")] in_addr groupAddr, [MangleAs ("struct in_addr const &")] in_addr sourceFilterAddr, [MangleAs ("int  short unsigned")] ushort portNum, [MangleAs ("int  unsigned")] uint numSuccessiveGroupAddrs);
			[Constructor] CppInstancePtr GroupEId (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("struct in_addr const &")] in_addr groupAddress (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("struct in_addr const &")] in_addr sourceFilterAddress (CppInstancePtr @this);
			[Const] [return: MangleAs ("int  unsigned")] uint isSSM (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint numSuccessiveGroupAddrs (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  short unsigned")] ushort portNum (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("class Scope const &")] Scope scope (CppInstancePtr @this);
		}
		public unsafe struct _GroupEId {
			public in_addr._in_addr fGroupAddress;
			public in_addr._in_addr fSourceFilterAddress;
			public uint fNumSuccessiveGroupAddrs;
			public ushort fPortNum;
			public Scope._Scope fScope;
		}





		public GroupEId (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public GroupEId (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public GroupEId (in_addr groupAddr, ushort portNum, Scope scope, uint numSuccessiveGroupAddrs)
		{
			__cxxi_LayoutClass ();
			Native = impl.GroupEId (impl.Alloc (this), groupAddr, portNum, scope, numSuccessiveGroupAddrs);
		}
		public GroupEId (in_addr groupAddr, in_addr sourceFilterAddr, ushort portNum, uint numSuccessiveGroupAddrs)
		{
			__cxxi_LayoutClass ();
			Native = impl.GroupEId (impl.Alloc (this), groupAddr, sourceFilterAddr, portNum, numSuccessiveGroupAddrs);
		}
		public GroupEId ()
		{
			__cxxi_LayoutClass ();
			Native = impl.GroupEId (impl.Alloc (this));
		}

		public in_addr GroupAddress {
			get {
				return impl.groupAddress (Native);
			}
		}

		public in_addr SourceFilterAddress {
			get {
				return impl.sourceFilterAddress (Native);
			}
		}

		public uint IsSSM {
			get {
				return impl.isSSM (Native);
			}
		}

		public uint NumSuccessiveGroupAddrs {
			get {
				return impl.numSuccessiveGroupAddrs (Native);
			}
		}

		public ushort PortNum {
			get {
				return impl.portNum (Native);
			}
		}

		public Scope Scope {
			get {
				return impl.scope (Native);
			}
		}


		partial void BeforeDestruct ();
		partial void AfterDestruct ();

		public virtual void Dispose ()
		{
			BeforeDestruct ();
			Native.Dispose ();
			AfterDestruct ();
		}

		private void __cxxi_LayoutClass ()
		{
			impl.TypeInfo.CompleteType ();
		}

	}
}

