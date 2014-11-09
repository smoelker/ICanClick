/*
 * Created by SharpDevelop.
 * User: yict1
 * Date: 23-7-2008
 * Time: 13:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ICanClick
{
	partial class AboutForm
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
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.copyrightTextBox = new System.Windows.Forms.TextBox();
            this.versionTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.madeWithPaintDotNetPictureBox = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.licenseDescriptionLabel = new System.Windows.Forms.Label();
            this.licenseGroupBox = new System.Windows.Forms.GroupBox();
            this.gnuGplLicenseLinkLabel = new System.Windows.Forms.LinkLabel();
            this.licenseDescriptionDotLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.madeWithPaintDotNetPictureBox)).BeginInit();
            this.licenseGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Location = new System.Drawing.Point(12, 6);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(64, 64);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.copyrightTextBox);
            this.panel1.Controls.Add(this.versionTextBox);
            this.panel1.Controls.Add(this.productNameTextBox);
            this.panel1.Controls.Add(this.logoPictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 80);
            this.panel1.TabIndex = 1;
            // 
            // copyrightTextBox
            // 
            this.copyrightTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.copyrightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.copyrightTextBox.Location = new System.Drawing.Point(82, 54);
            this.copyrightTextBox.Name = "copyrightTextBox";
            this.copyrightTextBox.ReadOnly = true;
            this.copyrightTextBox.Size = new System.Drawing.Size(152, 13);
            this.copyrightTextBox.TabIndex = 4;
            this.copyrightTextBox.Text = "©";
            // 
            // versionTextBox
            // 
            this.versionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.versionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.versionTextBox.Location = new System.Drawing.Point(82, 35);
            this.versionTextBox.Name = "versionTextBox";
            this.versionTextBox.ReadOnly = true;
            this.versionTextBox.Size = new System.Drawing.Size(152, 13);
            this.versionTextBox.TabIndex = 3;
            this.versionTextBox.Text = "version";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.productNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameTextBox.Location = new System.Drawing.Point(82, 5);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.ReadOnly = true;
            this.productNameTextBox.Size = new System.Drawing.Size(152, 24);
            this.productNameTextBox.TabIndex = 2;
            this.productNameTextBox.Text = "ICanClick";
            // 
            // madeWithPaintDotNetPictureBox
            // 
            this.madeWithPaintDotNetPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.madeWithPaintDotNetPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.madeWithPaintDotNetPictureBox.Location = new System.Drawing.Point(11, 105);
            this.madeWithPaintDotNetPictureBox.Name = "madeWithPaintDotNetPictureBox";
            this.madeWithPaintDotNetPictureBox.Size = new System.Drawing.Size(79, 20);
            this.madeWithPaintDotNetPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.madeWithPaintDotNetPictureBox.TabIndex = 3;
            this.madeWithPaintDotNetPictureBox.TabStop = false;
            this.madeWithPaintDotNetPictureBox.Click += new System.EventHandler(this.MadeWithPaintDotNetPictureBoxClick);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(337, 290);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // licenseDescriptionLabel
            // 
            this.licenseDescriptionLabel.AutoSize = true;
            this.licenseDescriptionLabel.Location = new System.Drawing.Point(11, 24);
            this.licenseDescriptionLabel.Name = "licenseDescriptionLabel";
            this.licenseDescriptionLabel.Size = new System.Drawing.Size(229, 13);
            this.licenseDescriptionLabel.TabIndex = 3;
            this.licenseDescriptionLabel.Text = "This software is released under the terms of the";
            // 
            // licenseGroupBox
            // 
            this.licenseGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.licenseGroupBox.Controls.Add(this.gnuGplLicenseLinkLabel);
            this.licenseGroupBox.Controls.Add(this.licenseDescriptionLabel);
            this.licenseGroupBox.Controls.Add(this.licenseDescriptionDotLabel);
            this.licenseGroupBox.Location = new System.Drawing.Point(12, 86);
            this.licenseGroupBox.Name = "licenseGroupBox";
            this.licenseGroupBox.Size = new System.Drawing.Size(400, 58);
            this.licenseGroupBox.TabIndex = 4;
            this.licenseGroupBox.TabStop = false;
            this.licenseGroupBox.Text = "License";
            // 
            // gnuGplLicenseLinkLabel
            // 
            this.gnuGplLicenseLinkLabel.AutoSize = true;
            this.gnuGplLicenseLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.gnuGplLicenseLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.gnuGplLicenseLinkLabel.Location = new System.Drawing.Point(236, 24);
            this.gnuGplLicenseLinkLabel.Name = "gnuGplLicenseLinkLabel";
            this.gnuGplLicenseLinkLabel.Size = new System.Drawing.Size(119, 13);
            this.gnuGplLicenseLinkLabel.TabIndex = 4;
            this.gnuGplLicenseLinkLabel.TabStop = true;
            this.gnuGplLicenseLinkLabel.Text = "GNU Public License V3";
            this.gnuGplLicenseLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
            // 
            // licenseDescriptionDotLabel
            // 
            this.licenseDescriptionDotLabel.AutoSize = true;
            this.licenseDescriptionDotLabel.BackColor = System.Drawing.Color.Transparent;
            this.licenseDescriptionDotLabel.Location = new System.Drawing.Point(351, 24);
            this.licenseDescriptionDotLabel.Name = "licenseDescriptionDotLabel";
            this.licenseDescriptionDotLabel.Size = new System.Drawing.Size(10, 13);
            this.licenseDescriptionDotLabel.TabIndex = 5;
            this.licenseDescriptionDotLabel.Text = ".";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.madeWithPaintDotNetPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 134);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credits";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(11, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(378, 79);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Sil Moelker (smoelker@gmail.com)";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 325);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.licenseGroupBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About ICanClick";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.madeWithPaintDotNetPictureBox)).EndInit();
            this.licenseGroupBox.ResumeLayout(false);
            this.licenseGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox licenseGroupBox;
		private System.Windows.Forms.LinkLabel gnuGplLicenseLinkLabel;
		private System.Windows.Forms.Label licenseDescriptionDotLabel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox copyrightTextBox;
		private System.Windows.Forms.Label licenseDescriptionLabel;
		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.PictureBox madeWithPaintDotNetPictureBox;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.TextBox productNameTextBox;
		private System.Windows.Forms.TextBox versionTextBox;
		private System.Windows.Forms.Panel panel1;
	}
}
