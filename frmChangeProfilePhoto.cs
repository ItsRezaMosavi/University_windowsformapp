using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class frmChangeProfilePhoto : Form
    {
        public frmChangeProfilePhoto()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        tblPhoto photo = new tblPhoto();

        private void frmChangeProfilePhoto_Load(object sender, EventArgs e)
        {
            if (clsPublicVariable.User.PhotoAddress != null)
                pcbUserCurrentPhoto.Image = Image.FromFile(clsPublicVariable.User.PhotoAddress);


        }
        string photoAddress = null;
        private void btnUploadNewPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            photoAddress = ofd.FileName;
            Random rnd = new Random();
            FileInfo fi = new FileInfo(ofd.FileName);
            photo.Suffix = fi.Extension;
            photo.Name = DateTime.Now.ToShortDateString().Replace("/", "") + rnd.Next(1000, 10000) + photo.Suffix;
            photo.Address = fi.FullName;
            pcbUserNewPhoto.Image = Image.FromFile(ofd.FileName);
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            if (photoAddress == null)
            {
                MessageBox.Show("عکس را انتخاب کنید");
                return;
            }
            University_DBEntities db = new University_DBEntities();
            int type = Convert.ToInt32(clsPublicVariable.Request_type.ProfilePictureChange);
            int approved = Convert.ToInt32(clsPublicVariable.RequestStatus.Approved);
            int Reject = Convert.ToInt32(clsPublicVariable.RequestStatus.Rejected);
            if (db.View_Requests.Any(r => r.RequestType == type && r.RequesterId == clsPublicVariable.User.UserId && r.Answer != approved && r.Answer != Reject))
            {
                MessageBox.Show("امکان ثبت دوباره این درخواست تا زمان مشخص شدن نتیجه درخواست قبل وجود ندارد");
                return;
            }
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random rnd = new Random();
            string code;
            do
                code = rnd.Next(100).ToString() + alphabet[rnd.Next(alphabet.Length)] + rnd.Next(1000, 10000);
            while (db.tblRequests.Any(r => r.TrackingCode == code));
            clsPublicVariable.Folder();
            File.Copy(photo.Address, clsPublicVariable.Profile_Photos_Address + "\\" + photo.Name);
            photo.Address = clsPublicVariable.Profile_Photos_Address + "\\" + photo.Name;
            tblRequest req = new tblRequest()
            {
                UserId = clsPublicVariable.User.UserId,
                RequestType = (int)clsPublicVariable.Request_type.ProfilePictureChange,
                FileId = photo.Id,
                SubmissionDate = DateTime.Now,
                RequestDetail = txtDescription.Text,
                TrackingCode = code,
            };
            db.tblPhotos.Add(photo);
            db.tblRequests.Add(req);
            db.SaveChanges();
            MessageBox.Show("درخواست ارسال شد و در اسرع وقت رسیدگی خواهد شد");
            MessageBox.Show("کد پیگیری : \n" + req.TrackingCode);
        }
    }
}
