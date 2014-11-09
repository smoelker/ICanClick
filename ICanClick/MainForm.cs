using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ICanClick.Core;
using System.Resources;

namespace ICanClick
{
	public partial class MainForm : Form
	{
        private ApplicationClass _application;


        public MainForm(ApplicationClass application)
		{
            _application = application;
            _application.EnabledChanged += _application_EnabledChanged;
			
            InitializeComponent();
			Initialize();
		}

		private void Initialize()
		{
            _singleClickLeftButton.Application = _application;
            _singleClickRightButton.Application = _application;
            _doubleClickLeftButton.Application = _application;
            _singleClickMiddleButton.Application = _application;
            _dragLeftButton.Application = _application;
            _dragRightButton.Application = _application;

            _dragRightButton.Visible = false;
           
            Load += MainForm_Load;
            InitializeLocation();
		}

        private void InitializeLocation()
        {
            int x = Screen.PrimaryScreen.WorkingArea.Left + 5;
            int y = Screen.PrimaryScreen.WorkingArea.Bottom - Height - 5;
            Location = new Point(x, y);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _application.Enabled = true;
            ResetTrayIcon();
        }
		
		private void ResetTrayIcon()
		{
			string resourceIconStr = "MouseIcon";
			if(!_application.Enabled)
			{
				resourceIconStr += "BW";
			}
            ResourceManager rm = new ResourceManager(typeof(Resources));
			Icon newTrayIcon = (Icon)rm.GetObject(resourceIconStr);
			if(_trayNotifyIcon.Icon != newTrayIcon)
			{
				_trayNotifyIcon.Icon = newTrayIcon;
			}
			else
			{
				if(newTrayIcon != null)
				{
					newTrayIcon.Dispose();
				}
			}
		}
		private void ToggleEnabled()
		{
			_application.Enabled = !_application.Enabled;
		}
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			#if !DEBUG
			e.Cancel = (MessageBox.Show("You are about to close \"ICanClick\". Do you want to proceed?", "Close", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel);
			#endif
		}
		
		private void _application_EnabledChanged(object sender, EventArgs e)
		{
			ResetTrayIcon();
			trayIconContextMenuStripEnabledButton.Checked = _application.Enabled;
		}

        private void _trayNotifyIcon_ContextMenuStripCloseButton_Click(object sender, EventArgs e)
		{
			Close();
		}

        private void _trayNotifyIcon_ContextMenuStripEnabledButton_Click(object sender, EventArgs e)
		{
			ToggleEnabled();
		}

        private void _trayNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			ToggleEnabled();
		}

        private void _trayNotifyIcon_MouseClick(object sender, MouseEventArgs e)
		{
			_trayNotifyIcon.ContextMenuStrip.Show(Cursor.Position);
		}
		
		private void _trayIconContextMenuStripAboutButton_Click(object sender, EventArgs e)
		{
			AboutForm.ShowAboutDialog();
		}

        private void _trayIconContextMenuStripSettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm.ShowSettingsDialog(_application.Settings);
        }
	}
}
