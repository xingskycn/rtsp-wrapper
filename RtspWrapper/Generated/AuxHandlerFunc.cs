
// -------------------------------------------------------------------------
//  Managed delegate for AuxHandlerFunc
//  Generated from RTSPClient.xml on 05/08/2012 20:36:35
//
//  This file was auto generated. Do not edit.
// -------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Mono.Cxxi;

namespace Live555Rtsp {
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	public delegate void AuxHandlerFunc ([MangleAs ("void  *")] IntPtr arg0, [MangleAs ("char  unsigned *")] string arg1, [MangleAs ("int  unsigned")] uint arg2);

}
