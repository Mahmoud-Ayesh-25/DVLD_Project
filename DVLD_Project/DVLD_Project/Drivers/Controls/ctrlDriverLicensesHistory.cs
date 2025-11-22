using DVLD_BusinessLayer;
using DVLD_Project.InternationalLicenses;
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

namespace DVLD_Project.Drivers.Controls
{
    public partial class ctrlDriverLicensesHistory : UserControl
    {
        DataTable dtLocal = new DataTable();
        DataTable dtInternational = new DataTable();

        clsDrivers driver = new clsDrivers();

        void Organize_dgvLocalLicenses()
        {
            if (!(dgvLocalLicenses.Columns.Count > 0)) return;

            dgvLocalLicenses.Columns["LicenseID"].HeaderText = "License ID";
            dgvLocalLicenses.Columns["ApplicationID"].HeaderText = "App ID";
            dgvLocalLicenses.Columns["ClassName"].HeaderText = "Class Name";
            dgvLocalLicenses.Columns["IssueDate"].HeaderText = "Issue Date";
            dgvLocalLicenses.Columns["ExpirationDate"].HeaderText = "Exp Date";
            dgvLocalLicenses.Columns["IsActive"].HeaderText = "Active";

            dgvLocalLicenses.Columns["LicenseID"].Width = ((dgvLocalLicenses.Width * 10) / 100) - 4;
            dgvLocalLicenses.Columns["ApplicationID"].Width = ((dgvLocalLicenses.Width * 10) / 100) - 4;
            dgvLocalLicenses.Columns["ClassName"].Width = ((dgvLocalLicenses.Width * 43) / 100) - 4;
            dgvLocalLicenses.Columns["IssueDate"].Width = ((dgvLocalLicenses.Width * 15) / 100) - 4;
            dgvLocalLicenses.Columns["ExpirationDate"].Width = ((dgvLocalLicenses.Width * 15) / 100) - 4;
            dgvLocalLicenses.Columns["IsActive"].Width = ((dgvLocalLicenses.Width * 7) / 100);
        }

        void Organize_dgvInternational()
        {
            if (!(dgvInternational.Columns.Count > 0)) return;

            dgvInternational.Columns["InternationalLicenseID"].HeaderText = "I.L.ID";
            dgvInternational.Columns["ApplicationID"].HeaderText = "App ID";
            dgvInternational.Columns["DriverID"].HeaderText = "Driver ID";
            dgvInternational.Columns["IssuedUsingLocalLicenseID"].HeaderText = "L.L.ID";
            dgvInternational.Columns["IssueDate"].HeaderText = "Issue Date";
            dgvInternational.Columns["ExpirationDate"].HeaderText = "Exp Date";
            dgvInternational.Columns["IsActive"].HeaderText = "Active";

            dgvInternational.Columns["InternationalLicenseID"].Width = ((dgvInternational.Width * 13) / 100) - 4;
            dgvInternational.Columns["ApplicationID"].Width = ((dgvInternational.Width * 13) / 100) - 4;
            dgvInternational.Columns["DriverID"].Width = ((dgvInternational.Width * 13) / 100) - 4;
            dgvInternational.Columns["IssuedUsingLocalLicenseID"].Width = ((dgvInternational.Width * 13) / 100) - 4;
            dgvInternational.Columns["IssueDate"].Width = ((dgvInternational.Width * 20) / 100);
            dgvInternational.Columns["ExpirationDate"].Width = ((dgvInternational.Width * 20) / 100);
            dgvInternational.Columns["IsActive"].Width = ((dgvInternational.Width * 8) / 100) - 4;
        }

        bool LoadLocalLicenses()
        {
            dtLocal = driver.GetDriverLocalLicenses();

            if (dtLocal == null) return false;

            dgvLocalLicenses.DataSource = dtLocal;

            Organize_dgvLocalLicenses();

            return true;
        }

        bool LoadInternationalLicenses()
        {
            dtInternational = clsInternationalLicense.GetDriverInterLicenses(driver.DriverID);

            if (dtInternational == null) return false;

            dgvInternational.DataSource = dtInternational;

            Organize_dgvInternational();

            return true;
        }

        public bool LoadDataByDriverID(int DriverID)
        {
            driver = clsDrivers.FindByDriverID(DriverID);

            if (driver == null) return false;

            if (!LoadLocalLicenses()) return false;
            if (!LoadInternationalLicenses()) return false;

            return true;
        }

        public bool LoadDataByPersonID(int PersonID)
        {
            driver = clsDrivers.FindByPersonID(PersonID);

            if (driver == null) return false;

            if (!LoadLocalLicenses()) return false;
            if (!LoadInternationalLicenses()) return false;

            return true;
        }

        public void Clear()
        {
            dgvLocalLicenses.Rows.Clear();
            dgvInternational.Rows.Clear();
        }

        public ctrlDriverLicensesHistory()
        {
            InitializeComponent();
        }

        private void cbtnInternational_Click(object sender, EventArgs e)
        {
            pnlInternational.BringToFront();
        }

        private void cbtnLocal_Click(object sender, EventArgs e)
        {
            pnlLocalLicenses.BringToFront();
        }

        private void dgvLocalLicenses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblLocalEmpty.Visible = (dgvLocalLicenses.Rows.Count == 0);
            lblLocalRecords.Content = $"Records : {dgvLocalLicenses.Rows.Count}";
        }

        private void dgvInternational_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblInternationalEmpty.Visible = (dgvInternational.Rows.Count == 0);
            lblInternationalRecords.Content = $"Records : {dgvInternational.Rows.Count}";
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(dgvLocalLicenses.Rows.Count > 0)) return;

            int LicenseID = int.Parse(dgvLocalLicenses.CurrentRow.Cells[0].Value.ToString());

            frmLocalDrivingLicenseInfo licenseInfo = new frmLocalDrivingLicenseInfo(LicenseID);
            licenseInfo.ShowDialog();
        }

        private void pnlLocalLicenses_Paint(object sender, PaintEventArgs e)
        {
            cxmLocal.Renderer = new MyMenuRenderer();
            cxmInternational.Renderer = new MyMenuRenderer();
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(dgvInternational.Rows.Count > 0)) return;

            int LicenseID = int.Parse(dgvInternational.CurrentRow.Cells[0].Value.ToString());

            frmInterLicenseInfo licenseInfo = new frmInterLicenseInfo(LicenseID);
            licenseInfo.ShowDialog();
        }
    }
}
