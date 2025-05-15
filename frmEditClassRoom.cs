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
    public partial class frmEditClassRoom : Form
    {
        tblTeacherLessonMapping ClassRoom;
        public frmEditClassRoom(tblTeacherLessonMapping A)
        {
            InitializeComponent();
            ClassRoom = A;
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

            List<View_ClassRoom> Classesofteacher = db.View_ClassRoom.Where(c => c.TeacherId == clsPublicVariable.SelectedTeacher.Id && c.Year == year && c.Term == Term && c.Id != ClassRoom.Id).ToList();
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
            ClassRoom.CollegeId = db.tblColleges.Where(c => c.CollegeName == cmbCollege.Text).Select(c => c.Id).First();
            ClassRoom.TeacherId = clsPublicVariable.SelectedTeacher.Id;
            ClassRoom.LessonId = db.tblLessons.Where(l => l.LessonName == cmbLesson.Text).Select(l => l.Id).First();
            ClassRoom.Capacity = Capacity;
            ClassRoom.Term = Term;
            ClassRoom.Year = year;
            ClassRoom.Day = cmbWeek.SelectedIndex + 1;
            ClassRoom.StartTime = StartTime.TimeOfDay;
            ClassRoom.FinishTime = FinishTime.TimeOfDay;
            ClassRoom.Remain = Capacity - ClassRoom.Taken;
            if(ClassRoom.Remain<0)
            {
                MessageBox.Show("ظرفیت از حد مجاز کمتر است");
                return;
            }
            db.tblTeacherLessonMappings.AddOrUpdate(ClassRoom);
            db.SaveChanges();
            MessageBox.Show("با موفقیت ویرایش شد");
            Close();
        }

        private void frmEditClassRoom_Load(object sender, EventArgs e)
        {
            Access();
            University_DBEntities db = new University_DBEntities();
            cmbCollege.Items.Clear();
            cmbLesson.Items.Clear();
            foreach (tblCollege c in db.tblColleges)
                cmbCollege.Items.Add(c.CollegeName);
            foreach (tblLesson l in db.tblLessons)
                cmbLesson.Items.Add(l.LessonName);
            cmbCollege.Text = db.tblColleges.Where(c => c.Id == ClassRoom.CollegeId).Select(c => c.CollegeName).FirstOrDefault();
            clsPublicVariable.SelectedTeacher = db.tblUsers.Where(u => u.Id == ClassRoom.TeacherId).FirstOrDefault();
            txtTeacher.Text = clsPublicVariable.SelectedTeacher.FirstName + "  " + clsPublicVariable.SelectedTeacher.LastName;
            cmbLesson.Text = db.tblLessons.Where(l => l.Id == ClassRoom.LessonId).Select(l => l.LessonName).FirstOrDefault();
            txtYear.Text = ClassRoom.Year.ToString();
            if (ClassRoom.Term == Convert.ToInt32(clsPublicVariable.Term.mehr))
                rdbMehr.Checked = true;
            else if (ClassRoom.Term == Convert.ToInt32(clsPublicVariable.Term.bahman))
                rdbBahman.Checked = true;
            else if (ClassRoom.Term == Convert.ToInt32(clsPublicVariable.Term.tabestan))
                rdbTabestan.Checked = true;
            txtCapacity.Text = ClassRoom.Capacity.ToString();
        }
        private void Access()
        {
    
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
    }
}
