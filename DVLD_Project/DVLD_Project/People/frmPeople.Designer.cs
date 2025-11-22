namespace DVLD_Project
{
    partial class frmPeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeople));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cuiResizeGrip = new CuoreUI.Controls.cuiResizeGrip();
            this.cuiFormRounder = new CuoreUI.Components.cuiFormRounder();
            this.MaximizedImgBox = new System.Windows.Forms.ImageList(this.components);
            this.PeopleDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.PeopleAnimator = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.cxmPeople = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jkToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecords = new CuoreUI.Controls.cuiLabel();
            this.cbxFilter = new CuoreUI.Controls.cuiComboBox();
            this.tbxFilter = new CuoreUI.Controls.cuiTextBox();
            this.cbxGendor = new CuoreUI.Controls.cuiComboBox();
            this.lblEmpty = new CuoreUI.Controls.cuiLabel();
            this.btnAddPerson = new CuoreUI.Controls.cuiButton();
            this.btnClose = new CuoreUI.Controls.cuiButton();
            this.btnMinimize = new CuoreUI.Controls.cuiButton();
            this.btnMaximize = new CuoreUI.Controls.cuiButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.cxmPeople.SuspendLayout();
            this.SuspendLayout();
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
            this.cuiResizeGrip.TabIndex = 5;
            this.cuiResizeGrip.TargetForm = this;
            this.cuiResizeGrip.TextureOffset = new System.Drawing.Size(-2, -2);
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
            // PeopleDrag
            // 
            this.PeopleDrag.TargetForm = this;
            // 
            // PeopleAnimator
            // 
            this.PeopleAnimator.AnimateOnStart = true;
            this.PeopleAnimator.Duration = 150;
            this.PeopleAnimator.EasingType = CuoreUI.Drawing.EasingTypes.QuadIn;
            this.PeopleAnimator.StartOpacity = 0D;
            this.PeopleAnimator.TargetForm = this;
            this.PeopleAnimator.TargetOpacity = 1D;
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cuiLabel1.Content = "People";
            this.cuiLabel1.Enabled = false;
            this.cuiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel1.Location = new System.Drawing.Point(12, 12);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(1176, 25);
            this.cuiLabel1.TabIndex = 9;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            this.dgvPeople.AllowUserToResizeColumns = false;
            this.dgvPeople.AllowUserToResizeRows = false;
            this.dgvPeople.BackgroundColor = System.Drawing.Color.White;
            this.dgvPeople.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPeople.ColumnHeadersHeight = 25;
            this.dgvPeople.ContextMenuStrip = this.cxmPeople;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPeople.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPeople.EnableHeadersVisualStyles = false;
            this.dgvPeople.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvPeople.Location = new System.Drawing.Point(12, 109);
            this.dgvPeople.MultiSelect = false;
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.ReadOnly = true;
            this.dgvPeople.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeople.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPeople.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPeople.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeople.Size = new System.Drawing.Size(1176, 509);
            this.dgvPeople.TabIndex = 0;
            this.dgvPeople.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPeople_DataBindingComplete);
            this.dgvPeople.DoubleClick += new System.EventHandler(this.dgvPeople_DoubleClick);
            this.dgvPeople.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPeople_KeyDown);
            // 
            // cxmPeople
            // 
            this.cxmPeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.jkToolStripMenuItem,
            this.addNewToolStripMenuItem});
            this.cxmPeople.Name = "cxmPeople";
            this.cxmPeople.Size = new System.Drawing.Size(142, 98);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.showDetailsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.show;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.updateToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.pencil;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.updateToolStripMenuItem.Text = "Edit";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.deleteToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.trash_bin;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // jkToolStripMenuItem
            // 
            this.jkToolStripMenuItem.Name = "jkToolStripMenuItem";
            this.jkToolStripMenuItem.Size = new System.Drawing.Size(138, 6);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.addNewToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.add_sign__1_;
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.addNewToolStripMenuItem.Text = "Add Person";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.btnAddPerson_Click);
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
            this.lblRecords.TabIndex = 11;
            this.lblRecords.VerticalAlignment = System.Drawing.StringAlignment.Near;
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
        "ID",
        "No.",
        "First Name",
        "Second Name",
        "Third Name",
        "Last Name",
        "Gendor",
        "Address",
        "Phone",
        "Email",
        "Nationality"};
            this.cbxFilter.Location = new System.Drawing.Point(12, 71);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.NoSelectionDropdownText = "Empty";
            this.cbxFilter.NoSelectionText = "Filter By";
            this.cbxFilter.OutlineColor = System.Drawing.Color.Gainsboro;
            this.cbxFilter.OutlineThickness = 1F;
            this.cbxFilter.Rounding = 15;
            this.cbxFilter.Size = new System.Drawing.Size(159, 32);
            this.cbxFilter.TabIndex = 1;
            this.cbxFilter.SelectedIndexChanged += new System.EventHandler(this.cbxFilter_SelectedIndexChanged);
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
            this.tbxFilter.Location = new System.Drawing.Point(178, 70);
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
            this.tbxFilter.TabIndex = 2;
            this.tbxFilter.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxFilter.UnderlinedStyle = false;
            this.tbxFilter.Visible = false;
            this.tbxFilter.ContentChanged += new System.EventHandler(this.tbxFilter_ContentChanged);
            this.tbxFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFilter_KeyPress);
            // 
            // cbxGendor
            // 
            this.cbxGendor.BackColor = System.Drawing.Color.Transparent;
            this.cbxGendor.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.cbxGendor.ButtonCursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxGendor.ButtonHoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.cbxGendor.ButtonHoverOutline = System.Drawing.Color.Transparent;
            this.cbxGendor.ButtonNormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.cbxGendor.ButtonNormalOutline = System.Drawing.Color.Empty;
            this.cbxGendor.ButtonPressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.cbxGendor.ButtonPressedOutline = System.Drawing.Color.Empty;
            this.cbxGendor.DropDownBackgroundColor = System.Drawing.Color.Transparent;
            this.cbxGendor.DropDownOutlineColor = System.Drawing.Color.Transparent;
            this.cbxGendor.ExpandArrowColor = System.Drawing.Color.DimGray;
            this.cbxGendor.ForeColor = System.Drawing.Color.DimGray;
            this.cbxGendor.Items = new string[] {
        "None",
        "Male",
        "Female"};
            this.cbxGendor.Location = new System.Drawing.Point(178, 71);
            this.cbxGendor.Name = "cbxGendor";
            this.cbxGendor.NoSelectionDropdownText = "Empty";
            this.cbxGendor.NoSelectionText = "Gendor";
            this.cbxGendor.OutlineColor = System.Drawing.Color.Gainsboro;
            this.cbxGendor.OutlineThickness = 1F;
            this.cbxGendor.Rounding = 15;
            this.cbxGendor.Size = new System.Drawing.Size(116, 32);
            this.cbxGendor.TabIndex = 2;
            this.cbxGendor.Visible = false;
            this.cbxGendor.SelectedIndexChanged += new System.EventHandler(this.cbxGendor_SelectedIndexChanged);
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
            this.lblEmpty.TabIndex = 15;
            this.lblEmpty.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPerson.CheckButton = false;
            this.btnAddPerson.Checked = false;
            this.btnAddPerson.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAddPerson.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddPerson.CheckedImageTint = System.Drawing.Color.White;
            this.btnAddPerson.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAddPerson.Content = "Add Perosn";
            this.btnAddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPerson.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAddPerson.ForeColor = System.Drawing.Color.DimGray;
            this.btnAddPerson.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnAddPerson.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnAddPerson.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnAddPerson.HoverOutline = System.Drawing.Color.DimGray;
            this.btnAddPerson.Image = global::DVLD_Project.Properties.Resources.add_sign;
            this.btnAddPerson.ImageAutoCenter = true;
            this.btnAddPerson.ImageExpand = new System.Drawing.Point(1, 1);
            this.btnAddPerson.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnAddPerson.Location = new System.Drawing.Point(1035, 71);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnAddPerson.NormalForeColor = System.Drawing.Color.DimGray;
            this.btnAddPerson.NormalImageTint = System.Drawing.Color.DimGray;
            this.btnAddPerson.NormalOutline = System.Drawing.Color.Transparent;
            this.btnAddPerson.OutlineThickness = 1F;
            this.btnAddPerson.PressedBackground = System.Drawing.Color.LightGray;
            this.btnAddPerson.PressedForeColor = System.Drawing.Color.DimGray;
            this.btnAddPerson.PressedImageTint = System.Drawing.Color.DimGray;
            this.btnAddPerson.PressedOutline = System.Drawing.Color.DimGray;
            this.btnAddPerson.Rounding = new System.Windows.Forms.Padding(15);
            this.btnAddPerson.Size = new System.Drawing.Size(153, 32);
            this.btnAddPerson.TabIndex = 3;
            this.btnAddPerson.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAddPerson.TextOffset = new System.Drawing.Point(2, 0);
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
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
            this.btnClose.TabIndex = 4;
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
            this.btnMinimize.TabIndex = 6;
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
            this.btnMaximize.TabIndex = 5;
            this.btnMaximize.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnMaximize.TextOffset = new System.Drawing.Point(0, 0);
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // frmPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.lblEmpty);
            this.Controls.Add(this.cbxGendor);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.cbxFilter);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvPeople);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.cuiResizeGrip);
            this.Controls.Add(this.cuiLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "frmPeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "clsPeople";
            this.Load += new System.EventHandler(this.frmPeople_Load);
            this.SizeChanged += new System.EventHandler(this.frmPeople_SizeChanged);
            this.Resize += new System.EventHandler(this.frmPeople_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.cxmPeople.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiResizeGrip cuiResizeGrip;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder;
        private CuoreUI.Controls.cuiButton btnClose;
        private CuoreUI.Controls.cuiButton btnMinimize;
        private CuoreUI.Controls.cuiButton btnMaximize;
        private System.Windows.Forms.ImageList MaximizedImgBox;
        private CuoreUI.Components.cuiFormDrag PeopleDrag;
        private CuoreUI.Components.cuiFormAnimator PeopleAnimator;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private System.Windows.Forms.DataGridView dgvPeople;
        private CuoreUI.Controls.cuiLabel lblRecords;
        private CuoreUI.Controls.cuiComboBox cbxFilter;
        private CuoreUI.Controls.cuiTextBox tbxFilter;
        private CuoreUI.Controls.cuiComboBox cbxGendor;
        private CuoreUI.Controls.cuiLabel lblEmpty;
        private CuoreUI.Controls.cuiButton btnAddPerson;
        private System.Windows.Forms.ContextMenuStrip cxmPeople;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator jkToolStripMenuItem;
    }
}