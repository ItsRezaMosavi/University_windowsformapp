using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class frmUserToRoleManagement : Form
    {
        public frmUserToRoleManagement()
        {
            InitializeComponent();
        }
        List<View_User> Users = new List<View_User>();
        private void frmUserToRoleManagement_Load(object sender, EventArgs e)
        {
            Access();
            University_DBEntities db = new University_DBEntities();
            foreach (tblRole r in db.tblRoles)
                cmbRole.Items.Add(r.Title);
            Users = db.View_User.ToList();
            fillfrm();
        }
        private void fillfrm()
        {
            Access();
            University_DBEntities db = new University_DBEntities();
            dgvUsers.Rows.Clear();
            int i = 0;
            foreach (View_User u in Users)
            {
                dgvUsers.RowTemplate.Height = 80;
                dgvUsers.Rows.Add();
                if (u.PhotoAddress != null)
                    dgvUsers["clmPhoto", i].Value = Image.FromFile(u.PhotoAddress);
                dgvUsers["clmUserName", i].Value = u.UserName;
                dgvUsers["clmFirstName", i].Value = u.FirstName;
                dgvUsers["clmLastName", i].Value = u.LastName;
                dgvUsers["clmNationalCode", i].Value = u.NationalCode;
                List<int> rolesId = db.tblRoleToUsers.Where(r => r.UserId == u.UserId).Select(r => r.RoleId).ToList();
                foreach (int role in rolesId)
                    dgvUsers["clmRoles", i].Value += db.tblRoles.Where(r => r.Id == role).Select(r => r.Title).FirstOrDefault() + " , ";
                dgvUsers["clmFatherName", i].Value = u.FathersName;
                dgvUsers["clmCollegeName", i].Value = u.CollegeName;
                dgvUsers["clmEducationalField", i].Value = u.Educational_Field;
                if (u.GenderTitle == "Male")
                    dgvUsers["clmGender", i].Value = "آقا";
                else if (u.GenderTitle == "Female")
                    dgvUsers["clmGender", i].Value = "خانم";
                dgvUsers["clmPhoneNumber", i].Value = u.PhoneNumber;
                i++;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            Users = db.View_User.ToList();
            tblCollege College = db.tblColleges.Where(c => c.CollegeName.Contains(cmbCollege.Text)).FirstOrDefault();
            Users = Users.Where(u => u.FirstName.Contains(txtFirstName.Text) && u.LastName.Contains(txtLastName.Text) && u.NationalCode.Contains(txtNationalCode.Text) && u.UserName.Contains(txtUserName.Text) && u.CollegeName.Contains(College.CollegeName)).ToList();
            fillfrm();
        }

        private void btnAddRoletoUser_Click(object sender, EventArgs e)
        {
            Access();
            University_DBEntities db = new University_DBEntities();
            if (cmbRole.SelectedIndex != -1)
            {
                tblRole role = db.tblRoles.Where(r => r.Title == cmbRole.Text).FirstOrDefault();
                if (db.tblRoleToUsers.Any(r => r.RoleId == role.Id))
                {
                    tblRoleToUser RoletoUser = new tblRoleToUser()
                    {
                        RoleId = role.Id,
                        UserId = selectedUser.UserId
                    };
                    db.tblRoleToUsers.Add(RoletoUser);
                    db.SaveChanges();
                    MessageBox.Show("انجام شد");
                    fillfrm();
                }
            }
        }
        View_User selectedUser;
        private void btnSelectUser_Click(object sender, EventArgs e)
        {
            int index = dgvUsers.CurrentRow.Index;
            string UserName = dgvUsers["clmUserName", index].Value.ToString();
            selectedUser = Users.Where(u => u.UserName.Contains(UserName)).FirstOrDefault();
            MessageBox.Show("Selected");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Access();
            University_DBEntities db = new University_DBEntities();
            Users.Clear();
            Users.AddRange(db.View_User);
            fillfrm();
        }
        private void Access()
        {
            University_DBEntities db = new University_DBEntities();
            if (!clsPublicVariable.UserRoleAccess.Any(r => r.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "User Role Management").Select(p => p.Id).First()))
                Close();
        }
    }
}
