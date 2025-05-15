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
    public partial class frmAddClassRoom : Form
    {
        public frmAddClassRoom()
        {
            InitializeComponent();
        }

        private void btnSelectTeacher_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            if (cmbCollege.SelectedIndex == -1)
            {
                MessageBox.Show("دانشکده را انتخاب کنید");
                return;
            }
            tblCollege College = db.tblColleges.Where(c => c.CollegeName == cmbCollege.Text).First();
            new frmSelectTeacher(College).ShowDialog();
            if (clsPublicVariable.SelectedTeacher != null)
                txtTeacher.Text = clsPublicVariable.SelectedTeacher.FirstName + " " + clsPublicVariable.SelectedTeacher.LastName;
            cmbLesson.Items.Clear();
            List<string> lesson = db.tblLessons.Where(l => l.CollegeId == College.Id).Select(l => l.LessonName).ToList();
            foreach (string l in lesson)
                cmbLesson.Items.Add(l);
        }

        private void cmbCollege_SelectedValueChanged(object sender, EventArgs e)
        {
            txtTeacher.Text = "";
            clsPublicVariable.SelectedTeacher = null;
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            if (cmbCollege.SelectedIndex == -1)
            {
                MessageBox.Show("دانشکده را انتخاب کنید");
                return;
            }
            int College = db.tblColleges.Where(c => c.CollegeName == cmbCollege.Text).Select(c => c.Id).First();
            pnlCollege.BackColor = SystemColors.Control;
            if (clsPublicVariable.SelectedTeacher == null)
            {
                MessageBox.Show("استاد را انتخاب کنید");
                pnlTeacher.BackColor = Color.Red;
                return;
            }
            if (clsPublicVariable.SelectedTeacher.CollegeId != College)
            {
                MessageBox.Show("استاد انتخاب شده در دانشکده مورد نظر وجود ندارد");
                pnlTeacher.BackColor = Color.Red;
                pnlCollege.BackColor = Color.Red;
                return;
            }
            pnlCollege.BackColor = SystemColors.Control;
            pnlTeacher.BackColor = SystemColors.Control;
            string lesson = cmbLesson.Text;
            if (!db.tblLessons.Any(l => l.LessonName == lesson && l.CollegeId == College))
            {
                MessageBox.Show("چنین درسی در دانشکده انتخاب شده تعریف نشده است");
                pnlLesson.BackColor = Color.Red;
                return;
            }
            pnlLesson.BackColor = SystemColors.Control;
            if (txtYear.Text.Length != 4)
            {
                MessageBox.Show("سال تحصیلی را به درستی وارد کنید");
                pnlYear_Term.BackColor = Color.Red;
                return;
            }
            int year;
            try
            {
                year = Convert.ToInt32(txtYear.Text);
            }
            catch
            {
                MessageBox.Show("سال تحصیلی را به درستی وارد کنید");
                pnlYear_Term.BackColor = Color.Red;
                return;
            }
            pnlYear_Term.BackColor = SystemColors.Control;
            if (!rdbMehr.Checked && !rdbBahman.Checked && !rdbTabestan.Checked)
            {
                MessageBox.Show("ترم را انتخاب کنید");
                pnlYear_Term.BackColor = Color.Red;
                return;
            }
            pnlYear_Term.BackColor = SystemColors.Control;
            int Term;
            if (rdbMehr.Checked)
                Term = Convert.ToInt32(clsPublicVariable.Term.mehr);
            else if (rdbBahman.Checked)
                Term = Convert.ToInt32(clsPublicVariable.Term.bahman);
            else
                Term = Convert.ToInt32(clsPublicVariable.Term.tabestan);
            if (cmbWeek.SelectedIndex == -1)
            {
                MessageBox.Show("روز را انتخاب کنید");
                pnlWeek.BackColor = Color.Red;
                return;
            }
            DateTime StartTime = dtpStartTime.Value;
            DateTime FinishTime = dtpFinishTime.Value;
            TimeSpan classTime = FinishTime - StartTime;
            if (classTime <= TimeSpan.Zero)
            {
                MessageBox.Show("ساعت برگزاری کلاس را به درستی انتخاب کنید");
                pnlWeek.BackColor = Color.Red;
                return;
            }

            List<View_ClassRoom> Classesofteacher = db.View_ClassRoom.Where(c => c.TeacherId == clsPublicVariable.SelectedTeacher.Id && c.Year == year && c.Term == Term).ToList();
            foreach (View_ClassRoom c in Classesofteacher)
            {
                if (c.Day == cmbWeek.SelectedIndex + 1)
                {
                    if (c.StartTime.Value == StartTime.TimeOfDay)
                    {
                        MessageBox.Show("ساعت برگزاری کلاس با کلاس های دیگر استاد تداخل دارد");
                        pnlWeek.BackColor = Color.Red;
                        return;
                    }
                    if (c.StartTime.Value < StartTime.TimeOfDay && c.FinishTime.Value > StartTime.TimeOfDay)
                    {
                        MessageBox.Show("ساعت برگزاری کلاس با کلاس های دیگر استاد تداخل دارد");
                        pnlWeek.BackColor = Color.Red;
                        return;
                    }
                    if (c.StartTime.Value > StartTime.TimeOfDay && c.StartTime.Value < FinishTime.TimeOfDay)
                    {
                        MessageBox.Show("ساعت برگزاری کلاس با کلاس های دیگر استاد تداخل دارد");
                        pnlWeek.BackColor = Color.Red;
                        return;
                    }
                }
            }

            pnlWeek.BackColor = SystemColors.Control;
            int Capacity;
            try
            {
                Capacity = Convert.ToInt32(txtCapacity.Text);
            }
            catch
            {
                MessageBox.Show("ظرفیت کلاس را به درستی بنویسید");
                pnlCapacity.BackColor = Color.Red;
                return;
            }
            pnlCapacity.BackColor = SystemColors.Control;

            tblTeacherLessonMapping NewClassRoom = new tblTeacherLessonMapping()
            {
                TeacherId = clsPublicVariable.SelectedTeacher.Id,
                LessonId = db.tblLessons.Where(l => l.LessonName == lesson).Select(l => l.Id).FirstOrDefault(),
                Year = Convert.ToInt32(txtYear.Text),
                Term = Term,
                Capacity = Capacity,
                CollegeId = College,
                Remain = Capacity,
                Taken = 0,
                StartTime = StartTime.TimeOfDay,
                FinishTime = FinishTime.TimeOfDay,
                Day = cmbWeek.SelectedIndex + 1
            };
            db.tblTeacherLessonMappings.Add(NewClassRoom);
            db.SaveChanges();
            MessageBox.Show("با موفقیت افزوده شد");
            Close();
        }

        private void frmAddClassRoom_Load(object sender, EventArgs e)
        {
            Access();
            frmLoad();
        }
        private void frmLoad()
        {
            University_DBEntities db = new University_DBEntities();
            cmbCollege.Items.Clear();
            cmbLesson.Items.Clear();
            foreach (tblLesson lesson in db.tblLessons)
                cmbLesson.Items.Add(lesson.LessonName);
            foreach (tblCollege college in db.tblColleges)
                cmbCollege.Items.Add(college.CollegeName);
        }
        private void Access()
        {

        }
    }
}
