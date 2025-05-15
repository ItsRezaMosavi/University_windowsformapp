namespace University
{
    partial class frmSelectClassRoom
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
            this.pnlClass = new System.Windows.Forms.Panel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblClass = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.txtTeacherLastName = new System.Windows.Forms.TextBox();
            this.lblTeacherLastName = new System.Windows.Forms.Label();
            this.btnDeleteFilter = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtTeacherFirstName = new System.Windows.Forms.TextBox();
            this.lblTeacherFirstName = new System.Windows.Forms.Label();
            this.txtTeacherUserName = new System.Windows.Forms.TextBox();
            this.lblTeacherUserName = new System.Windows.Forms.Label();
            this.cmbCollegeName = new System.Windows.Forms.ComboBox();
            this.lblCollegeName = new System.Windows.Forms.Label();
            this.txtCollegeId = new System.Windows.Forms.TextBox();
            this.lblCollegeId = new System.Windows.Forms.Label();
            this.txtLessonId = new System.Windows.Forms.TextBox();
            this.lblLessonId = new System.Windows.Forms.Label();
            this.txtLessonName = new System.Windows.Forms.TextBox();
            this.lblLessonName = new System.Windows.Forms.Label();
            this.txtClassId = new System.Windows.Forms.TextBox();
            this.lblClassId = new System.Windows.Forms.Label();
            this.dgvClassRoom = new System.Windows.Forms.DataGridView();
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
            this.pnlClass.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(544, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(233, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "انتخاب درس";
            // 
            // pnlClass
            // 
            this.pnlClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlClass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlClass.Controls.Add(this.dgvClassRoom);
            this.pnlClass.Controls.Add(this.btnSelect);
            this.pnlClass.Controls.Add(this.lblClass);
            this.pnlClass.Location = new System.Drawing.Point(1, 456);
            this.pnlClass.Name = "pnlClass";
            this.pnlClass.Size = new System.Drawing.Size(1246, 417);
            this.pnlClass.TabIndex = 52;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(9, 36);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(129, 37);
            this.btnSelect.TabIndex = 34;
            this.btnSelect.Text = "انتخاب کلاس";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblClass
            // 
            this.lblClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(613, 36);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(90, 32);
            this.lblClass.TabIndex = 9;
            this.lblClass.Text = "کلاس ها";
            // 
            // pnlFilter
            // 
            this.pnlFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFilter.Controls.Add(this.txtTeacherLastName);
            this.pnlFilter.Controls.Add(this.lblTeacherLastName);
            this.pnlFilter.Controls.Add(this.btnDeleteFilter);
            this.pnlFilter.Controls.Add(this.btnFilter);
            this.pnlFilter.Controls.Add(this.txtTeacherFirstName);
            this.pnlFilter.Controls.Add(this.lblTeacherFirstName);
            this.pnlFilter.Controls.Add(this.txtTeacherUserName);
            this.pnlFilter.Controls.Add(this.lblTeacherUserName);
            this.pnlFilter.Controls.Add(this.cmbCollegeName);
            this.pnlFilter.Controls.Add(this.lblCollegeName);
            this.pnlFilter.Controls.Add(this.txtCollegeId);
            this.pnlFilter.Controls.Add(this.lblCollegeId);
            this.pnlFilter.Controls.Add(this.txtLessonId);
            this.pnlFilter.Controls.Add(this.lblLessonId);
            this.pnlFilter.Controls.Add(this.txtLessonName);
            this.pnlFilter.Controls.Add(this.lblLessonName);
            this.pnlFilter.Controls.Add(this.txtClassId);
            this.pnlFilter.Controls.Add(this.lblClassId);
            this.pnlFilter.Location = new System.Drawing.Point(1, 121);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1236, 329);
            this.pnlFilter.TabIndex = 53;
            this.pnlFilter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFilter_Paint);
            // 
            // txtTeacherLastName
            // 
            this.txtTeacherLastName.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherLastName.Location = new System.Drawing.Point(67, 156);
            this.txtTeacherLastName.Name = "txtTeacherLastName";
            this.txtTeacherLastName.Size = new System.Drawing.Size(213, 39);
            this.txtTeacherLastName.TabIndex = 36;
            // 
            // lblTeacherLastName
            // 
            this.lblTeacherLastName.AutoSize = true;
            this.lblTeacherLastName.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherLastName.Location = new System.Drawing.Point(286, 159);
            this.lblTeacherLastName.Name = "lblTeacherLastName";
            this.lblTeacherLastName.Size = new System.Drawing.Size(102, 32);
            this.lblTeacherLastName.TabIndex = 35;
            this.lblTeacherLastName.Text = "نام استاد :";
            // 
            // btnDeleteFilter
            // 
            this.btnDeleteFilter.Location = new System.Drawing.Point(3, 246);
            this.btnDeleteFilter.Name = "btnDeleteFilter";
            this.btnDeleteFilter.Size = new System.Drawing.Size(185, 76);
            this.btnDeleteFilter.TabIndex = 34;
            this.btnDeleteFilter.Text = "حذف فیلتر";
            this.btnDeleteFilter.UseVisualStyleBackColor = true;
            this.btnDeleteFilter.Click += new System.EventHandler(this.btnDeleteFilter_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(197, 246);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(185, 76);
            this.btnFilter.TabIndex = 33;
            this.btnFilter.Text = "فیلتر";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtTeacherFirstName
            // 
            this.txtTeacherFirstName.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherFirstName.Location = new System.Drawing.Point(67, 92);
            this.txtTeacherFirstName.Name = "txtTeacherFirstName";
            this.txtTeacherFirstName.Size = new System.Drawing.Size(213, 39);
            this.txtTeacherFirstName.TabIndex = 32;
            // 
            // lblTeacherFirstName
            // 
            this.lblTeacherFirstName.AutoSize = true;
            this.lblTeacherFirstName.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherFirstName.Location = new System.Drawing.Point(286, 95);
            this.lblTeacherFirstName.Name = "lblTeacherFirstName";
            this.lblTeacherFirstName.Size = new System.Drawing.Size(102, 32);
            this.lblTeacherFirstName.TabIndex = 31;
            this.lblTeacherFirstName.Text = "نام استاد :";
            // 
            // txtTeacherUserName
            // 
            this.txtTeacherUserName.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherUserName.Location = new System.Drawing.Point(67, 31);
            this.txtTeacherUserName.Name = "txtTeacherUserName";
            this.txtTeacherUserName.Size = new System.Drawing.Size(213, 39);
            this.txtTeacherUserName.TabIndex = 30;
            // 
            // lblTeacherUserName
            // 
            this.lblTeacherUserName.AutoSize = true;
            this.lblTeacherUserName.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherUserName.Location = new System.Drawing.Point(286, 34);
            this.lblTeacherUserName.Name = "lblTeacherUserName";
            this.lblTeacherUserName.Size = new System.Drawing.Size(172, 32);
            this.lblTeacherUserName.TabIndex = 29;
            this.lblTeacherUserName.Text = "کد پرسنلی استاد :";
            // 
            // cmbCollegeName
            // 
            this.cmbCollegeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCollegeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCollegeName.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCollegeName.FormattingEnabled = true;
            this.cmbCollegeName.Location = new System.Drawing.Point(894, 263);
            this.cmbCollegeName.Name = "cmbCollegeName";
            this.cmbCollegeName.Size = new System.Drawing.Size(196, 40);
            this.cmbCollegeName.TabIndex = 28;
            // 
            // lblCollegeName
            // 
            this.lblCollegeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCollegeName.AutoSize = true;
            this.lblCollegeName.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollegeName.Location = new System.Drawing.Point(1096, 263);
            this.lblCollegeName.Name = "lblCollegeName";
            this.lblCollegeName.Size = new System.Drawing.Size(124, 32);
            this.lblCollegeName.TabIndex = 8;
            this.lblCollegeName.Text = "نام دانشکده :";
            // 
            // txtCollegeId
            // 
            this.txtCollegeId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCollegeId.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCollegeId.Location = new System.Drawing.Point(894, 204);
            this.txtCollegeId.Name = "txtCollegeId";
            this.txtCollegeId.Size = new System.Drawing.Size(196, 39);
            this.txtCollegeId.TabIndex = 7;
            // 
            // lblCollegeId
            // 
            this.lblCollegeId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCollegeId.AutoSize = true;
            this.lblCollegeId.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollegeId.Location = new System.Drawing.Point(1096, 207);
            this.lblCollegeId.Name = "lblCollegeId";
            this.lblCollegeId.Size = new System.Drawing.Size(122, 32);
            this.lblCollegeId.TabIndex = 6;
            this.lblCollegeId.Text = "کد دانشکده :";
            // 
            // txtLessonId
            // 
            this.txtLessonId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLessonId.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLessonId.Location = new System.Drawing.Point(894, 84);
            this.txtLessonId.Name = "txtLessonId";
            this.txtLessonId.Size = new System.Drawing.Size(213, 39);
            this.txtLessonId.TabIndex = 5;
            // 
            // lblLessonId
            // 
            this.lblLessonId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLessonId.AutoSize = true;
            this.lblLessonId.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLessonId.Location = new System.Drawing.Point(1118, 87);
            this.lblLessonId.Name = "lblLessonId";
            this.lblLessonId.Size = new System.Drawing.Size(100, 32);
            this.lblLessonId.TabIndex = 4;
            this.lblLessonId.Text = "کد درس :";
            // 
            // txtLessonName
            // 
            this.txtLessonName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLessonName.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLessonName.Location = new System.Drawing.Point(894, 145);
            this.txtLessonName.Name = "txtLessonName";
            this.txtLessonName.Size = new System.Drawing.Size(213, 39);
            this.txtLessonName.TabIndex = 3;
            // 
            // lblLessonName
            // 
            this.lblLessonName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLessonName.AutoSize = true;
            this.lblLessonName.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLessonName.Location = new System.Drawing.Point(1116, 152);
            this.lblLessonName.Name = "lblLessonName";
            this.lblLessonName.Size = new System.Drawing.Size(102, 32);
            this.lblLessonName.TabIndex = 2;
            this.lblLessonName.Text = "نام درس :";
            // 
            // txtClassId
            // 
            this.txtClassId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClassId.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassId.Location = new System.Drawing.Point(894, 27);
            this.txtClassId.Name = "txtClassId";
            this.txtClassId.Size = new System.Drawing.Size(213, 39);
            this.txtClassId.TabIndex = 1;
            // 
            // lblClassId
            // 
            this.lblClassId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClassId.AutoSize = true;
            this.lblClassId.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassId.Location = new System.Drawing.Point(1113, 27);
            this.lblClassId.Name = "lblClassId";
            this.lblClassId.Size = new System.Drawing.Size(105, 32);
            this.lblClassId.TabIndex = 0;
            this.lblClassId.Text = "کد کلاس :";
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
            this.clmfinishTime});
            this.dgvClassRoom.Location = new System.Drawing.Point(-216, 101);
            this.dgvClassRoom.Name = "dgvClassRoom";
            this.dgvClassRoom.ReadOnly = true;
            this.dgvClassRoom.Size = new System.Drawing.Size(1460, 309);
            this.dgvClassRoom.TabIndex = 35;
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
            // frmSelectClassRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 872);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlClass);
            this.Controls.Add(this.lblTitle);
            this.MinimumSize = new System.Drawing.Size(859, 911);
            this.Name = "frmSelectClassRoom";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.Load += new System.EventHandler(this.frmSelectClassRoom_Load);
            this.pnlClass.ResumeLayout(false);
            this.pnlClass.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblClassId;
        private System.Windows.Forms.TextBox txtClassId;
        private System.Windows.Forms.Label lblCollegeName;
        private System.Windows.Forms.TextBox txtCollegeId;
        private System.Windows.Forms.Label lblCollegeId;
        private System.Windows.Forms.TextBox txtLessonId;
        private System.Windows.Forms.Label lblLessonId;
        private System.Windows.Forms.TextBox txtLessonName;
        private System.Windows.Forms.Label lblLessonName;
        private System.Windows.Forms.ComboBox cmbCollegeName;
        private System.Windows.Forms.TextBox txtTeacherUserName;
        private System.Windows.Forms.Label lblTeacherUserName;
        private System.Windows.Forms.TextBox txtTeacherFirstName;
        private System.Windows.Forms.Label lblTeacherFirstName;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnDeleteFilter;
        private System.Windows.Forms.TextBox txtTeacherLastName;
        private System.Windows.Forms.Label lblTeacherLastName;
        private System.Windows.Forms.Button btnSelect;
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
    }
}