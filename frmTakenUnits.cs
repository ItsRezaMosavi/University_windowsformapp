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
    public partial class frmTakenUnits : Form
    {
        public frmTakenUnits()
        {
            InitializeComponent();
        }
        List<View_StudentClassRoomMapping> classes = new List<View_StudentClassRoomMapping>();
        private void frmTakenUnits_Load(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            classes = db.View_StudentClassRoomMapping.Where(c => c.StudentId == clsPublicVariable.User.UserId).ToList();
        }
        private void filldgv()
        {
            University_DBEntities db = new University_DBEntities();
            dgvClassRoom.Rows.Clear();
            int i = 0;
            foreach (View_StudentClassRoomMapping c in classes)
            {
                dgvClassRoom.Rows.Add();
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
                dgvClassRoom["clmUnit", i].Value = c.Unit;
                dgvClassRoom["clmStartTime", i].Value = c.StartTime;
                dgvClassRoom["clmFinishTime", i].Value = c.FinishTime;
                dgvClassRoom["clmIsPassed",i].Value = c.IsPassed;
                i++;
            }
        }
    }
}
