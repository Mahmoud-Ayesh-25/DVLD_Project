using CuoreUI.Controls;
using DVLD_BusinessLayer;
using DVLD_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Users
{
    public partial class frmAddUpdateUser : Form
    {
        enum enMode { Add = 1, Update}
        enMode Mode = new enMode();

        clsUser user = new clsUser();

        bool ReadyToSave()
        {
            if (string.IsNullOrEmpty(tbxUsername.Content)) return false;
            if (Mode == enMode.Add)
            {
                if (string.IsNullOrEmpty(tbxPassword.Content)) return false;
                if (tbxPassword.Content != tbxPassword.Content) return false;
            }
            if (Mode == enMode.Update)
            {
                if (string.IsNullOrEmpty(tbxCurrentPassword.Content)) return false;
            }
            return true;
        }

        bool Save()
        {
            if (!ReadyToSave())
            {
                MessageBox.Show("Ensure the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            user.PersonID = ctrlFindPerson.PersonID;
            user.Username = tbxUsername.Content;
            if (Mode == enMode.Add)
            {
                user.Password = tbxPassword.Content;
            }
            user.IsActive = schActive.Checked;

            return user.Save();
        }

        void DisableControlsWhenUpdate()
        {
            ctrlFindPerson.Enabled = false;
            tbxPassword.Visible = false;
            tbxConfirmPassword.Visible = false;
            btnShowPass.Visible = false;
            btnShowConfirmPass.Visible = false;
            cuiPictureBox1.Visible = false;

            tbxCurrentPassword.Visible = true;
            btnShowCurrentPass.Visible = true;
            btnChangePassword.Visible = true;
        }

        void LoadData(int ID)
        {
            user = clsUser.FindByID(ID);

            ctrlFindPerson.FindByPersonID(user.PersonID);
            DisableControlsWhenUpdate();
            pnlUserDetails.BringToFront();

            lblUserID.Content = $"User ID : {user.UserID}";
            tbxUsername.Content = user.Username;
            schActive.Checked = user.IsActive;
        }

        void OrganizeShowHidePassowrd(cuiTextBox tbx, cuiButton btn)
        {
            if (tbx.PasswordChar)
            {
                tbx.PasswordChar = false;
                btn.Image = Resources.hide_layer;
            }
            else
            {
                tbx.PasswordChar = true;
                btn.Image = Resources.show__1_;
            }
        }

        public frmAddUpdateUser()
        {
            InitializeComponent();

            Mode = enMode.Add;
            lblTitle.Content = "Add User";
        }

        public frmAddUpdateUser(int ID)
        {
            InitializeComponent();

            Mode = enMode.Update;
            lblTitle.Content = "Update User";

            LoadData(ID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string message = $"Are you sure you want to cancel {Mode.ToString()} user? All the modifications you made will be deleted.";

            if (MessageBox.Show(message, "Cancel Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Mode == enMode.Update)
            {
                pnlUserDetails.BringToFront();
                return;
            }

            if (ctrlFindPerson.PersonID != -1)
            {
                if (!clsUser.IsExistByPersonID(ctrlFindPerson.PersonID))
                {
                    pnlUserDetails.BringToFront();
                }
                else
                {
                    MessageBox.Show("This person is already a user.", "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("You must choose a person first.", "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlFindUser.BringToFront();
        }

        private void tbxUsername_Validating(object sender, CancelEventArgs e)
        {
            if (Mode == enMode.Update)
            {
                if (tbxUsername.Content == user.Username)
                {
                    tbxUsername.OutlineColor = Color.Gainsboro;
                    tbxUsername.ForeColor = Color.Black;
                    tbxUsername.PlaceholderColor = Color.DimGray;
                    tbxUsername.PlaceholderText = "Username";
                    return;
                }
            }

            if (string.IsNullOrEmpty(tbxUsername.Content))
            {
                tbxUsername.OutlineColor = Color.Red;
                tbxUsername.ForeColor = Color.Red;
                tbxUsername.PlaceholderColor = Color.Red;
                tbxUsername.PlaceholderText = "Required";
            }
            else if (clsUser.IsExist(tbxUsername.Content))
            {
                tbxUsername.OutlineColor = Color.Red;
                tbxUsername.ForeColor = Color.Red;
            }
            else
            {
                tbxUsername.OutlineColor = Color.Gainsboro;
                tbxUsername.ForeColor = Color.Black;
                tbxUsername.PlaceholderColor = Color.DimGray;
                tbxUsername.PlaceholderText = "Username";
            }
        }

        private void tbxPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPassword.Content))
            {
                tbxPassword.OutlineColor = Color.Red;
                tbxPassword.ForeColor = Color.Red;
                tbxPassword.PlaceholderColor = Color.Red;
                tbxPassword.PlaceholderText = "Required";
            }
            else
            {
                tbxPassword.OutlineColor = Color.Gainsboro;
                tbxPassword.ForeColor = Color.Black;
                tbxPassword.PlaceholderColor = Color.DimGray;
                tbxPassword.PlaceholderText = "Password";
            }
        }

        private void tbxConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbxConfirmPassword.Content != tbxPassword.Content)
            {
                tbxConfirmPassword.OutlineColor = Color.Red;
                tbxConfirmPassword.ForeColor = Color.Red;
                tbxConfirmPassword.PlaceholderColor = Color.Red;
                tbxConfirmPassword.PlaceholderText = "Not Identical";
            }
            else
            {
                tbxConfirmPassword.OutlineColor = Color.Gainsboro;
                tbxConfirmPassword.ForeColor = Color.Black;
                tbxConfirmPassword.PlaceholderColor = Color.DimGray;
                tbxConfirmPassword.PlaceholderText = "Confirm Password";
            }
        }

        private void tbxCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxCurrentPassword.Content))
            {
                tbxCurrentPassword.OutlineColor = Color.Red;
                tbxCurrentPassword.ForeColor = Color.Red;
                tbxCurrentPassword.PlaceholderColor = Color.Red;
                tbxCurrentPassword.PlaceholderText = "Required";
            }
            if (tbxCurrentPassword.Content != user.Password)
            {
                tbxCurrentPassword.OutlineColor = Color.Red;
                tbxCurrentPassword.ForeColor = Color.Red;
            }
            else
            {
                tbxCurrentPassword.OutlineColor = Color.Gainsboro;
                tbxCurrentPassword.ForeColor = Color.Black;
                tbxCurrentPassword.PlaceholderColor = Color.DimGray;
                tbxCurrentPassword.PlaceholderText = "Current Password";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Mode == enMode.Update)
            {
                if (tbxCurrentPassword.Content != user.Password)
                {
                    MessageBox.Show("Incorrect password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (tbxUsername.Content != user.Username)
            {
                if (clsUser.IsExist(tbxUsername.Content))
                {
                    MessageBox.Show("This username is already in use.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (Save())
            {
                if (Mode == enMode.Add)
                {
                    lblUserID.Content = $"User ID : {user.UserID}";
                    lblTitle.Content = "Update User";
                    Mode = enMode.Update;
                    DisableControlsWhenUpdate();
                }
                MessageBox.Show("The user has been successfully saved.", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error while saving the user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            OrganizeShowHidePassowrd(tbxPassword, btnShowPass);
        }

        private void btnShowCurrentPass_Click(object sender, EventArgs e)
        {
            OrganizeShowHidePassowrd(tbxCurrentPassword, btnShowCurrentPass);
        }

        private void btnShowConfirmPass_Click(object sender, EventArgs e)
        {
            OrganizeShowHidePassowrd(tbxConfirmPassword, btnShowConfirmPass);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword changePass = new frmChangePassword(user.UserID);
            changePass.ShowDialog();
            LoadData(user.UserID);
        }
    }
}
