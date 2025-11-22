namespace DVLD_Project
{
    partial class frmAddUpdatePerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdatePerson));
            this.cuiFormRounder = new CuoreUI.Components.cuiFormRounder();
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.cuiFormAnimator = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.lblFormLabel = new CuoreUI.Controls.cuiLabel();
            this.lblID = new CuoreUI.Controls.cuiLabel();
            this.tbxFirstName = new CuoreUI.Controls.cuiTextBox();
            this.tbxSecondName = new CuoreUI.Controls.cuiTextBox();
            this.tbxThirdName = new CuoreUI.Controls.cuiTextBox();
            this.tbxLastName = new CuoreUI.Controls.cuiTextBox();
            this.tbxNationalNo = new CuoreUI.Controls.cuiTextBox();
            this.tbxEmail = new CuoreUI.Controls.cuiTextBox();
            this.tbxAddress = new CuoreUI.Controls.cuiTextBox();
            this.tbxPhone = new CuoreUI.Controls.cuiTextBox();
            this.cbxNationality = new CuoreUI.Controls.cuiComboBox();
            this.btnEditNationality = new CuoreUI.Controls.cuiButton();
            this.btnMinimize = new CuoreUI.Controls.cuiButton();
            this.cbtnFemale = new CuoreUI.Controls.cuiButtonGroup();
            this.cbtnMale = new CuoreUI.Controls.cuiButtonGroup();
            this.btnDelete = new CuoreUI.Controls.cuiButton();
            this.btnImport = new CuoreUI.Controls.cuiButton();
            this.btnSavePerson = new CuoreUI.Controls.cuiButton();
            this.dtpDateOfBirth = new CuoreUI.Controls.cuiCalendarDatePicker();
            this.cuiPictureBox6 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox5 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox4 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox3 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox9 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox8 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox7 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox2 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            this.btnClose = new CuoreUI.Controls.cuiButton();
            this.pbxPersonImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
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
            // lblFormLabel
            // 
            this.lblFormLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFormLabel.Content = "Add\\ Person";
            this.lblFormLabel.Enabled = false;
            this.lblFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormLabel.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblFormLabel.Location = new System.Drawing.Point(12, 12);
            this.lblFormLabel.Name = "lblFormLabel";
            this.lblFormLabel.Size = new System.Drawing.Size(776, 25);
            this.lblFormLabel.TabIndex = 10;
            this.lblFormLabel.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblID
            // 
            this.lblID.Content = "ID\\ :\\ ";
            this.lblID.Enabled = false;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.DimGray;
            this.lblID.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblID.Location = new System.Drawing.Point(50, 61);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(166, 32);
            this.lblID.TabIndex = 12;
            this.lblID.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tbxFirstName.Content = "";
            this.tbxFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxFirstName.FocusBackgroundColor = System.Drawing.Color.White;
            this.tbxFirstName.FocusImageTint = System.Drawing.Color.White;
            this.tbxFirstName.FocusOutlineColor = System.Drawing.Color.Black;
            this.tbxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstName.ForeColor = System.Drawing.Color.Black;
            this.tbxFirstName.Image = null;
            this.tbxFirstName.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxFirstName.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxFirstName.Location = new System.Drawing.Point(51, 114);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFirstName.Multiline = false;
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.NormalImageTint = System.Drawing.Color.DimGray;
            this.tbxFirstName.OutlineColor = System.Drawing.Color.Gainsboro;
            this.tbxFirstName.Padding = new System.Windows.Forms.Padding(15, 9, 15, 0);
            this.tbxFirstName.PasswordChar = false;
            this.tbxFirstName.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxFirstName.PlaceholderText = "First Name";
            this.tbxFirstName.Rounding = new System.Windows.Forms.Padding(15);
            this.tbxFirstName.Size = new System.Drawing.Size(175, 32);
            this.tbxFirstName.TabIndex = 13;
            this.tbxFirstName.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxFirstName.UnderlinedStyle = false;
            this.tbxFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.ErrorProvider_Validating);
            // 
            // tbxSecondName
            // 
            this.tbxSecondName.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tbxSecondName.Content = "";
            this.tbxSecondName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxSecondName.FocusBackgroundColor = System.Drawing.Color.White;
            this.tbxSecondName.FocusImageTint = System.Drawing.Color.White;
            this.tbxSecondName.FocusOutlineColor = System.Drawing.Color.Black;
            this.tbxSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSecondName.ForeColor = System.Drawing.Color.Black;
            this.tbxSecondName.Image = null;
            this.tbxSecondName.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxSecondName.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxSecondName.Location = new System.Drawing.Point(238, 114);
            this.tbxSecondName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSecondName.Multiline = false;
            this.tbxSecondName.Name = "tbxSecondName";
            this.tbxSecondName.NormalImageTint = System.Drawing.Color.DimGray;
            this.tbxSecondName.OutlineColor = System.Drawing.Color.Gainsboro;
            this.tbxSecondName.Padding = new System.Windows.Forms.Padding(15, 9, 15, 0);
            this.tbxSecondName.PasswordChar = false;
            this.tbxSecondName.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxSecondName.PlaceholderText = "Second Name";
            this.tbxSecondName.Rounding = new System.Windows.Forms.Padding(15);
            this.tbxSecondName.Size = new System.Drawing.Size(175, 32);
            this.tbxSecondName.TabIndex = 13;
            this.tbxSecondName.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxSecondName.UnderlinedStyle = false;
            this.tbxSecondName.Validating += new System.ComponentModel.CancelEventHandler(this.ErrorProvider_Validating);
            // 
            // tbxThirdName
            // 
            this.tbxThirdName.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tbxThirdName.Content = "";
            this.tbxThirdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxThirdName.FocusBackgroundColor = System.Drawing.Color.White;
            this.tbxThirdName.FocusImageTint = System.Drawing.Color.White;
            this.tbxThirdName.FocusOutlineColor = System.Drawing.Color.Black;
            this.tbxThirdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxThirdName.ForeColor = System.Drawing.Color.Black;
            this.tbxThirdName.Image = null;
            this.tbxThirdName.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxThirdName.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxThirdName.Location = new System.Drawing.Point(425, 114);
            this.tbxThirdName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxThirdName.Multiline = false;
            this.tbxThirdName.Name = "tbxThirdName";
            this.tbxThirdName.NormalImageTint = System.Drawing.Color.DimGray;
            this.tbxThirdName.OutlineColor = System.Drawing.Color.Gainsboro;
            this.tbxThirdName.Padding = new System.Windows.Forms.Padding(15, 9, 15, 0);
            this.tbxThirdName.PasswordChar = false;
            this.tbxThirdName.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxThirdName.PlaceholderText = "Third Name";
            this.tbxThirdName.Rounding = new System.Windows.Forms.Padding(15);
            this.tbxThirdName.Size = new System.Drawing.Size(175, 32);
            this.tbxThirdName.TabIndex = 13;
            this.tbxThirdName.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxThirdName.UnderlinedStyle = false;
            // 
            // tbxLastName
            // 
            this.tbxLastName.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tbxLastName.Content = "";
            this.tbxLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxLastName.FocusBackgroundColor = System.Drawing.Color.White;
            this.tbxLastName.FocusImageTint = System.Drawing.Color.White;
            this.tbxLastName.FocusOutlineColor = System.Drawing.Color.Black;
            this.tbxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName.ForeColor = System.Drawing.Color.Black;
            this.tbxLastName.Image = null;
            this.tbxLastName.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxLastName.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxLastName.Location = new System.Drawing.Point(612, 114);
            this.tbxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxLastName.Multiline = false;
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.NormalImageTint = System.Drawing.Color.DimGray;
            this.tbxLastName.OutlineColor = System.Drawing.Color.Gainsboro;
            this.tbxLastName.Padding = new System.Windows.Forms.Padding(15, 9, 15, 0);
            this.tbxLastName.PasswordChar = false;
            this.tbxLastName.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxLastName.PlaceholderText = "Last Name";
            this.tbxLastName.Rounding = new System.Windows.Forms.Padding(15);
            this.tbxLastName.Size = new System.Drawing.Size(175, 32);
            this.tbxLastName.TabIndex = 13;
            this.tbxLastName.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxLastName.UnderlinedStyle = false;
            this.tbxLastName.Validating += new System.ComponentModel.CancelEventHandler(this.ErrorProvider_Validating);
            // 
            // tbxNationalNo
            // 
            this.tbxNationalNo.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tbxNationalNo.Content = "";
            this.tbxNationalNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxNationalNo.FocusBackgroundColor = System.Drawing.Color.White;
            this.tbxNationalNo.FocusImageTint = System.Drawing.Color.White;
            this.tbxNationalNo.FocusOutlineColor = System.Drawing.Color.Black;
            this.tbxNationalNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNationalNo.ForeColor = System.Drawing.Color.Black;
            this.tbxNationalNo.Image = null;
            this.tbxNationalNo.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxNationalNo.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxNationalNo.Location = new System.Drawing.Point(51, 163);
            this.tbxNationalNo.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNationalNo.Multiline = false;
            this.tbxNationalNo.Name = "tbxNationalNo";
            this.tbxNationalNo.NormalImageTint = System.Drawing.Color.DimGray;
            this.tbxNationalNo.OutlineColor = System.Drawing.Color.Gainsboro;
            this.tbxNationalNo.Padding = new System.Windows.Forms.Padding(15, 9, 15, 0);
            this.tbxNationalNo.PasswordChar = false;
            this.tbxNationalNo.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxNationalNo.PlaceholderText = "National No.";
            this.tbxNationalNo.Rounding = new System.Windows.Forms.Padding(15);
            this.tbxNationalNo.Size = new System.Drawing.Size(175, 32);
            this.tbxNationalNo.TabIndex = 13;
            this.tbxNationalNo.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxNationalNo.UnderlinedStyle = false;
            this.tbxNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.tbxNationalNo_Validating);
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tbxEmail.Content = "";
            this.tbxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxEmail.FocusBackgroundColor = System.Drawing.Color.White;
            this.tbxEmail.FocusImageTint = System.Drawing.Color.White;
            this.tbxEmail.FocusOutlineColor = System.Drawing.Color.Black;
            this.tbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.ForeColor = System.Drawing.Color.Black;
            this.tbxEmail.Image = null;
            this.tbxEmail.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxEmail.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxEmail.Location = new System.Drawing.Point(50, 261);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEmail.Multiline = false;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.NormalImageTint = System.Drawing.Color.DimGray;
            this.tbxEmail.OutlineColor = System.Drawing.Color.Gainsboro;
            this.tbxEmail.Padding = new System.Windows.Forms.Padding(15, 9, 15, 0);
            this.tbxEmail.PasswordChar = false;
            this.tbxEmail.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxEmail.PlaceholderText = "Email";
            this.tbxEmail.Rounding = new System.Windows.Forms.Padding(15);
            this.tbxEmail.Size = new System.Drawing.Size(176, 32);
            this.tbxEmail.TabIndex = 13;
            this.tbxEmail.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxEmail.UnderlinedStyle = false;
            this.tbxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbxEmail_Validating);
            // 
            // tbxAddress
            // 
            this.tbxAddress.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tbxAddress.Content = "";
            this.tbxAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxAddress.FocusBackgroundColor = System.Drawing.Color.White;
            this.tbxAddress.FocusImageTint = System.Drawing.Color.White;
            this.tbxAddress.FocusOutlineColor = System.Drawing.Color.Black;
            this.tbxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress.ForeColor = System.Drawing.Color.Black;
            this.tbxAddress.Image = null;
            this.tbxAddress.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxAddress.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxAddress.Location = new System.Drawing.Point(51, 310);
            this.tbxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.NormalImageTint = System.Drawing.Color.DimGray;
            this.tbxAddress.OutlineColor = System.Drawing.Color.Gainsboro;
            this.tbxAddress.Padding = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.tbxAddress.PasswordChar = false;
            this.tbxAddress.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxAddress.PlaceholderText = "Address";
            this.tbxAddress.Rounding = new System.Windows.Forms.Padding(15);
            this.tbxAddress.Size = new System.Drawing.Size(549, 116);
            this.tbxAddress.TabIndex = 13;
            this.tbxAddress.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxAddress.UnderlinedStyle = false;
            this.tbxAddress.Validating += new System.ComponentModel.CancelEventHandler(this.ErrorProvider_Validating);
            // 
            // tbxPhone
            // 
            this.tbxPhone.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tbxPhone.Content = "";
            this.tbxPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPhone.FocusBackgroundColor = System.Drawing.Color.White;
            this.tbxPhone.FocusImageTint = System.Drawing.Color.White;
            this.tbxPhone.FocusOutlineColor = System.Drawing.Color.Black;
            this.tbxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhone.ForeColor = System.Drawing.Color.Black;
            this.tbxPhone.Image = null;
            this.tbxPhone.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxPhone.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxPhone.Location = new System.Drawing.Point(425, 212);
            this.tbxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPhone.Multiline = false;
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.NormalImageTint = System.Drawing.Color.DimGray;
            this.tbxPhone.OutlineColor = System.Drawing.Color.Gainsboro;
            this.tbxPhone.Padding = new System.Windows.Forms.Padding(15, 9, 15, 0);
            this.tbxPhone.PasswordChar = false;
            this.tbxPhone.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxPhone.PlaceholderText = "Phone";
            this.tbxPhone.Rounding = new System.Windows.Forms.Padding(15);
            this.tbxPhone.Size = new System.Drawing.Size(175, 32);
            this.tbxPhone.TabIndex = 13;
            this.tbxPhone.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxPhone.UnderlinedStyle = false;
            this.tbxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPhone_KeyPress);
            this.tbxPhone.Validating += new System.ComponentModel.CancelEventHandler(this.ErrorProvider_Validating);
            // 
            // cbxNationality
            // 
            this.cbxNationality.BackColor = System.Drawing.Color.Transparent;
            this.cbxNationality.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.cbxNationality.ButtonCursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxNationality.ButtonHoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.cbxNationality.ButtonHoverOutline = System.Drawing.Color.Transparent;
            this.cbxNationality.ButtonNormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.cbxNationality.ButtonNormalOutline = System.Drawing.Color.Empty;
            this.cbxNationality.ButtonPressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.cbxNationality.ButtonPressedOutline = System.Drawing.Color.Empty;
            this.cbxNationality.DropDownBackgroundColor = System.Drawing.Color.Transparent;
            this.cbxNationality.DropDownOutlineColor = System.Drawing.Color.Transparent;
            this.cbxNationality.Enabled = false;
            this.cbxNationality.ExpandArrowColor = System.Drawing.Color.Gainsboro;
            this.cbxNationality.ForeColor = System.Drawing.Color.DimGray;
            this.cbxNationality.Items = new string[0];
            this.cbxNationality.Location = new System.Drawing.Point(425, 261);
            this.cbxNationality.Name = "cbxNationality";
            this.cbxNationality.NoSelectionDropdownText = "Empty";
            this.cbxNationality.NoSelectionText = "Nationality";
            this.cbxNationality.OutlineColor = System.Drawing.Color.Gainsboro;
            this.cbxNationality.OutlineThickness = 1F;
            this.cbxNationality.Rounding = 15;
            this.cbxNationality.Size = new System.Drawing.Size(138, 32);
            this.cbxNationality.TabIndex = 14;
            // 
            // btnEditNationality
            // 
            this.btnEditNationality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditNationality.CheckButton = false;
            this.btnEditNationality.Checked = false;
            this.btnEditNationality.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnEditNationality.CheckedForeColor = System.Drawing.Color.White;
            this.btnEditNationality.CheckedImageTint = System.Drawing.Color.White;
            this.btnEditNationality.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnEditNationality.Content = "";
            this.btnEditNationality.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditNationality.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnEditNationality.ForeColor = System.Drawing.Color.DimGray;
            this.btnEditNationality.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnEditNationality.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnEditNationality.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnEditNationality.HoverOutline = System.Drawing.Color.DimGray;
            this.btnEditNationality.Image = global::DVLD_Project.Properties.Resources.pencil__1_;
            this.btnEditNationality.ImageAutoCenter = true;
            this.btnEditNationality.ImageExpand = new System.Drawing.Point(1, 1);
            this.btnEditNationality.ImageOffset = new System.Drawing.Point(-1, 0);
            this.btnEditNationality.Location = new System.Drawing.Point(569, 261);
            this.btnEditNationality.Name = "btnEditNationality";
            this.btnEditNationality.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnEditNationality.NormalForeColor = System.Drawing.Color.DimGray;
            this.btnEditNationality.NormalImageTint = System.Drawing.Color.DimGray;
            this.btnEditNationality.NormalOutline = System.Drawing.Color.Transparent;
            this.btnEditNationality.OutlineThickness = 1F;
            this.btnEditNationality.PressedBackground = System.Drawing.Color.LightGray;
            this.btnEditNationality.PressedForeColor = System.Drawing.Color.DimGray;
            this.btnEditNationality.PressedImageTint = System.Drawing.Color.DimGray;
            this.btnEditNationality.PressedOutline = System.Drawing.Color.DimGray;
            this.btnEditNationality.Rounding = new System.Windows.Forms.Padding(15);
            this.btnEditNationality.Size = new System.Drawing.Size(32, 32);
            this.btnEditNationality.TabIndex = 21;
            this.btnEditNationality.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnEditNationality.TextOffset = new System.Drawing.Point(1, 0);
            this.btnEditNationality.Click += new System.EventHandler(this.btnEditNationality_Click);
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
            this.btnMinimize.Location = new System.Drawing.Point(732, 12);
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
            this.btnMinimize.TabIndex = 20;
            this.btnMinimize.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnMinimize.TextOffset = new System.Drawing.Point(0, 0);
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // cbtnFemale
            // 
            this.cbtnFemale.Checked = false;
            this.cbtnFemale.CheckedBackground = System.Drawing.Color.DimGray;
            this.cbtnFemale.CheckedForeColor = System.Drawing.Color.White;
            this.cbtnFemale.CheckedImageTint = System.Drawing.Color.White;
            this.cbtnFemale.CheckedOutline = System.Drawing.Color.DimGray;
            this.cbtnFemale.Content = "Female";
            this.cbtnFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbtnFemale.ForeColor = System.Drawing.Color.DimGray;
            this.cbtnFemale.Group = 0;
            this.cbtnFemale.HoverBackground = System.Drawing.Color.Gainsboro;
            this.cbtnFemale.HoverForeColor = System.Drawing.Color.DimGray;
            this.cbtnFemale.HoverImageTint = System.Drawing.Color.DimGray;
            this.cbtnFemale.HoverOutline = System.Drawing.Color.DimGray;
            this.cbtnFemale.Image = global::DVLD_Project.Properties.Resources.people;
            this.cbtnFemale.ImageAutoCenter = true;
            this.cbtnFemale.ImageExpand = new System.Drawing.Point(0, 0);
            this.cbtnFemale.ImageOffset = new System.Drawing.Point(-1, 0);
            this.cbtnFemale.Location = new System.Drawing.Point(143, 212);
            this.cbtnFemale.Name = "cbtnFemale";
            this.cbtnFemale.NormalBackground = System.Drawing.Color.Gainsboro;
            this.cbtnFemale.NormalForeColor = System.Drawing.Color.DimGray;
            this.cbtnFemale.NormalImageTint = System.Drawing.Color.DimGray;
            this.cbtnFemale.NormalOutline = System.Drawing.Color.Gainsboro;
            this.cbtnFemale.OutlineThickness = 1F;
            this.cbtnFemale.PressedBackground = System.Drawing.Color.LightGray;
            this.cbtnFemale.PressedForeColor = System.Drawing.Color.DimGray;
            this.cbtnFemale.PressedImageTint = System.Drawing.Color.DimGray;
            this.cbtnFemale.PressedOutline = System.Drawing.Color.DimGray;
            this.cbtnFemale.Rounding = new System.Windows.Forms.Padding(15);
            this.cbtnFemale.Size = new System.Drawing.Size(82, 32);
            this.cbtnFemale.TabIndex = 19;
            this.cbtnFemale.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cbtnFemale.TextOffset = new System.Drawing.Point(1, 0);
            this.cbtnFemale.Click += new System.EventHandler(this.cbtnMale_Click);
            // 
            // cbtnMale
            // 
            this.cbtnMale.Checked = true;
            this.cbtnMale.CheckedBackground = System.Drawing.Color.DimGray;
            this.cbtnMale.CheckedForeColor = System.Drawing.Color.White;
            this.cbtnMale.CheckedImageTint = System.Drawing.Color.White;
            this.cbtnMale.CheckedOutline = System.Drawing.Color.DimGray;
            this.cbtnMale.Content = "Male";
            this.cbtnMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbtnMale.ForeColor = System.Drawing.Color.DimGray;
            this.cbtnMale.Group = 0;
            this.cbtnMale.HoverBackground = System.Drawing.Color.Gainsboro;
            this.cbtnMale.HoverForeColor = System.Drawing.Color.DimGray;
            this.cbtnMale.HoverImageTint = System.Drawing.Color.DimGray;
            this.cbtnMale.HoverOutline = System.Drawing.Color.DimGray;
            this.cbtnMale.Image = global::DVLD_Project.Properties.Resources.employee;
            this.cbtnMale.ImageAutoCenter = true;
            this.cbtnMale.ImageExpand = new System.Drawing.Point(0, 0);
            this.cbtnMale.ImageOffset = new System.Drawing.Point(-1, 0);
            this.cbtnMale.Location = new System.Drawing.Point(50, 212);
            this.cbtnMale.Name = "cbtnMale";
            this.cbtnMale.NormalBackground = System.Drawing.Color.Gainsboro;
            this.cbtnMale.NormalForeColor = System.Drawing.Color.DimGray;
            this.cbtnMale.NormalImageTint = System.Drawing.Color.DimGray;
            this.cbtnMale.NormalOutline = System.Drawing.Color.Gainsboro;
            this.cbtnMale.OutlineThickness = 1F;
            this.cbtnMale.PressedBackground = System.Drawing.Color.LightGray;
            this.cbtnMale.PressedForeColor = System.Drawing.Color.DimGray;
            this.cbtnMale.PressedImageTint = System.Drawing.Color.DimGray;
            this.cbtnMale.PressedOutline = System.Drawing.Color.DimGray;
            this.cbtnMale.Rounding = new System.Windows.Forms.Padding(15);
            this.cbtnMale.Size = new System.Drawing.Size(82, 32);
            this.cbtnMale.TabIndex = 19;
            this.cbtnMale.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cbtnMale.TextOffset = new System.Drawing.Point(1, 0);
            this.cbtnMale.Click += new System.EventHandler(this.cbtnMale_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.CheckButton = false;
            this.btnDelete.Checked = false;
            this.btnDelete.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnDelete.CheckedForeColor = System.Drawing.Color.White;
            this.btnDelete.CheckedImageTint = System.Drawing.Color.White;
            this.btnDelete.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnDelete.Content = "Delete";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnDelete.ForeColor = System.Drawing.Color.DimGray;
            this.btnDelete.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnDelete.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnDelete.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnDelete.HoverOutline = System.Drawing.Color.DimGray;
            this.btnDelete.Image = global::DVLD_Project.Properties.Resources.trash_bin__1_;
            this.btnDelete.ImageAutoCenter = true;
            this.btnDelete.ImageExpand = new System.Drawing.Point(1, 1);
            this.btnDelete.ImageOffset = new System.Drawing.Point(-1, 0);
            this.btnDelete.Location = new System.Drawing.Point(705, 344);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnDelete.NormalForeColor = System.Drawing.Color.DimGray;
            this.btnDelete.NormalImageTint = System.Drawing.Color.DimGray;
            this.btnDelete.NormalOutline = System.Drawing.Color.Transparent;
            this.btnDelete.OutlineThickness = 1F;
            this.btnDelete.PressedBackground = System.Drawing.Color.LightGray;
            this.btnDelete.PressedForeColor = System.Drawing.Color.DimGray;
            this.btnDelete.PressedImageTint = System.Drawing.Color.DimGray;
            this.btnDelete.PressedOutline = System.Drawing.Color.DimGray;
            this.btnDelete.Rounding = new System.Windows.Forms.Padding(15);
            this.btnDelete.Size = new System.Drawing.Size(82, 32);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDelete.TextOffset = new System.Drawing.Point(1, 0);
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.CheckButton = false;
            this.btnImport.Checked = false;
            this.btnImport.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnImport.CheckedForeColor = System.Drawing.Color.White;
            this.btnImport.CheckedImageTint = System.Drawing.Color.White;
            this.btnImport.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnImport.Content = "Improt";
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnImport.ForeColor = System.Drawing.Color.DimGray;
            this.btnImport.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnImport.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnImport.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnImport.HoverOutline = System.Drawing.Color.DimGray;
            this.btnImport.Image = global::DVLD_Project.Properties.Resources.import;
            this.btnImport.ImageAutoCenter = true;
            this.btnImport.ImageExpand = new System.Drawing.Point(1, 1);
            this.btnImport.ImageOffset = new System.Drawing.Point(-1, 0);
            this.btnImport.Location = new System.Drawing.Point(612, 344);
            this.btnImport.Name = "btnImport";
            this.btnImport.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnImport.NormalForeColor = System.Drawing.Color.DimGray;
            this.btnImport.NormalImageTint = System.Drawing.Color.DimGray;
            this.btnImport.NormalOutline = System.Drawing.Color.Transparent;
            this.btnImport.OutlineThickness = 1F;
            this.btnImport.PressedBackground = System.Drawing.Color.LightGray;
            this.btnImport.PressedForeColor = System.Drawing.Color.DimGray;
            this.btnImport.PressedImageTint = System.Drawing.Color.DimGray;
            this.btnImport.PressedOutline = System.Drawing.Color.DimGray;
            this.btnImport.Rounding = new System.Windows.Forms.Padding(15);
            this.btnImport.Size = new System.Drawing.Size(82, 32);
            this.btnImport.TabIndex = 18;
            this.btnImport.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnImport.TextOffset = new System.Drawing.Point(1, 0);
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnSavePerson
            // 
            this.btnSavePerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSavePerson.CheckButton = false;
            this.btnSavePerson.Checked = false;
            this.btnSavePerson.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSavePerson.CheckedForeColor = System.Drawing.Color.White;
            this.btnSavePerson.CheckedImageTint = System.Drawing.Color.White;
            this.btnSavePerson.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSavePerson.Content = "Save Person";
            this.btnSavePerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSavePerson.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSavePerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSavePerson.ForeColor = System.Drawing.Color.DimGray;
            this.btnSavePerson.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnSavePerson.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnSavePerson.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnSavePerson.HoverOutline = System.Drawing.Color.DimGray;
            this.btnSavePerson.Image = global::DVLD_Project.Properties.Resources.save;
            this.btnSavePerson.ImageAutoCenter = true;
            this.btnSavePerson.ImageExpand = new System.Drawing.Point(1, 1);
            this.btnSavePerson.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnSavePerson.Location = new System.Drawing.Point(612, 394);
            this.btnSavePerson.Name = "btnSavePerson";
            this.btnSavePerson.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnSavePerson.NormalForeColor = System.Drawing.Color.DimGray;
            this.btnSavePerson.NormalImageTint = System.Drawing.Color.DimGray;
            this.btnSavePerson.NormalOutline = System.Drawing.Color.Transparent;
            this.btnSavePerson.OutlineThickness = 1F;
            this.btnSavePerson.PressedBackground = System.Drawing.Color.LightGray;
            this.btnSavePerson.PressedForeColor = System.Drawing.Color.DimGray;
            this.btnSavePerson.PressedImageTint = System.Drawing.Color.DimGray;
            this.btnSavePerson.PressedOutline = System.Drawing.Color.DimGray;
            this.btnSavePerson.Rounding = new System.Windows.Forms.Padding(15);
            this.btnSavePerson.Size = new System.Drawing.Size(175, 32);
            this.btnSavePerson.TabIndex = 17;
            this.btnSavePerson.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSavePerson.TextOffset = new System.Drawing.Point(2, 0);
            this.btnSavePerson.Click += new System.EventHandler(this.btnSavePerson_Click);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Content = new System.DateTime(2025, 10, 22, 0, 0, 0, 0);
            this.dtpDateOfBirth.EnableThemeChangeButton = true;
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtpDateOfBirth.ForeColor = System.Drawing.Color.DimGray;
            this.dtpDateOfBirth.HoverBackground = System.Drawing.Color.Gainsboro;
            this.dtpDateOfBirth.HoverOutline = System.Drawing.Color.DimGray;
            this.dtpDateOfBirth.Icon = ((System.Drawing.Image)(resources.GetObject("dtpDateOfBirth.Icon")));
            this.dtpDateOfBirth.IconTint = System.Drawing.Color.Gray;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(426, 163);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.NormalBackground = System.Drawing.Color.Gainsboro;
            this.dtpDateOfBirth.NormalOutline = System.Drawing.Color.Gainsboro;
            this.dtpDateOfBirth.OutlineThickness = 1.5F;
            this.dtpDateOfBirth.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom;
            this.dtpDateOfBirth.PressedBackground = System.Drawing.Color.LightGray;
            this.dtpDateOfBirth.PressedOutline = System.Drawing.Color.DimGray;
            this.dtpDateOfBirth.Rounding = 15;
            this.dtpDateOfBirth.ShowIcon = false;
            this.dtpDateOfBirth.Size = new System.Drawing.Size(175, 32);
            this.dtpDateOfBirth.TabIndex = 15;
            this.dtpDateOfBirth.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            // 
            // cuiPictureBox6
            // 
            this.cuiPictureBox6.Content = global::DVLD_Project.Properties.Resources.home;
            this.cuiPictureBox6.Enabled = false;
            this.cuiPictureBox6.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox6.Location = new System.Drawing.Point(12, 310);
            this.cuiPictureBox6.Name = "cuiPictureBox6";
            this.cuiPictureBox6.OutlineThickness = 1F;
            this.cuiPictureBox6.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox6.Rotation = 0;
            this.cuiPictureBox6.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPictureBox6.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox6.TabIndex = 11;
            // 
            // cuiPictureBox5
            // 
            this.cuiPictureBox5.Content = global::DVLD_Project.Properties.Resources.at_sign__1_;
            this.cuiPictureBox5.Enabled = false;
            this.cuiPictureBox5.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox5.Location = new System.Drawing.Point(12, 261);
            this.cuiPictureBox5.Name = "cuiPictureBox5";
            this.cuiPictureBox5.OutlineThickness = 0F;
            this.cuiPictureBox5.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox5.Rotation = 0;
            this.cuiPictureBox5.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPictureBox5.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox5.TabIndex = 11;
            // 
            // cuiPictureBox4
            // 
            this.cuiPictureBox4.Content = global::DVLD_Project.Properties.Resources.toilet;
            this.cuiPictureBox4.Enabled = false;
            this.cuiPictureBox4.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox4.Location = new System.Drawing.Point(12, 212);
            this.cuiPictureBox4.Name = "cuiPictureBox4";
            this.cuiPictureBox4.OutlineThickness = 1F;
            this.cuiPictureBox4.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox4.Rotation = 0;
            this.cuiPictureBox4.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox4.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox4.TabIndex = 11;
            // 
            // cuiPictureBox3
            // 
            this.cuiPictureBox3.Content = global::DVLD_Project.Properties.Resources.id_card;
            this.cuiPictureBox3.Enabled = false;
            this.cuiPictureBox3.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox3.Location = new System.Drawing.Point(12, 163);
            this.cuiPictureBox3.Name = "cuiPictureBox3";
            this.cuiPictureBox3.OutlineThickness = 1F;
            this.cuiPictureBox3.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox3.Rotation = 0;
            this.cuiPictureBox3.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox3.TabIndex = 11;
            // 
            // cuiPictureBox9
            // 
            this.cuiPictureBox9.Content = global::DVLD_Project.Properties.Resources.flag;
            this.cuiPictureBox9.Enabled = false;
            this.cuiPictureBox9.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox9.Location = new System.Drawing.Point(387, 261);
            this.cuiPictureBox9.Name = "cuiPictureBox9";
            this.cuiPictureBox9.OutlineThickness = 1F;
            this.cuiPictureBox9.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox9.Rotation = 0;
            this.cuiPictureBox9.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox9.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox9.TabIndex = 11;
            // 
            // cuiPictureBox8
            // 
            this.cuiPictureBox8.Content = global::DVLD_Project.Properties.Resources.phone_set;
            this.cuiPictureBox8.Enabled = false;
            this.cuiPictureBox8.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox8.Location = new System.Drawing.Point(387, 212);
            this.cuiPictureBox8.Name = "cuiPictureBox8";
            this.cuiPictureBox8.OutlineThickness = 1F;
            this.cuiPictureBox8.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox8.Rotation = 0;
            this.cuiPictureBox8.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox8.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox8.TabIndex = 11;
            // 
            // cuiPictureBox7
            // 
            this.cuiPictureBox7.Content = global::DVLD_Project.Properties.Resources.calendar__1_;
            this.cuiPictureBox7.Enabled = false;
            this.cuiPictureBox7.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox7.Location = new System.Drawing.Point(387, 163);
            this.cuiPictureBox7.Name = "cuiPictureBox7";
            this.cuiPictureBox7.OutlineThickness = 1F;
            this.cuiPictureBox7.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox7.Rotation = 0;
            this.cuiPictureBox7.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox7.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox7.TabIndex = 11;
            // 
            // cuiPictureBox2
            // 
            this.cuiPictureBox2.Content = global::DVLD_Project.Properties.Resources.user__1_;
            this.cuiPictureBox2.Enabled = false;
            this.cuiPictureBox2.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox2.Location = new System.Drawing.Point(12, 114);
            this.cuiPictureBox2.Name = "cuiPictureBox2";
            this.cuiPictureBox2.OutlineThickness = 1F;
            this.cuiPictureBox2.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox2.Rotation = 0;
            this.cuiPictureBox2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox2.TabIndex = 11;
            // 
            // cuiPictureBox1
            // 
            this.cuiPictureBox1.Content = global::DVLD_Project.Properties.Resources.id_card;
            this.cuiPictureBox1.Enabled = false;
            this.cuiPictureBox1.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox1.Location = new System.Drawing.Point(12, 61);
            this.cuiPictureBox1.Name = "cuiPictureBox1";
            this.cuiPictureBox1.OutlineThickness = 1F;
            this.cuiPictureBox1.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox1.Rotation = 0;
            this.cuiPictureBox1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox1.TabIndex = 11;
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
            this.btnClose.Location = new System.Drawing.Point(763, 12);
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
            this.btnClose.TabIndex = 5;
            this.btnClose.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnClose.TextOffset = new System.Drawing.Point(0, 0);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbxPersonImage
            // 
            this.pbxPersonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxPersonImage.Location = new System.Drawing.Point(612, 163);
            this.pbxPersonImage.Name = "pbxPersonImage";
            this.pbxPersonImage.Size = new System.Drawing.Size(175, 175);
            this.pbxPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPersonImage.TabIndex = 22;
            this.pbxPersonImage.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // frmAddUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 439);
            this.Controls.Add(this.pbxPersonImage);
            this.Controls.Add(this.btnEditNationality);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.cbtnFemale);
            this.Controls.Add(this.cbtnMale);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnSavePerson);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.cbxNationality);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxThirdName);
            this.Controls.Add(this.tbxSecondName);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.tbxPhone);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxNationalNo);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.cuiPictureBox6);
            this.Controls.Add(this.cuiPictureBox5);
            this.Controls.Add(this.cuiPictureBox4);
            this.Controls.Add(this.cuiPictureBox3);
            this.Controls.Add(this.cuiPictureBox9);
            this.Controls.Add(this.cuiPictureBox8);
            this.Controls.Add(this.cuiPictureBox7);
            this.Controls.Add(this.cuiPictureBox2);
            this.Controls.Add(this.cuiPictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFormLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdatePerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddUpdatePerson";
            this.Load += new System.EventHandler(this.frmAddUpdatePerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
        private CuoreUI.Components.cuiFormAnimator cuiFormAnimator;
        private CuoreUI.Controls.cuiButton btnClose;
        private CuoreUI.Controls.cuiLabel lblFormLabel;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiLabel lblID;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox5;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox4;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox3;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox2;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox6;
        private CuoreUI.Controls.cuiTextBox tbxLastName;
        private CuoreUI.Controls.cuiTextBox tbxThirdName;
        private CuoreUI.Controls.cuiTextBox tbxSecondName;
        private CuoreUI.Controls.cuiTextBox tbxFirstName;
        private CuoreUI.Controls.cuiTextBox tbxNationalNo;
        private CuoreUI.Controls.cuiTextBox tbxAddress;
        private CuoreUI.Controls.cuiTextBox tbxPhone;
        private CuoreUI.Controls.cuiCalendarDatePicker dtpDateOfBirth;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox9;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox8;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox7;
        private CuoreUI.Controls.cuiButton btnSavePerson;
        private CuoreUI.Controls.cuiButton btnDelete;
        private CuoreUI.Controls.cuiButton btnImport;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder;
        private CuoreUI.Controls.cuiButtonGroup cbtnFemale;
        private CuoreUI.Controls.cuiButtonGroup cbtnMale;
        private CuoreUI.Controls.cuiButton btnMinimize;
        private CuoreUI.Controls.cuiComboBox cbxNationality;
        private CuoreUI.Controls.cuiButton btnEditNationality;
        private System.Windows.Forms.PictureBox pbxPersonImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private CuoreUI.Controls.cuiTextBox tbxEmail;
    }
}