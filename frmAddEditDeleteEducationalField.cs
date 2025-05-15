using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class frmAddEditDeleteEducationalField : Form
    {
        int Operation;
        tblEducationalField Field;
        public frmAddEditDeleteEducationalField(int A, tblEducationalField B = null)
        {
            InitializeComponent();
            Operation = A;
            Field = B;
        }

        private void frmAddEditDeleteEducationalField_Load(object sender, EventArgs e)
        {
            Access();
            University_DBEntities db = new University_DBEntities();
            cmbCollege.Items.Clear();
            foreach (tblCollege c in db.tblColleges)
                cmbCollege.Items.Add(c.CollegeName);
            if (Operation == 1 && Field == null)
            {
                lblTitle.Text = "افزودن رشته";
                btnOperation.Text = "افزودن";
            }
            else if (Operation == 2 && Field != null)
            {
                lblTitle.Text = "ویرایش رشته";
                btnOperation.Text = "ویرایش";
                txtEducationalField.Text = Field.Educational_Field;
                tblCollege C = db.tblColleges.Where(c => c.Id == Field.CollegeId).FirstOrDefault();
                cmbCollege.Text = C.CollegeName;
            }
        }
        private void Access()
        {

        }
        private void Add()
        {
            Access();
            University_DBEntities db = new University_DBEntities();
            string EducationalField = txtEducationalField.Text;
            int collegeid = db.tblColleges.Where(c => c.CollegeName == cmbCollege.Text).Select(c => c.Id).FirstOrDefault();
            if (!db.tblEducationalFields.Any(e => e.Educational_Field == txtEducationalField.Text))
            {
                tblEducationalField ef = new tblEducationalField()
                {
                    Educational_Field = txtEducationalField.Text,
                    CollegeId = collegeid
                };
                db.tblEducationalFields.Add(ef);
                db.SaveChanges();
                MessageBox.Show("با موفقیت افزوده شد");
                Close();
            }
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            Access();
            if (cmbCollege.SelectedIndex == -1)
            {
                MessageBox.Show("دانشکده را انتخاب کنید");
                return;
            }
            if (txtEducationalField.Text == "")
            {
                MessageBox.Show("نام رشته را وارد کنید");
                return;
            }
            if (Operation == 1 && Field == null)
                Add();
            else if (Operation == 2 && Field != null)
                Edit();

        }
        private void Edit()
        {
            Access();
            University_DBEntities db = new University_DBEntities();
            string College_Name = cmbCollege.Text;
            int CollegeId = db.tblColleges.Where(c => c.CollegeName == College_Name).Select(c => c.Id).First();
            Field.Educational_Field = txtEducationalField.Text;
            Field.CollegeId = CollegeId;
            db.tblEducationalFields.AddOrUpdate(Field);
            db.SaveChanges();
            MessageBox.Show("با موفقیت ویرایش شد");
            Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
