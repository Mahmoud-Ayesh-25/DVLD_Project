namespace DVLD_Project.Licenses.LocalDrivingLicenses.Controls
{
    partial class ctrlLocalLicenseCardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlLocalLicenseCard1 = new DVLD_Project.Licenses.LocalDrivingLicenses.ctrlLocalLicenseCard();
            this.btnFind = new CuoreUI.Controls.cuiButton();
            this.tbxFilter = new CuoreUI.Controls.cuiTextBox();
            this.SuspendLayout();
            // 
            // ctrlLocalLicenseCard1
            // 
            this.ctrlLocalLicenseCard1.BackColor = System.Drawing.Color.White;
            this.ctrlLocalLicenseCard1.Location = new System.Drawing.Point(0, 44);
            this.ctrlLocalLicenseCard1.Name = "ctrlLocalLicenseCard1";
            this.ctrlLocalLicenseCard1.Size = new System.Drawing.Size(780, 400);
            this.ctrlLocalLicenseCard1.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.CheckButton = false;
            this.btnFind.Checked = false;
            this.btnFind.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnFind.CheckedForeColor = System.Drawing.Color.White;
            this.btnFind.CheckedImageTint = System.Drawing.Color.White;
            this.btnFind.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnFind.Content = "Find";
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnFind.ForeColor = System.Drawing.Color.DimGray;
            this.btnFind.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnFind.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnFind.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnFind.HoverOutline = System.Drawing.Color.DimGray;
            this.btnFind.Image = global::DVLD_Project.Properties.Resources.search;
            this.btnFind.ImageAutoCenter = true;
            this.btnFind.ImageExpand = new System.Drawing.Point(1, 1);
            this.btnFind.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnFind.Location = new System.Drawing.Point(229, 0);
            this.btnFind.Name = "btnFind";
            this.btnFind.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnFind.NormalForeColor = System.Drawing.Color.DimGray;
            this.btnFind.NormalImageTint = System.Drawing.Color.DimGray;
            this.btnFind.NormalOutline = System.Drawing.Color.Transparent;
            this.btnFind.OutlineThickness = 1F;
            this.btnFind.PressedBackground = System.Drawing.Color.LightGray;
            this.btnFind.PressedForeColor = System.Drawing.Color.DimGray;
            this.btnFind.PressedImageTint = System.Drawing.Color.DimGray;
            this.btnFind.PressedOutline = System.Drawing.Color.DimGray;
            this.btnFind.Rounding = new System.Windows.Forms.Padding(15);
            this.btnFind.Size = new System.Drawing.Size(153, 32);
            this.btnFind.TabIndex = 7;
            this.btnFind.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnFind.TextOffset = new System.Drawing.Point(2, 0);
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
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
            this.tbxFilter.Location = new System.Drawing.Point(0, 0);
            this.tbxFilter.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFilter.Multiline = false;
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.NormalImageTint = System.Drawing.Color.DimGray;
            this.tbxFilter.OutlineColor = System.Drawing.Color.Gainsboro;
            this.tbxFilter.Padding = new System.Windows.Forms.Padding(15, 9, 15, 0);
            this.tbxFilter.PasswordChar = false;
            this.tbxFilter.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxFilter.PlaceholderText = "License ID";
            this.tbxFilter.Rounding = new System.Windows.Forms.Padding(15);
            this.tbxFilter.Size = new System.Drawing.Size(222, 32);
            this.tbxFilter.TabIndex = 6;
            this.tbxFilter.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxFilter.UnderlinedStyle = false;
            this.tbxFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFilter_KeyPress);
            // 
            // ctrlLocalLicenseCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.ctrlLocalLicenseCard1);
            this.Name = "ctrlLocalLicenseCardWithFilter";
            this.Size = new System.Drawing.Size(780, 444);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlLocalLicenseCard ctrlLocalLicenseCard1;
        private CuoreUI.Controls.cuiButton btnFind;
        private CuoreUI.Controls.cuiTextBox tbxFilter;
    }
}
