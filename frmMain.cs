using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (clsPublicVariable.User == null)
                return;
            University_DBEntities db = new University_DBEntities();

            db.SaveChanges();
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Access();
            frmDefault();
            clsPublicVariable.Folder();
        }
        private void frmDefault()
        {
            tmrClock_Tick(null, null);
            
        }


        private void تغییررمزعبورToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmChangePassword().ShowDialog();
            Show();
        }

        private void اطلاعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmUserInformation().ShowDialog();
            Show();
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            clsPublicVariable.dt = DateTime.Now;
            lblTime.Text = clsPublicVariable.dt.Hour + " : " + clsPublicVariable.dt.Minute;
            lblDate.Text = clsPublicVariable.prs.GetYear(clsPublicVariable.dt) + " / " + clsPublicVariable.prs.GetMonth(clsPublicVariable.dt) + " / " + clsPublicVariable.prs.GetDayOfMonth(clsPublicVariable.dt);
        }

        private void درجنمرهToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmRegisterScore_Click(object sender, EventArgs e)
        {

        }

        private void مدیریتدانشکدهToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void حقوقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            Hide();
            new frmCollegeManagement(db.tblColleges.Where(c => c.CollegeName == "حقوق").First()).ShowDialog();
            Show();
        }

        private void علومپایهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            Hide();
            new frmCollegeManagement(db.tblColleges.Where(c => c.CollegeName == "علوم پایه").First()).ShowDialog();
            Show();
        }

        private void فنیمهندسیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            Hide();
            new frmCollegeManagement(db.tblColleges.Where(c => c.CollegeName == "فنی مهندسی").First()).ShowDialog();
            Show();
        }

        private void پزشکیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            Hide();
            new frmCollegeManagement(db.tblColleges.Where(c => c.CollegeName == "پزشکی").First()).ShowDialog();
            Show();
        }

        private void ادبیاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            Hide();
            new frmCollegeManagement(db.tblColleges.Where(c => c.CollegeName == "ادبیات").First()).ShowDialog();
            Show();
        }

        private void کشاورزیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            Hide();
            new frmCollegeManagement(db.tblColleges.Where(c => c.CollegeName == "کشاورزی").First()).ShowDialog();
            Show();
        }






        private void مدیریتدانشگاهToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void مدیریتدانشگاهToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            new frmUniversityManagement().ShowDialog();
            Show();
        }



        private void انتخابواحدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            if (!clsPublicVariable.UserRoleAccess.Any(r => r.SystemPartId == 7))
                return;
            Hide();
            if (clsPublicVariable.UserRoles.Contains(db.tblRoles.Where(r => r.Id == clsPublicVariable.StudentId).First()))
                new frmStudentClassRoomMappingbyStudent().ShowDialog();
            else
                new frmStudentClassRoomMapping().ShowDialog();
            Show();
        }

        private void tsmClassManagement_Click_1(object sender, EventArgs e)
        {
            Hide();
            new frmClassRoomManagement(clsPublicVariable.Year, Convert.ToInt32(clsPublicVariable.openTerm)).ShowDialog();
            Show();
        }

        private void tsmCollegeManagement_Click(object sender, EventArgs e)
        {

        }

        private void tsmClassRoom_Click(object sender, EventArgs e)
        {

        }

        private void خروجازحسToolStripMenuItem_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            tblLoging loging = db.tblLogings.Where(l => l.UserId == clsPublicVariable.User.UserId).OrderByDescending(l => l.LoginDatetime).FirstOrDefault();
            loging.LogoutDatetime = DateTime.Now;
            db.tblLogings.AddOrUpdate(loging);
            db.SaveChanges();



            clsPublicVariable.User = null;

            Hide();
            new frmLogin().ShowDialog();
        }

        private void tsmUserWorkHour_Click(object sender, EventArgs e)
        {
            Hide();
            new frmWorkTime().ShowDialog();
            Show();
        }


        private void درخواستمجوزانتخابواحدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmStudentClassRoomMappingAccessRequest().ShowDialog();
            Show();
        }

        private void پرداختشهریهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            tblUser user = db.tblUsers.Where(u => u.Id == clsPublicVariable.User.UserId).First();
            user.IsPay = true;
            db.SaveChanges();
        }

        private void tsmMyAllClasses_Click(object sender, EventArgs e)
        {
            Hide();
            new frmSelectYearTerm().ShowDialog();
            Show();
        }

        private void tsmClasses_Click(object sender, EventArgs e)
        {
            Hide();
            new frmThisTermClasses().ShowDialog();
            Show();
        }

        private void tsmLoginLogoutReport_Click(object sender, EventArgs e)
        {
            Hide();
            new frmLoginLogoutReport().ShowDialog();
            Show();
        }

        private void tsmWeekPlan_Click(object sender, EventArgs e)
        {

        }

        private void tsmRolesManagement_Click(object sender, EventArgs e)
        {
            Hide();
            new frmRolesManagement().ShowDialog();
            Show();
        }

        private void tsmSystemPartManagement_Click(object sender, EventArgs e)
        {
            Hide();
            new frmSystemPartManagement().ShowDialog();
            Show();
        }

        private void roleAccessManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmRoleAccessManagement().ShowDialog();
            Show();
        }

        private void tsmUserRoleManagement_Click(object sender, EventArgs e)
        {
            Hide();
            new frmUserToRoleManagement().ShowDialog();
            Show();
        }

        private void tsmUserManagement_Click(object sender, EventArgs e)
        {
            Hide();
            new frmSelectRole().ShowDialog();
            Show();
        }

        private void پروفایلToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void اقتصادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            Hide();
            new frmCollegeManagement(db.tblColleges.Where(c => c.CollegeName == "اقتصاد").First()).ShowDialog();
            Show();
        }

        private void tsmTakenUnits_Click(object sender, EventArgs e)
        {
            Hide();
            new frmTakenUnits().ShowDialog();
            Show();
        }

        private void tsmEducationReport_Click(object sender, EventArgs e)
        {
            Hide();
            new frmEducationReport().ShowDialog();
            Show();
        }

        private void Access()
        {
            University_DBEntities db = new University_DBEntities();
            if (clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Profile").Select(p => p.Id).First()))
            {
                tsmProfile.Visible = true;
                tsmProfile.Enabled = true;
            }
            if (clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Financial").Select(p => p.Id).First()))
            {
                tsmFinancialActivity.Visible = true;
                tsmFinancialActivity.Enabled = true;
            }
            if (clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "University Management").Select(p => p.Id).First()))
            {
                tsmUniversityHeadship.Visible = true;
                tsmUniversityHeadship.Enabled = true;
            }
            if (clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "College Management").Select(p => p.Id).First()))
            {
                tsmCollegeManagement.Visible = true;
                tsmCollegeManagement.Enabled = true;
            }
            if (clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Law College Management").Select(p => p.Id).First()))
            {
                tsmLawCollegeManagement.Visible = true;
                tsmLawCollegeManagement.Enabled = true;
            }
            if (clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Basic Science College Management").Select(p => p.Id).First()))
            {
                tsmBasicScienceCollegeManagement.Visible = true;
                tsmBasicScienceCollegeManagement.Enabled = true;
            }
            if (clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Engineering College Management").Select(p => p.Id).First()))
            {
                tsmEngineeringCollegeManagement.Visible = true;
                tsmEngineeringCollegeManagement.Enabled = true;
            }
            if (clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Medical College Management").Select(p => p.Id).First()))
            {
                tsmMedicalCollegeManagement.Visible = true;
                tsmMedicalCollegeManagement.Enabled = true;
            }
            if (clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Literature College Management").Select(p => p.Id).First()))
            {
                tsmLiteratureCollegeManagement.Visible = true;
                tsmLiteratureCollegeManagement.Enabled = true;
            }
            if (clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Agriculture College Management").Select(p => p.Id).First()))
            {
                tsmAgricultureCollegeManagement.Visible = true;
                tsmAgricultureCollegeManagement.Enabled = true;
            }
            if (clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Economy College Management").Select(p => p.Id).First()))
            {
                tsmEconomyCollegeManagement.Visible = true;
                tsmEconomyCollegeManagement.Enabled = true;
            }
            if (clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "User Management").Select(p => p.Id).First()))
            {
                tsmUserManagement.Visible = true;
                tsmUserManagement.Enabled = true;
            }
            if (clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Class Room Management").Select(p => p.Id).First()))
            {
                tsmClassRoom.Visible = true;
                tsmClassRoom.Enabled = true;
            }
            if (clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Student Class Room Mapping").Select(p => p.Id).First()))
            {
                tsmStudentClassRoomMapping.Visible = true;
                tsmStudentClassRoomMapping.Enabled = true;
            }
            if (clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Education Condition").Select(p => p.Id).First()))
            {
                tsmEducationCondition.Visible = true;
                tsmEducationCondition.Enabled = true;
            }
            if (clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "License").Select(p => p.Id).First()))
            {
                tsmLicense.Visible = true;
                tsmLicense.Enabled = true;
            }
            if (clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Admin").Select(p => p.Id).First()))
            {
                tsmAdmin.Visible = true;
                tsmAdmin.Enabled = true;
            }
        }

        private void درخواستهایکاربرانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmRequests().ShowDialog();
            Show();
        }

        private void پیامهایدریافتیToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void پیامهایخواندهنشدهToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnsChat_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void پیامهایدریافتیToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void tsmSearchUsers_Click(object sender, EventArgs e)
        {
            Hide();
            new frmSearchUser().ShowDialog();
            Show();
        }

        private void tsmSendMessage_Click(object sender, EventArgs e)
        {
            Hide();
            new frmSendMessage().ShowDialog();
            Show();
        }
    }
}
