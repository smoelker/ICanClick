using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using ICanClick.Core;
using System.Resources;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;

namespace ICanClick
{
	public class ClickOperationButton : CheckBox
	{
		private ClickOperation _associatedClickOperation = ClickOperation.None;
		private ApplicationClass _application;

		public ClickOperation AssociatedClickOperation
		{
			get { return _associatedClickOperation; }
			set
			{
				if (_associatedClickOperation != value)
				{
					_associatedClickOperation = value;
					EvaluateBackgroundImage();
				}
			}
		}

		public ApplicationClass Application
		{
			get { return _application; }
			set
			{
				if (_application != value)
				{
					if (_application != null)
					{
						_application.ClickOperationSelected -= _application_ClickOperationSelected;
						_application.EnabledChanged -= _application_EnabledChanged;
					}
					_application = value;
					if (_application != null)
					{
						_application.ClickOperationSelected += new ClickOperationSelectedEventHandler(_application_ClickOperationSelected);
						_application.EnabledChanged += new EventHandler(_application_EnabledChanged);
						EvaluateAll();
					}
				}
			}
		}

		public ClickOperationButton()
		{
			Click += ClickOperationButton_Click;
		}

		private void ClickOperationButton_Click(object sender, EventArgs e)
		{
			if (_application != null)
			{
				_application.SelectClickOperation(_associatedClickOperation);
			}
		}

		private void _application_ClickOperationSelected(object sender, ClickOperationSelectedEventArgs e)
		{
			EvaluateAll();
		}
		
		private void _application_EnabledChanged(object sender, EventArgs e)
		{
			EvaluateAll();
		}

		private void EvaluateAll()
		{
			EvaluateEnabled();
			EvaluateChecked();
			EvaluateBackgroundImage();
		}
		
		private void EvaluateBackgroundImage()
		{
			string bgResourceImageName = _associatedClickOperation.ToString();
			if (Enabled == false)
			{
				bgResourceImageName += "BW";
			}
            ResourceManager rm = new ResourceManager(typeof(Resources));
			Image bgImage = (Image)rm.GetObject(bgResourceImageName);
			if (BackgroundImage != bgImage)
			{
				if (BackgroundImage != null)
				{
					BackgroundImage.Dispose();
				}
				BackgroundImage = bgImage;
			}
			else
			{
				if(bgImage != null)
				{
					bgImage.Dispose();
				}
			}
		}
		
		private void EvaluateEnabled()
		{
			if(_application.Enabled)
			{
				if(_application.CurrentClickOperation == ClickOperation.SingleClickLeftButton || _application.CurrentClickOperation == _associatedClickOperation)
				{
					Enabled = true;
				}
				else
				{
					Enabled = false;
				}
			}
			else
			{
				Enabled = false;
			}
		}
		
		private void EvaluateChecked()
		{
			if(_application.CurrentClickOperation == _associatedClickOperation)
			{
				Checked = true;
				Focus();
			}
			else
			{
				Checked = false;
			}
		}
	}
}
