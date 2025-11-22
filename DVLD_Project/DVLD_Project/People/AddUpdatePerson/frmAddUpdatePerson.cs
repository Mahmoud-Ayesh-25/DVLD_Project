using CuoreUI.Controls;
using DVLD_BusinessLayer;
using DVLD_Project.MainSettings;
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
    public partial class frmAddUpdatePerson : Form
    {
        public delegate void DataBackEventHandler(int PersonID);
        public event DataBackEventHandler DataBack;

        enum Modes { Add = 1, Update}
        Modes Mode = Modes.Add;

        clsPerson person = new clsPerson();

        bool ReadyToSave()
        {
            if (string.IsNullOrEmpty(tbxFirstName.Content)) return false;
            if (string.IsNullOrEmpty(tbxSecondName.Content)) return false;
            if (string.IsNullOrEmpty(tbxLastName.Content)) return false;
            if (string.IsNullOrEmpty(tbxNationalNo.Content)) return false;
            if (string.IsNullOrEmpty(tbxPhone.Content)) return false;
            if (string.IsNullOrEmpty(tbxAddress.Content)) return false;
            if (!string.IsNullOrEmpty(tbxEmail.Content))
                if (!clsValidation.IsValidEmail(tbxEmail.Content)) return false;
            return true;
        }

        void HandleImage()
        {
            if (pbxPersonImage.ImageLocation == person.ImagePath) return;

            try
            {
                File.Delete(person.ImagePath);
                person.ImagePath = "";
            }
            catch { }

            if (pbxPersonImage.ImageLocation != null)
            {
                string imagePath = pbxPersonImage.ImageLocation;
                if (clsUtil.CopyImageToImagesFolder(ref imagePath))
                {
                    person.ImagePath = imagePath;
                    pbxPersonImage.ImageLocation = imagePath;
                }
                else
                {
                    MessageBox.Show("An error occurred while saving the image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void OrganizeDataToSave()
        {
            person.NationalNo = tbxNationalNo.Content;
            person.FirstName = tbxFirstName.Content;
            person.SecondName = tbxSecondName.Content;
            person.ThirdName = tbxThirdName.Content;
            person.LastName = tbxLastName.Content;
            person.Email = tbxEmail.Content;
            person.Phone = tbxPhone.Content;
            person.Address = tbxAddress.Content;
            person.DateOfBirth = dtpDateOfBirth.Content;
            person.NationalityID = cbxNationality.SelectedIndex + 2;

            if (cbtnMale.Checked)
                person.Gendor = 0;
            else
                person.Gendor = 1;

            HandleImage();
        }

        bool Save()
        {
            OrganizeDataToSave();
            
            return person.Save();
        }

        void GetPictureForPB()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Choose a picture";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbxPersonImage.BackgroundImage = null;
                pbxPersonImage.ImageLocation = openFileDialog.FileName;
                btnDelete.Visible = true;
            }
        }

        void SetDefaultPersonImage()
        {
            if (pbxPersonImage.ImageLocation != null)
            {
                btnDelete.Visible = true;
                return;
            }

            btnDelete.Visible = false;

            if (cbtnMale.Checked == true)
                pbxPersonImage.BackgroundImage = Resources.man;
            else
                pbxPersonImage.BackgroundImage = Resources.woman;
        }

        void SetNationality(string nationalityName)
        {
            cbxNationality.SelectedItem = nationalityName;
        }

        void GetAndSetCountries()
        {
            DataTable dtCountries = clsCountries.GetAllCountries();

            if (dtCountries == null)
            {
                MessageBox.Show("An error occurred while retrieving country data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            foreach (DataRow row in dtCountries.Rows)
            {
                cbxNationality.AddItem(row[1].ToString());
            }

            if (Mode == Modes.Add)
                cbxNationality.SelectedItem = "Egypt";
            else
                cbxNationality.SelectedItem = person.Country.CountryName;
        }

        void SetPersonData()
        {
            lblID.Content = $"ID : {person.PersonID.ToString()}";
            tbxFirstName.Content = person.FirstName;
            tbxSecondName.Content = person.SecondName;
            tbxThirdName.Content = person.ThirdName;
            tbxLastName.Content = person.LastName;
            tbxNationalNo.Content = person.NationalNo;
            tbxEmail.Content = person.Email;
            tbxAddress.Content = person.Address;
            tbxPhone.Content = person.Phone;
            dtpDateOfBirth.Content = person.DateOfBirth;

            if (person.Gendor == 0)
            {
                cbtnMale.Checked = true;
                cbtnFemale.Checked = false;
            }
            else
            {
                cbtnMale.Checked = false;
                cbtnFemale.Checked = true;
            }

            if (person.ImagePath != "" &&  person.ImagePath != string.Empty)
                pbxPersonImage.ImageLocation = person.ImagePath;
        }

        void LoadDate(int ID)
        {
            person = clsPerson.Find(ID);

            if (person == null)
            {
                MessageBox.Show("An error occurred while retrieving the person's data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            lblFormLabel.Content = "Update Person";
            Mode = Modes.Update;

            SetPersonData();
        }

        public frmAddUpdatePerson()
        {
            InitializeComponent();

            pbxPersonImage.BackgroundImage = Resources.man;
        }

        public frmAddUpdatePerson(int ID)
        {
            InitializeComponent();

            LoadDate(ID);
            SetDefaultPersonImage();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string message = $"Are you sure you want to cancel \"{Mode.ToString()} Person\"? All the modifications you made will be deleted.";

            if (MessageBox.Show(message, "Cancel Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (person.PersonID != -1)
                    DataBack?.Invoke(person.PersonID);

                this.Close();
            }
        }

        private void tbxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(clsValidation.IsDigit(e.KeyChar));
        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            GetAndSetCountries();
        }

        private void btnSavePerson_Click(object sender, EventArgs e)
        {
            if (!ReadyToSave())
            {
                MessageBox.Show("Error, make sure the required fields are filled in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!clsValidation.IsValidNationalNo(tbxNationalNo.Content, person.NationalNo))
            {
                MessageBox.Show("National No is already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!clsValidation.IsValidDate(dtpDateOfBirth.Content))
            {
                MessageBox.Show($"Incorrect date, the correct date should be between {DateTime.Now.AddYears(-150)} and {DateTime.Now.AddYears(-18)}.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Save())
            {
                if (Mode == Modes.Add)
                {
                    Mode = Modes.Update;
                    lblFormLabel.Content = "Update Person";
                    lblID.Content = $"ID : {person.PersonID.ToString()}";
                }

                MessageBox.Show("The person has been successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("An error occurred while saving the person.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEditNationality_Click(object sender, EventArgs e)
        {
            frmSelectNationaliry nationality = new frmSelectNationaliry(cbxNationality.SelectedIndex);
            nationality.DataBack += SetNationality;
            nationality.ShowDialog();
        }

        private void cbtnMale_Click(object sender, EventArgs e)
        {
            cbtnMale.Checked = false;
            cbtnFemale.Checked = false;
            ((cuiButtonGroup)sender).Checked = true;
            SetDefaultPersonImage();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            GetPictureForPB();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove the picture?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pbxPersonImage.ImageLocation = null;
                SetDefaultPersonImage();
            }
        }

        private void ErrorProvider_Validating(object sender, CancelEventArgs e)
        {
            var ctrl = (cuiTextBox)sender;

            if (string.IsNullOrEmpty(ctrl.Content))
            {
                ctrl.OutlineColor = Color.Red;
                ctrl.PlaceholderText = "Required";
                ctrl.PlaceholderColor = Color.Red;
            }
            else
            {
                ctrl.OutlineColor = Color.Gainsboro;
            }
        }

        private void tbxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxEmail.Content))
            {
                tbxEmail.OutlineColor = Color.Gainsboro;
                tbxEmail.ForeColor = Color.Black;
                return;
            }

            if (clsValidation.IsValidEmail(tbxEmail.Content))
            {
                tbxEmail.OutlineColor = Color.Gainsboro;
                tbxEmail.ForeColor = Color.Black;
            }
            else
            {
                tbxEmail.OutlineColor = Color.Red;
                tbxEmail.ForeColor = Color.Red;
            }
        }

        private void tbxNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidation.IsValidNationalNo(tbxNationalNo.Content, person.NationalNo) || string.IsNullOrEmpty(tbxNationalNo.Content))
            {
                tbxNationalNo.OutlineColor = Color.Red;
                tbxNationalNo.ForeColor = Color.Red;
                tbxNationalNo.PlaceholderText = "Required";
                tbxNationalNo.PlaceholderColor = Color.Red;
            }
            else
            {
                tbxNationalNo.OutlineColor = Color.Gainsboro;
                tbxNationalNo.ForeColor = Color.Black;
            }
        }
    }
}
