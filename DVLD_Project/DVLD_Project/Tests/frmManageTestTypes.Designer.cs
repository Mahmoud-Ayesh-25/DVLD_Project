namespace DVLD_Project.Tests
{
    partial class frmManageTestTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageTestTypes));
            this.cuiFormAnimator = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.cuiFormRounder = new CuoreUI.Components.cuiFormRounder();
            this.cuiResizeGrip1 = new CuoreUI.Controls.cuiResizeGrip();
            this.lblRecords = new CuoreUI.Controls.cuiLabel();
            this.lblEmpty = new CuoreUI.Controls.cuiLabel();
            this.dgvTestTypes = new System.Windows.Forms.DataGridView();
            this.cxmTestTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new CuoreUI.Controls.cuiButton();
            this.btnMinimize = new CuoreUI.Controls.cuiButton();
            this.btnMaximize = new CuoreUI.Controls.cuiButton();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.MaximizedImgBox = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypes)).BeginInit();
            this.cxmTestTypes.SuspendLayout();
            this.SuspendLayout();
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
            // cuiResizeGrip1
            // 
            this.cuiResizeGrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiResizeGrip1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.cuiResizeGrip1.GripColor = System.Drawing.Color.Gray;
            this.cuiResizeGrip1.GripSize = 2;
            this.cuiResizeGrip1.GripTexture = true;
            this.cuiResizeGrip1.Location = new System.Drawing.Point(702, 250);
            this.cuiResizeGrip1.Name = "cuiResizeGrip1";
            this.cuiResizeGrip1.Size = new System.Drawing.Size(12, 200);
            this.cuiResizeGrip1.SkipBottomRightSquare = true;
            this.cuiResizeGrip1.TabIndex = 35;
            this.cuiResizeGrip1.TargetForm = this;
            this.cuiResizeGrip1.TextureOffset = new System.Drawing.Size(-2, -2);
            // 
            // lblRecords
            // 
            this.lblRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecords.Content = "Records\\ :\\ 0";
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblRecords.Location = new System.Drawing.Point(12, 424);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(210, 14);
            this.lblRecords.TabIndex = 34;
            this.lblRecords.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lblEmpty
            // 
            this.lblEmpty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmpty.BackColor = System.Drawing.Color.White;
            this.lblEmpty.Content = "Empty";
            this.lblEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpty.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblEmpty.Location = new System.Drawing.Point(213, 135);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(289, 101);
            this.lblEmpty.TabIndex = 33;
            this.lblEmpty.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // dgvTestTypes
            // 
            this.dgvTestTypes.AllowUserToAddRows = false;
            this.dgvTestTypes.AllowUserToDeleteRows = false;
            this.dgvTestTypes.AllowUserToResizeColumns = false;
            this.dgvTestTypes.AllowUserToResizeRows = false;
            this.dgvTestTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvTestTypes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTestTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTestTypes.ColumnHeadersHeight = 25;
            this.dgvTestTypes.ContextMenuStrip = this.cxmTestTypes;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTestTypes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTestTypes.EnableHeadersVisualStyles = false;
            this.dgvTestTypes.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvTestTypes.Location = new System.Drawing.Point(12, 52);
            this.dgvTestTypes.MultiSelect = false;
            this.dgvTestTypes.Name = "dgvTestTypes";
            this.dgvTestTypes.ReadOnly = true;
            this.dgvTestTypes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTestTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTestTypes.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTestTypes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTestTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTestTypes.Size = new System.Drawing.Size(690, 366);
            this.dgvTestTypes.TabIndex = 32;
            this.dgvTestTypes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvTestTypes_DataBindingComplete);
            // 
            // cxmTestTypes
            // 
            this.cxmTestTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.cxmTestTypes.Name = "cxmPeople";
            this.cxmTestTypes.Size = new System.Drawing.Size(181, 48);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.updateToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.pencil;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateToolStripMenuItem.Text = "Edit";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
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
            this.btnClose.Location = new System.Drawing.Point(677, 12);
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
            this.btnMinimize.Location = new System.Drawing.Point(615, 12);
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
            this.btnMinimize.TabIndex = 31;
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
            this.btnMaximize.Location = new System.Drawing.Point(646, 12);
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
            this.btnMaximize.TabIndex = 30;
            this.btnMaximize.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnMaximize.TextOffset = new System.Drawing.Point(0, 0);
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cuiLabel1.Content = "Manage\\ Test\\ Types";
            this.cuiLabel1.Enabled = false;
            this.cuiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel1.Location = new System.Drawing.Point(12, 12);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(690, 25);
            this.cuiLabel1.TabIndex = 36;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // MaximizedImgBox
            // 
            this.MaximizedImgBox.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MaximizedImgBox.ImageStream")));
            this.MaximizedImgBox.TransparentColor = System.Drawing.Color.Transparent;
            this.MaximizedImgBox.Images.SetKeyName(0, "expand.png");
            this.MaximizedImgBox.Images.SetKeyName(1, "minimize.png");
            // 
            // frmManageTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.cuiResizeGrip1);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.lblEmpty);
            this.Controls.Add(this.dgvTestTypes);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.cuiLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(714, 450);
            this.Name = "frmManageTestTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageTestTypes";
            this.SizeChanged += new System.EventHandler(this.frmManageTestTypes_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypes)).EndInit();
            this.cxmTestTypes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Components.cuiFormAnimator cuiFormAnimator;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder;
        private CuoreUI.Controls.cuiResizeGrip cuiResizeGrip1;
        private CuoreUI.Controls.cuiLabel lblRecords;
        private CuoreUI.Controls.cuiLabel lblEmpty;
        private System.Windows.Forms.DataGridView dgvTestTypes;
        private CuoreUI.Controls.cuiButton btnClose;
        private CuoreUI.Controls.cuiButton btnMinimize;
        private CuoreUI.Controls.cuiButton btnMaximize;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private System.Windows.Forms.ImageList MaximizedImgBox;
        private System.Windows.Forms.ContextMenuStrip cxmTestTypes;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    }
}