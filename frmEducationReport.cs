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
    public partial class frmEducationReport : Form
    {
        public frmEducationReport()
        {
            InitializeComponent();
        }
        List<View_StudentClassRoomMapping> classes;
        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmEducationReport_Load(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            classes = db.View_StudentClassRoomMapping.Where(c => c.StudentId == clsPublicVariable.User.UserId).ToList();
            fillForm();
        }

        private void fillForm()
        {
            University_DBEntities db = new University_DBEntities();
            List<View_Score> Score = db.View_Score.Where(s => s.StudentId == clsPublicVariable.User.UserId).ToList();
            int classscore = Convert.ToInt32(clsPublicVariable.Score_Type.ClassPoint);
            int mid = Convert.ToInt32(clsPublicVariable.Score_Type.MidTerm);
            int final = Convert.ToInt32(clsPublicVariable.Score_Type.Final);
            int ave = Convert.ToInt32(clsPublicVariable.Score_Type.Average);
            int i = 0;
            dgvScore.Rows.Clear();
            foreach (View_StudentClassRoomMapping c in classes)
            {
                dgvScore.Rows.Add();
                dgvScore["clmClassRoomId", i].Value = c.ClassroomId;
                dgvScore["clmLesson", i].Value = c.LessonName;
                dgvScore["clmTeacherName", i].Value = c.TeacherFirstName + " " + c.TeacherLastName;
                dgvScore["clmYear", i].Value = c.Year;
                if (c.Term == Convert.ToInt32(clsPublicVariable.Term.mehr))
                    dgvScore["clmTerm", i].Value = "مهر";
                else if (c.Term == Convert.ToInt32(clsPublicVariable.Term.bahman))
                    dgvScore["clmTerm", i].Value = "بهمن";
                else
                    dgvScore["clmTerm", i].Value = "تابستان";
                dgvScore["clmUnit", i].Value = c.Unit;
                dgvScore["clmClassScore", i].Value = Score.Where(s => s.Type == classscore && s.ClassroomId == c.ClassroomId).Select(s => s.Score).FirstOrDefault();
                dgvScore["clmMidTermScore", i].Value = Score.Where(s => s.Type == mid && s.ClassroomId == c.ClassroomId).Select(s => s.Score).FirstOrDefault();
                dgvScore["clmFinalScore", i].Value = Score.Where(s => s.Type == final && s.ClassroomId == c.ClassroomId).Select(s => s.Score).FirstOrDefault();
                dgvScore["clmAverage", i].Value = Score.Where(s => s.Type == ave && s.ClassroomId == c.ClassroomId).Select(s => s.Score).FirstOrDefault();
                dgvScore["clmIsPassed", i].Value = c.IsPassed;
                i++;
            }

            lblFirstName.Text += clsPublicVariable.User.FirstName;
            lblLastName.Text += clsPublicVariable.User.LastName;
            lblFathersName.Text += clsPublicVariable.User.FathersName;
            lblGender.Text += clsPublicVariable.User.GenderTitle;
            lblNationalCode.Text += clsPublicVariable.User.NationalCode;
            double average = 0;
            foreach (View_Score s in Score.Where(a => a.Type == ave).ToList())
            {
                average += Convert.ToDouble(s.Score);
            }
            average /= Score.Where(a => a.Type == ave).Count();
            lblAverage.Text += average.ToString();
            int openTerm = Convert.ToInt32(clsPublicVariable.openTerm);
            average = 0;
            foreach (View_Score s in Score.Where(a => a.Type == ave && a.Year == clsPublicVariable.Year && a.Term == openTerm))
                average += Convert.ToInt32(s.Score);
            average /= Score.Where(a => a.Type == ave && a.Year == clsPublicVariable.Year && a.Term == openTerm).Count();
            lblThisTermAverage.Text += average.ToString();

        }
    }
}
