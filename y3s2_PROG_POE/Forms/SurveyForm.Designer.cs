namespace y3s2_PROG_POE.Forms
{
    partial class SurveyForm
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rdoStar1 = new System.Windows.Forms.RadioButton();
            this.rdoStar2 = new System.Windows.Forms.RadioButton();
            this.rdoStar3 = new System.Windows.Forms.RadioButton();
            this.rdoStar4 = new System.Windows.Forms.RadioButton();
            this.rdoStar5 = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlController = new System.Windows.Forms.Panel();
            this.pnlController.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(12, 9);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(130, 24);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question Text";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdoStar1
            // 
            this.rdoStar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoStar1.AutoSize = true;
            this.rdoStar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoStar1.Location = new System.Drawing.Point(66, 3);
            this.rdoStar1.Name = "rdoStar1";
            this.rdoStar1.Size = new System.Drawing.Size(75, 24);
            this.rdoStar1.TabIndex = 1;
            this.rdoStar1.TabStop = true;
            this.rdoStar1.Text = "1 Star";
            this.rdoStar1.UseVisualStyleBackColor = true;
            // 
            // rdoStar2
            // 
            this.rdoStar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoStar2.AutoSize = true;
            this.rdoStar2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoStar2.Location = new System.Drawing.Point(66, 33);
            this.rdoStar2.Name = "rdoStar2";
            this.rdoStar2.Size = new System.Drawing.Size(85, 27);
            this.rdoStar2.TabIndex = 2;
            this.rdoStar2.TabStop = true;
            this.rdoStar2.Text = "2 Stars";
            this.rdoStar2.UseVisualStyleBackColor = true;
            // 
            // rdoStar3
            // 
            this.rdoStar3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoStar3.AutoSize = true;
            this.rdoStar3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoStar3.Location = new System.Drawing.Point(66, 66);
            this.rdoStar3.Name = "rdoStar3";
            this.rdoStar3.Size = new System.Drawing.Size(85, 27);
            this.rdoStar3.TabIndex = 3;
            this.rdoStar3.TabStop = true;
            this.rdoStar3.Text = "3 Stars";
            this.rdoStar3.UseVisualStyleBackColor = true;
            // 
            // rdoStar4
            // 
            this.rdoStar4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoStar4.AutoSize = true;
            this.rdoStar4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoStar4.Location = new System.Drawing.Point(66, 99);
            this.rdoStar4.Name = "rdoStar4";
            this.rdoStar4.Size = new System.Drawing.Size(85, 27);
            this.rdoStar4.TabIndex = 4;
            this.rdoStar4.TabStop = true;
            this.rdoStar4.Text = "4 Stars";
            this.rdoStar4.UseVisualStyleBackColor = true;
            // 
            // rdoStar5
            // 
            this.rdoStar5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoStar5.AutoSize = true;
            this.rdoStar5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoStar5.Location = new System.Drawing.Point(66, 132);
            this.rdoStar5.Name = "rdoStar5";
            this.rdoStar5.Size = new System.Drawing.Size(85, 27);
            this.rdoStar5.TabIndex = 5;
            this.rdoStar5.TabStop = true;
            this.rdoStar5.Text = "5 Stars";
            this.rdoStar5.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSubmit.BackColor = System.Drawing.Color.Orange;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(0, 176);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(210, 65);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // pnlController
            // 
            this.pnlController.Controls.Add(this.btnSubmit);
            this.pnlController.Controls.Add(this.rdoStar1);
            this.pnlController.Controls.Add(this.rdoStar5);
            this.pnlController.Controls.Add(this.rdoStar2);
            this.pnlController.Controls.Add(this.rdoStar4);
            this.pnlController.Controls.Add(this.rdoStar3);
            this.pnlController.Location = new System.Drawing.Point(207, 67);
            this.pnlController.Name = "pnlController";
            this.pnlController.Size = new System.Drawing.Size(210, 244);
            this.pnlController.TabIndex = 9;
            // 
            // SurveyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(657, 333);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.pnlController);
            this.Name = "SurveyForm";
            this.Text = "Rate your experience";
            this.pnlController.ResumeLayout(false);
            this.pnlController.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rdoStar1;
        private System.Windows.Forms.RadioButton rdoStar2;
        private System.Windows.Forms.RadioButton rdoStar3;
        private System.Windows.Forms.RadioButton rdoStar4;
        private System.Windows.Forms.RadioButton rdoStar5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnlController;
    }
}