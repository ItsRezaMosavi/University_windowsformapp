using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class frmUserInformation : Form
    {
        public frmUserInformation()
        {
            InitializeComponent();
        }

        private void frmUserInformation_Load(object sender, EventArgs e)
        {
            frmLoad();
        }
        private void frmLoad()
        {
            access();
            University_DBEntities db = new University_DBEntities();
            lblFirstName.Text += "  " + clsPublicVariable.User.FirstName;
            lblLastName.Text += "  " + clsPublicVariable.User.LastName;
            lblNationalCode.Text += "  " + clsPublicVariable.User.NationalCode;
            lblFathersName.Text += "  " + clsPublicVariable.User.FathersName;
            lblGender.Text += "  " + clsPublicVariable.User.GenderTitle;
            lblUserName.Text += clsPublicVariable.User.UserName;
            if (clsPublicVariable.User.PhotoAddress != null)
                pcbUserPhoto.Image = Image.FromFile(clsPublicVariable.User.PhotoAddress);
            lblPassedUnitCount.Text += db.View_StudentClassRoomMapping.Where(s => s.StudentId == clsPublicVariable.User.UserId && s.IsPassed == true).Count();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            new frmChangePassword().ShowDialog();
        }
        private void access()
        {
            University_DBEntities db = new University_DBEntities();
            if (!clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "User Information").Select(p => p.Id).First()))
                Close();
            if (clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Change Password").Select(p => p.Id).First()))
            {
                btnChangePassword.Enabled = true;
                btnChangePassword.Visible = true;
            }
        }

        private void btnChangePhotoRequest_Click(object sender, EventArgs e)
        {
            Hide();
            new frmChangeProfilePhoto().ShowDialog();
            Show();
        }
    }
}
