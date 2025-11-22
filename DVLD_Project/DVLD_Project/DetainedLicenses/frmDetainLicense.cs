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

namespace DVLD_Project.DetainedLicenses
{
    public partial class frmDetainLicense : Form
    {
        int LicenseID = -1;
        clsLicenses License = new clsLicenses();

        public frmDetainLicense()
        {
            InitializeComponent();

            lblCreatedByUser.Content = $"Created By User : {clsSettings.CurrentUser.UserID}";
            lblDetainDate.Content = $"Detain Date : {DateTime.Now.ToShortDateString()}";
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
            License = ctrlLocalLicenseCardWithFilter1.LicenseInfo;
            LicenseID = License.LicenseID;

            btnShowLicenseHistory.Visible = (License.LicenseID != -1);
            btnDetain.Visible = false;

            if (LicenseID == -1) return;
            if (License.IsLicenseDetained()) { MessageBox.Show("This license is already detained.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (License.IsLicenseExpired()) { MessageBox.Show("This license is expired.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (!License.IsActive) { MessageBox.Show("This license is not active.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            lblLicenseID.Content = $"License ID : {LicenseID}";

            btnDetain.Visible = true;
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxFineFees.Content))
            {
                MessageBox.Show("Make sure to fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int DetainID = License.DetainLicense(clsSettings.CurrentUser.UserID, float.Parse(tbxFineFees.Content));

            if (DetainID == -1)
            {
                MessageBox.Show("Error while saving the detained license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblDetainID.Content = $"Detain ID : {DetainID}";

            ctrlLocalLicenseCardWithFilter1.EnableFilter(false);
            btnDetain.Visible = false;

            MessageBox.Show("The license has been successfully detained.", "Detained", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tbxFineFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxFineFees.Content))
            {
                tbxFineFees.OutlineColor = Color.Red;
                tbxFineFees.PlaceholderColor = Color.Red;
                tbxFineFees.PlaceholderText = "Required";
            }
            else
            {
                tbxFineFees.OutlineColor = Color.Gainsboro;
                tbxFineFees.PlaceholderColor = Color.DimGray;
                tbxFineFees.PlaceholderText = "Fine Fees";
            }
        }

        private void btnShowLicenseHistory_Click(object sender, EventArgs e)
        {
            if (License == null) return;

            frmDriverLicensesHistory licensesHistory = new frmDriverLicensesHistory(License.DriverID);
            licensesHistory.ShowDialog();
        }
    }
}
