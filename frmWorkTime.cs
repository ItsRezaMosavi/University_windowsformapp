using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class frmWorkTime : Form
    {
        public frmWorkTime()
        {
            InitializeComponent();
        }

        List<tblUser> users = new List<tblUser>();
        DateTime startTime;
        DateTime endTime;
        tblUser selecteduser;
        private void frmWorkTime_Load(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            int student = Convert.ToInt32(clsPublicVariable.UsersType.Student);
            users = db.tblUsers.Where(u => db.tblRoleToUsers.Any(r => r.RoleId != clsPublicVariable.StudentId && r.UserId == u.Id)).ToList();
            cmbStartDay.Items.Clear();
            cmbStartMonth.Items.Clear();
            cmbStartYear.Items.Clear();
            cmbFinishDay.Items.Clear();
            cmbFinishMonth.Items.Clear();
            cmbFinishYear.Items.Clear();

            for (int i = 1; i <= 31; i++)
            {
                if (i < 10)
                {
                    cmbFinishDay.Items.Add('0' + i.ToString());
                    cmbStartDay.Items.Add('0' + i.ToString());
                }
                else
                {
                    cmbFinishDay.Items.Add(i.ToString());
                    cmbStartDay.Items.Add(i.ToString());
                }
            }
            for (int i = 1; i <= 12; i++)
            {
                if (i < 10)
                {
                    cmbStartMonth.Items.Add('0' + i.ToString());
                    cmbFinishMonth.Items.Add('0' + i.ToString());
                }
                else
                {
                    cmbStartMonth.Items.Add(i.ToString());
                    cmbFinishMonth.Items.Add(i.ToString());
                }
            }
            for (int i = 1000; i < 1500; i++)
            {
                cmbStartYear.Items.Add(i.ToString());
                cmbFinishYear.Items.Add(i.ToString());
            }
            Filldgv();
        }

        private void Filldgv()
        {
            University_DBEntities db = new University_DBEntities();
            dgvUsers.Rows.Clear();
            int i = 0;
            foreach (tblUser user in users)
            {
                dgvUsers.Rows.Add();
                dgvUsers["clmUserName", i].Value = user.UserName;
                dgvUsers["clmFirstName", i].Value = user.FirstName;
                dgvUsers["clmLastName", i].Value = user.LastName;
                dgvUsers["clmNationalCode", i].Value = user.NationalCode;
                dgvUsers["clmFathersName", i].Value = user.FathersName;
                if (user.GenderId == db.tblGenders.Where(g => g.GenderTitle == "Female").Select(g => g.Id).First())
                    dgvUsers["clmGender", i].Value = "خانم";
                else
                    dgvUsers["clmGender", i].Value = "آقا";

                dgvUsers["clmPhoneNumber", i].Value = user.PhoneNumber;
                dgvUsers["clmCollege", i].Value = db.tblColleges.Where(c => c.Id == user.CollegeId).Select(c => c.CollegeName).FirstOrDefault();
                dgvUsers["clmEducational_Field", i].Value = db.tblEducationalFields.Where(c => c.Id == user.Educational_Field_Id).Select(c => c.Educational_Field).FirstOrDefault();
                i++;
            }
        }
        private void pnlUsers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectDate_Click(object sender, EventArgs e)
        {
            string date = cmbStartYear.Text + "/" + cmbStartMonth.Text + "/" + cmbStartDay.Text;
            PersianDateTime prs = PersianDateTime.Parse(date);
            startTime = prs.ToDateTime();
            date = cmbFinishYear.Text + "/" + cmbFinishMonth.Text + "/" + cmbFinishDay.Text;
            prs = PersianDateTime.Parse(date);
            endTime = prs.ToDateTime();
            University_DBEntities db = new University_DBEntities();
            DateTime worktime = new DateTime();
            foreach (View_UserLoging w in db.View_UserLoging.Where(l => l.LogoutDatetime != null && l.UserName == selecteduser.UserName && l.LoginDatetime >= startTime && l.LoginDatetime <= endTime))
            {
                worktime.Add(w.LogoutDatetime.Value.Subtract(w.LoginDatetime));
            }

            txtWorkHour.Text = worktime.Hour.ToString();
            txtWorkMinute.Text = worktime.Minute.ToString();
        }

        private void btnSelectUser_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            int index = dgvUsers.CurrentRow.Index;
            string username = dgvUsers["clmUserName", index].Value.ToString();
            selecteduser = db.tblUsers.Where(u => u.UserName == username).FirstOrDefault();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            DateTime worktime = new DateTime();
            DateTime dt = DateTime.Now.Date;
            List<View_UserLoging> a = db.View_UserLoging.Where(l => l.LogoutDatetime != null && l.UserName == selecteduser.UserName && l.LoginDatetime.Equals(dt)).ToList();
            foreach (View_UserLoging w in a)
            {
                worktime.Add(w.LogoutDatetime.Value.Subtract(w.LoginDatetime));
            }
            txtWorkHour.Text = worktime.Hour.ToString();
            txtWorkMinute.Text = worktime.Minute.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            DateTime worktime = new DateTime();
            DateTime dt = DateTime.Now;
            foreach (View_UserLoging w in db.View_UserLoging.Where(l => l.LogoutDatetime != null && l.UserName == selecteduser.UserName && l.LoginDatetime.Month.Equals(dt.Month) && l.LoginDatetime.Year.Equals(dt.Year)))
            {
                worktime.Add(w.LogoutDatetime.Value.Subtract(w.LoginDatetime));
            }
            txtWorkHour.Text = worktime.Hour.ToString();
            txtWorkMinute.Text = worktime.Minute.ToString();
        }
    }
}
