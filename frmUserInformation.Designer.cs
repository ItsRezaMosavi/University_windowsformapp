namespace University
{
    partial class frmUserInformation
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
            this.lblIdentityTitle = new System.Windows.Forms.Label();
            this.pnlIdentity = new System.Windows.Forms.Panel();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblFathersName = new System.Windows.Forms.Label();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.pnlUserNamePassWord = new System.Windows.Forms.Panel();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pcbUserPhoto = new System.Windows.Forms.PictureBox();
            this.btnChangePhotoRequest = new System.Windows.Forms.Button();
            this.pnlEducation = new System.Windows.Forms.Panel();
            this.lblPassedUnitCount = new System.Windows.Forms.Label();
            this.pnlIdentity.SuspendLayout();
            this.pnlUserNamePassWord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserPhoto)).BeginInit();
            this.pnlEducation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdentityTitle
            // 
            this.lblIdentityTitle.AutoSize = true;
            this.lblIdentityTitle.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentityTitle.Location = new System.Drawing.Point(436, 16);
            this.lblIdentityTitle.Name = "lblIdentityTitle";
            this.lblIdentityTitle.Size = new System.Drawing.Size(194, 41);
            this.lblIdentityTitle.TabIndex = 0;
            this.lblIdentityTitle.Text = "اطلاعات هویتی";
            // 
            // pnlIdentity
            // 
            this.pnlIdentity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlIdentity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlIdentity.Controls.Add(this.lblGender);
            this.pnlIdentity.Controls.Add(this.lblFathersName);
            this.pnlIdentity.Controls.Add(this.lblNationalCode);
            this.pnlIdentity.Controls.Add(this.lblLastName);
            this.pnlIdentity.Controls.Add(this.lblFirstName);
            this.pnlIdentity.Controls.Add(this.lblIdentityTitle);
            this.pnlIdentity.Location = new System.Drawing.Point(23, 265);
            this.pnlIdentity.Name = "pnlIdentity";
            this.pnlIdentity.Size = new System.Drawing.Size(1081, 285);
            this.pnlIdentity.TabIndex = 1;
            // 
            // lblGender
            // 
            this.lblGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(621, 203);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(99, 33);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "جنسیت :";
            // 
            // lblFathersName
            // 
            this.lblFathersName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFathersName.AutoSize = true;
            this.lblFathersName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFathersName.Location = new System.Drawing.Point(956, 203);
            this.lblFathersName.Name = "lblFathersName";
            this.lblFathersName.Size = new System.Drawing.Size(88, 33);
            this.lblFathersName.TabIndex = 4;
            this.lblFathersName.Text = "نام پدر :";
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNationalCode.AutoSize = true;
            this.lblNationalCode.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalCode.Location = new System.Drawing.Point(332, 111);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.Size = new System.Drawing.Size(90, 33);
            this.lblNationalCode.TabIndex = 3;
            this.lblNationalCode.Text = "کد ملی :";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(621, 111);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(134, 33);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "نام خانوادگی :";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(991, 111);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(53, 33);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "نام :";
            // 
            // pnlUserNamePassWord
            // 
            this.pnlUserNamePassWord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUserNamePassWord.Controls.Add(this.btnChangePassword);
            this.pnlUserNamePassWord.Controls.Add(this.lblLoginTitle);
            this.pnlUserNamePassWord.Controls.Add(this.lblPassword);
            this.pnlUserNamePassWord.Controls.Add(this.lblUserName);
            this.pnlUserNamePassWord.Location = new System.Drawing.Point(23, 556);
            this.pnlUserNamePassWord.Name = "pnlUserNamePassWord";
            this.pnlUserNamePassWord.Size = new System.Drawing.Size(1081, 184);
            this.pnlUserNamePassWord.TabIndex = 2;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Enabled = false;
            this.btnChangePassword.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(39, 87);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(192, 66);
            this.btnChangePassword.TabIndex = 3;
            this.btnChangePassword.Text = "تغییر رمز عبور";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Visible = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitle.Location = new System.Drawing.Point(448, 31);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(182, 41);
            this.lblLoginTitle.TabIndex = 2;
            this.lblLoginTitle.Text = "اطلاعات ورود";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(561, 108);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(119, 32);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "رمز عبور :";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(931, 107);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(113, 33);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "نام کاربری :";
            // 
            // pcbUserPhoto
            // 
            this.pcbUserPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbUserPhoto.Location = new System.Drawing.Point(23, 47);
            this.pcbUserPhoto.Name = "pcbUserPhoto";
            this.pcbUserPhoto.Size = new System.Drawing.Size(222, 201);
            this.pcbUserPhoto.TabIndex = 3;
            this.pcbUserPhoto.TabStop = false;
            // 
            // btnChangePhotoRequest
            // 
            this.btnChangePhotoRequest.Location = new System.Drawing.Point(263, 201);
            this.btnChangePhotoRequest.Name = "btnChangePhotoRequest";
            this.btnChangePhotoRequest.Size = new System.Drawing.Size(157, 47);
            this.btnChangePhotoRequest.TabIndex = 4;
            this.btnChangePhotoRequest.Text = "درخواست تغییر عکس";
            this.btnChangePhotoRequest.UseVisualStyleBackColor = true;
            this.btnChangePhotoRequest.Click += new System.EventHandler(this.btnChangePhotoRequest_Click);
            // 
            // pnlEducation
            // 
            this.pnlEducation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlEducation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEducation.Controls.Add(this.lblPassedUnitCount);
            this.pnlEducation.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlEducation.Location = new System.Drawing.Point(23, 746);
            this.pnlEducation.Name = "pnlEducation";
            this.pnlEducation.Size = new System.Drawing.Size(1081, 184);
            this.pnlEducation.TabIndex = 5;
            // 
            // lblPassedUnitCount
            // 
            this.lblPassedUnitCount.AutoSize = true;
            this.lblPassedUnitCount.Location = new System.Drawing.Point(779, 47);
            this.lblPassedUnitCount.Name = "lblPassedUnitCount";
            this.lblPassedUnitCount.Size = new System.Drawing.Size(265, 33);
            this.lblPassedUnitCount.TabIndex = 0;
            this.lblPassedUnitCount.Text = "تعداد واحد های قبول شده :";
            // 
            // frmUserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 936);
            this.Controls.Add(this.pnlEducation);
            this.Controls.Add(this.btnChangePhotoRequest);
            this.Controls.Add(this.pcbUserPhoto);
            this.Controls.Add(this.pnlUserNamePassWord);
            this.Controls.Add(this.pnlIdentity);
            this.Name = "frmUserInformation";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmUserInformation";
            this.Load += new System.EventHandler(this.frmUserInformation_Load);
            this.pnlIdentity.ResumeLayout(false);
            this.pnlIdentity.PerformLayout();
            this.pnlUserNamePassWord.ResumeLayout(false);
            this.pnlUserNamePassWord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserPhoto)).EndInit();
            this.pnlEducation.ResumeLayout(false);
            this.pnlEducation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIdentityTitle;
        private System.Windows.Forms.Panel pnlIdentity;
        private System.Windows.Forms.Label lblNationalCode;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblFathersName;
        private System.Windows.Forms.Panel pnlUserNamePassWord;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pcbUserPhoto;
        private System.Windows.Forms.Button btnChangePhotoRequest;
        private System.Windows.Forms.Panel pnlEducation;
        private System.Windows.Forms.Label lblPassedUnitCount;
    }
}