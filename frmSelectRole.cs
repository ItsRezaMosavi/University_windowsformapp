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
    public partial class frmSelectRole : Form
    {
        public frmSelectRole()
        {
            InitializeComponent();
        }

        private void frmSelectRole_Load(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();

            foreach (tblRole r in db.tblRoles)
            {
                if (clsPublicVariable.UserRoleAccess.Any(a => a.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == r.EnglishName + " Management").Select(p => p.Id).First()))
                    cmbRoles.Items.Add(r.Title);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();

            if (cmbRoles.SelectedIndex != -1)
            {
                Close();
                new frmUserManagement(db.tblRoles.Where(r => r.Title == cmbRoles.Text).First()).ShowDialog();
            }
        }
    }
}
