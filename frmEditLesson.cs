using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static University.clsPublicVariable;

namespace University
{
    public partial class frmEditLesson : Form
    {
        tblLesson lesson;
        public frmEditLesson(tblLesson l)
        {
            InitializeComponent();
            lesson = l;
        }

        private void frmEditLesson_Load(object sender, EventArgs e)
        {
            Access();
            frmload();
        }
        private void frmload()
        {
            University_DBEntities db = new University_DBEntities();
            cmbCollege.Items.Clear();
            foreach (tblCollege c in db.tblColleges)
                cmbCollege.Items.Add(c.CollegeName);
            txtLessonName.Text = lesson.LessonName;
            cmbCollege.Text = db.tblColleges.Where(c => c.Id == lesson.CollegeId).Select(c => c.CollegeName).First();
        }
        private void Access()
        {
 
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            string lessonName = txtLessonName.Text;
            if (cmbCollege.SelectedIndex == -1)
            {
                MessageBox.Show("دانشکده را انتخاب کنید");
                return;
            }
            int CollegeId = db.tblColleges.Where(c => c.CollegeName == cmbCollege.Text).Select(c => c.Id).First();

            DialogResult dr, dr1;
            if (lessonName != lesson.LessonName)
                dr = MessageBox.Show(string.Format("آیا میخواهید اسم درس را از {0} به {1} تغییر دهید ؟", lesson.LessonName, lessonName), "اخطار", MessageBoxButtons.YesNo);
            else
                dr = DialogResult.No;

            if (CollegeId != lesson.CollegeId)
                dr1 = MessageBox.Show("آیا میخواهید دانشکده را تغییر دهید ؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            else
                dr1 = DialogResult.No;

            if (dr == DialogResult.Yes && dr1 == DialogResult.Yes)
            {
                if (!db.tblLessons.Any(l => l.LessonName == lessonName && l.CollegeId == CollegeId))
                {
                    lesson.CollegeId = CollegeId;
                    lesson.LessonName = lessonName;
                    db.tblLessons.Add(lesson);
                    db.SaveChanges();
                    MessageBox.Show("با موفقیت تغییر کرد");
                }
                else
                    MessageBox.Show("این درس قبلا در دانشکده مورد نظر اضافه شده است");
            }
        }
    }
}
