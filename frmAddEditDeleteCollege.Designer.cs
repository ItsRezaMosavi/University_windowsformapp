namespace University
{
    partial class frmAddEditDeleteCollege
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
            this.txtCollegeName = new System.Windows.Forms.TextBox();
            this.lblCollegeName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnOperation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCollegeName
            // 
            this.txtCollegeName.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCollegeName.Location = new System.Drawing.Point(36, 126);
            this.txtCollegeName.Name = "txtCollegeName";
            this.txtCollegeName.Size = new System.Drawing.Size(207, 43);
            this.txtCollegeName.TabIndex = 0;
            // 
            // lblCollegeName
            // 
            this.lblCollegeName.AutoSize = true;
            this.lblCollegeName.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollegeName.Location = new System.Drawing.Point(275, 129);
            this.lblCollegeName.Name = "lblCollegeName";
            this.lblCollegeName.Size = new System.Drawing.Size(146, 36);
            this.lblCollegeName.TabIndex = 1;
            this.lblCollegeName.Text = "نام دانشکده :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(113, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(211, 42);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "افزودن دانشکده";
            // 
            // btnOperation
            // 
            this.btnOperation.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperation.Location = new System.Drawing.Point(149, 207);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(147, 58);
            this.btnOperation.TabIndex = 3;
            this.btnOperation.Text = "افزودن";
            this.btnOperation.UseVisualStyleBackColor = true;
            this.btnOperation.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAddCollege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 297);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCollegeName);
            this.Controls.Add(this.txtCollegeName);
            this.Name = "frmAddCollege";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frmAddCollege_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCollegeName;
        private System.Windows.Forms.Label lblCollegeName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnOperation;
    }
}