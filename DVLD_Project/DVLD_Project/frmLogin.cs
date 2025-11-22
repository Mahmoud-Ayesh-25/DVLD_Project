using DVLD_BusinessLayer;
using DVLD_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class frmLogin : Form
    {
        clsUser user = new clsUser();

        bool ShowPass = false;

        void SetRememberMeFile()
        {
            if (chkRememberMe.Checked)
            {
                if (!(string.IsNullOrEmpty(tbxUsername.Content) || string.IsNullOrEmpty(tbxPassword.Content)))
                {
                    File.WriteAllText("RememberMe", $"{tbxUsername.Content}|{tbxPassword.Content}");
                }
            }
            else
            {
                File.Delete("RememberMe");
            }
        }

        void GetRememberMe()
        {
            if (File.Exists("RememberMe"))
            {
                string loginInformation = File.ReadAllText("RememberMe");

                string[] usernameAndPassword = loginInformation.Split('|');

                try
                {
                    tbxUsername.Content = usernameAndPassword[0];
                    tbxPassword.Content = usernameAndPassword[1];
                    chkRememberMe.Checked = true;
                }
                catch
                {
                    tbxUsername.Content = "";
                    tbxPassword.Content = "";
                }
            }
        }

        bool IsReadyToLogin()
        {
            if (string.IsNullOrEmpty(tbxUsername.Content)) return false;
            if (string.IsNullOrEmpty(tbxPassword.Content)) return false;
            return true;
        }

        bool IsValidUsernameAndPassword()
        {
            user = clsUser.FindByUsernameAndPassword(tbxUsername.Content, tbxPassword.Content);

            if (user == null) return false;

            return true;
        }

        void MoveTheDB()
        {
            string mdf_path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DVLD", "DVLD.mdf");
            string log_path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DVLD", "DVLD_log.ldf");

            if (File.Exists(mdf_path) && File.Exists(log_path)) return;

            if (File.Exists(@"DB\DVLD.mdf") && File.Exists(@"DB\DVLD_log.ldf"))
            {
                string dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DVLD");

                Directory.CreateDirectory(dir);
                File.Move(@"DB\DVLD.mdf", mdf_path);
                File.Move(@"DB\DVLD_log.ldf", log_path);
                Directory.Delete("DB");
            }
            else
            {
                MessageBox.Show(@"The database files were not found. Please make sure the database files exist in \Program File\DB\.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        public frmLogin()
        {
            InitializeComponent();

            MoveTheDB();

            GetRememberMe();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!IsReadyToLogin())
            {
                MessageBox.Show("Make sure to fill in all the fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsValidUsernameAndPassword())
            {
                if (!user.IsActive)
                {
                    MessageBox.Show("Your user account is not activated, please contact your administrator.", "Not Activated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SetRememberMeFile();
                clsSettings.CurrentUser = user;

                frmMainForm mainForm = new frmMainForm(this);
                this.Hide();
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (ShowPass)
            {
                ShowPass = false;
                tbxPassword.PasswordChar = true;
                btnShowPassword.Image = Resources.show__1_;
            }
            else
            {
                ShowPass = true;
                tbxPassword.PasswordChar = false;
                btnShowPassword.Image = Resources.hide_layer;
            }
        }
    }
}
