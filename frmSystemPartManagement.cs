using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class frmSystemPartManagement : Form
    {
        public frmSystemPartManagement()
        {
            InitializeComponent();
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            if (!db.tblSystemPartNames.Any(p => p.PartName == txtPartName.Text ) || edit)
                if (txtPartName.Text.Length > 0)
                {
                    selectedPart.PartName = txtPartName.Text;
                    selectedPart.Description = txtDescription.Text;
                    db.tblSystemPartNames.AddOrUpdate(selectedPart);
                    db.SaveChanges();
                }
            edit = false;
            selectedPart = new tblSystemPartName();
            fillform();
        }
        private void fillform()
        {
            University_DBEntities db = new University_DBEntities();
            int i = 0;
            dgvParts.Rows.Clear();
            foreach (tblSystemPartName p in db.tblSystemPartNames)
            {
                dgvParts.RowTemplate.Height = 30;
                dgvParts.Rows.Add();
                dgvParts["clmId", i].Value = p.Id;
                dgvParts["clmPartName", i].Value = p.PartName;
                dgvParts["clmDescription", i].Value = p.Description;
                i++;
            }
        }

        private void frmSystemPartManagement_Load(object sender, EventArgs e)
        {
            fillform();
        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            int index = dgvParts.CurrentRow.Index;
            int id = Convert.ToInt32(dgvParts["clmId", index].Value);
            if (!db.tblRoleAccesses.Any(r => r.SystemPartId == id))
            {
                db.tblSystemPartNames.Remove(db.tblSystemPartNames.Where(i => i.Id == id).FirstOrDefault());
                db.SaveChanges();
                MessageBox.Show("Done");
                fillform();
            }
            else
                MessageBox.Show("There are some RoleAccess To this part, you must Delete Them First");
        }
        tblSystemPartName selectedPart = new tblSystemPartName();
        bool edit = false;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            int index = dgvParts.CurrentRow.Index;
            int id = Convert.ToInt32(dgvParts["clmId", index].Value);
            selectedPart = db.tblSystemPartNames.Where(p => p.Id == id).FirstOrDefault();
            txtPartName.Text = selectedPart.PartName;
            txtDescription.Text = selectedPart.Description;
            edit = true;
        }
    }
}
