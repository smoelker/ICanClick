/*
 * Created by SharpDevelop.
 * User: yict1
 * Date: 16-7-2008
 * Time: 11:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ICanClick.Core
{
	/// <summary>
	/// Description of MouseListener.
	/// </summary>
	public class MouseListener : IDisposable
	{
		private static MouseListener _current;
		
		private IntPtr _mouseHookId = IntPtr.Zero;
		
		//private event
		
		public static MouseListener Current
		{
			get
			{
				if(_current == null)
				{
					_current = new MouseListener();
				}
				return _current;
			}
		}
		
		private bool IsHookSet
		{
			get { return (_mouseHookId != IntPtr.Zero);}
		}
		
		private MouseListener()
		{
			SetHook();
		}
		
		~MouseListener()
		{
			Dispose(false);
		}
		
		private void SetHook()
		{
			if(!IsHookSet)
			{
				using (Process curProcess = Process.GetCurrentProcess())
				{
					using (ProcessModule curModule = curProcess.MainModule)
					{
						_mouseHookId = SetWindowsHookEx(14 /*WH_MOUSE_LL*/, MouseHookCallBack , GetModuleHandle(curModule.ModuleName), 0);
					}
				}
			}
		}
		
		private void RemoveHook()
		{
			if(IsHookSet)
			{
				UnhookWindowsHookEx(_mouseHookId);
				_mouseHookId = IntPtr.Zero;
			}
		}
		
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		
		public void Dispose(bool disposing)
		{
			if(disposing)
			{
				
			}
			RemoveHook();
		}
		
		private IntPtr MouseHookCallBack(int nCode, IntPtr wParam, IntPtr lParam)
		{
			// if the nCode >= 0 then we should process the message, otherwise we should just pass the message to the next hook.
			if (nCode >= 0)
			{
				MSLLHOOKSTRUCT hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
				
				MouseMessageEventArgs args = new MouseMessageEventArgs();
				args.Message = (MouseMessage)wParam;
				args.X = hookStruct.pt.x;
				args.Y = hookStruct.pt.y;
				
			}
			return CallNextHookEx(_mouseHookId, nCode, wParam, lParam);
		}
		
		
		
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool UnhookWindowsHookEx(IntPtr hhk);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr GetModuleHandle(string lpModuleName);
		
		private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);
		
		[StructLayout(LayoutKind.Sequential)]
		private struct POINT
		{
			public int x;
			public int y;
		}

		[StructLayout(LayoutKind.Sequential)]
		private struct MSLLHOOKSTRUCT
		{
			public POINT pt;
			public uint mouseData;
			public uint flags;
			public uint time;
			public IntPtr dwExtraInfo;
		}


	}
}
