using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class frmSendMessage : Form
    {
        View_User Receiver;
        List<tblPhoto> photos = new List<tblPhoto>();
        List<tblVideo> videos = new List<tblVideo>();
        List<tblFile> files = new List<tblFile>();
        tblMessage Message = new tblMessage();
        public frmSendMessage(View_User u = null)
        {
            InitializeComponent();
            Receiver = u;
        }

        private void frmSendMessage_Load(object sender, EventArgs e)
        {
            fillFrm();
        }
        private void fillFrm()
        {
            University_DBEntities db = new University_DBEntities();
            if (clsPublicVariable.User.PhotoAddress != null)
                pcbFromPhoto.Image = Image.FromFile(clsPublicVariable.User.PhotoAddress);
            txtFromName.Text = clsPublicVariable.User.FirstName + " " + clsPublicVariable.User.LastName;
            txtFromUserName.Text = clsPublicVariable.User.UserName;
            if (Receiver != null)
            {
                if (Receiver.PhotoAddress != null)
                    pcbToPhoto.Image = Image.FromFile(Receiver.PhotoAddress);
                else
                    pcbToPhoto.Image = null;
                txtToName.Text = Receiver.FirstName + " " + Receiver.LastName;
                txtToUserName.Text = Receiver.UserName;
            }
        }

        private void btnSelectReceiver_Click(object sender, EventArgs e)
        {
            Hide();
            new frmSearchUser(1).ShowDialog();
            Show();
            Receiver = clsPublicVariable.Selected_Receiver;
            fillFrm();
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (Receiver == null)
            {
                MessageBox.Show("گیرنده پیام را مشخص کنید");
                return;
            }
            if (txtMessageTitle.Text.Length < 5)
            {
                MessageBox.Show("عنوان پیام باید حداقل 5 کاراکتر باشد");
                return;
            }
            University_DBEntities db = new University_DBEntities();
            Message.Title = txtMessageTitle.Text;
            Message.Text = txtMessageText.Text;
            Message.DateTime = DateTime.Now;
            Message.ReceiverId = Receiver.UserId;
            Message.SenderId = clsPublicVariable.User.UserId;
            db.tblMessages.Add(Message);
            db.tblFiles.AddRange(files);
            db.tblVideos.AddRange(videos);
            db.tblPhotos.AddRange(photos);
            db.SaveChanges();
            foreach (tblFile f in files)
            {
                tblFileToMessage ftm = new tblFileToMessage()
                {
                    FileId = f.Id,
                    MessageId = Message.Id
                };
                db.tblFileToMessages.Add(ftm);
            }
           
            foreach (tblPhoto p in photos)
            {
                tblPhotoToMessage ptm = new tblPhotoToMessage()
                {
                    PhotoId = p.Id,
                    MessageId = Message.Id
                };
                db.tblPhotoToMessages.Add(ptm);
            }
            foreach (tblVideo v in videos)
            {
                tblVideoToMessage vtm = new tblVideoToMessage()
                {
                    VideoId = v.Id,
                    MessageId = Message.Id
                };
                db.tblVideoToMessages.Add(vtm);
            }
            
                db.SaveChanges();
            MessageBox.Show("ارسال شد");
            Close();
        }
        private void btnAttachPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            Random rnd = new Random();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.jfif;";
            ofd.Title = "یک عکس انتخاب کنید";
            ofd.ShowDialog();

            FileInfo fi = new FileInfo(ofd.FileName);
            tblPhoto photo = new tblPhoto()
            {
                Name = DateTime.Now.ToShortDateString().Replace("/", "") + rnd.Next(1000, 10000) + fi.Extension,
                Suffix = fi.Extension,
            };
            photo.Address = clsPublicVariable.Photo_Address + "\\" + photo.Name;
            File.Copy(fi.FullName, photo.Address, true);
            photos.Add(photo);
            filldgv();
        }

        private void btnAttachVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            Random rnd = new Random();
            ofd.Filter = "Video Files|*.mp4;*.avi;*.mkv;*.mov;*.wmv;";
            ofd.Title = "یک ویدیو انتخاب کنید";
            ofd.ShowDialog();

            FileInfo fi = new FileInfo(ofd.FileName);
            tblVideo video = new tblVideo()
            {
                Name = DateTime.Now.ToShortDateString().Replace("/", "") + rnd.Next(1000, 10000) + fi.Extension,
                Suffix = fi.Extension,
            };
            video.Address = clsPublicVariable.Video_Address + "\\" + video.Name;
            File.Copy(fi.FullName, video.Address, true);
            videos.Add(video);
            filldgv();
        }

        private void btnAttachFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Documents|*.doc;*.docx;*.txt;",
                Title = "یک فایل انتخاب کنید"
            };
            ofd.ShowDialog();

            Random rnd = new Random();
            FileInfo fi = new FileInfo(ofd.FileName);
            tblFile Selectedfile = new tblFile()
            {
                Name = DateTime.Now.ToShortDateString().Replace("/", "") + rnd.Next(1000, 10000) + fi.Extension,
                Suffix = fi.Extension,
            };
            Selectedfile.Address = clsPublicVariable.File_Address + "\\" + Selectedfile.Name;
            File.Copy(fi.FullName, Selectedfile.Address, true);
            files.Add(Selectedfile);
            filldgv();
        }

        private void pnlFrom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMessage_Paint(object sender, PaintEventArgs e)
        {

        }
        private void filldgv()
        {
            int i = 0;
            dgvFiles.Rows.Clear();
            foreach (tblPhoto p in photos)
            {
                dgvFiles.Rows.Add();
                dgvFiles["clmType", i].Value = "عکس";
                dgvFiles["clmName",i].Value = p.Name;
                i++;
            }
            foreach (tblVideo v in videos)
            {
                dgvFiles.Rows.Add();
                dgvFiles["clmType", i].Value = "ویدیو";
                dgvFiles["clmName", i].Value = v.Name;
                i++;
            }
            foreach (tblFile f in files)
            {
                dgvFiles.Rows.Add();
                dgvFiles["clmType", i].Value = "فایل";
                dgvFiles["clmName", i].Value = f.Name;
                i++;
            }
            dgvFiles.Sort(clmType,ListSortDirection.Ascending);
        }
    }
}
