/*
 * Created by SharpDevelop.
 * User: yict1
 * Date: 16-7-2008
 * Time: 12:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ICanClick
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._formToolTip = new System.Windows.Forms.ToolTip(this.components);
            this._dragRightButton = new ICanClick.ClickOperationButton();
            this._dragLeftButton = new ICanClick.ClickOperationButton();
            this._singleClickMiddleButton = new ICanClick.ClickOperationButton();
            this._doubleClickLeftButton = new ICanClick.ClickOperationButton();
            this._singleClickRightButton = new ICanClick.ClickOperationButton();
            this._singleClickLeftButton = new ICanClick.ClickOperationButton();
            this._trayNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this._trayIconContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trayIconContextMenuStripEnabledButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.trayIconContextMenuStripSettingsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.trayIconContextMenuStripAboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.trayIconContextMenuStripCloseButton = new System.Windows.Forms.ToolStripMenuItem();
            this._trayIconContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _dragRightButton
            // 
            this._dragRightButton.Appearance = System.Windows.Forms.Appearance.Button;
            this._dragRightButton.Application = null;
            this._dragRightButton.AssociatedClickOperation = ICanClick.Core.ClickOperation.None;
            this._dragRightButton.AutoCheck = false;
            this._dragRightButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_dragRightButton.BackgroundImage")));
            this._dragRightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._dragRightButton.Location = new System.Drawing.Point(44, 86);
            this._dragRightButton.Margin = new System.Windows.Forms.Padding(1);
            this._dragRightButton.Name = "_dragRightButton";
            this._dragRightButton.Size = new System.Drawing.Size(40, 40);
            this._dragRightButton.TabIndex = 5;
            this._dragRightButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._formToolTip.SetToolTip(this._dragRightButton, "Drag right");
            this._dragRightButton.UseVisualStyleBackColor = true;
            // 
            // _dragLeftButton
            // 
            this._dragLeftButton.Appearance = System.Windows.Forms.Appearance.Button;
            this._dragLeftButton.Application = null;
            this._dragLeftButton.AssociatedClickOperation = ICanClick.Core.ClickOperation.DragLeftButton;
            this._dragLeftButton.AutoCheck = false;
            this._dragLeftButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_dragLeftButton.BackgroundImage")));
            this._dragLeftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._dragLeftButton.Location = new System.Drawing.Point(2, 86);
            this._dragLeftButton.Margin = new System.Windows.Forms.Padding(1);
            this._dragLeftButton.Name = "_dragLeftButton";
            this._dragLeftButton.Size = new System.Drawing.Size(40, 40);
            this._dragLeftButton.TabIndex = 4;
            this._dragLeftButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._formToolTip.SetToolTip(this._dragLeftButton, "Drag left");
            this._dragLeftButton.UseVisualStyleBackColor = true;
            // 
            // _singleClickMiddleButton
            // 
            this._singleClickMiddleButton.Appearance = System.Windows.Forms.Appearance.Button;
            this._singleClickMiddleButton.Application = null;
            this._singleClickMiddleButton.AssociatedClickOperation = ICanClick.Core.ClickOperation.SingleClickMiddleButton;
            this._singleClickMiddleButton.AutoCheck = false;
            this._singleClickMiddleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_singleClickMiddleButton.BackgroundImage")));
            this._singleClickMiddleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._singleClickMiddleButton.Location = new System.Drawing.Point(44, 44);
            this._singleClickMiddleButton.Margin = new System.Windows.Forms.Padding(1);
            this._singleClickMiddleButton.Name = "_singleClickMiddleButton";
            this._singleClickMiddleButton.Size = new System.Drawing.Size(40, 40);
            this._singleClickMiddleButton.TabIndex = 3;
            this._singleClickMiddleButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._formToolTip.SetToolTip(this._singleClickMiddleButton, "Single click middle");
            this._singleClickMiddleButton.UseVisualStyleBackColor = true;
            // 
            // _doubleClickLeftButton
            // 
            this._doubleClickLeftButton.Appearance = System.Windows.Forms.Appearance.Button;
            this._doubleClickLeftButton.Application = null;
            this._doubleClickLeftButton.AssociatedClickOperation = ICanClick.Core.ClickOperation.DoubleClickLeftButton;
            this._doubleClickLeftButton.AutoCheck = false;
            this._doubleClickLeftButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_doubleClickLeftButton.BackgroundImage")));
            this._doubleClickLeftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._doubleClickLeftButton.Location = new System.Drawing.Point(2, 44);
            this._doubleClickLeftButton.Margin = new System.Windows.Forms.Padding(1);
            this._doubleClickLeftButton.Name = "_doubleClickLeftButton";
            this._doubleClickLeftButton.Size = new System.Drawing.Size(40, 40);
            this._doubleClickLeftButton.TabIndex = 2;
            this._doubleClickLeftButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._formToolTip.SetToolTip(this._doubleClickLeftButton, "Double click left");
            this._doubleClickLeftButton.UseVisualStyleBackColor = true;
            // 
            // _singleClickRightButton
            // 
            this._singleClickRightButton.Appearance = System.Windows.Forms.Appearance.Button;
            this._singleClickRightButton.Application = null;
            this._singleClickRightButton.AssociatedClickOperation = ICanClick.Core.ClickOperation.SingleClickRightButton;
            this._singleClickRightButton.AutoCheck = false;
            this._singleClickRightButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_singleClickRightButton.BackgroundImage")));
            this._singleClickRightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._singleClickRightButton.Location = new System.Drawing.Point(44, 2);
            this._singleClickRightButton.Margin = new System.Windows.Forms.Padding(1);
            this._singleClickRightButton.Name = "_singleClickRightButton";
            this._singleClickRightButton.Size = new System.Drawing.Size(40, 40);
            this._singleClickRightButton.TabIndex = 1;
            this._singleClickRightButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._formToolTip.SetToolTip(this._singleClickRightButton, "Single click right");
            this._singleClickRightButton.UseVisualStyleBackColor = true;
            // 
            // _singleClickLeftButton
            // 
            this._singleClickLeftButton.Appearance = System.Windows.Forms.Appearance.Button;
            this._singleClickLeftButton.Application = null;
            this._singleClickLeftButton.AssociatedClickOperation = ICanClick.Core.ClickOperation.SingleClickLeftButton;
            this._singleClickLeftButton.AutoCheck = false;
            this._singleClickLeftButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_singleClickLeftButton.BackgroundImage")));
            this._singleClickLeftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._singleClickLeftButton.Checked = true;
            this._singleClickLeftButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this._singleClickLeftButton.Location = new System.Drawing.Point(2, 2);
            this._singleClickLeftButton.Margin = new System.Windows.Forms.Padding(1);
            this._singleClickLeftButton.Name = "_singleClickLeftButton";
            this._singleClickLeftButton.Size = new System.Drawing.Size(40, 40);
            this._singleClickLeftButton.TabIndex = 0;
            this._singleClickLeftButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._formToolTip.SetToolTip(this._singleClickLeftButton, "Single click left");
            this._singleClickLeftButton.UseVisualStyleBackColor = true;
            // 
            // _trayNotifyIcon
            // 
            this._trayNotifyIcon.ContextMenuStrip = this._trayIconContextMenuStrip;
            this._trayNotifyIcon.Text = "ICanClick";
            this._trayNotifyIcon.Visible = true;
            this._trayNotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this._trayNotifyIcon_MouseClick);
            this._trayNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this._trayNotifyIcon_MouseDoubleClick);
            // 
            // _trayIconContextMenuStrip
            // 
            this._trayIconContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayIconContextMenuStripEnabledButton,
            this.toolStripSeparator2,
            this.trayIconContextMenuStripSettingsButton,
            this.trayIconContextMenuStripAboutButton,
            this.toolStripSeparator1,
            this.trayIconContextMenuStripCloseButton});
            this._trayIconContextMenuStrip.Name = "trayIconContextMenuStrip";
            this._trayIconContextMenuStrip.Size = new System.Drawing.Size(153, 126);
            // 
            // trayIconContextMenuStripEnabledButton
            // 
            this.trayIconContextMenuStripEnabledButton.Name = "trayIconContextMenuStripEnabledButton";
            this.trayIconContextMenuStripEnabledButton.Size = new System.Drawing.Size(152, 22);
            this.trayIconContextMenuStripEnabledButton.Text = "Enabled";
            this.trayIconContextMenuStripEnabledButton.Click += new System.EventHandler(this._trayNotifyIcon_ContextMenuStripEnabledButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // trayIconContextMenuStripSettingsButton
            // 
            this.trayIconContextMenuStripSettingsButton.Name = "trayIconContextMenuStripSettingsButton";
            this.trayIconContextMenuStripSettingsButton.Size = new System.Drawing.Size(152, 22);
            this.trayIconContextMenuStripSettingsButton.Text = "Settings";
            this.trayIconContextMenuStripSettingsButton.Click += new System.EventHandler(this._trayIconContextMenuStripSettingsButton_Click);
            // 
            // trayIconContextMenuStripAboutButton
            // 
            this.trayIconContextMenuStripAboutButton.Name = "trayIconContextMenuStripAboutButton";
            this.trayIconContextMenuStripAboutButton.Size = new System.Drawing.Size(152, 22);
            this.trayIconContextMenuStripAboutButton.Text = "About";
            this.trayIconContextMenuStripAboutButton.Click += new System.EventHandler(this._trayIconContextMenuStripAboutButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // trayIconContextMenuStripCloseButton
            // 
            this.trayIconContextMenuStripCloseButton.Name = "trayIconContextMenuStripCloseButton";
            this.trayIconContextMenuStripCloseButton.Size = new System.Drawing.Size(152, 22);
            this.trayIconContextMenuStripCloseButton.Text = "Close";
            this.trayIconContextMenuStripCloseButton.Click += new System.EventHandler(this._trayNotifyIcon_ContextMenuStripCloseButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(86, 128);
            this.Controls.Add(this._dragRightButton);
            this.Controls.Add(this._dragLeftButton);
            this.Controls.Add(this._singleClickMiddleButton);
            this.Controls.Add(this._doubleClickLeftButton);
            this.Controls.Add(this._singleClickRightButton);
            this.Controls.Add(this._singleClickLeftButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ICanClick";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this._trayIconContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.NotifyIcon _trayNotifyIcon;
		private ICanClick.ClickOperationButton _dragRightButton;
		private ICanClick.ClickOperationButton _dragLeftButton;
		private ICanClick.ClickOperationButton _singleClickMiddleButton;
		private ICanClick.ClickOperationButton _doubleClickLeftButton;
		private ICanClick.ClickOperationButton _singleClickRightButton;
		private ICanClick.ClickOperationButton _singleClickLeftButton;
        private System.Windows.Forms.ToolTip _formToolTip;
        private System.Windows.Forms.ContextMenuStrip _trayIconContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem trayIconContextMenuStripEnabledButton;
        private System.Windows.Forms.ToolStripMenuItem trayIconContextMenuStripAboutButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem trayIconContextMenuStripCloseButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem trayIconContextMenuStripSettingsButton;
	}
}
