namespace  SecureFtpClient.UserControls
{
    partial class ucLogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucLogin));
            this.mpLogin = new MetroFramework.Controls.MetroPanel();
            this.mlLoginTitle = new MetroFramework.Controls.MetroLink();
            this.mbLogin = new MetroFramework.Controls.MetroButton();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.mlExit = new MetroFramework.Controls.MetroLink();
            this.mlSettings = new MetroFramework.Controls.MetroLink();
            this.mpSettings = new MetroFramework.Controls.MetroPanel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.mtpConection = new MetroFramework.Controls.MetroTabPage();
            this.txtServerPassword = new MetroFramework.Controls.MetroTextBox();
            this.mlPassword = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtServerUser = new MetroFramework.Controls.MetroTextBox();
            this.mlUser = new MetroFramework.Controls.MetroLabel();
            this.txtPort = new MetroFramework.Controls.MetroTextBox();
            this.mlPort = new MetroFramework.Controls.MetroLabel();
            this.txtServerName = new MetroFramework.Controls.MetroTextBox();
            this.mlServer = new MetroFramework.Controls.MetroLabel();
            this.mlBackSettings = new MetroFramework.Controls.MetroLink();
            this.mpLogin.SuspendLayout();
            this.mpSettings.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.mtpConection.SuspendLayout();
            this.SuspendLayout();
            // 
            // mpLogin
            // 
            this.mpLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mpLogin.Controls.Add(this.mlExit);
            this.mpLogin.Controls.Add(this.mlLoginTitle);
            this.mpLogin.Controls.Add(this.mlSettings);
            this.mpLogin.Controls.Add(this.mbLogin);
            this.mpLogin.Controls.Add(this.txtPassword);
            this.mpLogin.Controls.Add(this.txtUsername);
            this.mpLogin.HorizontalScrollbarBarColor = true;
            this.mpLogin.HorizontalScrollbarHighlightOnWheel = false;
            this.mpLogin.HorizontalScrollbarSize = 8;
            this.mpLogin.Location = new System.Drawing.Point(2, 162);
            this.mpLogin.Margin = new System.Windows.Forms.Padding(2);
            this.mpLogin.Name = "mpLogin";
            this.mpLogin.Size = new System.Drawing.Size(861, 321);
            this.mpLogin.TabIndex = 2;
            this.mpLogin.VerticalScrollbarBarColor = true;
            this.mpLogin.VerticalScrollbarHighlightOnWheel = false;
            this.mpLogin.VerticalScrollbarSize = 8;
            // 
            // mlLoginTitle
            // 
            this.mlLoginTitle.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.mlLoginTitle.Image = ((System.Drawing.Image)(resources.GetObject("mlLoginTitle.Image")));
            this.mlLoginTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mlLoginTitle.ImageSize = 64;
            this.mlLoginTitle.Location = new System.Drawing.Point(267, 24);
            this.mlLoginTitle.Margin = new System.Windows.Forms.Padding(2);
            this.mlLoginTitle.Name = "mlLoginTitle";
            this.mlLoginTitle.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("mlLoginTitle.NoFocusImage")));
            this.mlLoginTitle.Size = new System.Drawing.Size(211, 54);
            this.mlLoginTitle.TabIndex = 7;
            this.mlLoginTitle.Text = "      Login";
            this.mlLoginTitle.UseSelectable = true;
            // 
            // mbLogin
            // 
            this.mbLogin.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mbLogin.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.mbLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mbLogin.Highlight = true;
            this.mbLogin.Location = new System.Drawing.Point(389, 153);
            this.mbLogin.Margin = new System.Windows.Forms.Padding(2);
            this.mbLogin.Name = "mbLogin";
            this.mbLogin.Size = new System.Drawing.Size(89, 26);
            this.mbLogin.TabIndex = 6;
            this.mbLogin.Text = "&Entrar";
            this.mbLogin.UseSelectable = true;
            this.mbLogin.Click += new System.EventHandler(this.mbLogin_Click);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(183, 2);
            this.txtPassword.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.Icon = ((System.Drawing.Image)(resources.GetObject("txtPassword.Icon")));
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(267, 119);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PromptText = "Password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(211, 30);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.CustomButton.Image = null;
            this.txtUsername.CustomButton.Location = new System.Drawing.Point(183, 2);
            this.txtUsername.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.CustomButton.Name = "";
            this.txtUsername.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.CustomButton.TabIndex = 1;
            this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsername.CustomButton.UseSelectable = true;
            this.txtUsername.CustomButton.Visible = false;
            this.txtUsername.DisplayIcon = true;
            this.txtUsername.Icon = ((System.Drawing.Image)(resources.GetObject("txtUsername.Icon")));
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(267, 84);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PromptText = "Usuario";
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(211, 30);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.WaterMark = "Usuario";
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlExit
            // 
            this.mlExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mlExit.Image = ((System.Drawing.Image)(resources.GetObject("mlExit.Image")));
            this.mlExit.ImageSize = 32;
            this.mlExit.Location = new System.Drawing.Point(802, 3);
            this.mlExit.Name = "mlExit";
            this.mlExit.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("mlExit.NoFocusImage")));
            this.mlExit.Size = new System.Drawing.Size(28, 28);
            this.mlExit.TabIndex = 0;
            this.mlExit.UseSelectable = true;
            // 
            // mlSettings
            // 
            this.mlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mlSettings.Image = ((System.Drawing.Image)(resources.GetObject("mlSettings.Image")));
            this.mlSettings.ImageSize = 32;
            this.mlSettings.Location = new System.Drawing.Point(830, 3);
            this.mlSettings.Name = "mlSettings";
            this.mlSettings.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("mlSettings.NoFocusImage")));
            this.mlSettings.Size = new System.Drawing.Size(28, 28);
            this.mlSettings.TabIndex = 1;
            this.mlSettings.UseSelectable = true;
            this.mlSettings.Click += new System.EventHandler(this.mlSettings_Click);
            // 
            // mpSettings
            // 
            this.mpSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpSettings.Controls.Add(this.metroTabControl1);
            this.mpSettings.Controls.Add(this.mlBackSettings);
            this.mpSettings.HorizontalScrollbarBarColor = true;
            this.mpSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.mpSettings.HorizontalScrollbarSize = 8;
            this.mpSettings.Location = new System.Drawing.Point(629, 0);
            this.mpSettings.Margin = new System.Windows.Forms.Padding(2);
            this.mpSettings.Name = "mpSettings";
            this.mpSettings.Size = new System.Drawing.Size(232, 610);
            this.mpSettings.TabIndex = 3;
            this.mpSettings.VerticalScrollbarBarColor = true;
            this.mpSettings.VerticalScrollbarHighlightOnWheel = false;
            this.mpSettings.VerticalScrollbarSize = 8;
            this.mpSettings.Visible = false;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.mtpConection);
            this.metroTabControl1.Location = new System.Drawing.Point(2, 54);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(227, 386);
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.UseSelectable = true;
            // 
            // mtpConection
            // 
            this.mtpConection.Controls.Add(this.txtServerPassword);
            this.mtpConection.Controls.Add(this.mlPassword);
            this.mtpConection.Controls.Add(this.metroButton1);
            this.mtpConection.Controls.Add(this.txtServerUser);
            this.mtpConection.Controls.Add(this.mlUser);
            this.mtpConection.Controls.Add(this.txtPort);
            this.mtpConection.Controls.Add(this.mlPort);
            this.mtpConection.Controls.Add(this.txtServerName);
            this.mtpConection.Controls.Add(this.mlServer);
            this.mtpConection.HorizontalScrollbarBarColor = true;
            this.mtpConection.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpConection.HorizontalScrollbarSize = 8;
            this.mtpConection.Location = new System.Drawing.Point(4, 38);
            this.mtpConection.Margin = new System.Windows.Forms.Padding(2);
            this.mtpConection.Name = "mtpConection";
            this.mtpConection.Size = new System.Drawing.Size(219, 344);
            this.mtpConection.TabIndex = 0;
            this.mtpConection.Text = "&Conexión";
            this.mtpConection.VerticalScrollbarBarColor = true;
            this.mtpConection.VerticalScrollbarHighlightOnWheel = false;
            this.mtpConection.VerticalScrollbarSize = 8;
            // 
            // txtServerPassword
            // 
            // 
            // 
            // 
            this.txtServerPassword.CustomButton.Image = null;
            this.txtServerPassword.CustomButton.Location = new System.Drawing.Point(134, 2);
            this.txtServerPassword.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtServerPassword.CustomButton.Name = "";
            this.txtServerPassword.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtServerPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServerPassword.CustomButton.TabIndex = 1;
            this.txtServerPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtServerPassword.CustomButton.UseSelectable = true;
            this.txtServerPassword.CustomButton.Visible = false;
            this.txtServerPassword.Lines = new string[] {
        "******"};
            this.txtServerPassword.Location = new System.Drawing.Point(23, 181);
            this.txtServerPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtServerPassword.MaxLength = 32767;
            this.txtServerPassword.Name = "txtServerPassword";
            this.txtServerPassword.PasswordChar = '*';
            this.txtServerPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServerPassword.SelectedText = "";
            this.txtServerPassword.SelectionLength = 0;
            this.txtServerPassword.SelectionStart = 0;
            this.txtServerPassword.ShortcutsEnabled = true;
            this.txtServerPassword.Size = new System.Drawing.Size(152, 20);
            this.txtServerPassword.TabIndex = 9;
            this.txtServerPassword.Text = "******";
            this.txtServerPassword.UseSelectable = true;
            this.txtServerPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtServerPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlPassword
            // 
            this.mlPassword.AutoSize = true;
            this.mlPassword.Location = new System.Drawing.Point(23, 162);
            this.mlPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlPassword.Name = "mlPassword";
            this.mlPassword.Size = new System.Drawing.Size(66, 19);
            this.mlPassword.TabIndex = 8;
            this.mlPassword.Text = "Password:";
            // 
            // metroButton1
            // 
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton1.Location = new System.Drawing.Point(23, 215);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(152, 23);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "&probar conexión";
            this.metroButton1.UseSelectable = true;
            // 
            // txtServerUser
            // 
            // 
            // 
            // 
            this.txtServerUser.CustomButton.Image = null;
            this.txtServerUser.CustomButton.Location = new System.Drawing.Point(134, 2);
            this.txtServerUser.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtServerUser.CustomButton.Name = "";
            this.txtServerUser.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtServerUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServerUser.CustomButton.TabIndex = 1;
            this.txtServerUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtServerUser.CustomButton.UseSelectable = true;
            this.txtServerUser.CustomButton.Visible = false;
            this.txtServerUser.Lines = new string[] {
        "admin"};
            this.txtServerUser.Location = new System.Drawing.Point(23, 134);
            this.txtServerUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtServerUser.MaxLength = 32767;
            this.txtServerUser.Name = "txtServerUser";
            this.txtServerUser.PasswordChar = '\0';
            this.txtServerUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServerUser.SelectedText = "";
            this.txtServerUser.SelectionLength = 0;
            this.txtServerUser.SelectionStart = 0;
            this.txtServerUser.ShortcutsEnabled = true;
            this.txtServerUser.Size = new System.Drawing.Size(152, 20);
            this.txtServerUser.TabIndex = 7;
            this.txtServerUser.Text = "admin";
            this.txtServerUser.UseSelectable = true;
            this.txtServerUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtServerUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlUser
            // 
            this.mlUser.AutoSize = true;
            this.mlUser.Location = new System.Drawing.Point(23, 115);
            this.mlUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlUser.Name = "mlUser";
            this.mlUser.Size = new System.Drawing.Size(56, 19);
            this.mlUser.TabIndex = 6;
            this.mlUser.Text = "Usuario:";
            // 
            // txtPort
            // 
            // 
            // 
            // 
            this.txtPort.CustomButton.Image = null;
            this.txtPort.CustomButton.Location = new System.Drawing.Point(134, 2);
            this.txtPort.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtPort.CustomButton.Name = "";
            this.txtPort.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPort.CustomButton.TabIndex = 1;
            this.txtPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPort.CustomButton.UseSelectable = true;
            this.txtPort.CustomButton.Visible = false;
            this.txtPort.Lines = new string[] {
        "0000"};
            this.txtPort.Location = new System.Drawing.Point(23, 87);
            this.txtPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtPort.MaxLength = 32767;
            this.txtPort.Name = "txtPort";
            this.txtPort.PasswordChar = '\0';
            this.txtPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPort.SelectedText = "";
            this.txtPort.SelectionLength = 0;
            this.txtPort.SelectionStart = 0;
            this.txtPort.ShortcutsEnabled = true;
            this.txtPort.Size = new System.Drawing.Size(152, 20);
            this.txtPort.TabIndex = 5;
            this.txtPort.Text = "0000";
            this.txtPort.UseSelectable = true;
            this.txtPort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlPort
            // 
            this.mlPort.AutoSize = true;
            this.mlPort.Location = new System.Drawing.Point(23, 68);
            this.mlPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlPort.Name = "mlPort";
            this.mlPort.Size = new System.Drawing.Size(52, 19);
            this.mlPort.TabIndex = 4;
            this.mlPort.Text = "Puerto:";
            // 
            // txtServerName
            // 
            // 
            // 
            // 
            this.txtServerName.CustomButton.Image = null;
            this.txtServerName.CustomButton.Location = new System.Drawing.Point(134, 2);
            this.txtServerName.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtServerName.CustomButton.Name = "";
            this.txtServerName.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtServerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServerName.CustomButton.TabIndex = 1;
            this.txtServerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtServerName.CustomButton.UseSelectable = true;
            this.txtServerName.CustomButton.Visible = false;
            this.txtServerName.Lines = new string[] {
        "192.168.1.194"};
            this.txtServerName.Location = new System.Drawing.Point(23, 39);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtServerName.MaxLength = 32767;
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.PasswordChar = '\0';
            this.txtServerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServerName.SelectedText = "";
            this.txtServerName.SelectionLength = 0;
            this.txtServerName.SelectionStart = 0;
            this.txtServerName.ShortcutsEnabled = true;
            this.txtServerName.Size = new System.Drawing.Size(152, 20);
            this.txtServerName.TabIndex = 3;
            this.txtServerName.Text = "192.168.1.194";
            this.txtServerName.UseSelectable = true;
            this.txtServerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtServerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlServer
            // 
            this.mlServer.AutoSize = true;
            this.mlServer.Location = new System.Drawing.Point(23, 20);
            this.mlServer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlServer.Name = "mlServer";
            this.mlServer.Size = new System.Drawing.Size(63, 19);
            this.mlServer.TabIndex = 2;
            this.mlServer.Text = "Servidor:";
            // 
            // mlBackSettings
            // 
            this.mlBackSettings.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.mlBackSettings.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.mlBackSettings.Image = ((System.Drawing.Image)(resources.GetObject("mlBackSettings.Image")));
            this.mlBackSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mlBackSettings.ImageSize = 32;
            this.mlBackSettings.Location = new System.Drawing.Point(2, 3);
            this.mlBackSettings.Margin = new System.Windows.Forms.Padding(2);
            this.mlBackSettings.Name = "mlBackSettings";
            this.mlBackSettings.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("mlBackSettings.NoFocusImage")));
            this.mlBackSettings.Size = new System.Drawing.Size(207, 37);
            this.mlBackSettings.TabIndex = 2;
            this.mlBackSettings.Text = "&Configuraciones";
            this.mlBackSettings.UseSelectable = true;
            this.mlBackSettings.Click += new System.EventHandler(this.mlBackSettings_Click);
            // 
            // ucLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mpLogin);
            this.Controls.Add(this.mpSettings);
            this.Name = "ucLogin";
            this.Size = new System.Drawing.Size(861, 610);
            this.mpLogin.ResumeLayout(false);
            this.mpSettings.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.mtpConection.ResumeLayout(false);
            this.mtpConection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink mlExit;
        private MetroFramework.Controls.MetroLink mlSettings;
        private MetroFramework.Controls.MetroPanel mpLogin;
        private MetroFramework.Controls.MetroPanel mpSettings;
        private MetroFramework.Controls.MetroLink mlBackSettings;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage mtpConection;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroButton mbLogin;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtServerName;
        private MetroFramework.Controls.MetroLabel mlServer;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txtServerPassword;
        private MetroFramework.Controls.MetroLabel mlPassword;
        private MetroFramework.Controls.MetroTextBox txtServerUser;
        private MetroFramework.Controls.MetroLabel mlUser;
        private MetroFramework.Controls.MetroTextBox txtPort;
        private MetroFramework.Controls.MetroLabel mlPort;
        private MetroFramework.Controls.MetroLink mlLoginTitle;
    }
}
