using DVLD_BusinessLayer;
using DVLD_Project.Drivers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.DetainedLicenses
{
    public partial class frmReleaseLicense : Form
    {
        clsLicenses License = new clsLicenses();
        int LicenseID = -1;

        float ApplicationFees = clsApplicationTypes.GetApplicationTypeByID(5).ApplicationTypeFees;

        public frmReleaseLicense()
        {
            InitializeComponent();
        }

        public frmReleaseLicense(int LicenseID)
        {
            InitializeComponent();

            License = clsLicenses.Find(LicenseID);
            this.LicenseID = LicenseID;

            if (ctrlLocalLicenseCardWithFilter1.LoadData(LicenseID))
                ctrlLocalLicenseCardWithFilter1_OnLicenseSelected(LicenseID);
        }

        private void ctrlLocalLicenseCardWithFilter1_OnLicenseSelected(int obj)
        {
            License = ctrlLocalLicenseCardWithFilter1.LicenseInfo;
            LicenseID = License.LicenseID;

            btnShowLicenseHistory.Visible = (License.LicenseID != -1);
            btnDetain.Visible = false;

            if (LicenseID == -1) return;
            if (!License.IsLicenseDetained()) { MessageBox.Show("This license is already released.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (License.IsLicenseExpired()) { MessageBox.Show("This license is expired.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (!License.IsActive) { MessageBox.Show("This license is not active.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            lblLicenseID.Content = $"License ID : {LicenseID}";
            
            clsDetainedLicenses detained = clsDetainedLicenses.FindByLicenseID(LicenseID);
            if (detained == null) return;

            lblDetainID.Content = $"Detain ID : {detained.DetainID}";
            lblDetainDate.Content = $"Detain Date : {detained.DetainDate.ToShortDateString()}";
            lblCreatedByUser.Content = $"Created By User : {detained.CreatedByUserInfo.Username}";
            lblFineFees.Content = $"Fine Fees : {detained.FineFees}";
            lblTotalFees.Content = $"Total Fees : {detained.FineFees + ApplicationFees}";

            btnDetain.Visible = true;
        }

        private void frmReleaseLicense_Load(object sender, EventArgs e)
        {
            lblAppFees.Content = $"Application Fees : {ApplicationFees}";
        }

        private void btnShowLicenseHistory_Click(object sender, EventArgs e)
        {
            if (License == null) return;

            frmDriverLicensesHistory releaseLicense = new frmDriverLicensesHistory(License.DriverID);
            releaseLicense.ShowDialog();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            int AppID = clsDetainedLicenses.ReleaseLicense(LicenseID, clsSettings.CurrentUser.UserID);

            if (AppID == -1)
            {
                MessageBox.Show("Error while saving the license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrlLocalLicenseCardWithFilter1.EnableFilter(false);
            lblAppID.Content = $"Application ID : {AppID}";
            btnDetain.Visible = false;

            MessageBox.Show("The license has been successfully released.", "Released", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
