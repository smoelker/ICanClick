using System;

namespace ICanClick.Core
{
    public class MouseMessageEventArgs : EventArgs
	{
		private MouseMessage _message;
		private int _x;
		private int _y;
		
		internal MouseMessageEventArgs()
		{
		}
		
		public MouseMessageEventArgs(MouseMessage message, int x, int y)
		{
			_message = message;
			_x = x;
			_y = y;
		}
		
		public MouseMessage Message
		{
			get { return _message;}
			internal set { _message = value;}
		}
		
		public int X
		{
			get { return _x;}
			internal set { _x = value;}
		}
		
		public int Y
		{
			get { return _y;}
			internal set { _y = value;}
		}
	}
}
