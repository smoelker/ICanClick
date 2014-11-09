using System;
using System.Drawing;

namespace ICanClick.Core
{
	public class ClickOperationSelectedEventArgs
	{
		private ClickOperation _clickOperation;
		
		internal ClickOperationSelectedEventArgs()
		{
		}
		
		public ClickOperationSelectedEventArgs(ClickOperation clickOperation)
		{
			_clickOperation = clickOperation;
		}
		
		
		public ClickOperation ClickOperation
		{
			get{ return _clickOperation;}
			internal set { _clickOperation = value;}
		}
	}
}
