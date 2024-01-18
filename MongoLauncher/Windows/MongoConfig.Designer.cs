namespace MongoLauncher
{
    partial class MongoConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MongoConfig));
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMongodPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMongoshPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkIsGlobal = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnOpenPathMongosh = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnOpenPathMongod = new Guna.UI2.WinForms.Guna2ImageButton();
            this.openMongosh = new System.Windows.Forms.FolderBrowserDialog();
            this.openMongod = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(22, 80);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(105, 21);
            this.guna2HtmlLabel1.TabIndex = 6;
            this.guna2HtmlLabel1.Text = "Mongod Path :";
            // 
            // txtMongodPath
            // 
            this.txtMongodPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMongodPath.DefaultText = "";
            this.txtMongodPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMongodPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMongodPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMongodPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMongodPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMongodPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMongodPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMongodPath.Location = new System.Drawing.Point(22, 107);
            this.txtMongodPath.Name = "txtMongodPath";
            this.txtMongodPath.PasswordChar = '\0';
            this.txtMongodPath.PlaceholderText = "";
            this.txtMongodPath.ReadOnly = true;
            this.txtMongodPath.SelectedText = "";
            this.txtMongodPath.Size = new System.Drawing.Size(222, 26);
            this.txtMongodPath.TabIndex = 5;
            this.txtMongodPath.TabStop = false;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(22, 150);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(111, 21);
            this.guna2HtmlLabel2.TabIndex = 9;
            this.guna2HtmlLabel2.Text = "Mongosh Path :";
            // 
            // txtMongoshPath
            // 
            this.txtMongoshPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMongoshPath.DefaultText = "";
            this.txtMongoshPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMongoshPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMongoshPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMongoshPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMongoshPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMongoshPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMongoshPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMongoshPath.Location = new System.Drawing.Point(22, 177);
            this.txtMongoshPath.Name = "txtMongoshPath";
            this.txtMongoshPath.PasswordChar = '\0';
            this.txtMongoshPath.PlaceholderText = "";
            this.txtMongoshPath.ReadOnly = true;
            this.txtMongoshPath.SelectedText = "";
            this.txtMongoshPath.Size = new System.Drawing.Size(222, 26);
            this.txtMongoshPath.TabIndex = 8;
            this.txtMongoshPath.TabStop = false;
            // 
            // chkIsGlobal
            // 
            this.chkIsGlobal.AutoSize = true;
            this.chkIsGlobal.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(151)))), ((int)(((byte)(69)))));
            this.chkIsGlobal.CheckedState.BorderRadius = 0;
            this.chkIsGlobal.CheckedState.BorderThickness = 0;
            this.chkIsGlobal.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(151)))), ((int)(((byte)(69)))));
            this.chkIsGlobal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkIsGlobal.Location = new System.Drawing.Point(128, 230);
            this.chkIsGlobal.Name = "chkIsGlobal";
            this.chkIsGlobal.Size = new System.Drawing.Size(15, 14);
            this.chkIsGlobal.TabIndex = 12;
            this.chkIsGlobal.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.chkIsGlobal.UncheckedState.BorderRadius = 0;
            this.chkIsGlobal.UncheckedState.BorderThickness = 0;
            this.chkIsGlobal.UncheckedState.FillColor = System.Drawing.Color.Silver;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(22, 224);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(95, 21);
            this.guna2HtmlLabel3.TabIndex = 11;
            this.guna2HtmlLabel3.Text = "Use Globally :";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(69, 24);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(175, 21);
            this.guna2HtmlLabel4.TabIndex = 13;
            this.guna2HtmlLabel4.Text = "MongoDB Configurations";
            // 
            // btnOpenPathMongosh
            // 
            this.btnOpenPathMongosh.CheckedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnOpenPathMongosh.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnOpenPathMongosh.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenPathMongosh.Image")));
            this.btnOpenPathMongosh.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnOpenPathMongosh.ImageRotate = 0F;
            this.btnOpenPathMongosh.ImageSize = new System.Drawing.Size(25, 25);
            this.btnOpenPathMongosh.Location = new System.Drawing.Point(253, 177);
            this.btnOpenPathMongosh.Name = "btnOpenPathMongosh";
            this.btnOpenPathMongosh.PressedState.ImageSize = new System.Drawing.Size(23, 23);
            this.btnOpenPathMongosh.Size = new System.Drawing.Size(25, 25);
            this.btnOpenPathMongosh.TabIndex = 10;
            this.btnOpenPathMongosh.Click += new System.EventHandler(this.btnOpenPathMongosh_Click);
            // 
            // btnOpenPathMongod
            // 
            this.btnOpenPathMongod.CheckedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnOpenPathMongod.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnOpenPathMongod.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenPathMongod.Image")));
            this.btnOpenPathMongod.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnOpenPathMongod.ImageRotate = 0F;
            this.btnOpenPathMongod.ImageSize = new System.Drawing.Size(25, 25);
            this.btnOpenPathMongod.Location = new System.Drawing.Point(253, 107);
            this.btnOpenPathMongod.Name = "btnOpenPathMongod";
            this.btnOpenPathMongod.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnOpenPathMongod.Size = new System.Drawing.Size(25, 25);
            this.btnOpenPathMongod.TabIndex = 7;
            this.btnOpenPathMongod.Click += new System.EventHandler(this.btnOpenPathMongod_Click);
            // 
            // MongoConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 297);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.chkIsGlobal);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.btnOpenPathMongosh);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.txtMongoshPath);
            this.Controls.Add(this.btnOpenPathMongod);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txtMongodPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MongoConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MongoConfig";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MongoConfig_FormClosed);
            this.Load += new System.EventHandler(this.MongoConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton btnOpenPathMongod;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtMongodPath;
        private Guna.UI2.WinForms.Guna2ImageButton btnOpenPathMongosh;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtMongoshPath;
        private Guna.UI2.WinForms.Guna2CheckBox chkIsGlobal;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private System.Windows.Forms.FolderBrowserDialog openMongosh;
        private System.Windows.Forms.FolderBrowserDialog openMongod;
    }
}