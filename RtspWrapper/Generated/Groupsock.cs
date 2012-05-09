// -------------------------------------------------------------------------
//  Managed wrapper for Groupsock
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class Groupsock : OutputSocket {

		private static readonly IGroupsock impl = Libs.live555.GetClass<IGroupsock,_Groupsock,Groupsock> ("Groupsock");
		public static bool operator!=(Groupsock a, Groupsock b) { return !(a == b); }
		public static bool operator==(Groupsock a, Groupsock b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as Groupsock); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class Groupsock")]
		public partial interface IGroupsock : ICppClassOverridable<Groupsock> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr Groupsock (CppInstancePtr @this, [MangleAs ("class Groupsock const &")] Groupsock arg0);
			[Constructor] CppInstancePtr Groupsock (CppInstancePtr @this, [MangleAs ("class UsageEnvironment &")] UsageEnvironment env, [MangleAs ("struct in_addr const &")] in_addr groupAddr, [MangleAs ("class Port")] [ByVal] Port port, [MangleAs ("char  unsigned")] char ttl);
			[Constructor] CppInstancePtr Groupsock (CppInstancePtr @this, [MangleAs ("class UsageEnvironment &")] UsageEnvironment env, [MangleAs ("struct in_addr const &")] in_addr groupAddr, [MangleAs ("struct in_addr const &")] in_addr sourceFilterAddr, [MangleAs ("class Port")] [ByVal] Port port);
			[Virtual] [Destructor] void Destruct (CppInstancePtr @this);
			void changeDestinationParameters (CppInstancePtr @this, [MangleAs ("struct in_addr const &")] in_addr newDestAddr, [MangleAs ("class Port")] [ByVal] Port newDestPort, int newDestTTL);
			void addDestination (CppInstancePtr @this, [MangleAs ("struct in_addr const &")] in_addr addr, [MangleAs ("class Port const &")] Port port);
			void removeDestination (CppInstancePtr @this, [MangleAs ("struct in_addr const &")] in_addr addr, [MangleAs ("class Port const &")] Port port);
			void removeAllDestinations (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("struct in_addr const &")] in_addr groupAddress (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("struct in_addr const &")] in_addr sourceFilterAddress (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint isSSM (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  unsigned")] char ttl (CppInstancePtr @this);
			void multicastSendOnly (CppInstancePtr @this);
			[return: MangleAs ("int  unsigned")] uint output (CppInstancePtr @this, [MangleAs ("class UsageEnvironment &")] UsageEnvironment env, [MangleAs ("char  unsigned")] char ttl, [MangleAs ("char  unsigned *")] string buffer, [MangleAs ("int  unsigned")] uint bufferSize, [MangleAs ("class DirectedNetInterface *")] DirectedNetInterface interfaceNotToFwdBackTo);
			[Inline] [return: MangleAs ("class DirectedNetInterfaceSet &")] DirectedNetInterfaceSet members (CppInstancePtr @this);
			[return: MangleAs ("int  unsigned")] uint wasLoopedBackFromUs (CppInstancePtr @this, [MangleAs ("class UsageEnvironment &")] UsageEnvironment env, [MangleAs ("struct sockaddr_in &")] sockaddr_in fromAddress);
			CppField<uint> deleteIfNoMembers { get; }
			CppField<uint> isSlave { get; }
			CppField<NetInterfaceTrafficStats> statsGroupIncoming { get; }
			CppField<NetInterfaceTrafficStats> statsGroupOutgoing { get; }
			CppField<NetInterfaceTrafficStats> statsGroupRelayedIncoming { get; }
			CppField<NetInterfaceTrafficStats> statsGroupRelayedOutgoing { get; }
		}
		public unsafe struct _Groupsock {
			public uint deleteIfNoMembers;
			public uint isSlave;
			public NetInterfaceTrafficStats._NetInterfaceTrafficStats statsGroupIncoming;
			public NetInterfaceTrafficStats._NetInterfaceTrafficStats statsGroupOutgoing;
			public NetInterfaceTrafficStats._NetInterfaceTrafficStats statsGroupRelayedIncoming;
			public NetInterfaceTrafficStats._NetInterfaceTrafficStats statsGroupRelayedOutgoing;
			public GroupEId._GroupEId fIncomingGroupEId;
			public destRecord fDests;
			public char fTTL;
			public DirectedNetInterfaceSet._DirectedNetInterfaceSet fMembers;
		}

		public uint deleteIfNoMembers {
			get {
				return impl.deleteIfNoMembers [Native];
			}
			set {
				impl.deleteIfNoMembers [Native] = value;
			}
		}
		public uint isSlave {
			get {
				return impl.isSlave [Native];
			}
			set {
				impl.isSlave [Native] = value;
			}
		}
		public NetInterfaceTrafficStats statsGroupIncoming {
			get {
				return impl.statsGroupIncoming [Native];
			}
			set {
				impl.statsGroupIncoming [Native] = value;
			}
		}
		public NetInterfaceTrafficStats statsGroupOutgoing {
			get {
				return impl.statsGroupOutgoing [Native];
			}
			set {
				impl.statsGroupOutgoing [Native] = value;
			}
		}
		public NetInterfaceTrafficStats statsGroupRelayedIncoming {
			get {
				return impl.statsGroupRelayedIncoming [Native];
			}
			set {
				impl.statsGroupRelayedIncoming [Native] = value;
			}
		}
		public NetInterfaceTrafficStats statsGroupRelayedOutgoing {
			get {
				return impl.statsGroupRelayedOutgoing [Native];
			}
			set {
				impl.statsGroupRelayedOutgoing [Native] = value;
			}
		}




		public Groupsock (CppTypeInfo subClass)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public Groupsock (CppInstancePtr native)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public Groupsock (UsageEnvironment env, in_addr groupAddr, Port port, char ttl)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = impl.Groupsock (impl.Alloc (this), env, groupAddr, port, ttl);
		}
		public Groupsock (UsageEnvironment env, in_addr groupAddr, in_addr sourceFilterAddr, Port port)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = impl.Groupsock (impl.Alloc (this), env, groupAddr, sourceFilterAddr, port);
		}
		public void ChangeDestinationParameters (in_addr newDestAddr, Port newDestPort, int newDestTTL)
		{
			impl.changeDestinationParameters (Native, newDestAddr, newDestPort, newDestTTL);
		}
		public void AddDestination (in_addr addr, Port port)
		{
			impl.addDestination (Native, addr, port);
		}
		public void RemoveDestination (in_addr addr, Port port)
		{
			impl.removeDestination (Native, addr, port);
		}
		public void RemoveAllDestinations ()
		{
			impl.removeAllDestinations (Native);
		}
		public void MulticastSendOnly ()
		{
			impl.multicastSendOnly (Native);
		}
		public uint Output (UsageEnvironment env, char ttl, string buffer, uint bufferSize, DirectedNetInterface interfaceNotToFwdBackTo)
		{
			return impl.output (Native, env, ttl, buffer, bufferSize, interfaceNotToFwdBackTo);
		}
		public DirectedNetInterfaceSet Members ()
		{
			return impl.members (Native);
		}
		public uint WasLoopedBackFromUs (UsageEnvironment env, sockaddr_in fromAddress)
		{
			return impl.wasLoopedBackFromUs (Native, env, fromAddress);
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

		public char Ttl {
			get {
				return impl.ttl (Native);
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

