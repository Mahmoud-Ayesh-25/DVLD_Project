using DVLD_BusinessLayer;
using DVLD_Project.Drivers;
using DVLD_Project.Licenses.LocalDrivingLicenses;
using DVLD_Project.MainSettings;
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

namespace DVLD_Project.DetainedLicenses
{
    public partial class frmManageDetainedLicenses : Form
    {
        DataTable dtDetained = new DataTable();

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
            dgvDLicenses.Width = this.Width - 24;
            dgvDLicenses.Height = this.Height - 141;
        }

        void dgvDLicenses_Refresh()
        {
            dtDetained = clsDetainedLicenses.GetAllDetainedLicenses();
            dgvDLicenses.DataSource = dtDetained;
        }

        string GetRealColumnName(string ColumnName)
        {
            switch (ColumnName)
            {
                case "Detain ID": return "DetainID";
                case "Full Name": return "FullName";
                case "National No.": return "NationalNo";
                case "Release App ID": return "ReleaseApplicationID";
                default: return "FullName";
            }
        }

        void IsReleasedFilterHandler()
        {
            if (cbxIsReleased.SelectedIndex == 0)
            {
                dgvDLicenses_Refresh();
                return;
            }

            DataView view = dtDetained.DefaultView;

            if (cbxIsReleased.SelectedIndex == 1)
            {
                view.RowFilter = $"IsReleased = 1";
            }
            else if (cbxIsReleased.SelectedIndex == 2)
            {
                view.RowFilter = $"IsReleased = 0";
            }

            dgvDLicenses.DataSource = view;
        }

        void FilterHandler()
        {
            if (string.IsNullOrEmpty(tbxFilter.Content))
            {
                dgvDLicenses_Refresh();
                return;
            }

            DataView view = dtDetained.DefaultView;

            if (cbxFilter.SelectedIndex == 1 || cbxFilter.SelectedIndex == 5)
            {
                view.RowFilter = $"{GetRealColumnName(cbxFilter.SelectedItem)} = {tbxFilter.Content}";
            }
            else
            {
                if (cbxFilter.SelectedIndex != 2)
                {
                    view.RowFilter = $"{GetRealColumnName(cbxFilter.SelectedItem)} LIKE '{tbxFilter.Content}%'";
                }
            }

            dgvDLicenses.DataSource = view;
        }

        void Organize_dgvDLicensesColumnsWidth()
        {
            dgvDLicenses.Columns["DetainID"].Width = ((dgvDLicenses.Width * 7) / 100) - 2;
            dgvDLicenses.Columns["LicenseID"].Width = ((dgvDLicenses.Width * 7) / 100) - 2;
            dgvDLicenses.Columns["DetainDate"].Width = ((dgvDLicenses.Width * 10) / 100) - 2;
            dgvDLicenses.Columns["IsReleased"].Width = ((dgvDLicenses.Width * 5) / 100) - 2;
            dgvDLicenses.Columns["FineFees"].Width = ((dgvDLicenses.Width * 7) / 100) - 2;
            dgvDLicenses.Columns["ReleaseDate"].Width = ((dgvDLicenses.Width * 10) / 100) - 2;
            dgvDLicenses.Columns["NationalNo"].Width = ((dgvDLicenses.Width * 7) / 100) - 2;
            dgvDLicenses.Columns["FullName"].Width = ((dgvDLicenses.Width * 37) / 100) - 4;
            dgvDLicenses.Columns["ReleaseApplicationID"].Width = ((dgvDLicenses.Width * 10) / 100) - 2;
        }

        void Organize_dgvDLicenses()
        {
            dgvDLicenses_Refresh();

            if (!(dgvDLicenses.Columns.Count > 0)) return;

            dgvDLicenses.Columns["DetainID"].HeaderText = "D.ID";
            dgvDLicenses.Columns["LicenseID"].HeaderText = "L.ID";
            dgvDLicenses.Columns["DetainDate"].HeaderText = "D.Date";
            dgvDLicenses.Columns["IsReleased"].HeaderText = "Released";
            dgvDLicenses.Columns["FineFees"].HeaderText = "Fees";
            dgvDLicenses.Columns["ReleaseDate"].HeaderText = "R.Date";
            dgvDLicenses.Columns["NationalNo"].HeaderText = "N.No.";
            dgvDLicenses.Columns["FullName"].HeaderText = "Full Name";
            dgvDLicenses.Columns["ReleaseApplicationID"].HeaderText = "Release App ID";

            Organize_dgvDLicensesColumnsWidth();
        }

