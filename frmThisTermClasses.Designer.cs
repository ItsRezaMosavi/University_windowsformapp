namespace University
{
    partial class frmThisTermClasses
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
            this.lblThisTermClasses = new System.Windows.Forms.Label();
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
            this.clmfinishTime});
            this.dgvClassRoom.Location = new System.Drawing.Point(0, 130);
            this.dgvClassRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvClassRoom.Name = "dgvClassRoom";
            this.dgvClassRoom.ReadOnly = true;
            this.dgvClassRoom.RowHeadersWidth = 51;
            this.dgvClassRoom.Size = new System.Drawing.Size(1525, 671);
            this.dgvClassRoom.TabIndex = 11;
            // 
            // clmClassRoomId
            // 
            this.clmClassRoomId.HeaderText = "کد کلاس";
            this.clmClassRoomId.MinimumWidth = 6;
            this.clmClassRoomId.Name = "clmClassRoomId";
            this.clmClassRoomId.ReadOnly = true;
            this.clmClassRoomId.Width = 125;
            // 
            // clmTeacherName
            // 
            this.clmTeacherName.HeaderText = "نام استاد";
            this.clmTeacherName.MinimumWidth = 6;
            this.clmTeacherName.Name = "clmTeacherName";
            this.clmTeacherName.ReadOnly = true;
            this.clmTeacherName.Width = 125;
            // 
            // clmLessonId
            // 
            this.clmLessonId.HeaderText = "کد درس";
            this.clmLessonId.MinimumWidth = 6;
            this.clmLessonId.Name = "clmLessonId";
            this.clmLessonId.ReadOnly = true;
            this.clmLessonId.Width = 125;
            // 
            // clmLessonName
            // 
            this.clmLessonName.HeaderText = "نام درس";
            this.clmLessonName.MinimumWidth = 6;
            this.clmLessonName.Name = "clmLessonName";
            this.clmLessonName.ReadOnly = true;
            this.clmLessonName.Width = 125;
            // 
            // clmCollegeName
            // 
            this.clmCollegeName.HeaderText = "نام دانشکده";
            this.clmCollegeName.MinimumWidth = 6;
            this.clmCollegeName.Name = "clmCollegeName";
            this.clmCollegeName.ReadOnly = true;
            this.clmCollegeName.Width = 125;
            // 
            // clmCollegeId
            // 
            this.clmCollegeId.HeaderText = "کد دانشکده";
            this.clmCollegeId.MinimumWidth = 6;
            this.clmCollegeId.Name = "clmCollegeId";
            this.clmCollegeId.ReadOnly = true;
            this.clmCollegeId.Width = 125;
            // 
            // clmUnit
            // 
            this.clmUnit.HeaderText = "واحد";
            this.clmUnit.MinimumWidth = 6;
            this.clmUnit.Name = "clmUnit";
            this.clmUnit.ReadOnly = true;
            this.clmUnit.Width = 125;
            // 
            // clmYear
            // 
            this.clmYear.HeaderText = "سال";
            this.clmYear.MinimumWidth = 6;
            this.clmYear.Name = "clmYear";
            this.clmYear.ReadOnly = true;
            this.clmYear.Width = 125;
            // 
            // clmTerm
            // 
            this.clmTerm.HeaderText = "ترم";
            this.clmTerm.MinimumWidth = 6;
            this.clmTerm.Name = "clmTerm";
            this.clmTerm.ReadOnly = true;
            this.clmTerm.Width = 125;
            // 
            // clmDay
            // 
            this.clmDay.HeaderText = "روز";
            this.clmDay.MinimumWidth = 6;
            this.clmDay.Name = "clmDay";
            this.clmDay.ReadOnly = true;
            this.clmDay.Width = 125;
            // 
            // clmStartTime
            // 
            this.clmStartTime.HeaderText = "ساعت شروع کلاس";
            this.clmStartTime.MinimumWidth = 6;
            this.clmStartTime.Name = "clmStartTime";
            this.clmStartTime.ReadOnly = true;
            this.clmStartTime.Width = 125;
            // 
            // clmfinishTime
            // 
            this.clmfinishTime.HeaderText = "ساعت پایان کلاس";
            this.clmfinishTime.MinimumWidth = 6;
            this.clmfinishTime.Name = "clmfinishTime";
            this.clmfinishTime.ReadOnly = true;
            this.clmfinishTime.Width = 125;
            // 
            // lblThisTermClasses
            // 
            this.lblThisTermClasses.AutoSize = true;
            this.lblThisTermClasses.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThisTermClasses.Location = new System.Drawing.Point(677, 75);
            this.lblThisTermClasses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThisTermClasses.Name = "lblThisTermClasses";
            this.lblThisTermClasses.Size = new System.Drawing.Size(244, 41);
            this.lblThisTermClasses.TabIndex = 12;
            this.lblThisTermClasses.Text = "کلاس های این ترم";
            // 
            // frmThisTermClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 802);
            this.Controls.Add(this.lblThisTermClasses);
            this.Controls.Add(this.dgvClassRoom);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmThisTermClasses";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frmThisTermClasses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClassRoom;
        private System.Windows.Forms.Label lblThisTermClasses;
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
    }
}