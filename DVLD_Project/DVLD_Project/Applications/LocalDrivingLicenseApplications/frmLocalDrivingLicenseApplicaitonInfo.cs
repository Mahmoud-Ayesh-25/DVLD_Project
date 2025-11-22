using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Applications.LocalDrivingLicenseApplications
{
    public partial class frmLocalDrivingLicenseApplicaitonInfo : Form
    {
        void LoadData(int ID)
        {
            if (!ctrlApplicaitonInfo.LoadData(ID))
            {
                MessageBox.Show("An error occurred while retrieving the data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        void LoadDefaultData()
        {
            ctrlApplicaitonInfo.LoadDefaultData();
        }

        public frmLocalDrivingLicenseApplicaitonInfo()
        {
            InitializeComponent();
            LoadDefaultData();
        }

        public frmLocalDrivingLicenseApplicaitonInfo(int ID)
        {
            InitializeComponent();
            LoadData(ID);
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
