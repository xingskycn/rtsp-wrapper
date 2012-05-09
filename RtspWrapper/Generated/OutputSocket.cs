// -------------------------------------------------------------------------
//  Managed wrapper for OutputSocket
//  Generated from RTSPClient.xml on 05/08/2012 20:36:36
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
    
	
	public partial class OutputSocket : Socket {

		private static readonly IOutputSocket impl = Libs.live555.GetClass<IOutputSocket,_OutputSocket,OutputSocket> ("OutputSocket");
		public static bool operator!=(OutputSocket a, OutputSocket b) { return !(a == b); }
		public static bool operator==(OutputSocket a, OutputSocket b)
		{
			if (object.ReferenceEquals(a, b))
                return true;
            if ((object)a == null || (object)b == null)
                return false;
			return a.Native == b.Native;
		}
        public override bool Equals(object obj) { return (this == obj as OutputSocket); }
        public override int GetHashCode() { return this.Native.GetHashCode(); }

		[MangleAs ("class OutputSocket")]
		public partial interface IOutputSocket : ICppClassOverridable<OutputSocket> {
			[Artificial] [Inline] [Constructor] [CopyConstructor] CppInstancePtr OutputSocket (CppInstancePtr @this, [MangleAs ("class OutputSocket const &")] OutputSocket arg0);
			[Constructor] CppInstancePtr OutputSocket (CppInstancePtr @this, [MangleAs ("class UsageEnvironment &")] UsageEnvironment env);
			[Virtual] [Destructor] void Destruct (CppInstancePtr @this);
			[return: MangleAs ("int  unsigned")] uint write (CppInstancePtr @this, [MangleAs ("int  unsigned")] uint address, [MangleAs ("class Port")] [ByVal] Port port, [MangleAs ("char  unsigned")] char ttl, [MangleAs ("char  unsigned *")] string buffer, [MangleAs ("int  unsigned")] uint bufferSize);
			[Constructor] [Protected] CppInstancePtr OutputSocket (CppInstancePtr @this, [MangleAs ("class UsageEnvironment &")] UsageEnvironment env, [MangleAs ("class Port")] [ByVal] Port port);
			[Inline] [Const] [Protected] [return: MangleAs ("int  short unsigned")] ushort sourcePortNum (CppInstancePtr @this);
		}
		public unsafe struct _OutputSocket {
			public Port._Port fSourcePort;
			public char fLastSentTTL;
		}





		public OutputSocket (CppTypeInfo subClass)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			subClass.AddBase (impl.TypeInfo);
		}

		public OutputSocket (CppInstancePtr native)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = native;
		}

		public OutputSocket (UsageEnvironment env)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = impl.OutputSocket (impl.Alloc (this), env);
		}
		public uint Write (uint address, Port port, char ttl, string buffer, uint bufferSize)
		{
			return impl.write (Native, address, port, ttl, buffer, bufferSize);
		}
		protected OutputSocket (UsageEnvironment env, Port port)
			: base (impl.TypeInfo)
		{
			__cxxi_LayoutClass ();
			Native = impl.OutputSocket (impl.Alloc (this), env, port);
		}

		public ushort SourcePortNum {
			get {
				return impl.sourcePortNum (Native);
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

