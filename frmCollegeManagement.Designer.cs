namespace University
{
    partial class frmCollegeManagement
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
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.clmFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEducational_Field = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCollege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTeachers = new System.Windows.Forms.Panel();
            this.lblTeachers = new System.Windows.Forms.Label();
            this.btnAddLesson = new System.Windows.Forms.Button();
            this.btnTeacherManagement = new System.Windows.Forms.Button();
            this.dgvLesson = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLesson = new System.Windows.Forms.Label();
            this.pnlLesson = new System.Windows.Forms.Panel();
            this.btnDeleteLesson = new System.Windows.Forms.Button();
            this.btnEditLesson = new System.Windows.Forms.Button();
            this.pnlClass = new System.Windows.Forms.Panel();
            this.dgvClassRoom = new System.Windows.Forms.DataGridView();
            this.clmClassRoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTeacherUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLessonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLessonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCollegeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCollegeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfinishTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblClass = new System.Windows.Forms.Label();
            this.btnEditClassRoom = new System.Windows.Forms.Button();
            this.btnDeleteClassRoom = new System.Windows.Forms.Button();
            this.btnAddClassRoom = new System.Windows.Forms.Button();
            this.pnlStatistic = new System.Windows.Forms.Panel();
            this.lblClassRoomCount = new System.Windows.Forms.Label();
            this.lblStudentsCount = new System.Windows.Forms.Label();
            this.lblTeachersCount = new System.Windows.Forms.Label();
            this.lblStatistics = new System.Windows.Forms.Label();
            this.btnStudentManagement = new System.Windows.Forms.Button();
            this.btnRegisterScore = new System.Windows.Forms.Button();
            this.btnStudentClassRoomMapping = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.pnlTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesson)).BeginInit();
            this.pnlLesson.SuspendLayout();
            this.pnlClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassRoom)).BeginInit();
            this.pnlStatistic.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.AllowUserToAddRows = false;
            this.dgvTeachers.AllowUserToDeleteRows = false;
            this.dgvTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFirstName,
            this.clmLastName,
            this.clmNationalCode,
            this.clmGender,
            this.clmEducational_Field,
            this.clmCollege});
            this.dgvTeachers.Location = new System.Drawing.Point(-2, 98);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.ReadOnly = true;
            this.dgvTeachers.Size = new System.Drawing.Size(631, 338);
            this.dgvTeachers.TabIndex = 0;
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
            // clmNationalCode
            // 
            this.clmNationalCode.HeaderText = "کد ملی";
            this.clmNationalCode.Name = "clmNationalCode";
            this.clmNationalCode.ReadOnly = true;
            // 
            // clmGender
            // 
            this.clmGender.HeaderText = "جنسیت";
            this.clmGender.Name = "clmGender";
            this.clmGender.ReadOnly = true;
            // 
            // clmEducational_Field
            // 
            this.clmEducational_Field.HeaderText = "رشته";
            this.clmEducational_Field.Name = "clmEducational_Field";
            this.clmEducational_Field.ReadOnly = true;
            // 
            // clmCollege
            // 
            this.clmCollege.HeaderText = "دانشکده";
            this.clmCollege.Name = "clmCollege";
            this.clmCollege.ReadOnly = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(567, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(217, 41);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "مدیریت دانشکده ";
            // 
            // pnlTeachers
            // 
            this.pnlTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTeachers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTeachers.Controls.Add(this.lblTeachers);
            this.pnlTeachers.Controls.Add(this.dgvTeachers);
            this.pnlTeachers.Location = new System.Drawing.Point(868, 472);
            this.pnlTeachers.Name = "pnlTeachers";
            this.pnlTeachers.Size = new System.Drawing.Size(633, 440);
            this.pnlTeachers.TabIndex = 2;
            // 
            // lblTeachers
            // 
            this.lblTeachers.AutoSize = true;
            this.lblTeachers.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeachers.Location = new System.Drawing.Point(265, 34);
            this.lblTeachers.Name = "lblTeachers";
            this.lblTeachers.Size = new System.Drawing.Size(144, 32);
            this.lblTeachers.TabIndex = 1;
            this.lblTeachers.Text = "اساتید دانشکده";
            // 
            // btnAddLesson
            // 
            this.btnAddLesson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddLesson.Enabled = false;
            this.btnAddLesson.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLesson.Location = new System.Drawing.Point(974, 195);
            this.btnAddLesson.Name = "btnAddLesson";
            this.btnAddLesson.Size = new System.Drawing.Size(194, 56);
            this.btnAddLesson.TabIndex = 4;
            this.btnAddLesson.Text = "افزودن درس";
            this.btnAddLesson.UseVisualStyleBackColor = true;
            this.btnAddLesson.Visible = false;
            this.btnAddLesson.Click += new System.EventHandler(this.btnAddLesson_Click);
            // 
            // btnTeacherManagement
            // 
            this.btnTeacherManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTeacherManagement.Enabled = false;
            this.btnTeacherManagement.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherManagement.Location = new System.Drawing.Point(974, 410);
            this.btnTeacherManagement.Name = "btnTeacherManagement";
            this.btnTeacherManagement.Size = new System.Drawing.Size(194, 56);
            this.btnTeacherManagement.TabIndex = 5;
            this.btnTeacherManagement.Text = "مدیریت اساتید";
            this.btnTeacherManagement.UseVisualStyleBackColor = true;
            this.btnTeacherManagement.Visible = false;
            this.btnTeacherManagement.Click += new System.EventHandler(this.btnTeacherManagement_Click);
            // 
            // dgvLesson
            // 
            this.dgvLesson.AllowUserToAddRows = false;
            this.dgvLesson.AllowUserToDeleteRows = false;
            this.dgvLesson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLesson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLesson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmName});
            this.dgvLesson.Location = new System.Drawing.Point(-2, 112);
            this.dgvLesson.Name = "dgvLesson";
            this.dgvLesson.ReadOnly = true;
            this.dgvLesson.Size = new System.Drawing.Size(299, 338);
            this.dgvLesson.TabIndex = 0;
            // 
            // clmId
            // 
            this.clmId.HeaderText = "کد درس";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "نام درس";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            // 
            // lblLesson
            // 
            this.lblLesson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLesson.AutoSize = true;
            this.lblLesson.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLesson.Location = new System.Drawing.Point(116, 27);
            this.lblLesson.Name = "lblLesson";
            this.lblLesson.Size = new System.Drawing.Size(71, 32);
            this.lblLesson.TabIndex = 1;
            this.lblLesson.Text = "دروس";
            // 
            // pnlLesson
            // 
            this.pnlLesson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLesson.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLesson.Controls.Add(this.lblLesson);
            this.pnlLesson.Controls.Add(this.dgvLesson);
            this.pnlLesson.Location = new System.Drawing.Point(1189, 12);
            this.pnlLesson.Name = "pnlLesson";
            this.pnlLesson.Size = new System.Drawing.Size(299, 454);
            this.pnlLesson.TabIndex = 3;
            // 
            // btnDeleteLesson
            // 
            this.btnDeleteLesson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteLesson.BackColor = System.Drawing.Color.Red;
            this.btnDeleteLesson.Enabled = false;
            this.btnDeleteLesson.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLesson.ForeColor = System.Drawing.Color.White;
            this.btnDeleteLesson.Location = new System.Drawing.Point(974, 257);
            this.btnDeleteLesson.Name = "btnDeleteLesson";
            this.btnDeleteLesson.Size = new System.Drawing.Size(194, 56);
            this.btnDeleteLesson.TabIndex = 6;
            this.btnDeleteLesson.Text = "حذف درس";
            this.btnDeleteLesson.UseVisualStyleBackColor = false;
            this.btnDeleteLesson.Visible = false;
            this.btnDeleteLesson.Click += new System.EventHandler(this.btnDeleteLesson_Click);
            // 
            // btnEditLesson
            // 
            this.btnEditLesson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditLesson.Enabled = false;
            this.btnEditLesson.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditLesson.Location = new System.Drawing.Point(974, 321);
            this.btnEditLesson.Name = "btnEditLesson";
            this.btnEditLesson.Size = new System.Drawing.Size(194, 56);
            this.btnEditLesson.TabIndex = 7;
            this.btnEditLesson.Text = "ویرایش درس";
            this.btnEditLesson.UseVisualStyleBackColor = true;
            this.btnEditLesson.Visible = false;
            this.btnEditLesson.Click += new System.EventHandler(this.btnEditLesson_Click);
            // 
            // pnlClass
            // 
            this.pnlClass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlClass.Controls.Add(this.dgvClassRoom);
            this.pnlClass.Controls.Add(this.lblClass);
            this.pnlClass.Location = new System.Drawing.Point(3, 472);
            this.pnlClass.Name = "pnlClass";
            this.pnlClass.Size = new System.Drawing.Size(849, 438);
            this.pnlClass.TabIndex = 9;
            // 
            // dgvClassRoom
            // 
            this.dgvClassRoom.AllowUserToAddRows = false;
            this.dgvClassRoom.AllowUserToDeleteRows = false;
            this.dgvClassRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmClassRoomId,
            this.clmTeacherUserName,
            this.clmTeacherName,
            this.clmLessonId,
            this.clmLessonName,
            this.clmUnit,
            this.clmCollegeName,
            this.clmCollegeId,
            this.clmYear,
            this.clmTerm,
            this.clmCapacity,
            this.clmTaken,
            this.clmDay,
            this.clmStartTime,
            this.clmfinishTime});
            this.dgvClassRoom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvClassRoom.Location = new System.Drawing.Point(0, 96);
            this.dgvClassRoom.Name = "dgvClassRoom";
            this.dgvClassRoom.ReadOnly = true;
            this.dgvClassRoom.Size = new System.Drawing.Size(845, 338);
            this.dgvClassRoom.TabIndex = 11;
            this.dgvClassRoom.DoubleClick += new System.EventHandler(this.dgvClassRoom_DoubleClick);
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
            // clmUnit
            // 
            this.clmUnit.HeaderText = "واحد";
            this.clmUnit.Name = "clmUnit";
            this.clmUnit.ReadOnly = true;
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
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(404, 34);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(90, 32);
            this.lblClass.TabIndex = 9;
            this.lblClass.Text = "کلاس ها";
            // 
            // btnEditClassRoom
            // 
            this.btnEditClassRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditClassRoom.Enabled = false;
            this.btnEditClassRoom.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditClassRoom.Location = new System.Drawing.Point(412, 410);
            this.btnEditClassRoom.Name = "btnEditClassRoom";
            this.btnEditClassRoom.Size = new System.Drawing.Size(194, 56);
            this.btnEditClassRoom.TabIndex = 12;
            this.btnEditClassRoom.Text = "ویرایش کلاس";
            this.btnEditClassRoom.UseVisualStyleBackColor = true;
            this.btnEditClassRoom.Visible = false;
            this.btnEditClassRoom.Click += new System.EventHandler(this.btnEditClassRoom_Click);
            // 
            // btnDeleteClassRoom
            // 
            this.btnDeleteClassRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteClassRoom.BackColor = System.Drawing.Color.Red;
            this.btnDeleteClassRoom.Enabled = false;
            this.btnDeleteClassRoom.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClassRoom.ForeColor = System.Drawing.Color.White;
            this.btnDeleteClassRoom.Location = new System.Drawing.Point(212, 410);
            this.btnDeleteClassRoom.Name = "btnDeleteClassRoom";
            this.btnDeleteClassRoom.Size = new System.Drawing.Size(194, 56);
            this.btnDeleteClassRoom.TabIndex = 11;
            this.btnDeleteClassRoom.Text = "حذف کلاس";
            this.btnDeleteClassRoom.UseVisualStyleBackColor = false;
            this.btnDeleteClassRoom.Visible = false;
            this.btnDeleteClassRoom.Click += new System.EventHandler(this.btnDeleteClassRoom_Click);
            // 
            // btnAddClassRoom
            // 
            this.btnAddClassRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddClassRoom.Enabled = false;
            this.btnAddClassRoom.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClassRoom.Location = new System.Drawing.Point(12, 410);
            this.btnAddClassRoom.Name = "btnAddClassRoom";
            this.btnAddClassRoom.Size = new System.Drawing.Size(194, 56);
            this.btnAddClassRoom.TabIndex = 10;
            this.btnAddClassRoom.Text = "افزودن کلاس";
            this.btnAddClassRoom.UseVisualStyleBackColor = true;
            this.btnAddClassRoom.Visible = false;
            this.btnAddClassRoom.Click += new System.EventHandler(this.btnAddClassRoom_Click);
            // 
            // pnlStatistic
            // 
            this.pnlStatistic.BackColor = System.Drawing.Color.Lavender;
            this.pnlStatistic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlStatistic.Controls.Add(this.lblClassRoomCount);
            this.pnlStatistic.Controls.Add(this.lblStudentsCount);
            this.pnlStatistic.Controls.Add(this.lblTeachersCount);
            this.pnlStatistic.Controls.Add(this.lblStatistics);
            this.pnlStatistic.Location = new System.Drawing.Point(521, 95);
            this.pnlStatistic.Name = "pnlStatistic";
            this.pnlStatistic.Size = new System.Drawing.Size(436, 294);
            this.pnlStatistic.TabIndex = 13;
            this.pnlStatistic.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStatistic_Paint);
            // 
            // lblClassRoomCount
            // 
            this.lblClassRoomCount.AutoSize = true;
            this.lblClassRoomCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblClassRoomCount.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassRoomCount.Location = new System.Drawing.Point(225, 221);
            this.lblClassRoomCount.Name = "lblClassRoomCount";
            this.lblClassRoomCount.Size = new System.Drawing.Size(159, 34);
            this.lblClassRoomCount.TabIndex = 3;
            this.lblClassRoomCount.Text = "تعداد کلاس ها :";
            // 
            // lblStudentsCount
            // 
            this.lblStudentsCount.AutoSize = true;
            this.lblStudentsCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStudentsCount.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentsCount.Location = new System.Drawing.Point(209, 149);
            this.lblStudentsCount.Name = "lblStudentsCount";
            this.lblStudentsCount.Size = new System.Drawing.Size(175, 34);
            this.lblStudentsCount.TabIndex = 2;
            this.lblStudentsCount.Text = "تعداد دانشجویان :";
            // 
            // lblTeachersCount
            // 
            this.lblTeachersCount.AutoSize = true;
            this.lblTeachersCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTeachersCount.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeachersCount.Location = new System.Drawing.Point(250, 76);
            this.lblTeachersCount.Name = "lblTeachersCount";
            this.lblTeachersCount.Size = new System.Drawing.Size(134, 34);
            this.lblTeachersCount.TabIndex = 1;
            this.lblTeachersCount.Text = "تعداد اساتید :";
            // 
            // lblStatistics
            // 
            this.lblStatistics.AutoSize = true;
            this.lblStatistics.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistics.Location = new System.Drawing.Point(201, 17);
            this.lblStatistics.Name = "lblStatistics";
            this.lblStatistics.Size = new System.Drawing.Size(60, 37);
            this.lblStatistics.TabIndex = 0;
            this.lblStatistics.Text = "آمار";
            // 
            // btnStudentManagement
            // 
            this.btnStudentManagement.BackColor = System.Drawing.Color.Orange;
            this.btnStudentManagement.Enabled = false;
            this.btnStudentManagement.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentManagement.Location = new System.Drawing.Point(636, 410);
            this.btnStudentManagement.Name = "btnStudentManagement";
            this.btnStudentManagement.Size = new System.Drawing.Size(216, 56);
            this.btnStudentManagement.TabIndex = 14;
            this.btnStudentManagement.Text = "مدیریت دانشجویان";
            this.btnStudentManagement.UseVisualStyleBackColor = false;
            this.btnStudentManagement.Visible = false;
            this.btnStudentManagement.Click += new System.EventHandler(this.btnStudentManagement_Click);
            // 
            // btnRegisterScore
            // 
            this.btnRegisterScore.Enabled = false;
            this.btnRegisterScore.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterScore.Location = new System.Drawing.Point(12, 348);
            this.btnRegisterScore.Name = "btnRegisterScore";
            this.btnRegisterScore.Size = new System.Drawing.Size(194, 56);
            this.btnRegisterScore.TabIndex = 15;
            this.btnRegisterScore.Text = "ثبت نمره";
            this.btnRegisterScore.UseVisualStyleBackColor = true;
            this.btnRegisterScore.Visible = false;
            this.btnRegisterScore.Click += new System.EventHandler(this.btnRegisterScore_Click);
            // 
            // btnStudentClassRoomMapping
            // 
            this.btnStudentClassRoomMapping.Enabled = false;
            this.btnStudentClassRoomMapping.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentClassRoomMapping.Location = new System.Drawing.Point(212, 263);
            this.btnStudentClassRoomMapping.Name = "btnStudentClassRoomMapping";
            this.btnStudentClassRoomMapping.Size = new System.Drawing.Size(194, 141);
            this.btnStudentClassRoomMapping.TabIndex = 16;
            this.btnStudentClassRoomMapping.Text = "افزودن دانشجو به کلاس";
            this.btnStudentClassRoomMapping.UseVisualStyleBackColor = true;
            this.btnStudentClassRoomMapping.Visible = false;
            this.btnStudentClassRoomMapping.Click += new System.EventHandler(this.btnStudentClassRoomMapping_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(148, 69);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "تازه سازی";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmCollegeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 910);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnStudentClassRoomMapping);
            this.Controls.Add(this.btnRegisterScore);
            this.Controls.Add(this.btnStudentManagement);
            this.Controls.Add(this.pnlStatistic);
            this.Controls.Add(this.btnEditClassRoom);
            this.Controls.Add(this.btnDeleteClassRoom);
            this.Controls.Add(this.btnAddClassRoom);
            this.Controls.Add(this.pnlClass);
            this.Controls.Add(this.btnEditLesson);
            this.Controls.Add(this.btnDeleteLesson);
            this.Controls.Add(this.btnTeacherManagement);
            this.Controls.Add(this.btnAddLesson);
            this.Controls.Add(this.pnlLesson);
            this.Controls.Add(this.pnlTeachers);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmCollegeManagement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frmCollegeTeacherManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            this.pnlTeachers.ResumeLayout(false);
            this.pnlTeachers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesson)).EndInit();
            this.pnlLesson.ResumeLayout(false);
            this.pnlLesson.PerformLayout();
            this.pnlClass.ResumeLayout(false);
            this.pnlClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassRoom)).EndInit();
            this.pnlStatistic.ResumeLayout(false);
            this.pnlStatistic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTeachers;
        private System.Windows.Forms.Label lblTeachers;
        private System.Windows.Forms.Button btnAddLesson;
        private System.Windows.Forms.Button btnTeacherManagement;
        private System.Windows.Forms.DataGridView dgvLesson;
        private System.Windows.Forms.Label lblLesson;
        private System.Windows.Forms.Panel pnlLesson;
        private System.Windows.Forms.Button btnDeleteLesson;
        private System.Windows.Forms.Button btnEditLesson;
        private System.Windows.Forms.Panel pnlClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Button btnEditClassRoom;
        private System.Windows.Forms.Button btnDeleteClassRoom;
        private System.Windows.Forms.Button btnAddClassRoom;
        private System.Windows.Forms.Panel pnlStatistic;
        private System.Windows.Forms.Label lblStudentsCount;
        private System.Windows.Forms.Label lblTeachersCount;
        private System.Windows.Forms.Label lblStatistics;
        private System.Windows.Forms.Button btnStudentManagement;
        private System.Windows.Forms.Button btnRegisterScore;
        private System.Windows.Forms.Button btnStudentClassRoomMapping;
        private System.Windows.Forms.DataGridView dgvClassRoom;
        private System.Windows.Forms.Label lblClassRoomCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClassRoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTeacherUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLessonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLessonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCollegeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCollegeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTaken;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfinishTime;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEducational_Field;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCollege;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
    }
}