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
    public partial class frmChangePassword : Form
    {
        clsUser user = new clsUser();
        int UserID;

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

        void LoadData()
        {
            user = clsUser.FindByID(UserID);

            if (user == null)
            {
                MessageBox.Show("Error while fetching user data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            lblUserID.Content = $"User ID : {user.UserID}";
            lblUsername.Content = $"Username : {user.Username}";
        }

        bool ReadyToSave()
        {
            if (string.IsNullOrEmpty(tbxOldPassword.Content)) return false;
            if (string.IsNullOrEmpty(tbxNewPassword.Content)) return false;
            if (string.IsNullOrEmpty(tbxConfirmPassword.Content)) return false;
            return true;
        }

        bool Save()
        {
            user.Password = tbxNewPassword.Content;

            return user.Save();
        }

        public frmChangePassword(int ID)
        {
            InitializeComponent();

            this.UserID = ID;
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string message = $"Are you sure you want to cancel update user? All the modifications you made will be deleted.";

            if (MessageBox.Show(message, "Cancel Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ReadyToSave())
            {
                MessageBox.Show("Ensure the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbxOldPassword.Content != user.Password)
            {
                MessageBox.Show("The old password is not correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbxNewPassword.Content == tbxOldPassword.Content)
            {
                MessageBox.Show("The new password should not be the same as the old one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Save())
            {
                MessageBox.Show("The password has been successfully updated.", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error while updating the password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxOldPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxOldPassword.Content))
            {
                tbxOldPassword.OutlineColor = Color.Red;
                tbxOldPassword.ForeColor = Color.Red;
                tbxOldPassword.PlaceholderColor = Color.Red;
                tbxOldPassword.PlaceholderText = "Required";
            }
            else if (tbxOldPassword.Content != user.Password)
            {
                tbxOldPassword.OutlineColor = Color.Red;
                tbxOldPassword.ForeColor = Color.Red;
            }
            else
            {
                tbxOldPassword.OutlineColor = Color.Gainsboro;
                tbxOldPassword.ForeColor = Color.Black;
                tbxOldPassword.PlaceholderColor = Color.DimGray;
                tbxOldPassword.PlaceholderText = "Password";
            }
        }

        private void tbxNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxNewPassword.Content))
            {
                tbxNewPassword.OutlineColor = Color.Red;
                tbxNewPassword.ForeColor = Color.Red;
                tbxNewPassword.PlaceholderColor = Color.Red;
                tbxNewPassword.PlaceholderText = "Required";
            }
            else if (tbxNewPassword.Content == user.Password)
            {
                tbxNewPassword.OutlineColor = Color.Red;
                tbxNewPassword.ForeColor = Color.Red;
            }
            else
            {
                tbxNewPassword.OutlineColor = Color.Gainsboro;
                tbxNewPassword.ForeColor = Color.Black;
                tbxNewPassword.PlaceholderColor = Color.DimGray;
                tbxNewPassword.PlaceholderText = "Password";
            }
        }

        private void tbxConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbxConfirmPassword.Content != tbxNewPassword.Content)
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

        private void btnShowOldPass_Click(object sender, EventArgs e)
        {
            OrganizeShowHidePassowrd(tbxOldPassword, btnShowOldPass);
        }

        private void btnShowNewPass_Click(object sender, EventArgs e)
        {
            OrganizeShowHidePassowrd(tbxNewPassword, btnShowNewPass);
        }

        private void btnShowConfirmPass_Click(object sender, EventArgs e)
        {
            OrganizeShowHidePassowrd(tbxConfirmPassword, btnShowConfirmPass);
        }
    }
}
