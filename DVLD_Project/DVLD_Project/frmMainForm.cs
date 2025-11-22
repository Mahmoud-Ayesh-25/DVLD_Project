using DVLD_Project.Applications;
using DVLD_Project.Applications.LocalDrivingLicenseApplications;
using DVLD_Project.DetainedLicenses;
using DVLD_Project.Drivers;
using DVLD_Project.InternationalLicenses;
using DVLD_Project.Licenses;
using DVLD_Project.Tests;
using DVLD_Project.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class frmMainForm : Form
    {
        frmLogin Login = new frmLogin();

        void GetLastSize()
        {
            if (!File.Exists("Last Size")) return;

            string lastSize = File.ReadAllText("Last Size");

            string[] size = lastSize.Split('|');

            if (size.Length == 2)
            {
                string width = size[0];
                string height = size[1];

                if (int.TryParse(width, out int w))
                {
                    this.Width = w;
                }

                if (int.TryParse(height, out int h))
                {
                    this.Height = h;
                }
            }
        }

        void GetLastLocation()
        {
            if (!File.Exists("Last Location")) return;

            string lastLocation = File.ReadAllText("Last Location");

            string[] locaiton = lastLocation.Split('|');

            if (locaiton.Length == 2)
            {
                string x = locaiton[0];
                string y = locaiton[1];

                if (int.TryParse(x, out int w))
                {
                    if (int.TryParse(y, out int h))
                    {
                        this.Location = new Point(w, h);
                    }
                }
            }
        }

        void GetMaximized()
        {
            if (!File.Exists("Maximized")) return;

            string maximized = File.ReadAllText("Maximized");

            if (maximized == "1")
                this.WindowState = FormWindowState.Maximized;
            else if (maximized == "0")
                this.WindowState = FormWindowState.Normal;
        }

        void SetMaximized()
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                btnMaximize.Image = MaximizedImgBox.Images[0];
                cuiResizeGrip1.Visible = true;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                btnMaximize.Image = MaximizedImgBox.Images[1];
                cuiResizeGrip1.Visible = false;
            }
        }

        void SetSizeChanged()
        {
            pnlMainMenu.Size = new Size(this.Width - 24, 117);
        }

        public frmMainForm(frmLogin login)
        {
            InitializeComponent();

            Login = login;

            cxmApplicaitons.Renderer = new MyMenuRenderer();
            cxmApplicaitons.Font = new Font(FontFamily.GenericSansSerif, 11);

            cxmAccountSettings.Renderer = new MyMenuRenderer();
            cxmAccountSettings.Font = new Font(FontFamily.GenericSansSerif, 11);

            clsSettings.MainForm = this;
            GetLastSize();
            GetMaximized();
            
            if (this.WindowState != FormWindowState.Maximized)
                GetLastLocation();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close DVLD?", "Close Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login.Close();
                this.Close();
            }
        }

        private void frmMainForm_SizeChanged(object sender, EventArgs e)
        {
            SetSizeChanged();

            if (this.WindowState != FormWindowState.Maximized)
            {
                File.WriteAllText("Last Size", $"{this.Size.Width.ToString()}|{this.Size.Height.ToString()}");
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                File.WriteAllText("Maximized", "1");
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                File.WriteAllText("Maximized", "0");
                GetLastLocation();
            }
        }

        private void frmMainForm_Resize(object sender, EventArgs e)
        {
            SetMaximized();
        }

        private void btnApplications_Click(object sender, EventArgs e)
        {
            int locationX = this.Location.X + pnlMainMenu.Location.X + btnApplications.Location.X;
            int locationY = this.Location.Y + pnlMainMenu.Location.Y + btnApplications.Location.Y + 114;

            cxmApplicaitons.Show(locationX, locationY);
        }

        private void btnAccountSettings_Click(object sender, EventArgs e)
        {
            int locationX = this.Location.X + pnlMainMenu.Location.X + btnAccountSettings.Location.X;
            int locationY = this.Location.Y + pnlMainMenu.Location.Y + btnAccountSettings.Location.Y + 114;

            cxmAccountSettings.Show(locationX, locationY);
        }

        private void frmMainForm_LocationChanged(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                File.WriteAllText("Last Location", $"{this.Location.X.ToString()}|{this.Location.Y.ToString()}");
            }
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            frmPeople peopleForm = new frmPeople();
            peopleForm.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUsers usersForm = new frmUsers();
            usersForm.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo userInfo = new frmUserInfo(clsSettings.CurrentUser.UserID);
            userInfo.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword updateUser = new frmChangePassword(clsSettings.CurrentUser.UserID);
            updateUser.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login.Show();
                this.Close();
            }
        }

        private void manageApplicationsTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes applicationTypes = new frmManageApplicationTypes();
            applicationTypes.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestTypes manageTestTypes = new frmManageTestTypes();
            manageTestTypes.ShowDialog();
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenseApplications frm = new frmLocalDrivingLicenseApplications();
            frm.ShowDialog();
        }

        private void localDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicenseApplication addUpdate = new frmAddUpdateLocalDrivingLicenseApplication();
            addUpdate.ShowDialog();
        }

        private void retakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenseApplications frm = new frmLocalDrivingLicenseApplications();
            frm.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewLicense renewLicense = new frmRenewLicense();
            renewLicense.ShowDialog();
        }

        private void replaceForLostOrDamageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplaceLicense replaceLicense = new frmReplaceLicense();
            replaceLicense.ShowDialog();
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            frmDrivers drivers = new frmDrivers();
            drivers.ShowDialog();
        }

        private void detaineLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainLicense detainLicense = new frmDetainLicense();
            detainLicense.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseLicense releaseLicense = new frmReleaseLicense();
            releaseLicense.ShowDialog();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDetainedLicenses detainedLicenses = new frmManageDetainedLicenses();
            detainedLicenses.ShowDialog();
        }

        private void relaiseDetainedDrivingLIcenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseLicense relaiseLicense = new frmReleaseLicense();
            relaiseLicense.ShowDialog();
        }

        private void internationalDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddInternationalLicense internationalLicense = new frmAddInternationalLicense();
            internationalLicense.ShowDialog();
        }

        private void internaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInternationalLicenses internationalLicenses = new frmInternationalLicenses();
            internationalLicenses.ShowDialog();
        }
    }
}