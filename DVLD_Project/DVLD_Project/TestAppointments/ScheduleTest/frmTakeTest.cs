using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD_Project.TestAppointments.frmManageTestAppointments;

namespace DVLD_Project.TestAppointments.ScheduleTest
{
    public partial class frmTakeTest : Form
    {
        int TestAppointment = -1;
        frmManageTestAppointments.enTestType TestType = enTestType.Vision;

        clsTests test = new clsTests();

        void LoadData(int TestAppointmentID, frmManageTestAppointments.enTestType TestType)
        {
            ctrlSheduledTest.TestType = TestType;

            if (!ctrlSheduledTest.LoadData(TestAppointmentID))
            {
                MessageBox.Show("Error while fetching data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            if (ctrlSheduledTest.TestID != -1)
            {
                test = clsTests.Find(ctrlSheduledTest.TestID);
                cbtnPass.Enabled = false;
                cbtnFail.Enabled = false;
                lblMessage.Visible = true;
                tbxNotes.Content = test.TestNotes;

                if (test.TestResult)
                {
                    cbtnPass.Checked = true;
                    cbtnFail.Checked = false;
                }
                else
                {
                    cbtnPass.Checked = false;
                    cbtnFail.Checked = true;
                }
            }
        }

        public frmTakeTest(int TestAppointmentID, frmManageTestAppointments.enTestType TestType)
        {
            InitializeComponent();

            this.TestAppointment = TestAppointmentID;
            this.TestType = TestType;

            LoadData(TestAppointmentID, TestType);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save the test?", "Save Confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No) return;

            if (cbtnPass.Checked)
                test.TestResult = true;
            else
                test.TestResult = false;

            test.TestNotes = tbxNotes.Content;
            test.TestAppointmentID = TestAppointment;
            test.CreatedByUserID = clsSettings.CurrentUser.UserID;

            if (test.Save())
            {
                LoadData(TestAppointment, TestType);
                MessageBox.Show("The test has been successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error while saving the test", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
