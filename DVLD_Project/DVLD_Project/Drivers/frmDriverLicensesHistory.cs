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

namespace DVLD_Project.Drivers
{
    public partial class frmDriverLicensesHistory : Form
    {
        public frmDriverLicensesHistory(int DriverID)
        {
            InitializeComponent();

            clsDrivers driver = clsDrivers.FindByDriverID(DriverID);

            if (driver == null) { MessageBox.Show("Error while fetching driver data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }

            ctrlPersonCard1.LoadData(driver.PersonID);
            ctrlDriverLicensesHistory1.LoadDataByDriverID(driver.DriverID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
