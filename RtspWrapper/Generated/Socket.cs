// -------------------------------------------------------------------------
//  Managed wrapper for Socket
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class Socket : NetInterface {

		private static readonly ISocket impl = Libs.live555.GetClass<ISocket,_Socket,Socket> ("Socket");
		public static bool operator!=(Socket a, Socket b) { return !(a == b); }
		public static bool operator==(Socket a, Socket b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as Socket); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class Socket")]
		public partial interface ISocket : ICppClassOverridable<Socket> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr Socket (CppInstancePtr @this, [MangleAs ("class Socket const &")] Socket arg0);
			[Virtual] [Destructor] void Destruct (CppInstancePtr @this);
			[Virtual] [return: MangleAs ("int  unsigned")] uint handleRead (CppInstancePtr @this, string buffer, uint bufferMaxSize, ref uint bytesRead, sockaddr_in fromAddress);
			[Inline] [Const] int socketNum (CppInstancePtr @this);
			[Inline] [Const] [return: ByVal] Port port (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("class UsageEnvironment &")] UsageEnvironment env (CppInstancePtr @this);
			[Constructor] [Protected] CppInstancePtr Socket (CppInstancePtr @this, [MangleAs ("class UsageEnvironment &")] UsageEnvironment env, [MangleAs ("class Port")] [ByVal] Port port);
			[Protected] [return: MangleAs ("int  unsigned")] uint changePort (CppInstancePtr @this, [MangleAs ("class Port")] [ByVal] Port newPort);
		}
		public unsafe struct _Socket {
			public int fSocketNum;
			public UsageEnvironment fEnv;
			public Port._Port fPort;
		}





		public Socket (CppTypeInfo subClass)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public Socket (CppInstancePtr native)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		[OverrideNative ("handleRead")]
		public virtual uint HandleRead (string buffer, uint bufferMaxSize, ref uint bytesRead, sockaddr_in fromAddress)
		{
			return impl.handleRead (Native, buffer, bufferMaxSize, ref bytesRead, fromAddress);
		}
		protected Socket (UsageEnvironment env, Port port)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = impl.Socket (impl.Alloc (this), env, port);
		}
		protected uint ChangePort (Port newPort)
		{
			return impl.changePort (Native, newPort);
		}

		public int SocketNum {
			get {
				return impl.socketNum (Native);
			}
		}

		public Port Port {
			get {
				return impl.port (Native);
			}
		}

		public UsageEnvironment Env {
			get {
				return impl.env (Native);
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

