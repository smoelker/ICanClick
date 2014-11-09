using System;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace ICanClick
{
	public partial class AboutForm : Form
	{
		public AboutForm()
		{
			InitializeComponent();
			Initialize();
		}
		
		private void Initialize()
		{
			using(Icon logoIcon64x64 = new Icon(Resources.MouseIcon, new Size(64, 64)))
			{
				logoPictureBox.Image = logoIcon64x64.ToBitmap();
			}
            madeWithPaintDotNetPictureBox.Image = Resources.madewithpdn;

            Version version = GetType().Assembly.GetName().Version;
			versionTextBox.Text = "v" + version.ToString();
			copyrightTextBox.Text = string.Format("© Sil Moelker 2008 - {0}", DateTime.Now.Year);
			
			closeButton.Select();
			closeButton.Focus();
		}
		
		public static void ShowAboutDialog()
		{
			using(AboutForm form = new AboutForm())
			{
				form.ShowDialog();
			}
		}
		
		private void CloseButtonClick(object sender, EventArgs e)
		{
			Close();
		}
		
		private void MadeWithPaintDotNetPictureBoxClick(object sender, EventArgs e)
		{
			Process.Start("http://www.getpaint.net/redirect/madewithpdn.html");
		}
		
		private void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://www.gnu.org/licenses/gpl-3.0.txt");
		}
	}
}
