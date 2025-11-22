namespace DVLD_Project.People
{
    partial class ctrlFindPerson
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
            this.tbxFilter = new CuoreUI.Controls.cuiTextBox();
            this.cbxFilter = new CuoreUI.Controls.cuiComboBox();
            this.btnFind = new CuoreUI.Controls.cuiButton();
            this.btnAddPerson = new CuoreUI.Controls.cuiButton();
            this.ctrlPersonCard = new DVLD_Project.ctrlPersonCard();
            this.SuspendLayout();
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
            this.tbxFilter.Location = new System.Drawing.Point(168, 2);
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
            this.tbxFilter.TabIndex = 4;
            this.tbxFilter.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxFilter.UnderlinedStyle = false;
            this.tbxFilter.Visible = false;
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
        "Person ID",
        "National No"};
            this.cbxFilter.Location = new System.Drawing.Point(2, 2);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.NoSelectionDropdownText = "Empty";
            this.cbxFilter.NoSelectionText = "Filter By";
            this.cbxFilter.OutlineColor = System.Drawing.Color.Gainsboro;
            this.cbxFilter.OutlineThickness = 1F;
            this.cbxFilter.Rounding = 15;
            this.cbxFilter.Size = new System.Drawing.Size(159, 32);
            this.cbxFilter.TabIndex = 3;
            this.cbxFilter.SelectedIndexChanged += new System.EventHandler(this.cbxFilter_SelectedIndexChanged);
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
            this.btnFind.Location = new System.Drawing.Point(397, 2);
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
            this.btnFind.TabIndex = 5;
            this.btnFind.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnFind.TextOffset = new System.Drawing.Point(2, 0);
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
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
            this.btnAddPerson.Content = "Add Person";
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
            this.btnAddPerson.Location = new System.Drawing.Point(603, 2);
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
            this.btnAddPerson.Size = new System.Drawing.Size(175, 32);
            this.btnAddPerson.TabIndex = 34;
            this.btnAddPerson.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAddPerson.TextOffset = new System.Drawing.Point(2, 0);
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // ctrlPersonCard
            // 
            this.ctrlPersonCard.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCard.Location = new System.Drawing.Point(0, 48);
            this.ctrlPersonCard.Name = "ctrlPersonCard";
            this.ctrlPersonCard.Size = new System.Drawing.Size(780, 320);
            this.ctrlPersonCard.TabIndex = 0;
            // 
            // ctrlFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.cbxFilter);
            this.Controls.Add(this.ctrlPersonCard);
            this.Name = "ctrlFindPerson";
            this.Size = new System.Drawing.Size(780, 368);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonCard ctrlPersonCard;
        private CuoreUI.Controls.cuiTextBox tbxFilter;
        private CuoreUI.Controls.cuiComboBox cbxFilter;
        private CuoreUI.Controls.cuiButton btnFind;
        private CuoreUI.Controls.cuiButton btnAddPerson;
    }
}
