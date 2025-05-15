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
    public partial class frmPresenceAbsence : Form
    {
        View_ClassRoom classroom;
        int SessionNumber;
        public frmPresenceAbsence(View_ClassRoom A, int B)
        {
            InitializeComponent();
            classroom = A;
            SessionNumber = B;
        }
        List<View_StudentClassRoomMapping> students;
        View_StudentClassRoomMapping student;
        List<tblPresenceAbsence> presenceAbsence = new List<tblPresenceAbsence>();
        int i = -1;
        private void tmrMain_Tick(object sender, EventArgs e)
        {
            clsPublicVariable.dt = DateTime.Now;
            lblTime.Text = clsPublicVariable.dt.Hour + " : " + clsPublicVariable.dt.Minute;
            lblDate.Text = clsPublicVariable.prs.GetYear(clsPublicVariable.dt) + " / " + clsPublicVariable.prs.GetMonth(clsPublicVariable.dt) + " / " + clsPublicVariable.prs.GetDayOfMonth(clsPublicVariable.dt);
        }

        private void frmPresenceAbsence_Load(object sender, EventArgs e)
        {
            tmrMain_Tick(null, null);
            University_DBEntities db = new University_DBEntities();
            students = db.View_StudentClassRoomMapping.Where(s => s.ClassroomId == classroom.Id).ToList();
            clsPublicVariable.dt = DateTime.Now;
            fillform();
        }
        private void fillform()
        {
            University_DBEntities db = new University_DBEntities();
            i++;
            if (students.Count <= i)
            {
                db.tblPresenceAbsences.AddRange(presenceAbsence);
                db.SaveChanges();
                MessageBox.Show("حضور غیاب همه دانش آموزان کلاس ثبت شد");
                Close();
                return;
            }
            student = students[i];
            if (student.StudentPhotoAddress != null)
                pcbPhoto.Image = Image.FromFile(student.StudentPhotoAddress);
            else
                pcbPhoto.Image = null;
            lblFirstName.Text = "نام : " + student.StudentFirstName;
            lblLastName.Text = "نام خانوادگی : " + student.StudentLastName;
            lblUserName.Text = "کد دانشجویی : " + student.StudentUserName;
            lblClassRoomId.Text = "کد کلاس : " + student.ClassroomId;
            lblLessonName.Text = "نام درس : " + student.LessonName;
            lblClassCount.Text = "تعداد دانشجو ها : " + students.Count;
            lblSessionNumber.Text = "جلسه شماره : " + SessionNumber;
        }

        private void btnAbsent_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            tblPresenceAbsence pre = new tblPresenceAbsence()
            {
                StudentId = student.StudentId,
                ClassRoomId = classroom.Id,
                SessionNumber = SessionNumber,
                IsPresent = false
            };
            presenceAbsence.Add(pre);
            fillform();
        }

        private void btnPresent_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            tblPresenceAbsence pre = new tblPresenceAbsence()
            {
                StudentId = student.StudentId,
                ClassRoomId = classroom.Id,
                SessionNumber = SessionNumber,
                IsPresent = true
            };
            presenceAbsence.Add(pre);
            fillform();
        }

        private void pcbPhoto_Click(object sender, EventArgs e)
        {

        }
    }
}
