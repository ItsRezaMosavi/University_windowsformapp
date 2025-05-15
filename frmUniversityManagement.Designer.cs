namespace University
{
    partial class frmUniversityManagement
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
            this.pnlCollege = new System.Windows.Forms.Panel();
            this.btnDeleteCollege = new System.Windows.Forms.Button();
            this.btnAddCollege = new System.Windows.Forms.Button();
            this.lblCollege = new System.Windows.Forms.Label();
            this.dgvCollege = new System.Windows.Forms.DataGridView();
            this.btnEditCollege = new System.Windows.Forms.Button();
            this.pnlEducationalField = new System.Windows.Forms.Panel();
            this.btnDeleteEducationalField = new System.Windows.Forms.Button();
            this.btnAddEducationalField = new System.Windows.Forms.Button();
            this.btnEditEducationalField = new System.Windows.Forms.Button();
            this.lblEducational_Field = new System.Windows.Forms.Label();
            this.dgvEducationalField = new System.Windows.Forms.DataGridView();
            this.pnlCollege.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollege)).BeginInit();
            this.pnlEducationalField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEducationalField)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCollege
            // 
            this.pnlCollege.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCollege.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCollege.Controls.Add(this.btnDeleteCollege);
            this.pnlCollege.Controls.Add(this.btnAddCollege);
            this.pnlCollege.Controls.Add(this.lblCollege);
            this.pnlCollege.Controls.Add(this.dgvCollege);
            this.pnlCollege.Controls.Add(this.btnEditCollege);
            this.pnlCollege.Enabled = false;
            this.pnlCollege.Location = new System.Drawing.Point(583, 194);
            this.pnlCollege.Name = "pnlCollege";
            this.pnlCollege.Size = new System.Drawing.Size(412, 474);
            this.pnlCollege.TabIndex = 0;
            this.pnlCollege.Visible = false;
            // 
            // btnDeleteCollege
            // 
            this.btnDeleteCollege.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCollege.Location = new System.Drawing.Point(3, 92);
            this.btnDeleteCollege.Name = "btnDeleteCollege";
            this.btnDeleteCollege.Size = new System.Drawing.Size(125, 48);
            this.btnDeleteCollege.TabIndex = 4;
            this.btnDeleteCollege.Text = "حذف";
            this.btnDeleteCollege.UseVisualStyleBackColor = true;
            this.btnDeleteCollege.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddCollege
            // 
            this.btnAddCollege.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCollege.Location = new System.Drawing.Point(273, 92);
            this.btnAddCollege.Name = "btnAddCollege";
            this.btnAddCollege.Size = new System.Drawing.Size(125, 48);
            this.btnAddCollege.TabIndex = 2;
            this.btnAddCollege.Text = "افزودن";
            this.btnAddCollege.UseVisualStyleBackColor = true;
            this.btnAddCollege.Click += new System.EventHandler(this.btnAddCollege_Click);
            // 
            // lblCollege
            // 
            this.lblCollege.AutoSize = true;
            this.lblCollege.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollege.Location = new System.Drawing.Point(157, 30);
            this.lblCollege.Name = "lblCollege";
            this.lblCollege.Size = new System.Drawing.Size(101, 37);
            this.lblCollege.TabIndex = 1;
            this.lblCollege.Text = "دانشکده";
            // 
            // dgvCollege
            // 
            this.dgvCollege.AllowUserToAddRows = false;
            this.dgvCollege.AllowUserToDeleteRows = false;
            this.dgvCollege.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCollege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCollege.Location = new System.Drawing.Point(-2, 176);
            this.dgvCollege.Name = "dgvCollege";
            this.dgvCollege.ReadOnly = true;
            this.dgvCollege.Size = new System.Drawing.Size(412, 296);
            this.dgvCollege.TabIndex = 0;
            // 
            // btnEditCollege
            // 
            this.btnEditCollege.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCollege.Location = new System.Drawing.Point(138, 92);
            this.btnEditCollege.Name = "btnEditCollege";
            this.btnEditCollege.Size = new System.Drawing.Size(125, 48);
            this.btnEditCollege.TabIndex = 3;
            this.btnEditCollege.Text = "ویرایش";
            this.btnEditCollege.UseVisualStyleBackColor = true;
            this.btnEditCollege.Click += new System.EventHandler(this.btnEditCollege_Click);
            // 
            // pnlEducationalField
            // 
            this.pnlEducationalField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEducationalField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEducationalField.Controls.Add(this.btnDeleteEducationalField);
            this.pnlEducationalField.Controls.Add(this.btnAddEducationalField);
            this.pnlEducationalField.Controls.Add(this.btnEditEducationalField);
            this.pnlEducationalField.Controls.Add(this.lblEducational_Field);
            this.pnlEducationalField.Controls.Add(this.dgvEducationalField);
            this.pnlEducationalField.Enabled = false;
            this.pnlEducationalField.Location = new System.Drawing.Point(3, 194);
            this.pnlEducationalField.Name = "pnlEducationalField";
            this.pnlEducationalField.Size = new System.Drawing.Size(412, 474);
            this.pnlEducationalField.TabIndex = 1;
            this.pnlEducationalField.Visible = false;
            // 
            // btnDeleteEducationalField
            // 
            this.btnDeleteEducationalField.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEducationalField.Location = new System.Drawing.Point(7, 86);
            this.btnDeleteEducationalField.Name = "btnDeleteEducationalField";
            this.btnDeleteEducationalField.Size = new System.Drawing.Size(125, 48);
            this.btnDeleteEducationalField.TabIndex = 7;
            this.btnDeleteEducationalField.Text = "حذف";
            this.btnDeleteEducationalField.UseVisualStyleBackColor = true;
            this.btnDeleteEducationalField.Click += new System.EventHandler(this.btnDeleteEducationalField_Click);
            // 
            // btnAddEducationalField
            // 
            this.btnAddEducationalField.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEducationalField.Location = new System.Drawing.Point(277, 86);
            this.btnAddEducationalField.Name = "btnAddEducationalField";
            this.btnAddEducationalField.Size = new System.Drawing.Size(125, 48);
            this.btnAddEducationalField.TabIndex = 5;
            this.btnAddEducationalField.Text = "افزودن";
            this.btnAddEducationalField.UseVisualStyleBackColor = true;
            this.btnAddEducationalField.Click += new System.EventHandler(this.btnAddEducationalField_Click);
            // 
            // btnEditEducationalField
            // 
            this.btnEditEducationalField.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEducationalField.Location = new System.Drawing.Point(142, 86);
            this.btnEditEducationalField.Name = "btnEditEducationalField";
            this.btnEditEducationalField.Size = new System.Drawing.Size(125, 48);
            this.btnEditEducationalField.TabIndex = 6;
            this.btnEditEducationalField.Text = "ویرایش";
            this.btnEditEducationalField.UseVisualStyleBackColor = true;
            this.btnEditEducationalField.Click += new System.EventHandler(this.btnEditEducationalField_Click);
            // 
            // lblEducational_Field
            // 
            this.lblEducational_Field.AutoSize = true;
            this.lblEducational_Field.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEducational_Field.Location = new System.Drawing.Point(155, 16);
            this.lblEducational_Field.Name = "lblEducational_Field";
            this.lblEducational_Field.Size = new System.Drawing.Size(74, 37);
            this.lblEducational_Field.TabIndex = 1;
            this.lblEducational_Field.Text = "رشته";
            // 
            // dgvEducationalField
            // 
            this.dgvEducationalField.AllowUserToAddRows = false;
            this.dgvEducationalField.AllowUserToDeleteRows = false;
            this.dgvEducationalField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEducationalField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEducationalField.Location = new System.Drawing.Point(-2, 176);
            this.dgvEducationalField.Name = "dgvEducationalField";
            this.dgvEducationalField.ReadOnly = true;
            this.dgvEducationalField.Size = new System.Drawing.Size(412, 296);
            this.dgvEducationalField.TabIndex = 0;
            // 
            // frmUniversityManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 670);
            this.Controls.Add(this.pnlEducationalField);
            this.Controls.Add(this.pnlCollege);
            this.Name = "frmUniversityManagement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frmUniversityManagement_Load);
            this.pnlCollege.ResumeLayout(false);
            this.pnlCollege.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollege)).EndInit();
            this.pnlEducationalField.ResumeLayout(false);
            this.pnlEducationalField.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEducationalField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCollege;
        private System.Windows.Forms.DataGridView dgvCollege;
        private System.Windows.Forms.Label lblCollege;
        private System.Windows.Forms.Panel pnlEducationalField;
        private System.Windows.Forms.Label lblEducational_Field;
        private System.Windows.Forms.DataGridView dgvEducationalField;
        private System.Windows.Forms.Button btnAddCollege;
        private System.Windows.Forms.Button btnEditCollege;
        private System.Windows.Forms.Button btnDeleteCollege;
        private System.Windows.Forms.Button btnDeleteEducationalField;
        private System.Windows.Forms.Button btnAddEducationalField;
        private System.Windows.Forms.Button btnEditEducationalField;
    }
}