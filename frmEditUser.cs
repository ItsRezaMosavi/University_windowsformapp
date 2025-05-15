using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class frmEditUser : Form
    {
        tblRole Role;
        tblUser User;
        public frmEditUser(tblRole R, tblUser u)
        {
            InitializeComponent();
            Role = R;
            User = u;
        }

        private void frmEditUser_Load(object sender, EventArgs e)
        {
            frmLoad();
        }
        private void frmLoad()
        {
            Access();
            University_DBEntities db = new University_DBEntities();
            photo.Address = db.tblPhotos.Where(p=>p.Id == User.PhotoId).Select(p=>p.Address).FirstOrDefault();
            btnEdit.Text = "ویرایش " + Role.Title;
            cmbCollege.Items.Clear();
            cmbEducational_Field.Items.Clear();
            foreach (tblCollege c in db.tblColleges)
                cmbCollege.Items.Add(c.CollegeName);
            foreach (tblEducationalField field in db.tblEducationalFields)
                cmbEducational_Field.Items.Add(field.Educational_Field);

            lblTitle.Text = btnEdit.Text;
            txtFirstName.Text = User.FirstName;
            txtLastName.Text = User.LastName;
            txtNationalCode.Text = User.NationalCode;
            txtFathersName.Text = User.FathersName;
            txtPhoneNumber.Text = User.PhoneNumber;
            if (User.GenderId == db.tblGenders.Where(g => g.GenderTitle == "Female").Select(g => g.Id).First())
                rdbFemale.Checked = true;
            else
                rdbMale.Checked = true;
            cmbEducational_Field.Text = db.tblEducationalFields.Where(f => f.Id == User.Educational_Field_Id).Select(f => f.Educational_Field).FirstOrDefault();
            cmbCollege.Text = db.tblColleges.Where(c => c.Id == User.CollegeId).Select(c => c.CollegeName).FirstOrDefault();
            if (photo != null)
            {
                pcbPhoto.ImageLocation = photo.Address;
            }
        }
        private void Access()
        {


        }

        tblGender Gender;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            string Fname = User.FirstName, Lname = User.LastName, NationalCode = User.NationalCode, FathersName = User.FathersName,
                EducationalField = db.tblEducationalFields.Where(f => f.Id == User.Educational_Field_Id).Select(f => f.Educational_Field).FirstOrDefault(),
                PhoneNumber = User.PhoneNumber;


            if (txtFirstName.Text != User.FirstName)
            {
                DialogResult dr = MessageBox.Show(string.Format("آیا میخواهید نام را از {0} به {1} تغییر دهید؟", User.FirstName, txtFirstName.Text), "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                if (dr == DialogResult.Yes)
                    Fname = txtFirstName.Text;
                else
                {
                    txtFirstName.Text = User.FirstName;
                    return;
                }
            }
            if (txtLastName.Text != User.LastName)
            {
                DialogResult dr = MessageBox.Show(string.Format("آیا میخواهید نام خانوادگی را از {0} به {1} تغییر دهید؟", User.LastName, txtLastName.Text), "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                if (dr == DialogResult.Yes)
                    Lname = txtLastName.Text;
                else
                {
                    txtLastName.Text = User.LastName;
                    return;
                }
            }
            if (User.NationalCode != txtNationalCode.Text)
            {
                DialogResult dr = MessageBox.Show(string.Format("آیا میخواهید کد ملی را از {0} به {1} تغییر دهید؟", User.NationalCode, txtNationalCode.Text), "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                if (dr == DialogResult.Yes)
                    if (!db.tblUsers.Any(u => u.NationalCode == txtNationalCode.Text))
                        NationalCode = txtNationalCode.Text;
                    else
                    {
                        MessageBox.Show("این کد ملی قبلا ثبت نام کرده است", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                        return;
                    }
                else
                {
                    txtNationalCode.Text = User.NationalCode;
                    return;
                }
            }
            if (txtFathersName.Text != User.FathersName)
            {
                DialogResult dr = MessageBox.Show(string.Format("آیا میخواهید نام پدر را از {0} به {1} تغییر دهید؟", User.FathersName, txtFathersName.Text), "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                if (dr == DialogResult.Yes)
                    FathersName = txtFathersName.Text;
                else
                {
                    txtFathersName.Text = User.FathersName;
                    return;
                }
            }
            if (Gender.Id != User.GenderId)
            {
                DialogResult dr;
                if (Gender.GenderTitle == "Male" && User.GenderId == db.tblGenders.Where(g => g.GenderTitle == "Female").Select(g => g.Id).First())
                {
                    dr = MessageBox.Show("آیا میخواهید جنسیت را از آقا به خانم تغییر دهید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                }
                else
                {
                    dr = MessageBox.Show("آیا میخواهید جنسیت را از خانم به آقا تغییر دهید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                }

                if (dr == DialogResult.No)
                {
                    Gender = db.tblGenders.Where(g => g.Id == User.GenderId).First();
                    if (Gender.GenderTitle == "Female")
                    {
                        rdbFemale.Checked = true;
                    }
                    else
                    {
                        rdbMale.Checked = true;
                    }
                    return;
                }

            }
            if (txtPhoneNumber.Text != User.PhoneNumber)
            {
                DialogResult dr = MessageBox.Show(string.Format("آیا میخواهید تلفن همراه را از {0} به {1} تغییر دهید؟", User.PhoneNumber, txtPhoneNumber.Text), "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                if (dr == DialogResult.Yes)
                {
                    PhoneNumber = txtPhoneNumber.Text;
                }
                else
                    return;
            }
            if (cmbEducational_Field.Text != db.tblEducationalFields.Where(f => f.Id == User.Educational_Field_Id).Select(f => f.Educational_Field).FirstOrDefault())
            {
                DialogResult dr = MessageBox.Show(string.Format("آیا میخواهید رشته دانشگاهی را از {0} به {1} تغییر دهید؟", db.tblEducationalFields.Where(f => f.Id == User.Educational_Field_Id).Select(f => f.Educational_Field).FirstOrDefault(), cmbEducational_Field.Text), "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                if (dr != DialogResult.Yes)
                    return;
            }
            Access();

            User.FirstName = Fname;
            User.LastName = Lname;
            User.NationalCode = NationalCode;
            User.GenderId = Gender.Id;
            User.PhoneNumber = PhoneNumber;
            User.FathersName = FathersName;
            User.Educational_Field_Id = db.tblEducationalFields.Where(f => f.Educational_Field == cmbEducational_Field.Text).Select(f => f.Id).FirstOrDefault();
            User.CollegeId = db.tblColleges.Where(c => c.CollegeName == cmbCollege.Text).Select(c => c.Id).FirstOrDefault();
            User.PhotoId = photo.Id;
            db.tblPhotos.AddOrUpdate(photo);
            db.tblUsers.AddOrUpdate(User);

            db.SaveChanges();
            MessageBox.Show("با موفقیت ویرایش شد");
            Close();
        }
        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            if (rdbMale.Checked)
                Gender = db.tblGenders.Where(g => g.GenderTitle == "Male").First();
        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            if (rdbFemale.Checked)
                Gender = db.tblGenders.Where(g => g.GenderTitle == "Female").First();
        }

        private void cmbCollege_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        tblPhoto photo = new tblPhoto();
        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            Random rnd = new Random();
            ofd.ShowDialog();
            FileInfo fi = new FileInfo(ofd.FileName);
            photo.Suffix = fi.Extension;
            photo.Name = DateTime.Now.ToShortDateString().Replace("/", "") + rnd.Next(1000, 10000) + photo.Suffix;
            photo.Address = fi.FullName;
            pcbPhoto.Image = Image.FromFile(photo.Address);
        }
    }
}