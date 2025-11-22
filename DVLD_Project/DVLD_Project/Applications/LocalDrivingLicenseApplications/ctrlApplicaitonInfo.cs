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

namespace DVLD_Project.Applications.LocalDrivingLicenseApplications
{
    public partial class ctrlApplicaitonInfo : UserControl
    {
        clsLocalDrivingLicenseApplication app = new clsLocalDrivingLicenseApplication();

        public int BaseApplicaitonID { get { return app.GAppID; } }

        public bool LoadData(int ID)
        {
            app = clsLocalDrivingLicenseApplication.FindByLDLAppID(ID);

            if (app == null) return false;

            return (ctrlLDLApplicationInfo.LoadData(ID) && ctrlBaseApplicationInfo.LoadData(app.GAppID));
        }

        public void LoadDefaultData()
        {
            ctrlLDLApplicationInfo.LoadDefaultData();
            ctrlBaseApplicationInfo.LoadDefaultData();
        }

        public ctrlApplicaitonInfo()
        {
            InitializeComponent();
        }
    }
}
