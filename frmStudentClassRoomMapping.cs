using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class frmStudentClassRoomMapping : Form
    {
        tblTeacherLessonMapping ClassRoom;
        List<View_ClassRoom> ClassRoom_List;
        List<View_User> Student_List;
        tblCollege College;
        public frmStudentClassRoomMapping(tblTeacherLessonMapping A = null)
        {
            InitializeComponent();
            ClassRoom = A;
        }

        private void frmStudentClassRoomMapping_Load(object sender, EventArgs e)
        {
            Access();
            University_DBEntities db = new University_DBEntities();
            cmbCollege.Items.Clear();
            foreach (tblCollege c in db.tblColleges)
                cmbCollege.Items.Add(c.CollegeName);
            ClassRoom_List = db.View_ClassRoom.ToList();
            int type = Convert.ToInt32(clsPublicVariable.UsersType.Student);
            Student_List = db.View_User.Where(u => db.tblRoleToUsers.Any(r => r.RoleId == clsPublicVariable.StudentId && r.UserId == u.UserId)).ToList();
            if (ClassRoom != null)
            {
                cmbCollege.Text = db.tblColleges.Where(c => c.Id == ClassRoom.CollegeId).Select(c => c.CollegeName).First();
                cmbCollege.SelectedIndex = cmbCollege.Items.IndexOf(cmbCollege.Text);
            }
            Filldgv();
        }
        private void Access()
        {
            University_DBEntities db = new University_DBEntities();
            if (!clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Student ClassRoom Mapping").Select(p => p.Id).First()))
                Close();
        }
        private void cmbCollege_SelectedIndexChanged(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();

            College = db.tblColleges.Where(c => c.CollegeName == cmbCollege.Text).First();
            ClassRoom_List = db.View_ClassRoom.Where(c => c.CollegeId == College.Id).ToList();
            Student_List = db.View_User.Where(s => s.CollegeName == College.CollegeName && db.tblRoleToUsers.Any(r => r.RoleId == clsPublicVariable.StudentId && r.UserId == s.UserId)).ToList();
            Filldgv();
        }
        private void Filldgv()
        {
            University_DBEntities db = new University_DBEntities();
            int i = 0;
            dgvClassRoom.Rows.Clear();
            foreach (View_ClassRoom c in ClassRoom_List)
            {
                dgvClassRoom.Rows.Add();
                dgvClassRoom["clmClassRoomId", i].Value = c.Id;
                dgvClassRoom["clmTeacherUsername", i].Value = db.tblUsers.Where(T => T.Id == c.TeacherId).Select(t => t.UserName).First();
                dgvClassRoom["clmTeacherName", i].Value = db.tblUsers.Where(T => T.Id == c.TeacherId).Select(T => T.FirstName + T.LastName).First();
                dgvClassRoom["clmLessonId", i].Value = c.LessonId;
                dgvClassRoom["clmLessonName", i].Value = db.tblLessons.Where(l => l.Id == c.LessonId).Select(l => l.LessonName).FirstOrDefault();
                dgvClassRoom["clmCapacity", i].Value = c.Capacity;
                dgvClassRoom["clmYear", i].Value = c.Year;
                if (c.Term == Convert.ToInt32(clsPublicVariable.Term.mehr))
                    dgvClassRoom["clmTerm", i].Value = "مهر";
                else if (c.Term == Convert.ToInt32(clsPublicVariable.Term.bahman))
                    dgvClassRoom["clmTerm", i].Value = "بهمن";
                else if (c.Term == Convert.ToInt32(clsPublicVariable.Term.tabestan))
                    dgvClassRoom["clmTerm", i].Value = "تابستان";

                if (c.Day == Convert.ToInt32(clsPublicVariable.Week.Saturday))
                    dgvClassRoom["clmDay", i].Value = "شنبه";
                else if (c.Day == Convert.ToInt32(clsPublicVariable.Week.Sunday))
                    dgvClassRoom["clmDay", i].Value = "یکشنبه";
                else if (c.Day == Convert.ToInt32(clsPublicVariable.Week.Monday))
                    dgvClassRoom["clmDay", i].Value = "دوشنبه";
                else if (c.Day == Convert.ToInt32(clsPublicVariable.Week.Tuesday))
                    dgvClassRoom["clmDay", i].Value = "سه شنبه";
                else if (c.Day == Convert.ToInt32(clsPublicVariable.Week.Wednesday))
                    dgvClassRoom["clmDay", i].Value = "چهارشنبه";
                else if (c.Day == Convert.ToInt32(clsPublicVariable.Week.Thursday))
                    dgvClassRoom["clmDay", i].Value = "پنج شنبه";
                else if (c.Day == Convert.ToInt32(clsPublicVariable.Week.Friday))
                    dgvClassRoom["clmDay", i].Value = "جمعه";
                dgvClassRoom["clmCollegeName", i].Value = c.CollegeName;
                dgvClassRoom["clmCollegeId", i].Value = c.CollegeId;
                dgvClassRoom["clmStartTime", i].Value = c.StartTime;
                dgvClassRoom["clmFinishTime", i].Value = c.FinishTime;
                i++;
            }


            i = 0;
            dgvStudent.Rows.Clear();
            foreach (View_User s in Student_List)
            {
                dgvStudent.RowTemplate.Height = 80;
                dgvStudent.Rows.Add();
                if (s.PhotoAddress != null)
                    dgvStudent["clmPhoto", i].Value = Image.FromFile(s.PhotoAddress);
                dgvStudent["clmUserName", i].Value = s.UserName;
                dgvStudent["clmFName", i].Value = s.FirstName;
                dgvStudent["clmLName", i].Value = s.LastName;
                dgvStudent["clmNationalCode", i].Value = s.NationalCode;
                dgvStudent["clmField", i].Value = s.Educational_Field;
                dgvStudent["clmCollege", i].Value = s.CollegeName;
                i++;
            }
        }

        private void btnSelectClassRoom_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            int index = dgvClassRoom.CurrentRow.Index;
            int ClassRoomId = Convert.ToInt32(dgvClassRoom["clmClassRoomId", index].Value);
            ClassRoom = db.tblTeacherLessonMappings.Where(c => c.Id == ClassRoomId).FirstOrDefault();
            MessageBox.Show("کلاس انتخاب شد");
            Filldgv();
        }

        private void btnAddStudentToClass_Click(object sender, EventArgs e)
        {
            Access();
            University_DBEntities db = new University_DBEntities();
            if (ClassRoom == null)
            {
                MessageBox.Show("کلاس را انتخاب کنید");
                return;
            }
            if (ClassRoom.Remain < 1)
            {
                MessageBox.Show("این کلاس ظرفیت خالی ندارد");
                return;
            }
            int index = dgvStudent.CurrentRow.Index;
            string user = dgvStudent["clmUserName", index].Value.ToString();
            int studentId = db.tblUsers.Where(u => u.UserName == user).Select(u => u.Id).First();
            if (db.tblStudentClassroomMappings.Any(b => b.StudentId == studentId))
            {
                MessageBox.Show("این دانشجو قبلا در این کلاس ثبت شده است");
                return;
            }
            tblStudentClassroomMapping s = new tblStudentClassroomMapping()
            {
                StudentId = studentId,
                ClassroomId = ClassRoom.Id
            };
            ClassRoom.Taken++;
            ClassRoom.Remain--;

            db.tblTeacherLessonMappings.AddOrUpdate(ClassRoom);
            db.tblStudentClassroomMappings.Add(s);
            db.SaveChanges();
            MessageBox.Show("با موفقیت افزوده شد");
        }
    }
}
