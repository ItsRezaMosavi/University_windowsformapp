namespace University
{
    partial class frmSendMessage
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
            this.pnlFrom = new System.Windows.Forms.Panel();
            this.lblFromName = new System.Windows.Forms.Label();
            this.lblFromUserName = new System.Windows.Forms.Label();
            this.txtFromUserName = new System.Windows.Forms.TextBox();
            this.txtFromName = new System.Windows.Forms.TextBox();
            this.pcbFromPhoto = new System.Windows.Forms.PictureBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.pnlTo = new System.Windows.Forms.Panel();
            this.lblToName = new System.Windows.Forms.Label();
            this.lblToUserName = new System.Windows.Forms.Label();
            this.txtToUserName = new System.Windows.Forms.TextBox();
            this.txtToName = new System.Windows.Forms.TextBox();
            this.pcbToPhoto = new System.Windows.Forms.PictureBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnSelectReceiver = new System.Windows.Forms.Button();
            this.pnlMessage = new System.Windows.Forms.Panel();
            this.btnAttachVideo = new System.Windows.Forms.Button();
            this.btnAttachFile = new System.Windows.Forms.Button();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.btnAttachPhoto = new System.Windows.Forms.Button();
            this.lblMessageText = new System.Windows.Forms.Label();
            this.txtMessageText = new System.Windows.Forms.TextBox();
            this.txtMessageTitle = new System.Windows.Forms.TextBox();
            this.lblMessageTitle = new System.Windows.Forms.Label();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.clmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFrom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFromPhoto)).BeginInit();
            this.pnlTo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbToPhoto)).BeginInit();
            this.pnlMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(540, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(130, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ارسال پیام";
            // 
            // pnlFrom
            // 
            this.pnlFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFrom.Controls.Add(this.lblFromName);
            this.pnlFrom.Controls.Add(this.lblFromUserName);
            this.pnlFrom.Controls.Add(this.txtFromUserName);
            this.pnlFrom.Controls.Add(this.txtFromName);
            this.pnlFrom.Controls.Add(this.pcbFromPhoto);
            this.pnlFrom.Controls.Add(this.lblFrom);
            this.pnlFrom.Location = new System.Drawing.Point(142, 90);
            this.pnlFrom.Name = "pnlFrom";
            this.pnlFrom.Size = new System.Drawing.Size(1023, 100);
            this.pnlFrom.TabIndex = 1;
            this.pnlFrom.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFrom_Paint);
            // 
            // lblFromName
            // 
            this.lblFromName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblFromName.AutoSize = true;
            this.lblFromName.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromName.Location = new System.Drawing.Point(768, 30);
            this.lblFromName.Name = "lblFromName";
            this.lblFromName.Size = new System.Drawing.Size(57, 45);
            this.lblFromName.TabIndex = 5;
            this.lblFromName.Text = "نام :";
            // 
            // lblFromUserName
            // 
            this.lblFromUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblFromUserName.AutoSize = true;
            this.lblFromUserName.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromUserName.Location = new System.Drawing.Point(335, 30);
            this.lblFromUserName.Name = "lblFromUserName";
            this.lblFromUserName.Size = new System.Drawing.Size(127, 45);
            this.lblFromUserName.TabIndex = 4;
            this.lblFromUserName.Text = "کد کاربری :";
            // 
            // txtFromUserName
            // 
            this.txtFromUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFromUserName.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromUserName.Location = new System.Drawing.Point(12, 33);
            this.txtFromUserName.Name = "txtFromUserName";
            this.txtFromUserName.ReadOnly = true;
            this.txtFromUserName.Size = new System.Drawing.Size(308, 39);
            this.txtFromUserName.TabIndex = 3;
            // 
            // txtFromName
            // 
            this.txtFromName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFromName.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromName.Location = new System.Drawing.Point(483, 33);
            this.txtFromName.Name = "txtFromName";
            this.txtFromName.ReadOnly = true;
            this.txtFromName.Size = new System.Drawing.Size(270, 39);
            this.txtFromName.TabIndex = 2;
            // 
            // pcbFromPhoto
            // 
            this.pcbFromPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pcbFromPhoto.Location = new System.Drawing.Point(841, 3);
            this.pcbFromPhoto.Name = "pcbFromPhoto";
            this.pcbFromPhoto.Size = new System.Drawing.Size(108, 90);
            this.pcbFromPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFromPhoto.TabIndex = 1;
            this.pcbFromPhoto.TabStop = false;
            // 
            // lblFrom
            // 
            this.lblFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(967, 30);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(49, 45);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "از :";
            // 
            // pnlTo
            // 
            this.pnlTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTo.Controls.Add(this.lblToName);
            this.pnlTo.Controls.Add(this.btnSelectReceiver);
            this.pnlTo.Controls.Add(this.lblToUserName);
            this.pnlTo.Controls.Add(this.txtToUserName);
            this.pnlTo.Controls.Add(this.txtToName);
            this.pnlTo.Controls.Add(this.pcbToPhoto);
            this.pnlTo.Controls.Add(this.lblTo);
            this.pnlTo.Location = new System.Drawing.Point(12, 196);
            this.pnlTo.Name = "pnlTo";
            this.pnlTo.Size = new System.Drawing.Size(1153, 96);
            this.pnlTo.TabIndex = 2;
            this.pnlTo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTo_Paint);
            // 
            // lblToName
            // 
            this.lblToName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblToName.AutoSize = true;
            this.lblToName.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToName.Location = new System.Drawing.Point(898, 27);
            this.lblToName.Name = "lblToName";
            this.lblToName.Size = new System.Drawing.Size(57, 45);
            this.lblToName.TabIndex = 7;
            this.lblToName.Text = "نام :";
            // 
            // lblToUserName
            // 
            this.lblToUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblToUserName.AutoSize = true;
            this.lblToUserName.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToUserName.Location = new System.Drawing.Point(465, 24);
            this.lblToUserName.Name = "lblToUserName";
            this.lblToUserName.Size = new System.Drawing.Size(127, 45);
            this.lblToUserName.TabIndex = 6;
            this.lblToUserName.Text = "کد کاربری :";
            // 
            // txtToUserName
            // 
            this.txtToUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToUserName.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToUserName.Location = new System.Drawing.Point(142, 27);
            this.txtToUserName.Name = "txtToUserName";
            this.txtToUserName.ReadOnly = true;
            this.txtToUserName.Size = new System.Drawing.Size(308, 39);
            this.txtToUserName.TabIndex = 3;
            // 
            // txtToName
            // 
            this.txtToName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToName.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToName.Location = new System.Drawing.Point(612, 27);
            this.txtToName.Name = "txtToName";
            this.txtToName.ReadOnly = true;
            this.txtToName.Size = new System.Drawing.Size(270, 39);
            this.txtToName.TabIndex = 2;
            // 
            // pcbToPhoto
            // 
            this.pcbToPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pcbToPhoto.Location = new System.Drawing.Point(971, 3);
            this.pcbToPhoto.Name = "pcbToPhoto";
            this.pcbToPhoto.Size = new System.Drawing.Size(108, 86);
            this.pcbToPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbToPhoto.TabIndex = 1;
            this.pcbToPhoto.TabStop = false;
            // 
            // lblTo
            // 
            this.lblTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(1093, 24);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(52, 45);
            this.lblTo.TabIndex = 0;
            this.lblTo.Text = "به :";
            // 
            // btnSelectReceiver
            // 
            this.btnSelectReceiver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectReceiver.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectReceiver.Location = new System.Drawing.Point(3, 15);
            this.btnSelectReceiver.Name = "btnSelectReceiver";
            this.btnSelectReceiver.Size = new System.Drawing.Size(135, 66);
            this.btnSelectReceiver.TabIndex = 3;
            this.btnSelectReceiver.Text = "انتخاب مقصد";
            this.btnSelectReceiver.UseVisualStyleBackColor = true;
            this.btnSelectReceiver.Click += new System.EventHandler(this.btnSelectReceiver_Click);
            // 
            // pnlMessage
            // 
            this.pnlMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMessage.Controls.Add(this.dgvFiles);
            this.pnlMessage.Controls.Add(this.btnAttachFile);
            this.pnlMessage.Controls.Add(this.btnAttachVideo);
            this.pnlMessage.Controls.Add(this.lblMessageText);
            this.pnlMessage.Controls.Add(this.txtMessageText);
            this.pnlMessage.Controls.Add(this.txtMessageTitle);
            this.pnlMessage.Controls.Add(this.btnAttachPhoto);
            this.pnlMessage.Controls.Add(this.lblMessageTitle);
            this.pnlMessage.Location = new System.Drawing.Point(12, 303);
            this.pnlMessage.Name = "pnlMessage";
            this.pnlMessage.Size = new System.Drawing.Size(1153, 658);
            this.pnlMessage.TabIndex = 4;
            this.pnlMessage.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMessage_Paint);
            // 
            // btnAttachVideo
            // 
            this.btnAttachVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAttachVideo.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAttachVideo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttachVideo.Location = new System.Drawing.Point(130, 21);
            this.btnAttachVideo.Name = "btnAttachVideo";
            this.btnAttachVideo.Size = new System.Drawing.Size(108, 52);
            this.btnAttachVideo.TabIndex = 8;
            this.btnAttachVideo.Text = "درج ویدیو";
            this.btnAttachVideo.UseVisualStyleBackColor = false;
            this.btnAttachVideo.Click += new System.EventHandler(this.btnAttachVideo_Click);
            // 
            // btnAttachFile
            // 
            this.btnAttachFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAttachFile.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAttachFile.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttachFile.Location = new System.Drawing.Point(16, 21);
            this.btnAttachFile.Name = "btnAttachFile";
            this.btnAttachFile.Size = new System.Drawing.Size(108, 52);
            this.btnAttachFile.TabIndex = 7;
            this.btnAttachFile.Text = "درج فایل";
            this.btnAttachFile.UseVisualStyleBackColor = false;
            this.btnAttachFile.Click += new System.EventHandler(this.btnAttachFile_Click);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSendMessage.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSendMessage.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMessage.Location = new System.Drawing.Point(12, 976);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(212, 73);
            this.btnSendMessage.TabIndex = 5;
            this.btnSendMessage.Text = "ارسال";
            this.btnSendMessage.UseVisualStyleBackColor = false;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // btnAttachPhoto
            // 
            this.btnAttachPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAttachPhoto.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAttachPhoto.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttachPhoto.Location = new System.Drawing.Point(244, 21);
            this.btnAttachPhoto.Name = "btnAttachPhoto";
            this.btnAttachPhoto.Size = new System.Drawing.Size(108, 52);
            this.btnAttachPhoto.TabIndex = 6;
            this.btnAttachPhoto.Text = "درج عکس";
            this.btnAttachPhoto.UseVisualStyleBackColor = false;
            this.btnAttachPhoto.Click += new System.EventHandler(this.btnAttachPhoto_Click);
            // 
            // lblMessageText
            // 
            this.lblMessageText.AutoSize = true;
            this.lblMessageText.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageText.Location = new System.Drawing.Point(1058, 88);
            this.lblMessageText.Name = "lblMessageText";
            this.lblMessageText.Size = new System.Drawing.Size(76, 33);
            this.lblMessageText.TabIndex = 5;
            this.lblMessageText.Text = "متن :";
            // 
            // txtMessageText
            // 
            this.txtMessageText.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageText.Location = new System.Drawing.Point(385, 86);
            this.txtMessageText.Multiline = true;
            this.txtMessageText.Name = "txtMessageText";
            this.txtMessageText.Size = new System.Drawing.Size(657, 565);
            this.txtMessageText.TabIndex = 4;
            // 
            // txtMessageTitle
            // 
            this.txtMessageTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageTitle.Location = new System.Drawing.Point(385, 27);
            this.txtMessageTitle.Name = "txtMessageTitle";
            this.txtMessageTitle.Size = new System.Drawing.Size(657, 39);
            this.txtMessageTitle.TabIndex = 3;
            // 
            // lblMessageTitle
            // 
            this.lblMessageTitle.AutoSize = true;
            this.lblMessageTitle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageTitle.Location = new System.Drawing.Point(1048, 29);
            this.lblMessageTitle.Name = "lblMessageTitle";
            this.lblMessageTitle.Size = new System.Drawing.Size(95, 33);
            this.lblMessageTitle.TabIndex = 0;
            this.lblMessageTitle.Text = "عنوان :";
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToDeleteRows = false;
            this.dgvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmType,
            this.clmName});
            this.dgvFiles.Location = new System.Drawing.Point(16, 88);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.ReadOnly = true;
            this.dgvFiles.Size = new System.Drawing.Size(336, 563);
            this.dgvFiles.TabIndex = 9;
            // 
            // clmType
            // 
            this.clmType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmType.HeaderText = "نوع";
            this.clmType.Name = "clmType";
            this.clmType.ReadOnly = true;
            this.clmType.Width = 49;
            // 
            // clmName
            // 
            this.clmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmName.HeaderText = "نام فایل";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 69;
            // 
            // frmSendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 1061);
            this.Controls.Add(this.pnlMessage);
            this.Controls.Add(this.pnlTo);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.pnlFrom);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmSendMessage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmSendMessage_Load);
            this.pnlFrom.ResumeLayout(false);
            this.pnlFrom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFromPhoto)).EndInit();
            this.pnlTo.ResumeLayout(false);
            this.pnlTo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbToPhoto)).EndInit();
            this.pnlMessage.ResumeLayout(false);
            this.pnlMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFrom;
        private System.Windows.Forms.TextBox txtFromName;
        private System.Windows.Forms.PictureBox pcbFromPhoto;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox txtFromUserName;
        private System.Windows.Forms.Panel pnlTo;
        private System.Windows.Forms.TextBox txtToUserName;
        private System.Windows.Forms.TextBox txtToName;
        private System.Windows.Forms.PictureBox pcbToPhoto;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFromName;
        private System.Windows.Forms.Label lblFromUserName;
        private System.Windows.Forms.Label lblToName;
        private System.Windows.Forms.Label lblToUserName;
        private System.Windows.Forms.Button btnSelectReceiver;
        private System.Windows.Forms.Panel pnlMessage;
        private System.Windows.Forms.Label lblMessageTitle;
        private System.Windows.Forms.Label lblMessageText;
        private System.Windows.Forms.TextBox txtMessageText;
        private System.Windows.Forms.TextBox txtMessageTitle;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Button btnAttachPhoto;
        private System.Windows.Forms.Button btnAttachVideo;
        private System.Windows.Forms.Button btnAttachFile;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
    }
}