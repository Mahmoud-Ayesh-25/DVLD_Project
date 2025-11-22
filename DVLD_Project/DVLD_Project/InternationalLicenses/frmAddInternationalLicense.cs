using DVLD_BusinessLayer;
using DVLD_Project.Drivers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.InternationalLicenses
{
    public partial class frmAddInternationalLicense : Form
    {
        clsLicenses license = new clsLicenses();
        clsInternationalLicense inter = new clsInternationalLicense();

        public frmAddInternationalLicense()
        {
            InitializeComponent();

            lblAppDate.Content = $"Application Date : {DateTime.Now.ToShortDateString()}";
            lblIssueDate.Content = $"Issue Date : {DateTime.Now.ToShortDateString()}";
            lblExpDate.Content = $"Exp Date : {DateTime.Now.AddYears(1).ToShortDateString()}";
            lblFees.Content = $"Fees : {clsApplicationTypes.GetApplicationTypeByID((int)clsGeneralApplications.enApplicationTypes.NewInternational).ApplicationTypeFees}";
            lblCreatedByUser.Content = $"Created By User : {clsSettings.CurrentUser.Username}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ctrlLocalLicenseCardWithFilter1_OnLicenseSelected(int obj)
        {
            license = ctrlLocalLicenseCardWithFilter1.LicenseInfo;

            btnIssue.Visible = false;
            btnShowLicenseHistory.Visible = true;

            int InterLicenseID = clsInternationalLicense.GetDriverActiveInterLicenseID(license.DriverID);

            if (InterLicenseID != -1) { MessageBox.Show($"This driver has international license with id : {InterLicenseID}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (license.IsLicenseDetained()) { MessageBox.Show("This license is detained.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (license.IsLicenseExpired()) { MessageBox.Show("This license is expired.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (!license.IsActive) { MessageBox.Show("This license is not active.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            lblLocalLicenseID.Content = $"Local License ID : {license.LicenseID}";

            btnIssue.Visible = true;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            inter.PersonID = license.Driver.PersonID;
            inter.Date = DateTime.Now;
            inter.TypeID = (int)clsGeneralApplications.enApplicationTypes.NewInternational;
            inter.Status = 3;
            inter.LastStatusDate = DateTime.Now;
            inter.PaidFees = clsApplicationTypes.GetApplicationTypeByID((int)clsGeneralApplications.enApplicationTypes.NewInternational).ApplicationTypeFees;
            inter.CreatedByUserID = clsSettings.CurrentUser.UserID;

            inter.DriverID = license.DriverID;
            inter.IssuedUsingLocalLicenseID = license.LicenseID;
            inter.IssueDate = DateTime.Now;
            inter.ExpirationDate = DateTime.Now.AddYears(1);
            inter.IsActive = true;

            if (!inter.Save())
            {
                MessageBox.Show("Error while saving the license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblILAppID.Content = $"I.L.Application ID : {inter.GAppID}";
            lblInterLicenseID.Content = $"Inter License ID : {inter.InternationalLicenseID}";

            btnIssue.Visible = false;
            btnShowInterLicense.Visible = true;
            ctrlLocalLicenseCardWithFilter1.EnableFilter(false);

            MessageBox.Show($"The license has been successfully saved with id : {inter.InternationalLicenseID}.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnShowInterLicense_Click(object sender, EventArgs e)
        {
            if (inter == null) return;

            frmInterLicenseInfo licenseInfo = new frmInterLicenseInfo(inter.InternationalLicenseID);
            licenseInfo.Show();
        }

        private void btnShowLicenseHistory_Click(object sender, EventArgs e)
        {
            if (license == null) return;

            frmDriverLicensesHistory licensesHistory = new frmDriverLicensesHistory(license.DriverID);
            licensesHistory.Show();
        }
    }
}
