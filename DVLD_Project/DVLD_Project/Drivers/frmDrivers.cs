using DVLD_BusinessLayer;
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

namespace DVLD_Project.Drivers
{
    public partial class frmDrivers : Form
    {
        DataTable dtDrivers = new DataTable();

        void Organize_SizeChanged()
        {
            dgvDrivers.Width = this.Width - 24;
            dgvDrivers.Height = this.Height - 141;
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

        void dgvDrivers_Refresh()
        {
            dtDrivers = clsDrivers.GetAllDrivers();
            dgvDrivers.DataSource = dtDrivers;
        }

        void Organize_dgvDriversColumnsWidth()
        {
            dgvDrivers.Columns["DriverID"].Width = ((dgvDrivers.Width * 10)/100) - 4;
            dgvDrivers.Columns["PersonID"].Width = ((dgvDrivers.Width * 10) / 100) - 4;
            dgvDrivers.Columns["NationalNo"].Width = ((dgvDrivers.Width * 10) / 100) - 4;
            dgvDrivers.Columns["FullName"].Width = ((dgvDrivers.Width * 45) / 100) - 4;
            dgvDrivers.Columns["CreatedDate"].Width = ((dgvDrivers.Width * 15) / 100) - 4;
            dgvDrivers.Columns["NumberOfActiveLicenses"].Width = ((dgvDrivers.Width * 10) / 100);
        }

        void Organize_dgvDrivers()
        {
            dgvDrivers_Refresh();

            if (!(dgvDrivers.Columns.Count > 0)) return;

            dgvDrivers.Columns["DriverID"].HeaderText = "Driver ID";
            dgvDrivers.Columns["PersonID"].HeaderText = "Person ID";
            dgvDrivers.Columns["NationalNo"].HeaderText = "National No.";
            dgvDrivers.Columns["FullName"].HeaderText = "Full Name";
            dgvDrivers.Columns["CreatedDate"].HeaderText = "Date";
            dgvDrivers.Columns["NumberOfActiveLicenses"].HeaderText = "Active Licenses";

            Organize_dgvDriversColumnsWidth();
        }

        void HandleFilter()
        {
            if (string.IsNullOrEmpty(tbxFilter.Content))
            {
                dgvDrivers_Refresh();
                return;
            }

            DataView view = dtDrivers.DefaultView;

            if (cbxFilter.SelectedIndex == 1 || cbxFilter.SelectedIndex == 2)
            {
                view.RowFilter = $"{dgvDrivers.Columns[cbxFilter.SelectedIndex - 1].Name} = {tbxFilter.Content}";
            }
            else if (cbxFilter.SelectedIndex == 3 || cbxFilter.SelectedIndex == 4)
            {
                view.RowFilter = $"{dgvDrivers.Columns[cbxFilter.SelectedIndex - 1].Name} Like '{tbxFilter.Content}%'";
            }

            dgvDrivers.DataSource = view;
        }

        public frmDrivers()
        {
            InitializeComponent();

            lblEmpty.Parent = dgvDrivers;
            cxmDrivers.Renderer = new MyMenuRenderer();

            Organize_dgvDrivers();
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

        private void frmDrivers_SizeChanged(object sender, EventArgs e)
        {
            Organize_SizeChanged();

            if (dgvDrivers.Columns.Count > 0)
                Organize_dgvDriversColumnsWidth();
        }

        private void frmDrivers_Resize(object sender, EventArgs e)
        {
            SetMaximized();
        }

        private void dgvDrivers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblEmpty.Visible = (dgvDrivers.Rows.Count == 0);
            lblRecords.Content = $"Records : {dgvDrivers.Rows.Count}";
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvDrivers_Refresh();
            tbxFilter.Visible = (cbxFilter.SelectedIndex != 0);
        }

        private void tbxFilter_ContentChanged(object sender, EventArgs e)
        {
            if (!(dgvDrivers.Columns.Count > 0)) return;

            HandleFilter();
        }

        private void tbxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbxFilter.SelectedIndex == 1 || cbxFilter.SelectedIndex == 2)
            {
                if (!clsValidation.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(dgvDrivers.Rows.Count > 0)) return;

            frmDriverLicensesHistory licensesHistory = new frmDriverLicensesHistory(int.Parse(dgvDrivers.CurrentRow.Cells[0].Value.ToString()));
            licensesHistory.ShowDialog();
            dgvDrivers_Refresh();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(dgvDrivers.Rows.Count > 0)) return;

            clsDrivers driver = clsDrivers.FindByDriverID(int.Parse(dgvDrivers.CurrentRow.Cells[0].Value.ToString()));

            if (driver == null) return;

            frmPersonInformation information = new frmPersonInformation(driver.PersonID);
            information.ShowDialog();
        }
    }
}
