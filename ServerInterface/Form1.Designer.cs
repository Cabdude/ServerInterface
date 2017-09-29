namespace ServerInterface
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.UsernameField = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginScreen = new System.Windows.Forms.GroupBox();
            this.LoginErrLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ServerMenuStrip = new System.Windows.Forms.MenuStrip();
            this.serverSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServerSettingsScreen = new System.Windows.Forms.GroupBox();
            this.PortErrLabel = new System.Windows.Forms.Label();
            this.ServerPortField = new System.Windows.Forms.TextBox();
            this.SetServerPortLabel = new System.Windows.Forms.Label();
            this.ServerPortLabel2 = new System.Windows.Forms.Label();
            this.ServerPortLabel = new System.Windows.Forms.Label();
            this.InvalidIPLabel = new System.Windows.Forms.Label();
            this.SetServerIPLabel = new System.Windows.Forms.Label();
            this.SetServerIPButton = new System.Windows.Forms.Button();
            this.ServerIPLabel2 = new System.Windows.Forms.Label();
            this.ServerIPHostLabel = new System.Windows.Forms.Label();
            this.ServerSetupLabel = new System.Windows.Forms.Label();
            this.ServerHostIPField = new System.Windows.Forms.MaskedTextBox();
            this.ServerHostIPToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.DatabaseSettingsScreen = new System.Windows.Forms.GroupBox();
            this.CreateCentralDatabaseButton = new System.Windows.Forms.Button();
            this.DatabaseViewLabel = new System.Windows.Forms.Label();
            this.DatabaseTreeView = new System.Windows.Forms.TreeView();
            this.CreateCentralFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.DatabaseCentralWarningLabel = new System.Windows.Forms.Label();
            this.DatabaseCentralWarningLabel2 = new System.Windows.Forms.Label();
            this.CreateSubFolderButton = new System.Windows.Forms.Button();
            this.SubFolderPanel = new System.Windows.Forms.GroupBox();
            this.SubFolderNameLabel = new System.Windows.Forms.Label();
            this.SubFolderNameField = new System.Windows.Forms.TextBox();
            this.FolderSubPickLabel = new System.Windows.Forms.Label();
            this.ParentFoldersComboBox = new System.Windows.Forms.ComboBox();
            this.SetSubFolderButton = new System.Windows.Forms.Button();
            this.SubFolderCloseButton = new System.Windows.Forms.Button();
            this.LoginScreen.SuspendLayout();
            this.ServerMenuStrip.SuspendLayout();
            this.ServerSettingsScreen.SuspendLayout();
            this.DatabaseSettingsScreen.SuspendLayout();
            this.SubFolderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PasswordField
            // 
            this.PasswordField.Location = new System.Drawing.Point(80, 75);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(175, 20);
            this.PasswordField.TabIndex = 0;
            this.PasswordField.UseSystemPasswordChar = true;
            // 
            // UsernameField
            // 
            this.UsernameField.Location = new System.Drawing.Point(80, 19);
            this.UsernameField.Name = "UsernameField";
            this.UsernameField.Size = new System.Drawing.Size(175, 20);
            this.UsernameField.TabIndex = 0;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(9, 22);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(67, 13);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(9, 78);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(65, 13);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password:";
            // 
            // LoginScreen
            // 
            this.LoginScreen.Controls.Add(this.LoginErrLabel);
            this.LoginScreen.Controls.Add(this.LoginButton);
            this.LoginScreen.Controls.Add(this.UsernameField);
            this.LoginScreen.Controls.Add(this.PasswordLabel);
            this.LoginScreen.Controls.Add(this.PasswordField);
            this.LoginScreen.Controls.Add(this.UsernameLabel);
            this.LoginScreen.Location = new System.Drawing.Point(259, 197);
            this.LoginScreen.Name = "LoginScreen";
            this.LoginScreen.Size = new System.Drawing.Size(302, 148);
            this.LoginScreen.TabIndex = 2;
            this.LoginScreen.TabStop = false;
            this.LoginScreen.Text = "Login";
            // 
            // LoginErrLabel
            // 
            this.LoginErrLabel.AutoSize = true;
            this.LoginErrLabel.ForeColor = System.Drawing.Color.Red;
            this.LoginErrLabel.Location = new System.Drawing.Point(12, 115);
            this.LoginErrLabel.Name = "LoginErrLabel";
            this.LoginErrLabel.Size = new System.Drawing.Size(140, 13);
            this.LoginErrLabel.TabIndex = 3;
            this.LoginErrLabel.Text = "Invalid Username/Password";
            this.LoginErrLabel.Visible = false;
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(180, 115);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ServerMenuStrip
            // 
            this.ServerMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverSettingsToolStripMenuItem,
            this.databaseSettingsToolStripMenuItem});
            this.ServerMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ServerMenuStrip.Name = "ServerMenuStrip";
            this.ServerMenuStrip.Size = new System.Drawing.Size(884, 24);
            this.ServerMenuStrip.TabIndex = 3;
            this.ServerMenuStrip.Text = "MenuStrip";
            this.ServerMenuStrip.Visible = false;
            // 
            // serverSettingsToolStripMenuItem
            // 
            this.serverSettingsToolStripMenuItem.Name = "serverSettingsToolStripMenuItem";
            this.serverSettingsToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.serverSettingsToolStripMenuItem.Text = "Server Settings";
            this.serverSettingsToolStripMenuItem.Click += new System.EventHandler(this.serverSettingsToolStripMenuItem_Click);
            // 
            // databaseSettingsToolStripMenuItem
            // 
            this.databaseSettingsToolStripMenuItem.Name = "databaseSettingsToolStripMenuItem";
            this.databaseSettingsToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.databaseSettingsToolStripMenuItem.Text = "Database Settings";
            this.databaseSettingsToolStripMenuItem.Click += new System.EventHandler(this.databaseSettingsToolStripMenuItem_Click);
            // 
            // ServerSettingsScreen
            // 
            this.ServerSettingsScreen.Controls.Add(this.PortErrLabel);
            this.ServerSettingsScreen.Controls.Add(this.ServerPortField);
            this.ServerSettingsScreen.Controls.Add(this.SetServerPortLabel);
            this.ServerSettingsScreen.Controls.Add(this.ServerPortLabel2);
            this.ServerSettingsScreen.Controls.Add(this.ServerPortLabel);
            this.ServerSettingsScreen.Controls.Add(this.InvalidIPLabel);
            this.ServerSettingsScreen.Controls.Add(this.SetServerIPLabel);
            this.ServerSettingsScreen.Controls.Add(this.SetServerIPButton);
            this.ServerSettingsScreen.Controls.Add(this.ServerIPLabel2);
            this.ServerSettingsScreen.Controls.Add(this.ServerIPHostLabel);
            this.ServerSettingsScreen.Controls.Add(this.ServerSetupLabel);
            this.ServerSettingsScreen.Controls.Add(this.ServerHostIPField);
            this.ServerSettingsScreen.Location = new System.Drawing.Point(37, 32);
            this.ServerSettingsScreen.Name = "ServerSettingsScreen";
            this.ServerSettingsScreen.Size = new System.Drawing.Size(802, 472);
            this.ServerSettingsScreen.TabIndex = 4;
            this.ServerSettingsScreen.TabStop = false;
            this.ServerSettingsScreen.Text = "Server Settings";
            this.ServerSettingsScreen.Visible = false;
            // 
            // PortErrLabel
            // 
            this.PortErrLabel.AutoSize = true;
            this.PortErrLabel.ForeColor = System.Drawing.Color.Red;
            this.PortErrLabel.Location = new System.Drawing.Point(562, 188);
            this.PortErrLabel.Name = "PortErrLabel";
            this.PortErrLabel.Size = new System.Drawing.Size(239, 13);
            this.PortErrLabel.TabIndex = 9;
            this.PortErrLabel.Text = "Invalid Port (Only numbers(0-9) Ranges: 0-65535)";
            this.PortErrLabel.Visible = false;
            // 
            // ServerPortField
            // 
            this.ServerPortField.Location = new System.Drawing.Point(563, 161);
            this.ServerPortField.Name = "ServerPortField";
            this.ServerPortField.Size = new System.Drawing.Size(186, 20);
            this.ServerPortField.TabIndex = 8;
            this.ServerPortField.Text = "1337";
            // 
            // SetServerPortLabel
            // 
            this.SetServerPortLabel.AutoSize = true;
            this.SetServerPortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetServerPortLabel.Location = new System.Drawing.Point(31, 188);
            this.SetServerPortLabel.Name = "SetServerPortLabel";
            this.SetServerPortLabel.Size = new System.Drawing.Size(0, 25);
            this.SetServerPortLabel.TabIndex = 7;
            // 
            // ServerPortLabel2
            // 
            this.ServerPortLabel2.AutoSize = true;
            this.ServerPortLabel2.Location = new System.Drawing.Point(28, 164);
            this.ServerPortLabel2.Name = "ServerPortLabel2";
            this.ServerPortLabel2.Size = new System.Drawing.Size(63, 13);
            this.ServerPortLabel2.TabIndex = 7;
            this.ServerPortLabel2.Text = "Server Port:";
            // 
            // ServerPortLabel
            // 
            this.ServerPortLabel.AutoSize = true;
            this.ServerPortLabel.Location = new System.Drawing.Point(497, 165);
            this.ServerPortLabel.Name = "ServerPortLabel";
            this.ServerPortLabel.Size = new System.Drawing.Size(63, 13);
            this.ServerPortLabel.TabIndex = 7;
            this.ServerPortLabel.Text = "Server Port:";
            // 
            // InvalidIPLabel
            // 
            this.InvalidIPLabel.AutoSize = true;
            this.InvalidIPLabel.ForeColor = System.Drawing.Color.Red;
            this.InvalidIPLabel.Location = new System.Drawing.Point(560, 117);
            this.InvalidIPLabel.Name = "InvalidIPLabel";
            this.InvalidIPLabel.Size = new System.Drawing.Size(92, 13);
            this.InvalidIPLabel.TabIndex = 6;
            this.InvalidIPLabel.Text = "Invalid IP Address";
            this.InvalidIPLabel.Visible = false;
            // 
            // SetServerIPLabel
            // 
            this.SetServerIPLabel.AutoSize = true;
            this.SetServerIPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetServerIPLabel.Location = new System.Drawing.Point(31, 121);
            this.SetServerIPLabel.Name = "SetServerIPLabel";
            this.SetServerIPLabel.Size = new System.Drawing.Size(0, 25);
            this.SetServerIPLabel.TabIndex = 5;
            // 
            // SetServerIPButton
            // 
            this.SetServerIPButton.Location = new System.Drawing.Point(673, 218);
            this.SetServerIPButton.Name = "SetServerIPButton";
            this.SetServerIPButton.Size = new System.Drawing.Size(75, 23);
            this.SetServerIPButton.TabIndex = 4;
            this.SetServerIPButton.Text = "Save";
            this.SetServerIPButton.UseVisualStyleBackColor = true;
            this.SetServerIPButton.Click += new System.EventHandler(this.SetServerIPButton_Click);
            // 
            // ServerIPLabel2
            // 
            this.ServerIPLabel2.AutoSize = true;
            this.ServerIPLabel2.Location = new System.Drawing.Point(28, 88);
            this.ServerIPLabel2.Name = "ServerIPLabel2";
            this.ServerIPLabel2.Size = new System.Drawing.Size(54, 13);
            this.ServerIPLabel2.TabIndex = 3;
            this.ServerIPLabel2.Text = "Server IP:";
            // 
            // ServerIPHostLabel
            // 
            this.ServerIPHostLabel.AutoSize = true;
            this.ServerIPHostLabel.Location = new System.Drawing.Point(506, 88);
            this.ServerIPHostLabel.Name = "ServerIPHostLabel";
            this.ServerIPHostLabel.Size = new System.Drawing.Size(54, 13);
            this.ServerIPHostLabel.TabIndex = 3;
            this.ServerIPHostLabel.Text = "Server IP:";
            // 
            // ServerSetupLabel
            // 
            this.ServerSetupLabel.AutoSize = true;
            this.ServerSetupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerSetupLabel.Location = new System.Drawing.Point(563, 48);
            this.ServerSetupLabel.Name = "ServerSetupLabel";
            this.ServerSetupLabel.Size = new System.Drawing.Size(81, 13);
            this.ServerSetupLabel.TabIndex = 2;
            this.ServerSetupLabel.Text = "Server Setup";
            // 
            // ServerHostIPField
            // 
            this.ServerHostIPField.Location = new System.Drawing.Point(563, 85);
            this.ServerHostIPField.Name = "ServerHostIPField";
            this.ServerHostIPField.Size = new System.Drawing.Size(186, 20);
            this.ServerHostIPField.TabIndex = 1;
            this.ServerHostIPField.Text = "127.0.0.1";
            // 
            // DatabaseSettingsScreen
            // 
            this.DatabaseSettingsScreen.Controls.Add(this.SubFolderPanel);
            this.DatabaseSettingsScreen.Controls.Add(this.CreateSubFolderButton);
            this.DatabaseSettingsScreen.Controls.Add(this.DatabaseCentralWarningLabel2);
            this.DatabaseSettingsScreen.Controls.Add(this.DatabaseCentralWarningLabel);
            this.DatabaseSettingsScreen.Controls.Add(this.CreateCentralDatabaseButton);
            this.DatabaseSettingsScreen.Controls.Add(this.DatabaseViewLabel);
            this.DatabaseSettingsScreen.Controls.Add(this.DatabaseTreeView);
            this.DatabaseSettingsScreen.Location = new System.Drawing.Point(37, 32);
            this.DatabaseSettingsScreen.Name = "DatabaseSettingsScreen";
            this.DatabaseSettingsScreen.Size = new System.Drawing.Size(802, 472);
            this.DatabaseSettingsScreen.TabIndex = 5;
            this.DatabaseSettingsScreen.TabStop = false;
            this.DatabaseSettingsScreen.Text = "Database Settings";
            this.DatabaseSettingsScreen.Visible = false;
            // 
            // CreateCentralDatabaseButton
            // 
            this.CreateCentralDatabaseButton.Location = new System.Drawing.Point(311, 48);
            this.CreateCentralDatabaseButton.Name = "CreateCentralDatabaseButton";
            this.CreateCentralDatabaseButton.Size = new System.Drawing.Size(166, 23);
            this.CreateCentralDatabaseButton.TabIndex = 2;
            this.CreateCentralDatabaseButton.Text = "Create Central Database Folder";
            this.CreateCentralDatabaseButton.UseVisualStyleBackColor = true;
            this.CreateCentralDatabaseButton.Click += new System.EventHandler(this.CreateCentralDatabaseButton_Click);
            // 
            // DatabaseViewLabel
            // 
            this.DatabaseViewLabel.AutoSize = true;
            this.DatabaseViewLabel.Location = new System.Drawing.Point(6, 29);
            this.DatabaseViewLabel.Name = "DatabaseViewLabel";
            this.DatabaseViewLabel.Size = new System.Drawing.Size(110, 13);
            this.DatabaseViewLabel.TabIndex = 1;
            this.DatabaseViewLabel.Text = "Database Heigharchy";
            // 
            // DatabaseTreeView
            // 
            this.DatabaseTreeView.Location = new System.Drawing.Point(6, 48);
            this.DatabaseTreeView.Name = "DatabaseTreeView";
            this.DatabaseTreeView.Size = new System.Drawing.Size(299, 418);
            this.DatabaseTreeView.TabIndex = 0;
            // 
            // DatabaseCentralWarningLabel
            // 
            this.DatabaseCentralWarningLabel.AutoSize = true;
            this.DatabaseCentralWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.DatabaseCentralWarningLabel.Location = new System.Drawing.Point(308, 16);
            this.DatabaseCentralWarningLabel.Name = "DatabaseCentralWarningLabel";
            this.DatabaseCentralWarningLabel.Size = new System.Drawing.Size(319, 13);
            this.DatabaseCentralWarningLabel.TabIndex = 3;
            this.DatabaseCentralWarningLabel.Text = "WARNING: DATABASE CENTRAL FOLDER ALREADY EXISTS!";
            this.DatabaseCentralWarningLabel.Visible = false;
            // 
            // DatabaseCentralWarningLabel2
            // 
            this.DatabaseCentralWarningLabel2.AutoSize = true;
            this.DatabaseCentralWarningLabel2.ForeColor = System.Drawing.Color.Red;
            this.DatabaseCentralWarningLabel2.Location = new System.Drawing.Point(308, 29);
            this.DatabaseCentralWarningLabel2.Name = "DatabaseCentralWarningLabel2";
            this.DatabaseCentralWarningLabel2.Size = new System.Drawing.Size(207, 13);
            this.DatabaseCentralWarningLabel2.TabIndex = 3;
            this.DatabaseCentralWarningLabel2.Text = "CHANGING WILL RESET THE SERVER!";
            this.DatabaseCentralWarningLabel2.Visible = false;
            // 
            // CreateSubFolderButton
            // 
            this.CreateSubFolderButton.Location = new System.Drawing.Point(311, 88);
            this.CreateSubFolderButton.Name = "CreateSubFolderButton";
            this.CreateSubFolderButton.Size = new System.Drawing.Size(166, 23);
            this.CreateSubFolderButton.TabIndex = 4;
            this.CreateSubFolderButton.Text = "Create Sub-Folder";
            this.CreateSubFolderButton.UseVisualStyleBackColor = true;
            this.CreateSubFolderButton.Click += new System.EventHandler(this.CreateSubFolderButton_Click);
            // 
            // SubFolderPanel
            // 
            this.SubFolderPanel.Controls.Add(this.SubFolderCloseButton);
            this.SubFolderPanel.Controls.Add(this.SetSubFolderButton);
            this.SubFolderPanel.Controls.Add(this.ParentFoldersComboBox);
            this.SubFolderPanel.Controls.Add(this.FolderSubPickLabel);
            this.SubFolderPanel.Controls.Add(this.SubFolderNameField);
            this.SubFolderPanel.Controls.Add(this.SubFolderNameLabel);
            this.SubFolderPanel.Location = new System.Drawing.Point(311, 117);
            this.SubFolderPanel.Name = "SubFolderPanel";
            this.SubFolderPanel.Size = new System.Drawing.Size(394, 176);
            this.SubFolderPanel.TabIndex = 5;
            this.SubFolderPanel.TabStop = false;
            this.SubFolderPanel.Text = "Sub-Folder Creator";
            this.SubFolderPanel.Visible = false;
            // 
            // SubFolderNameLabel
            // 
            this.SubFolderNameLabel.AutoSize = true;
            this.SubFolderNameLabel.Location = new System.Drawing.Point(7, 29);
            this.SubFolderNameLabel.Name = "SubFolderNameLabel";
            this.SubFolderNameLabel.Size = new System.Drawing.Size(92, 13);
            this.SubFolderNameLabel.TabIndex = 0;
            this.SubFolderNameLabel.Text = "Sub-Folder Name:";
            // 
            // SubFolderNameField
            // 
            this.SubFolderNameField.Location = new System.Drawing.Point(132, 25);
            this.SubFolderNameField.Name = "SubFolderNameField";
            this.SubFolderNameField.Size = new System.Drawing.Size(173, 20);
            this.SubFolderNameField.TabIndex = 1;
            // 
            // FolderSubPickLabel
            // 
            this.FolderSubPickLabel.AutoSize = true;
            this.FolderSubPickLabel.Location = new System.Drawing.Point(7, 69);
            this.FolderSubPickLabel.Name = "FolderSubPickLabel";
            this.FolderSubPickLabel.Size = new System.Drawing.Size(106, 13);
            this.FolderSubPickLabel.TabIndex = 2;
            this.FolderSubPickLabel.Text = "Select Parent Folder:";
            // 
            // ParentFoldersComboBox
            // 
            this.ParentFoldersComboBox.FormattingEnabled = true;
            this.ParentFoldersComboBox.Location = new System.Drawing.Point(132, 64);
            this.ParentFoldersComboBox.Name = "ParentFoldersComboBox";
            this.ParentFoldersComboBox.Size = new System.Drawing.Size(173, 21);
            this.ParentFoldersComboBox.TabIndex = 3;
            // 
            // SetSubFolderButton
            // 
            this.SetSubFolderButton.Location = new System.Drawing.Point(229, 100);
            this.SetSubFolderButton.Name = "SetSubFolderButton";
            this.SetSubFolderButton.Size = new System.Drawing.Size(75, 23);
            this.SetSubFolderButton.TabIndex = 4;
            this.SetSubFolderButton.Text = "Create";
            this.SetSubFolderButton.UseVisualStyleBackColor = true;
            // 
            // SubFolderCloseButton
            // 
            this.SubFolderCloseButton.Location = new System.Drawing.Point(362, 8);
            this.SubFolderCloseButton.Name = "SubFolderCloseButton";
            this.SubFolderCloseButton.Size = new System.Drawing.Size(26, 23);
            this.SubFolderCloseButton.TabIndex = 5;
            this.SubFolderCloseButton.Text = "X";
            this.SubFolderCloseButton.UseVisualStyleBackColor = true;
            this.SubFolderCloseButton.Click += new System.EventHandler(this.SubFolderCloseButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.ServerMenuStrip);
            this.Controls.Add(this.DatabaseSettingsScreen);
            this.Controls.Add(this.ServerSettingsScreen);
            this.Controls.Add(this.LoginScreen);
            this.Name = "LoginForm";
            this.Text = "Server Manager";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.LoginScreen.ResumeLayout(false);
            this.LoginScreen.PerformLayout();
            this.ServerMenuStrip.ResumeLayout(false);
            this.ServerMenuStrip.PerformLayout();
            this.ServerSettingsScreen.ResumeLayout(false);
            this.ServerSettingsScreen.PerformLayout();
            this.DatabaseSettingsScreen.ResumeLayout(false);
            this.DatabaseSettingsScreen.PerformLayout();
            this.SubFolderPanel.ResumeLayout(false);
            this.SubFolderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.TextBox UsernameField;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.GroupBox LoginScreen;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label LoginErrLabel;
        private System.Windows.Forms.MenuStrip ServerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem serverSettingsToolStripMenuItem;
        private System.Windows.Forms.GroupBox ServerSettingsScreen;
        private System.Windows.Forms.Label ServerSetupLabel;
        private System.Windows.Forms.MaskedTextBox ServerHostIPField;
        private System.Windows.Forms.ToolTip ServerHostIPToolTip;
        private System.Windows.Forms.Label ServerIPHostLabel;
        private System.Windows.Forms.Label SetServerIPLabel;
        private System.Windows.Forms.Button SetServerIPButton;
        private System.Windows.Forms.Label ServerIPLabel2;
        private System.Windows.Forms.Label InvalidIPLabel;
        private System.Windows.Forms.TextBox ServerPortField;
        private System.Windows.Forms.Label ServerPortLabel;
        private System.Windows.Forms.Label SetServerPortLabel;
        private System.Windows.Forms.Label ServerPortLabel2;
        private System.Windows.Forms.Label PortErrLabel;
        private System.Windows.Forms.ToolStripMenuItem databaseSettingsToolStripMenuItem;
        private System.Windows.Forms.GroupBox DatabaseSettingsScreen;
        private System.Windows.Forms.TreeView DatabaseTreeView;
        private System.Windows.Forms.Label DatabaseViewLabel;
        private System.Windows.Forms.Button CreateCentralDatabaseButton;
        private System.Windows.Forms.FolderBrowserDialog CreateCentralFolderDialog;
        private System.Windows.Forms.Label DatabaseCentralWarningLabel2;
        private System.Windows.Forms.Label DatabaseCentralWarningLabel;
        private System.Windows.Forms.GroupBox SubFolderPanel;
        private System.Windows.Forms.Button SetSubFolderButton;
        private System.Windows.Forms.ComboBox ParentFoldersComboBox;
        private System.Windows.Forms.Label FolderSubPickLabel;
        private System.Windows.Forms.TextBox SubFolderNameField;
        private System.Windows.Forms.Label SubFolderNameLabel;
        private System.Windows.Forms.Button CreateSubFolderButton;
        private System.Windows.Forms.Button SubFolderCloseButton;
    }
}

