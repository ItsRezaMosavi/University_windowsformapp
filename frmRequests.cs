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
    public partial class frmRequests : Form
    {
        public frmRequests()
        {
            InitializeComponent();
        }

        private void frmRequests_Load(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            if (clsPublicVariable.UserRoleAccess.Any(r => r.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Change Photo Request Tracking").Select(p => p.Id).First())
                || clsPublicVariable.UserExtraAccess.Any(r => r.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Change Photo Request Tracking").Select(p => p.Id).First()))
                cmbRequestType.Items.Add("درخواست تغییر عکس پروفایل");
            //if (clsPublicVariable.UserRoleAccess.Any(r => r.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Grade Review Request Tracking").Select(p => p.Id).First())
            //    || clsPublicVariable.UserExtraAccess.Any(r => r.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Grade Review Request Tracking").Select(p => p.Id).First()))
            //    cmbRequestType.Items.Add("اعتراض به نمره");
            if (clsPublicVariable.UserRoleAccess.Any(r => r.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Student ClassRoom Mapping License Request Tracking").Select(p => p.Id).First())
               || clsPublicVariable.UserExtraAccess.Any(r => r.SystemPartId == db.tblSystemPartNames.Where(p => p.PartName == "Student ClassRoom Mapping License Request Tracking").Select(p => p.Id).First()))
                cmbRequestType.Items.Add("درخواست مجوز انتخاب واحد");
        }

        private void FillFrm(clsPublicVariable.Request_type type)
        {
            University_DBEntities db = new University_DBEntities();
            dgvRequests.Rows.Clear();
            int Temp = (int)type;
            List<View_Requests> Requests = db.View_Requests.Where(r => r.RequestType == Temp).ToList();
            if (chbFilterApprovedAndRejected.Checked)
                Requests.RemoveAll(r => r.Answer == (int)clsPublicVariable.RequestStatus.Approved || r.Answer == (int)clsPublicVariable.RequestStatus.Rejected);
            int i = 0;
            foreach (View_Requests req in Requests)
            {
                dgvRequests.Rows.Add();
                dgvRequests["clmUserId", i].Value = req.RequesterId;
                switch (req.Answer)
                {
                    case 1:
                        dgvRequests["clmStatus", i].Value = "معوق";
                        break;
                    case 2:
                        dgvRequests["clmStatus", i].Value = "تایید شده";
                        break;
                    case 3:
                        dgvRequests["clmStatus", i].Value = "رد شده";
                        break;
                    default:
                        break;
                }
                dgvRequests["clmSubmissionDate", i].Value = req.SubmissionDate;
                dgvRequests["clmTrackingCode", i].Value = req.TrackingCode;
                i++;
            }
        }

        private void cmbRequestType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRequestType.Text == "درخواست تغییر عکس پروفایل")
            {
                pnlPhoto.Visible = true;
                FillFrm(clsPublicVariable.Request_type.ProfilePictureChange);
            }
            else if (cmbRequestType.Text == "درخواست مجوز انتخاب واحد")
            {
                pnlPhoto.Visible = false;
                FillFrm(clsPublicVariable.Request_type.StudentClassroomMappingLicense);
            }
        }
        View_Requests req;
        private void btnSelect_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            int index = dgvRequests.CurrentRow.Index;
            string trackingCode = dgvRequests["clmTrackingCode", index].Value.ToString();
            req = db.View_Requests.Where(r => r.TrackingCode == trackingCode).FirstOrDefault();
            txtUserId.Text = req.RequesterId.ToString();
            txtName.Text = req.RequesterFirstName + " " + req.RequesterLastName;
            txtDetail.Text = req.RequestDetail.ToString();
            txtDate.Text = req.SubmissionDate.ToString();
            if (req.FileId != null)
                pcbNextPhoto.Image = Image.FromFile(req.FileAddress);
            string photoAddress = db.View_User.Where(u => u.UserId == req.RequesterId).Select(u => u.PhotoAddress).First();
            if (photoAddress != null)
                pcbPrevPhoto.Image = Image.FromFile(photoAddress);
            switch (req.Answer)
            {
                case 1:
                    rdbPending.Checked = true;
                    break;
                case 2:
                    rdbApproved.Checked = true;
                    rdbApproved.Enabled = false;
                    rdbPending.Enabled = false;
                    rdbReject.Enabled = false;
                    break;
                case 3:
                    rdbReject.Checked = true;
                    rdbApproved.Enabled = false;
                    rdbPending.Enabled = false;
                    rdbReject.Enabled = false;
                    break;
                default:
                    break;
            }

        }

        private void pnlRequest_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            if (req == null)
                return;
            tblRequestAnswer ans = db.tblRequestAnswers.Where(r => r.RequestId == req.RequestId).FirstOrDefault();
            if (ans == null)
            {
                ans = new tblRequestAnswer()
                {
                    RequestId = req.RequestId,
                    EmployeeId = clsPublicVariable.User.UserId,
                    Date = DateTime.Now,
                };
            }
            if (rdbPending.Checked)
                ans.Answer = 1;
            else if (rdbApproved.Checked)
            {
                ans.Answer = 2;
                clsPublicVariable.req_approved(req);
            }
            else if (rdbReject.Checked)
                ans.Answer = 3;
            db.tblRequestAnswers.AddOrUpdate(ans);
            db.SaveChanges();

            MessageBox.Show("انجام شد");
        }

        private void chbFilterApprovedAndRejected_CheckedChanged(object sender, EventArgs e)
        {
            cmbRequestType_SelectedIndexChanged(null, null);
        }
    }
}
