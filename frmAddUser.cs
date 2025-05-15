using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static University.clsPublicVariable;

namespace University
{
    public partial class frmAddUser : Form
    {
        Random rnd = new Random();
        tblRole Role;
        public frmAddUser(tblRole R)
        {
            InitializeComponent();
            Role = R;
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            frmLoad();
        }
        private void frmLoad()
        {
            Access();
            University_DBEntities db = new University_DBEntities();
            btnAdd.Text = "افزودن " + Role.Title;
            lblTitle.Text = btnAdd.Text;
            cmbCollege.Items.Clear();
            cmbEducational_Field.Items.Clear();
            foreach (tblEducationalField field in db.tblEducationalFields)
                cmbEducational_Field.Items.Add(field.Educational_Field);
            foreach (tblCollege C in db.tblColleges)
                cmbCollege.Items.Add(C.CollegeName);
        }
        private void Access()
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            int? College = null, FieldId = null;
            if (txtFirstName.Text == "" || txtLastName.Text == "")
            {
                MessageBox.Show("اطلاعات لازم را وارد کنید");
                pnlName.BackColor = Color.Red;
                return;
            }
            pnlName.BackColor = SystemColors.Control;
            if (txtNationalCode.Text == "" || txtNationalCode.Text.Length != 10)
            {
                MessageBox.Show("اطلاعات لازم را وارد کنید");
                pnlNationalCode.BackColor = Color.Red;
                return;
            }
            if (db.tblUsers.Any(u => u.NationalCode == txtNationalCode.Text))
            {
                MessageBox.Show("کد ملی تکراری است");
                pnlNationalCode.BackColor = Color.Red;
                return;
            }
            pnlNationalCode.BackColor = SystemColors.Control;
            if (txtFathersName.Text == "")
            {
                MessageBox.Show("اطلاعات لازم را وارد کنید");
                pnlFathersName.BackColor = Color.Red;
                return;
            }
            pnlFathersName.BackColor = SystemColors.Control;
            if (rdbFemale.Checked == false && rdbMale.Checked == false)
            {
                MessageBox.Show("اطلاعات لازم را وارد کنید");
                pnlGender.BackColor = Color.Red;
                return;
            }
            pnlGender.BackColor = SystemColors.Control;
            if (txtPhoneNumber.Text == "")
            {
                MessageBox.Show("اطلاعات لازم را وارد کنید");
                pnlPhoneNumber.BackColor = Color.Red;
                return;
            }

            if (photo == null)
            {
                MessageBox.Show("عکس را انتخاب کنید");
                return;
            }
            if (cmbCollege.SelectedIndex == -1)
            {
                pnlCollege.BackColor = Color.Red;
                MessageBox.Show("اطلاعات لازم را وارد کنید");
                return;
            }
            pnlCollege.BackColor = SystemColors.Control;
            College = db.tblColleges.Where(c => c.CollegeName == cmbCollege.Text).Select(c => c.Id).FirstOrDefault();
            if (cmbEducational_Field.SelectedIndex == -1)
            {
                pnlEducational_Field.BackColor = Color.Red;
                MessageBox.Show("اطلاعات لازم را وارد کنید");
                return;
            }
            pnlEducational_Field.BackColor = SystemColors.Control;
            FieldId = db.tblEducationalFields.Where(f => f.Educational_Field == cmbEducational_Field.Text).Select(f => f.Id).FirstOrDefault();
            Access();
            pnlPhoneNumber.BackColor = SystemColors.Control;
            tblGender gender;
            if (rdbMale.Checked)
                gender = db.tblGenders.Where(g => g.GenderTitle == "Male").FirstOrDefault();
            else
                gender = db.tblGenders.Where(g => g.GenderTitle == "Female").FirstOrDefault();
            Folder();
            File.Copy(photo.Address, Profile_Photos_Address + "\\" + photo.Name);
            photo.Address = Profile_Photos_Address + "\\" + photo.Name;
            tblUser newuser = new tblUser()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                NationalCode = txtNationalCode.Text,
                FathersName = txtFathersName.Text,
                GenderId = gender.Id,
                PhoneNumber = txtPhoneNumber.Text,
                Educational_Field_Id = FieldId,
                CollegeId = College,
                UserName = username_generate(),
                Password = txtNationalCode.Text,
                PhotoId = photo.Id,
            };
            tblRoleToUser usserrole = new tblRoleToUser()
            {
                RoleId = Role.Id,
                UserId = newuser.Id
            };
            db.tblPhotos.Add(photo);
            db.tblUsers.Add(newuser);
            db.tblRoleToUsers.Add(usserrole);
            db.SaveChanges();
            MessageBox.Show("با موفقیت انجام شد");
            MessageBox.Show(string.Format("نام کاربری/کد پرسنلی : {0} \nرمز عبور : {1}", newuser.UserName, newuser.Password));
        }
        private string username_generate()
        {
            University_DBEntities db = new University_DBEntities();
            string username = txtNationalCode.Text.Substring(0, 4);
            if (rdbFemale.Checked)
                username += 11;
            else
                username += 10;
            username += rnd.Next(1000, 10000);
            if (db.tblUsers.Any(u => u.UserName == username))
                username_generate();
            return username;
        }
        tblPhoto photo = new tblPhoto();
        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            FileInfo fi = new FileInfo(ofd.FileName);
            photo.Suffix = fi.Extension;
            photo.Name = DateTime.Now.ToShortDateString().Replace("/", "") + rnd.Next(1000, 10000) + photo.Suffix;
            photo.Address = fi.FullName;
            pcbPhoto.Image = Image.FromFile(ofd.FileName);
        }
    }
}
