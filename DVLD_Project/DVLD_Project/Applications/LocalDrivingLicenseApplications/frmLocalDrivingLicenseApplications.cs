using DVLD_BusinessLayer;
using DVLD_Project.Drivers;
using DVLD_Project.Licenses;
using DVLD_Project.Licenses.LocalDrivingLicenses;
using DVLD_Project.TestAppointments;
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

namespace DVLD_Project.Applications.LocalDrivingLicenseApplications
{
    public partial class frmLocalDrivingLicenseApplications : Form
    {
        DataTable apps = new DataTable();

        void StatusFilterApplied()
        {
            if (cbxStatus.SelectedIndex == 0)
            {
                dgvLDLApps_Refresh();
                return;
            }

            DataView view = new DataView();
            view = apps.DefaultView;

            switch (cbxStatus.SelectedIndex)
            {
                case 1: view.RowFilter = "Status = 'New'"; break;
                case 2: view.RowFilter = "Status = 'Completed'"; break;
                case 3: view.RowFilter = "Status = 'Cancelled'"; break;
            }

            dgvLDLApps.DataSource = view;
        }

        string GetRealColumnName(string Name)
        {
            switch (Name)
            {
                case "National No.":
                    return "NationalNo";
                case "License Class":
                    return "ClassName";
                case "Full Name":
                    return "FullName";
                default: return Name;
            }
        }

        void FilterApplied()
        {
            if (tbxFilter.Content == "")
            {
                dgvLDLApps_Refresh();
                return;
            }

            if (cbxFilter.SelectedIndex == 1)
            {
                DataView view = apps.DefaultView;
                view.RowFilter = $"LocalDrivingLicenseApplicationID = {tbxFilter.Content}";
                dgvLDLApps.DataSource = view;
            }
            else if (cbxFilter.SelectedIndex != 5)
            {
                DataView view = apps.DefaultView;
                view.RowFilter = $"{GetRealColumnName(cbxFilter.SelectedItem)} LIKE '{tbxFilter.Content}%'";
                dgvLDLApps.DataSource = view;
            }
            else
                dgvLDLApps_Refresh();
        }

