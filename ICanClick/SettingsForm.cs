using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ICanClick.Core;

namespace ICanClick
{
    public partial class SettingsForm : Form
    {
        private Settings _settings;

        private SettingsForm(Settings settings)
        {
            _settings = settings;
            InitializeComponent();

            _clickIntervalNumericUpDown.Value = _settings.ClickInterval;
            _startWithWindows.Checked = _settings.AutoStart;
        }


        public static void ShowSettingsDialog(Settings settings)
        {
            if (settings == null)
            {
                throw new ArgumentNullException("settings");
            }
            using (SettingsForm form = new SettingsForm(settings))
            {
                form.ShowDialog();
            }
        }

        private void _okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void _cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                _settings.AutoStart = _startWithWindows.Checked;
                _settings.ClickInterval = (int)_clickIntervalNumericUpDown.Value;
                _settings.Save();
            }
        }
    }
}
