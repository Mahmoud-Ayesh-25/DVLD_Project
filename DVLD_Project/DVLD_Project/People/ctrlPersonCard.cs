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

namespace DVLD_Project
{
    public partial class ctrlPersonCard : UserControl
    {
        clsPerson person = new clsPerson();

        public int PersonID { get { return person.PersonID; } }
        public clsPerson Person { get { return person; } }

        public void LoadData(int ID)
        {
            if (ID == -1)
            {
                LoadDefaultData();
                return;
            }

            person = clsPerson.Find(ID);

            if (person != null)
                OrganizeControlsData();
            else
            {
                MessageBox.Show("The person's data was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                person = new clsPerson();
                LoadDefaultData();
            }
        }

        public void LoadData(string NationalNo)
        {
            person = clsPerson.Find(NationalNo);

            if (person != null)
                OrganizeControlsData();
            else
            {
                MessageBox.Show("The person's data was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                person = new clsPerson();
                LoadDefaultData();
            }
        }

        void SetImage()
        {
            pbxPersonImage.ImageLocation = null;

            if (person.Gendor == 0)
                pbxPersonImage.BackgroundImage = Resources.man;
            else
                pbxPersonImage.BackgroundImage = Resources.woman;

            if (!string.IsNullOrEmpty(person.ImagePath))
            {
                if (File.Exists(person.ImagePath))
                {
                    pbxPersonImage.BackgroundImage = null;
                    pbxPersonImage.ImageLocation = person.ImagePath;
                }
            }
        }

        void OrganizeControlsData()
        {
            lblID.Content = $"ID : {person.PersonID}";
            lblName.Content = $"Name : {person.FullName}";
            lblNationalNo.Content = $"National No : {person.NationalNo}";
            lblEmail.Content = $"Email : {person.Email}";
            lblAddress.Content = $"Address : {person.Address}";
            lblPhone.Content = $"Phone : {person.Phone}";
            lblNationality.Content = $"Nationality : {person.Country.CountryName}";
            lblDateOfBirth.Content = $"Date Of Birth : {person.DateOfBirth.ToLongDateString()}";

            if (person.Gendor == 0)
                lblGendor.Content = "Gendor : Male";
            else
                lblGendor.Content = "Gendor : Female";

            SetImage();
        }

        public void LoadDefaultData()
        {
            person = new clsPerson();

            lblID.Content = $"ID :";
            lblName.Content = $"Name :";
            lblNationalNo.Content = $"National No :";
            lblEmail.Content = $"Email :";
            lblAddress.Content = $"Address :";
            lblPhone.Content = $"Phone :";
            lblNationality.Content = $"Nationality :";
            lblDateOfBirth.Content = $"Date Of Birth :";
            lblGendor.Content = "Gendor :";
            SetImage();
        }

        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            if (PersonID < 0) return;

            frmAddUpdatePerson frmAddUpdate = new frmAddUpdatePerson(PersonID);
            frmAddUpdate.ShowDialog();
            LoadData(PersonID);
        }
    }
}
