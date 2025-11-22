namespace DVLD_Project.Users
{
    partial class frmChangePassword
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
            this.tbxNewPassword = new CuoreUI.Controls.cuiTextBox();
            this.tbxOldPassword = new CuoreUI.Controls.cuiTextBox();
            this.tbxConfirmPassword = new CuoreUI.Controls.cuiTextBox();
            this.cuiFormRounder = new CuoreUI.Components.cuiFormRounder();
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.cuiFormAnimator = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.lblUserID = new CuoreUI.Controls.cuiLabel();
            this.lblUsername = new CuoreUI.Controls.cuiLabel();
            this.btnShowConfirmPass = new CuoreUI.Controls.cuiButton();
            this.btnShowNewPass = new CuoreUI.Controls.cuiButton();
            this.btnShowOldPass = new CuoreUI.Controls.cuiButton();
            this.cuiPictureBox3 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox4 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox2 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox5 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            this.btnSave = new CuoreUI.Controls.cuiButton();
            this.btnClose = new CuoreUI.Controls.cuiButton();
            this.btnMinimize = new CuoreUI.Controls.cuiButton();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Content = "Change\\ Password";
            this.lblTitle.Enabled = false;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(304, 25);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tbxNewPassword
            // 
            this.tbxNewPassword.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tbxNewPassword.Content = "";
            this.tbxNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxNewPassword.FocusBackgroundColor = System.Drawing.Color.White;
            this.tbxNewPassword.FocusImageTint = System.Drawing.Color.White;
            this.tbxNewPassword.FocusOutlineColor = System.Drawing.Color.Black;
            this.tbxNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNewPassword.ForeColor = System.Drawing.Color.Black;
            this.tbxNewPassword.Image = null;
            this.tbxNewPassword.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxNewPassword.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxNewPassword.Location = new System.Drawing.Point(51, 214);
            this.tbxNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNewPassword.Multiline = false;
            this.tbxNewPassword.Name = "tbxNewPassword";
            this.tbxNewPassword.NormalImageTint = System.Drawing.Color.DimGray;
            this.tbxNewPassword.OutlineColor = System.Drawing.Color.Gainsboro;
            this.tbxNewPassword.Padding = new System.Windows.Forms.Padding(15, 9, 15, 0);
            this.tbxNewPassword.PasswordChar = true;
            this.tbxNewPassword.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxNewPassword.PlaceholderText = "New Passowrd";
            this.tbxNewPassword.Rounding = new System.Windows.Forms.Padding(15);
            this.tbxNewPassword.Size = new System.Drawing.Size(226, 32);
            this.tbxNewPassword.TabIndex = 34;
            this.tbxNewPassword.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxNewPassword.UnderlinedStyle = false;
            this.tbxNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbxNewPassword_Validating);
            // 
            // tbxOldPassword
            // 
            this.tbxOldPassword.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tbxOldPassword.Content = "";
            this.tbxOldPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxOldPassword.FocusBackgroundColor = System.Drawing.Color.White;
            this.tbxOldPassword.FocusImageTint = System.Drawing.Color.White;
            this.tbxOldPassword.FocusOutlineColor = System.Drawing.Color.Black;
            this.tbxOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOldPassword.ForeColor = System.Drawing.Color.Black;
            this.tbxOldPassword.Image = null;
            this.tbxOldPassword.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxOldPassword.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxOldPassword.Location = new System.Drawing.Point(51, 161);
            this.tbxOldPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbxOldPassword.Multiline = false;
            this.tbxOldPassword.Name = "tbxOldPassword";
            this.tbxOldPassword.NormalImageTint = System.Drawing.Color.DimGray;
            this.tbxOldPassword.OutlineColor = System.Drawing.Color.Gainsboro;
            this.tbxOldPassword.Padding = new System.Windows.Forms.Padding(15, 9, 15, 0);
            this.tbxOldPassword.PasswordChar = true;
            this.tbxOldPassword.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxOldPassword.PlaceholderText = "Old Password";
            this.tbxOldPassword.Rounding = new System.Windows.Forms.Padding(15);
            this.tbxOldPassword.Size = new System.Drawing.Size(226, 32);
            this.tbxOldPassword.TabIndex = 35;
            this.tbxOldPassword.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxOldPassword.UnderlinedStyle = false;
            this.tbxOldPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbxOldPassword_Validating);
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
            this.tbxConfirmPassword.Location = new System.Drawing.Point(51, 270);
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
            this.tbxConfirmPassword.TabIndex = 34;
            this.tbxConfirmPassword.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxConfirmPassword.UnderlinedStyle = false;
            this.tbxConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbxConfirmPassword_Validating);
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
            // lblUserID
            // 
            this.lblUserID.Content = "User\\ ID\\ :";
            this.lblUserID.Enabled = false;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.DimGray;
            this.lblUserID.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblUserID.Location = new System.Drawing.Point(50, 55);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(266, 32);
            this.lblUserID.TabIndex = 44;
            this.lblUserID.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblUsername
            // 
            this.lblUsername.Content = "Username\\ :";
            this.lblUsername.Enabled = false;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.DimGray;
            this.lblUsername.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblUsername.Location = new System.Drawing.Point(50, 108);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(266, 32);
            this.lblUsername.TabIndex = 44;
            this.lblUsername.VerticalAlignment = System.Drawing.StringAlignment.Center;
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
            this.btnShowConfirmPass.Location = new System.Drawing.Point(284, 270);
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
            this.btnShowConfirmPass.TabIndex = 45;
            this.btnShowConfirmPass.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnShowConfirmPass.TextOffset = new System.Drawing.Point(0, 0);
            this.btnShowConfirmPass.Click += new System.EventHandler(this.btnShowConfirmPass_Click);
            // 
            // btnShowNewPass
            // 
            this.btnShowNewPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowNewPass.BackColor = System.Drawing.Color.Transparent;
            this.btnShowNewPass.CheckButton = false;
            this.btnShowNewPass.Checked = false;
            this.btnShowNewPass.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnShowNewPass.CheckedForeColor = System.Drawing.Color.White;
            this.btnShowNewPass.CheckedImageTint = System.Drawing.Color.White;
            this.btnShowNewPass.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnShowNewPass.Content = "";
            this.btnShowNewPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowNewPass.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnShowNewPass.ForeColor = System.Drawing.Color.DimGray;
            this.btnShowNewPass.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnShowNewPass.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnShowNewPass.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnShowNewPass.HoverOutline = System.Drawing.Color.DimGray;
            this.btnShowNewPass.Image = global::DVLD_Project.Properties.Resources.show__1_;
            this.btnShowNewPass.ImageAutoCenter = true;
            this.btnShowNewPass.ImageExpand = new System.Drawing.Point(2, 2);
            this.btnShowNewPass.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnShowNewPass.Location = new System.Drawing.Point(284, 214);
            this.btnShowNewPass.Name = "btnShowNewPass";
            this.btnShowNewPass.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnShowNewPass.NormalForeColor = System.Drawing.Color.DimGray;
            this.btnShowNewPass.NormalImageTint = System.Drawing.Color.DimGray;
            this.btnShowNewPass.NormalOutline = System.Drawing.Color.Transparent;
            this.btnShowNewPass.OutlineThickness = 1F;
            this.btnShowNewPass.PressedBackground = System.Drawing.Color.LightGray;
            this.btnShowNewPass.PressedForeColor = System.Drawing.Color.DimGray;
            this.btnShowNewPass.PressedImageTint = System.Drawing.Color.DimGray;
            this.btnShowNewPass.PressedOutline = System.Drawing.Color.DimGray;
            this.btnShowNewPass.Rounding = new System.Windows.Forms.Padding(15);
            this.btnShowNewPass.Size = new System.Drawing.Size(32, 32);
            this.btnShowNewPass.TabIndex = 45;
            this.btnShowNewPass.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnShowNewPass.TextOffset = new System.Drawing.Point(0, 0);
            this.btnShowNewPass.Click += new System.EventHandler(this.btnShowNewPass_Click);
            // 
            // btnShowOldPass
            // 
            this.btnShowOldPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowOldPass.BackColor = System.Drawing.Color.Transparent;
            this.btnShowOldPass.CheckButton = false;
            this.btnShowOldPass.Checked = false;
            this.btnShowOldPass.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnShowOldPass.CheckedForeColor = System.Drawing.Color.White;
            this.btnShowOldPass.CheckedImageTint = System.Drawing.Color.White;
            this.btnShowOldPass.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnShowOldPass.Content = "";
            this.btnShowOldPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowOldPass.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnShowOldPass.ForeColor = System.Drawing.Color.DimGray;
            this.btnShowOldPass.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnShowOldPass.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnShowOldPass.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnShowOldPass.HoverOutline = System.Drawing.Color.DimGray;
            this.btnShowOldPass.Image = global::DVLD_Project.Properties.Resources.show__1_;
            this.btnShowOldPass.ImageAutoCenter = true;
            this.btnShowOldPass.ImageExpand = new System.Drawing.Point(2, 2);
            this.btnShowOldPass.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnShowOldPass.Location = new System.Drawing.Point(284, 161);
            this.btnShowOldPass.Name = "btnShowOldPass";
            this.btnShowOldPass.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnShowOldPass.NormalForeColor = System.Drawing.Color.DimGray;
            this.btnShowOldPass.NormalImageTint = System.Drawing.Color.DimGray;
            this.btnShowOldPass.NormalOutline = System.Drawing.Color.Transparent;
            this.btnShowOldPass.OutlineThickness = 1F;
            this.btnShowOldPass.PressedBackground = System.Drawing.Color.LightGray;
            this.btnShowOldPass.PressedForeColor = System.Drawing.Color.DimGray;
            this.btnShowOldPass.PressedImageTint = System.Drawing.Color.DimGray;
            this.btnShowOldPass.PressedOutline = System.Drawing.Color.DimGray;
            this.btnShowOldPass.Rounding = new System.Windows.Forms.Padding(15);
            this.btnShowOldPass.Size = new System.Drawing.Size(32, 32);
            this.btnShowOldPass.TabIndex = 45;
            this.btnShowOldPass.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnShowOldPass.TextOffset = new System.Drawing.Point(0, 0);
            this.btnShowOldPass.Click += new System.EventHandler(this.btnShowOldPass_Click);
            // 
            // cuiPictureBox3
            // 
            this.cuiPictureBox3.Content = global::DVLD_Project.Properties.Resources.id_card;
            this.cuiPictureBox3.Enabled = false;
            this.cuiPictureBox3.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox3.Location = new System.Drawing.Point(12, 55);
            this.cuiPictureBox3.Name = "cuiPictureBox3";
            this.cuiPictureBox3.OutlineThickness = 1F;
            this.cuiPictureBox3.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox3.Rotation = 0;
            this.cuiPictureBox3.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox3.TabIndex = 43;
            // 
            // cuiPictureBox4
            // 
            this.cuiPictureBox4.Content = global::DVLD_Project.Properties.Resources.id_card;
            this.cuiPictureBox4.Enabled = false;
            this.cuiPictureBox4.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox4.Location = new System.Drawing.Point(12, 108);
            this.cuiPictureBox4.Name = "cuiPictureBox4";
            this.cuiPictureBox4.OutlineThickness = 1F;
            this.cuiPictureBox4.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox4.Rotation = 0;
            this.cuiPictureBox4.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox4.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox4.TabIndex = 43;
            // 
            // cuiPictureBox2
            // 
            this.cuiPictureBox2.Content = global::DVLD_Project.Properties.Resources.password;
            this.cuiPictureBox2.Enabled = false;
            this.cuiPictureBox2.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox2.Location = new System.Drawing.Point(12, 161);
            this.cuiPictureBox2.Name = "cuiPictureBox2";
            this.cuiPictureBox2.OutlineThickness = 1F;
            this.cuiPictureBox2.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox2.Rotation = 0;
            this.cuiPictureBox2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox2.TabIndex = 43;
            // 
            // cuiPictureBox5
            // 
            this.cuiPictureBox5.Content = global::DVLD_Project.Properties.Resources.password;
            this.cuiPictureBox5.Enabled = false;
            this.cuiPictureBox5.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox5.Location = new System.Drawing.Point(12, 267);
            this.cuiPictureBox5.Name = "cuiPictureBox5";
            this.cuiPictureBox5.OutlineThickness = 1F;
            this.cuiPictureBox5.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox5.Rotation = 0;
            this.cuiPictureBox5.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox5.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox5.TabIndex = 42;
            // 
            // cuiPictureBox1
            // 
            this.cuiPictureBox1.Content = global::DVLD_Project.Properties.Resources.password;
            this.cuiPictureBox1.Enabled = false;
            this.cuiPictureBox1.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox1.Location = new System.Drawing.Point(12, 214);
            this.cuiPictureBox1.Name = "cuiPictureBox1";
            this.cuiPictureBox1.OutlineThickness = 1F;
            this.cuiPictureBox1.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox1.Rotation = 0;
            this.cuiPictureBox1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox1.TabIndex = 42;
            // 
            // btnSave
            // 
            this.btnSave.CheckButton = false;
            this.btnSave.Checked = false;
            this.btnSave.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSave.CheckedForeColor = System.Drawing.Color.White;
            this.btnSave.CheckedImageTint = System.Drawing.Color.White;
            this.btnSave.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSave.Content = "Save Password";
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
            this.btnSave.Location = new System.Drawing.Point(163, 332);
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
            this.btnSave.TabIndex = 39;
            this.btnSave.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSave.TextOffset = new System.Drawing.Point(2, 0);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
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
            this.btnClose.Location = new System.Drawing.Point(291, 12);
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
            this.btnClose.TabIndex = 23;
            this.btnClose.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnClose.TextOffset = new System.Drawing.Point(0, 0);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
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
            this.btnMinimize.Location = new System.Drawing.Point(260, 12);
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
            this.btnMinimize.TabIndex = 24;
            this.btnMinimize.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnMinimize.TextOffset = new System.Drawing.Point(0, 0);
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // frmUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(328, 376);
            this.Controls.Add(this.btnShowConfirmPass);
            this.Controls.Add(this.btnShowNewPass);
            this.Controls.Add(this.btnShowOldPass);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.tbxNewPassword);
            this.Controls.Add(this.cuiPictureBox3);
            this.Controls.Add(this.cuiPictureBox4);
            this.Controls.Add(this.cuiPictureBox2);
            this.Controls.Add(this.cuiPictureBox5);
            this.Controls.Add(this.cuiPictureBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxConfirmPassword);
            this.Controls.Add(this.tbxOldPassword);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateUser";
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiButton btnClose;
        private CuoreUI.Controls.cuiButton btnMinimize;
        private CuoreUI.Controls.cuiLabel lblTitle;
        private CuoreUI.Controls.cuiTextBox tbxNewPassword;
        private CuoreUI.Controls.cuiTextBox tbxOldPassword;
        private CuoreUI.Controls.cuiButton btnSave;
        private CuoreUI.Controls.cuiTextBox tbxConfirmPassword;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
        private CuoreUI.Components.cuiFormAnimator cuiFormAnimator;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox2;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox5;
        private CuoreUI.Controls.cuiLabel lblUsername;
        private CuoreUI.Controls.cuiLabel lblUserID;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox3;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox4;
        private CuoreUI.Controls.cuiButton btnShowConfirmPass;
        private CuoreUI.Controls.cuiButton btnShowNewPass;
        private CuoreUI.Controls.cuiButton btnShowOldPass;
    }
}