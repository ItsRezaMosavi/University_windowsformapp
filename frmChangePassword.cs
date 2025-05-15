using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            if (db.tblUsers.Any(u => u.Id == clsPublicVariable.User.UserId && u.Password == txtLastPassword.Text))
            {
                if (txtNewPassword.Text.Length >= 8)
                {
                    if (txtNewPassword.Text == txtNewPasswordRepeat.Text)
                    {
                        tblUser user = db.tblUsers.Where(u => u.Id == clsPublicVariable.User.UserId).FirstOrDefault();
                        user.Password = txtNewPassword.Text;
                        db.tblUsers.AddOrUpdate(user);
                        db.SaveChanges();
                        MessageBox.Show("رمز عبور تغییر داده شد");
                        clsPublicVariable.Fill_public(user.Id);
                    }
                    else
                        MessageBox.Show("رمز عبور جدید و تکرار رمز یکی نیست");
                }
                else
                    MessageBox.Show("رمز باید حداقل 8 کاراکتر داشته باشد");
            }
            else
                MessageBox.Show("رمز عبور خود را به درستی وارد کنید");
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
