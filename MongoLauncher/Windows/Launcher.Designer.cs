namespace MongoLauncher
{
    partial class Launcher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.txtPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.chkIsAuth = new Guna.UI2.WinForms.Guna2CheckBox();
            this.openPathDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPort = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtServerState = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnConfig = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnRestart = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnLaunch = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnShell = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnOpenPath = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInfo = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPath.DefaultText = "";
            this.txtPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPath.Location = new System.Drawing.Point(117, 148);
            this.txtPath.Name = "txtPath";
            this.txtPath.PasswordChar = '\0';
            this.txtPath.PlaceholderText = "";
            this.txtPath.ReadOnly = true;
            this.txtPath.SelectedText = "";
            this.txtPath.Size = new System.Drawing.Size(194, 26);
            this.txtPath.TabIndex = 2;
            this.txtPath.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.IsSelectionEnabled = false;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(46, 150);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(66, 21);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "DB Path :";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.IsSelectionEnabled = false;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(236, 191);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(45, 21);
            this.guna2HtmlLabel2.TabIndex = 5;
            this.guna2HtmlLabel2.Text = "Auth :";
            // 
            // chkIsAuth
            // 
            this.chkIsAuth.AutoSize = true;
            this.chkIsAuth.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(151)))), ((int)(((byte)(69)))));
            this.chkIsAuth.CheckedState.BorderRadius = 0;
            this.chkIsAuth.CheckedState.BorderThickness = 0;
            this.chkIsAuth.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(151)))), ((int)(((byte)(69)))));
            this.chkIsAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkIsAuth.Location = new System.Drawing.Point(289, 197);
            this.chkIsAuth.Name = "chkIsAuth";
            this.chkIsAuth.Size = new System.Drawing.Size(15, 14);
            this.chkIsAuth.TabIndex = 6;
            this.chkIsAuth.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.chkIsAuth.UncheckedState.BorderRadius = 0;
            this.chkIsAuth.UncheckedState.BorderThickness = 0;
            this.chkIsAuth.UncheckedState.FillColor = System.Drawing.Color.Silver;
            this.chkIsAuth.CheckedChanged += new System.EventHandler(this.chkIsAuth_CheckedChanged);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.IsSelectionEnabled = false;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(69, 189);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(41, 21);
            this.guna2HtmlLabel3.TabIndex = 8;
            this.guna2HtmlLabel3.Text = "Port :";
            // 
            // txtPort
            // 
            this.txtPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPort.DefaultText = "";
            this.txtPort.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPort.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPort.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPort.Location = new System.Drawing.Point(117, 188);
            this.txtPort.Name = "txtPort";
            this.txtPort.PasswordChar = '\0';
            this.txtPort.PlaceholderText = "";
            this.txtPort.SelectedText = "";
            this.txtPort.Size = new System.Drawing.Size(93, 26);
            this.txtPort.TabIndex = 7;
            this.txtPort.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.IsSelectionEnabled = false;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(174, 322);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(62, 15);
            this.guna2HtmlLabel4.TabIndex = 10;
            this.guna2HtmlLabel4.Text = "Mongo Shell";
            // 
            // txtServerState
            // 
            this.txtServerState.BackColor = System.Drawing.Color.Transparent;
            this.txtServerState.IsSelectionEnabled = false;
            this.txtServerState.Location = new System.Drawing.Point(20, 321);
            this.txtServerState.Name = "txtServerState";
            this.txtServerState.Size = new System.Drawing.Size(59, 15);
            this.txtServerState.TabIndex = 14;
            this.txtServerState.Text = "Start Server";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.IsSelectionEnabled = false;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(89, 322);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(71, 15);
            this.guna2HtmlLabel7.TabIndex = 15;
            this.guna2HtmlLabel7.Text = "Restart Server";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.IsSelectionEnabled = false;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(253, 322);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(69, 15);
            this.guna2HtmlLabel6.TabIndex = 17;
            this.guna2HtmlLabel6.Text = "Config Mongo";
            // 
            // btnConfig
            // 
            this.btnConfig.CheckedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnConfig.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
            this.btnConfig.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnConfig.ImageRotate = 0F;
            this.btnConfig.ImageSize = new System.Drawing.Size(30, 30);
            this.btnConfig.Location = new System.Drawing.Point(271, 287);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.PressedState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnConfig.Size = new System.Drawing.Size(34, 34);
            this.btnConfig.TabIndex = 16;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.CheckedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnRestart.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRestart.Image = ((System.Drawing.Image)(resources.GetObject("btnRestart.Image")));
            this.btnRestart.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnRestart.ImageRotate = 0F;
            this.btnRestart.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRestart.Location = new System.Drawing.Point(109, 287);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnRestart.Size = new System.Drawing.Size(34, 34);
            this.btnRestart.TabIndex = 13;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.CheckedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLaunch.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLaunch.Image = ((System.Drawing.Image)(resources.GetObject("btnLaunch.Image")));
            this.btnLaunch.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnLaunch.ImageRotate = 0F;
            this.btnLaunch.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLaunch.Location = new System.Drawing.Point(32, 287);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.PressedState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnLaunch.Size = new System.Drawing.Size(34, 34);
            this.btnLaunch.TabIndex = 12;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnShell
            // 
            this.btnShell.CheckedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnShell.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnShell.Image = ((System.Drawing.Image)(resources.GetObject("btnShell.Image")));
            this.btnShell.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnShell.ImageRotate = 0F;
            this.btnShell.ImageSize = new System.Drawing.Size(25, 25);
            this.btnShell.Location = new System.Drawing.Point(191, 287);
            this.btnShell.Name = "btnShell";
            this.btnShell.PressedState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnShell.Size = new System.Drawing.Size(34, 34);
            this.btnShell.TabIndex = 9;
            this.btnShell.Click += new System.EventHandler(this.btnShell_Click);
            // 
            // btnOpenPath
            // 
            this.btnOpenPath.CheckedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnOpenPath.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnOpenPath.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenPath.Image")));
            this.btnOpenPath.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnOpenPath.ImageRotate = 0F;
            this.btnOpenPath.ImageSize = new System.Drawing.Size(25, 25);
            this.btnOpenPath.Location = new System.Drawing.Point(317, 148);
            this.btnOpenPath.Name = "btnOpenPath";
            this.btnOpenPath.PressedState.ImageSize = new System.Drawing.Size(23, 23);
            this.btnOpenPath.Size = new System.Drawing.Size(25, 25);
            this.btnOpenPath.TabIndex = 4;
            this.btnOpenPath.Click += new System.EventHandler(this.btnOpenPath_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnInfo
            // 
            this.btnInfo.CheckedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnInfo.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnInfo.ImageRotate = 0F;
            this.btnInfo.ImageSize = new System.Drawing.Size(30, 30);
            this.btnInfo.Location = new System.Drawing.Point(334, 288);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.PressedState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnInfo.Size = new System.Drawing.Size(35, 35);
            this.btnInfo.TabIndex = 19;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.IsSelectionEnabled = false;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(342, 323);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(21, 15);
            this.guna2HtmlLabel5.TabIndex = 20;
            this.guna2HtmlLabel5.Text = "Info ";
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 381);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.txtServerState);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.btnShell);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.chkIsAuth);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.btnOpenPath);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mongo Launcher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Launcher_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtPath;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ImageButton btnOpenPath;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CheckBox chkIsAuth;
        private System.Windows.Forms.FolderBrowserDialog openPathDialog;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtPort;
        private Guna.UI2.WinForms.Guna2ImageButton btnShell;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2ImageButton btnLaunch;
        private Guna.UI2.WinForms.Guna2ImageButton btnRestart;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtServerState;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2ImageButton btnConfig;
        private Guna.UI2.WinForms.Guna2ImageButton btnInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
    }
}

