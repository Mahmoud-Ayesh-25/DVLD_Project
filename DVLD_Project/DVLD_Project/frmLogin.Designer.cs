namespace DVLD_Project
{
    partial class frmLogin
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
            this.cuiFormAnimator = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.cuiFormRounder = new CuoreUI.Components.cuiFormRounder();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.tbxUsername = new CuoreUI.Controls.cuiTextBox();
            this.tbxPassword = new CuoreUI.Controls.cuiTextBox();
            this.chkRememberMe = new CuoreUI.Controls.cuiCheckbox();
            this.btnShowPassword = new CuoreUI.Controls.cuiButton();
            this.btnLogin = new CuoreUI.Controls.cuiButton();
            this.cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox3 = new CuoreUI.Controls.cuiPictureBox();
            this.btnClose = new CuoreUI.Controls.cuiButton();
            this.btnMinimize = new CuoreUI.Controls.cuiButton();
            this.SuspendLayout();
            // 
            // cuiFormAnimator
            // 
            this.cuiFormAnimator.AnimateOnStart = true;
            this.cuiFormAnimator.Duration = 200;
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
            // cuiLabel1
            // 
            this.cuiLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cuiLabel1.Content = "Login";
            this.cuiLabel1.Enabled = false;
            this.cuiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel1.Location = new System.Drawing.Point(12, 12);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(408, 25);
            this.cuiLabel1.TabIndex = 25;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel2
            // 
            this.cuiLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cuiLabel2.Content = "Welcome\\ To\\nDVLD";
            this.cuiLabel2.Enabled = false;
            this.cuiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel2.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel2.Location = new System.Drawing.Point(12, 73);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Size = new System.Drawing.Size(408, 56);
            this.cuiLabel2.TabIndex = 0;
            this.cuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Center;
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
            this.tbxUsername.Location = new System.Drawing.Point(101, 166);
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
            this.tbxUsername.Size = new System.Drawing.Size(268, 32);
            this.tbxUsername.TabIndex = 1;
            this.tbxUsername.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxUsername.UnderlinedStyle = false;
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
            this.tbxPassword.Location = new System.Drawing.Point(101, 219);
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
            this.tbxPassword.Size = new System.Drawing.Size(229, 32);
            this.tbxPassword.TabIndex = 2;
            this.tbxPassword.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxPassword.UnderlinedStyle = false;
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.Checked = false;
            this.chkRememberMe.CheckedForeground = System.Drawing.Color.DimGray;
            this.chkRememberMe.CheckedOutlineColor = System.Drawing.Color.DimGray;
            this.chkRememberMe.CheckedSymbolColor = System.Drawing.Color.White;
            this.chkRememberMe.Content = "Remember Me";
            this.chkRememberMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkRememberMe.Location = new System.Drawing.Point(101, 272);
            this.chkRememberMe.MinimumSize = new System.Drawing.Size(16, 16);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.OutlineStyle = true;
            this.chkRememberMe.OutlineThickness = 1F;
            this.chkRememberMe.Rounding = 7;
            this.chkRememberMe.ShowSymbols = true;
            this.chkRememberMe.Size = new System.Drawing.Size(111, 16);
            this.chkRememberMe.TabIndex = 3;
            this.chkRememberMe.Text = "cuiCheckbox1";
            this.chkRememberMe.UncheckedForeground = System.Drawing.Color.Empty;
            this.chkRememberMe.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.chkRememberMe.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnShowPassword.CheckButton = false;
            this.btnShowPassword.Checked = false;
            this.btnShowPassword.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnShowPassword.CheckedForeColor = System.Drawing.Color.White;
            this.btnShowPassword.CheckedImageTint = System.Drawing.Color.White;
            this.btnShowPassword.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnShowPassword.Content = "";
            this.btnShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPassword.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnShowPassword.ForeColor = System.Drawing.Color.DimGray;
            this.btnShowPassword.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnShowPassword.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnShowPassword.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnShowPassword.HoverOutline = System.Drawing.Color.DimGray;
            this.btnShowPassword.Image = global::DVLD_Project.Properties.Resources.show__1_;
            this.btnShowPassword.ImageAutoCenter = true;
            this.btnShowPassword.ImageExpand = new System.Drawing.Point(2, 2);
            this.btnShowPassword.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnShowPassword.Location = new System.Drawing.Point(337, 219);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnShowPassword.NormalForeColor = System.Drawing.Color.DimGray;
            this.btnShowPassword.NormalImageTint = System.Drawing.Color.DimGray;
            this.btnShowPassword.NormalOutline = System.Drawing.Color.Transparent;
            this.btnShowPassword.OutlineThickness = 1F;
            this.btnShowPassword.PressedBackground = System.Drawing.Color.LightGray;
            this.btnShowPassword.PressedForeColor = System.Drawing.Color.DimGray;
            this.btnShowPassword.PressedImageTint = System.Drawing.Color.DimGray;
            this.btnShowPassword.PressedOutline = System.Drawing.Color.DimGray;
            this.btnShowPassword.Rounding = new System.Windows.Forms.Padding(15);
            this.btnShowPassword.Size = new System.Drawing.Size(32, 32);
            this.btnShowPassword.TabIndex = 29;
            this.btnShowPassword.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnShowPassword.TextOffset = new System.Drawing.Point(0, 0);
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.CheckButton = false;
            this.btnLogin.Checked = false;
            this.btnLogin.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnLogin.CheckedForeColor = System.Drawing.Color.White;
            this.btnLogin.CheckedImageTint = System.Drawing.Color.White;
            this.btnLogin.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnLogin.Content = "Login";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnLogin.ForeColor = System.Drawing.Color.DimGray;
            this.btnLogin.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnLogin.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnLogin.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnLogin.HoverOutline = System.Drawing.Color.DimGray;
            this.btnLogin.Image = global::DVLD_Project.Properties.Resources.login;
            this.btnLogin.ImageAutoCenter = true;
            this.btnLogin.ImageExpand = new System.Drawing.Point(1, 1);
            this.btnLogin.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnLogin.Location = new System.Drawing.Point(229, 318);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnLogin.NormalForeColor = System.Drawing.Color.DimGray;
            this.btnLogin.NormalImageTint = System.Drawing.Color.DimGray;
            this.btnLogin.NormalOutline = System.Drawing.Color.Transparent;
            this.btnLogin.OutlineThickness = 1F;
            this.btnLogin.PressedBackground = System.Drawing.Color.LightGray;
            this.btnLogin.PressedForeColor = System.Drawing.Color.DimGray;
            this.btnLogin.PressedImageTint = System.Drawing.Color.DimGray;
            this.btnLogin.PressedOutline = System.Drawing.Color.DimGray;
            this.btnLogin.Rounding = new System.Windows.Forms.Padding(15);
            this.btnLogin.Size = new System.Drawing.Size(140, 32);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLogin.TextOffset = new System.Drawing.Point(2, 0);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cuiPictureBox1
            // 
            this.cuiPictureBox1.Content = global::DVLD_Project.Properties.Resources.password;
            this.cuiPictureBox1.Enabled = false;
            this.cuiPictureBox1.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox1.Location = new System.Drawing.Point(62, 219);
            this.cuiPictureBox1.Name = "cuiPictureBox1";
            this.cuiPictureBox1.OutlineThickness = 1F;
            this.cuiPictureBox1.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox1.Rotation = 0;
            this.cuiPictureBox1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox1.TabIndex = 28;
            // 
            // cuiPictureBox3
            // 
            this.cuiPictureBox3.Content = global::DVLD_Project.Properties.Resources.id_card;
            this.cuiPictureBox3.Enabled = false;
            this.cuiPictureBox3.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox3.Location = new System.Drawing.Point(62, 166);
            this.cuiPictureBox3.Name = "cuiPictureBox3";
            this.cuiPictureBox3.OutlineThickness = 1F;
            this.cuiPictureBox3.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox3.Rotation = 0;
            this.cuiPictureBox3.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox3.TabIndex = 28;
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
            this.btnClose.Location = new System.Drawing.Point(395, 12);
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
            this.btnMinimize.Location = new System.Drawing.Point(364, 12);
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
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 450);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.chkRememberMe);
            this.Controls.Add(this.cuiPictureBox1);
            this.Controls.Add(this.cuiPictureBox3);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.cuiLabel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.cuiLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Components.cuiFormAnimator cuiFormAnimator;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder;
        private CuoreUI.Controls.cuiButton btnClose;
        private CuoreUI.Controls.cuiButton btnMinimize;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiTextBox tbxUsername;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox3;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiTextBox tbxPassword;
        private CuoreUI.Controls.cuiCheckbox chkRememberMe;
        private CuoreUI.Controls.cuiButton btnLogin;
        private CuoreUI.Controls.cuiButton btnShowPassword;
    }
}