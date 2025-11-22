using DVLD_BusinessLayer;
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
    public partial class frmRenewLicense : Form
    {
        int LicenseID = -1;
        clsLicenses License = new clsLicenses();

        public frmRenewLicense()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        void LoadAddintionalDetailsData()
        {
            float appFees = clsApplicationTypes.GetApplicationTypeByID(this.License.Application.TypeID).ApplicationTypeFees;
            float licenseFees = clsLicenseClasses.Find(this.License.LicenseClassID).ClassFees;

            lblAppDate.Content = $"Application Date : {DateTime.Now.ToShortDateString()}";
            lblIssueDate.Content = $"Issue Date : {DateTime.Now.ToShortDateString()}";
            lblAppFees.Content = $"Application Fees : {appFees.ToString()}";
            lblLicenseFees.Content = $"License Fees : {licenseFees.ToString()}";
            tbxNotes.Content = this.License.Notes;
            lblOldLicenseID.Content = $"Old License ID : {this.License.LicenseID}";
            lblExpDate.Content = $"Exp Date : {DateTime.Now.AddYears(clsLicenseClasses.Find(this.License.LicenseClassID).DefaultValidityLength).ToShortDateString()}";
            lblCreatedByUser.Content = $"Created By User : {clsSettings.CurrentUser.Username}";
            lblTotalFees.Content = $"Total Fees : {appFees + licenseFees}";
        }

        void ResetAddintionDetailsDefaultData()
        {
            lblAppDate.Content = $"Application Date : {DateTime.Now.ToShortDateString()}";
            lblIssueDate.Content = $"Issue Date : {DateTime.Now.ToShortDateString()}";
            lblAppFees.Content = $"Application Fees : ";
            lblLicenseFees.Content = $"License Fees : ";
            tbxNotes.Content = string.Empty;
            lblOldLicenseID.Content = $"Old License ID : ";
            lblExpDate.Content = $"Exp Date : ";
            lblCreatedByUser.Content = $"Created By User : {clsSettings.CurrentUser.Username}";
            lblTotalFees.Content = $"Total Fees : ";
        }

        private void ctrlLocalLicenseCardWithFilter_OnLicenseSelected(int obj)
        {
            LicenseID = obj;
            License = clsLicenses.Find(LicenseID);

            btnShowLicenseHistory.Visible = false;
            btnRenew.Visible = false;
            ResetAddintionDetailsDefaultData();

            if (License == null) return;

            if (!License.IsLicenseExpired()) 
            {
                MessageBox.Show($"This license is not expired yet, it will expire on {License.ExpDate.ToShortDateString()}.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnShowLicenseHistory.Visible = true;
                return; 
            }

            if (!License.IsActive)
            {
                MessageBox.Show($"No operations can be performed on this license because it is not active.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnShowLicenseHistory.Visible = true;
                return;
            }

            LoadAddintionalDetailsData();
            btnRenew.Visible = true;
            btnShowLicenseHistory.Visible = true;
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            clsLicenses newLicense = License.RenewLicense(tbxNotes.Content, clsSettings.CurrentUser.UserID);

            if (newLicense == null) { MessageBox.Show("Error while saving the license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            License = newLicense;
            LicenseID = newLicense.LicenseID;

            btnShowLicenseInfo.Visible = true;
            btnRenew.Visible = false;
            ctrlLocalLicenseCardWithFilter.EnableFilter(false);

            lblRLAppID.Content = $"R.L.Application ID : {License.ApplicaitonID}";
            lblNewLicneseID.Content = $"New License ID : {License.LicenseID}";

            MessageBox.Show($"The license has been successfully renewed and the new License ID = {License.LicenseID}", "Renewed", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
