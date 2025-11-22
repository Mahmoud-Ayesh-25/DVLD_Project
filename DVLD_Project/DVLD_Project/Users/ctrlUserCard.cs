using DVLD_BusinessLayer;
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
    public partial class ctrlUserCard : UserControl
    {
        public int UserID { get; set; }
        public clsUser User { get; set; }

        public void LoadData(int ID)
        {
            User = clsUser.FindByID(ID);

            if (User !=  null )
            {
                UserID = ID;

                lblID.Content = $"ID : {ID}";
                lblUsername.Content = $"Username : {User.Username}";

                if (User.IsActive)
                    lblIsActive.Content = $"Is Active : Yes";
                else
                    lblIsActive.Content = $"Is Active : No";
            }
        }

        public ctrlUserCard()
        {
            InitializeComponent();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser updateUser = new frmAddUpdateUser(UserID);
            updateUser.ShowDialog();
        }
    }
}
