namespace DVLD_Project
{
    partial class frmSelectNationaliry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCountries = new System.Windows.Forms.DataGridView();
            this.tbxFilter = new CuoreUI.Controls.cuiTextBox();
            this.btnClose = new CuoreUI.Controls.cuiButton();
            this.btnConfirm = new CuoreUI.Controls.cuiButton();
            this.cuiFormRounder = new CuoreUI.Components.cuiFormRounder();
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.cuiFormAnimator = new CuoreUI.Components.cuiFormAnimator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountries)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCountries
            // 
            this.dgvCountries.AllowUserToAddRows = false;
            this.dgvCountries.AllowUserToDeleteRows = false;
            this.dgvCountries.AllowUserToResizeColumns = false;
            this.dgvCountries.AllowUserToResizeRows = false;
            this.dgvCountries.BackgroundColor = System.Drawing.Color.White;
            this.dgvCountries.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCountries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCountries.ColumnHeadersHeight = 25;
            this.dgvCountries.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCountries.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCountries.EnableHeadersVisualStyles = false;
            this.dgvCountries.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvCountries.Location = new System.Drawing.Point(12, 83);
            this.dgvCountries.MultiSelect = false;
            this.dgvCountries.Name = "dgvCountries";
            this.dgvCountries.ReadOnly = true;
            this.dgvCountries.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCountries.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCountries.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCountries.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCountries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCountries.Size = new System.Drawing.Size(176, 317);
            this.dgvCountries.TabIndex = 1;
            this.dgvCountries.DoubleClick += new System.EventHandler(this.dgvCountries_DoubleClick);
            this.dgvCountries.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCountries_KeyDown);
            // 
            // tbxFilter
            // 
            this.tbxFilter.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tbxFilter.Content = "";
            this.tbxFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxFilter.FocusBackgroundColor = System.Drawing.Color.White;
            this.tbxFilter.FocusImageTint = System.Drawing.Color.White;
            this.tbxFilter.FocusOutlineColor = System.Drawing.Color.Black;
            this.tbxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFilter.ForeColor = System.Drawing.Color.Black;
            this.tbxFilter.Image = null;
            this.tbxFilter.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxFilter.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxFilter.Location = new System.Drawing.Point(13, 44);
            this.tbxFilter.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFilter.Multiline = false;
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.NormalImageTint = System.Drawing.Color.DimGray;
            this.tbxFilter.OutlineColor = System.Drawing.Color.Gainsboro;
            this.tbxFilter.Padding = new System.Windows.Forms.Padding(15, 9, 15, 0);
            this.tbxFilter.PasswordChar = false;
            this.tbxFilter.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxFilter.PlaceholderText = "Search...";
            this.tbxFilter.Rounding = new System.Windows.Forms.Padding(15);
            this.tbxFilter.Size = new System.Drawing.Size(175, 32);
            this.tbxFilter.TabIndex = 19;
            this.tbxFilter.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxFilter.UnderlinedStyle = false;
            this.tbxFilter.ContentChanged += new System.EventHandler(this.tbxFirstName_ContentChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.CheckButton = false;
            this.btnClose.Checked = false;
            this.btnClose.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnClose.CheckedForeColor = System.Drawing.Color.White;
            this.btnClose.CheckedImageTint = System.Drawing.Color.White;
            this.btnClose.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnClose.Content = "";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.HoverForeColor = System.Drawing.Color.Black;
            this.btnClose.HoverImageTint = System.Drawing.Color.White;
            this.btnClose.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.cancel;
            this.btnClose.ImageAutoCenter = true;
            this.btnClose.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.Location = new System.Drawing.Point(163, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.NormalBackground = System.Drawing.Color.White;
            this.btnClose.NormalForeColor = System.Drawing.Color.Black;
            this.btnClose.NormalImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.OutlineThickness = 1F;
            this.btnClose.PressedBackground = System.Drawing.Color.Maroon;
            this.btnClose.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnClose.PressedImageTint = System.Drawing.Color.White;
            this.btnClose.PressedOutline = System.Drawing.Color.Maroon;
            this.btnClose.Rounding = new System.Windows.Forms.Padding(12);
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 20;
            this.btnClose.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnClose.TextOffset = new System.Drawing.Point(0, 0);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.CheckButton = false;
            this.btnConfirm.Checked = false;
            this.btnConfirm.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnConfirm.CheckedForeColor = System.Drawing.Color.White;
            this.btnConfirm.CheckedImageTint = System.Drawing.Color.White;
            this.btnConfirm.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnConfirm.Content = "Confirm";
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnConfirm.ForeColor = System.Drawing.Color.DimGray;
            this.btnConfirm.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnConfirm.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnConfirm.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnConfirm.HoverOutline = System.Drawing.Color.DimGray;
            this.btnConfirm.Image = global::DVLD_Project.Properties.Resources.approve;
            this.btnConfirm.ImageAutoCenter = true;
            this.btnConfirm.ImageExpand = new System.Drawing.Point(1, 1);
            this.btnConfirm.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnConfirm.Location = new System.Drawing.Point(12, 406);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnConfirm.NormalForeColor = System.Drawing.Color.DimGray;
            this.btnConfirm.NormalImageTint = System.Drawing.Color.DimGray;
            this.btnConfirm.NormalOutline = System.Drawing.Color.Transparent;
            this.btnConfirm.OutlineThickness = 1F;
            this.btnConfirm.PressedBackground = System.Drawing.Color.LightGray;
            this.btnConfirm.PressedForeColor = System.Drawing.Color.DimGray;
            this.btnConfirm.PressedImageTint = System.Drawing.Color.DimGray;
            this.btnConfirm.PressedOutline = System.Drawing.Color.DimGray;
            this.btnConfirm.Rounding = new System.Windows.Forms.Padding(15);
            this.btnConfirm.Size = new System.Drawing.Size(176, 32);
            this.btnConfirm.TabIndex = 18;
            this.btnConfirm.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnConfirm.TextOffset = new System.Drawing.Point(2, 0);
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cuiFormRounder
            // 
            this.cuiFormRounder.OutlineColor = System.Drawing.Color.Silver;
            this.cuiFormRounder.Rounding = 8;
            this.cuiFormRounder.TargetForm = this;
            // 
            // cuiFormDrag
            // 
            this.cuiFormDrag.TargetForm = this;
            // 
            // cuiFormAnimator
            // 
            this.cuiFormAnimator.AnimateOnStart = true;
            this.cuiFormAnimator.Duration = 150;
            this.cuiFormAnimator.EasingType = CuoreUI.Drawing.EasingTypes.QuadIn;
            this.cuiFormAnimator.StartOpacity = 0D;
            this.cuiFormAnimator.TargetForm = this;
            this.cuiFormAnimator.TargetOpacity = 1D;
            // 
            // frmSelectNationaliry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(200, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dgvCountries);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSelectNationaliry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSelectNationaliry";
            this.Load += new System.EventHandler(this.frmSelectNationaliry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCountries;
        private CuoreUI.Controls.cuiButton btnConfirm;
        private CuoreUI.Controls.cuiTextBox tbxFilter;
        private CuoreUI.Controls.cuiButton btnClose;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
        private CuoreUI.Components.cuiFormAnimator cuiFormAnimator;
    }
}