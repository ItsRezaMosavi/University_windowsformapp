namespace University
{
    partial class frmRolesManagement
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
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRoles = new System.Windows.Forms.Panel();
            this.lblRoles = new System.Windows.Forms.Label();
            this.pnlAddRole = new System.Windows.Forms.Panel();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.lblNewRoleName = new System.Windows.Forms.Label();
            this.lblAddRoles = new System.Windows.Forms.Label();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.lblRoleManagement = new System.Windows.Forms.Label();
            this.btnDeleteRole = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.pnlRoles.SuspendLayout();
            this.pnlAddRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRoles
            // 
            this.dgvRoles.AllowUserToAddRows = false;
            this.dgvRoles.AllowUserToDeleteRows = false;
            this.dgvRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmTitle});
            this.dgvRoles.Location = new System.Drawing.Point(-2, 133);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.ReadOnly = true;
            this.dgvRoles.Size = new System.Drawing.Size(423, 333);
            this.dgvRoles.TabIndex = 0;
            // 
            // clmId
            // 
            this.clmId.HeaderText = "Id";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            // 
            // clmTitle
            // 
            this.clmTitle.HeaderText = "Title";
            this.clmTitle.Name = "clmTitle";
            this.clmTitle.ReadOnly = true;
            // 
            // pnlRoles
            // 
            this.pnlRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRoles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRoles.Controls.Add(this.lblRoles);
            this.pnlRoles.Controls.Add(this.dgvRoles);
            this.pnlRoles.Location = new System.Drawing.Point(643, 217);
            this.pnlRoles.Name = "pnlRoles";
            this.pnlRoles.Size = new System.Drawing.Size(423, 468);
            this.pnlRoles.TabIndex = 1;
            // 
            // lblRoles
            // 
            this.lblRoles.AutoSize = true;
            this.lblRoles.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoles.Location = new System.Drawing.Point(181, 39);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.Size = new System.Drawing.Size(78, 29);
            this.lblRoles.TabIndex = 1;
            this.lblRoles.Text = "Roles";
            // 
            // pnlAddRole
            // 
            this.pnlAddRole.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAddRole.Controls.Add(this.btnAddRole);
            this.pnlAddRole.Controls.Add(this.lblNewRoleName);
            this.pnlAddRole.Controls.Add(this.lblAddRoles);
            this.pnlAddRole.Controls.Add(this.txtRoleName);
            this.pnlAddRole.Location = new System.Drawing.Point(12, 217);
            this.pnlAddRole.Name = "pnlAddRole";
            this.pnlAddRole.Size = new System.Drawing.Size(529, 286);
            this.pnlAddRole.TabIndex = 2;
            // 
            // btnAddRole
            // 
            this.btnAddRole.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRole.Location = new System.Drawing.Point(189, 202);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(163, 48);
            this.btnAddRole.TabIndex = 3;
            this.btnAddRole.Text = "Add Role";
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // lblNewRoleName
            // 
            this.lblNewRoleName.AutoSize = true;
            this.lblNewRoleName.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewRoleName.Location = new System.Drawing.Point(16, 114);
            this.lblNewRoleName.Name = "lblNewRoleName";
            this.lblNewRoleName.Size = new System.Drawing.Size(167, 26);
            this.lblNewRoleName.TabIndex = 2;
            this.lblNewRoleName.Text = "New Role Name :";
            // 
            // lblAddRoles
            // 
            this.lblAddRoles.AutoSize = true;
            this.lblAddRoles.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRoles.Location = new System.Drawing.Point(113, 28);
            this.lblAddRoles.Name = "lblAddRoles";
            this.lblAddRoles.Size = new System.Drawing.Size(102, 24);
            this.lblAddRoles.TabIndex = 1;
            this.lblAddRoles.Text = "Add Role";
            // 
            // txtRoleName
            // 
            this.txtRoleName.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoleName.Location = new System.Drawing.Point(189, 109);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(333, 39);
            this.txtRoleName.TabIndex = 0;
            // 
            // lblRoleManagement
            // 
            this.lblRoleManagement.AutoSize = true;
            this.lblRoleManagement.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleManagement.Location = new System.Drawing.Point(385, 41);
            this.lblRoleManagement.Name = "lblRoleManagement";
            this.lblRoleManagement.Size = new System.Drawing.Size(290, 37);
            this.lblRoleManagement.TabIndex = 3;
            this.lblRoleManagement.Text = "Role Management";
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.BackColor = System.Drawing.Color.Red;
            this.btnDeleteRole.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRole.Location = new System.Drawing.Point(906, 163);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(149, 48);
            this.btnDeleteRole.TabIndex = 4;
            this.btnDeleteRole.Text = "Delete Role";
            this.btnDeleteRole.UseVisualStyleBackColor = false;
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // frmRolesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 687);
            this.Controls.Add(this.btnDeleteRole);
            this.Controls.Add(this.lblRoleManagement);
            this.Controls.Add(this.pnlAddRole);
            this.Controls.Add(this.pnlRoles);
            this.Name = "frmRolesManagement";
            this.Load += new System.EventHandler(this.frmRolesManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.pnlRoles.ResumeLayout(false);
            this.pnlRoles.PerformLayout();
            this.pnlAddRole.ResumeLayout(false);
            this.pnlAddRole.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.Panel pnlRoles;
        private System.Windows.Forms.Label lblRoles;
        private System.Windows.Forms.Panel pnlAddRole;
        private System.Windows.Forms.Label lblNewRoleName;
        private System.Windows.Forms.Label lblAddRoles;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Label lblRoleManagement;
        private System.Windows.Forms.Button btnDeleteRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTitle;
    }
}