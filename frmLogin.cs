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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtUserName.Text == "")
            {
                MessageBox.Show("نام کاربری و رمز عبور خود را وارد کنید", "خطا");
                return;
            }
            University_DBEntities db = new University_DBEntities();

            if (db.tblUsers.Any(u => u.UserName == txtUserName.Text && u.Password == txtPassword.Text))
            {

                int userid = db.tblUsers.Where(u => u.UserName == txtUserName.Text && u.Password == txtPassword.Text).Select(u => u.Id).FirstOrDefault();
                clsPublicVariable.Fill_public(userid);
                tblLoging newLogin = new tblLoging()
                {
                    UserId = clsPublicVariable.User.UserId,
                    LoginDatetime = DateTime.Now,
                };
                db.tblLogings.Add(newLogin);
                db.SaveChanges();
                Hide();
                new frmMain().ShowDialog();
            }
            else
                MessageBox.Show("چنین کاربری یافت نشد");
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(null, null);
        }
    }
}
