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

namespace DVLD_Project.Licenses.LocalDrivingLicenses
{
    public partial class frmLocalDrivingLicenseInfo : Form
    {
        public frmLocalDrivingLicenseInfo(int LicenseID)
        {
            InitializeComponent();

            if (!ctrlLocalLicenseCard1.LoadData(LicenseID))
            {
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
