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
    public partial class frmUniversityManagement : Form
    {
        public frmUniversityManagement()
        {
            InitializeComponent();
        }

        private void frmUniversityManagement_Load(object sender, EventArgs e)
        {
            Access();
            University_DBEntities db = new University_DBEntities();
            dgvCollege.Columns.Clear();
            dgvCollege.Rows.Clear();
            dgvCollege.Columns.Add("clmId", "کد دانشکده");
            dgvCollege.Columns.Add("clmCollegeName", "نام دانشکده");
            int i = 0;
            foreach (tblCollege c in db.tblColleges)
            {
                dgvCollege.Rows.Add();
                dgvCollege["clmId", i].Value = c.Id;
                dgvCollege["clmCollegeName", i].Value = c.CollegeName;
                i++;
            }

            dgvEducationalField.Rows.Clear();
            dgvEducationalField.Columns.Clear();
            dgvEducationalField.Columns.Add("clmId", "کد رشته");
            dgvEducationalField.Columns.Add("clmEducational_Field_Name", "نام رشته");
            dgvEducationalField.Columns.Add("clmCollegeId", "کد دانشکده");
            dgvEducationalField.Columns.Add("clmCollegeName", "نام دانشکده");

            i = 0;
            foreach (tblEducationalField ef in db.tblEducationalFields)
            {
                dgvEducationalField.Rows.Add();
                dgvEducationalField["clmId", i].Value = ef.Id;
                dgvEducationalField["clmEducational_Field_Name", i].Value = ef.Educational_Field;
                dgvEducationalField["clmCollegeId", i].Value = ef.CollegeId;
                dgvEducationalField["clmCollegeName", i].Value = db.tblColleges.Where(c => c.Id == ef.CollegeId).Select(c => c.CollegeName).First();
                i++;
            }
        }
        private void Access()
        {
            University_DBEntities db = new University_DBEntities();
            if (!clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "University Management").Select(p => p.Id).First()))
                Close();
            if(clsPublicVariable.UserRoleAccess.Any(a=>a.SystemPartId==db.tblSystemPartNames.Where(p=>p.PartName== "College").Select(p=>p.Id).First()))
            {
                pnlCollege.Enabled = true;
                pnlCollege.Visible = true;
            }
            if (clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Educational Field").Select(p => p.Id).First()))
            {
                pnlEducationalField.Enabled = true;
                pnlEducationalField.Visible = true;
            }
        }

        private void btnAddCollege_Click(object sender, EventArgs e)
        {
            new frmAddEditDeleteCollege(1).ShowDialog();
            frmUniversityManagement_Load(null, null);
        }

        private void btnEditCollege_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            int index = dgvCollege.CurrentRow.Index;
            if (index != -1)
            {
                int id = Convert.ToInt32(dgvCollege["clmId", index].Value);
                tblCollege College = db.tblColleges.Where(c => c.Id == id).First();
                new frmAddEditDeleteCollege(2, College).ShowDialog();
            }
            frmUniversityManagement_Load(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            int index = dgvCollege.CurrentRow.Index;
            int id = Convert.ToInt32(dgvCollege["clmId", index].Value);
            tblCollege College = db.tblColleges.Where(c => c.Id == id).First();
            DialogResult dr = MessageBox.Show("آیا میخواهید دانشکده را حذف کنید؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                if (db.tblUsers.Any(u => u.CollegeId == College.Id))
                {
                    MessageBox.Show("ابتدا کاربران این دانشکده را حذف کنید");
                    return;
                }
                if (db.tblTeacherLessonMappings.Any(c => c.CollegeId == College.Id))
                {
                    MessageBox.Show("ابتدا کلاس های این دانشکده را حذف کنید");
                    return;
                }
                if (db.tblLessons.Any(l => l.CollegeId.Equals(College.Id)))
                {
                    MessageBox.Show("ابتدا درس های این دانشکده را حذف کنید");
                    return;
                }
                if (db.tblEducationalFields.Any(f => f.CollegeId.Equals(College.Id)))
                {
                    MessageBox.Show("ابتدا رشته های این دانشکده را حذف کنید");
                    return;
                }
                db.tblColleges.Remove(College);
                db.SaveChanges();
                frmUniversityManagement_Load(null, null);

            }
        }

        private void btnEditEducationalField_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            int index;
            try
            {
                index = dgvEducationalField.CurrentRow.Index;
            }
            catch
            {
                return;
            }
            if (index != -1)
            {
                int id = Convert.ToInt32(dgvEducationalField["clmId", index].Value);
                tblEducationalField field = db.tblEducationalFields.Where(b => b.Id == id).First();
                new frmAddEditDeleteEducationalField(2, field).ShowDialog();
                frmUniversityManagement_Load(null, null);
            }
        }

        private void btnAddEducationalField_Click(object sender, EventArgs e)
        {
            new frmAddEditDeleteEducationalField(1).ShowDialog();
            frmUniversityManagement_Load(null, null);
        }

        private void btnDeleteEducationalField_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            int index = dgvEducationalField.CurrentRow.Index;
            int id = Convert.ToInt32(dgvEducationalField["clmId", index].Value);
            tblEducationalField Field = db.tblEducationalFields.Where(c => c.Id == id).First();
            DialogResult dr = MessageBox.Show("آیا میخواهید رشته را حذف کنید؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                if(db.tblUsers.Any(u=>u.Educational_Field_Id == id))
                {
                    MessageBox.Show("ابتدا کاربران این رشته را حذف کنید");
                    return;
                }    
                db.tblEducationalFields.Remove(Field);
                db.SaveChanges();
                frmUniversityManagement_Load(null, null);
            }
        }
    }
}
