using System;
using System.Windows.Forms;

namespace y3s2_PROG_POE.Forms
{
    public partial class ServiceRequestForm : Form
    {
        //UI Elements
        private ListView lvRequests;
        private ColumnHeader Location;
        private ColumnHeader Category;
        private ColumnHeader Status;
        private Label lblRelatedResults;
        private Button btnUpdate;
        private ComboBox cbLocation;
        private ComboBox cbCategory;
        private ComboBox cbStatus;
        private Label lblHeading;
        private Panel panel1;
        private Label lblFileView, lblStatus, lblDescription, lblCategory, lblLocation;
        private RichTextBox rtbFilePreview;
        private PictureBox pbFilePreview;
        private Label lblFilePreview, lblLocationHeading, lblCategoryHeading, lblStatusHeading, lbldescriptionHeading, lblPanelHeading;
        private FlowLayoutPanel flpRequestData;
        private Panel pnFileViewer;

        private void InitializeComponent()
        {
            this.lvRequests = new System.Windows.Forms.ListView();
            this.Location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblRelatedResults = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnFileViewer = new System.Windows.Forms.Panel();
            this.lblFilePreview = new System.Windows.Forms.Label();
            this.rtbFilePreview = new System.Windows.Forms.RichTextBox();
            this.pbFilePreview = new System.Windows.Forms.PictureBox();
            this.flpRequestData = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLocationHeading = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblCategoryHeading = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lbldescriptionHeading = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblStatusHeading = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblFileView = new System.Windows.Forms.Label();
            this.lblPanelHeading = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnFileViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilePreview)).BeginInit();
            this.flpRequestData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvRequests
            // 
            this.lvRequests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvRequests.BackColor = System.Drawing.Color.Gainsboro;
            this.lvRequests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Location,
            this.Category,
            this.Status});
            this.lvRequests.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvRequests.FullRowSelect = true;
            this.lvRequests.GridLines = true;
            this.lvRequests.HideSelection = false;
            this.lvRequests.Location = new System.Drawing.Point(170, 80);
            this.lvRequests.Name = "lvRequests";
            this.lvRequests.Size = new System.Drawing.Size(336, 354);
            this.lvRequests.TabIndex = 0;
            this.lvRequests.UseCompatibleStateImageBehavior = false;
            this.lvRequests.View = System.Windows.Forms.View.Details;
            this.lvRequests.SelectedIndexChanged += new System.EventHandler(this.lvRequests_SelectedIndexChanged);
            // 
            // Location
            // 
            this.Location.Text = "Location";
            this.Location.Width = 132;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 100;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 100;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.GreenYellow;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(42, 208);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 37);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Search";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbLocation
            // 
            this.cbLocation.BackColor = System.Drawing.Color.Gainsboro;
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Items.AddRange(new object[] {
            "--Location--",
            "Any"});
            this.cbLocation.Location = new System.Drawing.Point(20, 110);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(132, 25);
            this.cbLocation.TabIndex = 2;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.Gainsboro;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "--Category--",
            "Any"});
            this.cbCategory.Location = new System.Drawing.Point(20, 141);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(132, 25);
            this.cbCategory.TabIndex = 3;
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.Gainsboro;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "--Status--",
            "Any"});
            this.cbStatus.Location = new System.Drawing.Point(20, 172);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(132, 25);
            this.cbStatus.TabIndex = 4;
            // 
            // lblRelatedResults
            // 
            this.lblRelatedResults.AutoSize = true;
            this.lblRelatedResults.Location = new System.Drawing.Point(150, 400);
            this.lblRelatedResults.Name = "lblRelatedResults";
            this.lblRelatedResults.Size = new System.Drawing.Size(0, 13);
            this.lblRelatedResults.TabIndex = 5;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblHeading.Location = new System.Drawing.Point(11, 9);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(482, 42);
            this.lblHeading.TabIndex = 9;
            this.lblHeading.Text = "Track Service Request Status";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.pnFileViewer);
            this.panel1.Controls.Add(this.flpRequestData);
            this.panel1.Controls.Add(this.lblFileView);
            this.panel1.Controls.Add(this.lblPanelHeading);
            this.panel1.Location = new System.Drawing.Point(520, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 354);
            this.panel1.TabIndex = 10;
            // 
            // pnFileViewer
            // 
            this.pnFileViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnFileViewer.Controls.Add(this.lblFilePreview);
            this.pnFileViewer.Controls.Add(this.rtbFilePreview);
            this.pnFileViewer.Controls.Add(this.pbFilePreview);
            this.pnFileViewer.Location = new System.Drawing.Point(206, 36);
            this.pnFileViewer.Name = "pnFileViewer";
            this.pnFileViewer.Size = new System.Drawing.Size(281, 302);
            this.pnFileViewer.TabIndex = 22;
            // 
            // lblFilePreview
            // 
            this.lblFilePreview.AutoSize = true;
            this.lblFilePreview.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePreview.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFilePreview.Location = new System.Drawing.Point(3, 3);
            this.lblFilePreview.Name = "lblFilePreview";
            this.lblFilePreview.Size = new System.Drawing.Size(90, 19);
            this.lblFilePreview.TabIndex = 16;
            this.lblFilePreview.Text = "File Preview";
            // 
            // rtbFilePreview
            // 
            this.rtbFilePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbFilePreview.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFilePreview.Location = new System.Drawing.Point(0, 24);
            this.rtbFilePreview.Margin = new System.Windows.Forms.Padding(2);
            this.rtbFilePreview.Name = "rtbFilePreview";
            this.rtbFilePreview.ReadOnly = true;
            this.rtbFilePreview.Size = new System.Drawing.Size(281, 278);
            this.rtbFilePreview.TabIndex = 15;
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
            this.pbFilePreview.Location = new System.Drawing.Point(0, 24);
            this.pbFilePreview.Margin = new System.Windows.Forms.Padding(2);
            this.pbFilePreview.Name = "pbFilePreview";
            this.pbFilePreview.Size = new System.Drawing.Size(281, 278);
            this.pbFilePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFilePreview.TabIndex = 14;
            this.pbFilePreview.TabStop = false;
            this.pbFilePreview.Visible = false;
            // 
            // flpRequestData
            // 
            this.flpRequestData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpRequestData.AutoSize = true;
            this.flpRequestData.Controls.Add(this.lblLocationHeading);
            this.flpRequestData.Controls.Add(this.lblLocation);
            this.flpRequestData.Controls.Add(this.lblCategoryHeading);
            this.flpRequestData.Controls.Add(this.lblCategory);
            this.flpRequestData.Controls.Add(this.lbldescriptionHeading);
            this.flpRequestData.Controls.Add(this.lblDescription);
            this.flpRequestData.Controls.Add(this.lblStatusHeading);
            this.flpRequestData.Controls.Add(this.lblStatus);
            this.flpRequestData.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpRequestData.Location = new System.Drawing.Point(3, 36);
            this.flpRequestData.Name = "flpRequestData";
            this.flpRequestData.Size = new System.Drawing.Size(203, 302);
            this.flpRequestData.TabIndex = 21;
            // 
            // lblLocationHeading
            // 
            this.lblLocationHeading.AutoSize = true;
            this.lblLocationHeading.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLocationHeading.Location = new System.Drawing.Point(3, 0);
            this.lblLocationHeading.Name = "lblLocationHeading";
            this.lblLocationHeading.Size = new System.Drawing.Size(66, 19);
            this.lblLocationHeading.TabIndex = 17;
            this.lblLocationHeading.Text = "Location";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblLocation.Location = new System.Drawing.Point(10, 19);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.lblLocation.MaximumSize = new System.Drawing.Size(170, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(23, 17);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "---";
            // 
            // lblCategoryHeading
            // 
            this.lblCategoryHeading.AutoSize = true;
            this.lblCategoryHeading.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCategoryHeading.Location = new System.Drawing.Point(3, 46);
            this.lblCategoryHeading.Name = "lblCategoryHeading";
            this.lblCategoryHeading.Size = new System.Drawing.Size(70, 19);
            this.lblCategoryHeading.TabIndex = 18;
            this.lblCategoryHeading.Text = "Category";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCategory.Location = new System.Drawing.Point(10, 65);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.lblCategory.MaximumSize = new System.Drawing.Size(170, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(23, 17);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "---";
            // 
            // lbldescriptionHeading
            // 
            this.lbldescriptionHeading.AutoSize = true;
            this.lbldescriptionHeading.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescriptionHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbldescriptionHeading.Location = new System.Drawing.Point(3, 92);
            this.lbldescriptionHeading.Name = "lbldescriptionHeading";
            this.lbldescriptionHeading.Size = new System.Drawing.Size(85, 19);
            this.lbldescriptionHeading.TabIndex = 19;
            this.lbldescriptionHeading.Text = "Description";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDescription.Location = new System.Drawing.Point(10, 111);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.lblDescription.MaximumSize = new System.Drawing.Size(170, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(23, 17);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "---";
            // 
            // lblStatusHeading
            // 
            this.lblStatusHeading.AutoSize = true;
            this.lblStatusHeading.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStatusHeading.Location = new System.Drawing.Point(3, 138);
            this.lblStatusHeading.Name = "lblStatusHeading";
            this.lblStatusHeading.Size = new System.Drawing.Size(49, 19);
            this.lblStatusHeading.TabIndex = 20;
            this.lblStatusHeading.Text = "Status";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblStatus.Location = new System.Drawing.Point(10, 157);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.lblStatus.MaximumSize = new System.Drawing.Size(170, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(30, 19);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "---";
            // 
            // lblFileView
            // 
            this.lblFileView.AutoSize = true;
            this.lblFileView.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileView.Location = new System.Drawing.Point(206, 36);
            this.lblFileView.Name = "lblFileView";
            this.lblFileView.Size = new System.Drawing.Size(0, 17);
            this.lblFileView.TabIndex = 5;
            // 
            // lblPanelHeading
            // 
            this.lblPanelHeading.AutoSize = true;
            this.lblPanelHeading.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanelHeading.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblPanelHeading.Location = new System.Drawing.Point(4, 4);
            this.lblPanelHeading.Name = "lblPanelHeading";
            this.lblPanelHeading.Size = new System.Drawing.Size(222, 22);
            this.lblPanelHeading.TabIndex = 0;
            this.lblPanelHeading.Text = "Service Request Overview:";
            // 
            // ServiceRequestForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1034, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblRelatedResults);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lvRequests);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "ServiceRequestForm";
            this.Text = "Service Request Status";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnFileViewer.ResumeLayout(false);
            this.pnFileViewer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilePreview)).EndInit();
            this.flpRequestData.ResumeLayout(false);
            this.flpRequestData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
