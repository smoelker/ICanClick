using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;


namespace ICanClick.Core
{
	internal class MouseClickSimulator
	{
		public static void SingleClickLeft()
		{
			SendMouseEvent((MouseEvents.MOUSEEVENTF_LEFTDOWN | MouseEvents.MOUSEEVENTF_LEFTUP));
		}
		
		public static void DoubleClickLeft()
		{
			SendMouseEvent((MouseEvents.MOUSEEVENTF_LEFTDOWN | MouseEvents.MOUSEEVENTF_LEFTUP));
            SendMouseEvent((MouseEvents.MOUSEEVENTF_LEFTDOWN | MouseEvents.MOUSEEVENTF_LEFTUP));
		}
		
		public static void SingleClickRight()
		{
			SendMouseEvent((MouseEvents.MOUSEEVENTF_RIGHTDOWN | MouseEvents.MOUSEEVENTF_RIGHTUP));
		}
		
		public static void SingleClickMiddle()
		{
			SendMouseEvent((MouseEvents.MOUSEEVENTF_MIDDLEDOWN | MouseEvents.MOUSEEVENTF_MIDDLEUP));
		}
		
		public static void BeginDragLeft()
		{
			SendMouseEvent(MouseEvents.MOUSEEVENTF_LEFTDOWN);
		}
		
		public static void EndDragLeft()
		{
			SendMouseEvent(MouseEvents.MOUSEEVENTF_LEFTUP);
		}
		
		public static void BeginDragRight()
		{
			SendMouseEvent(MouseEvents.MOUSEEVENTF_RIGHTDOWN);
		}
		
		public static void EndDragRight()
		{
			SendMouseEvent(MouseEvents.MOUSEEVENTF_RIGHTUP);
		}
		
		private static void SendMouseEvent(MouseEvents mouseEvents)
		{
#if DEBUG
            Debug.WriteLine(string.Format("SendMouseEvent: x={0}, y={1}", Cursor.Position.X, Cursor.Position.Y));
#endif
            int x = (int)Cursor.Position.X;
            int y = (int)Cursor.Position.Y;

			try
			{
                Win32.INPUT inputStruct = new Win32.INPUT();
				inputStruct.type = 0;
                inputStruct.mkhi = new Win32.INPUTUNION();
                inputStruct.mkhi.mi = new Win32.MOUSEINPUT();
                inputStruct.mkhi.mi.dwExtraInfo = IntPtr.Zero;
                inputStruct.mkhi.mi.dx = x;
                inputStruct.mkhi.mi.dy = y;
                inputStruct.mkhi.mi.time = 0;
                inputStruct.mkhi.mi.dwFlags = (uint)mouseEvents;

                uint r = Win32.SendInput(1, new Win32.INPUT[] { inputStruct }, Marshal.SizeOf(inputStruct));
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
				throw;
			}
		}
	}
}
