using System;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.Fallout3
{
    public partial class Fallout3Settings : UserControl
    {
        public bool AutoStart { get; set; }
        public bool SPECIAL { get; set; }
        public bool TargetPractice { get; set; }
        public bool Escape { get; set; }
        public bool Walking { get; set; }
        public bool Vault87 { get; set; }
        public bool Flashbang { get; set; }
        public bool Escape2 { get; set; }
        public bool Walking2 { get; set; }
        public bool Memorial { get; set; }

        private const bool DEFAULT_AUTOSTART = true;
        private const bool DEFAULT_SPECIAL = true;
        private const bool DEFAULT_TARGETPRACTICE = true;
        private const bool DEFAULT_ESCAPE = true;
        private const bool DEFAULT_WALKING = true;
        private const bool DEFAULT_VAULT87 = true;
        private const bool DEFAULT_FLASHBANG = true;
        private const bool DEFAULT_ESCAPE2 = true;
        private const bool DEFAULT_WALKING2 = true;
        private const bool DEFAULT_MEMORIAL = true;

        public Fallout3Settings()
        {
            InitializeComponent();

            this.chkSPECIAL.DataBindings.Add("Checked", this, "SPECIAL", false, DataSourceUpdateMode.OnPropertyChanged);
            this.chkTargetPractice.DataBindings.Add("Checked", this, "TargetPractice", false, DataSourceUpdateMode.OnPropertyChanged);
            this.chkEscape.DataBindings.Add("Checked", this, "Escape", false, DataSourceUpdateMode.OnPropertyChanged);
            this.chkWalking.DataBindings.Add("Checked", this, "Walking", false, DataSourceUpdateMode.OnPropertyChanged);
            this.chkVault87.DataBindings.Add("Checked", this, "Vault87", false, DataSourceUpdateMode.OnPropertyChanged);
            this.chkFlashbang.DataBindings.Add("Checked", this, "Flashbang", false, DataSourceUpdateMode.OnPropertyChanged);
            this.chkEscape2.DataBindings.Add("Checked", this, "Escape2", false, DataSourceUpdateMode.OnPropertyChanged);
            this.chkWalking2.DataBindings.Add("Checked", this, "Walking2", false, DataSourceUpdateMode.OnPropertyChanged);
            this.chkMemorial.DataBindings.Add("Checked", this, "Memorial", false, DataSourceUpdateMode.OnPropertyChanged);

            // defaults
            this.AutoStart = DEFAULT_AUTOSTART;
            this.SPECIAL = DEFAULT_SPECIAL;
            this.TargetPractice = DEFAULT_TARGETPRACTICE;
            this.Escape = DEFAULT_ESCAPE;
            this.Walking = DEFAULT_WALKING;
            this.Vault87 = DEFAULT_VAULT87;
            this.Flashbang = DEFAULT_FLASHBANG;
            this.Escape2 = DEFAULT_ESCAPE2;
            this.Walking2 = DEFAULT_WALKING2;
            this.Memorial = DEFAULT_MEMORIAL;
        }

        public XmlNode GetSettings(XmlDocument doc)
        {
            XmlElement settingsNode = doc.CreateElement("Settings");

            settingsNode.AppendChild(ToElement(doc, "Version", Assembly.GetExecutingAssembly().GetName().Version.ToString(3)));

            settingsNode.AppendChild(ToElement(doc, "AutoStart", this.AutoStart));
            settingsNode.AppendChild(ToElement(doc, "SPECIAL", this.SPECIAL));
            settingsNode.AppendChild(ToElement(doc, "TargetPractice", this.TargetPractice));
            settingsNode.AppendChild(ToElement(doc, "Escape", this.Escape));
            settingsNode.AppendChild(ToElement(doc, "Walking", this.Walking));
            settingsNode.AppendChild(ToElement(doc, "Vault87", this.Vault87));
            settingsNode.AppendChild(ToElement(doc, "Flashbang", this.Flashbang));
            settingsNode.AppendChild(ToElement(doc, "Escape2", this.Escape2));
            settingsNode.AppendChild(ToElement(doc, "Walking2", this.Walking2));
            settingsNode.AppendChild(ToElement(doc, "Memorial", this.Memorial));

            return settingsNode;
        }

        public void SetSettings(XmlNode settings)
        {
            this.AutoStart = ParseBool(settings, "AutoStart", DEFAULT_AUTOSTART);
            this.SPECIAL = ParseBool(settings, "SPECIAL", DEFAULT_SPECIAL);
            this.TargetPractice = ParseBool(settings, "TargetPractice", DEFAULT_TARGETPRACTICE);
            this.Escape = ParseBool(settings, "Escape", DEFAULT_ESCAPE);
            this.Walking = ParseBool(settings, "Walking", DEFAULT_WALKING);
            this.Vault87 = ParseBool(settings, "Vault87", DEFAULT_VAULT87);
            this.Flashbang = ParseBool(settings, "Flashbang", DEFAULT_FLASHBANG);
            this.Escape2 = ParseBool(settings, "Escape2", DEFAULT_ESCAPE2);
            this.Walking2 = ParseBool(settings, "Walking2", DEFAULT_WALKING2);
            this.Memorial = ParseBool(settings, "Memorial", DEFAULT_MEMORIAL);
        }

        static bool ParseBool(XmlNode settings, string setting, bool default_ = false)
        {
            bool val;
            return settings[setting] != null ?
                (Boolean.TryParse(settings[setting].InnerText, out val) ? val : default_)
                : default_;
        }

        static XmlElement ToElement<T>(XmlDocument document, string name, T value)
        {
            XmlElement str = document.CreateElement(name);
            str.InnerText = value.ToString();
            return str;
        }
    }
}
