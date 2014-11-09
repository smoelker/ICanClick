using System;
using System.Diagnostics;

namespace ICanClick.Core
{
	public class ICanClickApplication : IDisposable
	{
		private ClickOperationManager _mouseActionManager;
		
		public ICanClickApplication()
		{
			_mouseActionManager = new ClickOperationManager();
		}
		
		public ClickOperationManager MouseActionManager
		{
			get { return _mouseActionManager;}
		}
		
		~ICanClickApplication()
		{
			Dispose(false);
		}
		
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		
		protected virtual void Dispose(bool disposeManagedResources)
		{
			if(disposeManagedResources)
			{
				
			}
			if(_mouseActionManager != null)
			{
				_mouseActionManager.Dispose();
			}
		}
	}
}
