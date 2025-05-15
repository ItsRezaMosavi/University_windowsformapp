using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class frmSearchUser : Form
    {
        int From;
        public frmSearchUser(int j = 0)
        {
            InitializeComponent();
            // 0 == from main 1 == from send
            From = j;
        }
        List<View_User> users = new List<View_User>();
        List<View_UserRoles> UserRoles = new List<View_UserRoles>();
        private void frmSearchUser_Load(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            foreach (tblCollege c in db.tblColleges)
                cmbCollege.Items.Add(c.CollegeName);
            foreach (tblRole r in db.tblRoles)
                cmbUserRoles.Items.Add(r.Title);
            Fillfrm();
        }
        private void Fillfrm()
        {
            University_DBEntities db = new University_DBEntities();
            users.Clear();
            UserRoles.Clear();
            UserRoles.AddRange(db.View_UserRoles.Where(r => r.RoleTitle.Contains(cmbUserRoles.Text)).ToList());
            foreach (View_UserRoles r in UserRoles)
                users.Add(db.View_User.Where(u => u.UserId == r.UserId).FirstOrDefault());
            users = users.Where(u => u.FirstName.Contains(txtFirstName.Text) && u.LastName.Contains(txtLastName.Text) && u.UserName.Contains(txtUserName.Text) && u.CollegeName.Contains(cmbCollege.Text)).ToList();
            filldgv();
        }
        private void filldgv()
        {
            int i = 0;
            dgvUsers.Rows.Clear();
            University_DBEntities db = new University_DBEntities();
            foreach (View_User user in users)
            {
                dgvUsers.RowTemplate.Height = 80;
                dgvUsers.Rows.Add();
                if (user.PhotoAddress != null)
                    dgvUsers["clmPhoto", i].Value = Image.FromFile(user.PhotoAddress);
                dgvUsers["clmUserName", i].Value = user.UserName;
                dgvUsers["clmFirstName", i].Value = user.FirstName;
                dgvUsers["clmLastName", i].Value = user.LastName;
                if (user.GenderTitle == "Female")
                    dgvUsers["clmGender", i].Value = "خانم";
                else
                    dgvUsers["clmGender", i].Value = "آقا";

                List<int> rolesId = db.tblRoleToUsers.Where(r => r.UserId == user.UserId).Select(r => r.RoleId).ToList();
                foreach (int role in rolesId)
                    dgvUsers["clmRole", i].Value += db.tblRoles.Where(r => r.Id == role).Select(r => r.Title).FirstOrDefault() + " , ";
                dgvUsers["clmCollegeName", i].Value = user.CollegeName;
                dgvUsers["clmEducationalField", i].Value = user.Educational_Field;
                i++;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Fillfrm();
        }

        private void btnSelectUser_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            int index = dgvUsers.CurrentRow.Index;
            string username = dgvUsers["clmUserName", index].Value.ToString();
            clsPublicVariable.Selected_Receiver = db.View_User.Where(u => u.UserName == username).FirstOrDefault();
            Close();
            if (From == 0)
                new frmSendMessage(clsPublicVariable.Selected_Receiver).ShowDialog();
            else
                Close();
        }
    }
}
