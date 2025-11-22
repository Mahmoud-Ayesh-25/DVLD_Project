using CuoreUI.Controls;
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

namespace DVLD_Project.Applications
{
    public partial class frmManageApplicationTypes : Form
    {
        DataTable dtAppTypes = new DataTable();

        void dgvAppTypes_Refresh()
        {
            dtAppTypes = clsApplicationTypes.GetAllApplicationTypes();
            dgvAppTypes.DataSource = dtAppTypes;
        }

        void OrganizeSizeChanged()
        {
            dgvAppTypes.Width = this.Width - 24;
            dgvAppTypes.Height = this.Height - 84;

            if (this.WindowState == FormWindowState.Normal)
            {
                btnMaximize.Image = MaximizedImgBox.Images[0];
                cuiResizeGrip1.Visible = true;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                btnMaximize.Image = MaximizedImgBox.Images[1];
                cuiResizeGrip1.Visible = false;
            }
        }

        void Ordanize_dgvAppTypesColumnsWidth()
        {
            dgvAppTypes.Columns["ApplicationTypeID"].Width = ((dgvAppTypes.Width * 10)/100);
            dgvAppTypes.Columns["ApplicationTypeTitle"].Width = ((dgvAppTypes.Width * 75) / 100) - 20;
            dgvAppTypes.Columns["ApplicationFees"].Width = ((dgvAppTypes.Width * 15) / 100);
        }

        void Ordanize_dgvAppTypes()
        {
            dtAppTypes = clsApplicationTypes.GetAllApplicationTypes();

            dgvAppTypes.DataSource = dtAppTypes;

            if (dgvAppTypes.Rows.Count <= 0) return;

            dgvAppTypes.Columns["ApplicationTypeID"].HeaderText = "ID";
            dgvAppTypes.Columns["ApplicationTypeTitle"].HeaderText = "Title";
            dgvAppTypes.Columns["ApplicationFees"].HeaderText = "Fees";

            Ordanize_dgvAppTypesColumnsWidth();
        }

        public frmManageApplicationTypes()
        {
            InitializeComponent();

            lblEmpty.Parent = dgvAppTypes;
            Ordanize_dgvAppTypes();
            cxmAppTypes.Renderer = new MyMenuRenderer();
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

        private void dgvAppTypes_SizeChanged(object sender, EventArgs e)
        {
            OrganizeSizeChanged();
            
            if (dgvAppTypes.Columns.Count > 0 )
            {
                Ordanize_dgvAppTypesColumnsWidth();
            }
        }

        private void dgvAppTypes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblRecords.Content = $"Records : {dgvAppTypes.RowCount}";
            lblEmpty.Visible = (!(dgvAppTypes.Rows.Count > 0));
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateApplicationType updateApplicationType = new frmUpdateApplicationType(int.Parse(dgvAppTypes.CurrentRow.Cells[0].Value.ToString()));
            updateApplicationType.ShowDialog();
            dgvAppTypes_Refresh();
        }
    }
}
