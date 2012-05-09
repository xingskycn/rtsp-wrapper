// -------------------------------------------------------------------------
//  Managed wrapper for RTCPInstance
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class RTCPInstance : Medium {

		private static readonly IRTCPInstance impl = Libs.live555.GetClass<IRTCPInstance,_RTCPInstance,RTCPInstance> ("RTCPInstance");
		public static bool operator!=(RTCPInstance a, RTCPInstance b) { return !(a == b); }
		public static bool operator==(RTCPInstance a, RTCPInstance b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as RTCPInstance); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class RTCPInstance")]
		public partial interface IRTCPInstance : ICppClassOverridable<RTCPInstance> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr RTCPInstance (CppInstancePtr @this, [MangleAs ("class RTCPInstance const &")] RTCPInstance arg0);
			[Static] [return: MangleAs ("class RTCPInstance *")] RTCPInstance createNew ([MangleAs ("class UsageEnvironment &")] UsageEnvironment env, [MangleAs ("class Groupsock *")] Groupsock RTCPgs, [MangleAs ("int  unsigned")] uint totSessionBW, [MangleAs ("char  unsigned const *")] string cname, [MangleAs ("class RTPSink *")] RTPSink sink, [MangleAs ("class RTPSource const *")] RTPSource source, [MangleAs ("int  unsigned")] uint isSSMSource);
			[Static] [return: MangleAs ("int  unsigned")] uint lookupByName ([MangleAs ("class UsageEnvironment &")] UsageEnvironment env, [MangleAs ("char  const *")] string instanceName, [MangleAs ("class RTCPInstance * &")] RTCPInstance resultInstance);
			[Const] [return: MangleAs ("int  unsigned")] uint numMembers (CppInstancePtr @this);
			[Inline] [Const] [return: MangleAs ("int  unsigned")] uint totSessionBW (CppInstancePtr @this);
			void setByeHandler (CppInstancePtr @this, [MangleAs ("delegate FramedSource::OnCloseFunc *")] FramedSource.OnCloseFunc handlerTask, [MangleAs ("void  *")] IntPtr clientData, [MangleAs ("int  unsigned")] uint handleActiveParticipantsOnly);
			void setSRHandler (CppInstancePtr @this, [MangleAs ("delegate FramedSource::OnCloseFunc *")] FramedSource.OnCloseFunc handlerTask, [MangleAs ("void  *")] IntPtr clientData);
			void setRRHandler (CppInstancePtr @this, [MangleAs ("delegate FramedSource::OnCloseFunc *")] FramedSource.OnCloseFunc handlerTask, [MangleAs ("void  *")] IntPtr clientData);
			void setSpecificRRHandler (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint fromAddress, [MangleAs ("class Port")] [ByVal] Port fromPort, [MangleAs ("delegate FramedSource::OnCloseFunc *")] FramedSource.OnCloseFunc handlerTask, [MangleAs ("void  *")] IntPtr clientData);
			void unsetSpecificRRHandler (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint fromAddress, [MangleAs ("class Port")] [ByVal] Port fromPort);
			[Inline] [Const] [return: MangleAs ("class Groupsock *")] Groupsock RTCPgs (CppInstancePtr @this);
			void setStreamSocket (CppInstancePtr @this, int sockNum, [MangleAs ("char  unsigned")] char streamChannelId);
			void addStreamSocket (CppInstancePtr @this, int sockNum, [MangleAs ("char  unsigned")] char streamChannelId);
			[Inline] void removeStreamSocket (CppInstancePtr @this, int sockNum, [MangleAs ("char  unsigned")] char streamChannelId);
			[Inline] void setAuxilliaryReadHandler (CppInstancePtr @this, [MangleAs ("delegate AuxHandlerFunc *")] AuxHandlerFunc handlerFunc, [MangleAs ("void  *")] IntPtr handlerClientData);
			[Constructor] [Protected] CppInstancePtr RTCPInstance (CppInstancePtr @this, [MangleAs ("class UsageEnvironment &")] UsageEnvironment env, [MangleAs ("class Groupsock *")] Groupsock RTPgs, [MangleAs ("int  unsigned")] uint totSessionBW, [MangleAs ("char  unsigned const *")] string cname, [MangleAs ("class RTPSink *")] RTPSink sink, [MangleAs ("class RTPSource const *")] RTPSource source, [MangleAs ("int  unsigned")] uint isSSMSource);
			[Virtual] [Destructor] [Protected] void Destruct (CppInstancePtr @this);
			void schedule (CppInstancePtr @this, double nextTime);
			void reschedule (CppInstancePtr @this, double nextTime);
			void sendReport (CppInstancePtr @this);
			void sendBYE (CppInstancePtr @this);
			[Inline] int typeOfEvent (CppInstancePtr @this);
			[Inline] int sentPacketSize (CppInstancePtr @this);
			[Inline] int packetType (CppInstancePtr @this);
			[Inline] int receivedPacketSize (CppInstancePtr @this);
			int checkNewSSRC (CppInstancePtr @this);
			void removeLastReceivedSSRC (CppInstancePtr @this);
			void removeSSRC (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint ssrc, [MangleAs ("int  unsigned")] uint alsoRemoveStats);
		}
		public unsafe struct _RTCPInstance {
			public string fInBuf;
			public uint fNumBytesAlreadyRead;
			public OutPacketBuffer fOutBuf;
			public RTPInterface._RTPInterface fRTCPInterface;
			public uint fTotSessionBW;
			public RTPSink fSink;
			public RTPSource fSource;
			public uint fIsSSMSource;
			public SDESItem._SDESItem fCNAME;
			public IntPtr fKnownMembers;
			public uint fOutgoingReportCount;
			public double fAveRTCPSize;
			public int fIsInitial;
			public double fPrevReportTime;
			public double fNextReportTime;
			public int fPrevNumMembers;
			public int fLastSentSize;
			public int fLastReceivedSize;
			public uint fLastReceivedSSRC;
			public int fTypeOfEvent;
			public int fTypeOfPacket;
			public uint fHaveJustSentPacket;
			public uint fLastPacketSentSize;
			public FramedSource.OnCloseFunc fByeHandlerTask;
			public IntPtr fByeHandlerClientData;
			public uint fByeHandleActiveParticipantsOnly;
			public FramedSource.OnCloseFunc fSRHandlerTask;
			public IntPtr fSRHandlerClientData;
			public FramedSource.OnCloseFunc fRRHandlerTask;
			public IntPtr fRRHandlerClientData;
			public AddressPortLookupTable fSpecificRRHandlerTable;
		}





		public RTCPInstance (CppTypeInfo subClass)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public RTCPInstance (CppInstancePtr native)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public static RTCPInstance CreateNew (UsageEnvironment env, Groupsock RTCPgs, uint totSessionBW, string cname, RTPSink sink, RTPSource source, uint isSSMSource)
		{
			return impl.createNew (env, RTCPgs, totSessionBW, cname, sink, source, isSSMSource);
		}
		public static uint LookupByName (UsageEnvironment env, string instanceName, RTCPInstance resultInstance)
		{
			return impl.lookupByName (env, instanceName, resultInstance);
		}
		public void SetByeHandler (FramedSource.OnCloseFunc handlerTask, IntPtr clientData, uint handleActiveParticipantsOnly)
		{
			impl.setByeHandler (Native, new WeakDelegate<FramedSource.OnCloseFunc>(handlerTask), clientData, handleActiveParticipantsOnly);
		}
		public void SetSRHandler (FramedSource.OnCloseFunc handlerTask, IntPtr clientData)
		{
			impl.setSRHandler (Native, new WeakDelegate<FramedSource.OnCloseFunc>(handlerTask), clientData);
		}
		public void SetRRHandler (FramedSource.OnCloseFunc handlerTask, IntPtr clientData)
		{
			impl.setRRHandler (Native, new WeakDelegate<FramedSource.OnCloseFunc>(handlerTask), clientData);
		}
		public void SetSpecificRRHandler (uint fromAddress, Port fromPort, FramedSource.OnCloseFunc handlerTask, IntPtr clientData)
		{
			impl.setSpecificRRHandler (Native, fromAddress, fromPort, new WeakDelegate<FramedSource.OnCloseFunc>(handlerTask), clientData);
		}
		public void UnsetSpecificRRHandler (uint fromAddress, Port fromPort)
		{
			impl.unsetSpecificRRHandler (Native, fromAddress, fromPort);
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
		public void SetAuxilliaryReadHandler (AuxHandlerFunc handlerFunc, IntPtr handlerClientData)
		{
			impl.setAuxilliaryReadHandler (Native, new WeakDelegate<AuxHandlerFunc>(handlerFunc), handlerClientData);
		}
		protected RTCPInstance (UsageEnvironment env, Groupsock RTPgs, uint totSessionBW, string cname, RTPSink sink, RTPSource source, uint isSSMSource)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = impl.RTCPInstance (impl.Alloc (this), env, RTPgs, totSessionBW, cname, sink, source, isSSMSource);
		}
		public void Schedule (double nextTime)
		{
			impl.schedule (Native, nextTime);
		}
		public void Reschedule (double nextTime)
		{
			impl.reschedule (Native, nextTime);
		}
		public void SendReport ()
		{
			impl.sendReport (Native);
		}
		public void SendBYE ()
		{
			impl.sendBYE (Native);
		}
		public int TypeOfEvent ()
		{
			return impl.typeOfEvent (Native);
		}
		public int SentPacketSize ()
		{
			return impl.sentPacketSize (Native);
		}
		public int PacketType ()
		{
			return impl.packetType (Native);
		}
		public int ReceivedPacketSize ()
		{
			return impl.receivedPacketSize (Native);
		}
		public int CheckNewSSRC ()
		{
			return impl.checkNewSSRC (Native);
		}
		public void RemoveLastReceivedSSRC ()
		{
			impl.removeLastReceivedSSRC (Native);
		}
		public void RemoveSSRC (uint ssrc, uint alsoRemoveStats)
		{
			impl.removeSSRC (Native, ssrc, alsoRemoveStats);
		}

		public uint NumMembers {
			get {
				return impl.numMembers (Native);
			}
		}

		public uint TotSessionBW {
			get {
				return impl.totSessionBW (Native);
			}
		}

		public Groupsock RTCPgs {
			get {
				return impl.RTCPgs (Native);
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

