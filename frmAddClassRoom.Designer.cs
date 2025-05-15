namespace University
{
    partial class frmAddClassRoom
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
            this.pnlCollege = new System.Windows.Forms.Panel();
            this.cmbCollege = new System.Windows.Forms.ComboBox();
            this.lblCollege = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.btnSelectTeacher = new System.Windows.Forms.Button();
            this.pnlTeacher = new System.Windows.Forms.Panel();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.rdbBahman = new System.Windows.Forms.RadioButton();
            this.rdbMehr = new System.Windows.Forms.RadioButton();
            this.rdbTabestan = new System.Windows.Forms.RadioButton();
            this.pnlYear_Term = new System.Windows.Forms.Panel();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.pnlCapacity = new System.Windows.Forms.Panel();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.pnlLesson = new System.Windows.Forms.Panel();
            this.cmbLesson = new System.Windows.Forms.ComboBox();
            this.lblLesson = new System.Windows.Forms.Label();
            this.pnlWeek = new System.Windows.Forms.Panel();
            this.cmbWeek = new System.Windows.Forms.ComboBox();
            this.lblDayOfWeek = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblFinishTime = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpFinishTime = new System.Windows.Forms.DateTimePicker();
            this.lblAlert = new System.Windows.Forms.Label();
            this.pnlCollege.SuspendLayout();
            this.pnlTeacher.SuspendLayout();
            this.pnlYear_Term.SuspendLayout();
            this.pnlCapacity.SuspendLayout();
            this.pnlLesson.SuspendLayout();
            this.pnlWeek.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(475, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(172, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "افزودن کلاس";
            // 
            // pnlCollege
            // 
            this.pnlCollege.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCollege.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCollege.Controls.Add(this.cmbCollege);
            this.pnlCollege.Controls.Add(this.lblCollege);
            this.pnlCollege.Location = new System.Drawing.Point(578, 104);
            this.pnlCollege.Name = "pnlCollege";
            this.pnlCollege.Size = new System.Drawing.Size(500, 100);
            this.pnlCollege.TabIndex = 28;
            // 
            // cmbCollege
            // 
            this.cmbCollege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCollege.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCollege.FormattingEnabled = true;
            this.cmbCollege.Location = new System.Drawing.Point(33, 27);
            this.cmbCollege.Name = "cmbCollege";
            this.cmbCollege.Size = new System.Drawing.Size(282, 47);
            this.cmbCollege.TabIndex = 25;
            this.cmbCollege.SelectedValueChanged += new System.EventHandler(this.cmbCollege_SelectedValueChanged);
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
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacher.Location = new System.Drawing.Point(378, 29);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(87, 39);
            this.lblTeacher.TabIndex = 30;
            this.lblTeacher.Text = "استاد :";
            // 
            // txtTeacher
            // 
            this.txtTeacher.Enabled = false;
            this.txtTeacher.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacher.Location = new System.Drawing.Point(33, 26);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(282, 47);
            this.txtTeacher.TabIndex = 29;
            // 
            // btnSelectTeacher
            // 
            this.btnSelectTeacher.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectTeacher.Location = new System.Drawing.Point(170, 100);
            this.btnSelectTeacher.Name = "btnSelectTeacher";
            this.btnSelectTeacher.Size = new System.Drawing.Size(184, 57);
            this.btnSelectTeacher.TabIndex = 31;
            this.btnSelectTeacher.Text = "انتخاب استاد";
            this.btnSelectTeacher.UseVisualStyleBackColor = true;
            this.btnSelectTeacher.Click += new System.EventHandler(this.btnSelectTeacher_Click);
            // 
            // pnlTeacher
            // 
            this.pnlTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTeacher.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTeacher.Controls.Add(this.btnSelectTeacher);
            this.pnlTeacher.Controls.Add(this.txtTeacher);
            this.pnlTeacher.Controls.Add(this.lblTeacher);
            this.pnlTeacher.Location = new System.Drawing.Point(578, 210);
            this.pnlTeacher.Name = "pnlTeacher";
            this.pnlTeacher.Size = new System.Drawing.Size(500, 205);
            this.pnlTeacher.TabIndex = 32;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(91, 26);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(151, 47);
            this.txtYear.TabIndex = 33;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(295, 29);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(170, 39);
            this.lblYear.TabIndex = 34;
            this.lblYear.Text = "سال تحصیلی :";
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerm.Location = new System.Drawing.Point(399, 106);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(66, 39);
            this.lblTerm.TabIndex = 35;
            this.lblTerm.Text = "ترم :";
            // 
            // rdbBahman
            // 
            this.rdbBahman.AutoSize = true;
            this.rdbBahman.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBahman.Location = new System.Drawing.Point(190, 108);
            this.rdbBahman.Name = "rdbBahman";
            this.rdbBahman.Size = new System.Drawing.Size(78, 37);
            this.rdbBahman.TabIndex = 36;
            this.rdbBahman.TabStop = true;
            this.rdbBahman.Text = "بهمن";
            this.rdbBahman.UseVisualStyleBackColor = true;
            // 
            // rdbMehr
            // 
            this.rdbMehr.AutoSize = true;
            this.rdbMehr.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMehr.Location = new System.Drawing.Point(286, 108);
            this.rdbMehr.Name = "rdbMehr";
            this.rdbMehr.Size = new System.Drawing.Size(67, 37);
            this.rdbMehr.TabIndex = 37;
            this.rdbMehr.TabStop = true;
            this.rdbMehr.Text = "مهر";
            this.rdbMehr.UseVisualStyleBackColor = true;
            // 
            // rdbTabestan
            // 
            this.rdbTabestan.AutoSize = true;
            this.rdbTabestan.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTabestan.Location = new System.Drawing.Point(73, 108);
            this.rdbTabestan.Name = "rdbTabestan";
            this.rdbTabestan.Size = new System.Drawing.Size(100, 37);
            this.rdbTabestan.TabIndex = 38;
            this.rdbTabestan.TabStop = true;
            this.rdbTabestan.Text = "تابستان";
            this.rdbTabestan.UseVisualStyleBackColor = true;
            // 
            // pnlYear_Term
            // 
            this.pnlYear_Term.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlYear_Term.Controls.Add(this.txtYear);
            this.pnlYear_Term.Controls.Add(this.rdbTabestan);
            this.pnlYear_Term.Controls.Add(this.rdbMehr);
            this.pnlYear_Term.Controls.Add(this.lblYear);
            this.pnlYear_Term.Controls.Add(this.rdbBahman);
            this.pnlYear_Term.Controls.Add(this.lblTerm);
            this.pnlYear_Term.Location = new System.Drawing.Point(21, 260);
            this.pnlYear_Term.Name = "pnlYear_Term";
            this.pnlYear_Term.Size = new System.Drawing.Size(500, 195);
            this.pnlYear_Term.TabIndex = 39;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.Location = new System.Drawing.Point(95, 24);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(149, 40);
            this.txtCapacity.TabIndex = 40;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(356, 23);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(111, 39);
            this.lblCapacity.TabIndex = 41;
            this.lblCapacity.Text = "ظرفیت :";
            // 
            // pnlCapacity
            // 
            this.pnlCapacity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCapacity.Controls.Add(this.txtCapacity);
            this.pnlCapacity.Controls.Add(this.lblCapacity);
            this.pnlCapacity.Location = new System.Drawing.Point(21, 461);
            this.pnlCapacity.Name = "pnlCapacity";
            this.pnlCapacity.Size = new System.Drawing.Size(500, 90);
            this.pnlCapacity.TabIndex = 42;
            // 
            // btnAddClass
            // 
            this.btnAddClass.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClass.Location = new System.Drawing.Point(21, 618);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(393, 119);
            this.btnAddClass.TabIndex = 43;
            this.btnAddClass.Text = "افزودن";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // pnlLesson
            // 
            this.pnlLesson.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLesson.Controls.Add(this.cmbLesson);
            this.pnlLesson.Controls.Add(this.lblLesson);
            this.pnlLesson.Location = new System.Drawing.Point(21, 104);
            this.pnlLesson.Name = "pnlLesson";
            this.pnlLesson.Size = new System.Drawing.Size(500, 150);
            this.pnlLesson.TabIndex = 44;
            // 
            // cmbLesson
            // 
            this.cmbLesson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLesson.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLesson.FormattingEnabled = true;
            this.cmbLesson.Location = new System.Drawing.Point(33, 52);
            this.cmbLesson.Name = "cmbLesson";
            this.cmbLesson.Size = new System.Drawing.Size(282, 41);
            this.cmbLesson.TabIndex = 1;
            // 
            // lblLesson
            // 
            this.lblLesson.AutoSize = true;
            this.lblLesson.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLesson.Location = new System.Drawing.Point(381, 52);
            this.lblLesson.Name = "lblLesson";
            this.lblLesson.Size = new System.Drawing.Size(84, 39);
            this.lblLesson.TabIndex = 0;
            this.lblLesson.Text = "درس :";
            // 
            // pnlWeek
            // 
            this.pnlWeek.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlWeek.Controls.Add(this.lblAlert);
            this.pnlWeek.Controls.Add(this.dtpFinishTime);
            this.pnlWeek.Controls.Add(this.dtpStartTime);
            this.pnlWeek.Controls.Add(this.lblFinishTime);
            this.pnlWeek.Controls.Add(this.lblStartTime);
            this.pnlWeek.Controls.Add(this.lblDayOfWeek);
            this.pnlWeek.Controls.Add(this.cmbWeek);
            this.pnlWeek.Location = new System.Drawing.Point(578, 421);
            this.pnlWeek.Name = "pnlWeek";
            this.pnlWeek.Size = new System.Drawing.Size(500, 316);
            this.pnlWeek.TabIndex = 45;
            // 
            // cmbWeek
            // 
            this.cmbWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWeek.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWeek.FormattingEnabled = true;
            this.cmbWeek.Items.AddRange(new object[] {
            "شنبه",
            "یکشنبه",
            "دوشنبه",
            "سه شنبه",
            "چهارشنبه",
            "پنج شنبه",
            "جمعه"});
            this.cmbWeek.Location = new System.Drawing.Point(79, 22);
            this.cmbWeek.Name = "cmbWeek";
            this.cmbWeek.Size = new System.Drawing.Size(253, 47);
            this.cmbWeek.TabIndex = 26;
            // 
            // lblDayOfWeek
            // 
            this.lblDayOfWeek.AutoSize = true;
            this.lblDayOfWeek.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayOfWeek.Location = new System.Drawing.Point(378, 25);
            this.lblDayOfWeek.Name = "lblDayOfWeek";
            this.lblDayOfWeek.Size = new System.Drawing.Size(68, 39);
            this.lblDayOfWeek.TabIndex = 27;
            this.lblDayOfWeek.Text = "روز :";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.Location = new System.Drawing.Point(263, 106);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(230, 39);
            this.lblStartTime.TabIndex = 29;
            this.lblStartTime.Text = "ساعت شروع کلاس :";
            // 
            // lblFinishTime
            // 
            this.lblFinishTime.AutoSize = true;
            this.lblFinishTime.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinishTime.Location = new System.Drawing.Point(264, 178);
            this.lblFinishTime.Name = "lblFinishTime";
            this.lblFinishTime.Size = new System.Drawing.Size(220, 39);
            this.lblFinishTime.TabIndex = 33;
            this.lblFinishTime.Text = "ساعت پایان کلاس :";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.Location = new System.Drawing.Point(33, 113);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(212, 32);
            this.dtpStartTime.TabIndex = 46;
            // 
            // dtpFinishTime
            // 
            this.dtpFinishTime.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinishTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFinishTime.Location = new System.Drawing.Point(33, 183);
            this.dtpFinishTime.Name = "dtpFinishTime";
            this.dtpFinishTime.ShowUpDown = true;
            this.dtpFinishTime.Size = new System.Drawing.Size(212, 32);
            this.dtpFinishTime.TabIndex = 47;
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.ForeColor = System.Drawing.Color.Red;
            this.lblAlert.Location = new System.Drawing.Point(129, 240);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(263, 32);
            this.lblAlert.TabIndex = 48;
            this.lblAlert.Text = "به AM  و  PM دقت کنید .";
            // 
            // frmAddClassRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 928);
            this.Controls.Add(this.pnlWeek);
            this.Controls.Add(this.pnlLesson);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.pnlCapacity);
            this.Controls.Add(this.pnlYear_Term);
            this.Controls.Add(this.pnlTeacher);
            this.Controls.Add(this.pnlCollege);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddClassRoom";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frmAddClassRoom_Load);
            this.pnlCollege.ResumeLayout(false);
            this.pnlCollege.PerformLayout();
            this.pnlTeacher.ResumeLayout(false);
            this.pnlTeacher.PerformLayout();
            this.pnlYear_Term.ResumeLayout(false);
            this.pnlYear_Term.PerformLayout();
            this.pnlCapacity.ResumeLayout(false);
            this.pnlCapacity.PerformLayout();
            this.pnlLesson.ResumeLayout(false);
            this.pnlLesson.PerformLayout();
            this.pnlWeek.ResumeLayout(false);
            this.pnlWeek.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlCollege;
        private System.Windows.Forms.ComboBox cmbCollege;
        private System.Windows.Forms.Label lblCollege;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.Button btnSelectTeacher;
        private System.Windows.Forms.Panel pnlTeacher;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.RadioButton rdbBahman;
        private System.Windows.Forms.RadioButton rdbMehr;
        private System.Windows.Forms.RadioButton rdbTabestan;
        private System.Windows.Forms.Panel pnlYear_Term;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Panel pnlCapacity;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Panel pnlLesson;
        private System.Windows.Forms.Label lblLesson;
        private System.Windows.Forms.ComboBox cmbLesson;
        private System.Windows.Forms.Panel pnlWeek;
        private System.Windows.Forms.Label lblDayOfWeek;
        private System.Windows.Forms.ComboBox cmbWeek;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblFinishTime;
        private System.Windows.Forms.DateTimePicker dtpFinishTime;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label lblAlert;
    }
}