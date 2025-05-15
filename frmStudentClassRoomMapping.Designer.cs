namespace University
{
    partial class frmStudentClassRoomMapping
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
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.clmPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCollege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlStudent = new System.Windows.Forms.Panel();
            this.lblStudent = new System.Windows.Forms.Label();
            this.btnAddStudentToClass = new System.Windows.Forms.Button();
            this.pnlClass = new System.Windows.Forms.Panel();
            this.dgvClassRoom = new System.Windows.Forms.DataGridView();
            this.btnSelectClassRoom = new System.Windows.Forms.Button();
            this.lblClass = new System.Windows.Forms.Label();
            this.pnlCollege = new System.Windows.Forms.Panel();
            this.cmbCollege = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.clmClassRoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTeacherUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLessonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLessonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCollegeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCollegeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfinishTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.pnlStudent.SuspendLayout();
            this.pnlClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassRoom)).BeginInit();
            this.pnlCollege.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPhoto,
            this.clmUserName,
            this.clmFName,
            this.clmLName,
            this.clmNationalCode,
            this.clmCollege,
            this.clmField});
            this.dgvStudent.Location = new System.Drawing.Point(0, 78);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.Size = new System.Drawing.Size(1247, 306);
            this.dgvStudent.TabIndex = 4;
            // 
            // clmPhoto
            // 
            this.clmPhoto.HeaderText = "عکس دانشجو";
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
            // clmFName
            // 
            this.clmFName.HeaderText = "نام";
            this.clmFName.Name = "clmFName";
            this.clmFName.ReadOnly = true;
            // 
            // clmLName
            // 
            this.clmLName.HeaderText = "نام خانوادگی";
            this.clmLName.Name = "clmLName";
            this.clmLName.ReadOnly = true;
            // 
            // clmNationalCode
            // 
            this.clmNationalCode.HeaderText = "کد ملی";
            this.clmNationalCode.Name = "clmNationalCode";
            this.clmNationalCode.ReadOnly = true;
            // 
            // clmCollege
            // 
            this.clmCollege.HeaderText = "دانشکده";
            this.clmCollege.Name = "clmCollege";
            this.clmCollege.ReadOnly = true;
            // 
            // clmField
            // 
            this.clmField.HeaderText = "رشته";
            this.clmField.Name = "clmField";
            this.clmField.ReadOnly = true;
            // 
            // pnlStudent
            // 
            this.pnlStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlStudent.Controls.Add(this.lblStudent);
            this.pnlStudent.Controls.Add(this.dgvStudent);
            this.pnlStudent.Location = new System.Drawing.Point(258, 556);
            this.pnlStudent.Name = "pnlStudent";
            this.pnlStudent.Size = new System.Drawing.Size(1249, 386);
            this.pnlStudent.TabIndex = 5;
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(579, 15);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(112, 33);
            this.lblStudent.TabIndex = 5;
            this.lblStudent.Text = "دانشجویان";
            // 
            // btnAddStudentToClass
            // 
            this.btnAddStudentToClass.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudentToClass.Location = new System.Drawing.Point(59, 604);
            this.btnAddStudentToClass.Name = "btnAddStudentToClass";
            this.btnAddStudentToClass.Size = new System.Drawing.Size(172, 167);
            this.btnAddStudentToClass.TabIndex = 6;
            this.btnAddStudentToClass.Text = "افزودن دانشجو به کلاس";
            this.btnAddStudentToClass.UseVisualStyleBackColor = true;
            this.btnAddStudentToClass.Click += new System.EventHandler(this.btnAddStudentToClass_Click);
            // 
            // pnlClass
            // 
            this.pnlClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlClass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlClass.Controls.Add(this.dgvClassRoom);
            this.pnlClass.Controls.Add(this.btnSelectClassRoom);
            this.pnlClass.Controls.Add(this.lblClass);
            this.pnlClass.Location = new System.Drawing.Point(8, 118);
            this.pnlClass.Name = "pnlClass";
            this.pnlClass.Size = new System.Drawing.Size(1499, 432);
            this.pnlClass.TabIndex = 10;
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
            this.clmYear,
            this.clmTerm,
            this.clmDay,
            this.clmStartTime,
            this.clmfinishTime,
            this.clmCapacity});
            this.dgvClassRoom.Location = new System.Drawing.Point(0, 106);
            this.dgvClassRoom.Name = "dgvClassRoom";
            this.dgvClassRoom.ReadOnly = true;
            this.dgvClassRoom.Size = new System.Drawing.Size(1498, 324);
            this.dgvClassRoom.TabIndex = 11;
            // 
            // btnSelectClassRoom
            // 
            this.btnSelectClassRoom.Location = new System.Drawing.Point(29, 38);
            this.btnSelectClassRoom.Name = "btnSelectClassRoom";
            this.btnSelectClassRoom.Size = new System.Drawing.Size(127, 54);
            this.btnSelectClassRoom.TabIndex = 10;
            this.btnSelectClassRoom.Text = "انتخاب کلاس";
            this.btnSelectClassRoom.UseVisualStyleBackColor = true;
            this.btnSelectClassRoom.Click += new System.EventHandler(this.btnSelectClassRoom_Click);
            // 
            // lblClass
            // 
            this.lblClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(601, 38);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(90, 32);
            this.lblClass.TabIndex = 9;
            this.lblClass.Text = "کلاس ها";
            // 
            // pnlCollege
            // 
            this.pnlCollege.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCollege.Controls.Add(this.cmbCollege);
            this.pnlCollege.Controls.Add(this.label1);
            this.pnlCollege.Location = new System.Drawing.Point(8, 12);
            this.pnlCollege.Name = "pnlCollege";
            this.pnlCollege.Size = new System.Drawing.Size(427, 100);
            this.pnlCollege.TabIndex = 47;
            // 
            // cmbCollege
            // 
            this.cmbCollege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCollege.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCollege.FormattingEnabled = true;
            this.cmbCollege.Location = new System.Drawing.Point(17, 27);
            this.cmbCollege.Name = "cmbCollege";
            this.cmbCollege.Size = new System.Drawing.Size(282, 47);
            this.cmbCollege.TabIndex = 25;
            this.cmbCollege.SelectedIndexChanged += new System.EventHandler(this.cmbCollege_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 39);
            this.label1.TabIndex = 26;
            this.label1.Text = "دانشکده :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(627, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(385, 45);
            this.lblTitle.TabIndex = 48;
            this.lblTitle.Text = "انتخاب واحد توسط کارمندان";
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
            // clmCapacity
            // 
            this.clmCapacity.HeaderText = "ظرفیت";
            this.clmCapacity.Name = "clmCapacity";
            this.clmCapacity.ReadOnly = true;
            // 
            // frmStudentClassRoomMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 942);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlCollege);
            this.Controls.Add(this.pnlClass);
            this.Controls.Add(this.btnAddStudentToClass);
            this.Controls.Add(this.pnlStudent);
            this.Name = "frmStudentClassRoomMapping";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStudentClassRoomMapping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.pnlStudent.ResumeLayout(false);
            this.pnlStudent.PerformLayout();
            this.pnlClass.ResumeLayout(false);
            this.pnlClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassRoom)).EndInit();
            this.pnlCollege.ResumeLayout(false);
            this.pnlCollege.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Panel pnlStudent;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Button btnAddStudentToClass;
        private System.Windows.Forms.Panel pnlClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Button btnSelectClassRoom;
        private System.Windows.Forms.Panel pnlCollege;
        private System.Windows.Forms.ComboBox cmbCollege;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewImageColumn clmPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCollege;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmField;
        private System.Windows.Forms.DataGridView dgvClassRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClassRoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTeacherUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLessonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLessonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCollegeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCollegeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfinishTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCapacity;
    }
}