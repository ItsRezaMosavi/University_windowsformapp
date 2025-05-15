using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class frmSelectClassRoom : Form
    {
        public frmSelectClassRoom()
        {
            InitializeComponent();
        }

        List<View_ClassRoom> allClass = new List<View_ClassRoom>();
        private void frmSelectClassRoom_Load(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            foreach (tblCollege c in db.tblColleges)
                cmbCollegeName.Items.Add(c.CollegeName);
            allClass = db.View_ClassRoom.ToList();
            fillform();
        }
        private void fillform()
        {
            int i = 0;
            dgvClassRoom.Rows.Clear();
            foreach (View_ClassRoom c in allClass)
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
                dgvClassRoom["clmAvailableCapacity", i].Value = c.Remain;
                dgvClassRoom["clmCapacity", i].Value = c.Capacity;

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
                i++;
            }
        }

        private void btnDeleteFilter_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            allClass = db.View_ClassRoom.ToList();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            allClass = allClass.Where(c => c.Id.ToString().Contains(txtClassId.Text) && c.LessonId.ToString().Contains(txtLessonId.Text) && c.LessonName.Contains(txtLessonName.Text) && c.CollegeId.ToString().Contains(txtCollegeId.Text) && c.CollegeName.Contains(cmbCollegeName.Text) && c.TeacherUserName.Contains(txtTeacherUserName.Text) && c.TeacherFirstName.Contains(txtTeacherFirstName.Text) && c.TeacherLastName.Contains(txtTeacherLastName.Text)).ToList();
            fillform();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            int index = dgvClassRoom.CurrentRow.Index;
            int ClassRoomId = Convert.ToInt32(dgvClassRoom["clmClassRoomId", index].Value);
            if (Convert.ToInt32(dgvClassRoom["clmAvailableCapacity", index].Value) != 0)
            {
                clsPublicVariable.SelectedClasstoAdd = allClass.Where(c => c.Id == ClassRoomId).First();
                Close();
            }
            else
                MessageBox.Show("این کلاس ظرفیت ندارد");
        }

        private void pnlFilter_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
