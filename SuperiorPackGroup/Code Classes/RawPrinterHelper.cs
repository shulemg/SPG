﻿//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using System.IO;
using System.Drawing.Printing;
using System.Runtime.InteropServices;

namespace SuperiorPackGroup
{
	public class RawPrinterHelper
	{

		// Structure and API declarions:
		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
		public struct DOCINFOW
		{
			[MarshalAs(UnmanagedType.LPWStr)]
			public string pDocName;
			[MarshalAs(UnmanagedType.LPWStr)]
			public string pOutputFile;
			[MarshalAs(UnmanagedType.LPWStr)]
			public string pDataType;
		}

		[DllImport("winspool.Drv", EntryPoint="OpenPrinterW", SetLastError=true, CharSet=CharSet.Unicode, ExactSpelling=true, CallingConvention=CallingConvention.StdCall)]
		public extern static bool OpenPrinter(string src, ref IntPtr hPrinter, long pd);
		[DllImport("winspool.Drv", EntryPoint="ClosePrinter", SetLastError=true, CharSet=CharSet.Unicode, ExactSpelling=true, CallingConvention=CallingConvention.StdCall)]
		public extern static bool ClosePrinter(IntPtr hPrinter);
		[DllImport("winspool.Drv", EntryPoint="StartDocPrinterW", SetLastError=true, CharSet=CharSet.Unicode, ExactSpelling=true, CallingConvention=CallingConvention.StdCall)]
		public extern static bool StartDocPrinter(IntPtr hPrinter, Int32 level, ref DOCINFOW pDI);
		[DllImport("winspool.Drv", EntryPoint="EndDocPrinter", SetLastError=true, CharSet=CharSet.Unicode, ExactSpelling=true, CallingConvention=CallingConvention.StdCall)]
		public extern static bool EndDocPrinter(IntPtr hPrinter);
		[DllImport("winspool.Drv", EntryPoint="StartPagePrinter", SetLastError=true, CharSet=CharSet.Unicode, ExactSpelling=true, CallingConvention=CallingConvention.StdCall)]
		public extern static bool StartPagePrinter(IntPtr hPrinter);
		[DllImport("winspool.Drv", EntryPoint="EndPagePrinter", SetLastError=true, CharSet=CharSet.Unicode, ExactSpelling=true, CallingConvention=CallingConvention.StdCall)]
		public extern static bool EndPagePrinter(IntPtr hPrinter);
		[DllImport("winspool.Drv", EntryPoint="WritePrinter", SetLastError=true, CharSet=CharSet.Unicode, ExactSpelling=true, CallingConvention=CallingConvention.StdCall)]
		public extern static bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, ref Int32 dwWritten);

		// SendBytesToPrinter()
		// When the function is given a printer name and an unmanaged array of  
		// bytes, the function sends those bytes to the print queue.
		// Returns True on success or False on failure.
		public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
		{
			IntPtr hPrinter = System.IntPtr.Zero; // The printer handle.
			Int32 dwError = 0; // Last error - in case there was trouble.
			DOCINFOW di = new DOCINFOW(); // Describes your document (name, port, data type).
			Int32 dwWritten = 0; // The number of bytes written by WritePrinter().
			bool bSuccess = false; // Your success code.

			// Set up the DOCINFO structure.
			di.pDocName = "LPN Label";
			di.pDataType = "RAW";
			// Assume failure unless you specifically succeed.
			if (OpenPrinter(szPrinterName, ref hPrinter, 0))
			{
				if (StartDocPrinter(hPrinter, 1, ref di))
				{
					if (StartPagePrinter(hPrinter))
					{
						// Write your printer-specific bytes to the printer.
						bSuccess = WritePrinter(hPrinter, pBytes, dwCount, ref dwWritten);
						EndPagePrinter(hPrinter);
					}
					EndDocPrinter(hPrinter);
				}
				ClosePrinter(hPrinter);
			}
			// If you did not succeed, GetLastError may give more information
			// about why not.
			if (bSuccess == false)
			{
				dwError = Marshal.GetLastWin32Error();
			}
			return bSuccess;
		} // SendBytesToPrinter()

		// SendFileToPrinter()
		// When the function is given a file name and a printer name, 
		// the function reads the contents of the file and sends the
		// contents to the printer.
		// Presumes that the file contains printer-ready data.
		// Shows how to use the SendBytesToPrinter function.
		// Returns True on success or False on failure.
		public static bool SendFileToPrinter(string szPrinterName, string szFileName)
		{
			// Open the file.
			FileStream fs = new FileStream(szFileName, FileMode.Open);
			// Create a BinaryReader on the file.
			BinaryReader br = new BinaryReader(fs);
			// Dim an array of bytes large enough to hold the file's contents.
			byte[] bytes = new byte[((int)fs.Length) + 1];
			bool bSuccess = false;
			// Your unmanaged pointer.
			IntPtr pUnmanagedBytes = System.IntPtr.Zero;

			// Read the contents of the file into the array.
			bytes = br.ReadBytes((int)fs.Length);
			// Allocate some unmanaged memory for those bytes.
			pUnmanagedBytes = Marshal.AllocCoTaskMem((int)fs.Length);
			// Copy the managed byte array into the unmanaged array.
			Marshal.Copy(bytes, 0, pUnmanagedBytes, (int)fs.Length);
			// Send the unmanaged bytes to the printer.
			bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, (int)fs.Length);
			// Free the unmanaged memory that you allocated earlier.
			Marshal.FreeCoTaskMem(pUnmanagedBytes);
			return bSuccess;
		} // SendFileToPrinter()

		// When the function is given a string and a printer name,
		// the function sends the string to the printer as raw bytes.
		public static bool SendStringToPrinter(string szPrinterName, string szString)
		{
			IntPtr pBytes = System.IntPtr.Zero;
			Int32 dwCount = szString.Length;
			bool bSuccess = false;
			// How many characters are in the string?
			// Assume that the printer is expecting ANSI text, and then convert
			// the string to ANSI text.
			pBytes = Marshal.StringToCoTaskMemAnsi(szString);
			// Send the converted ANSI string to the printer.
			bSuccess = SendBytesToPrinter(szPrinterName, pBytes, dwCount);
			Marshal.FreeCoTaskMem(pBytes);
			return bSuccess;
		}

	}

}