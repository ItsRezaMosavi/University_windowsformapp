namespace University
{
    partial class frmPresenceAbsenceReport
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
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.pnlAbsenceLimit = new System.Windows.Forms.Panel();
            this.rdb5Absence = new System.Windows.Forms.RadioButton();
            this.rdb4Absence = new System.Windows.Forms.RadioButton();
            this.rdb3Absence = new System.Windows.Forms.RadioButton();
            this.lblAbsenceLimit = new System.Windows.Forms.Label();
            this.clmPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmClassRoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLessonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPresenceCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAbsenceCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.pnlAbsenceLimit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPhoto,
            this.clmUserName,
            this.clmFirstName,
            this.clmLastName,
            this.clmClassRoomId,
            this.clmTeacherName,
            this.clmLessonName,
            this.clmPresenceCount,
            this.clmAbsenceCount});
            this.dgvStudents.Location = new System.Drawing.Point(1, 278);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.Size = new System.Drawing.Size(1143, 387);
            this.dgvStudents.TabIndex = 0;
            // 
            // pnlAbsenceLimit
            // 
            this.pnlAbsenceLimit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAbsenceLimit.Controls.Add(this.rdb5Absence);
            this.pnlAbsenceLimit.Controls.Add(this.rdb4Absence);
            this.pnlAbsenceLimit.Controls.Add(this.rdb3Absence);
            this.pnlAbsenceLimit.Controls.Add(this.lblAbsenceLimit);
            this.pnlAbsenceLimit.Location = new System.Drawing.Point(678, 44);
            this.pnlAbsenceLimit.Name = "pnlAbsenceLimit";
            this.pnlAbsenceLimit.Size = new System.Drawing.Size(443, 117);
            this.pnlAbsenceLimit.TabIndex = 1;
            // 
            // rdb5Absence
            // 
            this.rdb5Absence.AutoSize = true;
            this.rdb5Absence.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb5Absence.Location = new System.Drawing.Point(27, 75);
            this.rdb5Absence.Name = "rdb5Absence";
            this.rdb5Absence.Size = new System.Drawing.Size(95, 33);
            this.rdb5Absence.TabIndex = 3;
            this.rdb5Absence.TabStop = true;
            this.rdb5Absence.Text = "5 غیبت";
            this.rdb5Absence.UseVisualStyleBackColor = true;
            // 
            // rdb4Absence
            // 
            this.rdb4Absence.AutoSize = true;
            this.rdb4Absence.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb4Absence.Location = new System.Drawing.Point(167, 75);
            this.rdb4Absence.Name = "rdb4Absence";
            this.rdb4Absence.Size = new System.Drawing.Size(95, 33);
            this.rdb4Absence.TabIndex = 2;
            this.rdb4Absence.TabStop = true;
            this.rdb4Absence.Text = "4 غیبت";
            this.rdb4Absence.UseVisualStyleBackColor = true;
            // 
            // rdb3Absence
            // 
            this.rdb3Absence.AutoSize = true;
            this.rdb3Absence.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb3Absence.Location = new System.Drawing.Point(304, 75);
            this.rdb3Absence.Name = "rdb3Absence";
            this.rdb3Absence.Size = new System.Drawing.Size(95, 33);
            this.rdb3Absence.TabIndex = 1;
            this.rdb3Absence.TabStop = true;
            this.rdb3Absence.Text = "3 غیبت";
            this.rdb3Absence.UseVisualStyleBackColor = true;
            // 
            // lblAbsenceLimit
            // 
            this.lblAbsenceLimit.AutoSize = true;
            this.lblAbsenceLimit.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbsenceLimit.Location = new System.Drawing.Point(121, 12);
            this.lblAbsenceLimit.Name = "lblAbsenceLimit";
            this.lblAbsenceLimit.Size = new System.Drawing.Size(205, 32);
            this.lblAbsenceLimit.TabIndex = 0;
            this.lblAbsenceLimit.Text = "تعداد غیبت های مجاز";
            // 
            // clmPhoto
            // 
            this.clmPhoto.HeaderText = "عکس";
            this.clmPhoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.clmPhoto.Name = "clmPhoto";
            this.clmPhoto.ReadOnly = true;
            // 
            // clmUserName
            // 
            this.clmUserName.HeaderText = "کد دانشجویی";
            this.clmUserName.Name = "clmUserName";
            this.clmUserName.ReadOnly = true;
            // 
            // clmFirstName
            // 
            this.clmFirstName.HeaderText = "نام";
            this.clmFirstName.Name = "clmFirstName";
            this.clmFirstName.ReadOnly = true;
            // 
            // clmLastName
            // 
            this.clmLastName.HeaderText = "نام خانوادگی";
            this.clmLastName.Name = "clmLastName";
            this.clmLastName.ReadOnly = true;
            // 
            // clmClassRoomId
            // 
            this.clmClassRoomId.HeaderText = "کد کلاس";
            this.clmClassRoomId.Name = "clmClassRoomId";
            this.clmClassRoomId.ReadOnly = true;
            // 
            // clmTeacherName
            // 
            this.clmTeacherName.HeaderText = "نام استاد";
            this.clmTeacherName.Name = "clmTeacherName";
            this.clmTeacherName.ReadOnly = true;
            // 
            // clmLessonName
            // 
            this.clmLessonName.HeaderText = "نام درس";
            this.clmLessonName.Name = "clmLessonName";
            this.clmLessonName.ReadOnly = true;
            // 
            // clmPresenceCount
            // 
            this.clmPresenceCount.HeaderText = "تعداد حضور";
            this.clmPresenceCount.Name = "clmPresenceCount";
            this.clmPresenceCount.ReadOnly = true;
            // 
            // clmAbsenceCount
            // 
            this.clmAbsenceCount.HeaderText = "تعداد غیبت";
            this.clmAbsenceCount.Name = "clmAbsenceCount";
            this.clmAbsenceCount.ReadOnly = true;
            // 
            // frmPresenceAbsenceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 663);
            this.Controls.Add(this.pnlAbsenceLimit);
            this.Controls.Add(this.dgvStudents);
            this.Name = "frmPresenceAbsenceReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frmPresenceAbsenceReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.pnlAbsenceLimit.ResumeLayout(false);
            this.pnlAbsenceLimit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Panel pnlAbsenceLimit;
        private System.Windows.Forms.RadioButton rdb5Absence;
        private System.Windows.Forms.RadioButton rdb4Absence;
        private System.Windows.Forms.RadioButton rdb3Absence;
        private System.Windows.Forms.Label lblAbsenceLimit;
        private System.Windows.Forms.DataGridViewImageColumn clmPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClassRoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLessonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPresenceCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAbsenceCount;
    }
}