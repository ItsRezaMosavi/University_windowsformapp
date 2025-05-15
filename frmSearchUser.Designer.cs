namespace University
{
    partial class frmSearchUser
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
            this.cmbUserRoles = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbCollege = new System.Windows.Forms.ComboBox();
            this.lblCollege = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.clmPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCollegeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEducationalField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelectUser = new System.Windows.Forms.Button();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFilter.Controls.Add(this.lblType);
            this.pnlFilter.Controls.Add(this.cmbUserRoles);
            this.pnlFilter.Controls.Add(this.btnSearch);
            this.pnlFilter.Controls.Add(this.cmbCollege);
            this.pnlFilter.Controls.Add(this.lblCollege);
            this.pnlFilter.Controls.Add(this.txtLastName);
            this.pnlFilter.Controls.Add(this.txtFirstName);
            this.pnlFilter.Controls.Add(this.lblLastName);
            this.pnlFilter.Controls.Add(this.lblFirstName);
            this.pnlFilter.Controls.Add(this.txtUserName);
            this.pnlFilter.Controls.Add(this.lblUserName);
            this.pnlFilter.Location = new System.Drawing.Point(256, 111);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(889, 284);
            this.pnlFilter.TabIndex = 32;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(689, 219);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(58, 33);
            this.lblType.TabIndex = 31;
            this.lblType.Text = "نوع :";
            // 
            // cmbUserRoles
            // 
            this.cmbUserRoles.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserRoles.FormattingEnabled = true;
            this.cmbUserRoles.Items.AddRange(new object[] {
            "کارمند ساده",
            "دانشجو",
            "استاد",
            "کارمند سیستمی"});
            this.cmbUserRoles.Location = new System.Drawing.Point(353, 211);
            this.cmbUserRoles.Name = "cmbUserRoles";
            this.cmbUserRoles.Size = new System.Drawing.Size(251, 41);
            this.cmbUserRoles.TabIndex = 30;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(49, 121);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(221, 81);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbCollege
            // 
            this.cmbCollege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCollege.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCollege.FormattingEnabled = true;
            this.cmbCollege.Location = new System.Drawing.Point(353, 143);
            this.cmbCollege.Name = "cmbCollege";
            this.cmbCollege.Size = new System.Drawing.Size(251, 41);
            this.cmbCollege.TabIndex = 27;
            // 
            // lblCollege
            // 
            this.lblCollege.AutoSize = true;
            this.lblCollege.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollege.Location = new System.Drawing.Point(681, 151);
            this.lblCollege.Name = "lblCollege";
            this.lblCollege.Size = new System.Drawing.Size(104, 33);
            this.lblCollege.TabIndex = 28;
            this.lblCollege.Text = "دانشکده :";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(27, 15);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(260, 40);
            this.txtLastName.TabIndex = 18;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(490, 16);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(251, 40);
            this.txtFirstName.TabIndex = 17;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(302, 19);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(134, 33);
            this.lblLastName.TabIndex = 16;
            this.lblLastName.Text = "نام خانوادگی :";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(804, 22);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(53, 33);
            this.lblFirstName.TabIndex = 15;
            this.lblFirstName.Text = "نام :";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(353, 78);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(251, 40);
            this.txtUserName.TabIndex = 13;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(625, 81);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(232, 33);
            this.lblUserName.TabIndex = 14;
            this.lblUserName.Text = "کد پرسنلی یا دانشجویی :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(551, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 33);
            this.label1.TabIndex = 33;
            this.label1.Text = "جستجو";
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
            this.clmRole,
            this.clmCollegeName,
            this.clmEducationalField,
            this.clmGender});
            this.dgvUsers.Location = new System.Drawing.Point(-1, 407);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.Size = new System.Drawing.Size(1158, 398);
            this.dgvUsers.TabIndex = 34;
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
            this.clmUserName.HeaderText = "کد پرسنلی / دانشجویی";
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
            // clmRole
            // 
            this.clmRole.HeaderText = "نوع";
            this.clmRole.Name = "clmRole";
            this.clmRole.ReadOnly = true;
            // 
            // clmCollegeName
            // 
            this.clmCollegeName.HeaderText = "دانشکده";
            this.clmCollegeName.Name = "clmCollegeName";
            this.clmCollegeName.ReadOnly = true;
            // 
            // clmEducationalField
            // 
            this.clmEducationalField.HeaderText = "رشته تحصیلی";
            this.clmEducationalField.Name = "clmEducationalField";
            this.clmEducationalField.ReadOnly = true;
            // 
            // clmGender
            // 
            this.clmGender.HeaderText = "جنسیت";
            this.clmGender.Name = "clmGender";
            this.clmGender.ReadOnly = true;
            // 
            // btnSelectUser
            // 
            this.btnSelectUser.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectUser.Location = new System.Drawing.Point(12, 324);
            this.btnSelectUser.Name = "btnSelectUser";
            this.btnSelectUser.Size = new System.Drawing.Size(227, 77);
            this.btnSelectUser.TabIndex = 35;
            this.btnSelectUser.Text = "انتخاب و ارسال پیام";
            this.btnSelectUser.UseVisualStyleBackColor = true;
            this.btnSelectUser.Click += new System.EventHandler(this.btnSelectUser_Click);
            // 
            // frmSearchUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 805);
            this.Controls.Add(this.btnSelectUser);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlFilter);
            this.Name = "frmSearchUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frmSearchUser_Load);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbUserRoles;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbCollege;
        private System.Windows.Forms.Label lblCollege;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewImageColumn clmPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCollegeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEducationalField;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGender;
        private System.Windows.Forms.Button btnSelectUser;
    }
}