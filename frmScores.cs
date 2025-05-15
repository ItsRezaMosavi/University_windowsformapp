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
    public partial class frmScores : Form
    {
        View_ClassRoom classroom;
        List<View_StudentClassRoomMapping> Students = new List<View_StudentClassRoomMapping>();
        List<View_Score> Scores = new List<View_Score>();
        public frmScores(View_ClassRoom A)
        {
            InitializeComponent();
            classroom = A;
        }

        private void dgvStudent_DoubleClick(object sender, EventArgs e)
        {
            Access();
            University_DBEntities db = new University_DBEntities();
            int index = dgvStudent.CurrentRow.Index;
            string StudentUserName = Convert.ToString(dgvStudent["clmUserName", index].Value);
            new frmRegisterScore(db.tblUsers.Where(u => u.UserName == StudentUserName).Select(u => u.Id).First(), classroom.Id).ShowDialog();
            Scores = db.View_Score.Where(s => s.ClassroomId == classroom.Id).ToList();
            filldgv();
        }

        private void frmScores_Load(object sender, EventArgs e)
        {
            Access();
            filldgv();
        }
        private void Access()
        {

        }
        private void filldgv()
        {
            University_DBEntities db = new University_DBEntities();
            Students = db.View_StudentClassRoomMapping.Where(s => s.ClassroomId == classroom.Id && s.TeacherId == clsPublicVariable.User.UserId).ToList();
            Scores = db.View_Score.Where(a => a.ClassroomId == classroom.Id).ToList();

            dgvStudent.Rows.Clear();
            int i = 0;
            foreach (View_StudentClassRoomMapping s in Students)
            {
                dgvStudent.RowTemplate.Height = 80;
                dgvStudent.Rows.Add();
                if (s.StudentPhotoAddress != null)
                    dgvStudent["clmPhoto", i].Value = Image.FromFile(s.StudentPhotoAddress);
                dgvStudent["clmUserName", i].Value = s.StudentUserName;
                dgvStudent["clmFirstName", i].Value = s.StudentFirstName;
                dgvStudent["clmLastName", i].Value = s.StudentLastName;
                if (s.StudentGender == "Female")
                    dgvStudent["clmGender", i].Value = "خانم";
                else
                    dgvStudent["clmGender", i].Value = "آقا";
                dgvStudent["clmCollege", i].Value = s.CollegeName;
                dgvStudent["clmClassRoomId", i].Value = s.ClassroomId;
                dgvStudent["clmLesson", i].Value = s.LessonName;
                List<View_Score> UserScore = Scores.Where(a => a.ClassroomId == s.ClassroomId && a.StudentId == s.StudentId).ToList();
                int classPoint = Convert.ToInt32(clsPublicVariable.Score_Type.ClassPoint);
                int midterm = Convert.ToInt32(clsPublicVariable.Score_Type.MidTerm);
                int final = Convert.ToInt32(clsPublicVariable.Score_Type.Final);
                int Average = Convert.ToInt32(clsPublicVariable.Score_Type.Average);
                dgvStudent["clmClassScore", i].Value = UserScore.Where(a => a.Type == classPoint).Select(a => a.Score).FirstOrDefault();
                dgvStudent["clmMidTermScore", i].Value = UserScore.Where(a => a.Type == midterm).Select(a => a.Score).FirstOrDefault();
                dgvStudent["clmFinalScore", i].Value = UserScore.Where(a => a.Type == final).Select(a => a.Score).FirstOrDefault();
                dgvStudent["clmAverage", i].Value = UserScore.Where(a => a.Type == Average).Select(a => a.Score).FirstOrDefault();
                i++;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRecordScores_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("آیا میخواهید نمرات این کلاس ثبت نهایی شوند؟ در این صورت دیگر امکان تغییر نخواهید داشت", "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                University_DBEntities db = new University_DBEntities();
                tblTeacherLessonMapping class_room = db.tblTeacherLessonMappings.Where(c => c.Id == classroom.Id).FirstOrDefault();
                foreach (View_StudentClassRoomMapping student in Students)
                {
                    double classpoint, mid, final, ave;
                    if (!Scores.Any(s => s.Type == Convert.ToInt32(clsPublicVariable.Score_Type.ClassPoint) && s.StudentId == student.StudentId))
                    {
                        tblScore score = new tblScore()
                        {
                            StudentId = student.StudentId,
                            ClassRoomId = classroom.Id,
                            Score = 0.ToString(),
                            Type = Convert.ToInt32(clsPublicVariable.Score_Type.ClassPoint)
                        };
                        classpoint = 0;
                        db.tblScores.Add(score);
                    }
                    else
                        classpoint = Convert.ToDouble(Scores.Where(s => s.Type == Convert.ToInt32(clsPublicVariable.Score_Type.ClassPoint) && s.StudentId == student.StudentId).Select(s => s.Score).First());
                    if (!Scores.Any(s => s.Type == Convert.ToInt32(clsPublicVariable.Score_Type.MidTerm) && s.StudentId == student.StudentId))
                    {
                        tblScore score = new tblScore()
                        {
                            StudentId = student.StudentId,
                            ClassRoomId = classroom.Id,
                            Score = 0.ToString(),
                            Type = Convert.ToInt32(clsPublicVariable.Score_Type.MidTerm)
                        };
                        mid = 0;
                        db.tblScores.Add(score);
                    }
                    else
                        mid = Convert.ToDouble(Scores.Where(s => s.Type == Convert.ToInt32(clsPublicVariable.Score_Type.MidTerm) && s.StudentId == student.StudentId).Select(s => s.Score).First());
                    if (!Scores.Any(s => s.Type == Convert.ToInt32(clsPublicVariable.Score_Type.Final) && s.StudentId == student.StudentId))
                    {
                        tblScore score = new tblScore()
                        {
                            StudentId = student.StudentId,
                            ClassRoomId = classroom.Id,
                            Score = 0.ToString(),
                            Type = Convert.ToInt32(clsPublicVariable.Score_Type.Final)
                        };
                        final = 0;
                        db.tblScores.Add(score);
                    }
                    else
                        final = Convert.ToDouble(Scores.Where(s => s.Type == Convert.ToInt32(clsPublicVariable.Score_Type.Final) && s.StudentId == student.StudentId).Select(s => s.Score).First());
                    if (!Scores.Any(s => s.Type == Convert.ToInt32(clsPublicVariable.Score_Type.Average) && s.StudentId == student.StudentId))
                    {
                        tblScore score = new tblScore()
                        {
                            StudentId = student.StudentId,
                            ClassRoomId = classroom.Id,
                            Score = Convert.ToString((final + classpoint + mid) / 3),
                            Type = Convert.ToInt32(clsPublicVariable.Score_Type.Average)
                        };
                        db.tblScores.Add(score);
                    }
                }
                class_room.IsActive = false;
                db.tblTeacherLessonMappings.AddOrUpdate(class_room);
                db.SaveChanges();
                MessageBox.Show("با موفقیت انجام شد");
                this.Close();
            }
        }
    }
}
