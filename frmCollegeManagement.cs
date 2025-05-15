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
    public partial class frmCollegeManagement : Form
    {
        tblCollege College;
        View_ClassRoom SelectedClassRoom = null;
        public frmCollegeManagement(tblCollege A)
        {
            InitializeComponent();
            College = A;
        }

        private void frmCollegeTeacherManagement_Load(object sender, EventArgs e)
        {
            Access();
            frmLoad();
        }
        private void frmLoad()
        {
            University_DBEntities db = new University_DBEntities();
            lblTitle.Text = "مدیریت دانشکده " + College.CollegeName;
            List<tblUser> Teachers = db.tblUsers.Where(u => u.CollegeId == College.Id && db.tblRoleToUsers.Any(r => r.UserId == u.Id && r.RoleId == clsPublicVariable.TeacherId)).ToList();
            dgvTeachers.Rows.Clear();
            int i = 0;
            foreach (tblUser teacher in Teachers)
            {
                dgvTeachers.Rows.Add();
                dgvTeachers["clmFirstName", i].Value = teacher.FirstName;
                dgvTeachers["clmLastName", i].Value = teacher.LastName;
                dgvTeachers["clmNationalCode", i].Value = teacher.NationalCode;
                if (teacher.GenderId == db.tblGenders.Where(g => g.GenderTitle == "Female").Select(g => g.Id).First())
                    dgvTeachers["clmGender", i].Value = "خانم";
                else
                    dgvTeachers["clmGender", i].Value = "آقا";
                dgvTeachers["clmEducational_Field", i].Value = db.tblEducationalFields.Where(f => f.Id == teacher.Educational_Field_Id).Select(f => f.Educational_Field).First();
                dgvTeachers["clmCollege", i].Value = db.tblColleges.Where(c => c.Id == teacher.CollegeId).Select(c => c.CollegeName).First();
                i++;
            }

            int studenttype = Convert.ToInt32(clsPublicVariable.UsersType.Student);
            List<tblUser> student = db.tblUsers.Where(u => u.CollegeId == College.Id && db.tblRoleToUsers.Any(r => r.RoleId == clsPublicVariable.StudentId && r.UserId == u.Id)).ToList();
            lblTeachersCount.Text = "تعداد اساتید :  " + Convert.ToString(Teachers.Count);
            lblStudentsCount.Text = "تعداد دانشجویان :  " + Convert.ToString(student.Count);
            lblClassRoomCount.Text = "تعداد کلاس ها : " + db.View_ClassRoom.Where(c => c.CollegeId == College.Id).Count().ToString();


            dgvLesson.Rows.Clear();
            int j = 0;
            foreach (tblLesson l in db.tblLessons.Where(l => l.CollegeId == College.Id).ToList())
            {
                dgvLesson.Rows.Add();
                dgvLesson["clmId", j].Value = l.Id;
                dgvLesson["clmName", j].Value = l.LessonName;
                j++;
            }


            List<View_ClassRoom> ClassRoom = db.View_ClassRoom.Where(c => c.CollegeId == College.Id).ToList();
            i = 0;
            dgvClassRoom.Rows.Clear();
            foreach (View_ClassRoom c in ClassRoom)
            {
                dgvClassRoom.Rows.Add();
                dgvClassRoom["clmClassRoomId", i].Value = c.Id;
                dgvClassRoom["clmTeacherUsername", i].Value = c.TeacherUserName;
                dgvClassRoom["clmTeacherName", i].Value = c.TeacherFirstName + "  " + c.TeacherLastName;
                dgvClassRoom["clmLessonId", i].Value = c.LessonId;
                dgvClassRoom["clmLessonName", i].Value = c.LessonName;
                dgvClassRoom["clmCollegeId", i].Value = c.CollegeId;
                dgvClassRoom["clmCollegeName", i].Value = c.CollegeName;
                dgvClassRoom["clmYear", i].Value = c.Year;
                if (c.Term == Convert.ToInt32(clsPublicVariable.Term.mehr))
                    dgvClassRoom["clmTerm", i].Value = "مهر";
                else if (c.Term == Convert.ToInt32(clsPublicVariable.Term.bahman))
                    dgvClassRoom["clmTerm", i].Value = "بهمن";
                else if (c.Term == Convert.ToInt32(clsPublicVariable.Term.tabestan))
                    dgvClassRoom["clmTerm", i].Value = "تابستان";
                dgvClassRoom["clmCapacity", i].Value = c.Capacity;
                dgvClassRoom["clmTaken", i].Value = c.Taken;
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

                dgvClassRoom["clmStartTime", i].Value = c.StartTime;
                dgvClassRoom["clmFinishTime", i].Value = c.FinishTime;
                dgvClassRoom["clmUnit", i].Value = c.Unit;
                i++;
            }
        }
        private void Access()
        {
            University_DBEntities db = new University_DBEntities();
            if (!clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == College.CollegeEnglishName + " College Management").Select(p => p.Id).First()))
                Close();
            if (clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "lesson").Select(p => p.Id).First()))
            {
                btnAddLesson.Enabled = true;
                btnAddLesson.Visible = true;
                btnEditLesson.Enabled = true;
                btnEditLesson.Visible = true;
                btnDeleteLesson.Enabled = true;
                btnDeleteLesson.Visible = true;
            }
            if (clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "ClassRoom").Select(p => p.Id).First()))
            {
                btnAddClassRoom.Enabled = true;
                btnAddClassRoom.Visible = true;
                btnEditClassRoom.Enabled = true;
                btnEditClassRoom.Visible = true;
                btnDeleteClassRoom.Enabled = true;
                btnDeleteClassRoom.Visible = true;
            }
            if (clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Teacher Management").Select(p => p.Id).First()))
            {
                btnTeacherManagement.Enabled = true;
                btnTeacherManagement.Visible = true;
            }
            if (clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Student Management").Select(p => p.Id).First()))
            {
                btnStudentManagement.Enabled = true;
                btnStudentManagement.Visible = true;
            }
            if (clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Register Score").Select(p => p.Id).First()))
            {
                btnRegisterScore.Enabled = true;
                btnRegisterScore.Visible = true;
            }
            if (clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Student ClassRoom Mapping").Select(p => p.Id).First()))
            {
                btnStudentClassRoomMapping.Enabled = true;
                btnStudentClassRoomMapping.Visible = true;
            }
        }
        private void btnAddLesson_Click(object sender, EventArgs e)
        {

            new frmAddLesson(College.Id).ShowDialog();
            frmLoad();
        }

        private void btnTeacherManagement_Click(object sender, EventArgs e)
        {
            Hide();
            University_DBEntities db = new University_DBEntities();
            int type = Convert.ToInt32(clsPublicVariable.UsersType.Teacher);
            new frmUserManagement(db.tblRoles.Where(r => r.Id == clsPublicVariable.TeacherId).First(), College.Id).ShowDialog();
            frmLoad();
            Show();
        }

        private void btnDeleteLesson_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            int index = dgvLesson.CurrentRow.Index;
            int id = Convert.ToInt32(dgvLesson["clmId", index].Value);
            tblLesson lesson = db.tblLessons.Where(l => l.Id == id).FirstOrDefault();
            DialogResult dr = MessageBox.Show(string.Format("آیا میخواهید درس {0} را حذف کنید؟\nهشدار : این عملیات قابل بازگشت نیست.", lesson.LessonName), "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            if (dr == DialogResult.Yes)
            {
                db.tblLessons.Remove(lesson);
                db.SaveChanges();
                MessageBox.Show("با موفقیت حذف شد");
                frmLoad();
            }
        }

        private void btnEditLesson_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            int index = dgvLesson.CurrentRow.Index;
            int id = Convert.ToInt32(dgvLesson["clmId", index].Value);
            tblLesson lesson = db.tblLessons.Where(l => l.Id == id).FirstOrDefault();
            if (lesson != null)
                new frmEditLesson(lesson).ShowDialog();
        }

        private void btnAddClassRoom_Click(object sender, EventArgs e)
        {
            new frmAddClassRoom().ShowDialog();
            frmLoad();
        }

        private void btnDeleteClassRoom_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            int index = dgvClassRoom.CurrentRow.Index;
            int id = Convert.ToInt32(dgvClassRoom["clmId", index].Value);
            tblTeacherLessonMapping ClassRoom = db.tblTeacherLessonMappings.Where(l => l.Id == id).FirstOrDefault();
            DialogResult dr = MessageBox.Show(string.Format("آیا میخواهید کلاس {0} را حذف کنید؟\nهشدار : این عملیات قابل بازگشت نیست.", ClassRoom.Id), "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            if (dr == DialogResult.Yes)
            {
                db.tblTeacherLessonMappings.Remove(ClassRoom);
                db.SaveChanges();
                MessageBox.Show("با موفقیت حذف شد");
                frmLoad();
            }
        }

        private void btnEditClassRoom_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            int index = dgvClassRoom.CurrentRow.Index;
            int id = Convert.ToInt32(dgvClassRoom["clmId", index].Value);
            tblTeacherLessonMapping ClassRoom = db.tblTeacherLessonMappings.Where(l => l.Id == id).FirstOrDefault();
            if (ClassRoom != null)
                new frmEditClassRoom(ClassRoom).ShowDialog();
            frmLoad();
        }

        private void btnStudentClassRoomMapping_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            int index = dgvClassRoom.CurrentRow.Index;
            int ClassRoomId = Convert.ToInt32(dgvClassRoom["clmClassRoomId", index].Value);
            tblTeacherLessonMapping ClassRoom = db.tblTeacherLessonMappings.Where(c => c.Id == ClassRoomId).First();
            if (ClassRoom.Remain < 1)
            {
                MessageBox.Show("این کلاس ظرفیت خالی ندارد");
                return;
            }
            new frmStudentClassRoomMapping(ClassRoom).ShowDialog();

        }

        private void btnStudentManagement_Click(object sender, EventArgs e)
        {
            Hide();
            University_DBEntities db = new University_DBEntities();
            new frmUserManagement(db.tblRoles.Where(r => r.Id == clsPublicVariable.StudentId).First(), College.Id).ShowDialog();
            frmLoad();
            Show();
        }

        private void dgvClassRoom_DoubleClick(object sender, EventArgs e)
        {
        }

        private void pnlStatistic_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegisterScore_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            int index = dgvClassRoom.CurrentRow.Index;
            int ClassRoomId = Convert.ToInt32(dgvClassRoom["clmId", index].Value);
            SelectedClassRoom = db.View_ClassRoom.Where(c => c.Id == ClassRoomId).First();
            if (SelectedClassRoom.Taken == 0)
                MessageBox.Show("این کلاس دانشجویی ندارد");
            else
            {
                Hide();
                new frmScores(SelectedClassRoom).ShowDialog();
                Show();
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmLoad();
        }
    }
}
