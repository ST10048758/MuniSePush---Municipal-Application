namespace y3s2_PROG_POE.Forms
{
    partial class ReportIssuesPage
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
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txbLocation = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnAttachMedia = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblFileError = new System.Windows.Forms.Label();
            this.rtbFilePreview = new System.Windows.Forms.RichTextBox();
            this.pbFilePreview = new System.Windows.Forms.PictureBox();
            this.btnDeleteAttachment = new System.Windows.Forms.Button();
            this.panelbox = new System.Windows.Forms.Panel();
            this.labelText = new System.Windows.Forms.Label();
            this.pbCustomProgressBar = new y3s2_PROG_POE.Classes.CustomProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilePreview)).BeginInit();
            this.panelbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblLocation.Location = new System.Drawing.Point(32, 83);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(62, 19);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "Location";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCategory.Location = new System.Drawing.Point(29, 120);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 19);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDescription.Location = new System.Drawing.Point(15, 158);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 19);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // txbLocation
            // 
            this.txbLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txbLocation.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLocation.Location = new System.Drawing.Point(105, 83);
            this.txbLocation.Margin = new System.Windows.Forms.Padding(2);
            this.txbLocation.Name = "txbLocation";
            this.txbLocation.Size = new System.Drawing.Size(326, 24);
            this.txbLocation.TabIndex = 3;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Sanitation",
            "Roads",
            "Utilities",
            "Other"});
            this.cmbCategory.Location = new System.Drawing.Point(105, 118);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(326, 27);
            this.cmbCategory.TabIndex = 4;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbDescription.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescription.Location = new System.Drawing.Point(105, 158);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(2);
            this.rtbDescription.MinimumSize = new System.Drawing.Size(4, 20);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(326, 183);
            this.rtbDescription.TabIndex = 5;
            this.rtbDescription.Text = "";
            // 
            // btnAttachMedia
            // 
            this.btnAttachMedia.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAttachMedia.FlatAppearance.BorderSize = 0;
            this.btnAttachMedia.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttachMedia.Location = new System.Drawing.Point(459, 83);
            this.btnAttachMedia.Margin = new System.Windows.Forms.Padding(2);
            this.btnAttachMedia.Name = "btnAttachMedia";
            this.btnAttachMedia.Size = new System.Drawing.Size(130, 53);
            this.btnAttachMedia.TabIndex = 6;
            this.btnAttachMedia.Text = "Attach Media";
            this.btnAttachMedia.UseVisualStyleBackColor = false;
            this.btnAttachMedia.Click += new System.EventHandler(this.btnAttachMedia_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSubmit.BackColor = System.Drawing.Color.GreenYellow;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(446, 355);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(158, 50);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "Create New Issue Report";
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(284, 355);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(158, 50);
            this.btnMenu.TabIndex = 11;
            this.btnMenu.Text = "Back to Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblFileError
            // 
            this.lblFileError.AutoSize = true;
            this.lblFileError.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileError.ForeColor = System.Drawing.Color.Red;
            this.lblFileError.Location = new System.Drawing.Point(456, 61);
            this.lblFileError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileError.Name = "lblFileError";
            this.lblFileError.Size = new System.Drawing.Size(195, 19);
            this.lblFileError.TabIndex = 12;
            this.lblFileError.Text = "*File type not supported.";
            this.lblFileError.Visible = false;
            // 
            // rtbFilePreview
            // 
            this.rtbFilePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbFilePreview.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFilePreview.Location = new System.Drawing.Point(-3, -2);
            this.rtbFilePreview.Margin = new System.Windows.Forms.Padding(2);
            this.rtbFilePreview.Name = "rtbFilePreview";
            this.rtbFilePreview.ReadOnly = true;
            this.rtbFilePreview.Size = new System.Drawing.Size(328, 182);
            this.rtbFilePreview.TabIndex = 13;
            this.rtbFilePreview.Text = "";
            this.rtbFilePreview.Visible = false;
            // 
            // pbFilePreview
            // 
            this.pbFilePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFilePreview.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pbFilePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFilePreview.Location = new System.Drawing.Point(459, 158);
            this.pbFilePreview.Margin = new System.Windows.Forms.Padding(2);
            this.pbFilePreview.Name = "pbFilePreview";
            this.pbFilePreview.Size = new System.Drawing.Size(328, 182);
            this.pbFilePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFilePreview.TabIndex = 10;
            this.pbFilePreview.TabStop = false;
            this.pbFilePreview.Visible = false;
            // 
            // btnDeleteAttachment
            // 
            this.btnDeleteAttachment.BackColor = System.Drawing.Color.Red;
            this.btnDeleteAttachment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteAttachment.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAttachment.Image = global::y3s2_PROG_POE.Properties.Resources.bin_new;
            this.btnDeleteAttachment.Location = new System.Drawing.Point(593, 83);
            this.btnDeleteAttachment.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteAttachment.Name = "btnDeleteAttachment";
            this.btnDeleteAttachment.Size = new System.Drawing.Size(46, 53);
            this.btnDeleteAttachment.TabIndex = 14;
            this.btnDeleteAttachment.UseVisualStyleBackColor = false;
            this.btnDeleteAttachment.Visible = false;
            this.btnDeleteAttachment.Click += new System.EventHandler(this.btnDeleteAttachment_Click);
            // 
            // panelbox
            // 
            this.panelbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelbox.Controls.Add(this.labelText);
            this.panelbox.Controls.Add(this.rtbFilePreview);
            this.panelbox.Location = new System.Drawing.Point(460, 159);
            this.panelbox.Margin = new System.Windows.Forms.Padding(2);
            this.panelbox.MinimumSize = new System.Drawing.Size(226, 20);
            this.panelbox.Name = "panelbox";
            this.panelbox.Size = new System.Drawing.Size(328, 182);
            this.panelbox.TabIndex = 15;
            // 
            // labelText
            // 
            this.labelText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelText.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.Location = new System.Drawing.Point(33, 17);
            this.labelText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(134, 0);
            this.labelText.TabIndex = 0;
            this.labelText.Text = "label2";
            this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbCustomProgressBar
            // 
            this.pbCustomProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCustomProgressBar.ForeColor = System.Drawing.Color.GreenYellow;
            this.pbCustomProgressBar.Location = new System.Drawing.Point(9, 423);
            this.pbCustomProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.pbCustomProgressBar.Name = "pbCustomProgressBar";
            this.pbCustomProgressBar.Size = new System.Drawing.Size(860, 27);
            this.pbCustomProgressBar.TabIndex = 16;
            // 
            // ReportIssuesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(878, 460);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pbCustomProgressBar);
            this.Controls.Add(this.panelbox);
            this.Controls.Add(this.lblFileError);
            this.Controls.Add(this.pbFilePreview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAttachMedia);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txbLocation);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.btnDeleteAttachment);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReportIssuesPage";
            this.Text = "Create a new report";
            this.Load += new System.EventHandler(this.ReportIssuesPage_Load);
            this.Resize += new System.EventHandler(this.ReportIssuesPage_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbFilePreview)).EndInit();
            this.panelbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txbLocation;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnAttachMedia;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbFilePreview;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblFileError;
        private System.Windows.Forms.RichTextBox rtbFilePreview;
        private System.Windows.Forms.Button btnDeleteAttachment;
        private System.Windows.Forms.Panel panelbox;
        private System.Windows.Forms.Label labelText;
        private Classes.CustomProgressBar pbCustomProgressBar;
    }
}