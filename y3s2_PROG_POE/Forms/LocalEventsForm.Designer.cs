namespace y3s2_PROG_POE.Forms
{
    partial class LocalEventsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalEventsForm));
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.lblHeading = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.mcEventDateRange = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFilters = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbEventDesc = new System.Windows.Forms.RichTextBox();
            this.lblEventVenue = new System.Windows.Forms.Label();
            this.lblEventPrice = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.lblEventCat = new System.Windows.Forms.Label();
            this.lblEventDetails = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnImageContainer = new System.Windows.Forms.Panel();
            this.imgEventPoster = new System.Windows.Forms.PictureBox();
            this.btnRecommendations = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnImageContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEventPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEvents
            // 
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.AllowUserToDeleteRows = false;
            this.dgvEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvEvents.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvEvents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvEvents.Location = new System.Drawing.Point(14, 15);
            this.dgvEvents.MultiSelect = false;
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.ReadOnly = true;
            this.dgvEvents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvents.Size = new System.Drawing.Size(579, 287);
            this.dgvEvents.TabIndex = 0;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblHeading.Location = new System.Drawing.Point(13, 9);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(542, 42);
            this.lblHeading.TabIndex = 9;
            this.lblHeading.Text = "Local Events and Announcments";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.btnResetFilter);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.mcEventDateRange);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblFilters);
            this.panel2.Controls.Add(this.cmbCategories);
            this.panel2.Controls.Add(this.dgvEvents);
            this.panel2.Location = new System.Drawing.Point(12, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 315);
            this.panel2.TabIndex = 10;
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetFilter.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnResetFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnResetFilter.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilter.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetFilter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnResetFilter.Location = new System.Drawing.Point(820, 3);
            this.btnResetFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(28, 30);
            this.btnResetFilter.TabIndex = 15;
            this.btnResetFilter.Text = "X";
            this.btnResetFilter.UseVisualStyleBackColor = false;
            this.btnResetFilter.Visible = false;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilters_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.GreenYellow;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(668, 274);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 36);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Apply";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // mcEventDateRange
            // 
            this.mcEventDateRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mcEventDateRange.BackColor = System.Drawing.SystemColors.MenuText;
            this.mcEventDateRange.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcEventDateRange.ForeColor = System.Drawing.SystemColors.Window;
            this.mcEventDateRange.Location = new System.Drawing.Point(607, 107);
            this.mcEventDateRange.MaxSelectionCount = 365;
            this.mcEventDateRange.Name = "mcEventDateRange";
            this.mcEventDateRange.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(613, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date Range:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(613, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Category:";
            // 
            // lblFilters
            // 
            this.lblFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilters.AutoSize = true;
            this.lblFilters.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilters.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFilters.Location = new System.Drawing.Point(604, 3);
            this.lblFilters.Name = "lblFilters";
            this.lblFilters.Size = new System.Drawing.Size(89, 19);
            this.lblFilters.TabIndex = 5;
            this.lblFilters.Text = "Filter Events";
            // 
            // cmbCategories
            // 
            this.cmbCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategories.BackColor = System.Drawing.SystemColors.Window;
            this.cmbCategories.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(607, 50);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(227, 21);
            this.cmbCategories.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rtbEventDesc);
            this.panel1.Controls.Add(this.lblEventVenue);
            this.panel1.Controls.Add(this.lblEventPrice);
            this.panel1.Controls.Add(this.lblEventName);
            this.panel1.Controls.Add(this.lblEventDate);
            this.panel1.Controls.Add(this.lblEventCat);
            this.panel1.Location = new System.Drawing.Point(14, 36);
            this.panel1.MinimumSize = new System.Drawing.Size(2, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 153);
            this.panel1.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(247, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 32;
            this.label8.Text = "Entry Fee:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(248, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "Venue:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "About:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Date:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Category:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Name:";
            // 
            // rtbEventDesc
            // 
            this.rtbEventDesc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtbEventDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbEventDesc.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbEventDesc.Location = new System.Drawing.Point(74, 80);
            this.rtbEventDesc.Name = "rtbEventDesc";
            this.rtbEventDesc.ReadOnly = true;
            this.rtbEventDesc.Size = new System.Drawing.Size(453, 58);
            this.rtbEventDesc.TabIndex = 26;
            this.rtbEventDesc.Text = "";
            // 
            // lblEventVenue
            // 
            this.lblEventVenue.AutoSize = true;
            this.lblEventVenue.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventVenue.Location = new System.Drawing.Point(307, 32);
            this.lblEventVenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventVenue.Name = "lblEventVenue";
            this.lblEventVenue.Size = new System.Drawing.Size(0, 19);
            this.lblEventVenue.TabIndex = 25;
            // 
            // lblEventPrice
            // 
            this.lblEventPrice.AutoSize = true;
            this.lblEventPrice.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventPrice.Location = new System.Drawing.Point(325, 55);
            this.lblEventPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventPrice.Name = "lblEventPrice";
            this.lblEventPrice.Size = new System.Drawing.Size(0, 19);
            this.lblEventPrice.TabIndex = 24;
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(70, 6);
            this.lblEventName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(0, 19);
            this.lblEventName.TabIndex = 20;
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDate.Location = new System.Drawing.Point(78, 55);
            this.lblEventDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(0, 19);
            this.lblEventDate.TabIndex = 21;
            // 
            // lblEventCat
            // 
            this.lblEventCat.AutoSize = true;
            this.lblEventCat.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventCat.Location = new System.Drawing.Point(97, 32);
            this.lblEventCat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventCat.Name = "lblEventCat";
            this.lblEventCat.Size = new System.Drawing.Size(0, 19);
            this.lblEventCat.TabIndex = 22;
            // 
            // lblEventDetails
            // 
            this.lblEventDetails.AutoSize = true;
            this.lblEventDetails.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDetails.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEventDetails.Location = new System.Drawing.Point(10, 11);
            this.lblEventDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventDetails.Name = "lblEventDetails";
            this.lblEventDetails.Size = new System.Drawing.Size(120, 22);
            this.lblEventDetails.TabIndex = 19;
            this.lblEventDetails.Text = "Event Details:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.Controls.Add(this.pnImageContainer);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.lblEventDetails);
            this.panel3.Location = new System.Drawing.Point(12, 375);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(850, 201);
            this.panel3.TabIndex = 20;
            // 
            // pnImageContainer
            // 
            this.pnImageContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnImageContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnImageContainer.Controls.Add(this.imgEventPoster);
            this.pnImageContainer.Location = new System.Drawing.Point(607, 11);
            this.pnImageContainer.MinimumSize = new System.Drawing.Size(229, 180);
            this.pnImageContainer.Name = "pnImageContainer";
            this.pnImageContainer.Size = new System.Drawing.Size(229, 180);
            this.pnImageContainer.TabIndex = 20;
            // 
            // imgEventPoster
            // 
            this.imgEventPoster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgEventPoster.BackColor = System.Drawing.Color.Transparent;
            this.imgEventPoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgEventPoster.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgEventPoster.InitialImage")));
            this.imgEventPoster.Location = new System.Drawing.Point(-1, -1);
            this.imgEventPoster.MinimumSize = new System.Drawing.Size(226, 177);
            this.imgEventPoster.Name = "imgEventPoster";
            this.imgEventPoster.Size = new System.Drawing.Size(226, 177);
            this.imgEventPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgEventPoster.TabIndex = 19;
            this.imgEventPoster.TabStop = false;
            this.imgEventPoster.Click += new System.EventHandler(this.imgEventPoster_Click);
            // 
            // btnRecommendations
            // 
            this.btnRecommendations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecommendations.BackColor = System.Drawing.Color.GreenYellow;
            this.btnRecommendations.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecommendations.Location = new System.Drawing.Point(619, 12);
            this.btnRecommendations.Name = "btnRecommendations";
            this.btnRecommendations.Size = new System.Drawing.Size(243, 33);
            this.btnRecommendations.TabIndex = 21;
            this.btnRecommendations.Text = "Recommended Events";
            this.btnRecommendations.UseVisualStyleBackColor = false;
            this.btnRecommendations.Visible = false;
            this.btnRecommendations.Click += new System.EventHandler(this.btnRecommendations_Click);
            // 
            // LocalEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(881, 588);
            this.Controls.Add(this.btnRecommendations);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.panel3);
            this.Name = "LocalEventsForm";
            this.Text = "LocalEventsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnImageContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgEventPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFilters;
        private System.Windows.Forms.PictureBox imgEventPoster;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEventDetails;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.Label lblEventCat;
        private System.Windows.Forms.Label lblEventVenue;
        private System.Windows.Forms.Label lblEventPrice;
        private System.Windows.Forms.MonthCalendar mcEventDateRange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RichTextBox rtbEventDesc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRecommendations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.Panel pnImageContainer;
    }
}