namespace University
{
    partial class frmChangeProfilePhoto
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
            this.btnUploadNewPhoto = new System.Windows.Forms.Button();
            this.lblCurrentPhoto = new System.Windows.Forms.Label();
            this.lblNewPhoto = new System.Windows.Forms.Label();
            this.pcbUserNewPhoto = new System.Windows.Forms.PictureBox();
            this.pcbUserCurrentPhoto = new System.Windows.Forms.PictureBox();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserNewPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserCurrentPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(277, 56);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(236, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "درخواست تغییر عکس";
            // 
            // btnUploadNewPhoto
            // 
            this.btnUploadNewPhoto.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadNewPhoto.Location = new System.Drawing.Point(307, 174);
            this.btnUploadNewPhoto.Name = "btnUploadNewPhoto";
            this.btnUploadNewPhoto.Size = new System.Drawing.Size(186, 75);
            this.btnUploadNewPhoto.TabIndex = 6;
            this.btnUploadNewPhoto.Text = "انتخاب عکس جدید";
            this.btnUploadNewPhoto.UseVisualStyleBackColor = true;
            this.btnUploadNewPhoto.Click += new System.EventHandler(this.btnUploadNewPhoto_Click);
            // 
            // lblCurrentPhoto
            // 
            this.lblCurrentPhoto.AutoSize = true;
            this.lblCurrentPhoto.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPhoto.Location = new System.Drawing.Point(94, 358);
            this.lblCurrentPhoto.Name = "lblCurrentPhoto";
            this.lblCurrentPhoto.Size = new System.Drawing.Size(102, 29);
            this.lblCurrentPhoto.TabIndex = 7;
            this.lblCurrentPhoto.Text = "عکس فعلی";
            // 
            // lblNewPhoto
            // 
            this.lblNewPhoto.AutoSize = true;
            this.lblNewPhoto.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPhoto.Location = new System.Drawing.Point(603, 358);
            this.lblNewPhoto.Name = "lblNewPhoto";
            this.lblNewPhoto.Size = new System.Drawing.Size(108, 29);
            this.lblNewPhoto.TabIndex = 8;
            this.lblNewPhoto.Text = "عکس جدید";
            // 
            // pcbUserNewPhoto
            // 
            this.pcbUserNewPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbUserNewPhoto.Location = new System.Drawing.Point(547, 114);
            this.pcbUserNewPhoto.Name = "pcbUserNewPhoto";
            this.pcbUserNewPhoto.Size = new System.Drawing.Size(222, 201);
            this.pcbUserNewPhoto.TabIndex = 5;
            this.pcbUserNewPhoto.TabStop = false;
            // 
            // pcbUserCurrentPhoto
            // 
            this.pcbUserCurrentPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbUserCurrentPhoto.Location = new System.Drawing.Point(34, 114);
            this.pcbUserCurrentPhoto.Name = "pcbUserCurrentPhoto";
            this.pcbUserCurrentPhoto.Size = new System.Drawing.Size(222, 201);
            this.pcbUserCurrentPhoto.TabIndex = 4;
            this.pcbUserCurrentPhoto.TabStop = false;
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendRequest.Location = new System.Drawing.Point(34, 610);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(267, 110);
            this.btnSendRequest.TabIndex = 9;
            this.btnSendRequest.Text = "ثبت درخواست تغییر عکس";
            this.btnSendRequest.UseVisualStyleBackColor = true;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(355, 518);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(351, 202);
            this.txtDescription.TabIndex = 10;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(620, 463);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(86, 26);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "توضیحات";
            // 
            // frmChangeProfilePhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 732);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnSendRequest);
            this.Controls.Add(this.lblNewPhoto);
            this.Controls.Add(this.lblCurrentPhoto);
            this.Controls.Add(this.btnUploadNewPhoto);
            this.Controls.Add(this.pcbUserNewPhoto);
            this.Controls.Add(this.pcbUserCurrentPhoto);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmChangeProfilePhoto";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmChangeProfilePhoto";
            this.Load += new System.EventHandler(this.frmChangeProfilePhoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserNewPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserCurrentPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pcbUserCurrentPhoto;
        private System.Windows.Forms.PictureBox pcbUserNewPhoto;
        private System.Windows.Forms.Button btnUploadNewPhoto;
        private System.Windows.Forms.Label lblCurrentPhoto;
        private System.Windows.Forms.Label lblNewPhoto;
        private System.Windows.Forms.Button btnSendRequest;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
    }
}