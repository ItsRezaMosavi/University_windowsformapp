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
    public partial class frmRegisterScore : Form
    {

        int StudentID;
        int ClassRoomId;
        public frmRegisterScore(int A, int B)
        {
            InitializeComponent();
            StudentID = A;
            ClassRoomId = B;
        }
        private void frmRegisterScore_Load(object sender, EventArgs e)
        {
            int classPoint = Convert.ToInt32(clsPublicVariable.Score_Type.ClassPoint);
            int midterm = Convert.ToInt32(clsPublicVariable.Score_Type.MidTerm);
            int final = Convert.ToInt32(clsPublicVariable.Score_Type.Final);
            University_DBEntities db = new University_DBEntities();
            List<View_Score> UserScore = db.View_Score.Where(a => a.ClassroomId == ClassRoomId && a.StudentId == StudentID).ToList();
            txtClassPoint.Text = UserScore.Where(s => s.Type == classPoint).Select(s => s.Score).FirstOrDefault();
            txtMidTermScore.Text = UserScore.Where(s => s.Type == midterm).Select(s => s.Score).FirstOrDefault();
            txtFinalScore.Text = UserScore.Where(s => s.Type == final).Select(s => s.Score).FirstOrDefault();
        }

        private void btnRegisterScore_Click(object sender, EventArgs e)
        {
            University_DBEntities db = new University_DBEntities();
            if (txtClassPoint.Text != "")
            {
                double score;
                try
                {
                    score = Convert.ToDouble(txtClassPoint.Text);
                }
                catch
                {
                    MessageBox.Show("نمره را به درستی وارد کنید");
                    return;
                }
                int type = Convert.ToInt32(clsPublicVariable.Score_Type.ClassPoint);
                if (db.tblScores.Any(s => s.StudentId == StudentID && s.ClassRoomId == ClassRoomId && s.Type == type))
                {
                    tblScore classPoint = db.tblScores.Where(s => s.StudentId == StudentID && s.ClassRoomId == ClassRoomId && s.Type == type).First();
                    classPoint.Score = txtClassPoint.Text;
                }
                else
                {
                    tblScore classpoint = new tblScore()
                    {
                        StudentId = StudentID,
                        ClassRoomId = ClassRoomId,
                        Score = txtClassPoint.Text,
                        Type = type
                    };
                    db.tblScores.Add(classpoint);
                }
                db.SaveChanges();
            }

            if (txtMidTermScore.Text != "")
            {
                double score;
                try
                {
                    score = Convert.ToDouble(txtMidTermScore.Text);
                }
                catch
                {
                    MessageBox.Show("نمره را به درستی وارد کنید");
                    return;
                }
                int type = Convert.ToInt32(clsPublicVariable.Score_Type.MidTerm);
                if (db.tblScores.Any(s => s.StudentId == StudentID && s.ClassRoomId == ClassRoomId && s.Type == type))
                {
                    tblScore MidTerm = db.tblScores.Where(s => s.StudentId == StudentID && s.ClassRoomId == ClassRoomId && s.Type == type).First();
                    MidTerm.Score = txtMidTermScore.Text;
                }
                else
                {
                    tblScore MidTerm = new tblScore()
                    {
                        StudentId = StudentID,
                        ClassRoomId = ClassRoomId,
                        Score = txtMidTermScore.Text,
                        Type = type
                    };
                    db.tblScores.Add(MidTerm);
                }
                db.SaveChanges();
            }
            if (txtFinalScore.Text != "")
            {
                double score;
                try
                {
                    score = Convert.ToDouble(txtFinalScore.Text);
                }
                catch
                {
                    MessageBox.Show("نمره را به درستی وارد کنید");
                    return;
                }
                int type = Convert.ToInt32(clsPublicVariable.Score_Type.Final);
                if (db.tblScores.Any(s => s.StudentId == StudentID && s.ClassRoomId == ClassRoomId && s.Type == type))
                {
                    tblScore Final = db.tblScores.Where(s => s.StudentId == StudentID && s.ClassRoomId == ClassRoomId && s.Type == type).First();
                    Final.Score = txtFinalScore.Text;
                }
                else
                {
                    tblScore Final = new tblScore()
                    {
                        StudentId = StudentID,
                        ClassRoomId = ClassRoomId,
                        Score = txtFinalScore.Text,
                        Type = type
                    };
                    db.tblScores.Add(Final);
                }
                db.SaveChanges();
            }

            if (txtClassPoint.Text != "" && txtFinalScore.Text != "" && txtMidTermScore.Text != "")
            {
                int type = Convert.ToInt32(clsPublicVariable.Score_Type.Average);
                double score = (Convert.ToDouble(txtClassPoint.Text) + Convert.ToDouble(txtFinalScore.Text) + Convert.ToDouble(txtMidTermScore.Text)) / 3;
                string ave = score.ToString();
                if(ave.Length>5)
                    ave = ave.Substring(0, 5);
                if (db.tblScores.Any(s => s.StudentId == StudentID && s.ClassRoomId == ClassRoomId && s.Type == type))
                {
                    tblScore average = db.tblScores.Where(s => s.StudentId == StudentID && s.ClassRoomId == ClassRoomId && s.Type == type).First();
                    average.Score = ave;
                }
                else
                {
                    tblScore average = new tblScore()
                    {
                        StudentId = StudentID,
                        ClassRoomId = ClassRoomId,
                        Type = type,
                        Score = ave,
                    };
                    db.tblScores.Add(average);
                }
                db.SaveChanges();
            }
            MessageBox.Show("با موفقیت انجام شد");
            Close();
        }
    }
}
