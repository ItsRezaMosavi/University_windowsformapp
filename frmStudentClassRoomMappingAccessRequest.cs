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
    public partial class frmStudentClassRoomMappingAccessRequest : Form
    {
        public frmStudentClassRoomMappingAccessRequest()
        {
            InitializeComponent();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            if (clsPublicVariable.UserRoles.Contains(db.tblRoles.Where(r => r.Id == clsPublicVariable.StudentId).First()))
            {
                //// after creating the extra access
                tblExtraAccess access = new tblExtraAccess()
                {
                    UserId = clsPublicVariable.User.UserId,
                    SystemPartId = db.tblSystemPartNames.Where(p => p.PartName == "Student ClassRoom Mapping").Select(p => p.Id).First()
                };
                db.tblExtraAccesses.Add(access);
                db.SaveChanges();
                MessageBox.Show("مجوز صادر شد");
                Close();
            }
        }

        private void frmStudentClassRoomMappingAccessRequest_Load(object sender, EventArgs e)
        {
            lblYear.Text += " " + clsPublicVariable.Year;
            if (clsPublicVariable.openTerm == clsPublicVariable.Term.mehr)
                lblTerm.Text += " مهر";
            else if (clsPublicVariable.openTerm == clsPublicVariable.Term.bahman)
                lblTerm.Text += " بهمن";
            else
                lblTerm.Text += " تابستان";
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
