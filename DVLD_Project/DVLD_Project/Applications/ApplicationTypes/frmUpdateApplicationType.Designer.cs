namespace DVLD_Project.Applications
{
    partial class frmUpdateApplicationType
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
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.cuiFormAnimator = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.cuiFormRounder = new CuoreUI.Components.cuiFormRounder();
            this.tbxTitle = new CuoreUI.Controls.cuiTextBox();
            this.tbxFees = new CuoreUI.Controls.cuiTextBox();
            this.lblID = new CuoreUI.Controls.cuiLabel();
            this.cuiPictureBox2 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox3 = new CuoreUI.Controls.cuiPictureBox();
            this.btnSave = new CuoreUI.Controls.cuiButton();
            this.btnClose = new CuoreUI.Controls.cuiButton();
            this.btnMinimize = new CuoreUI.Controls.cuiButton();
            this.SuspendLayout();
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cuiLabel1.Content = "Update\\ Application\\ Type";
            this.cuiLabel1.Enabled = false;
            this.cuiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel1.Location = new System.Drawing.Point(12, 12);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(527, 25);
            this.cuiLabel1.TabIndex = 31;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Center;
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
            // tbxTitle
            // 
            this.tbxTitle.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tbxTitle.Content = "";
            this.tbxTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxTitle.FocusBackgroundColor = System.Drawing.Color.White;
            this.tbxTitle.FocusImageTint = System.Drawing.Color.White;
            this.tbxTitle.FocusOutlineColor = System.Drawing.Color.Black;
            this.tbxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTitle.ForeColor = System.Drawing.Color.Black;
            this.tbxTitle.Image = null;
            this.tbxTitle.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxTitle.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxTitle.Location = new System.Drawing.Point(51, 115);
            this.tbxTitle.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTitle.Multiline = false;
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.NormalImageTint = System.Drawing.Color.DimGray;
            this.tbxTitle.OutlineColor = System.Drawing.Color.Gainsboro;
            this.tbxTitle.Padding = new System.Windows.Forms.Padding(15, 9, 15, 0);
            this.tbxTitle.PasswordChar = false;
            this.tbxTitle.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxTitle.PlaceholderText = "Application Type Title";
            this.tbxTitle.Rounding = new System.Windows.Forms.Padding(15);
            this.tbxTitle.Size = new System.Drawing.Size(488, 32);
            this.tbxTitle.TabIndex = 32;
            this.tbxTitle.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxTitle.UnderlinedStyle = false;
            // 
            // tbxFees
            // 
            this.tbxFees.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tbxFees.Content = "";
            this.tbxFees.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxFees.FocusBackgroundColor = System.Drawing.Color.White;
            this.tbxFees.FocusImageTint = System.Drawing.Color.White;
            this.tbxFees.FocusOutlineColor = System.Drawing.Color.Black;
            this.tbxFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFees.ForeColor = System.Drawing.Color.Black;
            this.tbxFees.Image = null;
            this.tbxFees.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxFees.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxFees.Location = new System.Drawing.Point(51, 167);
            this.tbxFees.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFees.Multiline = false;
            this.tbxFees.Name = "tbxFees";
            this.tbxFees.NormalImageTint = System.Drawing.Color.DimGray;
            this.tbxFees.OutlineColor = System.Drawing.Color.Gainsboro;
            this.tbxFees.Padding = new System.Windows.Forms.Padding(15, 9, 15, 0);
            this.tbxFees.PasswordChar = false;
            this.tbxFees.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxFees.PlaceholderText = "Application Type Fees";
            this.tbxFees.Rounding = new System.Windows.Forms.Padding(15);
            this.tbxFees.Size = new System.Drawing.Size(488, 32);
            this.tbxFees.TabIndex = 32;
            this.tbxFees.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxFees.UnderlinedStyle = false;
            this.tbxFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFees_KeyPress);
            // 
            // lblID
            // 
            this.lblID.Content = "Application\\ Type\\ ID\\ :\\ ";
            this.lblID.Enabled = false;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.DimGray;
            this.lblID.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblID.Location = new System.Drawing.Point(51, 63);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(488, 32);
            this.lblID.TabIndex = 34;
            this.lblID.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiPictureBox2
            // 
            this.cuiPictureBox2.Content = global::DVLD_Project.Properties.Resources.title;
            this.cuiPictureBox2.Enabled = false;
            this.cuiPictureBox2.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox2.Location = new System.Drawing.Point(12, 115);
            this.cuiPictureBox2.Name = "cuiPictureBox2";
            this.cuiPictureBox2.OutlineThickness = 1F;
            this.cuiPictureBox2.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox2.Rotation = 0;
            this.cuiPictureBox2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox2.TabIndex = 36;
            // 
            // cuiPictureBox1
            // 
            this.cuiPictureBox1.Content = global::DVLD_Project.Properties.Resources.cash_money;
            this.cuiPictureBox1.Enabled = false;
            this.cuiPictureBox1.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox1.Location = new System.Drawing.Point(12, 167);
            this.cuiPictureBox1.Name = "cuiPictureBox1";
            this.cuiPictureBox1.OutlineThickness = 1F;
            this.cuiPictureBox1.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox1.Rotation = 0;
            this.cuiPictureBox1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox1.TabIndex = 35;
            // 
            // cuiPictureBox3
            // 
            this.cuiPictureBox3.Content = global::DVLD_Project.Properties.Resources.id;
            this.cuiPictureBox3.Enabled = false;
            this.cuiPictureBox3.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox3.Location = new System.Drawing.Point(12, 63);
            this.cuiPictureBox3.Name = "cuiPictureBox3";
            this.cuiPictureBox3.OutlineThickness = 1F;
            this.cuiPictureBox3.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox3.Rotation = 0;
            this.cuiPictureBox3.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox3.TabIndex = 35;
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
            this.btnSave.Content = "Save";
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
            this.btnSave.Location = new System.Drawing.Point(386, 219);
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
            this.btnSave.TabIndex = 33;
            this.btnSave.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSave.TextOffset = new System.Drawing.Point(2, 0);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnClose.Location = new System.Drawing.Point(514, 12);
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
            this.btnClose.TabIndex = 29;
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
            this.btnMinimize.Location = new System.Drawing.Point(483, 12);
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
            this.btnMinimize.TabIndex = 30;
            this.btnMinimize.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnMinimize.TextOffset = new System.Drawing.Point(0, 0);
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // frmUpdateApplicationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(551, 263);
            this.Controls.Add(this.cuiPictureBox2);
            this.Controls.Add(this.cuiPictureBox1);
            this.Controls.Add(this.cuiPictureBox3);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxFees);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.cuiLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdateApplicationType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateApplicationType";
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiButton btnClose;
        private CuoreUI.Controls.cuiButton btnMinimize;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Components.cuiFormAnimator cuiFormAnimator;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder;
        private CuoreUI.Controls.cuiTextBox tbxFees;
        private CuoreUI.Controls.cuiTextBox tbxTitle;
        private CuoreUI.Controls.cuiButton btnSave;
        private CuoreUI.Controls.cuiLabel lblID;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox2;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox3;
    }
}