        public frmManageDetainedLicenses()
        {
            InitializeComponent();

            cxmDLicenses.Renderer = new MyMenuRenderer();
            lblEmpty.Parent = dgvDLicenses;

            Organize_dgvDLicenses();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void dgvDLicenses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblEmpty.Visible = (!(dgvDLicenses.Rows.Count > 0));
            lblRecords.Content = $"Records : {dgvDLicenses.Rows.Count}";
        }

        private void frmManageDetainedLicenses_Resize(object sender, EventArgs e)
        {
            SetMaximized();
        }

        private void frmManageDetainedLicenses_SizeChanged(object sender, EventArgs e)
        {
            Organize_SizeChanged();

            if (dgvDLicenses.Rows.Count > 0)
                Organize_dgvDLicensesColumnsWidth();
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

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvDLicenses_Refresh();

            tbxFilter.Content = string.Empty;
            tbxFilter.Visible = (cbxFilter.SelectedIndex != 0 && cbxFilter.SelectedIndex != 2);
            cbxIsReleased.Visible = (cbxFilter.SelectedIndex == 2);
        }

        private void tbxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbxFilter.SelectedIndex == 1 || cbxFilter.SelectedIndex == 5)
            {
                if (!clsValidation.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void tbxFilter_ContentChanged(object sender, EventArgs e)
        {
            if (!(dgvDLicenses.Columns.Count > 0)) return;

            FilterHandler();
        }

        private void cbxIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(dgvDLicenses.Columns.Count > 0)) return;

            IsReleasedFilterHandler();
        }

        private void btnDLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicense detainLicense = new frmDetainLicense();
            detainLicense.ShowDialog();
            dgvDLicenses_Refresh();
        }

        private void btnRLicense_Click(object sender, EventArgs e)
        {
            frmReleaseLicense releaseLicense = new frmReleaseLicense();
            releaseLicense.ShowDialog();
            dgvDLicenses_Refresh();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(dgvDLicenses.Rows.Count > 0)) return;

            clsLicenses license = clsLicenses.Find(int.Parse(dgvDLicenses.CurrentRow.Cells[1].Value.ToString()));
            if (license == null) return;

            frmPersonInformation personInformation = new frmPersonInformation(license.Driver.PersonID);
            personInformation.ShowDialog();

            dgvDLicenses_Refresh();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(dgvDLicenses.Rows.Count > 0)) return;

            clsLicenses license = clsLicenses.Find(int.Parse(dgvDLicenses.CurrentRow.Cells[1].Value.ToString()));
            if (license == null) return;

            frmLocalDrivingLicenseInfo licenseInfo = new frmLocalDrivingLicenseInfo(license.LicenseID);
            licenseInfo.ShowDialog();

            dgvDLicenses_Refresh();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(dgvDLicenses.Rows.Count > 0)) return;

            clsLicenses license = clsLicenses.Find(int.Parse(dgvDLicenses.CurrentRow.Cells[1].Value.ToString()));
            if (license == null) return;

            frmDriverLicensesHistory licensesHistory = new frmDriverLicensesHistory(license.DriverID);
            licensesHistory.ShowDialog();

            dgvDLicenses_Refresh();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(dgvDLicenses.Rows.Count > 0)) return;

            clsLicenses license = clsLicenses.Find(int.Parse(dgvDLicenses.CurrentRow.Cells[1].Value.ToString()));
            if (license == null) return;

            frmReleaseLicense releaseLicense = new frmReleaseLicense(license.LicenseID);
            releaseLicense.ShowDialog();

            dgvDLicenses_Refresh();
        }

        private void cxmDLicenses_Opening(object sender, CancelEventArgs e)
        {
            if (!(dgvDLicenses.Rows.Count > 0)) return;

            bool IsRelease = (bool)dgvDLicenses.CurrentRow.Cells[3].Value;

            cxmDLicenses.Items[4].Enabled = (!IsRelease);
        }
    }
}
