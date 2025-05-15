namespace University
{
    partial class frmClassRoomManagement
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
            this.pnlClass = new System.Windows.Forms.Panel();
            this.dgvClassRoom = new System.Windows.Forms.DataGridView();
            this.clmClassRoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTeacherUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLessonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLessonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCollegeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCollegeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfinishTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblClass = new System.Windows.Forms.Label();
            this.pnlYearTerm = new System.Windows.Forms.Panel();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.btnScores = new System.Windows.Forms.Button();
            this.btnPresenceAbsenceList = new System.Windows.Forms.Button();
            this.btnPresenceAbsenceReport = new System.Windows.Forms.Button();
            this.pnlClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassRoom)).BeginInit();
            this.pnlYearTerm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlClass
            // 
            this.pnlClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlClass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlClass.Controls.Add(this.dgvClassRoom);
            this.pnlClass.Controls.Add(this.lblClass);
            this.pnlClass.Location = new System.Drawing.Point(1, 96);
            this.pnlClass.Name = "pnlClass";
            this.pnlClass.Size = new System.Drawing.Size(1448, 427);
            this.pnlClass.TabIndex = 33;
            // 
            // dgvClassRoom
            // 
            this.dgvClassRoom.AllowUserToAddRows = false;
            this.dgvClassRoom.AllowUserToDeleteRows = false;
            this.dgvClassRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClassRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmClassRoomId,
            this.clmTeacherUserName,
            this.clmTeacherName,
            this.clmLessonId,
            this.clmLessonName,
            this.clmCollegeName,
            this.clmCollegeId,
            this.clmUnit,
            this.clmYear,
            this.clmTerm,
            this.clmCapacity,
            this.clmTaken,
            this.clmDay,
            this.clmStartTime,
            this.clmfinishTime});
            this.dgvClassRoom.Location = new System.Drawing.Point(-2, 104);
            this.dgvClassRoom.Name = "dgvClassRoom";
            this.dgvClassRoom.ReadOnly = true;
            this.dgvClassRoom.Size = new System.Drawing.Size(1448, 321);
            this.dgvClassRoom.TabIndex = 10;
            // 
            // clmClassRoomId
            // 
            this.clmClassRoomId.HeaderText = "کد کلاس";
            this.clmClassRoomId.Name = "clmClassRoomId";
            this.clmClassRoomId.ReadOnly = true;
            // 
            // clmTeacherUserName
            // 
            this.clmTeacherUserName.HeaderText = "کد پرسنلی استاد";
            this.clmTeacherUserName.Name = "clmTeacherUserName";
            this.clmTeacherUserName.ReadOnly = true;
            // 
            // clmTeacherName
            // 
            this.clmTeacherName.HeaderText = "نام استاد";
            this.clmTeacherName.Name = "clmTeacherName";
            this.clmTeacherName.ReadOnly = true;
            // 
            // clmLessonId
            // 
            this.clmLessonId.HeaderText = "کد درس";
            this.clmLessonId.Name = "clmLessonId";
            this.clmLessonId.ReadOnly = true;
            // 
            // clmLessonName
            // 
            this.clmLessonName.HeaderText = "نام درس";
            this.clmLessonName.Name = "clmLessonName";
            this.clmLessonName.ReadOnly = true;
            // 
            // clmCollegeName
            // 
            this.clmCollegeName.HeaderText = "نام دانشکده";
            this.clmCollegeName.Name = "clmCollegeName";
            this.clmCollegeName.ReadOnly = true;
            // 
            // clmCollegeId
            // 
            this.clmCollegeId.HeaderText = "کد دانشکده";
            this.clmCollegeId.Name = "clmCollegeId";
            this.clmCollegeId.ReadOnly = true;
            // 
            // clmUnit
            // 
            this.clmUnit.HeaderText = "واحد";
            this.clmUnit.Name = "clmUnit";
            this.clmUnit.ReadOnly = true;
            // 
            // clmYear
            // 
            this.clmYear.HeaderText = "سال";
            this.clmYear.Name = "clmYear";
            this.clmYear.ReadOnly = true;
            // 
            // clmTerm
            // 
            this.clmTerm.HeaderText = "ترم";
            this.clmTerm.Name = "clmTerm";
            this.clmTerm.ReadOnly = true;
            // 
            // clmCapacity
            // 
            this.clmCapacity.HeaderText = "ظرفیت";
            this.clmCapacity.Name = "clmCapacity";
            this.clmCapacity.ReadOnly = true;
            // 
            // clmTaken
            // 
            this.clmTaken.HeaderText = "ظرفیت پر شده";
            this.clmTaken.Name = "clmTaken";
            this.clmTaken.ReadOnly = true;
            // 
            // clmDay
            // 
            this.clmDay.HeaderText = "روز";
            this.clmDay.Name = "clmDay";
            this.clmDay.ReadOnly = true;
            // 
            // clmStartTime
            // 
            this.clmStartTime.HeaderText = "ساعت شروع کلاس";
            this.clmStartTime.Name = "clmStartTime";
            this.clmStartTime.ReadOnly = true;
            // 
            // clmfinishTime
            // 
            this.clmfinishTime.HeaderText = "ساعت پایان کلاس";
            this.clmfinishTime.Name = "clmfinishTime";
            this.clmfinishTime.ReadOnly = true;
            // 
            // lblClass
            // 
            this.lblClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(690, 40);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(63, 32);
            this.lblClass.TabIndex = 9;
            this.lblClass.Text = "کلاس";
            // 
            // pnlYearTerm
            // 
            this.pnlYearTerm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlYearTerm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlYearTerm.Controls.Add(this.lblYear);
            this.pnlYearTerm.Controls.Add(this.lblTerm);
            this.pnlYearTerm.Location = new System.Drawing.Point(1180, 9);
            this.pnlYearTerm.Name = "pnlYearTerm";
            this.pnlYearTerm.Size = new System.Drawing.Size(269, 81);
            this.pnlYearTerm.TabIndex = 51;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(157, 29);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(53, 23);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "سال  : ";
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerm.Location = new System.Drawing.Point(47, 29);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(46, 23);
            this.lblTerm.TabIndex = 3;
            this.lblTerm.Text = "ترم  : ";
            // 
            // btnScores
            // 
            this.btnScores.Enabled = false;
            this.btnScores.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScores.Location = new System.Drawing.Point(12, 529);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(157, 55);
            this.btnScores.TabIndex = 52;
            this.btnScores.Text = "نمرات";
            this.btnScores.UseVisualStyleBackColor = true;
            this.btnScores.Visible = false;
            this.btnScores.Click += new System.EventHandler(this.btnScores_Click);
            // 
            // btnPresenceAbsenceList
            // 
            this.btnPresenceAbsenceList.Enabled = false;
            this.btnPresenceAbsenceList.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresenceAbsenceList.Location = new System.Drawing.Point(175, 529);
            this.btnPresenceAbsenceList.Name = "btnPresenceAbsenceList";
            this.btnPresenceAbsenceList.Size = new System.Drawing.Size(241, 55);
            this.btnPresenceAbsenceList.TabIndex = 53;
            this.btnPresenceAbsenceList.Text = "ثبت حضور غیاب";
            this.btnPresenceAbsenceList.UseVisualStyleBackColor = true;
            this.btnPresenceAbsenceList.Visible = false;
            this.btnPresenceAbsenceList.Click += new System.EventHandler(this.btnPresenceAbsenceList_Click);
            // 
            // btnPresenceAbsenceReport
            // 
            this.btnPresenceAbsenceReport.Enabled = false;
            this.btnPresenceAbsenceReport.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresenceAbsenceReport.Location = new System.Drawing.Point(422, 529);
            this.btnPresenceAbsenceReport.Name = "btnPresenceAbsenceReport";
            this.btnPresenceAbsenceReport.Size = new System.Drawing.Size(241, 55);
            this.btnPresenceAbsenceReport.TabIndex = 54;
            this.btnPresenceAbsenceReport.Text = "گزارش حضور غیاب";
            this.btnPresenceAbsenceReport.UseVisualStyleBackColor = true;
            this.btnPresenceAbsenceReport.Visible = false;
            this.btnPresenceAbsenceReport.Click += new System.EventHandler(this.btnPresenceAbsenceReport_Click);
            // 
            // frmClassRoomManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 622);
            this.Controls.Add(this.btnPresenceAbsenceReport);
            this.Controls.Add(this.btnPresenceAbsenceList);
            this.Controls.Add(this.btnScores);
            this.Controls.Add(this.pnlYearTerm);
            this.Controls.Add(this.pnlClass);
            this.Name = "frmClassRoomManagement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frmClassRoomManagement_Load);
            this.pnlClass.ResumeLayout(false);
            this.pnlClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassRoom)).EndInit();
            this.pnlYearTerm.ResumeLayout(false);
            this.pnlYearTerm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Panel pnlYearTerm;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Button btnScores;
        private System.Windows.Forms.Button btnPresenceAbsenceList;
        private System.Windows.Forms.Button btnPresenceAbsenceReport;
        private System.Windows.Forms.DataGridView dgvClassRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClassRoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTeacherUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLessonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLessonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCollegeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCollegeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTaken;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfinishTime;
    }
}