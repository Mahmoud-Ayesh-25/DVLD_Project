using CuoreUI.Controls;
using DVLD_BusinessLayer;
using DVLD_Project.MainSettings;
using DVLD_Project.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class frmUsers : Form
    {
        DataTable dtUsers = new DataTable();

        void dgvUsers_Refresh()
        {
            dtUsers = clsUser.GetAllUsers();
            dgvUsers.DataSource = dtUsers;
        }

        void OrganizeSizeChanged()
        {
            dgvUsers.Width = this.Width - 24;
            dgvUsers.Height = this.Height - 141;

            if (this.WindowState == FormWindowState.Normal)
            {
                btnMaximize.Image = MaximizedImgBox.Images[0];
                cuiResizeGrip.Visible = true;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                btnMaximize.Image = MaximizedImgBox.Images[1];
                cuiResizeGrip.Visible = false;
            }
        }

        void Organize_dgvUsersColumnsWidth()
        {
            dgvUsers.Columns["UserID"].Width = ((dgvUsers.Width * 14) / 100) - 4;
            dgvUsers.Columns["PersonID"].Width = ((dgvUsers.Width * 14) / 100) - 4;
            dgvUsers.Columns["PersonName"].Width = ((dgvUsers.Width * 50) / 100) - 4;
            dgvUsers.Columns["UserName"].Width = ((dgvUsers.Width * 15) / 100) - 4;
            dgvUsers.Columns["IsActive"].Width = ((dgvUsers.Width * 7) / 100) - 4;
        }

        void Organize_dgvUsers()
        {
            dtUsers = clsUser.GetAllUsers();
            dgvUsers.DataSource = dtUsers;

            if (!(dgvUsers.Columns.Count > 0)) return;

            dgvUsers.Columns["UserID"].HeaderText = "ID";
            dgvUsers.Columns["PersonID"].HeaderText = "Person ID";
            dgvUsers.Columns["PersonName"].HeaderText = "Person Name";
            dgvUsers.Columns["UserName"].HeaderText = "Username";
            dgvUsers.Columns["IsActive"].HeaderText = "Is Active";

            Organize_dgvUsersColumnsWidth();
        }

        void FilterApplied()
        {
            if (tbxFilter.Content != string.Empty)
            {
                DataView view = dtUsers.DefaultView;
                if (cbxFilter.SelectedIndex == 2 || cbxFilter.SelectedIndex == 4)
                {
                    view.RowFilter = $"{dtUsers.Columns[cbxFilter.SelectedIndex - 1].ColumnName} LIKE '{tbxFilter.Content}%'";
                }
                else if (cbxFilter.SelectedIndex == 1 || cbxFilter.SelectedIndex == 3)
                {
                    view.RowFilter = $"{dtUsers.Columns[cbxFilter.SelectedIndex - 1].ColumnName} = {tbxFilter.Content}";
                }
            }
            else
            {
                dgvUsers_Refresh();
            }
        }

        void ActiveFilterApplied()
        {
            if (cbxActive.SelectedIndex != 2)
            {
                DataView view = dtUsers.DefaultView;
                view.RowFilter = $"IsActive = {cbxActive.SelectedIndex}";
            }
            else dgvUsers_Refresh();
        }

        public frmUsers()
        {
            InitializeComponent();

            cxmUsers.Renderer = new MyMenuRenderer();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            Organize_dgvUsers();
            lblEmpty.Parent = dgvUsers;
        }

        private void dgvUsers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblEmpty.Visible = !(dgvUsers.Rows.Count > 0);
            lblRecords.Content = $"Records : {dgvUsers.Rows.Count}";
            if ((dgvUsers.Columns.Count > 0))
                Organize_dgvUsersColumnsWidth();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void frmUsers_SizeChanged(object sender, EventArgs e)
        {
            OrganizeSizeChanged();

            if (dgvUsers.Columns.Count > 0)
                Organize_dgvUsersColumnsWidth();
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvUsers_Refresh();

            tbxFilter.Visible = !(cbxFilter.SelectedIndex == 0 || cbxFilter.SelectedIndex == 5);
            cbxActive.Visible = (cbxFilter.SelectedIndex != 0 && cbxFilter.SelectedIndex == 5);
        }

        private void tbxFilter_ContentChanged(object sender, EventArgs e)
        {
            if (!(dgvUsers.Columns.Count > 0)) return;

            FilterApplied();
        }

        private void cbxActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(dgvUsers.Columns.Count > 0)) return;
            
            ActiveFilterApplied();
        }

        private void tbxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbxFilter.SelectedIndex == 1 || cbxFilter.SelectedIndex == 3)
            {
                if (!clsValidation.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(dgvUsers.Columns.Count > 0)) return;

            frmUserInfo userInfo = new frmUserInfo(int.Parse(dgvUsers.CurrentRow.Cells[0].Value.ToString()));
            userInfo.ShowDialog();
            dgvUsers_Refresh();
        }

        private void dgvUsers_DoubleClick(object sender, EventArgs e)
        {
            if (!(dgvUsers.Columns.Count > 0)) return;

            frmUserInfo userInfo = new frmUserInfo(int.Parse(dgvUsers.CurrentRow.Cells[0].Value.ToString()));
            userInfo.ShowDialog();
            dgvUsers_Refresh();
        }

        private void dgvUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!(dgvUsers.Columns.Count > 0)) return;

                frmUserInfo userInfo = new frmUserInfo(int.Parse(dgvUsers.CurrentRow.Cells[0].Value.ToString()));
                userInfo.ShowDialog();
                dgvUsers_Refresh();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(dgvUsers.Columns.Count > 0)) return;

            if (MessageBox.Show($"Are you sure you want to delete the user with ID [{int.Parse(dgvUsers.CurrentRow.Cells[0].Value.ToString())}].", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsUser.DeleteUser(int.Parse(dgvUsers.CurrentRow.Cells[0].Value.ToString())))
                {
                    MessageBox.Show("The user has been successfully deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvUsers_Refresh();
                }
                else
                {
                    MessageBox.Show("This user cannot be deleted because it is linked to data in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Deletion of the user has been canceled.", "Deletion canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frmAddUser = new frmAddUpdateUser();
            frmAddUser.ShowDialog();
            dgvUsers_Refresh();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frmAddUser = new frmAddUpdateUser();
            frmAddUser.ShowDialog();
            dgvUsers_Refresh();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(dgvUsers.Rows.Count > 0)) return;

            frmAddUpdateUser updateUser = new frmAddUpdateUser(int.Parse(dgvUsers.CurrentRow.Cells[0].Value.ToString()));
            updateUser.ShowDialog();
            dgvUsers_Refresh();
        }

        private void changepassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(dgvUsers.Rows.Count > 0)) return;

            frmChangePassword updateUser = new frmChangePassword(int.Parse(dgvUsers.CurrentRow.Cells[0].Value.ToString()));
            updateUser.ShowDialog();
        }
    }
}
