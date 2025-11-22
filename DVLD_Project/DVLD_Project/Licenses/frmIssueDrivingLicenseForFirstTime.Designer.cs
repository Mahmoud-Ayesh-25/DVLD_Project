namespace DVLD_Project.Licenses
{
    partial class frmIssueDrivingLicenseForFirstTime
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
            this.btnClose = new CuoreUI.Controls.cuiButton();
            this.btnMinimize = new CuoreUI.Controls.cuiButton();
            this.lblTitle = new CuoreUI.Controls.cuiLabel();
            this.btnSave = new CuoreUI.Controls.cuiButton();
            this.cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            this.tbxNotes = new CuoreUI.Controls.cuiTextBox();
            this.cuiFormAnimator = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.cuiFormRounder = new CuoreUI.Components.cuiFormRounder();
            this.ctrlApplicaitonInfo1 = new DVLD_Project.Applications.LocalDrivingLicenseApplications.ctrlApplicaitonInfo();
            this.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(825, 12);
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
            this.btnClose.TabIndex = 17;
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
            this.btnMinimize.Location = new System.Drawing.Point(794, 12);
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
            this.btnMinimize.TabIndex = 18;
            this.btnMinimize.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnMinimize.TextOffset = new System.Drawing.Point(0, 0);
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.Content = "Issue\\ Driving\\ License\\ \\(First\\ Time\\)";
            this.lblTitle.Enabled = false;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(838, 25);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.VerticalAlignment = System.Drawing.StringAlignment.Center;
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
            this.btnSave.Content = "Issue";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSave.ForeColor = System.Drawing.Color.DimGray;
            this.btnSave.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnSave.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnSave.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnSave.HoverOutline = System.Drawing.Color.DimGray;
            this.btnSave.Image = global::DVLD_Project.Properties.Resources.approve;
            this.btnSave.ImageAutoCenter = true;
            this.btnSave.ImageExpand = new System.Drawing.Point(1, 1);
            this.btnSave.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnSave.Location = new System.Drawing.Point(697, 540);
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
            this.btnSave.TabIndex = 35;
            this.btnSave.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSave.TextOffset = new System.Drawing.Point(2, 0);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cuiPictureBox1
            // 
            this.cuiPictureBox1.Content = global::DVLD_Project.Properties.Resources.notes__1_;
            this.cuiPictureBox1.Enabled = false;
            this.cuiPictureBox1.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox1.Location = new System.Drawing.Point(12, 441);
            this.cuiPictureBox1.Name = "cuiPictureBox1";
            this.cuiPictureBox1.OutlineThickness = 1F;
            this.cuiPictureBox1.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox1.Rotation = 0;
            this.cuiPictureBox1.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox1.TabIndex = 37;
            // 
            // tbxNotes
            // 
            this.tbxNotes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tbxNotes.Content = "";
            this.tbxNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxNotes.FocusBackgroundColor = System.Drawing.Color.White;
            this.tbxNotes.FocusImageTint = System.Drawing.Color.White;
            this.tbxNotes.FocusOutlineColor = System.Drawing.Color.Black;
            this.tbxNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNotes.ForeColor = System.Drawing.Color.Black;
            this.tbxNotes.Image = null;
            this.tbxNotes.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxNotes.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxNotes.Location = new System.Drawing.Point(51, 441);
            this.tbxNotes.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNotes.Multiline = true;
            this.tbxNotes.Name = "tbxNotes";
            this.tbxNotes.NormalImageTint = System.Drawing.Color.DimGray;
            this.tbxNotes.OutlineColor = System.Drawing.Color.Gainsboro;
            this.tbxNotes.Padding = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.tbxNotes.PasswordChar = false;
            this.tbxNotes.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxNotes.PlaceholderText = "Notes";
            this.tbxNotes.Rounding = new System.Windows.Forms.Padding(15);
            this.tbxNotes.Size = new System.Drawing.Size(798, 81);
            this.tbxNotes.TabIndex = 38;
            this.tbxNotes.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxNotes.UnderlinedStyle = false;
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
            // ctrlApplicaitonInfo1
            // 
            this.ctrlApplicaitonInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlApplicaitonInfo1.Location = new System.Drawing.Point(12, 52);
            this.ctrlApplicaitonInfo1.Name = "ctrlApplicaitonInfo1";
            this.ctrlApplicaitonInfo1.Size = new System.Drawing.Size(838, 374);
            this.ctrlApplicaitonInfo1.TabIndex = 20;
            // 
            // frmIssueDrivingLicenseForFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 584);
            this.Controls.Add(this.tbxNotes);
            this.Controls.Add(this.cuiPictureBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ctrlApplicaitonInfo1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIssueDrivingLicenseForFirstTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIssueDrivingLicenseForFirstTime";
            this.Load += new System.EventHandler(this.frmIssueDrivingLicenseForFirstTime_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiButton btnClose;
        private CuoreUI.Controls.cuiButton btnMinimize;
        private CuoreUI.Controls.cuiLabel lblTitle;
        private Applications.LocalDrivingLicenseApplications.ctrlApplicaitonInfo ctrlApplicaitonInfo1;
        private CuoreUI.Controls.cuiButton btnSave;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiTextBox tbxNotes;
        private CuoreUI.Components.cuiFormAnimator cuiFormAnimator;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder;
    }
}