using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class frmLoginLogoutReport : Form
    {
        public frmLoginLogoutReport()
        {
            InitializeComponent();
        }

        private void frmLoginLogoutReport_Load(object sender, EventArgs e)
        {
            Access();
            fillform();
        }
        private void fillform()
        {
            University_DBEntities db = new University_DBEntities();
            dgvEnterOutReport.Rows.Clear();
            int i = 0;
            foreach (View_UserLoging w in db.View_UserLoging.Where(l => l.LogoutDatetime != null))
            {
                dgvEnterOutReport.RowTemplate.Height = 80;
                dgvEnterOutReport.Rows.Add();
                if (w.PhotoAddress != null)
                    dgvEnterOutReport["clmUserPhoto", i].Value = Image.FromFile(w.PhotoAddress);
                dgvEnterOutReport["clmUserName", i].Value = w.UserName;
                dgvEnterOutReport["clmFirstName", i].Value = w.FirstName;
                dgvEnterOutReport["clmLastName", i].Value = w.LastName;
                dgvEnterOutReport["clmType", i].Value = w.RoleTitle;
                dgvEnterOutReport["clmLoginDate", i].Value = clsPublicVariable.prs.GetDayOfMonth(w.LoginDatetime) + " / " + clsPublicVariable.prs.GetMonth(w.LoginDatetime) + " / " + clsPublicVariable.prs.GetYear(w.LoginDatetime);
                dgvEnterOutReport["clmLoginTime", i].Value = w.LoginDatetime.Minute + " : " + w.LoginDatetime.Hour;
                dgvEnterOutReport["clmlogoutTime", i].Value = w.LogoutDatetime.Value.Minute + " : " + w.LogoutDatetime.Value.Hour;
                dgvEnterOutReport["clmWorkTime", i].Value = w.LogoutDatetime.Value.Subtract(w.LoginDatetime);
                i++;
            }
        }
        private void Access()
        {
            University_DBEntities db = new University_DBEntities();
            if (!clsPublicVariable.UserRoleAccess.Any(r => r.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Login Logout Report").Select(p => p.Id).First()))
                Close();
        }
    }
}