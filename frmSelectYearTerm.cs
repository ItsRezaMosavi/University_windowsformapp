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
    public partial class frmSelectYearTerm : Form
    {
        public frmSelectYearTerm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtYear.Text == "" || cmbTerm.SelectedIndex == -1)
            {
                MessageBox.Show("لطفا سال و ترم را به درستی انتخاب کنید ");
                return;
            }
            Close();
            new frmClassRoomManagement(Convert.ToInt32(txtYear.Text), cmbTerm.SelectedIndex + 1).ShowDialog();
        }
    }
}
