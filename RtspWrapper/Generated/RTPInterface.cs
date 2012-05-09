// -------------------------------------------------------------------------
//  Managed wrapper for RTPInterface
//  Generated from RTSPClient.xml on 05/08/2012 20:36:33
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class RTPInterface : ICppObject {

		private static readonly IRTPInterface impl = Libs.live555.GetClass<IRTPInterface,_RTPInterface,RTPInterface> ("RTPInterface");
		public CppInstancePtr Native { get; protected set; }
		public static bool operator!=(RTPInterface a, RTPInterface b) { return !(a == b); }
		public static bool operator==(RTPInterface a, RTPInterface b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as RTPInterface); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class RTPInterface")]
		public partial interface IRTPInterface : ICppClassOverridable<RTPInterface> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr RTPInterface (CppInstancePtr @this, [MangleAs ("class RTPInterface const &")] RTPInterface arg0);
			[Constructor] CppInstancePtr RTPInterface (CppInstancePtr @this, [MangleAs ("class Medium *")] Medium owner, [MangleAs ("class Groupsock *")] Groupsock gs);
			[Virtual] [Destructor] void Destruct (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("class Groupsock *")] Groupsock gs (CppInstancePtr @this);
			void setStreamSocket (CppInstancePtr @this, int sockNum, [MangleAs ("char  unsigned")] char streamChannelId);
			void addStreamSocket (CppInstancePtr @this, int sockNum, [MangleAs ("char  unsigned")] char streamChannelId);
			void removeStreamSocket (CppInstancePtr @this, int sockNum, [MangleAs ("char  unsigned")] char streamChannelId);
			void setServerRequestAlternativeByteHandler (CppInstancePtr @this, int socketNum, [MangleAs ("delegate ServerRequestAlternativeByteHandler *")] ServerRequestAlternativeByteHandler handler, [MangleAs ("void  *")] IntPtr clientData);
			[return: MangleAs ("int  unsigned")] uint sendPacket (CppInstancePtr @this, [MangleAs ("char  unsigned *")] string packet, [MangleAs ("int  unsigned")] uint packetSize);
			void startNetworkReading (CppInstancePtr @this, [MangleAs ("delegate TaskScheduler::BackgroundHandlerProc *")] TaskScheduler.BackgroundHandlerProc handlerProc);
			[return: MangleAs ("int  unsigned")] uint handleRead (CppInstancePtr @this, [MangleAs ("char  unsigned *")] string buffer, [MangleAs ("int  unsigned")] uint bufferMaxSize, [MangleAs ("int  unsigned &")] ref uint bytesRead, [MangleAs ("struct sockaddr_in &")] sockaddr_in fromAddress, [MangleAs ("int  unsigned &")] ref uint packetReadWasIncomplete);
			void stopNetworkReading (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("class UsageEnvironment &")] UsageEnvironment envir (CppInstancePtr @this);
			[Inline] void setAuxilliaryReadHandler (CppInstancePtr @this, [MangleAs ("delegate AuxHandlerFunc *")] AuxHandlerFunc handlerFunc, [MangleAs ("void  *")] IntPtr handlerClientData);
			[Inline] [Const] int nextTCPReadStreamSocketNum (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("char  unsigned")] char nextTCPReadStreamChannelId (CppInstancePtr @this);
		}
		public unsafe struct _RTPInterface {
			public Medium fOwner;
			public Groupsock fGS;
			public tcpStreamRecord fTCPStreams;
			public ushort fNextTCPReadSize;
			public int fNextTCPReadStreamSocketNum;
			public char fNextTCPReadStreamChannelId;
			public TaskScheduler.BackgroundHandlerProc fReadHandlerProc;
			public AuxHandlerFunc fAuxReadHandlerFunc;
			public IntPtr fAuxReadHandlerClientData;
		}





		public RTPInterface (CppTypeInfo subClass)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public RTPInterface (CppInstancePtr native)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public RTPInterface (Medium owner, Groupsock gs)
		{
			__cxxi_LayoutClass ();
			Native = impl.RTPInterface (impl.Alloc (this), owner, gs);
		}
		public void SetStreamSocket (int sockNum, char streamChannelId)
		{
			impl.setStreamSocket (Native, sockNum, streamChannelId);
		}
		public void AddStreamSocket (int sockNum, char streamChannelId)
		{
			impl.addStreamSocket (Native, sockNum, streamChannelId);
		}
		public void RemoveStreamSocket (int sockNum, char streamChannelId)
		{
			impl.removeStreamSocket (Native, sockNum, streamChannelId);
		}
		public void SetServerRequestAlternativeByteHandler (int socketNum, ServerRequestAlternativeByteHandler handler, IntPtr clientData)
		{
			impl.setServerRequestAlternativeByteHandler (Native, socketNum, new WeakDelegate<ServerRequestAlternativeByteHandler>(handler), clientData);
		}
		public uint SendPacket (string packet, uint packetSize)
		{
			return impl.sendPacket (Native, packet, packetSize);
		}
		public void StartNetworkReading (TaskScheduler.BackgroundHandlerProc handlerProc)
		{
			impl.startNetworkReading (Native, new WeakDelegate<TaskScheduler.BackgroundHandlerProc>(handlerProc));
		}
		public uint HandleRead (string buffer, uint bufferMaxSize, ref uint bytesRead, sockaddr_in fromAddress, ref uint packetReadWasIncomplete)
		{
			return impl.handleRead (Native, buffer, bufferMaxSize, ref bytesRead, fromAddress, ref packetReadWasIncomplete);
		}
		public void StopNetworkReading ()
		{
			impl.stopNetworkReading (Native);
		}
		public void SetAuxilliaryReadHandler (AuxHandlerFunc handlerFunc, IntPtr handlerClientData)
		{
			impl.setAuxilliaryReadHandler (Native, new WeakDelegate<AuxHandlerFunc>(handlerFunc), handlerClientData);
		}

		public Groupsock Gs {
			get {
				return impl.gs (Native);
			}
		}

		public UsageEnvironment Envir {
			get {
				return impl.envir (Native);
			}
		}

		public int NextTCPReadStreamSocketNum {
			get {
				return impl.nextTCPReadStreamSocketNum (Native);
			}
		}

		public char NextTCPReadStreamChannelId {
			get {
				return impl.nextTCPReadStreamChannelId (Native);
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

