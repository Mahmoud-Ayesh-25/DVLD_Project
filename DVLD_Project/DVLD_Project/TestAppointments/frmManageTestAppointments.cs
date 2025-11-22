using DVLD_BusinessLayer;
using DVLD_Project.TestAppointments.ScheduleTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.TestAppointments
{
    public partial class frmManageTestAppointments : Form
    {
        DataTable dtAppointments = new DataTable();

        int LDLAppID = -1;

        public enum enTestType { Vision = 1, Written, Street}
        enTestType TestType = enTestType.Vision;

        void dgvAppointments_Refresh()
        {
            dtAppointments = clsTestAppointments.GetApplicaitonTestAppointmentByTestType(LDLAppID, (int)TestType);
            dgvTestAppointments.DataSource = dtAppointments;
        }

        void Organize_dgvAppointmentsColumnsWidth()
        {
            dgvTestAppointments.Columns["TestAppointmentID"].Width = ((dgvTestAppointments.Width * 25)/100) - 5;
            dgvTestAppointments.Columns["AppointmentDate"].Width = ((dgvTestAppointments.Width * 35) / 100) - 5;
            dgvTestAppointments.Columns["PaidFees"].Width = ((dgvTestAppointments.Width * 25) / 100) - 5;
            dgvTestAppointments.Columns["IsLocked"].Width = ((dgvTestAppointments.Width * 15) / 100) - 5;
        }

        void Organize_dgvAppointments()
        {
            dgvAppointments_Refresh();

            if (!(dgvTestAppointments.Rows.Count > 0)) return;

            dgvTestAppointments.Columns["TestAppointmentID"].HeaderText = "ID";
            dgvTestAppointments.Columns["AppointmentDate"].HeaderText = "Date";
            dgvTestAppointments.Columns["PaidFees"].HeaderText = "Fees";
            dgvTestAppointments.Columns["IsLocked"].HeaderText = "Is Locked";

            Organize_dgvAppointmentsColumnsWidth();
        }

        public frmManageTestAppointments(int LDLAppID, enTestType testType)
        {
            InitializeComponent();

            cxmAppointments.Renderer = new MyMenuRenderer();
            this.LDLAppID = LDLAppID;
            TestType = testType;
            ctrlApplicaitonInfo.LoadData(LDLAppID);
            lblTitle.Content = TestType.ToString() + " " + lblTitle.Content;
            Organize_dgvAppointments();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dgvTestAppointments_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblEmpty.Visible = (!(dgvTestAppointments.Rows.Count > 0));
            lblRecords.Content = $"Records : {dgvTestAppointments.Rows.Count}";
            if ((dgvTestAppointments.Columns.Count > 0))
                Organize_dgvAppointmentsColumnsWidth();
        }

        private void btnLDLApp_Click(object sender, EventArgs e)
        {
            frmSheduleTest sheduleTest = new frmSheduleTest(TestType, LDLAppID);
            sheduleTest.ShowDialog();
            dgvAppointments_Refresh();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(dgvTestAppointments.Columns.Count > 0)) return;

            frmSheduleTest sheduleTest = new frmSheduleTest(TestType, LDLAppID, int.Parse(dgvTestAppointments.CurrentRow.Cells[0].Value.ToString()));
            sheduleTest.ShowDialog();
            dgvAppointments_Refresh();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(dgvTestAppointments.Columns.Count > 0)) return;

            frmTakeTest takeTest = new frmTakeTest(int.Parse(dgvTestAppointments.CurrentRow.Cells[0].Value.ToString()), TestType);
            takeTest.ShowDialog(); 
            dgvAppointments_Refresh();
        }
    }
}
