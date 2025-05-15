namespace University
{
    partial class frmSystemPartManagement
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
            this.btnDeletePart = new System.Windows.Forms.Button();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRoles = new System.Windows.Forms.Panel();
            this.lblParts = new System.Windows.Forms.Label();
            this.pnlAddRole = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddorUpdatePart = new System.Windows.Forms.Button();
            this.lblNewPartName = new System.Windows.Forms.Label();
            this.lblAddParts = new System.Windows.Forms.Label();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.lblSystemPartManagement = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            this.pnlRoles.SuspendLayout();
            this.pnlAddRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.BackColor = System.Drawing.Color.Red;
            this.btnDeletePart.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePart.Location = new System.Drawing.Point(913, 159);
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(173, 59);
            this.btnDeletePart.TabIndex = 8;
            this.btnDeletePart.Text = "Delete Part";
            this.btnDeletePart.UseVisualStyleBackColor = false;
            this.btnDeletePart.Click += new System.EventHandler(this.btnDeletePart_Click);
            // 
            // dgvParts
            // 
            this.dgvParts.AllowUserToAddRows = false;
            this.dgvParts.AllowUserToDeleteRows = false;
            this.dgvParts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmPartName,
            this.clmDescription});
            this.dgvParts.Location = new System.Drawing.Point(-2, 133);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.ReadOnly = true;
            this.dgvParts.Size = new System.Drawing.Size(423, 333);
            this.dgvParts.TabIndex = 0;
            // 
            // clmId
            // 
            this.clmId.HeaderText = "Id";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            // 
            // clmPartName
            // 
            this.clmPartName.HeaderText = "PartName";
            this.clmPartName.Name = "clmPartName";
            this.clmPartName.ReadOnly = true;
            // 
            // clmDescription
            // 
            this.clmDescription.HeaderText = "Description";
            this.clmDescription.Name = "clmDescription";
            this.clmDescription.ReadOnly = true;
            // 
            // pnlRoles
            // 
            this.pnlRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRoles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRoles.Controls.Add(this.lblParts);
            this.pnlRoles.Controls.Add(this.dgvParts);
            this.pnlRoles.Location = new System.Drawing.Point(663, 224);
            this.pnlRoles.Name = "pnlRoles";
            this.pnlRoles.Size = new System.Drawing.Size(423, 468);
            this.pnlRoles.TabIndex = 5;
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParts.Location = new System.Drawing.Point(152, 44);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(72, 29);
            this.lblParts.TabIndex = 1;
            this.lblParts.Text = "Parts";
            // 
            // pnlAddRole
            // 
            this.pnlAddRole.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAddRole.Controls.Add(this.lblDescription);
            this.pnlAddRole.Controls.Add(this.txtDescription);
            this.pnlAddRole.Controls.Add(this.btnAddorUpdatePart);
            this.pnlAddRole.Controls.Add(this.lblNewPartName);
            this.pnlAddRole.Controls.Add(this.lblAddParts);
            this.pnlAddRole.Controls.Add(this.txtPartName);
            this.pnlAddRole.Location = new System.Drawing.Point(12, 242);
            this.pnlAddRole.Name = "pnlAddRole";
            this.pnlAddRole.Size = new System.Drawing.Size(493, 466);
            this.pnlAddRole.TabIndex = 6;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(9, 217);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(127, 26);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description :";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(142, 217);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(344, 168);
            this.txtDescription.TabIndex = 4;
            // 
            // btnAddorUpdatePart
            // 
            this.btnAddorUpdatePart.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddorUpdatePart.Location = new System.Drawing.Point(87, 391);
            this.btnAddorUpdatePart.Name = "btnAddorUpdatePart";
            this.btnAddorUpdatePart.Size = new System.Drawing.Size(304, 48);
            this.btnAddorUpdatePart.TabIndex = 3;
            this.btnAddorUpdatePart.Text = "Add/Update Part";
            this.btnAddorUpdatePart.UseVisualStyleBackColor = true;
            this.btnAddorUpdatePart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // lblNewPartName
            // 
            this.lblNewPartName.AutoSize = true;
            this.lblNewPartName.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPartName.Location = new System.Drawing.Point(16, 114);
            this.lblNewPartName.Name = "lblNewPartName";
            this.lblNewPartName.Size = new System.Drawing.Size(164, 26);
            this.lblNewPartName.TabIndex = 2;
            this.lblNewPartName.Text = "New Part Name :";
            // 
            // lblAddParts
            // 
            this.lblAddParts.AutoSize = true;
            this.lblAddParts.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddParts.Location = new System.Drawing.Point(113, 28);
            this.lblAddParts.Name = "lblAddParts";
            this.lblAddParts.Size = new System.Drawing.Size(98, 24);
            this.lblAddParts.TabIndex = 1;
            this.lblAddParts.Text = "Add Part";
            // 
            // txtPartName
            // 
            this.txtPartName.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartName.Location = new System.Drawing.Point(189, 109);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(297, 39);
            this.txtPartName.TabIndex = 0;
            // 
            // lblSystemPartManagement
            // 
            this.lblSystemPartManagement.AutoSize = true;
            this.lblSystemPartManagement.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemPartManagement.Location = new System.Drawing.Point(367, 58);
            this.lblSystemPartManagement.Name = "lblSystemPartManagement";
            this.lblSystemPartManagement.Size = new System.Drawing.Size(405, 37);
            this.lblSystemPartManagement.TabIndex = 7;
            this.lblSystemPartManagement.Text = "System Part Management";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(663, 163);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(133, 55);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmSystemPartManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 760);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDeletePart);
            this.Controls.Add(this.pnlRoles);
            this.Controls.Add(this.pnlAddRole);
            this.Controls.Add(this.lblSystemPartManagement);
            this.Name = "frmSystemPartManagement";
            this.Load += new System.EventHandler(this.frmSystemPartManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            this.pnlRoles.ResumeLayout(false);
            this.pnlRoles.PerformLayout();
            this.pnlAddRole.ResumeLayout(false);
            this.pnlAddRole.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeletePart;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.Panel pnlRoles;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.Panel pnlAddRole;
        private System.Windows.Forms.Button btnAddorUpdatePart;
        private System.Windows.Forms.Label lblNewPartName;
        private System.Windows.Forms.Label lblAddParts;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.Label lblSystemPartManagement;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescription;
        private System.Windows.Forms.Button btnEdit;
    }
}