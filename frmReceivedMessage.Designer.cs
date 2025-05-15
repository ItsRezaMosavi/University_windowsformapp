namespace University
{
    partial class frmReceivedMessage
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
            this.pnlFrom = new System.Windows.Forms.Panel();
            this.lblFromName = new System.Windows.Forms.Label();
            this.lblFromUserName = new System.Windows.Forms.Label();
            this.txtFromUserName = new System.Windows.Forms.TextBox();
            this.txtFromName = new System.Windows.Forms.TextBox();
            this.pcbFromPhoto = new System.Windows.Forms.PictureBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.pnlMessage = new System.Windows.Forms.Panel();
            this.btnDownload = new System.Windows.Forms.Button();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.clmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMessageText = new System.Windows.Forms.Label();
            this.txtMessageText = new System.Windows.Forms.TextBox();
            this.txtMessageTitle = new System.Windows.Forms.TextBox();
            this.lblMessageTitle = new System.Windows.Forms.Label();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.dgvUnSeenMessage = new System.Windows.Forms.DataGridView();
            this.clmSender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUnseenMessage = new System.Windows.Forms.Panel();
            this.lblMessages = new System.Windows.Forms.Label();
            this.pnlDateTime = new System.Windows.Forms.Panel();
            this.lblSendedTime = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlFrom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFromPhoto)).BeginInit();
            this.pnlMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnSeenMessage)).BeginInit();
            this.pnlUnseenMessage.SuspendLayout();
            this.pnlDateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFrom
            // 
            this.pnlFrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFrom.Controls.Add(this.lblFromName);
            this.pnlFrom.Controls.Add(this.lblFromUserName);
            this.pnlFrom.Controls.Add(this.txtFromUserName);
            this.pnlFrom.Controls.Add(this.txtFromName);
            this.pnlFrom.Controls.Add(this.pcbFromPhoto);
            this.pnlFrom.Controls.Add(this.lblFrom);
            this.pnlFrom.Location = new System.Drawing.Point(58, 82);
            this.pnlFrom.Name = "pnlFrom";
            this.pnlFrom.Size = new System.Drawing.Size(1023, 100);
            this.pnlFrom.TabIndex = 2;
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
            // pnlMessage
            // 
            this.pnlMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMessage.Controls.Add(this.btnDownload);
            this.pnlMessage.Controls.Add(this.dgvFiles);
            this.pnlMessage.Controls.Add(this.lblMessageText);
            this.pnlMessage.Controls.Add(this.txtMessageText);
            this.pnlMessage.Controls.Add(this.txtMessageTitle);
            this.pnlMessage.Controls.Add(this.lblMessageTitle);
            this.pnlMessage.Location = new System.Drawing.Point(12, 188);
            this.pnlMessage.Name = "pnlMessage";
            this.pnlMessage.Size = new System.Drawing.Size(1106, 658);
            this.pnlMessage.TabIndex = 5;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(96, 29);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(132, 40);
            this.btnDownload.TabIndex = 10;
            this.btnDownload.Text = "دانلود فایل ها";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
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
            this.dgvFiles.Location = new System.Drawing.Point(3, 86);
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
            // lblMessageText
            // 
            this.lblMessageText.AutoSize = true;
            this.lblMessageText.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageText.Location = new System.Drawing.Point(1008, 86);
            this.lblMessageText.Name = "lblMessageText";
            this.lblMessageText.Size = new System.Drawing.Size(76, 33);
            this.lblMessageText.TabIndex = 5;
            this.lblMessageText.Text = "متن :";
            // 
            // txtMessageText
            // 
            this.txtMessageText.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageText.Location = new System.Drawing.Point(345, 84);
            this.txtMessageText.Multiline = true;
            this.txtMessageText.Name = "txtMessageText";
            this.txtMessageText.Size = new System.Drawing.Size(657, 565);
            this.txtMessageText.TabIndex = 4;
            // 
            // txtMessageTitle
            // 
            this.txtMessageTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageTitle.Location = new System.Drawing.Point(345, 29);
            this.txtMessageTitle.Name = "txtMessageTitle";
            this.txtMessageTitle.Size = new System.Drawing.Size(657, 39);
            this.txtMessageTitle.TabIndex = 3;
            // 
            // lblMessageTitle
            // 
            this.lblMessageTitle.AutoSize = true;
            this.lblMessageTitle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageTitle.Location = new System.Drawing.Point(1008, 29);
            this.lblMessageTitle.Name = "lblMessageTitle";
            this.lblMessageTitle.Size = new System.Drawing.Size(95, 33);
            this.lblMessageTitle.TabIndex = 0;
            this.lblMessageTitle.Text = "عنوان :";
            // 
            // btnAnswer
            // 
            this.btnAnswer.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer.Location = new System.Drawing.Point(17, 883);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(157, 66);
            this.btnAnswer.TabIndex = 6;
            this.btnAnswer.Text = "پاسخ";
            this.btnAnswer.UseVisualStyleBackColor = true;
            // 
            // dgvUnSeenMessage
            // 
            this.dgvUnSeenMessage.AllowUserToAddRows = false;
            this.dgvUnSeenMessage.AllowUserToDeleteRows = false;
            this.dgvUnSeenMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnSeenMessage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSender,
            this.clmTitle});
            this.dgvUnSeenMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUnSeenMessage.Location = new System.Drawing.Point(0, 87);
            this.dgvUnSeenMessage.Name = "dgvUnSeenMessage";
            this.dgvUnSeenMessage.ReadOnly = true;
            this.dgvUnSeenMessage.Size = new System.Drawing.Size(438, 918);
            this.dgvUnSeenMessage.TabIndex = 7;
            this.dgvUnSeenMessage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnSeenMessage_CellClick);
            this.dgvUnSeenMessage.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnSeenMessage_CellDoubleClick);
            // 
            // clmSender
            // 
            this.clmSender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmSender.HeaderText = "فرستنده";
            this.clmSender.Name = "clmSender";
            this.clmSender.ReadOnly = true;
            this.clmSender.Width = 71;
            // 
            // clmTitle
            // 
            this.clmTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmTitle.HeaderText = "عنوان";
            this.clmTitle.Name = "clmTitle";
            this.clmTitle.ReadOnly = true;
            this.clmTitle.Width = 59;
            // 
            // pnlUnseenMessage
            // 
            this.pnlUnseenMessage.Controls.Add(this.lblMessages);
            this.pnlUnseenMessage.Controls.Add(this.dgvUnSeenMessage);
            this.pnlUnseenMessage.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlUnseenMessage.Location = new System.Drawing.Point(1125, 0);
            this.pnlUnseenMessage.Name = "pnlUnseenMessage";
            this.pnlUnseenMessage.Size = new System.Drawing.Size(438, 1005);
            this.pnlUnseenMessage.TabIndex = 8;
            // 
            // lblMessages
            // 
            this.lblMessages.AutoSize = true;
            this.lblMessages.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessages.Location = new System.Drawing.Point(193, 25);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(68, 31);
            this.lblMessages.TabIndex = 8;
            this.lblMessages.Text = "پیام ها";
            // 
            // pnlDateTime
            // 
            this.pnlDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDateTime.Controls.Add(this.lblSendedTime);
            this.pnlDateTime.Controls.Add(this.lblTime);
            this.pnlDateTime.Controls.Add(this.lblDate);
            this.pnlDateTime.Location = new System.Drawing.Point(631, 852);
            this.pnlDateTime.Name = "pnlDateTime";
            this.pnlDateTime.Size = new System.Drawing.Size(301, 100);
            this.pnlDateTime.TabIndex = 9;
            // 
            // lblSendedTime
            // 
            this.lblSendedTime.AutoSize = true;
            this.lblSendedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSendedTime.Location = new System.Drawing.Point(189, 30);
            this.lblSendedTime.Name = "lblSendedTime";
            this.lblSendedTime.Size = new System.Drawing.Size(107, 24);
            this.lblSendedTime.TabIndex = 4;
            this.lblSendedTime.Text = "زمان ارسال پیام";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(46, 59);
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTime.Size = new System.Drawing.Size(84, 25);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "label1";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(14, 20);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDate.Size = new System.Drawing.Size(84, 25);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "label1";
            // 
            // frmReceivedMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 1005);
            this.Controls.Add(this.pnlDateTime);
            this.Controls.Add(this.pnlUnseenMessage);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.pnlMessage);
            this.Controls.Add(this.pnlFrom);
            this.Name = "frmReceivedMessage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmReceivedMessage";
            this.Load += new System.EventHandler(this.frmReceivedMessage_Load);
            this.pnlFrom.ResumeLayout(false);
            this.pnlFrom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFromPhoto)).EndInit();
            this.pnlMessage.ResumeLayout(false);
            this.pnlMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnSeenMessage)).EndInit();
            this.pnlUnseenMessage.ResumeLayout(false);
            this.pnlUnseenMessage.PerformLayout();
            this.pnlDateTime.ResumeLayout(false);
            this.pnlDateTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFrom;
        private System.Windows.Forms.Label lblFromName;
        private System.Windows.Forms.Label lblFromUserName;
        private System.Windows.Forms.TextBox txtFromUserName;
        private System.Windows.Forms.TextBox txtFromName;
        private System.Windows.Forms.PictureBox pcbFromPhoto;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Panel pnlMessage;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.Label lblMessageText;
        private System.Windows.Forms.TextBox txtMessageText;
        private System.Windows.Forms.TextBox txtMessageTitle;
        private System.Windows.Forms.Label lblMessageTitle;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.DataGridView dgvUnSeenMessage;
        private System.Windows.Forms.Panel pnlUnseenMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTitle;
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.Panel pnlDateTime;
        private System.Windows.Forms.Label lblSendedTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
    }
}