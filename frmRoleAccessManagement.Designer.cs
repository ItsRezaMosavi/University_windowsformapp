namespace University
{
    partial class frmRoleAccessManagement
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
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.btnSelectRole = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbPart = new System.Windows.Forms.ComboBox();
            this.lblPart = new System.Windows.Forms.Label();
            this.dgvAccess = new System.Windows.Forms.DataGridView();
            this.clmRoleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteAccess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccess)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(270, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(438, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Role Access Management";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(12, 182);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(86, 32);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Role :";
            // 
            // cmbRoles
            // 
            this.cmbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoles.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(104, 182);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(441, 40);
            this.cmbRoles.TabIndex = 2;
            this.cmbRoles.SelectedIndexChanged += new System.EventHandler(this.cmbRoles_SelectedIndexChanged);
            // 
            // btnSelectRole
            // 
            this.btnSelectRole.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectRole.Location = new System.Drawing.Point(551, 176);
            this.btnSelectRole.Name = "btnSelectRole";
            this.btnSelectRole.Size = new System.Drawing.Size(163, 56);
            this.btnSelectRole.TabIndex = 3;
            this.btnSelectRole.Text = "Select  Role";
            this.btnSelectRole.UseVisualStyleBackColor = true;
            this.btnSelectRole.Click += new System.EventHandler(this.btnSelectRole_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(663, 248);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(163, 56);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "add Access";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbPart
            // 
            this.cmbPart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPart.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPart.FormattingEnabled = true;
            this.cmbPart.Location = new System.Drawing.Point(97, 257);
            this.cmbPart.Name = "cmbPart";
            this.cmbPart.Size = new System.Drawing.Size(560, 40);
            this.cmbPart.TabIndex = 5;
            // 
            // lblPart
            // 
            this.lblPart.AutoSize = true;
            this.lblPart.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPart.Location = new System.Drawing.Point(12, 257);
            this.lblPart.Name = "lblPart";
            this.lblPart.Size = new System.Drawing.Size(79, 32);
            this.lblPart.TabIndex = 4;
            this.lblPart.Text = "Part :";
            // 
            // dgvAccess
            // 
            this.dgvAccess.AllowUserToAddRows = false;
            this.dgvAccess.AllowUserToDeleteRows = false;
            this.dgvAccess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmRoleId,
            this.clmRole});
            this.dgvAccess.Location = new System.Drawing.Point(12, 371);
            this.dgvAccess.Name = "dgvAccess";
            this.dgvAccess.ReadOnly = true;
            this.dgvAccess.Size = new System.Drawing.Size(972, 424);
            this.dgvAccess.TabIndex = 7;
            // 
            // clmRoleId
            // 
            this.clmRoleId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmRoleId.HeaderText = "Role Id";
            this.clmRoleId.Name = "clmRoleId";
            this.clmRoleId.ReadOnly = true;
            this.clmRoleId.Width = 66;
            // 
            // clmRole
            // 
            this.clmRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmRole.HeaderText = "Role";
            this.clmRole.Name = "clmRole";
            this.clmRole.ReadOnly = true;
            this.clmRole.Width = 54;
            // 
            // btnDeleteAccess
            // 
            this.btnDeleteAccess.BackColor = System.Drawing.Color.Red;
            this.btnDeleteAccess.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccess.Location = new System.Drawing.Point(832, 248);
            this.btnDeleteAccess.Name = "btnDeleteAccess";
            this.btnDeleteAccess.Size = new System.Drawing.Size(163, 56);
            this.btnDeleteAccess.TabIndex = 8;
            this.btnDeleteAccess.Text = "delete Access";
            this.btnDeleteAccess.UseVisualStyleBackColor = false;
            this.btnDeleteAccess.Click += new System.EventHandler(this.btnDeleteAccess_Click);
            // 
            // frmRoleAccessManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 807);
            this.Controls.Add(this.btnDeleteAccess);
            this.Controls.Add(this.dgvAccess);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbPart);
            this.Controls.Add(this.lblPart);
            this.Controls.Add(this.btnSelectRole);
            this.Controls.Add(this.cmbRoles);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmRoleAccessManagement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRoleAccessManagement_FormClosing);
            this.Load += new System.EventHandler(this.frmRoleAccessManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Button btnSelectRole;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbPart;
        private System.Windows.Forms.Label lblPart;
        private System.Windows.Forms.DataGridView dgvAccess;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRoleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRole;
        private System.Windows.Forms.Button btnDeleteAccess;
    }
}