namespace University
{
    partial class frmScores
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnlStudent = new System.Windows.Forms.Panel();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.clmPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCollege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmClassRoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLesson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmClassScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMidTermScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFinalScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRecordScores = new System.Windows.Forms.Button();
            this.pnlStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(561, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "نمرات";
            // 
            // pnlStudent
            // 
            this.pnlStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlStudent.Controls.Add(this.dgvStudent);
            this.pnlStudent.Enabled = false;
            this.pnlStudent.Location = new System.Drawing.Point(1, 162);
            this.pnlStudent.Name = "pnlStudent";
            this.pnlStudent.Size = new System.Drawing.Size(1249, 555);
            this.pnlStudent.TabIndex = 37;
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
            this.clmFirstName,
            this.clmLastName,
            this.clmGender,
            this.clmCollege,
            this.clmClassRoomId,
            this.clmLesson,
            this.clmClassScore,
            this.clmMidTermScore,
            this.clmFinalScore,
            this.clmAverage});
            this.dgvStudent.Location = new System.Drawing.Point(-2, 72);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.Size = new System.Drawing.Size(1249, 481);
            this.dgvStudent.TabIndex = 9;
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            this.dgvStudent.DoubleClick += new System.EventHandler(this.dgvStudent_DoubleClick);
            // 
            // clmPhoto
            // 
            this.clmPhoto.HeaderText = "عکس کاربر";
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
            // clmGender
            // 
            this.clmGender.HeaderText = "جنسیت";
            this.clmGender.Name = "clmGender";
            this.clmGender.ReadOnly = true;
            // 
            // clmCollege
            // 
            this.clmCollege.HeaderText = "دانشکده";
            this.clmCollege.Name = "clmCollege";
            this.clmCollege.ReadOnly = true;
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
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(34, 35);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(149, 59);
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "برگشت";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRecordScores
            // 
            this.btnRecordScores.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordScores.Location = new System.Drawing.Point(938, 41);
            this.btnRecordScores.Name = "btnRecordScores";
            this.btnRecordScores.Size = new System.Drawing.Size(277, 93);
            this.btnRecordScores.TabIndex = 39;
            this.btnRecordScores.Text = "ثبت نهایی نمرات کلاس";
            this.btnRecordScores.UseVisualStyleBackColor = true;
            this.btnRecordScores.Click += new System.EventHandler(this.btnRecordScores_Click);
            // 
            // frmScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 716);
            this.Controls.Add(this.btnRecordScores);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlStudent);
            this.Controls.Add(this.label1);
            this.Name = "frmScores";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmScores";
            this.Load += new System.EventHandler(this.frmScores_Load);
            this.pnlStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlStudent;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewImageColumn clmPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCollege;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClassRoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLesson;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClassScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMidTermScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFinalScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAverage;
        private System.Windows.Forms.Button btnRecordScores;
    }
}