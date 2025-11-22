using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Licenses
{
    public partial class frmIssueDrivingLicenseForFirstTime : Form
    {
        int LDLAppID = -1;
        clsLocalDrivingLicenseApplication app = new clsLocalDrivingLicenseApplication();

        public frmIssueDrivingLicenseForFirstTime(int LDLAppID)
        {
            InitializeComponent();

            this.LDLAppID = LDLAppID;
        }

        private void frmIssueDrivingLicenseForFirstTime_Load(object sender, EventArgs e)
        {
            app = clsLocalDrivingLicenseApplication.FindByLDLAppID(LDLAppID);

            if (app == null) { MessageBox.Show("No information found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }
            if (app.GetActiveLicenseID() != -1) { MessageBox.Show("Already has license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }
            if (!app.DoesPassAllTests()) { MessageBox.Show("This person did not pass all tests.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }

            ctrlApplicaitonInfo1.LoadData(LDLAppID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int LicenseID = app.IssueDrivingLicenseForFirstTime(tbxNotes.Content, clsSettings.CurrentUser.UserID);

            if (LicenseID != -1)
            {
                MessageBox.Show("License Issued Successfully with License ID = " + LicenseID.ToString(),
                    "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("License Was not Issued ! ",
                 "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
