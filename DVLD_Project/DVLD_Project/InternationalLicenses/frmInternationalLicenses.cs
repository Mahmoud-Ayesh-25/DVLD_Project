using DVLD_BusinessLayer;
using DVLD_Project.Drivers;
using DVLD_Project.Licenses.LocalDrivingLicenses;
using DVLD_Project.People;
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
    public partial class frmInternationalLicenses : Form
    {
        DataTable dtInter = new DataTable();

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
            dgvInterLicenses.Width = this.Width - 24;
            dgvInterLicenses.Height = this.Height - 141;
        }

        void dgvInterLicenses_Refresh()
        {
            dtInter = clsInternationalLicense.GetAllInterLicenses();
            dgvInterLicenses.DataSource = dtInter;
        }
        
        void Organize_dgvInterLicensesColumnsWidth()
        {
            dgvInterLicenses.Columns["InternationalLicenseID"].Width = ((dgvInterLicenses.Width * 13) / 100) - 4;
            dgvInterLicenses.Columns["ApplicationID"].Width = ((dgvInterLicenses.Width * 13) / 100) - 4;
            dgvInterLicenses.Columns["DriverID"].Width = ((dgvInterLicenses.Width * 13) / 100) - 4;
            dgvInterLicenses.Columns["IssuedUsingLocalLicenseID"].Width = ((dgvInterLicenses.Width * 13) / 100) - 4;
            dgvInterLicenses.Columns["IssueDate"].Width = ((dgvInterLicenses.Width * 20) / 100);
            dgvInterLicenses.Columns["ExpirationDate"].Width = ((dgvInterLicenses.Width * 20) / 100);
            dgvInterLicenses.Columns["IsActive"].Width = ((dgvInterLicenses.Width * 8) / 100) - 4;
        }

        void Organize_dgvInterLicenses()
        {
            dgvInterLicenses_Refresh();

            if (!(dgvInterLicenses.Columns.Count > 0)) return;

            dgvInterLicenses.Columns["InternationalLicenseID"].HeaderText = "I.L.ID";
            dgvInterLicenses.Columns["ApplicationID"].HeaderText = "App ID";
            dgvInterLicenses.Columns["DriverID"].HeaderText = "Driver ID";
            dgvInterLicenses.Columns["IssuedUsingLocalLicenseID"].HeaderText = "L.L.ID";
            dgvInterLicenses.Columns["IssueDate"].HeaderText = "Issue Date";
            dgvInterLicenses.Columns["ExpirationDate"].HeaderText = "Exp Date";
            dgvInterLicenses.Columns["IsActive"].HeaderText = "Active";

            Organize_dgvInterLicensesColumnsWidth();
        }

        void FilterHandler()
        {
            if (string.IsNullOrEmpty(tbxFilter.Content))
            {
                dgvInterLicenses_Refresh();
                return;
            }

            if (cbxFilter.SelectedIndex != 5 && cbxFilter.SelectedIndex != 0)
            {
                DataView view = dtInter.DefaultView;
                view.RowFilter = $"{dgvInterLicenses.Columns[cbxFilter.SelectedIndex - 1].Name} = {tbxFilter.Content}";
                dgvInterLicenses.DataSource = view;
            }
        }

        void IsActiveFilterHandler()
        {
            if (cbxIsActive.SelectedIndex == 0)
            {
                dgvInterLicenses_Refresh();
                return;
            }

            DataView view = dtInter.DefaultView;

            if (cbxIsActive.SelectedIndex == 1)
            {
                view.RowFilter = $"IsActive = 1";
            }

            if (cbxIsActive.SelectedIndex == 2)
            {
                view.RowFilter = $"IsActive = 0";
            }

            dgvInterLicenses.DataSource = view;
        }

        public frmInternationalLicenses()
        {
            InitializeComponent();

            lblEmpty.Parent = dgvInterLicenses;
            cxmInterLicenses.Renderer = new MyMenuRenderer();

            Organize_dgvInterLicenses();
        }

        private void dgvDLicenses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblEmpty.Visible = (!(dgvInterLicenses.Rows.Count > 0));
            lblRecords.Content = $"Records : {dgvInterLicenses.Rows.Count}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnAddInter_Click(object sender, EventArgs e)
        {
            frmAddInternationalLicense internationalLicense = new frmAddInternationalLicense();
            internationalLicense.ShowDialog();
            dgvInterLicenses_Refresh();
        }

        private void frmInternationalLicenses_SizeChanged(object sender, EventArgs e)
        {
            Organize_SizeChanged();

            if (dgvInterLicenses.Columns.Count > 0)
                Organize_dgvInterLicensesColumnsWidth();
        }

        private void frmInternationalLicenses_Resize(object sender, EventArgs e)
        {
            SetMaximized();
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

        private void tbxFilter_ContentChanged(object sender, EventArgs e)
        {
            FilterHandler();
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvInterLicenses_Refresh();

            tbxFilter.Visible = (cbxFilter.SelectedIndex != 5 && cbxFilter.SelectedIndex != 0);
            cbxIsActive.Visible = (cbxFilter.SelectedIndex == 5);
        }

        private void cbxIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsActiveFilterHandler();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(dgvInterLicenses.Rows.Count > 0)) return;

            int driverID = int.Parse(dgvInterLicenses.CurrentRow.Cells[2].Value.ToString());
            clsDrivers driver = clsDrivers.FindByDriverID(driverID);

            if (driver == null) return;

            frmPersonInformation personInformation = new frmPersonInformation(driver.PersonID);
            personInformation.ShowDialog();

            dgvInterLicenses_Refresh();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(dgvInterLicenses.Rows.Count > 0)) return;

            int interID = int.Parse(dgvInterLicenses.CurrentRow.Cells[0].Value.ToString());

            frmInterLicenseInfo licenseInfo = new frmInterLicenseInfo(interID);
            licenseInfo.ShowDialog();

            dgvInterLicenses_Refresh();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(dgvInterLicenses.Rows.Count > 0)) return;

            int driverID = int.Parse(dgvInterLicenses.CurrentRow.Cells[2].Value.ToString());

            frmDriverLicensesHistory licensesHistory = new frmDriverLicensesHistory(driverID);
            licensesHistory.ShowDialog();

            dgvInterLicenses_Refresh();
        }
    }
}
