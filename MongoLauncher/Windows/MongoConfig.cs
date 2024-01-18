using System;
using System.Configuration;
using System.Windows.Forms;

namespace MongoLauncher
{
    public partial class MongoConfig : Form
    {
        public static bool isGlobal;
        public MongoConfig()
        {
            InitializeComponent();
        }

        private void MongoConfig_Load(object sender, EventArgs e)
        {
            txtMongodPath.Text = ConfigurationManager.AppSettings["mongodPath"];
            txtMongoshPath.Text = ConfigurationManager.AppSettings["mongoshPath"];
            if (isGlobal)
            {
                chkIsGlobal.Checked = true;
            }
        }

        private void btnOpenPathMongod_Click(object sender, EventArgs e)
        {
            if (openMongod.ShowDialog() == DialogResult.OK)
            {
                string RawPath = openMongod.SelectedPath;
                string mongodPath = $"{RawPath}/bin";
                txtMongodPath.Text = mongodPath;

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["mongodPath"].Value = mongodPath;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

        private void btnOpenPathMongosh_Click(object sender, EventArgs e)
        {
            if (openMongosh.ShowDialog() == DialogResult.OK)
            {
                string RawPath = openMongosh.SelectedPath;
                string mongoshPath = $"{RawPath}/bin";
                txtMongoshPath.Text = mongoshPath;

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["mongoshPath"].Value = mongoshPath;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");

            }
        }

        private void MongoConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
