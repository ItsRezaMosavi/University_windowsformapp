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
    public partial class frmAddEditDeleteCollege : Form
    {
        int Operation;
        tblCollege College;
        public frmAddEditDeleteCollege(int A, tblCollege B = null)
        {
            InitializeComponent();
            Operation = A;
            College = B;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            if (Operation == 1 && College == null)
                Add();
            else if (Operation == 2 && College != null)
                Edit();
        }

        private void frmAddCollege_Load(object sender, EventArgs e)
        {
            Access();
            if (Operation == 1)
                btnOperation.Text = "افزودن";
            else if (Operation == 2 && College != null)
            {
                txtCollegeName.Text = College.CollegeName;
                btnOperation.Text = "ویرایش";
            }
        }
        private void Access()
        {
           
        }
        private void Add()
        {
            Access();
            University_DBEntities db = new University_DBEntities();
            string college = txtCollegeName.Text;
            if (!db.tblColleges.Any(c => c.CollegeName == college))
            {
                tblCollege newcollege = new tblCollege()
                {
                    CollegeName = college
                };
                db.tblColleges.Add(newcollege);
                db.SaveChanges();
                MessageBox.Show("افزوده شد");
                Close();
            }
            else
                MessageBox.Show("این دانشکده قبلا افزوده شده است");
        }
        private void Edit()
        {
            Access();
            University_DBEntities db = new University_DBEntities();
            if (!db.tblColleges.Any(c => c.CollegeName == txtCollegeName.Text))
            {
                if (txtCollegeName.Text != "")
                {
                    College.CollegeName = txtCollegeName.Text;
                    db.tblColleges.AddOrUpdate(College);
                    db.SaveChanges();
                    MessageBox.Show("با موفقیت ویرایش شد");
                    Close();
                }
                else
                    MessageBox.Show("لطفا نام دانشکده را وارد کنید");
            }
            else
                MessageBox.Show("نام دانشکده تکراری است");
        }
    }
}
