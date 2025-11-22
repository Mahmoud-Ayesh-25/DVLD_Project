namespace DVLD_Project.Users
{
    partial class frmAddUpdateUser
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
            this.lblTitle = new CuoreUI.Controls.cuiLabel();
            this.pnlFindUser = new CuoreUI.Controls.cuiPanel();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.pnlUserDetails = new CuoreUI.Controls.cuiPanel();
            this.lblUserID = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            this.lblUsername = new CuoreUI.Controls.cuiLabel();
            this.schActive = new CuoreUI.Controls.cuiSwitch();
            this.tbxConfirmPassword = new CuoreUI.Controls.cuiTextBox();
            this.tbxCurrentPassword = new CuoreUI.Controls.cuiTextBox();
            this.tbxPassword = new CuoreUI.Controls.cuiTextBox();
            this.tbxUsername = new CuoreUI.Controls.cuiTextBox();
            this.cuiFormRounder = new CuoreUI.Components.cuiFormRounder();
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.cuiFormAnimator = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.ctrlFindPerson = new DVLD_Project.People.ctrlFindPerson();
            this.btnClose = new CuoreUI.Controls.cuiButton();
            this.btnMinimize = new CuoreUI.Controls.cuiButton();
            this.btnNext = new CuoreUI.Controls.cuiButton();
            this.btnShowConfirmPass = new CuoreUI.Controls.cuiButton();
            this.btnShowCurrentPass = new CuoreUI.Controls.cuiButton();
            this.btnShowPass = new CuoreUI.Controls.cuiButton();
            this.cuiPictureBox4 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox2 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox5 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox3 = new CuoreUI.Controls.cuiPictureBox();
            this.btnChangePassword = new CuoreUI.Controls.cuiButton();
            this.btnSave = new CuoreUI.Controls.cuiButton();
            this.btnBack = new CuoreUI.Controls.cuiButton();
            this.pnlFindUser.SuspendLayout();
            this.pnlUserDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.Content = "Add\\ User";
            this.lblTitle.Enabled = false;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(780, 25);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // pnlFindUser
            // 
            this.pnlFindUser.Controls.Add(this.cuiLabel2);
            this.pnlFindUser.Controls.Add(this.btnNext);
            this.pnlFindUser.Controls.Add(this.ctrlFindPerson);
            this.pnlFindUser.ImeMode = System.Windows.Forms.ImeMode.On;
            this.pnlFindUser.Location = new System.Drawing.Point(0, 43);
            this.pnlFindUser.Name = "pnlFindUser";
            this.pnlFindUser.OutlineThickness = 1F;
            this.pnlFindUser.PanelColor = System.Drawing.Color.White;
            this.pnlFindUser.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlFindUser.Rounding = new System.Windows.Forms.Padding(8);
            this.pnlFindUser.Size = new System.Drawing.Size(804, 460);
            this.pnlFindUser.TabIndex = 13;
            // 
            // cuiLabel2
            // 
            this.cuiLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cuiLabel2.Content = "Find\\ Person";
            this.cuiLabel2.Enabled = false;
            this.cuiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel2.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel2.Location = new System.Drawing.Point(12, 4);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Size = new System.Drawing.Size(780, 25);
            this.cuiLabel2.TabIndex = 15;
            this.cuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // pnlUserDetails
            // 
            this.pnlUserDetails.Controls.Add(this.btnShowConfirmPass);
            this.pnlUserDetails.Controls.Add(this.btnShowCurrentPass);
            this.pnlUserDetails.Controls.Add(this.btnShowPass);
            this.pnlUserDetails.Controls.Add(this.lblUserID);
            this.pnlUserDetails.Controls.Add(this.cuiPictureBox4);
            this.pnlUserDetails.Controls.Add(this.cuiPictureBox2);
            this.pnlUserDetails.Controls.Add(this.cuiPictureBox1);
            this.pnlUserDetails.Controls.Add(this.cuiPictureBox5);
            this.pnlUserDetails.Controls.Add(this.cuiPictureBox3);
            this.pnlUserDetails.Controls.Add(this.cuiLabel3);
            this.pnlUserDetails.Controls.Add(this.btnChangePassword);
            this.pnlUserDetails.Controls.Add(this.btnSave);
            this.pnlUserDetails.Controls.Add(this.btnBack);
            this.pnlUserDetails.Controls.Add(this.lblUsername);
            this.pnlUserDetails.Controls.Add(this.schActive);
            this.pnlUserDetails.Controls.Add(this.tbxConfirmPassword);
            this.pnlUserDetails.Controls.Add(this.tbxCurrentPassword);
            this.pnlUserDetails.Controls.Add(this.tbxPassword);
            this.pnlUserDetails.Controls.Add(this.tbxUsername);
            this.pnlUserDetails.Location = new System.Drawing.Point(0, 43);
            this.pnlUserDetails.Name = "pnlUserDetails";
            this.pnlUserDetails.OutlineThickness = 1F;
            this.pnlUserDetails.PanelColor = System.Drawing.Color.White;
            this.pnlUserDetails.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlUserDetails.Rounding = new System.Windows.Forms.Padding(8);
            this.pnlUserDetails.Size = new System.Drawing.Size(804, 460);
            this.pnlUserDetails.TabIndex = 14;
            // 
            // lblUserID
            // 
            this.lblUserID.Content = "User\\ ID\\ :";
            this.lblUserID.Enabled = false;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.DimGray;
            this.lblUserID.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblUserID.Location = new System.Drawing.Point(51, 41);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(265, 32);
            this.lblUserID.TabIndex = 40;
            this.lblUserID.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel3
            // 
            this.cuiLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cuiLabel3.Content = "User\\ Details";
            this.cuiLabel3.Enabled = false;
            this.cuiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel3.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel3.Location = new System.Drawing.Point(12, 4);
            this.cuiLabel3.Name = "cuiLabel3";
            this.cuiLabel3.Size = new System.Drawing.Size(780, 25);
            this.cuiLabel3.TabIndex = 35;
            this.cuiLabel3.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblUsername
            // 
            this.lblUsername.Content = "Active";
            this.lblUsername.Enabled = false;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.DimGray;
            this.lblUsername.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblUsername.Location = new System.Drawing.Point(51, 290);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(53, 26);
            this.lblUsername.TabIndex = 33;
            this.lblUsername.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // schActive
            // 
            this.schActive.Checked = true;
            this.schActive.CheckedBackground = System.Drawing.Color.DimGray;
            this.schActive.CheckedForeground = System.Drawing.Color.White;
            this.schActive.CheckedOutlineColor = System.Drawing.Color.Empty;
            this.schActive.CheckedSymbolColor = System.Drawing.Color.DimGray;
            this.schActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.schActive.Location = new System.Drawing.Point(110, 290);
            this.schActive.MinimumSize = new System.Drawing.Size(12, 8);
            this.schActive.Name = "schActive";
            this.schActive.OutlineThickness = 1F;
            this.schActive.ShowSymbols = false;
            this.schActive.Size = new System.Drawing.Size(48, 26);
            this.schActive.TabIndex = 4;
            this.schActive.ThumbSizeModifier = new System.Drawing.Size(0, 0);
            this.schActive.UncheckedBackground = System.Drawing.Color.Gainsboro;
            this.schActive.UncheckedForeground = System.Drawing.Color.White;
            this.schActive.UncheckedOutlineColor = System.Drawing.Color.Empty;
            this.schActive.UncheckedSymbolColor = System.Drawing.Color.Gainsboro;
            // 
            // tbxConfirmPassword
            // 
            this.tbxConfirmPassword.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tbxConfirmPassword.Content = "";
            this.tbxConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxConfirmPassword.FocusBackgroundColor = System.Drawing.Color.White;
            this.tbxConfirmPassword.FocusImageTint = System.Drawing.Color.White;
            this.tbxConfirmPassword.FocusOutlineColor = System.Drawing.Color.Black;
            this.tbxConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.tbxConfirmPassword.Image = null;
            this.tbxConfirmPassword.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxConfirmPassword.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxConfirmPassword.Location = new System.Drawing.Point(51, 224);
            this.tbxConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbxConfirmPassword.Multiline = false;
            this.tbxConfirmPassword.Name = "tbxConfirmPassword";
            this.tbxConfirmPassword.NormalImageTint = System.Drawing.Color.DimGray;
            this.tbxConfirmPassword.OutlineColor = System.Drawing.Color.Gainsboro;
            this.tbxConfirmPassword.Padding = new System.Windows.Forms.Padding(15, 9, 15, 0);
            this.tbxConfirmPassword.PasswordChar = true;
            this.tbxConfirmPassword.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxConfirmPassword.PlaceholderText = "Confirm Passowrd";
            this.tbxConfirmPassword.Rounding = new System.Windows.Forms.Padding(15);
            this.tbxConfirmPassword.Size = new System.Drawing.Size(226, 32);
            this.tbxConfirmPassword.TabIndex = 3;
            this.tbxConfirmPassword.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxConfirmPassword.UnderlinedStyle = false;
            this.tbxConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbxConfirmPassword_Validating);
            // 
            // tbxCurrentPassword
            // 
            this.tbxCurrentPassword.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tbxCurrentPassword.Content = "";
            this.tbxCurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxCurrentPassword.FocusBackgroundColor = System.Drawing.Color.White;
            this.tbxCurrentPassword.FocusImageTint = System.Drawing.Color.White;
            this.tbxCurrentPassword.FocusOutlineColor = System.Drawing.Color.Black;
            this.tbxCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCurrentPassword.ForeColor = System.Drawing.Color.Black;
            this.tbxCurrentPassword.Image = null;
            this.tbxCurrentPassword.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxCurrentPassword.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxCurrentPassword.Location = new System.Drawing.Point(51, 163);
            this.tbxCurrentPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCurrentPassword.Multiline = false;
            this.tbxCurrentPassword.Name = "tbxCurrentPassword";
            this.tbxCurrentPassword.NormalImageTint = System.Drawing.Color.DimGray;
            this.tbxCurrentPassword.OutlineColor = System.Drawing.Color.Gainsboro;
            this.tbxCurrentPassword.Padding = new System.Windows.Forms.Padding(15, 9, 15, 0);
            this.tbxCurrentPassword.PasswordChar = true;
            this.tbxCurrentPassword.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxCurrentPassword.PlaceholderText = "Current Password";
            this.tbxCurrentPassword.Rounding = new System.Windows.Forms.Padding(15);
            this.tbxCurrentPassword.Size = new System.Drawing.Size(226, 32);
            this.tbxCurrentPassword.TabIndex = 3;
            this.tbxCurrentPassword.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxCurrentPassword.UnderlinedStyle = false;
            this.tbxCurrentPassword.Visible = false;
            this.tbxCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbxCurrentPassword_Validating);
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tbxPassword.Content = "";
            this.tbxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPassword.FocusBackgroundColor = System.Drawing.Color.White;
            this.tbxPassword.FocusImageTint = System.Drawing.Color.White;
            this.tbxPassword.FocusOutlineColor = System.Drawing.Color.Black;
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.ForeColor = System.Drawing.Color.Black;
            this.tbxPassword.Image = null;
            this.tbxPassword.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxPassword.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxPassword.Location = new System.Drawing.Point(51, 163);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPassword.Multiline = false;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.NormalImageTint = System.Drawing.Color.DimGray;
            this.tbxPassword.OutlineColor = System.Drawing.Color.Gainsboro;
            this.tbxPassword.Padding = new System.Windows.Forms.Padding(15, 9, 15, 0);
            this.tbxPassword.PasswordChar = true;
            this.tbxPassword.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxPassword.PlaceholderText = "Password";
            this.tbxPassword.Rounding = new System.Windows.Forms.Padding(15);
            this.tbxPassword.Size = new System.Drawing.Size(226, 32);
            this.tbxPassword.TabIndex = 3;
            this.tbxPassword.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxPassword.UnderlinedStyle = false;
            this.tbxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbxPassword_Validating);
            // 
            // tbxUsername
            // 
            this.tbxUsername.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tbxUsername.Content = "";
            this.tbxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxUsername.FocusBackgroundColor = System.Drawing.Color.White;
            this.tbxUsername.FocusImageTint = System.Drawing.Color.White;
            this.tbxUsername.FocusOutlineColor = System.Drawing.Color.Black;
            this.tbxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsername.ForeColor = System.Drawing.Color.Black;
            this.tbxUsername.Image = null;
            this.tbxUsername.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxUsername.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxUsername.Location = new System.Drawing.Point(51, 102);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.tbxUsername.Multiline = false;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.NormalImageTint = System.Drawing.Color.DimGray;
            this.tbxUsername.OutlineColor = System.Drawing.Color.Gainsboro;
            this.tbxUsername.Padding = new System.Windows.Forms.Padding(15, 9, 15, 0);
            this.tbxUsername.PasswordChar = false;
            this.tbxUsername.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxUsername.PlaceholderText = "Username";
            this.tbxUsername.Rounding = new System.Windows.Forms.Padding(15);
            this.tbxUsername.Size = new System.Drawing.Size(265, 32);
            this.tbxUsername.TabIndex = 3;
            this.tbxUsername.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxUsername.UnderlinedStyle = false;
            this.tbxUsername.Validating += new System.ComponentModel.CancelEventHandler(this.tbxUsername_Validating);
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
            // ctrlFindPerson
            // 
            this.ctrlFindPerson.BackColor = System.Drawing.Color.White;
            this.ctrlFindPerson.Location = new System.Drawing.Point(12, 41);
            this.ctrlFindPerson.Name = "ctrlFindPerson";
            this.ctrlFindPerson.Size = new System.Drawing.Size(780, 368);
            this.ctrlFindPerson.TabIndex = 0;
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
            this.btnClose.Location = new System.Drawing.Point(767, 12);
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
            this.btnClose.TabIndex = 10;
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
            this.btnMinimize.Location = new System.Drawing.Point(736, 12);
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
            this.btnMinimize.TabIndex = 11;
            this.btnMinimize.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnMinimize.TextOffset = new System.Drawing.Point(0, 0);
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.CheckButton = false;
            this.btnNext.Checked = false;
            this.btnNext.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnNext.CheckedForeColor = System.Drawing.Color.White;
            this.btnNext.CheckedImageTint = System.Drawing.Color.White;
            this.btnNext.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnNext.Content = "Next";
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnNext.ForeColor = System.Drawing.Color.DimGray;
            this.btnNext.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnNext.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnNext.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnNext.HoverOutline = System.Drawing.Color.DimGray;
            this.btnNext.Image = global::DVLD_Project.Properties.Resources.right_arrow;
            this.btnNext.ImageAutoCenter = true;
            this.btnNext.ImageExpand = new System.Drawing.Point(1, 1);
            this.btnNext.ImageOffset = new System.Drawing.Point(32, 0);
            this.btnNext.Location = new System.Drawing.Point(639, 416);
            this.btnNext.Name = "btnNext";
            this.btnNext.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnNext.NormalForeColor = System.Drawing.Color.DimGray;
            this.btnNext.NormalImageTint = System.Drawing.Color.DimGray;
            this.btnNext.NormalOutline = System.Drawing.Color.Transparent;
            this.btnNext.OutlineThickness = 1F;
            this.btnNext.PressedBackground = System.Drawing.Color.LightGray;
            this.btnNext.PressedForeColor = System.Drawing.Color.DimGray;
            this.btnNext.PressedImageTint = System.Drawing.Color.DimGray;
            this.btnNext.PressedOutline = System.Drawing.Color.DimGray;
            this.btnNext.Rounding = new System.Windows.Forms.Padding(15);
            this.btnNext.Size = new System.Drawing.Size(153, 32);
            this.btnNext.TabIndex = 4;
            this.btnNext.TextAlignment = System.Drawing.StringAlignment.Near;
            this.btnNext.TextOffset = new System.Drawing.Point(42, 0);
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnShowConfirmPass
            // 
            this.btnShowConfirmPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowConfirmPass.BackColor = System.Drawing.Color.Transparent;
            this.btnShowConfirmPass.CheckButton = false;
            this.btnShowConfirmPass.Checked = false;
            this.btnShowConfirmPass.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnShowConfirmPass.CheckedForeColor = System.Drawing.Color.White;
            this.btnShowConfirmPass.CheckedImageTint = System.Drawing.Color.White;
            this.btnShowConfirmPass.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnShowConfirmPass.Content = "";
            this.btnShowConfirmPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowConfirmPass.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnShowConfirmPass.ForeColor = System.Drawing.Color.DimGray;
            this.btnShowConfirmPass.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnShowConfirmPass.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnShowConfirmPass.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnShowConfirmPass.HoverOutline = System.Drawing.Color.DimGray;
            this.btnShowConfirmPass.Image = global::DVLD_Project.Properties.Resources.show__1_;
            this.btnShowConfirmPass.ImageAutoCenter = true;
            this.btnShowConfirmPass.ImageExpand = new System.Drawing.Point(2, 2);
            this.btnShowConfirmPass.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnShowConfirmPass.Location = new System.Drawing.Point(284, 224);
            this.btnShowConfirmPass.Name = "btnShowConfirmPass";
            this.btnShowConfirmPass.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnShowConfirmPass.NormalForeColor = System.Drawing.Color.DimGray;
            this.btnShowConfirmPass.NormalImageTint = System.Drawing.Color.DimGray;
            this.btnShowConfirmPass.NormalOutline = System.Drawing.Color.Transparent;
            this.btnShowConfirmPass.OutlineThickness = 1F;
            this.btnShowConfirmPass.PressedBackground = System.Drawing.Color.LightGray;
            this.btnShowConfirmPass.PressedForeColor = System.Drawing.Color.DimGray;
            this.btnShowConfirmPass.PressedImageTint = System.Drawing.Color.DimGray;
            this.btnShowConfirmPass.PressedOutline = System.Drawing.Color.DimGray;
            this.btnShowConfirmPass.Rounding = new System.Windows.Forms.Padding(15);
            this.btnShowConfirmPass.Size = new System.Drawing.Size(32, 32);
            this.btnShowConfirmPass.TabIndex = 47;
            this.btnShowConfirmPass.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnShowConfirmPass.TextOffset = new System.Drawing.Point(0, 0);
            this.btnShowConfirmPass.Click += new System.EventHandler(this.btnShowConfirmPass_Click);
            // 
            // btnShowCurrentPass
            // 
            this.btnShowCurrentPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowCurrentPass.BackColor = System.Drawing.Color.Transparent;
            this.btnShowCurrentPass.CheckButton = false;
            this.btnShowCurrentPass.Checked = false;
            this.btnShowCurrentPass.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnShowCurrentPass.CheckedForeColor = System.Drawing.Color.White;
            this.btnShowCurrentPass.CheckedImageTint = System.Drawing.Color.White;
            this.btnShowCurrentPass.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnShowCurrentPass.Content = "";
            this.btnShowCurrentPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowCurrentPass.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowCurrentPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnShowCurrentPass.ForeColor = System.Drawing.Color.DimGray;
            this.btnShowCurrentPass.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnShowCurrentPass.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnShowCurrentPass.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnShowCurrentPass.HoverOutline = System.Drawing.Color.DimGray;
            this.btnShowCurrentPass.Image = global::DVLD_Project.Properties.Resources.show__1_;
            this.btnShowCurrentPass.ImageAutoCenter = true;
            this.btnShowCurrentPass.ImageExpand = new System.Drawing.Point(2, 2);
            this.btnShowCurrentPass.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnShowCurrentPass.Location = new System.Drawing.Point(284, 163);
            this.btnShowCurrentPass.Name = "btnShowCurrentPass";
            this.btnShowCurrentPass.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnShowCurrentPass.NormalForeColor = System.Drawing.Color.DimGray;
            this.btnShowCurrentPass.NormalImageTint = System.Drawing.Color.DimGray;
            this.btnShowCurrentPass.NormalOutline = System.Drawing.Color.Transparent;
            this.btnShowCurrentPass.OutlineThickness = 1F;
            this.btnShowCurrentPass.PressedBackground = System.Drawing.Color.LightGray;
            this.btnShowCurrentPass.PressedForeColor = System.Drawing.Color.DimGray;
            this.btnShowCurrentPass.PressedImageTint = System.Drawing.Color.DimGray;
            this.btnShowCurrentPass.PressedOutline = System.Drawing.Color.DimGray;
            this.btnShowCurrentPass.Rounding = new System.Windows.Forms.Padding(15);
            this.btnShowCurrentPass.Size = new System.Drawing.Size(32, 32);
            this.btnShowCurrentPass.TabIndex = 46;
            this.btnShowCurrentPass.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnShowCurrentPass.TextOffset = new System.Drawing.Point(0, 0);
            this.btnShowCurrentPass.Visible = false;
            this.btnShowCurrentPass.Click += new System.EventHandler(this.btnShowCurrentPass_Click);
            // 
            // btnShowPass
            // 
            this.btnShowPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowPass.BackColor = System.Drawing.Color.Transparent;
            this.btnShowPass.CheckButton = false;
            this.btnShowPass.Checked = false;
            this.btnShowPass.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnShowPass.CheckedForeColor = System.Drawing.Color.White;
            this.btnShowPass.CheckedImageTint = System.Drawing.Color.White;
            this.btnShowPass.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnShowPass.Content = "";
            this.btnShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPass.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnShowPass.ForeColor = System.Drawing.Color.DimGray;
            this.btnShowPass.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnShowPass.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnShowPass.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnShowPass.HoverOutline = System.Drawing.Color.DimGray;
            this.btnShowPass.Image = global::DVLD_Project.Properties.Resources.show__1_;
            this.btnShowPass.ImageAutoCenter = true;
            this.btnShowPass.ImageExpand = new System.Drawing.Point(2, 2);
            this.btnShowPass.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnShowPass.Location = new System.Drawing.Point(284, 163);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnShowPass.NormalForeColor = System.Drawing.Color.DimGray;
            this.btnShowPass.NormalImageTint = System.Drawing.Color.DimGray;
            this.btnShowPass.NormalOutline = System.Drawing.Color.Transparent;
            this.btnShowPass.OutlineThickness = 1F;
            this.btnShowPass.PressedBackground = System.Drawing.Color.LightGray;
            this.btnShowPass.PressedForeColor = System.Drawing.Color.DimGray;
            this.btnShowPass.PressedImageTint = System.Drawing.Color.DimGray;
            this.btnShowPass.PressedOutline = System.Drawing.Color.DimGray;
            this.btnShowPass.Rounding = new System.Windows.Forms.Padding(15);
            this.btnShowPass.Size = new System.Drawing.Size(32, 32);
            this.btnShowPass.TabIndex = 46;
            this.btnShowPass.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnShowPass.TextOffset = new System.Drawing.Point(0, 0);
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // cuiPictureBox4
            // 
            this.cuiPictureBox4.Content = global::DVLD_Project.Properties.Resources.user_check;
            this.cuiPictureBox4.Enabled = false;
            this.cuiPictureBox4.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox4.Location = new System.Drawing.Point(12, 285);
            this.cuiPictureBox4.Name = "cuiPictureBox4";
            this.cuiPictureBox4.OutlineThickness = 1F;
            this.cuiPictureBox4.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox4.Rotation = 0;
            this.cuiPictureBox4.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox4.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox4.TabIndex = 39;
            // 
            // cuiPictureBox2
            // 
            this.cuiPictureBox2.Content = global::DVLD_Project.Properties.Resources.password;
            this.cuiPictureBox2.Enabled = false;
            this.cuiPictureBox2.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox2.Location = new System.Drawing.Point(12, 163);
            this.cuiPictureBox2.Name = "cuiPictureBox2";
            this.cuiPictureBox2.OutlineThickness = 1F;
            this.cuiPictureBox2.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox2.Rotation = 0;
            this.cuiPictureBox2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox2.TabIndex = 38;
            // 
            // cuiPictureBox1
            // 
            this.cuiPictureBox1.Content = global::DVLD_Project.Properties.Resources.password;
            this.cuiPictureBox1.Enabled = false;
            this.cuiPictureBox1.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox1.Location = new System.Drawing.Point(12, 224);
            this.cuiPictureBox1.Name = "cuiPictureBox1";
            this.cuiPictureBox1.OutlineThickness = 1F;
            this.cuiPictureBox1.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox1.Rotation = 0;
            this.cuiPictureBox1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox1.TabIndex = 37;
            // 
            // cuiPictureBox5
            // 
            this.cuiPictureBox5.Content = global::DVLD_Project.Properties.Resources.id_card;
            this.cuiPictureBox5.Enabled = false;
            this.cuiPictureBox5.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox5.Location = new System.Drawing.Point(12, 41);
            this.cuiPictureBox5.Name = "cuiPictureBox5";
            this.cuiPictureBox5.OutlineThickness = 1F;
            this.cuiPictureBox5.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox5.Rotation = 0;
            this.cuiPictureBox5.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox5.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox5.TabIndex = 36;
            // 
            // cuiPictureBox3
            // 
            this.cuiPictureBox3.Content = global::DVLD_Project.Properties.Resources.id_card;
            this.cuiPictureBox3.Enabled = false;
            this.cuiPictureBox3.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox3.Location = new System.Drawing.Point(12, 102);
            this.cuiPictureBox3.Name = "cuiPictureBox3";
            this.cuiPictureBox3.OutlineThickness = 1F;
            this.cuiPictureBox3.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox3.Rotation = 0;
            this.cuiPictureBox3.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox3.TabIndex = 36;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePassword.CheckButton = false;
            this.btnChangePassword.Checked = false;
            this.btnChangePassword.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnChangePassword.CheckedForeColor = System.Drawing.Color.White;
            this.btnChangePassword.CheckedImageTint = System.Drawing.Color.White;
            this.btnChangePassword.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnChangePassword.Content = "Change Password";
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnChangePassword.ForeColor = System.Drawing.Color.DimGray;
            this.btnChangePassword.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnChangePassword.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnChangePassword.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnChangePassword.HoverOutline = System.Drawing.Color.DimGray;
            this.btnChangePassword.Image = global::DVLD_Project.Properties.Resources.password;
            this.btnChangePassword.ImageAutoCenter = true;
            this.btnChangePassword.ImageExpand = new System.Drawing.Point(1, 1);
            this.btnChangePassword.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnChangePassword.Location = new System.Drawing.Point(321, 416);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnChangePassword.NormalForeColor = System.Drawing.Color.DimGray;
            this.btnChangePassword.NormalImageTint = System.Drawing.Color.DimGray;
            this.btnChangePassword.NormalOutline = System.Drawing.Color.Transparent;
            this.btnChangePassword.OutlineThickness = 1F;
            this.btnChangePassword.PressedBackground = System.Drawing.Color.LightGray;
            this.btnChangePassword.PressedForeColor = System.Drawing.Color.DimGray;
            this.btnChangePassword.PressedImageTint = System.Drawing.Color.DimGray;
            this.btnChangePassword.PressedOutline = System.Drawing.Color.DimGray;
            this.btnChangePassword.Rounding = new System.Windows.Forms.Padding(15);
            this.btnChangePassword.Size = new System.Drawing.Size(153, 32);
            this.btnChangePassword.TabIndex = 34;
            this.btnChangePassword.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnChangePassword.TextOffset = new System.Drawing.Point(2, 0);
            this.btnChangePassword.Visible = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.CheckButton = false;
            this.btnSave.Checked = false;
            this.btnSave.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSave.CheckedForeColor = System.Drawing.Color.White;
            this.btnSave.CheckedImageTint = System.Drawing.Color.White;
            this.btnSave.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSave.Content = "Save User";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSave.ForeColor = System.Drawing.Color.DimGray;
            this.btnSave.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnSave.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnSave.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnSave.HoverOutline = System.Drawing.Color.DimGray;
            this.btnSave.Image = global::DVLD_Project.Properties.Resources.save;
            this.btnSave.ImageAutoCenter = true;
            this.btnSave.ImageExpand = new System.Drawing.Point(1, 1);
            this.btnSave.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnSave.Location = new System.Drawing.Point(480, 416);
            this.btnSave.Name = "btnSave";
            this.btnSave.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnSave.NormalForeColor = System.Drawing.Color.DimGray;
            this.btnSave.NormalImageTint = System.Drawing.Color.DimGray;
            this.btnSave.NormalOutline = System.Drawing.Color.Transparent;
            this.btnSave.OutlineThickness = 1F;
            this.btnSave.PressedBackground = System.Drawing.Color.LightGray;
            this.btnSave.PressedForeColor = System.Drawing.Color.DimGray;
            this.btnSave.PressedImageTint = System.Drawing.Color.DimGray;
            this.btnSave.PressedOutline = System.Drawing.Color.DimGray;
            this.btnSave.Rounding = new System.Windows.Forms.Padding(15);
            this.btnSave.Size = new System.Drawing.Size(153, 32);
            this.btnSave.TabIndex = 34;
            this.btnSave.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSave.TextOffset = new System.Drawing.Point(2, 0);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.CheckButton = false;
            this.btnBack.Checked = false;
            this.btnBack.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnBack.CheckedForeColor = System.Drawing.Color.White;
            this.btnBack.CheckedImageTint = System.Drawing.Color.White;
            this.btnBack.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnBack.Content = "Back";
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnBack.ForeColor = System.Drawing.Color.DimGray;
            this.btnBack.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnBack.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnBack.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnBack.HoverOutline = System.Drawing.Color.DimGray;
            this.btnBack.Image = global::DVLD_Project.Properties.Resources.left_arrow;
            this.btnBack.ImageAutoCenter = true;
            this.btnBack.ImageExpand = new System.Drawing.Point(1, 1);
            this.btnBack.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnBack.Location = new System.Drawing.Point(639, 416);
            this.btnBack.Name = "btnBack";
            this.btnBack.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnBack.NormalForeColor = System.Drawing.Color.DimGray;
            this.btnBack.NormalImageTint = System.Drawing.Color.DimGray;
            this.btnBack.NormalOutline = System.Drawing.Color.Transparent;
            this.btnBack.OutlineThickness = 1F;
            this.btnBack.PressedBackground = System.Drawing.Color.LightGray;
            this.btnBack.PressedForeColor = System.Drawing.Color.DimGray;
            this.btnBack.PressedImageTint = System.Drawing.Color.DimGray;
            this.btnBack.PressedOutline = System.Drawing.Color.DimGray;
            this.btnBack.Rounding = new System.Windows.Forms.Padding(15);
            this.btnBack.Size = new System.Drawing.Size(153, 32);
            this.btnBack.TabIndex = 34;
            this.btnBack.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnBack.TextOffset = new System.Drawing.Point(2, 0);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 503);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlFindUser);
            this.Controls.Add(this.pnlUserDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddUser";
            this.pnlFindUser.ResumeLayout(false);
            this.pnlUserDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiButton btnClose;
        private CuoreUI.Controls.cuiButton btnMinimize;
        private CuoreUI.Controls.cuiLabel lblTitle;
        private People.ctrlFindPerson ctrlFindPerson;
        private CuoreUI.Controls.cuiButton btnNext;
        private CuoreUI.Controls.cuiPanel pnlFindUser;
        private CuoreUI.Controls.cuiPanel pnlUserDetails;
        private CuoreUI.Controls.cuiButton btnBack;
        private CuoreUI.Controls.cuiButton btnSave;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
        private CuoreUI.Components.cuiFormAnimator cuiFormAnimator;
        private CuoreUI.Controls.cuiLabel lblUserID;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox5;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox3;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox4;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox2;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiLabel lblUsername;
        private CuoreUI.Controls.cuiSwitch schActive;
        private CuoreUI.Controls.cuiTextBox tbxConfirmPassword;
        private CuoreUI.Controls.cuiTextBox tbxPassword;
        private CuoreUI.Controls.cuiTextBox tbxUsername;
        private CuoreUI.Controls.cuiButton btnShowConfirmPass;
        private CuoreUI.Controls.cuiButton btnShowPass;
        private CuoreUI.Controls.cuiButton btnShowCurrentPass;
        private CuoreUI.Controls.cuiTextBox tbxCurrentPassword;
        private CuoreUI.Controls.cuiButton btnChangePassword;
    }
}