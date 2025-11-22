namespace DVLD_Project.DetainedLicenses
{
    partial class frmManageDetainedLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageDetainedLicenses));
            this.lblEmpty = new CuoreUI.Controls.cuiLabel();
            this.tbxFilter = new CuoreUI.Controls.cuiTextBox();
            this.cbxFilter = new CuoreUI.Controls.cuiComboBox();
            this.lblRecords = new CuoreUI.Controls.cuiLabel();
            this.dgvDLicenses = new System.Windows.Forms.DataGridView();
            this.cxmDLicenses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuiResizeGrip = new CuoreUI.Controls.cuiResizeGrip();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.btnRLicense = new CuoreUI.Controls.cuiButton();
            this.btnDLicense = new CuoreUI.Controls.cuiButton();
            this.btnClose = new CuoreUI.Controls.cuiButton();
            this.btnMinimize = new CuoreUI.Controls.cuiButton();
            this.btnMaximize = new CuoreUI.Controls.cuiButton();
            this.cuiFormAnimator = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.cuiFormRounder = new CuoreUI.Components.cuiFormRounder();
            this.MaximizedImgBox = new System.Windows.Forms.ImageList(this.components);
            this.cbxIsReleased = new CuoreUI.Controls.cuiComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDLicenses)).BeginInit();
            this.cxmDLicenses.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmpty
            // 
            this.lblEmpty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmpty.Content = "Empty";
            this.lblEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpty.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblEmpty.Location = new System.Drawing.Point(387, 230);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(426, 101);
            this.lblEmpty.TabIndex = 39;
            this.lblEmpty.VerticalAlignment = System.Drawing.StringAlignment.Center;
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
            this.tbxFilter.Location = new System.Drawing.Point(178, 71);
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
            this.tbxFilter.Size = new System.Drawing.Size(222, 32);
            this.tbxFilter.TabIndex = 31;
            this.tbxFilter.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxFilter.UnderlinedStyle = false;
            this.tbxFilter.Visible = false;
            this.tbxFilter.ContentChanged += new System.EventHandler(this.tbxFilter_ContentChanged);
            this.tbxFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFilter_KeyPress);
            // 
            // cbxFilter
            // 
            this.cbxFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbxFilter.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.cbxFilter.ButtonCursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxFilter.ButtonHoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.cbxFilter.ButtonHoverOutline = System.Drawing.Color.Transparent;
            this.cbxFilter.ButtonNormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.cbxFilter.ButtonNormalOutline = System.Drawing.Color.Empty;
            this.cbxFilter.ButtonPressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.cbxFilter.ButtonPressedOutline = System.Drawing.Color.Empty;
            this.cbxFilter.DropDownBackgroundColor = System.Drawing.Color.Transparent;
            this.cbxFilter.DropDownOutlineColor = System.Drawing.Color.Transparent;
            this.cbxFilter.ExpandArrowColor = System.Drawing.Color.DimGray;
            this.cbxFilter.ForeColor = System.Drawing.Color.DimGray;
            this.cbxFilter.Items = new string[] {
        "None",
        "Detain ID",
        "Released",
        "National No.",
        "Full Name",
        "Release App ID"};
            this.cbxFilter.Location = new System.Drawing.Point(12, 71);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.NoSelectionDropdownText = "Empty";
            this.cbxFilter.NoSelectionText = "Filter By";
            this.cbxFilter.OutlineColor = System.Drawing.Color.Gainsboro;
            this.cbxFilter.OutlineThickness = 1F;
            this.cbxFilter.Rounding = 15;
            this.cbxFilter.Size = new System.Drawing.Size(159, 32);
            this.cbxFilter.TabIndex = 29;
            this.cbxFilter.SelectedIndexChanged += new System.EventHandler(this.cbxFilter_SelectedIndexChanged);
            // 
            // lblRecords
            // 
            this.lblRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecords.Content = "Records\\ :\\ 0";
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblRecords.Location = new System.Drawing.Point(12, 624);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(210, 14);
            this.lblRecords.TabIndex = 38;
            this.lblRecords.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // dgvDLicenses
            // 
            this.dgvDLicenses.AllowUserToAddRows = false;
            this.dgvDLicenses.AllowUserToDeleteRows = false;
            this.dgvDLicenses.AllowUserToResizeColumns = false;
            this.dgvDLicenses.AllowUserToResizeRows = false;
            this.dgvDLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvDLicenses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDLicenses.ColumnHeadersHeight = 25;
            this.dgvDLicenses.ContextMenuStrip = this.cxmDLicenses;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDLicenses.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDLicenses.EnableHeadersVisualStyles = false;
            this.dgvDLicenses.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvDLicenses.Location = new System.Drawing.Point(12, 109);
            this.dgvDLicenses.MultiSelect = false;
            this.dgvDLicenses.Name = "dgvDLicenses";
            this.dgvDLicenses.ReadOnly = true;
            this.dgvDLicenses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDLicenses.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDLicenses.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDLicenses.Size = new System.Drawing.Size(1176, 509);
            this.dgvDLicenses.TabIndex = 28;
            this.dgvDLicenses.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDLicenses_DataBindingComplete);
            // 
            // cxmDLicenses
            // 
            this.cxmDLicenses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addNewToolStripMenuItem});
            this.cxmDLicenses.Name = "cxmPeople";
            this.cxmDLicenses.Size = new System.Drawing.Size(226, 98);
            this.cxmDLicenses.Opening += new System.ComponentModel.CancelEventHandler(this.cxmDLicenses_Opening);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.showDetailsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.show;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.showDetailsToolStripMenuItem.Text = "Show Person Info";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.showLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.show;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.showLicenseToolStripMenuItem.Text = "Show License Info";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.show;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(222, 6);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.addNewToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.check_mark;
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.addNewToolStripMenuItem.Text = "Release Selected License";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // cuiResizeGrip
            // 
            this.cuiResizeGrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiResizeGrip.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.cuiResizeGrip.GripColor = System.Drawing.Color.Gray;
            this.cuiResizeGrip.GripSize = 2;
            this.cuiResizeGrip.GripTexture = true;
            this.cuiResizeGrip.Location = new System.Drawing.Point(1188, 450);
            this.cuiResizeGrip.Name = "cuiResizeGrip";
            this.cuiResizeGrip.Size = new System.Drawing.Size(12, 200);
            this.cuiResizeGrip.SkipBottomRightSquare = true;
            this.cuiResizeGrip.TabIndex = 35;
            this.cuiResizeGrip.TargetForm = this;
            this.cuiResizeGrip.TextureOffset = new System.Drawing.Size(-2, -2);
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cuiLabel1.Content = "Detained\\ Licenses";
            this.cuiLabel1.Enabled = false;
            this.cuiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel1.Location = new System.Drawing.Point(12, 12);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(1176, 25);
            this.cuiLabel1.TabIndex = 37;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnRLicense
            // 
            this.btnRLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRLicense.CheckButton = false;
            this.btnRLicense.Checked = false;
            this.btnRLicense.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnRLicense.CheckedForeColor = System.Drawing.Color.White;
            this.btnRLicense.CheckedImageTint = System.Drawing.Color.White;
            this.btnRLicense.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnRLicense.Content = "Release License";
            this.btnRLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRLicense.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnRLicense.ForeColor = System.Drawing.Color.DimGray;
            this.btnRLicense.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnRLicense.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnRLicense.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnRLicense.HoverOutline = System.Drawing.Color.DimGray;
            this.btnRLicense.Image = global::DVLD_Project.Properties.Resources.check;
            this.btnRLicense.ImageAutoCenter = true;
            this.btnRLicense.ImageExpand = new System.Drawing.Point(1, 1);
            this.btnRLicense.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnRLicense.Location = new System.Drawing.Point(876, 71);
            this.btnRLicense.Name = "btnRLicense";
            this.btnRLicense.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnRLicense.NormalForeColor = System.Drawing.Color.DimGray;
            this.btnRLicense.NormalImageTint = System.Drawing.Color.DimGray;
            this.btnRLicense.NormalOutline = System.Drawing.Color.Transparent;
            this.btnRLicense.OutlineThickness = 1F;
            this.btnRLicense.PressedBackground = System.Drawing.Color.LightGray;
            this.btnRLicense.PressedForeColor = System.Drawing.Color.DimGray;
            this.btnRLicense.PressedImageTint = System.Drawing.Color.DimGray;
            this.btnRLicense.PressedOutline = System.Drawing.Color.DimGray;
            this.btnRLicense.Rounding = new System.Windows.Forms.Padding(15);
            this.btnRLicense.Size = new System.Drawing.Size(153, 32);
            this.btnRLicense.TabIndex = 32;
            this.btnRLicense.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnRLicense.TextOffset = new System.Drawing.Point(2, 0);
            this.btnRLicense.Click += new System.EventHandler(this.btnRLicense_Click);
            // 
            // btnDLicense
            // 
            this.btnDLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDLicense.CheckButton = false;
            this.btnDLicense.Checked = false;
            this.btnDLicense.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnDLicense.CheckedForeColor = System.Drawing.Color.White;
            this.btnDLicense.CheckedImageTint = System.Drawing.Color.White;
            this.btnDLicense.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnDLicense.Content = "Detain License";
            this.btnDLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDLicense.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnDLicense.ForeColor = System.Drawing.Color.DimGray;
            this.btnDLicense.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnDLicense.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnDLicense.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnDLicense.HoverOutline = System.Drawing.Color.DimGray;
            this.btnDLicense.Image = global::DVLD_Project.Properties.Resources.cross__1_;
            this.btnDLicense.ImageAutoCenter = true;
            this.btnDLicense.ImageExpand = new System.Drawing.Point(1, 1);
            this.btnDLicense.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnDLicense.Location = new System.Drawing.Point(1035, 71);
            this.btnDLicense.Name = "btnDLicense";
            this.btnDLicense.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnDLicense.NormalForeColor = System.Drawing.Color.DimGray;
            this.btnDLicense.NormalImageTint = System.Drawing.Color.DimGray;
            this.btnDLicense.NormalOutline = System.Drawing.Color.Transparent;
            this.btnDLicense.OutlineThickness = 1F;
            this.btnDLicense.PressedBackground = System.Drawing.Color.LightGray;
            this.btnDLicense.PressedForeColor = System.Drawing.Color.DimGray;
            this.btnDLicense.PressedImageTint = System.Drawing.Color.DimGray;
            this.btnDLicense.PressedOutline = System.Drawing.Color.DimGray;
            this.btnDLicense.Rounding = new System.Windows.Forms.Padding(15);
            this.btnDLicense.Size = new System.Drawing.Size(153, 32);
            this.btnDLicense.TabIndex = 32;
            this.btnDLicense.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDLicense.TextOffset = new System.Drawing.Point(2, 0);
            this.btnDLicense.Click += new System.EventHandler(this.btnDLicense_Click);
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
            this.btnClose.Location = new System.Drawing.Point(1163, 12);
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
            this.btnClose.TabIndex = 33;
            this.btnClose.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnClose.TextOffset = new System.Drawing.Point(0, 0);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.CheckButton = false;
            this.btnMinimize.Checked = false;
            this.btnMinimize.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnMinimize.CheckedForeColor = System.Drawing.Color.White;
            this.btnMinimize.CheckedImageTint = System.Drawing.Color.White;
            this.btnMinimize.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnMinimize.Content = "";
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnMinimize.ForeColor = System.Drawing.Color.Black;
            this.btnMinimize.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.btnMinimize.HoverForeColor = System.Drawing.Color.Black;
            this.btnMinimize.HoverImageTint = System.Drawing.Color.White;
            this.btnMinimize.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.btnMinimize.Image = global::DVLD_Project.Properties.Resources.down_chevron;
            this.btnMinimize.ImageAutoCenter = true;
            this.btnMinimize.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnMinimize.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMinimize.Location = new System.Drawing.Point(1101, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.NormalBackground = System.Drawing.Color.White;
            this.btnMinimize.NormalForeColor = System.Drawing.Color.Black;
            this.btnMinimize.NormalImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.btnMinimize.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.btnMinimize.OutlineThickness = 1F;
            this.btnMinimize.PressedBackground = System.Drawing.Color.Black;
            this.btnMinimize.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.btnMinimize.PressedImageTint = System.Drawing.Color.White;
            this.btnMinimize.PressedOutline = System.Drawing.Color.Black;
            this.btnMinimize.Rounding = new System.Windows.Forms.Padding(12);
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 36;
            this.btnMinimize.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnMinimize.TextOffset = new System.Drawing.Point(0, 0);
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.CheckButton = false;
            this.btnMaximize.Checked = false;
            this.btnMaximize.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnMaximize.CheckedForeColor = System.Drawing.Color.White;
            this.btnMaximize.CheckedImageTint = System.Drawing.Color.White;
            this.btnMaximize.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnMaximize.Content = "";
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnMaximize.ForeColor = System.Drawing.Color.Black;
            this.btnMaximize.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.btnMaximize.HoverForeColor = System.Drawing.Color.Black;
            this.btnMaximize.HoverImageTint = System.Drawing.Color.White;
            this.btnMaximize.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.btnMaximize.Image = global::DVLD_Project.Properties.Resources.expand;
            this.btnMaximize.ImageAutoCenter = true;
            this.btnMaximize.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnMaximize.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMaximize.Location = new System.Drawing.Point(1132, 12);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.NormalBackground = System.Drawing.Color.White;
            this.btnMaximize.NormalForeColor = System.Drawing.Color.Black;
            this.btnMaximize.NormalImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.btnMaximize.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.btnMaximize.OutlineThickness = 1F;
            this.btnMaximize.PressedBackground = System.Drawing.Color.Black;
            this.btnMaximize.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnMaximize.PressedImageTint = System.Drawing.Color.White;
            this.btnMaximize.PressedOutline = System.Drawing.Color.Black;
            this.btnMaximize.Rounding = new System.Windows.Forms.Padding(12);
            this.btnMaximize.Size = new System.Drawing.Size(25, 25);
            this.btnMaximize.TabIndex = 34;
            this.btnMaximize.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnMaximize.TextOffset = new System.Drawing.Point(0, 0);
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
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
            // cuiFormDrag
            // 
            this.cuiFormDrag.TargetForm = this;
            // 
            // cuiFormRounder
            // 
            this.cuiFormRounder.OutlineColor = System.Drawing.Color.Silver;
            this.cuiFormRounder.Rounding = 8;
            this.cuiFormRounder.TargetForm = this;
            // 
            // MaximizedImgBox
            // 
            this.MaximizedImgBox.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MaximizedImgBox.ImageStream")));
            this.MaximizedImgBox.TransparentColor = System.Drawing.Color.Transparent;
            this.MaximizedImgBox.Images.SetKeyName(0, "expand.png");
            this.MaximizedImgBox.Images.SetKeyName(1, "minimize.png");
            // 
            // cbxIsReleased
            // 
            this.cbxIsReleased.BackColor = System.Drawing.Color.Transparent;
            this.cbxIsReleased.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.cbxIsReleased.ButtonCursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxIsReleased.ButtonHoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.cbxIsReleased.ButtonHoverOutline = System.Drawing.Color.Transparent;
            this.cbxIsReleased.ButtonNormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.cbxIsReleased.ButtonNormalOutline = System.Drawing.Color.Empty;
            this.cbxIsReleased.ButtonPressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.cbxIsReleased.ButtonPressedOutline = System.Drawing.Color.Empty;
            this.cbxIsReleased.DropDownBackgroundColor = System.Drawing.Color.Transparent;
            this.cbxIsReleased.DropDownOutlineColor = System.Drawing.Color.Transparent;
            this.cbxIsReleased.ExpandArrowColor = System.Drawing.Color.DimGray;
            this.cbxIsReleased.ForeColor = System.Drawing.Color.DimGray;
            this.cbxIsReleased.Items = new string[] {
        "All",
        "Yes",
        "No"};
            this.cbxIsReleased.Location = new System.Drawing.Point(177, 71);
            this.cbxIsReleased.Name = "cbxIsReleased";
            this.cbxIsReleased.NoSelectionDropdownText = "Empty";
            this.cbxIsReleased.NoSelectionText = "Is Released";
            this.cbxIsReleased.OutlineColor = System.Drawing.Color.Gainsboro;
            this.cbxIsReleased.OutlineThickness = 1F;
            this.cbxIsReleased.Rounding = 15;
            this.cbxIsReleased.Size = new System.Drawing.Size(123, 32);
            this.cbxIsReleased.TabIndex = 41;
            this.cbxIsReleased.Visible = false;
            this.cbxIsReleased.SelectedIndexChanged += new System.EventHandler(this.cbxIsReleased_SelectedIndexChanged);
            // 
            // frmManageDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.cbxIsReleased);
            this.Controls.Add(this.btnRLicense);
            this.Controls.Add(this.btnDLicense);
            this.Controls.Add(this.lblEmpty);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.cbxFilter);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvDLicenses);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.cuiResizeGrip);
            this.Controls.Add(this.cuiLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "frmManageDetainedLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageDetainedLicenses";
            this.SizeChanged += new System.EventHandler(this.frmManageDetainedLicenses_SizeChanged);
            this.Resize += new System.EventHandler(this.frmManageDetainedLicenses_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDLicenses)).EndInit();
            this.cxmDLicenses.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiButton btnDLicense;
        private CuoreUI.Controls.cuiLabel lblEmpty;
        private CuoreUI.Controls.cuiTextBox tbxFilter;
        private CuoreUI.Controls.cuiComboBox cbxFilter;
        private CuoreUI.Controls.cuiLabel lblRecords;
        private System.Windows.Forms.DataGridView dgvDLicenses;
        private CuoreUI.Controls.cuiButton btnClose;
        private CuoreUI.Controls.cuiButton btnMinimize;
        private CuoreUI.Controls.cuiButton btnMaximize;
        private CuoreUI.Controls.cuiResizeGrip cuiResizeGrip;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiButton btnRLicense;
        private System.Windows.Forms.ContextMenuStrip cxmDLicenses;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private CuoreUI.Components.cuiFormAnimator cuiFormAnimator;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder;
        private System.Windows.Forms.ImageList MaximizedImgBox;
        private CuoreUI.Controls.cuiComboBox cbxIsReleased;
    }
}