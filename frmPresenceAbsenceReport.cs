using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class frmPresenceAbsenceReport : Form
    {
        View_ClassRoom classroom;
        public frmPresenceAbsenceReport(View_ClassRoom A)
        {
            InitializeComponent();
            classroom = A;
        }
        List<View_StudentClassRoomMapping> students = new List<View_StudentClassRoomMapping>();

        private void frmPresenceAbsenceReport_Load(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            students = db.View_StudentClassRoomMapping.Where(s => s.ClassroomId == classroom.Id).ToList();
            fillform();
        }
        private void fillform()
        {
            University_DBEntities db = new University_DBEntities();
            dgvStudents.Rows.Clear();
            int i = 0;
            foreach (View_StudentClassRoomMapping s in students)
            {
                dgvStudents.RowTemplate.Height = 80;
                dgvStudents.Rows.Add();
                if (s.StudentPhotoAddress != null)
                    dgvStudents["clmPhoto", i].Value = Image.FromFile(s.StudentPhotoAddress);
                dgvStudents["clmFirstName", i].Value = s.StudentFirstName;
                dgvStudents["clmLastName", i].Value = s.StudentLastName;
                dgvStudents["clmUserName", i].Value = s.StudentUserName;
                dgvStudents["clmClassRoomId", i].Value = s.ClassroomId;
                dgvStudents["clmTeacherName", i].Value = s.TeacherFirstName + " " + s.TeacherLastName;
                dgvStudents["clmLessonName", i].Value = s.LessonName;
                dgvStudents["clmPresenceCount", i].Value = db.tblPresenceAbsences.Where(c => c.ClassRoomId == s.ClassroomId && c.IsPresent && c.StudentId == s.StudentId).Count();
                dgvStudents["clmAbsenceCount",i].Value = db.tblPresenceAbsences.Where(c=>c.ClassRoomId == s.ClassroomId &&  !c.IsPresent && c.StudentId == s.StudentId).Count();
                i++;
            }
        }
    }
}
