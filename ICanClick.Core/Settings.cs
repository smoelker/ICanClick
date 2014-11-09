using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Globalization;

namespace ICanClick.Core
{
    public sealed class Settings : INotifyPropertyChanged
    {
        private int _clickInterval;
        private bool _autoStart;

        public event EventHandler Saved;
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler ClickIntervalChanged;
        public event EventHandler AutoStartChanged;

        public int ClickInterval
        {
            get
            {
                return _clickInterval;
            }
            set
            {
                if (_clickInterval != value)
                {
                    _clickInterval = value;
                    OnClickIntervalChanged();
                }
            }
        }
        public bool AutoStart
        {
            get
            {
                return _autoStart;
            }
            set
            {
                if (_autoStart != value)
                {
                    _autoStart = value;
                    OnAutoStartChanged();
                }
            }
        }


        public Settings()
        {
            _clickInterval = 750;
            _autoStart = false;
        }

        private void OnClickIntervalChanged()
        {
            if (ClickIntervalChanged != null)
            {
                ClickIntervalChanged(this, EventArgs.Empty);
            }
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("ClickInterval"));
            }
        }
        private void OnAutoStartChanged()
        {
            if (AutoStartChanged != null)
            {
                AutoStartChanged(this, EventArgs.Empty);
            }
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("AutoStart"));
            }
        }

        private void OnSaved()
        {
            if (Saved != null)
            {
                Saved(this, EventArgs.Empty);
            }
        }

        public void Save()
        {
            var xDoc = new XDocument();
            var xSettings = new XElement("Settings");
            var xVersionAttribute = new XAttribute("version", GetVersion().ToString());
            var xClickInterval = new XElement("ClickInterval");
            var xAutoStart = new XElement("AutoStart");

            xClickInterval.Value = _clickInterval.ToString(CultureInfo.InvariantCulture);
            xAutoStart.Value = _autoStart.ToString(CultureInfo.InvariantCulture);

            xSettings.Add(xVersionAttribute);
            xSettings.Add(xClickInterval);
            xSettings.Add(xAutoStart);
            xDoc.Add(xSettings);

            string filePath = GetFilePath();
            string dir = Path.GetDirectoryName(filePath);
            if (Directory.Exists(dir) == false)
            {
                Directory.CreateDirectory(dir);
            }
            xDoc.Save(GetFilePath());
            OnSaved();
        }

        public void Reload()
        {
            string filePath = GetFilePath();
            if (File.Exists(filePath) == true)
            {
                XDocument xmlDocument = XDocument.Load(filePath);
                LoadFromXml(xmlDocument);
            }
        }

        private static string GetFilePath()
        {
            string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            return Path.Combine(appDataFolder, @"ICanClick\settings.xml");
        }

        private void LoadFromXml(XDocument xmlDocument)
        {
            XElement xSettings = xmlDocument.Descendants("Settings").FirstOrDefault();
            if (xSettings == null)
            {
                //TODO: Log?
                return;
            }
            Version version = null;
            XAttribute xVersionAttribute = xSettings.Attribute("version");
            if (xVersionAttribute != null)
            {
                try
                {
                    version = new Version(xVersionAttribute.Value);
                }
                catch (Exception)
                {
                    /* ignore */
                    //TODO: Log?
                }
            }

            if (version != GetVersion())
            {
                //TODO: Check version compatibility?
            }

            XElement xClickInterval = xSettings.Descendants("ClickInterval").FirstOrDefault();
            XElement xAutoStart = xSettings.Descendants("AutoStart").FirstOrDefault();

            if (xClickInterval != null)
            {
                ClickInterval = int.Parse(xClickInterval.Value, CultureInfo.InvariantCulture);
            }
            if (xAutoStart != null)
            {
                AutoStart = bool.Parse(xAutoStart.Value);
            }
        }

        private static Version GetVersion()
        {
            return typeof(Settings).Assembly.GetName().Version;
        }
    }
}