﻿namespace SuperLauncher
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
            this.logInGroupBox = new System.Windows.Forms.GroupBox();
            this.downloadingProgressBar = new System.Windows.Forms.ProgressBar();
            this.downloadingLabel = new System.Windows.Forms.Label();
            this.rememberPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.jarSelectorDropDown = new System.Windows.Forms.ComboBox();
            this.loginFailedLabel = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusIcon = new System.Windows.Forms.PictureBox();
            this.serviceStatusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.newsTab = new System.Windows.Forms.TabPage();
            this.newsWebBrowser = new WebKit.WebKitBrowser();
            this.mapsTab = new System.Windows.Forms.TabPage();
            this.mapsWebBrowser = new WebKit.WebKitBrowser();
            this.serversTab = new System.Windows.Forms.TabPage();
            this.serverWebBrowser = new WebKit.WebKitBrowser();
            this.texturePacksTab = new System.Windows.Forms.TabPage();
            this.texturePackWebBrowser = new WebKit.WebKitBrowser();
            this.modsTab = new System.Windows.Forms.TabPage();
            this.modWebBrowser = new WebKit.WebKitBrowser();
            this.skinsTab = new System.Windows.Forms.TabPage();
            this.skinWebBrowser = new WebKit.WebKitBrowser();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.logInGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.newsTab.SuspendLayout();
            this.mapsTab.SuspendLayout();
            this.serversTab.SuspendLayout();
            this.texturePacksTab.SuspendLayout();
            this.modsTab.SuspendLayout();
            this.skinsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // logInGroupBox
            // 
            this.logInGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logInGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.logInGroupBox.Controls.Add(this.downloadingProgressBar);
            this.logInGroupBox.Controls.Add(this.downloadingLabel);
            this.logInGroupBox.Controls.Add(this.rememberPasswordCheckBox);
            this.logInGroupBox.Controls.Add(this.jarSelectorDropDown);
            this.logInGroupBox.Controls.Add(this.loginFailedLabel);
            this.logInGroupBox.Controls.Add(this.logInButton);
            this.logInGroupBox.Controls.Add(this.passwordTextBox);
            this.logInGroupBox.Controls.Add(this.usernameTextBox);
            this.logInGroupBox.ForeColor = System.Drawing.Color.Black;
            this.logInGroupBox.Location = new System.Drawing.Point(444, 351);
            this.logInGroupBox.Name = "logInGroupBox";
            this.logInGroupBox.Size = new System.Drawing.Size(385, 126);
            this.logInGroupBox.TabIndex = 0;
            this.logInGroupBox.TabStop = false;
            this.logInGroupBox.Text = "Log In";
            // 
            // downloadingProgressBar
            // 
            this.downloadingProgressBar.Location = new System.Drawing.Point(177, 96);
            this.downloadingProgressBar.Name = "downloadingProgressBar";
            this.downloadingProgressBar.Size = new System.Drawing.Size(201, 23);
            this.downloadingProgressBar.TabIndex = 7;
            this.downloadingProgressBar.Visible = false;
            // 
            // downloadingLabel
            // 
            this.downloadingLabel.AutoSize = true;
            this.downloadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadingLabel.Location = new System.Drawing.Point(6, 100);
            this.downloadingLabel.Name = "downloadingLabel";
            this.downloadingLabel.Size = new System.Drawing.Size(86, 20);
            this.downloadingLabel.TabIndex = 6;
            this.downloadingLabel.Text = "Updating...";
            this.downloadingLabel.Visible = false;
            // 
            // rememberPasswordCheckBox
            // 
            this.rememberPasswordCheckBox.AutoSize = true;
            this.rememberPasswordCheckBox.Location = new System.Drawing.Point(6, 71);
            this.rememberPasswordCheckBox.Name = "rememberPasswordCheckBox";
            this.rememberPasswordCheckBox.Size = new System.Drawing.Size(126, 17);
            this.rememberPasswordCheckBox.TabIndex = 5;
            this.rememberPasswordCheckBox.Text = "Remember Password";
            this.rememberPasswordCheckBox.UseVisualStyleBackColor = true;
            // 
            // jarSelectorDropDown
            // 
            this.jarSelectorDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jarSelectorDropDown.FormattingEnabled = true;
            this.jarSelectorDropDown.Location = new System.Drawing.Point(177, 70);
            this.jarSelectorDropDown.Name = "jarSelectorDropDown";
            this.jarSelectorDropDown.Size = new System.Drawing.Size(201, 21);
            this.jarSelectorDropDown.TabIndex = 4;
            // 
            // loginFailedLabel
            // 
            this.loginFailedLabel.AutoSize = true;
            this.loginFailedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginFailedLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.loginFailedLabel.Location = new System.Drawing.Point(2, 99);
            this.loginFailedLabel.Name = "loginFailedLabel";
            this.loginFailedLabel.Size = new System.Drawing.Size(89, 17);
            this.loginFailedLabel.TabIndex = 3;
            this.loginFailedLabel.Text = "Login failed: ";
            this.loginFailedLabel.Visible = false;
            // 
            // logInButton
            // 
            this.logInButton.ForeColor = System.Drawing.Color.Black;
            this.logInButton.Location = new System.Drawing.Point(303, 97);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(75, 23);
            this.logInButton.TabIndex = 2;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(6, 45);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(372, 20);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(5, 19);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(373, 20);
            this.usernameTextBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.logInGroupBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 480);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::SuperLauncher.Properties.Resources.snow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.statusIcon);
            this.panel2.Controls.Add(this.serviceStatusLabel);
            this.panel2.Location = new System.Drawing.Point(7, 447);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 30);
            this.panel2.TabIndex = 8;
            // 
            // statusIcon
            // 
            this.statusIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusIcon.Image = global::SuperLauncher.Properties.Resources.red;
            this.statusIcon.Location = new System.Drawing.Point(3, 5);
            this.statusIcon.Name = "statusIcon";
            this.statusIcon.Size = new System.Drawing.Size(16, 17);
            this.statusIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.statusIcon.TabIndex = 7;
            this.statusIcon.TabStop = false;
            // 
            // serviceStatusLabel
            // 
            this.serviceStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.serviceStatusLabel.AutoSize = true;
            this.serviceStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceStatusLabel.Location = new System.Drawing.Point(16, 3);
            this.serviceStatusLabel.Name = "serviceStatusLabel";
            this.serviceStatusLabel.Size = new System.Drawing.Size(148, 20);
            this.serviceStatusLabel.TabIndex = 6;
            this.serviceStatusLabel.Text = "Checking services...";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "SuperLauncher";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::SuperLauncher.Properties.Resources.commandBlock;
            this.pictureBox1.Location = new System.Drawing.Point(7, 370);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.newsTab);
            this.tabControl1.Controls.Add(this.mapsTab);
            this.tabControl1.Controls.Add(this.serversTab);
            this.tabControl1.Controls.Add(this.texturePacksTab);
            this.tabControl1.Controls.Add(this.modsTab);
            this.tabControl1.Controls.Add(this.skinsTab);
            this.tabControl1.Controls.Add(this.settingsTab);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(826, 342);
            this.tabControl1.TabIndex = 3;
            // 
            // newsTab
            // 
            this.newsTab.Controls.Add(this.newsWebBrowser);
            this.newsTab.Location = new System.Drawing.Point(4, 22);
            this.newsTab.Name = "newsTab";
            this.newsTab.Padding = new System.Windows.Forms.Padding(3);
            this.newsTab.Size = new System.Drawing.Size(818, 316);
            this.newsTab.TabIndex = 0;
            this.newsTab.Text = "Minecraft News";
            this.newsTab.UseVisualStyleBackColor = true;
            // 
            // newsWebBrowser
            // 
            this.newsWebBrowser.AllowNewWindows = false;
            this.newsWebBrowser.BackColor = System.Drawing.Color.White;
            this.newsWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newsWebBrowser.IsWebBrowserContextMenuEnabled = false;
            this.newsWebBrowser.Location = new System.Drawing.Point(3, 3);
            this.newsWebBrowser.Name = "newsWebBrowser";
            this.newsWebBrowser.Size = new System.Drawing.Size(812, 310);
            this.newsWebBrowser.TabIndex = 0;
            this.newsWebBrowser.Url = null;
            // 
            // mapsTab
            // 
            this.mapsTab.Controls.Add(this.mapsWebBrowser);
            this.mapsTab.Location = new System.Drawing.Point(4, 22);
            this.mapsTab.Name = "mapsTab";
            this.mapsTab.Padding = new System.Windows.Forms.Padding(3);
            this.mapsTab.Size = new System.Drawing.Size(818, 316);
            this.mapsTab.TabIndex = 1;
            this.mapsTab.Text = "Maps";
            this.mapsTab.UseVisualStyleBackColor = true;
            // 
            // mapsWebBrowser
            // 
            this.mapsWebBrowser.AllowDownloads = false;
            this.mapsWebBrowser.AllowNewWindows = false;
            this.mapsWebBrowser.BackColor = System.Drawing.Color.White;
            this.mapsWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapsWebBrowser.Location = new System.Drawing.Point(3, 3);
            this.mapsWebBrowser.Name = "mapsWebBrowser";
            this.mapsWebBrowser.Size = new System.Drawing.Size(812, 310);
            this.mapsWebBrowser.TabIndex = 0;
            this.mapsWebBrowser.Url = null;
            // 
            // serversTab
            // 
            this.serversTab.Controls.Add(this.serverWebBrowser);
            this.serversTab.Location = new System.Drawing.Point(4, 22);
            this.serversTab.Name = "serversTab";
            this.serversTab.Size = new System.Drawing.Size(818, 316);
            this.serversTab.TabIndex = 2;
            this.serversTab.Text = "Servers";
            this.serversTab.UseVisualStyleBackColor = true;
            // 
            // serverWebBrowser
            // 
            this.serverWebBrowser.AllowDownloads = false;
            this.serverWebBrowser.AllowNewWindows = false;
            this.serverWebBrowser.BackColor = System.Drawing.Color.White;
            this.serverWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverWebBrowser.IsWebBrowserContextMenuEnabled = false;
            this.serverWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.serverWebBrowser.Name = "serverWebBrowser";
            this.serverWebBrowser.Size = new System.Drawing.Size(818, 316);
            this.serverWebBrowser.TabIndex = 0;
            this.serverWebBrowser.Url = null;
            // 
            // texturePacksTab
            // 
            this.texturePacksTab.Controls.Add(this.texturePackWebBrowser);
            this.texturePacksTab.Location = new System.Drawing.Point(4, 22);
            this.texturePacksTab.Name = "texturePacksTab";
            this.texturePacksTab.Size = new System.Drawing.Size(818, 316);
            this.texturePacksTab.TabIndex = 3;
            this.texturePacksTab.Text = "Texture Packs";
            this.texturePacksTab.UseVisualStyleBackColor = true;
            // 
            // texturePackWebBrowser
            // 
            this.texturePackWebBrowser.AllowDownloads = false;
            this.texturePackWebBrowser.AllowNewWindows = false;
            this.texturePackWebBrowser.BackColor = System.Drawing.Color.White;
            this.texturePackWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.texturePackWebBrowser.IsWebBrowserContextMenuEnabled = false;
            this.texturePackWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.texturePackWebBrowser.Name = "texturePackWebBrowser";
            this.texturePackWebBrowser.Size = new System.Drawing.Size(818, 316);
            this.texturePackWebBrowser.TabIndex = 0;
            this.texturePackWebBrowser.Url = null;
            // 
            // modsTab
            // 
            this.modsTab.Controls.Add(this.modWebBrowser);
            this.modsTab.Location = new System.Drawing.Point(4, 22);
            this.modsTab.Name = "modsTab";
            this.modsTab.Padding = new System.Windows.Forms.Padding(3);
            this.modsTab.Size = new System.Drawing.Size(818, 316);
            this.modsTab.TabIndex = 4;
            this.modsTab.Text = "Mods";
            this.modsTab.UseVisualStyleBackColor = true;
            // 
            // modWebBrowser
            // 
            this.modWebBrowser.AllowDownloads = false;
            this.modWebBrowser.AllowNewWindows = false;
            this.modWebBrowser.BackColor = System.Drawing.Color.White;
            this.modWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modWebBrowser.IsWebBrowserContextMenuEnabled = false;
            this.modWebBrowser.Location = new System.Drawing.Point(3, 3);
            this.modWebBrowser.Name = "modWebBrowser";
            this.modWebBrowser.Size = new System.Drawing.Size(812, 310);
            this.modWebBrowser.TabIndex = 0;
            this.modWebBrowser.Url = null;
            // 
            // skinsTab
            // 
            this.skinsTab.Controls.Add(this.skinWebBrowser);
            this.skinsTab.Location = new System.Drawing.Point(4, 22);
            this.skinsTab.Name = "skinsTab";
            this.skinsTab.Padding = new System.Windows.Forms.Padding(3);
            this.skinsTab.Size = new System.Drawing.Size(818, 316);
            this.skinsTab.TabIndex = 6;
            this.skinsTab.Text = "Skins";
            this.skinsTab.UseVisualStyleBackColor = true;
            // 
            // skinWebBrowser
            // 
            this.skinWebBrowser.AllowDownloads = false;
            this.skinWebBrowser.AllowNewWindows = false;
            this.skinWebBrowser.BackColor = System.Drawing.Color.White;
            this.skinWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinWebBrowser.IsWebBrowserContextMenuEnabled = false;
            this.skinWebBrowser.Location = new System.Drawing.Point(3, 3);
            this.skinWebBrowser.Name = "skinWebBrowser";
            this.skinWebBrowser.Size = new System.Drawing.Size(812, 310);
            this.skinWebBrowser.TabIndex = 0;
            this.skinWebBrowser.Url = null;
            // 
            // settingsTab
            // 
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(818, 316);
            this.settingsTab.TabIndex = 5;
            this.settingsTab.Text = "Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 504);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Launcher";
            this.Text = "Minecraft";
            this.logInGroupBox.ResumeLayout(false);
            this.logInGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.newsTab.ResumeLayout(false);
            this.mapsTab.ResumeLayout(false);
            this.serversTab.ResumeLayout(false);
            this.texturePacksTab.ResumeLayout(false);
            this.modsTab.ResumeLayout(false);
            this.skinsTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox logInGroupBox;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label loginFailedLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage newsTab;
        private System.Windows.Forms.TabPage mapsTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage serversTab;
        private System.Windows.Forms.TabPage texturePacksTab;
        private System.Windows.Forms.TabPage modsTab;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.Label serviceStatusLabel;
        private System.Windows.Forms.PictureBox statusIcon;
        private System.Windows.Forms.TabPage skinsTab;
        private System.Windows.Forms.CheckBox rememberPasswordCheckBox;
        private System.Windows.Forms.ComboBox jarSelectorDropDown;
        private System.Windows.Forms.Label downloadingLabel;
        private System.Windows.Forms.ProgressBar downloadingProgressBar;
        private WebKit.WebKitBrowser mapsWebBrowser;
        private WebKit.WebKitBrowser newsWebBrowser;
        private System.Windows.Forms.Panel panel2;
        private WebKit.WebKitBrowser serverWebBrowser;
        private WebKit.WebKitBrowser texturePackWebBrowser;
        private WebKit.WebKitBrowser modWebBrowser;
        private WebKit.WebKitBrowser skinWebBrowser;
    }
}

