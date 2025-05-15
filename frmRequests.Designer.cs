namespace University
{
    partial class frmRequests
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
            this.lblRequestType = new System.Windows.Forms.Label();
            this.cmbRequestType = new System.Windows.Forms.ComboBox();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.clmUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubmissionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTrackingCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pnlRequest = new System.Windows.Forms.Panel();
            this.pnlPhoto = new System.Windows.Forms.Panel();
            this.lblNewPhoto = new System.Windows.Forms.Label();
            this.lblPrevPhoto = new System.Windows.Forms.Label();
            this.pcbNextPhoto = new System.Windows.Forms.PictureBox();
            this.pcbPrevPhoto = new System.Windows.Forms.PictureBox();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.lblDetail = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.rdbPending = new System.Windows.Forms.RadioButton();
            this.rdbReject = new System.Windows.Forms.RadioButton();
            this.rdbApproved = new System.Windows.Forms.RadioButton();
            this.btnRegister = new System.Windows.Forms.Button();
            this.chbFilterApprovedAndRejected = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.pnlRequest.SuspendLayout();
            this.pnlPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNextPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPrevPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRequestType
            // 
            this.lblRequestType.AutoSize = true;
            this.lblRequestType.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestType.Location = new System.Drawing.Point(1015, 68);
            this.lblRequestType.Name = "lblRequestType";
            this.lblRequestType.Size = new System.Drawing.Size(62, 32);
            this.lblRequestType.TabIndex = 0;
            this.lblRequestType.Text = "نوع :";
            // 
            // cmbRequestType
            // 
            this.cmbRequestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRequestType.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRequestType.FormattingEnabled = true;
            this.cmbRequestType.Location = new System.Drawing.Point(773, 68);
            this.cmbRequestType.Name = "cmbRequestType";
            this.cmbRequestType.Size = new System.Drawing.Size(216, 33);
            this.cmbRequestType.TabIndex = 1;
            this.cmbRequestType.SelectedIndexChanged += new System.EventHandler(this.cmbRequestType_SelectedIndexChanged);
            // 
            // dgvRequests
            // 
            this.dgvRequests.AllowUserToAddRows = false;
            this.dgvRequests.AllowUserToDeleteRows = false;
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmUserId,
            this.clmStatus,
            this.clmSubmissionDate,
            this.clmTrackingCode});
            this.dgvRequests.Location = new System.Drawing.Point(605, 229);
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.ReadOnly = true;
            this.dgvRequests.Size = new System.Drawing.Size(490, 535);
            this.dgvRequests.TabIndex = 2;
            // 
            // clmUserId
            // 
            this.clmUserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmUserId.HeaderText = "کد دانشجویی";
            this.clmUserId.Name = "clmUserId";
            this.clmUserId.ReadOnly = true;
            this.clmUserId.Width = 95;
            // 
            // clmStatus
            // 
            this.clmStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmStatus.HeaderText = "وضعیت";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
            this.clmStatus.Width = 65;
            // 
            // clmSubmissionDate
            // 
            this.clmSubmissionDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmSubmissionDate.HeaderText = "تاریخ ثبت";
            this.clmSubmissionDate.Name = "clmSubmissionDate";
            this.clmSubmissionDate.ReadOnly = true;
            this.clmSubmissionDate.Width = 76;
            // 
            // clmTrackingCode
            // 
            this.clmTrackingCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmTrackingCode.HeaderText = "کد رهگیری";
            this.clmTrackingCode.Name = "clmTrackingCode";
            this.clmTrackingCode.ReadOnly = true;
            this.clmTrackingCode.Width = 85;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(612, 60);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(142, 52);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "انتخاب";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // pnlRequest
            // 
            this.pnlRequest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRequest.Controls.Add(this.pnlPhoto);
            this.pnlRequest.Controls.Add(this.txtDetail);
            this.pnlRequest.Controls.Add(this.lblDetail);
            this.pnlRequest.Controls.Add(this.txtDate);
            this.pnlRequest.Controls.Add(this.lblDate);
            this.pnlRequest.Controls.Add(this.txtUserId);
            this.pnlRequest.Controls.Add(this.lblUserId);
            this.pnlRequest.Controls.Add(this.txtName);
            this.pnlRequest.Controls.Add(this.lblName);
            this.pnlRequest.Controls.Add(this.rdbPending);
            this.pnlRequest.Controls.Add(this.rdbReject);
            this.pnlRequest.Controls.Add(this.rdbApproved);
            this.pnlRequest.Controls.Add(this.btnRegister);
            this.pnlRequest.Location = new System.Drawing.Point(12, 68);
            this.pnlRequest.Name = "pnlRequest";
            this.pnlRequest.Size = new System.Drawing.Size(585, 696);
            this.pnlRequest.TabIndex = 4;
            this.pnlRequest.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRequest_Paint);
            // 
            // pnlPhoto
            // 
            this.pnlPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPhoto.Controls.Add(this.lblNewPhoto);
            this.pnlPhoto.Controls.Add(this.lblPrevPhoto);
            this.pnlPhoto.Controls.Add(this.pcbNextPhoto);
            this.pnlPhoto.Controls.Add(this.pcbPrevPhoto);
            this.pnlPhoto.Location = new System.Drawing.Point(17, 365);
            this.pnlPhoto.Name = "pnlPhoto";
            this.pnlPhoto.Size = new System.Drawing.Size(540, 250);
            this.pnlPhoto.TabIndex = 12;
            this.pnlPhoto.Visible = false;
            // 
            // lblNewPhoto
            // 
            this.lblNewPhoto.AutoSize = true;
            this.lblNewPhoto.Location = new System.Drawing.Point(373, 211);
            this.lblNewPhoto.Name = "lblNewPhoto";
            this.lblNewPhoto.Size = new System.Drawing.Size(54, 13);
            this.lblNewPhoto.TabIndex = 3;
            this.lblNewPhoto.Text = "عکس جدید";
            // 
            // lblPrevPhoto
            // 
            this.lblPrevPhoto.AutoSize = true;
            this.lblPrevPhoto.Location = new System.Drawing.Point(106, 211);
            this.lblPrevPhoto.Name = "lblPrevPhoto";
            this.lblPrevPhoto.Size = new System.Drawing.Size(58, 13);
            this.lblPrevPhoto.TabIndex = 2;
            this.lblPrevPhoto.Text = "عکس فعلی";
            // 
            // pcbNextPhoto
            // 
            this.pcbNextPhoto.Location = new System.Drawing.Point(285, 17);
            this.pcbNextPhoto.Name = "pcbNextPhoto";
            this.pcbNextPhoto.Size = new System.Drawing.Size(238, 169);
            this.pcbNextPhoto.TabIndex = 1;
            this.pcbNextPhoto.TabStop = false;
            // 
            // pcbPrevPhoto
            // 
            this.pcbPrevPhoto.Location = new System.Drawing.Point(16, 17);
            this.pcbPrevPhoto.Name = "pcbPrevPhoto";
            this.pcbPrevPhoto.Size = new System.Drawing.Size(238, 169);
            this.pcbPrevPhoto.TabIndex = 0;
            this.pcbPrevPhoto.TabStop = false;
            // 
            // txtDetail
            // 
            this.txtDetail.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetail.Location = new System.Drawing.Point(70, 191);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.ReadOnly = true;
            this.txtDetail.Size = new System.Drawing.Size(365, 158);
            this.txtDetail.TabIndex = 11;
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail.Location = new System.Drawing.Point(455, 191);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(92, 25);
            this.lblDetail.TabIndex = 10;
            this.lblDetail.Text = "توضیحات :";
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(236, 134);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(199, 32);
            this.txtDate.TabIndex = 9;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(450, 134);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(60, 25);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "تاریخ :";
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(236, 33);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(199, 32);
            this.txtUserId.TabIndex = 7;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(450, 33);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(112, 25);
            this.lblUserId.TabIndex = 6;
            this.lblUserId.Text = "کد دانشجویی :";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(236, 81);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(199, 32);
            this.txtName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(450, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(97, 25);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "نام دانشجو :";
            // 
            // rdbPending
            // 
            this.rdbPending.AutoSize = true;
            this.rdbPending.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPending.Location = new System.Drawing.Point(410, 640);
            this.rdbPending.Name = "rdbPending";
            this.rdbPending.Size = new System.Drawing.Size(72, 30);
            this.rdbPending.TabIndex = 3;
            this.rdbPending.TabStop = true;
            this.rdbPending.Text = "معطل";
            this.rdbPending.UseVisualStyleBackColor = true;
            // 
            // rdbReject
            // 
            this.rdbReject.AutoSize = true;
            this.rdbReject.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbReject.Location = new System.Drawing.Point(312, 640);
            this.rdbReject.Name = "rdbReject";
            this.rdbReject.Size = new System.Drawing.Size(45, 30);
            this.rdbReject.TabIndex = 2;
            this.rdbReject.TabStop = true;
            this.rdbReject.Text = "رد";
            this.rdbReject.UseVisualStyleBackColor = true;
            // 
            // rdbApproved
            // 
            this.rdbApproved.AutoSize = true;
            this.rdbApproved.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbApproved.Location = new System.Drawing.Point(197, 640);
            this.rdbApproved.Name = "rdbApproved";
            this.rdbApproved.Size = new System.Drawing.Size(61, 30);
            this.rdbApproved.TabIndex = 1;
            this.rdbApproved.TabStop = true;
            this.rdbApproved.Text = "تایید";
            this.rdbApproved.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(17, 632);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(107, 43);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "ثبت";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // chbFilterApprovedAndRejected
            // 
            this.chbFilterApprovedAndRejected.AutoSize = true;
            this.chbFilterApprovedAndRejected.Checked = true;
            this.chbFilterApprovedAndRejected.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbFilterApprovedAndRejected.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFilterApprovedAndRejected.Location = new System.Drawing.Point(695, 151);
            this.chbFilterApprovedAndRejected.Name = "chbFilterApprovedAndRejected";
            this.chbFilterApprovedAndRejected.Size = new System.Drawing.Size(306, 35);
            this.chbFilterApprovedAndRejected.TabIndex = 5;
            this.chbFilterApprovedAndRejected.Text = "فقط بدون پاسخ ها را نمایش بده";
            this.chbFilterApprovedAndRejected.UseVisualStyleBackColor = true;
            this.chbFilterApprovedAndRejected.CheckedChanged += new System.EventHandler(this.chbFilterApprovedAndRejected_CheckedChanged);
            // 
            // frmRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 776);
            this.Controls.Add(this.chbFilterApprovedAndRejected);
            this.Controls.Add(this.pnlRequest);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dgvRequests);
            this.Controls.Add(this.cmbRequestType);
            this.Controls.Add(this.lblRequestType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "frmRequests";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frmRequests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.pnlRequest.ResumeLayout(false);
            this.pnlRequest.PerformLayout();
            this.pnlPhoto.ResumeLayout(false);
            this.pnlPhoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNextPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPrevPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequestType;
        private System.Windows.Forms.ComboBox cmbRequestType;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubmissionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTrackingCode;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel pnlRequest;
        private System.Windows.Forms.RadioButton rdbPending;
        private System.Windows.Forms.RadioButton rdbReject;
        private System.Windows.Forms.RadioButton rdbApproved;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Panel pnlPhoto;
        private System.Windows.Forms.Label lblNewPhoto;
        private System.Windows.Forms.Label lblPrevPhoto;
        private System.Windows.Forms.PictureBox pcbNextPhoto;
        private System.Windows.Forms.PictureBox pcbPrevPhoto;
        private System.Windows.Forms.CheckBox chbFilterApprovedAndRejected;
    }
}