        void SetMaximized()
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                btnMaximize.Image = MaximizedImgBox.Images[0];
                cuiResizeGrip.Visible = true;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                btnMaximize.Image = MaximizedImgBox.Images[1];
                cuiResizeGrip.Visible = false;
            }
        }

        void Organize_SizeChanged()
        {
            dgvLDLApps.Width = this.Width - 24;
            dgvLDLApps.Height = this.Height - 141;
        }

        void dgvLDLApps_Refresh()
        {
            apps = clsLocalDrivingLicenseApplication.GetAllLDLApps();
            dgvLDLApps.DataSource = apps;
        }

        void Organize_dgvLDLAppsColumnsWidth()
        {
            dgvLDLApps.Columns["LocalDrivingLicenseApplicationID"].Width = ((dgvLDLApps.Width * 7) / 100);
            dgvLDLApps.Columns["ClassName"].Width = ((dgvLDLApps.Width * 30) / 100) - 4;
            dgvLDLApps.Columns["NationalNo"].Width = ((dgvLDLApps.Width * 7) / 100);
            dgvLDLApps.Columns["FullName"].Width = ((dgvLDLApps.Width * 30) / 100) - 4;
            dgvLDLApps.Columns["ApplicationDate"].Width = ((dgvLDLApps.Width * 10) / 100) - 4;
            dgvLDLApps.Columns["PasssedTests"].Width = ((dgvLDLApps.Width * 9) / 100) - 4;
            dgvLDLApps.Columns["Status"].Width = ((dgvLDLApps.Width * 7) / 100) - 4;
        }

        void LoadDate()
        {
            dgvLDLApps_Refresh();

            if (!(dgvLDLApps.Rows.Count > 0)) return;

            dgvLDLApps.Columns["LocalDrivingLicenseApplicationID"].HeaderText = "ID";
            dgvLDLApps.Columns["ClassName"].HeaderText = "License Class";
            dgvLDLApps.Columns["NationalNo"].HeaderText = "National No.";
            dgvLDLApps.Columns["FullName"].HeaderText = "Full Name";
            dgvLDLApps.Columns["ApplicationDate"].HeaderText = "Date";
            dgvLDLApps.Columns["PasssedTests"].HeaderText = "Passed Tests";
            dgvLDLApps.Columns["Status"].HeaderText = "Status";

            Organize_dgvLDLAppsColumnsWidth();
        }

        public frmLocalDrivingLicenseApplications()
        {
            InitializeComponent();

            lblEmpty.Parent = dgvLDLApps;

            LoadDate();

            cxmAppliations.Renderer = new MyMenuRenderer();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void frmLocalDrivingLicenseApplications_SizeChanged(object sender, EventArgs e)
        {
            Organize_SizeChanged();

            if (dgvLDLApps.Columns.Count > 0)
                Organize_dgvLDLAppsColumnsWidth();
        }

        private void frmLocalDrivingLicenseApplications_Resize(object sender, EventArgs e)
        {
            SetMaximized();
        }

        private void dgvLDLApps_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblEmpty.Visible = !(dgvLDLApps.RowCount > 0);
            lblRecords.Content = $"Records : {dgvLDLApps.Rows.Count}";
            if ((dgvLDLApps.Columns.Count > 0))
                Organize_dgvLDLAppsColumnsWidth();
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxFilter.Content = string.Empty;
            dgvLDLApps_Refresh();

            tbxFilter.Visible = (cbxFilter.SelectedIndex != 0 && cbxFilter.SelectedIndex != 5);
            cbxStatus.Visible = (cbxFilter.SelectedIndex == 5);
        }

        private void tbxFilter_ContentChanged(object sender, EventArgs e)
        {
            if (dgvLDLApps.Columns.Count > 0)
                FilterApplied();
        }

        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFilter.SelectedIndex == 5)
            StatusFilterApplied();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(dgvLDLApps.Columns.Count > 0)) return;

            int ID = int.Parse(dgvLDLApps.CurrentRow.Cells[0].Value.ToString());

            frmAddUpdateLocalDrivingLicenseApplication addUpdate = new frmAddUpdateLocalDrivingLicenseApplication(ID);
            addUpdate.ShowDialog();
            dgvLDLApps_Refresh();
        }

        private void btnLDLApp_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicenseApplication addUpdate = new frmAddUpdateLocalDrivingLicenseApplication();
            addUpdate.ShowDialog();
            dgvLDLApps_Refresh();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(dgvLDLApps.Columns.Count > 0)) return;

            int ID = int.Parse(dgvLDLApps.CurrentRow.Cells[0].Value.ToString());

            frmLocalDrivingLicenseApplicaitonInfo info = new frmLocalDrivingLicenseApplicaitonInfo(ID);
            info.ShowDialog();
            dgvLDLApps_Refresh();
        }

        private void toolStripMenuItemVisionTest_Click(object sender, EventArgs e)
        {
            if (!(dgvLDLApps.Columns.Count > 0)) return;

            int ID = int.Parse(dgvLDLApps.CurrentRow.Cells[0].Value.ToString());

            frmManageTestAppointments testAppointments = new frmManageTestAppointments(ID, frmManageTestAppointments.enTestType.Vision);
            testAppointments.ShowDialog();
            dgvLDLApps_Refresh();
        }

        private void toolStripMenuItemWrittenTest_Click(object sender, EventArgs e)
        {
            if (!(dgvLDLApps.Columns.Count > 0)) return;

            int ID = int.Parse(dgvLDLApps.CurrentRow.Cells[0].Value.ToString());

            frmManageTestAppointments testAppointments = new frmManageTestAppointments(ID, frmManageTestAppointments.enTestType.Written);
            testAppointments.ShowDialog();
            dgvLDLApps_Refresh();
        }

        private void toolStripMenuItemStreetTest_Click(object sender, EventArgs e)
        {
            if (!(dgvLDLApps.Columns.Count > 0)) return;

            int ID = int.Parse(dgvLDLApps.CurrentRow.Cells[0].Value.ToString());

            frmManageTestAppointments testAppointments = new frmManageTestAppointments(ID, frmManageTestAppointments.enTestType.Street);
            testAppointments.ShowDialog();
            dgvLDLApps_Refresh();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the applicaiton?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsLocalDrivingLicenseApplication.DeleteLDLApp(int.Parse(dgvLDLApps.CurrentRow.Cells[0].Value.ToString())))
                {
                    MessageBox.Show("The applicaion has been successfully deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvLDLApps_Refresh();
                }
                else
                {
                    MessageBox.Show("An error occurred while deleting the application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Deletion of the application has been canceled.", "Deletion Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cancelApplicaitonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel the applicaiton?", "Cancel Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsLocalDrivingLicenseApplication app = clsLocalDrivingLicenseApplication.FindByLDLAppID(int.Parse(dgvLDLApps.CurrentRow.Cells[0].Value.ToString()));

                if (app == null) return;

                if (app.Cancel())
                {
                    MessageBox.Show("The applicaion has been successfully canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvLDLApps_Refresh();
                }
                else
                {
                    MessageBox.Show("An error occurred while canceling the application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Cancelation of the application has been canceled.", "Cancelation Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void EnableAllContextMenuItems(bool status)
        {
            for (int i = 0; i < cxmAppliations.Items.Count; i++)
            {
                cxmAppliations.Items[i].Enabled = status;
            }
        }

        private void cxmAppliations_Opening(object sender, CancelEventArgs e)
        {
            EnableAllContextMenuItems(false);

            cxmAppliations.Items[10].Enabled = true;
            cxmAppliations.Items[0].Enabled = true;

            clsLocalDrivingLicenseApplication app = clsLocalDrivingLicenseApplication.FindByLDLAppID(int.Parse(dgvLDLApps.CurrentRow.Cells[0].Value.ToString()));

            clsDrivers Driver = clsDrivers.FindByPersonID(app.PersonID);

            if (Driver != null)
            {
                cxmAppliations.Items[8].Enabled = true;
            }

            if (!(dgvLDLApps.Rows.Count > 0)) return;

            if (app.Status == 3)
            {
                if (clsLicenses.DoesThisPersonHaveActivateLicense(app.PersonID, app.LicenseClassID))
                {
                    cxmAppliations.Items[7].Enabled = true;
                }

                return;
            }
            else if (app.Status == 2)
            {
                cxmAppliations.Items[2].Enabled = true;
                return;
            }

            if (app.DoesPassAllTests())
            {
                cxmAppliations.Items[6].Enabled = true;
                return;
            }

            cxmAppliations.Items[1].Enabled = true;
            cxmAppliations.Items[2].Enabled = true;
            cxmAppliations.Items[3].Enabled = true;
            cxmAppliations.Items[5].Enabled = true;

            scheduleTestToolStripMenuItem.DropDown.Items[0].Enabled = false;
            scheduleTestToolStripMenuItem.DropDown.Items[1].Enabled = false;
            scheduleTestToolStripMenuItem.DropDown.Items[2].Enabled = false;

            scheduleTestToolStripMenuItem.DropDown.Items[0].Enabled = true;

            if (app.DoesPassTestType(1)) 
            {
                scheduleTestToolStripMenuItem.DropDown.Items[0].Enabled = false;
                scheduleTestToolStripMenuItem.DropDown.Items[1].Enabled = true;
                scheduleTestToolStripMenuItem.DropDown.Items[2].Enabled = false;
            }
            if (app.DoesPassTestType(2)) 
            {
                scheduleTestToolStripMenuItem.DropDown.Items[0].Enabled = false;
                scheduleTestToolStripMenuItem.DropDown.Items[1].Enabled = false;
                scheduleTestToolStripMenuItem.DropDown.Items[2].Enabled = true;
            }
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(dgvLDLApps.Columns.Count > 0)) return;

            int ID = int.Parse(dgvLDLApps.CurrentRow.Cells[0].Value.ToString());
            frmIssueDrivingLicenseForFirstTime issueLicense = new frmIssueDrivingLicenseForFirstTime(ID);
            issueLicense.ShowDialog();
            dgvLDLApps_Refresh();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(dgvLDLApps.Columns.Count > 0)) return;

            clsLocalDrivingLicenseApplication app = clsLocalDrivingLicenseApplication.FindByLDLAppID(int.Parse(dgvLDLApps.CurrentRow.Cells[0].Value.ToString()));

            int LicenseID = clsLicenses.GetActivateLicensesForPersonID(app.PersonID, app.LicenseClassID);

            if (LicenseID == -1) return;

            frmLocalDrivingLicenseInfo issueLicense = new frmLocalDrivingLicenseInfo(LicenseID);
            issueLicense.ShowDialog();
            dgvLDLApps_Refresh();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(dgvLDLApps.Columns.Count > 0)) return;

            clsLocalDrivingLicenseApplication app = clsLocalDrivingLicenseApplication.FindByLDLAppID(int.Parse(dgvLDLApps.CurrentRow.Cells[0].Value.ToString()));

            clsDrivers Driver = clsDrivers.FindByPersonID(app.PersonID);

            if (Driver == null) return;

            frmDriverLicensesHistory licensesHistory = new frmDriverLicensesHistory(Driver.DriverID);
            licensesHistory.ShowDialog();
            dgvLDLApps_Refresh();
        }
    }
}
