using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class frmRolesManagement : Form
    {
        public frmRolesManagement()
        {
            InitializeComponent();
        }

        private void frmRolesManagement_Load(object sender, EventArgs e)
        {
            Fillform();
        }
        private void Fillform()
        {
            University_DBEntities db = new University_DBEntities();
            dgvRoles.Rows.Clear();
            int i = 0;
            foreach (tblRole r in db.tblRoles)
            {
                dgvRoles.Rows.Add();
                dgvRoles["clmId", i].Value = r.Id;
                dgvRoles["clmTitle", i].Value = r.Title;
                i++;
            }
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            int index = dgvRoles.CurrentRow.Index;
            int id = Convert.ToInt32(dgvRoles["clmId", index].Value);
            University_DBEntities db = new University_DBEntities();
            if (!db.tblRoleToUsers.Any(r => r.RoleId == id))
            {
                DialogResult dr = MessageBox.Show("do you want to delete this role ?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr.Equals(DialogResult.OK))
                {
                    List<tblRoleAccess> roleAccesses = db.tblRoleAccesses.Where(c => c.RoleId == id).ToList();
                    db.tblRoleAccesses.RemoveRange(roleAccesses);
                    db.SaveChanges();
                    db.tblRoles.Remove(db.tblRoles.Where(r => r.Id == id).First());
                    db.SaveChanges();
                    MessageBox.Show("Done");
                    Fillform();
                }
            }
            else
                MessageBox.Show("there is some user with this role. you must change their role first");
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            if (!db.tblRoles.Any(r => r.Title == txtRoleName.Text) && txtRoleName.Text.Length > 0)
            {
                tblRole role = new tblRole()
                {
                    Title = txtRoleName.Text
                };
                db.tblRoles.Add(role);
                db.SaveChanges();
            }
            Fillform();
        }
    }
}
