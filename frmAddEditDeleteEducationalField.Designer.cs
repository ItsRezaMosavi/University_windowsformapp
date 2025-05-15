namespace University
{
    partial class frmAddEditDeleteEducationalField
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
            this.cmbCollege = new System.Windows.Forms.ComboBox();
            this.lblCollege = new System.Windows.Forms.Label();
            this.txtEducationalField = new System.Windows.Forms.TextBox();
            this.lblEducationalField = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnOperation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCollege
            // 
            this.cmbCollege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCollege.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCollege.FormattingEnabled = true;
            this.cmbCollege.Location = new System.Drawing.Point(26, 202);
            this.cmbCollege.Name = "cmbCollege";
            this.cmbCollege.Size = new System.Drawing.Size(221, 47);
            this.cmbCollege.TabIndex = 0;
            // 
            // lblCollege
            // 
            this.lblCollege.AutoSize = true;
            this.lblCollege.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollege.Location = new System.Drawing.Point(264, 205);
            this.lblCollege.Name = "lblCollege";
            this.lblCollege.Size = new System.Drawing.Size(124, 39);
            this.lblCollege.TabIndex = 1;
            this.lblCollege.Text = "دانشکده :";
            // 
            // txtEducationalField
            // 
            this.txtEducationalField.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEducationalField.Location = new System.Drawing.Point(26, 118);
            this.txtEducationalField.Name = "txtEducationalField";
            this.txtEducationalField.Size = new System.Drawing.Size(221, 47);
            this.txtEducationalField.TabIndex = 2;
            // 
            // lblEducationalField
            // 
            this.lblEducationalField.AutoSize = true;
            this.lblEducationalField.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEducationalField.Location = new System.Drawing.Point(275, 121);
            this.lblEducationalField.Name = "lblEducationalField";
            this.lblEducationalField.Size = new System.Drawing.Size(85, 39);
            this.lblEducationalField.TabIndex = 3;
            this.lblEducationalField.Text = "رشته :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(141, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(114, 45);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "label1";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnOperation
            // 
            this.btnOperation.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperation.Location = new System.Drawing.Point(112, 298);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(163, 50);
            this.btnOperation.TabIndex = 5;
            this.btnOperation.Text = "button1";
            this.btnOperation.UseVisualStyleBackColor = true;
            this.btnOperation.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // frmAddEditDeleteEducationalField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 402);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblEducationalField);
            this.Controls.Add(this.txtEducationalField);
            this.Controls.Add(this.lblCollege);
            this.Controls.Add(this.cmbCollege);
            this.Name = "frmAddEditDeleteEducationalField";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frmAddEditDeleteEducationalField_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCollege;
        private System.Windows.Forms.Label lblCollege;
        private System.Windows.Forms.TextBox txtEducationalField;
        private System.Windows.Forms.Label lblEducationalField;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnOperation;
    }
}