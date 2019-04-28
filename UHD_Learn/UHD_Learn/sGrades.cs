using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UHD_Learn
{
    public partial class sGrades : Form
    {
        public string Crn1 { get; protected internal set; }
        public string Crn2 { get; protected internal set; }
        public string Crn3 { get; protected internal set; }
        public string Crn4 { get; protected internal set; }

        public string gatorID { get; protected internal set; }


        public string course1 { get; protected internal set; }
        public string course2 { get; protected internal set; }
        public string course3 { get; protected internal set; }
        public string course4 { get; protected internal set; }
        
        SqlConnection con = new SqlConnection("Data Source=ASUSVIVOBOOK\\SQLEXPRESS;Initial Catalog=UHD_Learn;Integrated Security=True"); 

        public sGrades()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            CourseInfotxt.Clear();
            clearGrades();
            SetGradesAndInfoText(Crn4, gatorID);
            showGradeLabels();
        }

        private void Course3btn_Click(object sender, EventArgs e)
        {
            CourseInfotxt.Clear();
            clearGrades();

            SetGradesAndInfoText(Crn3, gatorID);

            showGradeLabels();
            
        }

        private void Course2btn_Click(object sender, EventArgs e)
        {
            CourseInfotxt.Clear();
            clearGrades();
            SetGradesAndInfoText(Crn2,gatorID);

            showGradeLabels();

            
        }

        private void Course1btn_Click(object sender, EventArgs e)
        {
            CourseInfotxt.Clear();
            clearGrades();
            SetGradesAndInfoText(Crn1, gatorID);
            showGradeLabels();
            
        }

        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Login"].Show();
        }

        public void setName(string s)
        {
            Namelbl.Text = s;
        }

        private void sGrades_Load(object sender, EventArgs e)
        {
            //con.Open();
            if (course1 != null)
            {
                Course1btn.Text = course1;
                Course1btn.Show();
                CourseInfotxt.Clear();
                clearGrades();
                SetGradesAndInfoText(Crn1, gatorID);
                showGradeLabels();
            }

            if (course2 != null)
            {
                Course2btn.Text = course2;
                Course2btn.Show();
            }

            if (course3 != null)
            {
                Course3btn.Text = course3;
                Course3btn.Show();
            }

            if (course4 != null)
            {
                Course4btn.Text = course4;
                Course4btn.Show();
            }

            

        }

        private void HomeBtt_Click(object sender, EventArgs e)
        {
            this.Close();

            Application.OpenForms["StudentPage"].Show();
        }

        public void SetGradesAndInfoText(string crn, string id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * FROM [" + crn + "] where gatorID ='" + id + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Hw1Gradetxt.Text = rd.IsDBNull(3) ? null : rd.GetInt32(3).ToString().Trim();
                    Hw2Gradetxt.Text = rd.IsDBNull(4) ? null : rd.GetInt32(4).ToString().Trim();
                    Midterm1Gradetxt.Text = rd.IsDBNull(5) ? null : rd.GetInt32(5).ToString().Trim();
                    MidtermGrade2txt.Text = rd.IsDBNull(6) ? null : rd.GetInt32(6).ToString().Trim();
                    FinalProjecttxt.Text = rd.IsDBNull(7) ? null : rd.GetInt32(7).ToString().Trim();
                    FinalExamtxt.Text = rd.IsDBNull(8) ? null : rd.GetInt32(8).ToString().Trim();


                }

                int grade1, grade2, grade3, grade4, grade5, grade6;
                TotalGradetxt.Text = ((int.TryParse(Hw1Gradetxt.Text, out grade1) ? grade1 : 0) +
                                      (int.TryParse(Hw2Gradetxt.Text, out grade2) ? grade2 : 0) +
                                      (int.TryParse(Midterm1Gradetxt.Text, out grade3) ? grade3 : 0) +
                                      (int.TryParse(MidtermGrade2txt.Text, out grade4) ? grade4 : 0) +
                                      (int.TryParse(FinalProjecttxt.Text, out grade5) ? grade5 : 0) +
                                      (int.TryParse(FinalExamtxt.Text, out grade6) ? grade6 : 0)).ToString().Trim();
            }

            rd.Close();

            SqlCommand cmd1 = new SqlCommand("Select * FROM Course WHERE CRN = '" + crn + "'", con);
            rd = cmd1.ExecuteReader();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    CourseInfotxt.Text = rd.GetString(0).Trim() + " " + rd.GetString(1).Trim() + "_" +
                                         rd.GetString(2).Trim() + ": " + rd.GetString(3).Trim() + " - " +
                                         rd.GetString(4).Trim();
                }
            }

            con.Close();
        }

        public void clearGrades()
        {
            Hw1Gradetxt.Text = "";
            Hw2Gradetxt.Text = "";
            Midterm1Gradetxt.Text = "";
            MidtermGrade2txt.Text = "";
            FinalProjecttxt.Text = "";
            FinalExamtxt.Text = "";
            TotalGradetxt.Text = "";

        }

        public void showGradeLabels()
        {
            CourseInfotxt.Show();
            Itemlbl.Show();
            DueDatelbl.Show();
            Gradeslbl.Show();
            Hw1lbl.Show();
            Hw2lbl.Show();
            finalProjectlbl.Show();
            Midterm1lbl.Show();
            Midterm2lbl.Show();
            finalExamlbl.Show();
            //TotalGradelbl.Show();
            Hw1Gradetxt.Show();
            Hw2Gradetxt.Show();
            MidtermGrade2txt.Show();
            Midterm1Gradetxt.Show();
            FinalProjecttxt.Show();
            FinalExamtxt.Show();
            TotalGradetxt.Show();
            dueDate1.Show();
            dueDate2.Show();
            dueDate3.Show();
            dueDate4.Show();
            dueDate5.Show();
            dueDate6.Show();
        }


    }
}
