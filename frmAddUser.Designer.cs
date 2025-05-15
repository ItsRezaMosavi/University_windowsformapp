namespace University
{
    partial class frmAddUser
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.txtFathersName = new System.Windows.Forms.TextBox();
            this.lblFathersName = new System.Windows.Forms.Label();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEducational_Field = new System.Windows.Forms.Label();
            this.cmbEducational_Field = new System.Windows.Forms.ComboBox();
            this.pnlName = new System.Windows.Forms.Panel();
            this.pnlNationalCode = new System.Windows.Forms.Panel();
            this.pnlGender = new System.Windows.Forms.Panel();
            this.pnlFathersName = new System.Windows.Forms.Panel();
            this.pnlPhoneNumber = new System.Windows.Forms.Panel();
            this.pnlEducational_Field = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbCollege = new System.Windows.Forms.ComboBox();
            this.lblCollege = new System.Windows.Forms.Label();
            this.pnlCollege = new System.Windows.Forms.Panel();
            this.pcbPhoto = new System.Windows.Forms.PictureBox();
            this.btnSelectPhoto = new System.Windows.Forms.Button();
            this.pnlName.SuspendLayout();
            this.pnlNationalCode.SuspendLayout();
            this.pnlGender.SuspendLayout();
            this.pnlFathersName.SuspendLayout();
            this.pnlPhoneNumber.SuspendLayout();
            this.pnlEducational_Field.SuspendLayout();
            this.pnlCollege.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(28, 692);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(229, 68);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "button1";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(21, 33);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(251, 47);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(21, 107);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(251, 47);
            this.txtLastName.TabIndex = 2;
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationalCode.Location = new System.Drawing.Point(24, 29);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(251, 47);
            this.txtNationalCode.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(331, 33);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(62, 39);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "نام :";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(331, 119);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(157, 39);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "نام خانوادگی :";
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.AutoSize = true;
            this.lblNationalCode.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalCode.Location = new System.Drawing.Point(324, 32);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.Size = new System.Drawing.Size(107, 39);
            this.lblNationalCode.TabIndex = 6;
            this.lblNationalCode.Text = "کد ملی :";
            // 
            // txtFathersName
            // 
            this.txtFathersName.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFathersName.Location = new System.Drawing.Point(21, 29);
            this.txtFathersName.Name = "txtFathersName";
            this.txtFathersName.Size = new System.Drawing.Size(251, 47);
            this.txtFathersName.TabIndex = 7;
            // 
            // lblFathersName
            // 
            this.lblFathersName.AutoSize = true;
            this.lblFathersName.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFathersName.Location = new System.Drawing.Point(339, 29);
            this.lblFathersName.Name = "lblFathersName";
            this.lblFathersName.Size = new System.Drawing.Size(104, 39);
            this.lblFathersName.TabIndex = 8;
            this.lblFathersName.Text = "نام پدر :";
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMale.Location = new System.Drawing.Point(184, 88);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(63, 43);
            this.rdbMale.TabIndex = 11;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "آقا";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemale.Location = new System.Drawing.Point(23, 88);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(85, 43);
            this.rdbFemale.TabIndex = 12;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "خانم";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(154, 22);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(120, 39);
            this.lblGender.TabIndex = 13;
            this.lblGender.Text = "جنسیت :";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(24, 32);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(251, 47);
            this.txtPhoneNumber.TabIndex = 14;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(308, 35);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(144, 39);
            this.lblPhoneNumber.TabIndex = 15;
            this.lblPhoneNumber.Text = "تلفن همراه :";
            // 
            // lblEducational_Field
            // 
            this.lblEducational_Field.AutoSize = true;
            this.lblEducational_Field.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEducational_Field.Location = new System.Drawing.Point(304, 32);
            this.lblEducational_Field.Name = "lblEducational_Field";
            this.lblEducational_Field.Size = new System.Drawing.Size(178, 39);
            this.lblEducational_Field.TabIndex = 16;
            this.lblEducational_Field.Text = "رشته تحصیلی :";
            // 
            // cmbEducational_Field
            // 
            this.cmbEducational_Field.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEducational_Field.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEducational_Field.FormattingEnabled = true;
            this.cmbEducational_Field.Location = new System.Drawing.Point(16, 29);
            this.cmbEducational_Field.Name = "cmbEducational_Field";
            this.cmbEducational_Field.Size = new System.Drawing.Size(282, 47);
            this.cmbEducational_Field.TabIndex = 17;
            // 
            // pnlName
            // 
            this.pnlName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlName.Controls.Add(this.txtFirstName);
            this.pnlName.Controls.Add(this.txtLastName);
            this.pnlName.Controls.Add(this.lblFirstName);
            this.pnlName.Controls.Add(this.lblLastName);
            this.pnlName.Location = new System.Drawing.Point(525, 143);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(500, 206);
            this.pnlName.TabIndex = 18;
            // 
            // pnlNationalCode
            // 
            this.pnlNationalCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlNationalCode.Controls.Add(this.txtNationalCode);
            this.pnlNationalCode.Controls.Add(this.lblNationalCode);
            this.pnlNationalCode.Location = new System.Drawing.Point(28, 143);
            this.pnlNationalCode.Name = "pnlNationalCode";
            this.pnlNationalCode.Size = new System.Drawing.Size(471, 100);
            this.pnlNationalCode.TabIndex = 19;
            // 
            // pnlGender
            // 
            this.pnlGender.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGender.Controls.Add(this.rdbFemale);
            this.pnlGender.Controls.Add(this.rdbMale);
            this.pnlGender.Controls.Add(this.lblGender);
            this.pnlGender.Location = new System.Drawing.Point(206, 273);
            this.pnlGender.Name = "pnlGender";
            this.pnlGender.Size = new System.Drawing.Size(293, 154);
            this.pnlGender.TabIndex = 20;
            // 
            // pnlFathersName
            // 
            this.pnlFathersName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFathersName.Controls.Add(this.txtFathersName);
            this.pnlFathersName.Controls.Add(this.lblFathersName);
            this.pnlFathersName.Location = new System.Drawing.Point(525, 363);
            this.pnlFathersName.Name = "pnlFathersName";
            this.pnlFathersName.Size = new System.Drawing.Size(500, 100);
            this.pnlFathersName.TabIndex = 21;
            // 
            // pnlPhoneNumber
            // 
            this.pnlPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPhoneNumber.Controls.Add(this.txtPhoneNumber);
            this.pnlPhoneNumber.Controls.Add(this.lblPhoneNumber);
            this.pnlPhoneNumber.Location = new System.Drawing.Point(28, 450);
            this.pnlPhoneNumber.Name = "pnlPhoneNumber";
            this.pnlPhoneNumber.Size = new System.Drawing.Size(471, 100);
            this.pnlPhoneNumber.TabIndex = 22;
            // 
            // pnlEducational_Field
            // 
            this.pnlEducational_Field.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEducational_Field.Controls.Add(this.cmbEducational_Field);
            this.pnlEducational_Field.Controls.Add(this.lblEducational_Field);
            this.pnlEducational_Field.Location = new System.Drawing.Point(525, 484);
            this.pnlEducational_Field.Name = "pnlEducational_Field";
            this.pnlEducational_Field.Size = new System.Drawing.Size(500, 100);
            this.pnlEducational_Field.TabIndex = 23;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(465, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(114, 45);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "label1";
            // 
            // cmbCollege
            // 
            this.cmbCollege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCollege.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCollege.FormattingEnabled = true;
            this.cmbCollege.Location = new System.Drawing.Point(18, 27);
            this.cmbCollege.Name = "cmbCollege";
            this.cmbCollege.Size = new System.Drawing.Size(282, 47);
            this.cmbCollege.TabIndex = 25;
            // 
            // lblCollege
            // 
            this.lblCollege.AutoSize = true;
            this.lblCollege.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollege.Location = new System.Drawing.Point(341, 30);
            this.lblCollege.Name = "lblCollege";
            this.lblCollege.Size = new System.Drawing.Size(124, 39);
            this.lblCollege.TabIndex = 26;
            this.lblCollege.Text = "دانشکده :";
            // 
            // pnlCollege
            // 
            this.pnlCollege.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCollege.Controls.Add(this.cmbCollege);
            this.pnlCollege.Controls.Add(this.lblCollege);
            this.pnlCollege.Location = new System.Drawing.Point(525, 600);
            this.pnlCollege.Name = "pnlCollege";
            this.pnlCollege.Size = new System.Drawing.Size(500, 100);
            this.pnlCollege.TabIndex = 27;
            // 
            // pcbPhoto
            // 
            this.pcbPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pcbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbPhoto.Location = new System.Drawing.Point(28, 565);
            this.pcbPhoto.Name = "pcbPhoto";
            this.pcbPhoto.Size = new System.Drawing.Size(172, 94);
            this.pcbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPhoto.TabIndex = 28;
            this.pcbPhoto.TabStop = false;
            // 
            // btnSelectPhoto
            // 
            this.btnSelectPhoto.Location = new System.Drawing.Point(276, 583);
            this.btnSelectPhoto.Name = "btnSelectPhoto";
            this.btnSelectPhoto.Size = new System.Drawing.Size(142, 57);
            this.btnSelectPhoto.TabIndex = 29;
            this.btnSelectPhoto.Text = "انتخاب عکس";
            this.btnSelectPhoto.UseVisualStyleBackColor = true;
            this.btnSelectPhoto.Click += new System.EventHandler(this.btnSelectPhoto_Click);
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 772);
            this.Controls.Add(this.btnSelectPhoto);
            this.Controls.Add(this.pcbPhoto);
            this.Controls.Add(this.pnlCollege);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlEducational_Field);
            this.Controls.Add(this.pnlPhoneNumber);
            this.Controls.Add(this.pnlFathersName);
            this.Controls.Add(this.pnlGender);
            this.Controls.Add(this.pnlNationalCode);
            this.Controls.Add(this.pnlName);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmAddUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frmAddUser_Load);
            this.pnlName.ResumeLayout(false);
            this.pnlName.PerformLayout();
            this.pnlNationalCode.ResumeLayout(false);
            this.pnlNationalCode.PerformLayout();
            this.pnlGender.ResumeLayout(false);
            this.pnlGender.PerformLayout();
            this.pnlFathersName.ResumeLayout(false);
            this.pnlFathersName.PerformLayout();
            this.pnlPhoneNumber.ResumeLayout(false);
            this.pnlPhoneNumber.PerformLayout();
            this.pnlEducational_Field.ResumeLayout(false);
            this.pnlEducational_Field.PerformLayout();
            this.pnlCollege.ResumeLayout(false);
            this.pnlCollege.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblNationalCode;
        private System.Windows.Forms.TextBox txtFathersName;
        private System.Windows.Forms.Label lblFathersName;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEducational_Field;
        private System.Windows.Forms.ComboBox cmbEducational_Field;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.Panel pnlNationalCode;
        private System.Windows.Forms.Panel pnlGender;
        private System.Windows.Forms.Panel pnlFathersName;
        private System.Windows.Forms.Panel pnlPhoneNumber;
        private System.Windows.Forms.Panel pnlEducational_Field;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbCollege;
        private System.Windows.Forms.Label lblCollege;
        private System.Windows.Forms.Panel pnlCollege;
        private System.Windows.Forms.PictureBox pcbPhoto;
        private System.Windows.Forms.Button btnSelectPhoto;
    }
}