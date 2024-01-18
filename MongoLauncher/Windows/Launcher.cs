using System;
using System.Configuration;
using System.Windows.Forms;
using MongoLauncher.controllers;

namespace MongoLauncher
{
    public partial class Launcher : Form
    {
        public static bool mongoState = false;
        public static bool isPathAvailable;
        public Launcher()
        {
            InitializeComponent();
        }

        //server state
        private void setState()
        {
            if (mongoState)
            {
                chkIsAuth.Enabled = false;
                txtPort.ReadOnly = true;
                btnLaunch.Image = MongoLauncher.Properties.Resources.icon_pause;
                txtServerState.Text = "Stop Server";
            }
            else
            {
                chkIsAuth.Enabled = true;
                txtPort.ReadOnly = false;
                btnLaunch.Image = MongoLauncher.Properties.Resources.icon_play;
                txtServerState.Text = "Start Server";

            }
        }
        
        //start mongodb server
        private void StartMongo()
        {
            string mongodPath = ConfigurationManager.AppSettings["mongodPath"];
            isPathAvailable = verification.checkMongodVersionfromPath(mongodPath);

            string dbpath = ConfigurationManager.AppSettings["dbpath"];
            string port = ConfigurationManager.AppSettings["port"];
            bool isAuth = chkIsAuth.Checked;
            
            if (!mongoState)
            {
                if (MongoConfig.isGlobal)
                {
                    server.StartServer(dbpath, isAuth, port);
                }
                else
                {
                    if (isPathAvailable)
                    {
                        
                        server.StartServer(mongodPath, dbpath, isAuth, port);
                    }
                    else
                    {
                        MessageBox.Show("MongoDB Path Not Added !");
                    }
                    
                }
                setState();
            }
            else
            {
                server.KillMongoServer();
                setState();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string mongosh = verification.GetMongoSHVersion();
            string mongod = verification.GetMongoDVersion();
            if (mongosh != null && mongod != null)
            {
                MongoConfig.isGlobal = true;
            }
            else
            {
                MongoConfig.isGlobal = false; 
            }
            txtPath.Text = ConfigurationManager.AppSettings["dbpath"];
            txtPort.Text = ConfigurationManager.AppSettings["port"];
            string auth = ConfigurationManager.AppSettings["isAuth"];
            if(auth == "true")
            {
                chkIsAuth.Checked = true;
            }
            else
            {
                chkIsAuth.Checked = false;
            }
        }

        private void btnOpenPath_Click(object sender, EventArgs e)
        {
            if (openPathDialog.ShowDialog() == DialogResult.OK)
            {
                string dbPath = openPathDialog.SelectedPath;
                txtPath.Text = dbPath;
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["dbPath"].Value = dbPath;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                
            }
        }
        private void txtPort_TextChanged(object sender, EventArgs e)
        {
            if (txtPort.Text != null)
            {
                string port = txtPort.Text;
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["port"].Value = port;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

        private void btnShell_Click(object sender, EventArgs e)
        {
            if (mongoState)
            {
                string mongoshPath = ConfigurationManager.AppSettings["mongoshPath"];
                isPathAvailable = verification.checkMongoshVersionfromPath(mongoshPath);
                string current_port = ConfigurationManager.AppSettings["port"];
                if (MongoConfig.isGlobal)
                {
                    mongosh.RunMongoshCommand(current_port);
                }
                else
                {
                    if (isPathAvailable)
                    {
                        mongosh.RunMongoshCommand(mongoshPath, current_port);
                    }
                    else
                    {
                        MessageBox.Show("Mongo Shell Path Not Added !");
                    }

                }
            }
            else
            {
                MessageBox.Show("Start the Server First");
            }
            
            
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
           StartMongo();
        }

        private void chkIsAuth_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsAuth.Checked)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["isAuth"].Value = "true";
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }else 
            if (!chkIsAuth.Checked)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["isAuth"].Value = "false";
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            MongoConfig mc = new MongoConfig();
            mc.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            mc.Location = new System.Drawing.Point((Launcher.ActiveForm.Location.X + Launcher.ActiveForm.Width / 2) - (mc.Width / 2), (Launcher.ActiveForm.Location.Y + Launcher.ActiveForm.Height / 2) - (mc.Height / 2));
            mc.Show(Launcher.ActiveForm);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (mongoState)
            {
                server.KillMongoServer();
                StartMongo();
                MessageBox.Show("Server Restarted Successfully");
            }
            else
            {
                MessageBox.Show("Start the Server First");
            }
            
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            info.Location = new System.Drawing.Point((Launcher.ActiveForm.Location.X + Launcher.ActiveForm.Width / 2) - (info.Width / 2), (Launcher.ActiveForm.Location.Y + Launcher.ActiveForm.Height / 2) - (info.Height / 2));
            info.Show(Launcher.ActiveForm);
        }

        private void Launcher_FormClosed(object sender, FormClosedEventArgs e)
        {
            server.KillMongoServer();
        }
    }
}
