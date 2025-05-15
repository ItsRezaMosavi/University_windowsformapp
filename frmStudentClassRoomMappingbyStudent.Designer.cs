namespace University
{
    partial class frmStudentClassRoomMappingbyStudent
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
            this.lblYear = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlYearTerm = new System.Windows.Forms.Panel();
            this.pnlClass = new System.Windows.Forms.Panel();
            this.btnPermanentSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblClass = new System.Windows.Forms.Label();
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
            this.clmDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfinishTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlYearTerm.SuspendLayout();
            this.pnlClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(169, 29);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(45, 23);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "سال :";
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerm.Location = new System.Drawing.Point(90, 29);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(38, 23);
            this.lblTerm.TabIndex = 3;
            this.lblTerm.Text = "ترم :";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(422, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(383, 45);
            this.lblTitle.TabIndex = 49;
            this.lblTitle.Text = "انتخاب واحد توسط دانشجو";
            // 
            // pnlYearTerm
            // 
            this.pnlYearTerm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlYearTerm.Controls.Add(this.lblYear);
            this.pnlYearTerm.Controls.Add(this.lblTerm);
            this.pnlYearTerm.Location = new System.Drawing.Point(887, 88);
            this.pnlYearTerm.Name = "pnlYearTerm";
            this.pnlYearTerm.Size = new System.Drawing.Size(313, 81);
            this.pnlYearTerm.TabIndex = 50;
            // 
            // pnlClass
            // 
            this.pnlClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlClass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlClass.Controls.Add(this.btnPermanentSave);
            this.pnlClass.Controls.Add(this.btnRemove);
            this.pnlClass.Controls.Add(this.btnAdd);
            this.pnlClass.Controls.Add(this.lblClass);
            this.pnlClass.Controls.Add(this.dgvClassRoom);
            this.pnlClass.Location = new System.Drawing.Point(12, 192);
            this.pnlClass.Name = "pnlClass";
            this.pnlClass.Size = new System.Drawing.Size(1193, 491);
            this.pnlClass.TabIndex = 51;
            // 
            // btnPermanentSave
            // 
            this.btnPermanentSave.Enabled = false;
            this.btnPermanentSave.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermanentSave.Location = new System.Drawing.Point(15, 414);
            this.btnPermanentSave.Name = "btnPermanentSave";
            this.btnPermanentSave.Size = new System.Drawing.Size(183, 38);
            this.btnPermanentSave.TabIndex = 52;
            this.btnPermanentSave.Text = "ذخیره نهایی انتخاب واحد";
            this.btnPermanentSave.UseVisualStyleBackColor = true;
            this.btnPermanentSave.Click += new System.EventHandler(this.btnPermanentSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(938, 405);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(121, 38);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "حذف درس";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1065, 405);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 38);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "افزودن";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblClass
            // 
            this.lblClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(577, 28);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(90, 32);
            this.lblClass.TabIndex = 9;
            this.lblClass.Text = "کلاس ها";
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
            this.clmDay,
            this.clmStartTime,
            this.clmfinishTime});
            this.dgvClassRoom.Location = new System.Drawing.Point(-2, 90);
            this.dgvClassRoom.Name = "dgvClassRoom";
            this.dgvClassRoom.ReadOnly = true;
            this.dgvClassRoom.Size = new System.Drawing.Size(1193, 309);
            this.dgvClassRoom.TabIndex = 8;
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
            // frmStudentClassRoomMappingbyStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 723);
            this.Controls.Add(this.pnlClass);
            this.Controls.Add(this.pnlYearTerm);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmStudentClassRoomMappingbyStudent";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "..و";
            this.Load += new System.EventHandler(this.frmStudentClassRoomMappingbyStudent_Load);
            this.pnlYearTerm.ResumeLayout(false);
            this.pnlYearTerm.PerformLayout();
            this.pnlClass.ResumeLayout(false);
            this.pnlClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlYearTerm;
        private System.Windows.Forms.Panel pnlClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.DataGridView dgvClassRoom;
        private System.Windows.Forms.Button btnPermanentSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfinishTime;
    }
}