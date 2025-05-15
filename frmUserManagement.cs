using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class frmUserManagement : Form
    {
        int College = -1;
        List<View_User> users = new List<View_User>();
        tblRole Role;
        public frmUserManagement(tblRole R, int C = -1)
        {
            InitializeComponent();
            Role = R;
            College = C;
        }

        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            Default();
        }
        private void Default()
        {
            tmrClock_Tick(null, null);
            Access();
            University_DBEntities db = new University_DBEntities();
            List<tblRoleToUser> usertorole = db.tblRoleToUsers.Where(u => u.RoleId == Role.Id).ToList();
            users.Clear();
            foreach (tblRoleToUser ur in usertorole)
                users.Add(db.View_User.Where(u => u.UserId == ur.UserId).First());
            lblTitle.Text = "مدیریت " + Role.Title;
            cmbCollege.Items.Clear();
            foreach (tblCollege c in db.tblColleges)
                cmbCollege.Items.Add(c.CollegeName);
            if (College != -1)
                cmbCollege.Text = db.tblColleges.Where(c => c.Id == College).Select(c => c.CollegeName).First();
            btnFilter_Click(null, null);
            Filldgv();
        }

        private void Access()
        {
            University_DBEntities db = new University_DBEntities();
            if (!clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == Role.EnglishName + " Management").Select(p => p.Id).First()))
                Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Hide();
            new frmAddUser(Role).ShowDialog();
            Default();
            Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            int index = dgvUsers.CurrentRow.Index;
            string username = dgvUsers["clmUserName", index].Value.ToString();
            tblUser userEdit = db.tblUsers.Where(u => u.UserName == username).FirstOrDefault();
            if (userEdit != null)
            {
                Hide();
                new frmEditUser(Role,userEdit).ShowDialog();
                Show();
                Default();
            }
            Filldgv();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            int index = dgvUsers.CurrentRow.Index;
            string username = dgvUsers["clmUserName", index].Value.ToString();
            tblUser userDelete = db.tblUsers.Where(u => u.UserName == username).FirstOrDefault();
            List<tblRoleToUser> userRole = db.tblRoleToUsers.Where(r => r.UserId == userDelete.Id).ToList();
            DialogResult dr = MessageBox.Show(string.Format("با ادامه این عملیات کاربر {0} را حذف می کنید.آیا می خواهید حذف شود؟", userDelete.FirstName + " " + userDelete.LastName), "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            if (userRole.Count > 1 && dr == DialogResult.Yes)
            {
                db.tblRoleToUsers.Remove(userRole.Where(u => u.RoleId == Role.Id).FirstOrDefault());
                MessageBox.Show("کاربر مورد نظر حذف شد");
            }
            else if (dr == DialogResult.Yes && userRole.Count == 1)
            {
                db.tblRoleToUsers.RemoveRange(userRole);
                db.tblUsers.Remove(userDelete);
                MessageBox.Show("کاربر مورد نظر حذف شد");
            }
            db.SaveChanges();
            Default();
        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            List<tblRoleToUser> usertorole = db.tblRoleToUsers.Where(u => u.RoleId == Role.Id).ToList();
            users.Clear();
            foreach (tblRoleToUser ur in usertorole)
                users.AddRange(db.View_User.Where(u => u.UserId == ur.UserId).ToList());
            Filldgv();
        }


        private void Filldgv()
        {
            University_DBEntities db = new University_DBEntities();
            dgvUsers.Rows.Clear();
            int i = 0;
            foreach (View_User user in users)
            {
                dgvUsers.RowTemplate.Height = 80;
                dgvUsers.Rows.Add();
                if (user.PhotoAddress != null)
                    dgvUsers["clmPhoto", i].Value = Image.FromFile(user.PhotoAddress);
                dgvUsers["clmUserName", i].Value = user.UserName;
                dgvUsers["clmFirstName", i].Value = user.FirstName;
                dgvUsers["clmLastName", i].Value = user.LastName;
                dgvUsers["clmNationalCode", i].Value = user.NationalCode;
                dgvUsers["clmFatherName", i].Value = user.FathersName;
                if (user.GenderTitle == "Female")
                    dgvUsers["clmGender", i].Value = "خانم";
                else
                    dgvUsers["clmGender", i].Value = "آقا";
                dgvUsers["clmPhoneNumber", i].Value = user.PhoneNumber;

                List<int> rolesId = db.tblRoleToUsers.Where(r => r.UserId == user.UserId).Select(r => r.RoleId).ToList();
                foreach (int role in rolesId)
                    dgvUsers["clmRole", i].Value += db.tblRoles.Where(r => r.Id == role).Select(r => r.Title).FirstOrDefault() + " , ";
                dgvUsers["clmCollegeName", i].Value = user.CollegeName;
                dgvUsers["clmEducationalField", i].Value = user.Educational_Field;
                i++;
            }
        }


        private void tmrClock_Tick(object sender, EventArgs e)
        {
            clsPublicVariable.dt = DateTime.Now;
            lblTime.Text = clsPublicVariable.dt.Hour + " : " + clsPublicVariable.dt.Minute;
            lblDate.Text = clsPublicVariable.prs.GetYear(clsPublicVariable.dt) + " / " + clsPublicVariable.prs.GetMonth(clsPublicVariable.dt) + " / " + clsPublicVariable.prs.GetDayOfMonth(clsPublicVariable.dt);
        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();

            if (cmbCollege.SelectedIndex != -1)
                College = db.tblColleges.Where(c => c.CollegeName.Contains(cmbCollege.Text)).Select(c => c.Id).FirstOrDefault();
            List<tblRoleToUser> usertorole = db.tblRoleToUsers.Where(u => u.RoleId == Role.Id).ToList();
            users.Clear();
            foreach (tblRoleToUser ur in usertorole)
                users.Add(db.View_User.Where(u => u.UserId == ur.UserId).First());
            users = users.Where(u => u.FirstName.Contains(txtFirstName.Text) && u.LastName.Contains(txtLastName.Text) && u.NationalCode.Contains(txtNationalCode.Text) && u.UserName.Contains(txtUserName.Text)&&u.CollegeName.Contains(cmbCollege.Text)).ToList();
            Filldgv();
        }
    }
}
