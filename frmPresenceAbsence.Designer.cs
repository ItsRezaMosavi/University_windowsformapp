namespace University
{
    partial class frmPresenceAbsence
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
            this.components = new System.ComponentModel.Container();
            this.pcbPhoto = new System.Windows.Forms.PictureBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblClassRoomId = new System.Windows.Forms.Label();
            this.pnlDateTime = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.lblLessonName = new System.Windows.Forms.Label();
            this.btnPresent = new System.Windows.Forms.Button();
            this.btnAbsent = new System.Windows.Forms.Button();
            this.lblClassCount = new System.Windows.Forms.Label();
            this.lblSessionNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPhoto)).BeginInit();
            this.pnlDateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbPhoto
            // 
            this.pcbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbPhoto.Location = new System.Drawing.Point(355, 33);
            this.pcbPhoto.Name = "pcbPhoto";
            this.pcbPhoto.Size = new System.Drawing.Size(400, 428);
            this.pcbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPhoto.TabIndex = 0;
            this.pcbPhoto.TabStop = false;
            this.pcbPhoto.Click += new System.EventHandler(this.pcbPhoto_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(921, 33);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(110, 37);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "label1";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(921, 131);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(110, 37);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "label1";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(921, 229);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(110, 37);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "label1";
            // 
            // lblClassRoomId
            // 
            this.lblClassRoomId.AutoSize = true;
            this.lblClassRoomId.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassRoomId.Location = new System.Drawing.Point(921, 327);
            this.lblClassRoomId.Name = "lblClassRoomId";
            this.lblClassRoomId.Size = new System.Drawing.Size(110, 37);
            this.lblClassRoomId.TabIndex = 4;
            this.lblClassRoomId.Text = "label1";
            // 
            // pnlDateTime
            // 
            this.pnlDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDateTime.Controls.Add(this.lblTime);
            this.pnlDateTime.Controls.Add(this.lblDate);
            this.pnlDateTime.Location = new System.Drawing.Point(12, 12);
            this.pnlDateTime.Name = "pnlDateTime";
            this.pnlDateTime.Size = new System.Drawing.Size(200, 100);
            this.pnlDateTime.TabIndex = 6;
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
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 10;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // lblLessonName
            // 
            this.lblLessonName.AutoSize = true;
            this.lblLessonName.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLessonName.Location = new System.Drawing.Point(921, 425);
            this.lblLessonName.Name = "lblLessonName";
            this.lblLessonName.Size = new System.Drawing.Size(110, 37);
            this.lblLessonName.TabIndex = 5;
            this.lblLessonName.Text = "label1";
            // 
            // btnPresent
            // 
            this.btnPresent.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresent.Location = new System.Drawing.Point(635, 514);
            this.btnPresent.Name = "btnPresent";
            this.btnPresent.Size = new System.Drawing.Size(205, 91);
            this.btnPresent.TabIndex = 7;
            this.btnPresent.Text = "حاضر";
            this.btnPresent.UseVisualStyleBackColor = true;
            this.btnPresent.Click += new System.EventHandler(this.btnPresent_Click);
            // 
            // btnAbsent
            // 
            this.btnAbsent.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbsent.Location = new System.Drawing.Point(298, 514);
            this.btnAbsent.Name = "btnAbsent";
            this.btnAbsent.Size = new System.Drawing.Size(205, 91);
            this.btnAbsent.TabIndex = 8;
            this.btnAbsent.Text = "غایب";
            this.btnAbsent.UseVisualStyleBackColor = true;
            this.btnAbsent.Click += new System.EventHandler(this.btnAbsent_Click);
            // 
            // lblClassCount
            // 
            this.lblClassCount.AutoSize = true;
            this.lblClassCount.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassCount.Location = new System.Drawing.Point(110, 186);
            this.lblClassCount.Name = "lblClassCount";
            this.lblClassCount.Size = new System.Drawing.Size(81, 29);
            this.lblClassCount.TabIndex = 9;
            this.lblClassCount.Text = "label1";
            // 
            // lblSessionNumber
            // 
            this.lblSessionNumber.AutoSize = true;
            this.lblSessionNumber.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionNumber.Location = new System.Drawing.Point(110, 291);
            this.lblSessionNumber.Name = "lblSessionNumber";
            this.lblSessionNumber.Size = new System.Drawing.Size(81, 29);
            this.lblSessionNumber.TabIndex = 10;
            this.lblSessionNumber.Text = "label1";
            // 
            // frmPresenceAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 678);
            this.Controls.Add(this.lblSessionNumber);
            this.Controls.Add(this.lblClassCount);
            this.Controls.Add(this.btnAbsent);
            this.Controls.Add(this.btnPresent);
            this.Controls.Add(this.pnlDateTime);
            this.Controls.Add(this.lblLessonName);
            this.Controls.Add(this.lblClassRoomId);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.pcbPhoto);
            this.Name = "frmPresenceAbsence";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frmPresenceAbsence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPhoto)).EndInit();
            this.pnlDateTime.ResumeLayout(false);
            this.pnlDateTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbPhoto;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblClassRoomId;
        private System.Windows.Forms.Panel pnlDateTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Label lblLessonName;
        private System.Windows.Forms.Button btnPresent;
        private System.Windows.Forms.Button btnAbsent;
        private System.Windows.Forms.Label lblClassCount;
        private System.Windows.Forms.Label lblSessionNumber;
    }
}