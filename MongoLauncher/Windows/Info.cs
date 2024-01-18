using System;
using System.Configuration;
using System.Windows.Forms;
using MongoLauncher.controllers;

namespace MongoLauncher
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        { 
            string mongosh = verification.GetMongoSHVersion();
            string mongod = verification.GetMongoDVersion();

            if(mongosh != null)
            {
                txtVerMongosh.Text = mongosh;
            }
            else
            {
                try
                {
                    string mongoshfromPath = verification.GetMongoSHVersionfrompath(ConfigurationManager.AppSettings["mongoshPath"]);
                    if(mongoshfromPath != null)
                    {
                        txtVerMongosh.Text = mongoshfromPath;
                    }
                    else
                    {
                        txtVerMongosh.Text = "not found";
                    }
                    

                }catch (Exception)
                {
                    txtVerMongosh.Text = "not found";
                }
                
            }
            if(mongod != null)
            {
                txtVerMongod.Text = mongod;
            }
            else
            {
                try
                {
                    string mongodfromPath = verification.GetMongoDVersionfromPath(ConfigurationManager.AppSettings["mongodPath"]);
                    if(mongodfromPath != null)
                    {
                        txtVerMongod.Text = mongodfromPath;
                    }
                    else
                    {
                        txtVerMongod.Text = "not found";
                    }
                    
                }
                catch (Exception)
                {
                    txtVerMongod.Text = "not found";
                }
                
            }
            
            txtLauncherVersion.Text = ConfigurationManager.AppSettings["appVersion"];

        }
    }
}
