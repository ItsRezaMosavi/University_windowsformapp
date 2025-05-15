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
    public partial class frmAddLesson : Form
    {
        int College;
        public frmAddLesson(int A = 0)
        {
            InitializeComponent();
            College = A;
        }

        private void frmAddLesson_Load(object sender, EventArgs e)
        {
            Access();
            frmLoad();
        }
        private void frmLoad()
        {
            University_DBEntities db = new University_DBEntities();
            cmbCollege.Items.Clear();
            foreach (tblCollege c in db.tblColleges)
                cmbCollege.Items.Add(c.CollegeName);
            if (College != 0)
                cmbCollege.Text = db.tblColleges.Where(c => c.Id == College).Select(c => c.CollegeName).First();
        }
        private void Access()
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Access();
            University_DBEntities db = new University_DBEntities();
            if (cmbCollege.SelectedIndex == -1)
            {
                MessageBox.Show("دانشکده را انتخاب کنید");
                return;
            }
            College = db.tblColleges.Where(c=>c.CollegeName==cmbCollege.Text).Select(c=>c.Id).First();
            if (txtLessonName.Text != "")
            {
                if (!db.tblLessons.Any(l => l.LessonName == txtLessonName.Text && l.CollegeId == College))
                {
                    DialogResult dr = MessageBox.Show(string.Format("آیا میخواهید درس {0} را به دانشکده {1} اضافه کنید ؟", txtLessonName.Text, cmbCollege.Text), "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    if (dr == DialogResult.Yes)
                    {
                        db.tblLessons.Add(new tblLesson() { LessonName = txtLessonName.Text, CollegeId = College });
                        db.SaveChanges();
                        MessageBox.Show("با موفقیت انجام شد");
                    }
                }
                else
                    MessageBox.Show("این درس قبلا اضافه شده است");
            }
            else
                MessageBox.Show("نام درس را وارد کنید");
        }
    }
}
