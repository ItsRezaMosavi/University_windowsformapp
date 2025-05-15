namespace University
{
    partial class frmRegisterScore
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblClassPoint = new System.Windows.Forms.Label();
            this.lblMidTermScore = new System.Windows.Forms.Label();
            this.lblFinalScore = new System.Windows.Forms.Label();
            this.btnRegisterScore = new System.Windows.Forms.Button();
            this.txtClassPoint = new System.Windows.Forms.TextBox();
            this.txtMidTermScore = new System.Windows.Forms.TextBox();
            this.txtFinalScore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(178, 43);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(126, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ثبت نمره";
            // 
            // lblClassPoint
            // 
            this.lblClassPoint.AutoSize = true;
            this.lblClassPoint.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassPoint.Location = new System.Drawing.Point(302, 194);
            this.lblClassPoint.Name = "lblClassPoint";
            this.lblClassPoint.Size = new System.Drawing.Size(97, 26);
            this.lblClassPoint.TabIndex = 7;
            this.lblClassPoint.Text = "نمره کلاسی :";
            // 
            // lblMidTermScore
            // 
            this.lblMidTermScore.AutoSize = true;
            this.lblMidTermScore.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMidTermScore.Location = new System.Drawing.Point(287, 302);
            this.lblMidTermScore.Name = "lblMidTermScore";
            this.lblMidTermScore.Size = new System.Drawing.Size(112, 26);
            this.lblMidTermScore.TabIndex = 8;
            this.lblMidTermScore.Text = "نمره میان ترم :";
            // 
            // lblFinalScore
            // 
            this.lblFinalScore.AutoSize = true;
            this.lblFinalScore.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalScore.Location = new System.Drawing.Point(294, 415);
            this.lblFinalScore.Name = "lblFinalScore";
            this.lblFinalScore.Size = new System.Drawing.Size(113, 26);
            this.lblFinalScore.TabIndex = 9;
            this.lblFinalScore.Text = "نمره پایان ترم :";
            // 
            // btnRegisterScore
            // 
            this.btnRegisterScore.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterScore.Location = new System.Drawing.Point(145, 539);
            this.btnRegisterScore.Name = "btnRegisterScore";
            this.btnRegisterScore.Size = new System.Drawing.Size(184, 77);
            this.btnRegisterScore.TabIndex = 11;
            this.btnRegisterScore.Text = "ثبت نمره";
            this.btnRegisterScore.UseVisualStyleBackColor = true;
            this.btnRegisterScore.Click += new System.EventHandler(this.btnRegisterScore_Click);
            // 
            // txtClassPoint
            // 
            this.txtClassPoint.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassPoint.Location = new System.Drawing.Point(83, 185);
            this.txtClassPoint.Name = "txtClassPoint";
            this.txtClassPoint.Size = new System.Drawing.Size(145, 40);
            this.txtClassPoint.TabIndex = 12;
            // 
            // txtMidTermScore
            // 
            this.txtMidTermScore.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMidTermScore.Location = new System.Drawing.Point(83, 293);
            this.txtMidTermScore.Name = "txtMidTermScore";
            this.txtMidTermScore.Size = new System.Drawing.Size(145, 40);
            this.txtMidTermScore.TabIndex = 13;
            // 
            // txtFinalScore
            // 
            this.txtFinalScore.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalScore.Location = new System.Drawing.Point(83, 401);
            this.txtFinalScore.Name = "txtFinalScore";
            this.txtFinalScore.Size = new System.Drawing.Size(145, 40);
            this.txtFinalScore.TabIndex = 14;
            // 
            // frmRegisterScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 679);
            this.Controls.Add(this.txtFinalScore);
            this.Controls.Add(this.txtMidTermScore);
            this.Controls.Add(this.txtClassPoint);
            this.Controls.Add(this.btnRegisterScore);
            this.Controls.Add(this.lblFinalScore);
            this.Controls.Add(this.lblMidTermScore);
            this.Controls.Add(this.lblClassPoint);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmRegisterScore";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frmRegisterScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblClassPoint;
        private System.Windows.Forms.Label lblMidTermScore;
        private System.Windows.Forms.Label lblFinalScore;
        private System.Windows.Forms.Button btnRegisterScore;
        private System.Windows.Forms.TextBox txtClassPoint;
        private System.Windows.Forms.TextBox txtMidTermScore;
        private System.Windows.Forms.TextBox txtFinalScore;
    }
}