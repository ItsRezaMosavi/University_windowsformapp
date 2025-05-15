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
    public partial class frmStudentClassRoomMappingbyStudent : Form
    {
        public frmStudentClassRoomMappingbyStudent()
        {
            InitializeComponent();
        }
        List<View_StudentClassRoomMapping> classroom = new List<View_StudentClassRoomMapping>();
        private void frmStudentClassRoomMappingbyStudent_Load(object sender, EventArgs e)
        {
            Access();
            lblYear.Text = clsPublicVariable.Year.ToString();
            if (clsPublicVariable.openTerm == clsPublicVariable.Term.mehr)
                lblTerm.Text += "  مهر";
            else if (clsPublicVariable.openTerm == clsPublicVariable.Term.bahman)
                lblTerm.Text += "  بهمن";
            else
                lblTerm.Text += "  تابستان";
            fillform();
        }
        private void fillform()
        {
            Access();
            University_DBEntities db = new University_DBEntities();
            int thisterm = Convert.ToInt32(clsPublicVariable.openTerm);
            classroom = db.View_StudentClassRoomMapping.Where(c => c.StudentId == clsPublicVariable.User.UserId && c.Year == clsPublicVariable.Year && c.Term == thisterm).ToList();


            int i = 0;
            dgvClassRoom.Rows.Clear();
            foreach (View_StudentClassRoomMapping c in classroom)
            {
                dgvClassRoom.Rows.Add();
                dgvClassRoom["clmClassRoomId", i].Value = c.ClassroomId;
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

        private void btnPermanentSave_Click(object sender, EventArgs e)
        {
            Access();
            DialogResult dr = MessageBox.Show("با ادامه این روند انتخاب واحد شما تمام شده و امکان ویرایش آن وجود نخواهد داشت\r\n آیا میخواهید ادامه دهید ؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            if (dr == DialogResult.OK)
            {
                University_DBEntities db = new University_DBEntities();
                tblExtraAccess access = clsPublicVariable.UserExtraAccess.Where(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Student Class Room Mapping").Select(p => p.Id).First()).First();
                db.tblExtraAccesses.Remove(access);
                db.SaveChanges();
                clsPublicVariable.UserExtraAccess.Clear();
                clsPublicVariable.UserExtraAccess.AddRange(db.tblExtraAccesses.Where(a => a.UserId == clsPublicVariable.User.UserId).ToList());
                MessageBox.Show("با موفقیت ثبت شد");
                btnAdd.Enabled = false;
                btnRemove.Enabled = false;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Access();
            University_DBEntities db = new University_DBEntities();
            Hide();
            new frmSelectClassRoom().ShowDialog();
            if (clsPublicVariable.SelectedClasstoAdd == null)
                return;
            if (db.tblStudentClassroomMappings.Any(c => c.StudentId == clsPublicVariable.User.UserId && c.ClassroomId == clsPublicVariable.SelectedClasstoAdd.Id))
            {
                MessageBox.Show("شما قبلا در این کلاس شرکت کرده اید");
                return;
            }
            tblStudentClassroomMapping scm = new tblStudentClassroomMapping()
            {
                StudentId = clsPublicVariable.User.UserId,
                ClassroomId = clsPublicVariable.SelectedClasstoAdd.Id
            };

            tblTeacherLessonMapping room = db.tblTeacherLessonMappings.Where(c => c.Id == clsPublicVariable.SelectedClasstoAdd.Id).FirstOrDefault();
            room.Remain--;
            room.Taken++;
            db.tblTeacherLessonMappings.AddOrUpdate(room);
            db.tblStudentClassroomMappings.Add(scm);
            db.SaveChanges();
            fillform();
            Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Access();
            int index;
            try
            {
                index = dgvClassRoom.CurrentRow.Index;
            }
            catch { MessageBox.Show("یک درس را انتخاب کنید"); return; }
            DialogResult dr = MessageBox.Show("آیا میخواهید این درس را حذف کنید ؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                University_DBEntities db = new University_DBEntities();
                int classid = Convert.ToInt32(dgvClassRoom["clmClassRoomId", index].Value);
                tblStudentClassroomMapping scm = db.tblStudentClassroomMappings.Where(c => c.ClassroomId == classid && c.StudentId == clsPublicVariable.User.UserId).First();
                db.tblStudentClassroomMappings.Remove(scm);
                db.SaveChanges();
                MessageBox.Show("درس حذف شد");
                fillform();
            }

        }

        private void Access()
        {
            University_DBEntities db = new University_DBEntities();
            if (!clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Student ClassRoom Mapping").Select(p => p.Id).First()))
                Close();
        }
    }
}
