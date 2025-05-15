namespace University
{
    partial class frmChangePassword
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
            this.txtLastPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewPasswordRepeat = new System.Windows.Forms.TextBox();
            this.lblLastPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblNewPasswordRepeat = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLastPassword
            // 
            this.txtLastPassword.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastPassword.Location = new System.Drawing.Point(99, 171);
            this.txtLastPassword.Name = "txtLastPassword";
            this.txtLastPassword.Size = new System.Drawing.Size(179, 40);
            this.txtLastPassword.TabIndex = 0;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(99, 246);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(179, 40);
            this.txtNewPassword.TabIndex = 1;
            // 
            // txtNewPasswordRepeat
            // 
            this.txtNewPasswordRepeat.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPasswordRepeat.Location = new System.Drawing.Point(99, 319);
            this.txtNewPasswordRepeat.Name = "txtNewPasswordRepeat";
            this.txtNewPasswordRepeat.Size = new System.Drawing.Size(179, 40);
            this.txtNewPasswordRepeat.TabIndex = 2;
            // 
            // lblLastPassword
            // 
            this.lblLastPassword.AutoSize = true;
            this.lblLastPassword.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastPassword.Location = new System.Drawing.Point(339, 178);
            this.lblLastPassword.Name = "lblLastPassword";
            this.lblLastPassword.Size = new System.Drawing.Size(104, 33);
            this.lblLastPassword.TabIndex = 3;
            this.lblLastPassword.Text = "رمز عبور :";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(339, 253);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(158, 33);
            this.lblNewPassword.TabIndex = 4;
            this.lblNewPassword.Text = "رمز عبور جدید :";
            this.lblNewPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNewPasswordRepeat
            // 
            this.lblNewPasswordRepeat.AutoSize = true;
            this.lblNewPasswordRepeat.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPasswordRepeat.Location = new System.Drawing.Point(339, 326);
            this.lblNewPasswordRepeat.Name = "lblNewPasswordRepeat";
            this.lblNewPasswordRepeat.Size = new System.Drawing.Size(206, 33);
            this.lblNewPasswordRepeat.TabIndex = 5;
            this.lblNewPasswordRepeat.Text = "تکرار رمز عبور جدید :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(224, 52);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(166, 34);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "تغییر رمز عبور";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(190, 438);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(247, 69);
            this.btnChangePassword.TabIndex = 7;
            this.btnChangePassword.Text = "تغییر رمز عبور";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 587);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblNewPasswordRepeat);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblLastPassword);
            this.Controls.Add(this.txtNewPasswordRepeat);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtLastPassword);
            this.Name = "frmChangePassword";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "تغییر رمز عبور";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLastPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtNewPasswordRepeat;
        private System.Windows.Forms.Label lblLastPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblNewPasswordRepeat;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnChangePassword;
    }
}