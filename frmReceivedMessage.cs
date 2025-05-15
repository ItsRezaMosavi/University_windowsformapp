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
    public partial class frmReceivedMessage : Form
    {
        List<View_Message> messages = new List<View_Message>();
        public frmReceivedMessage()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog()
            {
                ShowNewFolderButton = true,
                Description = "محل ذخیره سازی اطلاعات را انتخاب کنید"
            };
            fbd.ShowDialog();

        }

        private void frmReceivedMessage_Load(object sender, EventArgs e)
        {
            fill();
        }
        private void fill()
        {
            messages.Clear();
            University_DBEntities db = new University_DBEntities();
            messages.AddRange(db.View_Message.Where(m => !m.IsRead && m.ReceiverId == clsPublicVariable.User.UserId).ToList());
            dgvUnSeenMessage.Rows.Clear();
            int i = 0;
            foreach (View_Message m in messages)
            {
                dgvUnSeenMessage.Rows.Add();
                dgvUnSeenMessage["clmSender",i].Value = m.SenderFirstName+" "+m.SenderLastName;
                dgvUnSeenMessage["clmTitle",i].Value = m.Title;
            }
        }

        private void dgvUnSeenMessage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void dgvUnSeenMessage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            int index = dgvUnSeenMessage.CurrentRow.Index;

        }
    }
}
