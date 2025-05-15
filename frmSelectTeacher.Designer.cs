namespace University
{
    partial class frmSelectTeacher
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
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clmPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFathersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEducational_Field = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.AllowUserToAddRows = false;
            this.dgvTeacher.AllowUserToDeleteRows = false;
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPhoto,
            this.clmUserName,
            this.clmName,
            this.clmNationalCode,
            this.clmFathersName,
            this.clmEducational_Field,
            this.clmGender});
            this.dgvTeacher.Location = new System.Drawing.Point(4, 260);
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.ReadOnly = true;
            this.dgvTeacher.Size = new System.Drawing.Size(775, 460);
            this.dgvTeacher.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(299, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(172, 44);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "انتخاب استاد";
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(12, 189);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(147, 54);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "انتخاب ";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "انتخاب استاد";
            // 
            // clmPhoto
            // 
            this.clmPhoto.HeaderText = "عکس";
            this.clmPhoto.Name = "clmPhoto";
            this.clmPhoto.ReadOnly = true;
            // 
            // clmUserName
            // 
            this.clmUserName.HeaderText = "کد پرسنلی";
            this.clmUserName.Name = "clmUserName";
            this.clmUserName.ReadOnly = true;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "نام";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            // 
            // clmNationalCode
            // 
            this.clmNationalCode.HeaderText = "کد ملی";
            this.clmNationalCode.Name = "clmNationalCode";
            this.clmNationalCode.ReadOnly = true;
            // 
            // clmFathersName
            // 
            this.clmFathersName.HeaderText = "نام پدر";
            this.clmFathersName.Name = "clmFathersName";
            this.clmFathersName.ReadOnly = true;
            // 
            // clmEducational_Field
            // 
            this.clmEducational_Field.HeaderText = "رشته";
            this.clmEducational_Field.Name = "clmEducational_Field";
            this.clmEducational_Field.ReadOnly = true;
            // 
            // clmGender
            // 
            this.clmGender.HeaderText = "جنسیت";
            this.clmGender.Name = "clmGender";
            this.clmGender.ReadOnly = true;
            // 
            // frmSelectTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 722);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dgvTeacher);
            this.Name = "frmSelectTeacher";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frmSelectTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeacher;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn clmPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFathersName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEducational_Field;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGender;
    }
}