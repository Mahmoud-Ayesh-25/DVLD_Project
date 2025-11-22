using DVLD_BusinessLayer;
using DVLD_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.InternationalLicenses
{
    public partial class ctrlInterLicenseInfo : UserControl
    {
        int InterLicenseID = -1;
        clsInternationalLicense InterLicense = new clsInternationalLicense();

        public int InternationalLicenseID { get { return InterLicenseID; } }
        public clsInternationalLicense InternationalLicense { get { return InterLicense; } }

        void LoadImage()
        {
            if (InterLicense.DriverInfo.Person.Gendor == 0)
                pbxPersonImage.BackgroundImage = Resources.man;
            else
                pbxPersonImage.BackgroundImage = Resources.woman;

            string imagePath = InterLicense.DriverInfo.Person.ImagePath;

            if (!string.IsNullOrEmpty(imagePath))
            {
                if (File.Exists(imagePath))
                {
                    pbxPersonImage.BackgroundImage = null;
                    pbxPersonImage.ImageLocation = imagePath;
                }
            }
        }

        public void LoadDefaultData()
        {
            lblName.Content = $"Name : ";
            lblInterLicenseID.Content = $"Inter License ID : ";
            lblLicenseID.Content = $"License ID : ";
            lblNationalNo.Content = $"National No. : ";
            lblGendor.Content = $"Gender : ";
            lblIssueDate.Content = $"Issue Date : ";
            lblAppID.Content = $"Application ID : ";
            lblIsAvtive.Content = $"Is Active : ";
            lblDateOfBirth.Content = $"Date Of Birth : ";
            lblDriverID.Content = $"Driver ID : ";
            lblExpDate.Content = $"Exp Date : ";
        }

        public bool LoadData(int InterLicenseID)
        {
            InterLicense = clsInternationalLicense.FindInterLicense(InterLicenseID);

            if (InterLicense == null)
            {
                MessageBox.Show("Error while fetching license data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            this.InterLicenseID = InterLicense.InternationalLicenseID;

            lblName.Content = $"Name : {InterLicense.DriverInfo.Person.FullName}";
            lblInterLicenseID.Content = $"Inter License ID : {this.InterLicenseID}";
            lblLicenseID.Content = $"License ID : {InterLicense.IssuedUsingLocalLicenseID}";
            lblNationalNo.Content = $"National No. : {InterLicense.DriverInfo.Person.NationalNo}";
            lblGendor.Content = $"Gender : {((InterLicense.DriverInfo.Person.Gendor == 0)? "Male" : "Female")}";
            lblIssueDate.Content = $"Issue Date : {InterLicense.IssueDate.ToShortDateString()}";
            lblAppID.Content = $"Application ID : {InterLicense.GAppID}";
            lblIsAvtive.Content = $"Is Active : {((InterLicense.IsActive == true)? "Yes" : "No")}";
            lblDateOfBirth.Content = $"Date Of Birth : {InterLicense.DriverInfo.Person.DateOfBirth.ToShortDateString()}";
            lblDriverID.Content = $"Driver ID : {InterLicense.DriverID}";
            lblExpDate.Content = $"Exp Date : {InterLicense.ExpirationDate.ToShortDateString()}";

            LoadImage();

            return true;
        }

        public ctrlInterLicenseInfo()
        {
            InitializeComponent();
        }
    }
}
