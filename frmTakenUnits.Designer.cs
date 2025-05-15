namespace University
{
    partial class frmTakenUnits
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
            this.dgvClassRoom = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.clmClassRoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLessonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLessonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCollegeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCollegeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfinishTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIsPassed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassRoom)).BeginInit();
            this.SuspendLayout();
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
            this.clmTeacherName,
            this.clmLessonId,
            this.clmLessonName,
            this.clmCollegeName,
            this.clmCollegeId,
            this.clmUnit,
            this.clmYear,
            this.clmTerm,
            this.clmDay,
            this.clmStartTime,
            this.clmfinishTime,
            this.clmIsPassed});
            this.dgvClassRoom.Location = new System.Drawing.Point(-2, 325);
            this.dgvClassRoom.Name = "dgvClassRoom";
            this.dgvClassRoom.ReadOnly = true;
            this.dgvClassRoom.Size = new System.Drawing.Size(1266, 545);
            this.dgvClassRoom.TabIndex = 12;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(505, 87);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(253, 37);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "واحد های گذرانده شده";
            // 
            // clmClassRoomId
            // 
            this.clmClassRoomId.HeaderText = "کد کلاس";
            this.clmClassRoomId.Name = "clmClassRoomId";
            this.clmClassRoomId.ReadOnly = true;
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
            // clmUnit
            // 
            this.clmUnit.HeaderText = "واحد";
            this.clmUnit.Name = "clmUnit";
            this.clmUnit.ReadOnly = true;
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
            // clmIsPassed
            // 
            this.clmIsPassed.HeaderText = "قبولی";
            this.clmIsPassed.Name = "clmIsPassed";
            this.clmIsPassed.ReadOnly = true;
            // 
            // frmTakenUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 866);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvClassRoom);
            this.Name = "frmTakenUnits";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frmTakenUnits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClassRoom;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClassRoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLessonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLessonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCollegeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCollegeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfinishTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmIsPassed;
    }
}