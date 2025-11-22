using DVLD_BusinessLayer;
using DVLD_Project.Applications;
using DVLD_Project.Drivers;
using DVLD_Project.Licenses.LocalDrivingLicenses;
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
    public partial class frmReplaceLicense : Form
    {
        int LicenseID = -1;
        clsLicenses License = new clsLicenses();

        int GetApplicaiotnType()
        {
            if (cbtnLost.Checked)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }

        void ResetAddintionDetailsDefaultData()
        {
            lblAppDate.Content = $"Application Date : ";
            lblAppFees.Content = $"Applicaiton Fees : ";
            lblOldLicenseID.Content = $"Old License ID : ";
            lblCreatedByUser.Content = $"Created By User : ";
        }

        void LoadAddintionalDetailsData()
        {
            lblAppDate.Content = $"Application Date : {DateTime.Now.ToShortDateString()}";
            lblAppFees.Content = $"Applicaiton Fees : {clsApplicationTypes.GetApplicationTypeByID(GetApplicaiotnType()).ApplicationTypeFees}";
            lblOldLicenseID.Content = $"Old License ID : {LicenseID}";
            lblCreatedByUser.Content = $"Created By User : {clsSettings.CurrentUser.Username}";
        }

        public frmReplaceLicense()
        {
            InitializeComponent();
        }

        private void cbtnLost_Click(object sender, EventArgs e)
        {
            lblTitle.Content = "Replace License For Lost";
        }

        private void cbtnDamage_Click(object sender, EventArgs e)
        {
            lblTitle.Content = "Replace License For Damage";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ctrlLocalLicenseCardWithFilter_OnLicenseSelected(int obj)
        {
            LicenseID = obj;
            License = clsLicenses.Find(LicenseID);

            btnShowLicenseHistory.Visible = false;
            btnReplace.Visible = false;
            ResetAddintionDetailsDefaultData();

            if (License == null) return;

            if (!License.IsActive)
            {
                MessageBox.Show($"No operations can be performed on this license because it is not active.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnShowLicenseHistory.Visible = true;
                return;
            }

            LoadAddintionalDetailsData();
            btnReplace.Visible = true;
            btnShowLicenseHistory.Visible = true;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            clsLicenses newLicense = License.ReplaceLicense((clsLicenses.enIssueReason)GetApplicaiotnType(), clsSettings.CurrentUser.UserID);

            if (newLicense == null) { MessageBox.Show("Error while saving the license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            License = newLicense;
            LicenseID = newLicense.LicenseID;

            btnShowLicenseInfo.Visible = true;
            btnReplace.Visible = false;
            ctrlLocalLicenseCardWithFilter.EnableFilter(false);

            lblRLAppID.Content = $"R.L.Application ID : {License.ApplicaitonID}";
            lblReplacedLicenseID.Content = $"Replaced License ID : {License.LicenseID}";

            MessageBox.Show($"The license has been successfully replaced and the new License ID = {License.LicenseID}", "Replaced", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnShowLicenseInfo_Click(object sender, EventArgs e)
        {
            if (LicenseID == -1) return;

            frmLocalDrivingLicenseInfo licenseInfo = new frmLocalDrivingLicenseInfo(LicenseID);
            licenseInfo.ShowDialog();
        }

        private void btnShowLicenseHistory_Click(object sender, EventArgs e)
        {
            if (License == null) return;

            frmDriverLicensesHistory licensesHistory = new frmDriverLicensesHistory(License.DriverID);
            licensesHistory.ShowDialog();
        }
    }
}
