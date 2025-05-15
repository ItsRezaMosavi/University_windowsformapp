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
    public partial class frmRoleAccessManagement : Form
    {
        public frmRoleAccessManagement()
        {
            InitializeComponent();
        }

        List<tblRoleAccess> access = new List<tblRoleAccess>();
        private void frmRoleAccessManagement_Load(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            foreach (tblSystemPartName p in db.tblSystemPartNames)
            {
                DataGridViewCheckBoxColumn chb = new DataGridViewCheckBoxColumn();
                chb.Name = "clm" + p.PartName;
                chb.HeaderText = p.PartName;
                dgvAccess.Columns.Add(chb);
            }
            foreach (tblRole r in db.tblRoles)
                cmbRoles.Items.Add(r.Title);
            foreach (tblSystemPartName p in db.tblSystemPartNames)
                cmbPart.Items.Add(p.PartName + "--" + p.Description);
            access = db.tblRoleAccesses.ToList();
            fillfrm();
        }
        tblRole SelectedRole;
        private void btnSelectRole_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            SelectedRole = db.tblRoles.Where(r => r.Title == cmbRoles.Text).FirstOrDefault();
            fillfrm();
        }
        private void fillfrm()
        {
            University_DBEntities db = new University_DBEntities();
            //DataGridView dgv = new DataGridView();


            dgvAccess.Rows.Clear();
            //int i = 0;
            //foreach (tblRole r in db.tblRoles)
            //{
            //    dgvAccess.Rows.Add();
            //    dgvAccess["clmRole", i].Value = r.Title;
            //    i++;
            //}

            int i = 0;
            foreach (tblRole r in db.tblRoles.ToList())
            {
                dgvAccess.Rows.Add();
                dgvAccess.RowTemplate.Height = 30;
                dgvAccess["clmRoleId", i].Value = r.Id;
                dgvAccess["clmRole", i].Value = r.Title;
                foreach (tblSystemPartName p in db.tblSystemPartNames.ToList())
                {
                    dgvAccess["clm" + p.PartName, i].Value = access.Any(a => a.SystemPartId == p.Id && a.RoleId == r.Id);
                }
                i++;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            int index = cmbPart.Text.IndexOf("-");
            int partid = db.tblSystemPartNames.Where(p => p.PartName == cmbPart.Text.Substring(0, index)).Select(p => p.Id).First();
            if (!db.tblRoleAccesses.Any(r => r.RoleId == SelectedRole.Id && r.SystemPartId == partid))
            {
                tblRoleAccess ac = new tblRoleAccess()
                {
                    RoleId = SelectedRole.Id,
                    SystemPartId = partid
                };
                db.tblRoleAccesses.Add(ac);
                db.SaveChanges();
                MessageBox.Show("Done");
            }
            else
                MessageBox.Show("your selected Role already has the access to this part");
            access = db.tblRoleAccesses.ToList();
            fillfrm();
        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSelectRole_Click(null, null);
        }

        private void btnDeleteAccess_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            int index = cmbPart.Text.IndexOf("-");
            int partid = db.tblSystemPartNames.Where(p => p.PartName == cmbPart.Text.Substring(0, index)).Select(p => p.Id).First();
            if (db.tblRoleAccesses.Any(r => r.RoleId == SelectedRole.Id && r.SystemPartId == partid))
            {
                tblRoleAccess ac = db.tblRoleAccesses.Where(r => r.RoleId == SelectedRole.Id && r.SystemPartId == partid).First();
                db.tblRoleAccesses.Remove(ac);
                db.SaveChanges();
                MessageBox.Show("Done");
                access = db.tblRoleAccesses.ToList();
                fillfrm();
            }
            else
                MessageBox.Show("Your selected role doesnt have this access");
        }

        private void frmRoleAccessManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            List<tblRoleAccess> roleAccess = new List<tblRoleAccess>();
            foreach (tblRole role in clsPublicVariable.UserRoles)
                roleAccess.AddRange(db.tblRoleAccesses.Where(r => r.RoleId == role.Id).ToList());
            clsPublicVariable.UserRoleAccess = roleAccess;
            clsPublicVariable.UserExtraAccess = db.tblExtraAccesses.Where(a => a.UserId == clsPublicVariable.User.UserId).ToList();
        }
    }
}
