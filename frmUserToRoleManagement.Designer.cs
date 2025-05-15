namespace University
{
    partial class frmUserToRoleManagement
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnSelectUser = new System.Windows.Forms.Button();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnAddRoletoUser = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.clmPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCollegeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEducationalField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.pnlFilter.Location = new System.Drawing.Point(491, 1);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(693, 239);
            this.pnlFilter.TabIndex = 31;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(17, 168);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(167, 55);
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
            this.cmbCollege.Location = new System.Drawing.Point(388, 182);
            this.cmbCollege.Name = "cmbCollege";
            this.cmbCollege.Size = new System.Drawing.Size(182, 41);
            this.cmbCollege.TabIndex = 27;
            // 
            // lblCollege
            // 
            this.lblCollege.AutoSize = true;
            this.lblCollege.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollege.Location = new System.Drawing.Point(582, 190);
            this.lblCollege.Name = "lblCollege";
            this.lblCollege.Size = new System.Drawing.Size(104, 33);
            this.lblCollege.TabIndex = 28;
            this.lblCollege.Text = "دانشکده :";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(17, 26);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(182, 40);
            this.txtLastName.TabIndex = 18;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(388, 27);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(182, 40);
            this.txtFirstName.TabIndex = 17;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(222, 30);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(134, 33);
            this.lblLastName.TabIndex = 16;
            this.lblLastName.Text = "نام خانوادگی :";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(620, 30);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(53, 33);
            this.lblFirstName.TabIndex = 15;
            this.lblFirstName.Text = "نام :";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(17, 97);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(182, 40);
            this.txtUserName.TabIndex = 13;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(237, 104);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(119, 33);
            this.lblUserName.TabIndex = 14;
            this.lblUserName.Text = "کد پرسنلی :";
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationalCode.Location = new System.Drawing.Point(388, 104);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(182, 40);
            this.txtNationalCode.TabIndex = 11;
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.AutoSize = true;
            this.lblNationalCode.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalCode.Location = new System.Drawing.Point(596, 104);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.Size = new System.Drawing.Size(90, 33);
            this.lblNationalCode.TabIndex = 12;
            this.lblNationalCode.Text = "کد ملی :";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPhoto,
            this.clmUserName,
            this.clmFirstName,
            this.clmLastName,
            this.clmRoles,
            this.clmNationalCode,
            this.clmFatherName,
            this.clmCollegeName,
            this.clmEducationalField,
            this.clmGender,
            this.clmPhoneNumber});
            this.dgvUsers.Location = new System.Drawing.Point(-114, 246);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.Size = new System.Drawing.Size(1302, 393);
            this.dgvUsers.TabIndex = 30;
            // 
            // btnSelectUser
            // 
            this.btnSelectUser.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectUser.Location = new System.Drawing.Point(12, 176);
            this.btnSelectUser.Name = "btnSelectUser";
            this.btnSelectUser.Size = new System.Drawing.Size(167, 55);
            this.btnSelectUser.TabIndex = 32;
            this.btnSelectUser.Text = "انتخاب کاربر";
            this.btnSelectUser.UseVisualStyleBackColor = true;
            this.btnSelectUser.Click += new System.EventHandler(this.btnSelectUser_Click);
            // 
            // cmbRole
            // 
            this.cmbRole.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(666, 680);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(351, 40);
            this.cmbRole.TabIndex = 33;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(1056, 680);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(95, 32);
            this.lblRole.TabIndex = 34;
            this.lblRole.Text = "رول ها :";
            // 
            // btnAddRoletoUser
            // 
            this.btnAddRoletoUser.Location = new System.Drawing.Point(397, 674);
            this.btnAddRoletoUser.Name = "btnAddRoletoUser";
            this.btnAddRoletoUser.Size = new System.Drawing.Size(221, 54);
            this.btnAddRoletoUser.TabIndex = 35;
            this.btnAddRoletoUser.Text = "الحاق رول به کاربر";
            this.btnAddRoletoUser.UseVisualStyleBackColor = true;
            this.btnAddRoletoUser.Click += new System.EventHandler(this.btnAddRoletoUser_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(12, 21);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(167, 55);
            this.btnRefresh.TabIndex = 36;
            this.btnRefresh.Text = "تازه سازی";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // clmPhoto
            // 
            this.clmPhoto.HeaderText = "عکس";
            this.clmPhoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.clmPhoto.Name = "clmPhoto";
            this.clmPhoto.ReadOnly = true;
            this.clmPhoto.Width = 150;
            // 
            // clmUserName
            // 
            this.clmUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmUserName.HeaderText = "کد پرسنلی / دانشجویی";
            this.clmUserName.Name = "clmUserName";
            this.clmUserName.ReadOnly = true;
            this.clmUserName.Width = 129;
            // 
            // clmFirstName
            // 
            this.clmFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmFirstName.HeaderText = "نام";
            this.clmFirstName.Name = "clmFirstName";
            this.clmFirstName.ReadOnly = true;
            this.clmFirstName.Width = 45;
            // 
            // clmLastName
            // 
            this.clmLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmLastName.HeaderText = "نام خانوادگی";
            this.clmLastName.Name = "clmLastName";
            this.clmLastName.ReadOnly = true;
            this.clmLastName.Width = 87;
            // 
            // clmRoles
            // 
            this.clmRoles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmRoles.HeaderText = "رول های کاربر";
            this.clmRoles.Name = "clmRoles";
            this.clmRoles.ReadOnly = true;
            this.clmRoles.Width = 94;
            // 
            // clmNationalCode
            // 
            this.clmNationalCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmNationalCode.HeaderText = "کد ملی";
            this.clmNationalCode.Name = "clmNationalCode";
            this.clmNationalCode.ReadOnly = true;
            this.clmNationalCode.Width = 61;
            // 
            // clmFatherName
            // 
            this.clmFatherName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmFatherName.HeaderText = "نام پدر";
            this.clmFatherName.Name = "clmFatherName";
            this.clmFatherName.ReadOnly = true;
            this.clmFatherName.Width = 58;
            // 
            // clmCollegeName
            // 
            this.clmCollegeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmCollegeName.HeaderText = "دانشکده";
            this.clmCollegeName.Name = "clmCollegeName";
            this.clmCollegeName.ReadOnly = true;
            this.clmCollegeName.Width = 71;
            // 
            // clmEducationalField
            // 
            this.clmEducationalField.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmEducationalField.HeaderText = "رشته تحصیلی";
            this.clmEducationalField.Name = "clmEducationalField";
            this.clmEducationalField.ReadOnly = true;
            this.clmEducationalField.Width = 88;
            // 
            // clmGender
            // 
            this.clmGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmGender.HeaderText = "جنسیت";
            this.clmGender.Name = "clmGender";
            this.clmGender.ReadOnly = true;
            this.clmGender.Width = 64;
            // 
            // clmPhoneNumber
            // 
            this.clmPhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmPhoneNumber.HeaderText = "تلفن همراه";
            this.clmPhoneNumber.Name = "clmPhoneNumber";
            this.clmPhoneNumber.ReadOnly = true;
            this.clmPhoneNumber.Width = 74;
            // 
            // frmUserToRoleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 915);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddRoletoUser);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.btnSelectUser);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.dgvUsers);
            this.MinimumSize = new System.Drawing.Size(1060, 954);
            this.Name = "frmUserToRoleManagement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frmUserToRoleManagement_Load);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFilter;
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
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnSelectUser;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnAddRoletoUser;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewImageColumn clmPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCollegeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEducationalField;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhoneNumber;
    }
}