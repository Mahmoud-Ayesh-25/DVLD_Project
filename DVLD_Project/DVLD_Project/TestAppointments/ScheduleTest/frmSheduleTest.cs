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

namespace DVLD_Project.TestAppointments.ScheduleTest
{
    public partial class frmSheduleTest : Form
    {
        public frmSheduleTest(frmManageTestAppointments.enTestType TestType, int LDLAppID, int TestAppointment = -1)
        {
            InitializeComponent();

            ctrlScheduleTest.TestType = TestType;
            if (!ctrlScheduleTest.LoadData(LDLAppID, TestAppointment))
            {
                MessageBox.Show("Error while fetching data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
