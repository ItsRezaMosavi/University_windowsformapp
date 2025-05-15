using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class frmClassRoomManagement : Form
    {
        int Year, Term;
        public frmClassRoomManagement(int Y = 0, int T = 0)
        {
            InitializeComponent();
            Year = Y;
            Term = T;
        }
        List<View_ClassRoom> AllClass = new List<View_ClassRoom>();
        View_ClassRoom SelectedClass = new View_ClassRoom();
        private void frmClassRoomManagement_Load(object sender, EventArgs e)
        {
            Access();
            lblYear.Text += clsPublicVariable.Year.ToString();
            if (clsPublicVariable.openTerm == clsPublicVariable.Term.mehr)
                lblTerm.Text += "  مهر";
            else if (clsPublicVariable.openTerm == clsPublicVariable.Term.bahman)
                lblTerm.Text += "  بهمن";
            else
                lblTerm.Text += "  تابستان";
            University_DBEntities db = new University_DBEntities();
            int teacherId = clsPublicVariable.User.UserId;
            AllClass = db.View_ClassRoom.Where(c => c.TeacherId == clsPublicVariable.User.UserId && c.Year == Year && c.Term == Term).ToList();
            if (Year == 0 && Term == 0)// show all classes
                AllClass = db.View_ClassRoom.Where(c => c.TeacherId == clsPublicVariable.User.UserId).ToList();
            filldgv();
        }

        private void filldgv()
        {
            Access();
            University_DBEntities db = new University_DBEntities();
            dgvClassRoom.Rows.Clear();
            int i = 0;
            foreach (View_ClassRoom c in AllClass)
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
            if (!clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Class Room Management").Select(p => p.Id).First()))
                Close();
            if (clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Presence Absence Report").Select(p => p.Id).First()))
            {
                btnPresenceAbsenceReport.Visible = true;
                btnPresenceAbsenceReport.Enabled = true;
            }
            if (clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Presence Absence Registor").Select(p => p.Id).First()))
            {
                btnPresenceAbsenceList.Visible = true;
                btnPresenceAbsenceList.Enabled = true;
            }
            if (clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Scores").Select(p => p.Id).First()))
            {
                btnScores.Visible = true;
                btnScores.Enabled = true;
            }
        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            Access();
            University_DBEntities db = new University_DBEntities();
            int index = dgvClassRoom.CurrentRow.Index;
            int ClassRoomId = Convert.ToInt32(dgvClassRoom["clmClassRoomId", index].Value);
            Hide();
            new frmScores(AllClass.Where(c => c.Id == ClassRoomId).First()).ShowDialog();
            int teacherId = clsPublicVariable.User.UserId;
            AllClass = db.View_ClassRoom.Where(c => c.TeacherId == clsPublicVariable.User.UserId && c.Year == Year && c.Term == Term).ToList();
            if (Year == 0 && Term == 0)// show all classes
                AllClass = db.View_ClassRoom.Where(c => c.TeacherId == clsPublicVariable.User.UserId).ToList();
            filldgv();
            Show();
        }

        private void btnPresenceAbsenceList_Click(object sender, EventArgs e)
        {
            Access();
            University_DBEntities db = new University_DBEntities();
            int index = dgvClassRoom.CurrentRow.Index;
            int ClassRoomId = Convert.ToInt32(dgvClassRoom["clmClassRoomId", index].Value);
            View_ClassRoom classroom = AllClass.Where(c => c.Id == ClassRoomId).First();
            if (classroom.IsActive)
            {
                int SessionNumber = db.tblPresenceAbsences.Where(c => c.ClassRoomId == ClassRoomId).OrderByDescending(c => c.SessionNumber).Take(1).Select(c => c.SessionNumber).FirstOrDefault() + 1;
                DialogResult dr = MessageBox.Show(string.Format("آیا میخواهید حضور غیاب جلسه {0} ام را ثبت کنید ؟", SessionNumber), "اخطار", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.OK)
                {
                    Hide();
                    new frmPresenceAbsence(AllClass.Where(c => c.Id == ClassRoomId).First(), SessionNumber).ShowDialog();
                    Show();
                }
            }
            else
                MessageBox.Show("امکان ثبت حضور غیاب برای کلاس های ترم های قبل وجود ندارد");
        }

        private void btnPresenceAbsenceReport_Click(object sender, EventArgs e)
        {
            Access();
            University_DBEntities db = new University_DBEntities();
            int index = dgvClassRoom.CurrentRow.Index;
            int ClassRoomId = Convert.ToInt32(dgvClassRoom["clmClassRoomId", index].Value);
            View_ClassRoom classroom = AllClass.Where(c => c.Id == ClassRoomId).First();
            Hide();
            new frmPresenceAbsenceReport(classroom).ShowDialog();
            Show();
        }
    }
}
