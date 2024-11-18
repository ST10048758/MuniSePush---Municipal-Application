namespace y3s2_PROG_POE.Forms
{
    partial class RecommendationsForm
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
            this.pnlRecommendation = new System.Windows.Forms.Panel();
            this.llEvent3 = new System.Windows.Forms.LinkLabel();
            this.llEvent2 = new System.Windows.Forms.LinkLabel();
            this.llEvent1 = new System.Windows.Forms.LinkLabel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblHeader2 = new System.Windows.Forms.Label();
            this.rtbEvent1 = new System.Windows.Forms.RichTextBox();
            this.rtbEvent2 = new System.Windows.Forms.RichTextBox();
            this.rtbEvent3 = new System.Windows.Forms.RichTextBox();
            this.pnlRecommendation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRecommendation
            // 
            this.pnlRecommendation.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlRecommendation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRecommendation.Controls.Add(this.rtbEvent3);
            this.pnlRecommendation.Controls.Add(this.rtbEvent2);
            this.pnlRecommendation.Controls.Add(this.rtbEvent1);
            this.pnlRecommendation.Controls.Add(this.llEvent3);
            this.pnlRecommendation.Controls.Add(this.llEvent2);
            this.pnlRecommendation.Controls.Add(this.llEvent1);
            this.pnlRecommendation.Location = new System.Drawing.Point(12, 82);
            this.pnlRecommendation.Name = "pnlRecommendation";
            this.pnlRecommendation.Size = new System.Drawing.Size(473, 316);
            this.pnlRecommendation.TabIndex = 4;
            // 
            // llEvent3
            // 
            this.llEvent3.AutoSize = true;
            this.llEvent3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llEvent3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.llEvent3.Location = new System.Drawing.Point(13, 206);
            this.llEvent3.Name = "llEvent3";
            this.llEvent3.Size = new System.Drawing.Size(86, 21);
            this.llEvent3.TabIndex = 3;
            this.llEvent3.TabStop = true;
            this.llEvent3.Text = "linkLabel3";
            this.llEvent3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llEvent3.Click += new System.EventHandler(this.llEvent_Click);
            // 
            // llEvent2
            // 
            this.llEvent2.AutoSize = true;
            this.llEvent2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llEvent2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.llEvent2.Location = new System.Drawing.Point(13, 112);
            this.llEvent2.Name = "llEvent2";
            this.llEvent2.Size = new System.Drawing.Size(86, 21);
            this.llEvent2.TabIndex = 2;
            this.llEvent2.TabStop = true;
            this.llEvent2.Text = "linkLabel2";
            this.llEvent2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llEvent2.Click += new System.EventHandler(this.llEvent_Click);
            // 
            // llEvent1
            // 
            this.llEvent1.AutoSize = true;
            this.llEvent1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llEvent1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.llEvent1.Location = new System.Drawing.Point(13, 14);
            this.llEvent1.Name = "llEvent1";
            this.llEvent1.Size = new System.Drawing.Size(86, 21);
            this.llEvent1.TabIndex = 1;
            this.llEvent1.TabStop = true;
            this.llEvent1.Text = "linkLabel1";
            this.llEvent1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.llEvent1.Click += new System.EventHandler(this.llEvent_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblHeader.Location = new System.Drawing.Point(140, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(224, 26);
            this.lblHeader.TabIndex = 5;
            this.lblHeader.Text = "Recommended Events";
            // 
            // lblHeader2
            // 
            this.lblHeader2.AutoSize = true;
            this.lblHeader2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblHeader2.Location = new System.Drawing.Point(172, 35);
            this.lblHeader2.Name = "lblHeader2";
            this.lblHeader2.Size = new System.Drawing.Size(167, 19);
            this.lblHeader2.TabIndex = 6;
            this.lblHeader2.Text = "Select an event to view:";
            // 
            // rtbEvent1
            // 
            this.rtbEvent1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rtbEvent1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbEvent1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbEvent1.ForeColor = System.Drawing.SystemColors.Info;
            this.rtbEvent1.Location = new System.Drawing.Point(17, 49);
            this.rtbEvent1.Name = "rtbEvent1";
            this.rtbEvent1.Size = new System.Drawing.Size(431, 49);
            this.rtbEvent1.TabIndex = 4;
            this.rtbEvent1.Text = "";
            // 
            // rtbEvent2
            // 
            this.rtbEvent2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rtbEvent2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbEvent2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbEvent2.ForeColor = System.Drawing.SystemColors.Info;
            this.rtbEvent2.Location = new System.Drawing.Point(17, 146);
            this.rtbEvent2.Name = "rtbEvent2";
            this.rtbEvent2.Size = new System.Drawing.Size(431, 49);
            this.rtbEvent2.TabIndex = 5;
            this.rtbEvent2.Text = "";
            // 
            // rtbEvent3
            // 
            this.rtbEvent3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rtbEvent3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbEvent3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbEvent3.ForeColor = System.Drawing.SystemColors.Info;
            this.rtbEvent3.Location = new System.Drawing.Point(17, 238);
            this.rtbEvent3.Name = "rtbEvent3";
            this.rtbEvent3.Size = new System.Drawing.Size(431, 49);
            this.rtbEvent3.TabIndex = 6;
            this.rtbEvent3.Text = "";
            // 
            // RecommendationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(497, 423);
            this.Controls.Add(this.lblHeader2);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pnlRecommendation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RecommendationsForm";
            this.Text = "Event Recommendations";
            this.pnlRecommendation.ResumeLayout(false);
            this.pnlRecommendation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRecommendation;
        private System.Windows.Forms.LinkLabel llEvent3;
        private System.Windows.Forms.LinkLabel llEvent2;
        private System.Windows.Forms.LinkLabel llEvent1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblHeader2;
        private System.Windows.Forms.RichTextBox rtbEvent3;
        private System.Windows.Forms.RichTextBox rtbEvent2;
        private System.Windows.Forms.RichTextBox rtbEvent1;
    }
}