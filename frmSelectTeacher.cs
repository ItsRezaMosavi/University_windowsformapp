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
    public partial class frmSelectTeacher : Form
    {
        tblCollege College;
        public frmSelectTeacher(tblCollege A)
        {
            InitializeComponent();
            College = A;
        }

        private void frmSelectTeacher_Load(object sender, EventArgs e)
        {
            frmLoad();
        }
        private void frmLoad()
        {
            University_DBEntities db = new University_DBEntities();
            dgvTeacher.Rows.Clear();
            int type = Convert.ToInt32(clsPublicVariable.UsersType.Teacher);
            List<View_User> Teachers = db.View_User.Where(t => db.tblRoleToUsers.Any(r => r.RoleId == clsPublicVariable.TeacherId && r.UserId == t.UserId) && t.CollegeName == College.CollegeName).ToList();
            int i = 0;
            foreach (View_User t in Teachers)
            {
                dgvTeacher.RowTemplate.Height = 80;
                dgvTeacher.Rows.Add();
                if (t.PhotoAddress != null)
                    dgvTeacher["clmPhoto", i].Value = Image.FromFile(t.PhotoAddress);
                dgvTeacher["clmUserName", i].Value = t.UserName;
                dgvTeacher["clmName", i].Value = t.FirstName + " " + t.LastName;
                dgvTeacher["clmNationalCode", i].Value = t.NationalCode;
                dgvTeacher["clmFathersName", i].Value = t.FathersName;
                dgvTeacher["clmEducational_Field", i].Value = t.Educational_Field;
                if (t.GenderTitle == "Female")
                    dgvTeacher["clmGender", i].Value = "خانم";
                else
                    dgvTeacher["clmGender", i].Value = "آقا";
                i++;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            clsPublicVariable.SelectedTeacher = null;
            University_DBEntities db = new University_DBEntities();
            int index = dgvTeacher.CurrentRow.Index;
            string UserName = dgvTeacher["clmUserName", index].Value.ToString();
            int type = Convert.ToInt32(clsPublicVariable.UsersType.Teacher);
            tblUser teacher = db.tblUsers.Where(u => u.UserName == UserName && db.tblRoleToUsers.Any(r => r.RoleId == clsPublicVariable.TeacherId && r.UserId == u.Id)).FirstOrDefault();
            if (teacher != null)
            {
                clsPublicVariable.SelectedTeacher = teacher;
                Close();
            }
        }
    }
}
