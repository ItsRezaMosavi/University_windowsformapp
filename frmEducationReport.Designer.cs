namespace University
{
    partial class frmEducationReport
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
            this.pnlScores = new System.Windows.Forms.Panel();
            this.dgvScore = new System.Windows.Forms.DataGridView();
            this.clmClassRoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLesson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmClassScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMidTermScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFinalScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIsPass = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlIdentity = new System.Windows.Forms.Panel();
            this.lblThisTermAverage = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblFathersName = new System.Windows.Forms.Label();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.pnlScores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScore)).BeginInit();
            this.pnlIdentity.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlScores
            // 
            this.pnlScores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlScores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlScores.Controls.Add(this.dgvScore);
            this.pnlScores.Location = new System.Drawing.Point(9, 378);
            this.pnlScores.Name = "pnlScores";
            this.pnlScores.Size = new System.Drawing.Size(1145, 498);
            this.pnlScores.TabIndex = 1;
            // 
            // dgvScore
            // 
            this.dgvScore.AllowUserToAddRows = false;
            this.dgvScore.AllowUserToDeleteRows = false;
            this.dgvScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmClassRoomId,
            this.clmLesson,
            this.clmTeacherName,
            this.clmYear,
            this.clmTerm,
            this.clmUnit,
            this.clmClassScore,
            this.clmMidTermScore,
            this.clmFinalScore,
            this.clmAverage,
            this.clmIsPass});
            this.dgvScore.Location = new System.Drawing.Point(-2, 91);
            this.dgvScore.Name = "dgvScore";
            this.dgvScore.ReadOnly = true;
            this.dgvScore.Size = new System.Drawing.Size(1145, 405);
            this.dgvScore.TabIndex = 10;
            this.dgvScore.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            // 
            // clmClassRoomId
            // 
            this.clmClassRoomId.HeaderText = "کد کلاس";
            this.clmClassRoomId.Name = "clmClassRoomId";
            this.clmClassRoomId.ReadOnly = true;
            // 
            // clmLesson
            // 
            this.clmLesson.HeaderText = "نام درس";
            this.clmLesson.Name = "clmLesson";
            this.clmLesson.ReadOnly = true;
            // 
            // clmTeacherName
            // 
            this.clmTeacherName.HeaderText = "نام استاد";
            this.clmTeacherName.Name = "clmTeacherName";
            this.clmTeacherName.ReadOnly = true;
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
            // clmUnit
            // 
            this.clmUnit.HeaderText = "واحد";
            this.clmUnit.Name = "clmUnit";
            this.clmUnit.ReadOnly = true;
            // 
            // clmClassScore
            // 
            this.clmClassScore.HeaderText = "نمره کلاسی";
            this.clmClassScore.Name = "clmClassScore";
            this.clmClassScore.ReadOnly = true;
            // 
            // clmMidTermScore
            // 
            this.clmMidTermScore.HeaderText = "نمره میان ترم";
            this.clmMidTermScore.Name = "clmMidTermScore";
            this.clmMidTermScore.ReadOnly = true;
            // 
            // clmFinalScore
            // 
            this.clmFinalScore.HeaderText = "نمره پایان ترم";
            this.clmFinalScore.Name = "clmFinalScore";
            this.clmFinalScore.ReadOnly = true;
            // 
            // clmAverage
            // 
            this.clmAverage.HeaderText = "نمره نهایی";
            this.clmAverage.Name = "clmAverage";
            this.clmAverage.ReadOnly = true;
            // 
            // clmIsPass
            // 
            this.clmIsPass.HeaderText = "قبولی";
            this.clmIsPass.Name = "clmIsPass";
            this.clmIsPass.ReadOnly = true;
            // 
            // pnlIdentity
            // 
            this.pnlIdentity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlIdentity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlIdentity.Controls.Add(this.lblThisTermAverage);
            this.pnlIdentity.Controls.Add(this.lblAverage);
            this.pnlIdentity.Controls.Add(this.lblGender);
            this.pnlIdentity.Controls.Add(this.lblFathersName);
            this.pnlIdentity.Controls.Add(this.lblNationalCode);
            this.pnlIdentity.Controls.Add(this.lblLastName);
            this.pnlIdentity.Controls.Add(this.lblFirstName);
            this.pnlIdentity.Location = new System.Drawing.Point(9, 87);
            this.pnlIdentity.Name = "pnlIdentity";
            this.pnlIdentity.Size = new System.Drawing.Size(1145, 285);
            this.pnlIdentity.TabIndex = 2;
            // 
            // lblThisTermAverage
            // 
            this.lblThisTermAverage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThisTermAverage.AutoSize = true;
            this.lblThisTermAverage.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThisTermAverage.Location = new System.Drawing.Point(425, 202);
            this.lblThisTermAverage.Name = "lblThisTermAverage";
            this.lblThisTermAverage.Size = new System.Drawing.Size(145, 33);
            this.lblThisTermAverage.TabIndex = 7;
            this.lblThisTermAverage.Text = "معدل این ترم :";
            // 
            // lblAverage
            // 
            this.lblAverage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(767, 202);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(108, 33);
            this.lblAverage.TabIndex = 6;
            this.lblAverage.Text = "معدل کل :";
            // 
            // lblGender
            // 
            this.lblGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(1022, 202);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(99, 33);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "جنسیت :";
            // 
            // lblFathersName
            // 
            this.lblFathersName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFathersName.AutoSize = true;
            this.lblFathersName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFathersName.Location = new System.Drawing.Point(217, 87);
            this.lblFathersName.Name = "lblFathersName";
            this.lblFathersName.Size = new System.Drawing.Size(88, 33);
            this.lblFathersName.TabIndex = 4;
            this.lblFathersName.Text = "نام پدر :";
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNationalCode.AutoSize = true;
            this.lblNationalCode.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalCode.Location = new System.Drawing.Point(480, 87);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.Size = new System.Drawing.Size(90, 33);
            this.lblNationalCode.TabIndex = 3;
            this.lblNationalCode.Text = "کد ملی :";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(767, 87);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(134, 33);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "نام خانوادگی :";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(1068, 87);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(53, 33);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "نام :";
            // 
            // frmEducationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 878);
            this.Controls.Add(this.pnlIdentity);
            this.Controls.Add(this.pnlScores);
            this.Name = "frmEducationReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frmEducationReport_Load);
            this.pnlScores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScore)).EndInit();
            this.pnlIdentity.ResumeLayout(false);
            this.pnlIdentity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlScores;
        private System.Windows.Forms.DataGridView dgvScore;
        private System.Windows.Forms.Panel pnlIdentity;
        private System.Windows.Forms.Label lblThisTermAverage;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblFathersName;
        private System.Windows.Forms.Label lblNationalCode;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClassRoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLesson;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClassScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMidTermScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFinalScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAverage;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmIsPass;
    }
}