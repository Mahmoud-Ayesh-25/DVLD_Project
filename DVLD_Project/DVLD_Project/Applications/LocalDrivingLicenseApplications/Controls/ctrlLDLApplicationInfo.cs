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

namespace DVLD_Project.Applications.LocalDrivingLicenseApplications.Controls
{
    public partial class ctrlLDLApplicationInfo : UserControl
    {
        clsLocalDrivingLicenseApplication app = new clsLocalDrivingLicenseApplication();

        public bool LoadData(int ID)
        {
            app = clsLocalDrivingLicenseApplication.FindByLDLAppID(ID);

            if (app == null) return false;

            lblID.Content += ID;
            lblLicenseClass.Content += clsLicenseClasses.Find(app.LicenseClassID).ClassName;
            lblPassedTests.Content += clsTests.GetPassedTestCount(app.LDLAppID) + "/3";

            return true;
        }

        public void LoadDefaultData()
        {
            lblID.Content = "ID : ";
            lblLicenseClass.Content = "License Class : ";
            lblPassedTests.Content = "Passed Tests : ";
        }

        public ctrlLDLApplicationInfo()
        {
            InitializeComponent();
        }

        private void btnLicenseInfo_Click(object sender, EventArgs e)
        {
            LoadDefaultData();
            LoadData(app.LDLAppID);
        }
    }
}
