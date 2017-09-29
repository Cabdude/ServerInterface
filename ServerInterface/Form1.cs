using System;
using System.Net;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerInterface
{
    public partial class LoginForm : Form
    {
        IPAddress ServerIP;
        int ServerPort;
        string localUser = "Caleb";
        string localPassword = "Server";
        string centralFolderPath;

        public LoginForm()
        {
            InitializeComponent();
            InitializeSettings();
        }

        private void InitializeSettings()
        {
            if (Properties.Database.Default.CentralFolder != "")
            {
                centralFolderPath = Properties.Database.Default.CentralFolder;
                DatabaseTreeView.Nodes.Add(centralFolderPath);
                string[] centralFolderName = centralFolderPath.Split('\\');
                ParentFoldersComboBox.Items.Add(centralFolderName[centralFolderName.Length - 1]);
            }
        }

        #region Login
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameField.Text;
            string password = PasswordField.Text;
            if (username.Equals(localUser) && password.Equals(localPassword))
            {
                LoginScreen.Visible = false;
                ServerMenuStrip.Visible = true;
            }
            else
            {
                LoginErrLabel.Visible = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        #endregion


        #region ServerSettings
        private void serverSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServerSettingsScreen.Visible = true;
            DatabaseSettingsScreen.Visible = false;
        }

        private void SetServerIPButton_Click(object sender, EventArgs e)
        {

            if (IPAddress.TryParse(ServerHostIPField.Text, out ServerIP))
            {

                if(int.TryParse(ServerPortField.Text, out ServerPort))
                {
                    if(ServerPort >= 0 && ServerPort <= 65535)
                    {
                        SetServerIPLabel.Text = ServerHostIPField.Text;
                        SetServerPortLabel.Text = ServerPortField.Text;
                        InvalidIPLabel.Visible = false;
                        PortErrLabel.Visible = false;
                    }
                    else
                    {
                        PortErrLabel.Visible = true;
                    }
                }
                else
                {
                    PortErrLabel.Visible = true;
                }           
            }
            else
            {
                InvalidIPLabel.Visible = true;
            }
        }
        #endregion

        #region DatabaseSettings
        private void CreateCentralDatabaseButton_Click(object sender, EventArgs e)
        {
            if (Properties.Database.Default.CentralFolder == "")
            {
                DialogResult centralFolder = CreateCentralFolderDialog.ShowDialog();
                if (centralFolder == DialogResult.OK)
                {
                    string folderPath = CreateCentralFolderDialog.SelectedPath;
                    string setup_file = folderPath + "\\" + GlobalPrefs.DATABASE_SETUP_FILE;

                    if (!File.Exists(setup_file))
                    {
                        FileStream setup = File.Create(setup_file);
                        StreamWriter writer = new StreamWriter(setup);
                        writer.WriteLine(setup_file);
                        writer.Flush();
                        setup.Close();

                        Properties.Database.Default.CentralFolder = folderPath;
                        Properties.Database.Default.Save();

                        this.centralFolderPath = Properties.Database.Default.CentralFolder;

                        DatabaseTreeView.Nodes.Add(Properties.Database.Default.CentralFolder);

                    }
                }
            }
            else
            {
                DatabaseCentralWarningLabel.Visible = true;
                DatabaseCentralWarningLabel2.Visible = true;
            }
        }

     

        private void databaseSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseSettingsScreen.Visible = true;
            ServerSettingsScreen.Visible = false;
        }

        private void CreateSubFolderButton_Click(object sender, EventArgs e)
        {
            SubFolderPanel.Visible = true;
        }

        private void SubFolderCloseButton_Click(object sender, EventArgs e)
        {
            SubFolderPanel.Visible = false;
        }

        #endregion
    }
}
