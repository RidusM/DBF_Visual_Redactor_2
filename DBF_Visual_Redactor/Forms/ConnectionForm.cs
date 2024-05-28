using System;
using System.Configuration;
using System.Windows.Forms;
using ConfigurationManager = System.Configuration.ConfigurationManager;

namespace DBF_Visual_Redactor
{
    public partial class ConnectionForm : Form
    {
        public string host;

        public string port;
        public ConnectionForm()
        {
            InitializeComponent();
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = config.AppSettings.Settings;
            textBoxIP.Text = settings["ip"].Value;
            textBoxPort.Text = settings["port"].Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            API apiMethods = new API();
            try
            {
                MessageBox.Show(apiMethods.CheckConnection(textBoxIP.Text, textBoxPort.Text).Result);
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConnectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = config.AppSettings.Settings;
            settings["ip"].Value = textBoxIP.Text;
            settings["port"].Value = textBoxPort.Text;
            host = settings["ip"].Value;
            port = settings["port"].Value;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
        }
    }
}
