using System;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Win32;
using System.Reflection;

namespace ICanClick.Core
{
	public class ApplicationClass : IDisposable
	{
        private const string ApplicationName = "ICanClick";
		private ClickOperationManager _clickOperationManager;

       
        public Settings Settings { get; private set; }
        public ClickOperation CurrentClickOperation
        {
            get { return _clickOperationManager.CurrentClickOperation; }
        }
        public bool Enabled
        {
            get { return _clickOperationManager.MouseHook.IsEnabled; }
            set { _clickOperationManager.MouseHook.IsEnabled = value; }
        }
		
		
		public event EventHandler EnabledChanged;
		public event ClickOperationSelectedEventHandler ClickOperationSelected;


		public ApplicationClass()
		{
            InitializeSettings();
            InitializeClickOperationManager();
            ResetSettings();
		}

		~ApplicationClass()
		{
			Dispose(false);
		}

        private void InitializeSettings()
        {
            Settings = new Settings();
            Settings.Reload();
            Settings.Saved += Settings_Saved;
        }

        private void InitializeClickOperationManager()
        {
            _clickOperationManager = new ClickOperationManager();
            _clickOperationManager.ClickOperationSelected += _clickOperationManager_ClickOperationSelected;
            _clickOperationManager.MouseHook.EnabledChanged += _clickOperationManager_MouseHook_EnabledChanged;
            _clickOperationManager.IsEnabled = false;
        }

		public void SelectClickOperation(ClickOperation clickOperation)
		{
			_clickOperationManager.SelectClickOperation(clickOperation);
		}

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
		
		public void Dispose(bool disposing)
		{
			if (_clickOperationManager != null)
			{
				_clickOperationManager.Dispose();
			}
		}


        private void Settings_Saved(object sender, EventArgs e)
        {
            ResetSettings();
        }

		
		private void _clickOperationManager_ClickOperationSelected(object sender, ClickOperationSelectedEventArgs e)
		{
			OnClickOperationSelected(e);
		}
		private void _clickOperationManager_MouseHook_EnabledChanged(object sender, EventArgs e)
		{
			OnEnabledChanged(e);
		}
		
		private void OnEnabledChanged(EventArgs e)
		{
			if(EnabledChanged != null)
			{
				EnabledChanged(this, e);
			}
		}
		private void OnClickOperationSelected(ClickOperationSelectedEventArgs e)
		{
			if(ClickOperationSelected != null)
			{
				ClickOperationSelected(this, e);
			}
		}

        private void ResetSettings()
        {
            _clickOperationManager.ClickInterval = Settings.ClickInterval;

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            object value = key.GetValue(ApplicationName);
            if (value == null && Settings.AutoStart == true)
            {
                string path = Assembly.GetEntryAssembly().Location;
                key.SetValue(ApplicationName, @"""" + path + @"""");
            }
            else if (value != null && Settings.AutoStart == false)
            {
                key.DeleteValue(ApplicationName);
            }
        }
	}
}
