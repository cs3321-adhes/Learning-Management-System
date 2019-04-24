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
        public string Crn { get; protected internal set; }

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
            CourseInfotxt.AppendText("CS_3321 23924: Yuchou Chang-TTH 11:30-12:45 pm");
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
            TotalGradelbl.Show();
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

        private void Course3btn_Click(object sender, EventArgs e)
        {
            CourseInfotxt.Clear();
            CourseInfotxt.AppendText("CS_4315 21820: Ling Xu-MW 10:00-11:15 am");
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
            TotalGradelbl.Show();
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

        private void Course2btn_Click(object sender, EventArgs e)
        {
            CourseInfotxt.Clear();
            CourseInfotxt.AppendText("CS_3300 25480: Moiz Ahmed-F 10:00-12:45 pm");
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
            TotalGradelbl.Show();
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

        private void Course1btn_Click(object sender, EventArgs e)
        {
            CourseInfotxt.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * FROM [23924] where gatorID ='" + gatorID.Trim() + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Hw1Gradetxt.Text = rd.IsDBNull(3) ? null : rd.GetInt32(3).ToString().Trim();
                    Hw2Gradetxt.Text = rd.IsDBNull(4) ? null : rd.GetInt32(4).ToString().Trim();
                    Midterm1Gradetxt.Text = rd.IsDBNull(5) ? null: rd.GetInt32(5).ToString().Trim();
                    MidtermGrade2txt.Text = rd.IsDBNull(6) ? null : rd.GetInt32(6).ToString().Trim();
                    FinalProjecttxt.Text = rd.IsDBNull(7) ? null : rd.GetInt32(7).ToString().Trim();
                    FinalExamtxt.Text = rd.IsDBNull(8) ? null : rd.GetInt32(8).ToString().Trim();


                }
            }


            
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
            TotalGradelbl.Show();
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
            con.Close();
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
    }
}
