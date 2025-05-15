namespace University
{
    partial class frmLoginLogoutReport
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
            this.dgvEnterOutReport = new System.Windows.Forms.DataGridView();
            this.clmUserPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLoginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLoginTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLogoutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWorkTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnterOutReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEnterOutReport
            // 
            this.dgvEnterOutReport.AllowUserToAddRows = false;
            this.dgvEnterOutReport.AllowUserToDeleteRows = false;
            this.dgvEnterOutReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnterOutReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmUserPhoto,
            this.clmUserName,
            this.clmFirstName,
            this.clmLastName,
            this.clmType,
            this.clmLoginDate,
            this.clmLoginTime,
            this.clmLogoutTime,
            this.clmWorkTime});
            this.dgvEnterOutReport.Location = new System.Drawing.Point(-1, 305);
            this.dgvEnterOutReport.Name = "dgvEnterOutReport";
            this.dgvEnterOutReport.ReadOnly = true;
            this.dgvEnterOutReport.Size = new System.Drawing.Size(1097, 426);
            this.dgvEnterOutReport.TabIndex = 0;
            // 
            // clmUserPhoto
            // 
            this.clmUserPhoto.HeaderText = "عکس کاربر";
            this.clmUserPhoto.Name = "clmUserPhoto";
            this.clmUserPhoto.ReadOnly = true;
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
            // clmType
            // 
            this.clmType.HeaderText = "نوع کاربر";
            this.clmType.Name = "clmType";
            this.clmType.ReadOnly = true;
            // 
            // clmLoginDate
            // 
            this.clmLoginDate.HeaderText = "تاریخ ورود";
            this.clmLoginDate.Name = "clmLoginDate";
            this.clmLoginDate.ReadOnly = true;
            // 
            // clmLoginTime
            // 
            this.clmLoginTime.HeaderText = "زمان ورود";
            this.clmLoginTime.Name = "clmLoginTime";
            this.clmLoginTime.ReadOnly = true;
            // 
            // clmLogoutTime
            // 
            this.clmLogoutTime.HeaderText = "زمان خروج";
            this.clmLogoutTime.Name = "clmLogoutTime";
            this.clmLogoutTime.ReadOnly = true;
            // 
            // clmWorkTime
            // 
            this.clmWorkTime.HeaderText = "زمان حضور در سیستم";
            this.clmWorkTime.Name = "clmWorkTime";
            this.clmWorkTime.ReadOnly = true;
            // 
            // frmLoginLogoutReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 730);
            this.Controls.Add(this.dgvEnterOutReport);
            this.Name = "frmLoginLogoutReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frmLoginLogoutReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnterOutReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEnterOutReport;
        private System.Windows.Forms.DataGridViewImageColumn clmUserPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLoginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLoginTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLogoutTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWorkTime;
    }
}