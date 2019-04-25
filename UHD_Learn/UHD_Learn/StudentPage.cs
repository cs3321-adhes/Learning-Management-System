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

    public partial class StudentPage : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ASUSVIVOBOOK\\SQLEXPRESS;Initial Catalog=UHD_Learn;Integrated Security=True");
        List<Course> courseNames = new List<Course>();
        private int numOfCourse;

        public StudentPage()
        {
            InitializeComponent();
        }

        public string gatorID { get; protected internal set; }


        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void StudentPage_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * FROM Student where gatorID='" + gatorID + "'", con);
            
            SqlDataReader rd = cmd.ExecuteReader();
            string fname = "";
            string lname = "";

            string name = fname + " " + lname;

            if (rd.HasRows)
            {
                if(rd.Read())
                {
                    fname = rd.GetString(0).Trim();
                    lname = rd.GetString(1).Trim();
                }
            }

            rd.Close();

            label2.Text = fname + " " + lname;

            this.Text = "Welcome, " + fname;
            rd.Close();

            SqlCommand cmd1 = new SqlCommand("Select * FROM Student where gatorID ='" + gatorID + "'", con);

            rd = cmd1.ExecuteReader();

            List<String> courseID = new List<String>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    
                    courseID.Add(rd.IsDBNull(4) ? null : rd.GetString(4).Trim());
                    courseID.Add(rd.IsDBNull(5) ? null : rd.GetString(5).Trim());
                    courseID.Add(rd.IsDBNull(6) ? null : rd.GetString(6).Trim());
                    courseID.Add(rd.IsDBNull(7) ? null : rd.GetString(7).Trim());

                }
            }

            rd.Close();

            SqlCommand cmd2 = new SqlCommand("Select * FROM Course WHERE CRN IN ('" + courseID[0] + "','" + courseID[1] + "','" + courseID[2] + "','" + courseID[3] +"')", con);
            rd = cmd2.ExecuteReader();

           


            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    courseNames.Add(new Course(rd.GetString(0).Trim(), rd.GetString(1).Trim(), rd.GetString(2).Trim(), rd.GetString(3).Trim(), rd.GetString(4).Trim()));

                }
            }
            numOfCourse = courseNames.Count;
            switch (numOfCourse)
            {
                case 1:
                    courseLabel1.Text = courseNames[0].Crn + " " + courseNames[0].Subj + "_" + courseNames[0].Cnum + ": " + courseNames[0].Name + "-" + courseNames[0].tName;
                    courseLabel1.Show();
                    break;
                case 2:
                    courseLabel1.Text = courseNames[0].Crn + " " + courseNames[0].Subj + "_" + courseNames[0].Cnum + ": " + courseNames[0].Name + "-" + courseNames[0].tName;
                    courseLabel2.Text = courseNames[1].Crn + " " + courseNames[1].Subj + "_" + courseNames[1].Cnum + ": " + courseNames[1].Name + "-" + courseNames[1].tName;
                    courseLabel1.Show();
                    courseLabel2.Show();
                    break;
                case 3:
                    courseLabel1.Text = courseNames[0].Crn + " " + courseNames[0].Subj + "_" + courseNames[0].Cnum + ": " + courseNames[0].Name + "-" + courseNames[0].tName;
                    courseLabel2.Text = courseNames[1].Crn + " " + courseNames[1].Subj + "_" + courseNames[1].Cnum + ": " + courseNames[1].Name + "-" + courseNames[1].tName;
                    courseLabel3.Text = courseNames[2].Crn + " " + courseNames[2].Subj + "_" + courseNames[2].Cnum + ": " + courseNames[2].Name + "-" + courseNames[2].tName;
                    courseLabel1.Show();
                    courseLabel2.Show();
                    courseLabel3.Show();
                    break;
                case 4:
                    courseLabel1.Text = courseNames[0].Crn + " " + courseNames[0].Subj + "_" + courseNames[0].Cnum + ": " + courseNames[0].Name + "-" + courseNames[0].tName;
                    courseLabel2.Text = courseNames[1].Crn + " " + courseNames[1].Subj + "_" + courseNames[1].Cnum + ": " + courseNames[1].Name + "-" + courseNames[1].tName;
                    courseLabel3.Text = courseNames[2].Crn + " " + courseNames[2].Subj + "_" + courseNames[2].Cnum + ": " + courseNames[2].Name + "-" + courseNames[2].tName;
                    courseLabel4.Text = courseNames[3].Crn + " " + courseNames[3].Subj + "_" + courseNames[3].Cnum + ": " + courseNames[3].Name + "-" + courseNames[3].tName;
                    courseLabel1.Show();
                    courseLabel2.Show();
                    courseLabel3.Show();
                    courseLabel4.Show();
                    break;
                default:
                    break;

            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sCoursePage scPage = new sCoursePage();
            scPage.Text = courseLabel1.Text;
            scPage.setLabel(courseLabel1.Text);
            scPage.setLabel2(label2.Text);
            scPage.Crn = courseNames[0].Crn;
            scPage.gradeLabel = courseNames[0].Subj + " " + courseNames[0].Cnum + "-" + courseNames[0].Name;
            scPage.gatorID = gatorID;

            this.Hide();
            scPage.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            coursepanel.Hide();
            announcementPanel.Show();
            welcomePanel.Hide();
            calendarPanel.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sGrades studentGrades = new sGrades();
            switch (numOfCourse)
            {
                case 1:
                    studentGrades.course1 = courseNames[0].Subj + " " + courseNames[0].Cnum + "-" + courseNames[0].Name;
                    studentGrades.Crn1 = courseNames[0].Crn;
                    break;
                case 2:
                    studentGrades.course1 = courseNames[0].Subj + " " + courseNames[0].Cnum + "-" + courseNames[0].Name;
                    studentGrades.Crn1 = courseNames[0].Crn;
                    studentGrades.course2 = courseNames[1].Subj + " " + courseNames[1].Cnum + "-" + courseNames[1].Name;
                    studentGrades.Crn2 = courseNames[1].Crn;
                    break;
                case 3:
                    studentGrades.course1 = courseNames[0].Subj + " " + courseNames[0].Cnum + "-" + courseNames[0].Name;
                    studentGrades.Crn1 = courseNames[0].Crn;
                    studentGrades.course2 = courseNames[1].Subj + " " + courseNames[1].Cnum + "-" + courseNames[1].Name;
                    studentGrades.Crn2 = courseNames[1].Crn;
                    studentGrades.course3 = courseNames[2].Subj + " " + courseNames[2].Cnum + "-" + courseNames[2].Name;
                    studentGrades.Crn3 = courseNames[2].Crn;
                    break;
                case 4:
                    studentGrades.course1 = courseNames[0].Subj + " " + courseNames[0].Cnum + "-" + courseNames[0].Name;
                    studentGrades.Crn1 = courseNames[0].Crn;
                    studentGrades.course2 = courseNames[1].Subj + " " + courseNames[1].Cnum + "-" + courseNames[1].Name;
                    studentGrades.Crn2 = courseNames[1].Crn;
                    studentGrades.course3 = courseNames[2].Subj + " " + courseNames[2].Cnum + "-" + courseNames[2].Name;
                    studentGrades.Crn3 = courseNames[2].Crn;
                    studentGrades.course4 = courseNames[3].Subj + " " + courseNames[3].Cnum + "-" + courseNames[3].Name;
                    studentGrades.Crn4 = courseNames[3].Crn;
                    break;
                default:
                    break;
            }
            
            
            studentGrades.gatorID = gatorID;
            studentGrades.setName(label2.Text);

            this.Hide();
            studentGrades.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            coursepanel.Hide();
            welcomePanel.Hide();
            announcementPanel.Hide();
            calendarPanel.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            coursepanel.Show();
            welcomePanel.Hide();
            announcementPanel.Hide();
            calendarPanel.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calendarPanel.Show();
            coursepanel.Hide();
            welcomePanel.Hide();
            announcementPanel.Hide();
        }

        private void HomeBtt_Click(object sender, EventArgs e)
        {
            StudentPage studentpage = new StudentPage();
            studentpage.Show();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void announcement_Click(object sender, EventArgs e)
        {

        }

        private void LogOutBtt_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Login"].Show();
        }

        private void courseLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sCoursePage scPage = new sCoursePage();
            scPage.Text = courseLabel2.Text;
            scPage.setLabel(courseLabel2.Text);
            scPage.setLabel2(label2.Text);
            scPage.Crn = courseNames[1].Crn;
            scPage.gradeLabel = courseNames[1].Subj + " " + courseNames[1].Cnum + "-" + courseNames[1].Name;
            scPage.gatorID = gatorID;

            this.Hide();
            scPage.Show();
        }

        private void courseLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sCoursePage scPage = new sCoursePage();
            scPage.Text = courseLabel3.Text;
            scPage.setLabel(courseLabel3.Text);
            scPage.setLabel2(label2.Text);
            scPage.Crn = courseNames[2].Crn;
            scPage.gradeLabel = courseNames[2].Subj + " " + courseNames[2].Cnum + "-" + courseNames[2].Name;
            scPage.gatorID = gatorID;

            this.Hide();
            scPage.Show();
        }

        private void courseLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sCoursePage scPage = new sCoursePage();
            scPage.Text = courseLabel4.Text;
            scPage.setLabel(courseLabel4.Text);
            scPage.setLabel2(label2.Text);
            scPage.Crn = courseNames[3].Crn;
            scPage.gradeLabel = courseNames[3].Subj + " " + courseNames[3].Cnum + "-" + courseNames[3].Name;
            scPage.gatorID = gatorID;

            this.Hide();
            scPage.Show();
        }
    }
}
