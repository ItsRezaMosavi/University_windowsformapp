namespace University
{
    partial class frmWorkTime
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
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cmbCollege = new System.Windows.Forms.ComboBox();
            this.lblCollege = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.btnSelectUser = new System.Windows.Forms.Button();
            this.lblUsers = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.clmUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFathersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCollege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEducational_Field = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbStartDay = new System.Windows.Forms.ComboBox();
            this.cmbStartMonth = new System.Windows.Forms.ComboBox();
            this.cmbStartYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFinishYear = new System.Windows.Forms.ComboBox();
            this.cmbFinishMonth = new System.Windows.Forms.ComboBox();
            this.cmbFinishDay = new System.Windows.Forms.ComboBox();
            this.btnSelectDate = new System.Windows.Forms.Button();
            this.txtWorkHour = new System.Windows.Forms.TextBox();
            this.txtWorkMinute = new System.Windows.Forms.TextBox();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnThisMonth = new System.Windows.Forms.Button();
            this.pnlFilter.SuspendLayout();
            this.pnlUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFilter.Controls.Add(this.lblType);
            this.pnlFilter.Controls.Add(this.cmbUserType);
            this.pnlFilter.Controls.Add(this.btnFilter);
            this.pnlFilter.Controls.Add(this.cmbCollege);
            this.pnlFilter.Controls.Add(this.lblCollege);
            this.pnlFilter.Controls.Add(this.txtLastName);
            this.pnlFilter.Controls.Add(this.txtFirstName);
            this.pnlFilter.Controls.Add(this.lblLastName);
            this.pnlFilter.Controls.Add(this.lblFirstName);
            this.pnlFilter.Controls.Add(this.txtUserName);
            this.pnlFilter.Controls.Add(this.lblUserName);
            this.pnlFilter.Controls.Add(this.txtNationalCode);
            this.pnlFilter.Controls.Add(this.lblNationalCode);
            this.pnlFilter.Location = new System.Drawing.Point(501, 1);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(693, 215);
            this.pnlFilter.TabIndex = 31;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(615, 151);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(58, 33);
            this.lblType.TabIndex = 31;
            this.lblType.Text = "نوع :";
            // 
            // cmbUserType
            // 
            this.cmbUserType.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Items.AddRange(new object[] {
            "کارمند ساده",
            "دانشجو",
            "استاد",
            "کارمند سیستمی"});
            this.cmbUserType.Location = new System.Drawing.Point(388, 148);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(182, 41);
            this.cmbUserType.TabIndex = 30;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(12, 126);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(221, 81);
            this.btnFilter.TabIndex = 29;
            this.btnFilter.Text = "فیلتر کردن";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cmbCollege
            // 
            this.cmbCollege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCollege.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCollege.FormattingEnabled = true;
            this.cmbCollege.Location = new System.Drawing.Point(388, 101);
            this.cmbCollege.Name = "cmbCollege";
            this.cmbCollege.Size = new System.Drawing.Size(182, 41);
            this.cmbCollege.TabIndex = 27;
            // 
            // lblCollege
            // 
            this.lblCollege.AutoSize = true;
            this.lblCollege.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollege.Location = new System.Drawing.Point(582, 109);
            this.lblCollege.Name = "lblCollege";
            this.lblCollege.Size = new System.Drawing.Size(104, 33);
            this.lblCollege.TabIndex = 28;
            this.lblCollege.Text = "دانشکده :";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(12, 12);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(182, 40);
            this.txtLastName.TabIndex = 18;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(388, 9);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(182, 40);
            this.txtFirstName.TabIndex = 17;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(217, 16);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(134, 33);
            this.lblLastName.TabIndex = 16;
            this.lblLastName.Text = "نام خانوادگی :";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(620, 12);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(53, 33);
            this.lblFirstName.TabIndex = 15;
            this.lblFirstName.Text = "نام :";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(12, 58);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(182, 40);
            this.txtUserName.TabIndex = 13;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(232, 65);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(119, 33);
            this.lblUserName.TabIndex = 14;
            this.lblUserName.Text = "کد پرسنلی :";
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationalCode.Location = new System.Drawing.Point(388, 55);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(182, 40);
            this.txtNationalCode.TabIndex = 11;
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.AutoSize = true;
            this.lblNationalCode.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalCode.Location = new System.Drawing.Point(596, 55);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.Size = new System.Drawing.Size(90, 33);
            this.lblNationalCode.TabIndex = 12;
            this.lblNationalCode.Text = "کد ملی :";
            // 
            // pnlUsers
            // 
            this.pnlUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUsers.Controls.Add(this.btnSelectUser);
            this.pnlUsers.Controls.Add(this.lblUsers);
            this.pnlUsers.Controls.Add(this.dgvUsers);
            this.pnlUsers.Location = new System.Drawing.Point(1, 222);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(1193, 290);
            this.pnlUsers.TabIndex = 32;
            this.pnlUsers.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUsers_Paint);
            // 
            // btnSelectUser
            // 
            this.btnSelectUser.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectUser.Location = new System.Drawing.Point(9, 15);
            this.btnSelectUser.Name = "btnSelectUser";
            this.btnSelectUser.Size = new System.Drawing.Size(179, 45);
            this.btnSelectUser.TabIndex = 31;
            this.btnSelectUser.Text = "انتخاب کاربر";
            this.btnSelectUser.UseVisualStyleBackColor = true;
            this.btnSelectUser.Click += new System.EventHandler(this.btnSelectUser_Click);
            // 
            // lblUsers
            // 
            this.lblUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(512, 19);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(106, 41);
            this.lblUsers.TabIndex = 1;
            this.lblUsers.Text = "کاربران";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmUserName,
            this.clmFirstName,
            this.clmLastName,
            this.clmNationalCode,
            this.clmFathersName,
            this.clmGender,
            this.clmType,
            this.clmPhoneNumber,
            this.clmCollege,
            this.clmEducational_Field});
            this.dgvUsers.Location = new System.Drawing.Point(-2, 79);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.Size = new System.Drawing.Size(1193, 209);
            this.dgvUsers.TabIndex = 0;
            // 
            // clmUserName
            // 
            this.clmUserName.HeaderText = "کد پرسنلی یا دانشجویی";
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
            // clmGender
            // 
            this.clmGender.HeaderText = "جنسیت";
            this.clmGender.Name = "clmGender";
            this.clmGender.ReadOnly = true;
            // 
            // clmType
            // 
            this.clmType.HeaderText = "نوع کاربر";
            this.clmType.Name = "clmType";
            this.clmType.ReadOnly = true;
            // 
            // clmPhoneNumber
            // 
            this.clmPhoneNumber.HeaderText = "تلفن همراه";
            this.clmPhoneNumber.Name = "clmPhoneNumber";
            this.clmPhoneNumber.ReadOnly = true;
            // 
            // clmCollege
            // 
            this.clmCollege.HeaderText = "دانشکده";
            this.clmCollege.Name = "clmCollege";
            this.clmCollege.ReadOnly = true;
            // 
            // clmEducational_Field
            // 
            this.clmEducational_Field.HeaderText = "رشته";
            this.clmEducational_Field.Name = "clmEducational_Field";
            this.clmEducational_Field.ReadOnly = true;
            // 
            // cmbStartDay
            // 
            this.cmbStartDay.FormattingEnabled = true;
            this.cmbStartDay.Location = new System.Drawing.Point(863, 547);
            this.cmbStartDay.Name = "cmbStartDay";
            this.cmbStartDay.Size = new System.Drawing.Size(66, 21);
            this.cmbStartDay.TabIndex = 33;
            // 
            // cmbStartMonth
            // 
            this.cmbStartMonth.FormattingEnabled = true;
            this.cmbStartMonth.Location = new System.Drawing.Point(935, 547);
            this.cmbStartMonth.Name = "cmbStartMonth";
            this.cmbStartMonth.Size = new System.Drawing.Size(66, 21);
            this.cmbStartMonth.TabIndex = 34;
            // 
            // cmbStartYear
            // 
            this.cmbStartYear.FormattingEnabled = true;
            this.cmbStartYear.Location = new System.Drawing.Point(1007, 547);
            this.cmbStartYear.Name = "cmbStartYear";
            this.cmbStartYear.Size = new System.Drawing.Size(66, 21);
            this.cmbStartYear.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1096, 544);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 36;
            this.label1.Text = "از تاریخ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1096, 586);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 26);
            this.label2.TabIndex = 40;
            this.label2.Text = "تا تاریخ";
            // 
            // cmbFinishYear
            // 
            this.cmbFinishYear.FormattingEnabled = true;
            this.cmbFinishYear.Location = new System.Drawing.Point(1007, 589);
            this.cmbFinishYear.Name = "cmbFinishYear";
            this.cmbFinishYear.Size = new System.Drawing.Size(66, 21);
            this.cmbFinishYear.TabIndex = 39;
            // 
            // cmbFinishMonth
            // 
            this.cmbFinishMonth.FormattingEnabled = true;
            this.cmbFinishMonth.Location = new System.Drawing.Point(935, 589);
            this.cmbFinishMonth.Name = "cmbFinishMonth";
            this.cmbFinishMonth.Size = new System.Drawing.Size(66, 21);
            this.cmbFinishMonth.TabIndex = 38;
            // 
            // cmbFinishDay
            // 
            this.cmbFinishDay.FormattingEnabled = true;
            this.cmbFinishDay.Location = new System.Drawing.Point(863, 589);
            this.cmbFinishDay.Name = "cmbFinishDay";
            this.cmbFinishDay.Size = new System.Drawing.Size(66, 21);
            this.cmbFinishDay.TabIndex = 37;
            // 
            // btnSelectDate
            // 
            this.btnSelectDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectDate.Location = new System.Drawing.Point(935, 630);
            this.btnSelectDate.Name = "btnSelectDate";
            this.btnSelectDate.Size = new System.Drawing.Size(164, 49);
            this.btnSelectDate.TabIndex = 41;
            this.btnSelectDate.Text = "انتخاب تاریخ";
            this.btnSelectDate.UseVisualStyleBackColor = true;
            this.btnSelectDate.Click += new System.EventHandler(this.btnSelectDate_Click);
            // 
            // txtWorkHour
            // 
            this.txtWorkHour.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkHour.Location = new System.Drawing.Point(17, 531);
            this.txtWorkHour.Name = "txtWorkHour";
            this.txtWorkHour.ReadOnly = true;
            this.txtWorkHour.Size = new System.Drawing.Size(174, 40);
            this.txtWorkHour.TabIndex = 42;
            // 
            // txtWorkMinute
            // 
            this.txtWorkMinute.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkMinute.Location = new System.Drawing.Point(17, 595);
            this.txtWorkMinute.Name = "txtWorkMinute";
            this.txtWorkMinute.ReadOnly = true;
            this.txtWorkMinute.Size = new System.Drawing.Size(174, 40);
            this.txtWorkMinute.TabIndex = 43;
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.Location = new System.Drawing.Point(218, 545);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(71, 26);
            this.lblHour.TabIndex = 44;
            this.lblHour.Text = "ساعت :";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinute.Location = new System.Drawing.Point(218, 600);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(66, 26);
            this.lblMinute.TabIndex = 45;
            this.lblMinute.Text = "دقیقه :";
            // 
            // btnToday
            // 
            this.btnToday.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.Location = new System.Drawing.Point(575, 531);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(141, 46);
            this.btnToday.TabIndex = 46;
            this.btnToday.Text = "فعالیت امروز";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisMonth.Location = new System.Drawing.Point(531, 586);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(224, 49);
            this.btnThisMonth.TabIndex = 47;
            this.btnThisMonth.Text = "فعالیت از ابتدای ماه";
            this.btnThisMonth.UseVisualStyleBackColor = true;
            this.btnThisMonth.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmWorkTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 792);
            this.Controls.Add(this.btnThisMonth);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.lblMinute);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.txtWorkMinute);
            this.Controls.Add(this.txtWorkHour);
            this.Controls.Add(this.btnSelectDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFinishYear);
            this.Controls.Add(this.cmbFinishMonth);
            this.Controls.Add(this.cmbFinishDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStartYear);
            this.Controls.Add(this.cmbStartMonth);
            this.Controls.Add(this.cmbStartDay);
            this.Controls.Add(this.pnlUsers);
            this.Controls.Add(this.pnlFilter);
            this.Name = "frmWorkTime";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmWorkTime";
            this.Load += new System.EventHandler(this.frmWorkTime_Load);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlUsers.ResumeLayout(false);
            this.pnlUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cmbCollege;
        private System.Windows.Forms.Label lblCollege;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.Label lblNationalCode;
        private System.Windows.Forms.Panel pnlUsers;
        private System.Windows.Forms.Button btnSelectUser;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFathersName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCollege;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEducational_Field;
        private System.Windows.Forms.ComboBox cmbStartDay;
        private System.Windows.Forms.ComboBox cmbStartMonth;
        private System.Windows.Forms.ComboBox cmbStartYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFinishYear;
        private System.Windows.Forms.ComboBox cmbFinishMonth;
        private System.Windows.Forms.ComboBox cmbFinishDay;
        private System.Windows.Forms.Button btnSelectDate;
        private System.Windows.Forms.TextBox txtWorkHour;
        private System.Windows.Forms.TextBox txtWorkMinute;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnThisMonth;
    }
}