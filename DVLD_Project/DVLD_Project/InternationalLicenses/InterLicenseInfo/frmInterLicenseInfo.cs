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
    public partial class frmInterLicenseInfo : Form
    {
        public frmInterLicenseInfo(int InterLicenseID)
        {
            InitializeComponent();

            if (ctrlInterLicenseInfo1.LoadData(InterLicenseID)) return;
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
