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

namespace UHD_learn___hung
{

    public partial class TeacherPage : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-ANDREW\\SQLEXPRESS;Initial Catalog=UHD_LEARN;Integrated Security=True");

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\keens\\Documents\\UHD Learn.mdf\";Integrated Security=True;Connect Timeout=30");
        
        // Function to change the logout label based on info from log in screen.
        public void ChangeLabel(string s)
        {
            label1.Text = s;
            
        }

        public TeacherPage()
        {
            InitializeComponent5();
        }

        private void TeacherPage_Load(object sender, EventArgs e)
        {
            // Declared list of courses to hold course info
            List<Course> courseNames = new List<Course>();
            con.Open();
            // Select only courses taught by this teacher
            SqlCommand cmd = new SqlCommand("SELECT * FROM Course where teacher='" + label1.Text + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();

            // If there are courses taught by this teacher
            if (rd.HasRows)
            {

                // reads the table
                while (rd.Read())
                {
                    // Add course info to course list
                    courseNames.Add(new Course(rd.GetString(0).Trim(), rd.GetString(1).Trim(), rd.GetString(2).Trim(), rd.GetString(3).Trim()));             
                    
                }
            }

            // To store the number of courses
            var numOfCourse = courseNames.Count;

            // switch statement for different number of courses
            switch (numOfCourse)
            {
                case 1:
                    // Sets course labels to display course number, subject, sub num and course name
                    courseLabel1.Text = courseNames[0].Crn + " " + courseNames[0].Subj + "_" + courseNames[0].Cnum + ": " + courseNames[0].Name;
                    
                    courseLabel1.Show();
                    break;
                case 2:
                    courseLabel1.Text = courseNames[0].Crn + " " + courseNames[0].Subj + "_" + courseNames[0].Cnum + ": " + courseNames[0].Name;
                    courseLabel2.Text = courseNames[1].Crn + " " + courseNames[1].Subj + "_" + courseNames[1].Cnum + ": " + courseNames[1].Name;
                    courseLabel1.Show();
                    courseLabel2.Show();
                    break;
                case 3:
                    courseLabel1.Text = courseNames[0].Crn + " " + courseNames[0].Subj + "_" + courseNames[0].Cnum + ": " + courseNames[0].Name;
                    courseLabel2.Text = courseNames[1].Crn + " " + courseNames[1].Subj + "_" + courseNames[1].Cnum + ": " + courseNames[1].Name;
                    courseLabel3.Text = courseNames[2].Crn + " " + courseNames[2].Subj + "_" + courseNames[2].Cnum + ": " + courseNames[2].Name;
                    courseLabel1.Show();
                    courseLabel2.Show();
                    courseLabel3.Show();
                    break;
                case 4:
                    courseLabel1.Text = courseNames[0].Crn + " " + courseNames[0].Subj + "_" + courseNames[0].Cnum + ": " + courseNames[0].Name;
                    courseLabel2.Text = courseNames[1].Crn + " " + courseNames[1].Subj + "_" + courseNames[1].Cnum + ": " + courseNames[1].Name;
                    courseLabel3.Text = courseNames[2].Crn + " " + courseNames[2].Subj + "_" + courseNames[2].Cnum + ": " + courseNames[2].Name;
                    courseLabel4.Text = courseNames[3].Crn + " " + courseNames[3].Subj + "_" + courseNames[3].Cnum + ": " + courseNames[3].Name;
                    courseLabel1.Show();
                    courseLabel2.Show();
                    courseLabel3.Show();
                    courseLabel4.Show();
                    break;
                default:
                    break;
                 
            }
           con.Close();
        }

        private void TeacherPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();

        }

        private void CreateCoursePage()
        {

        }

        private void courseLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //con.Open();
            SqlCommand cmd = new SqlCommand("Select * FROM Course WHERE CRN = '" + courseLabel1.Tag + "'", con);
            tCoursePage tcPage = new tCoursePage();

            tcPage.Text = courseLabel1.Text;
            this.Hide();
            tcPage.Show();
        }

        private void InitializeComponent5()
        {
            this.SuspendLayout();
            // 
            // TeacherPage
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "TeacherPage";
            this.Load += new System.EventHandler(this.TeacherPage_Load_1);
            this.ResumeLayout(false);

        }

        private void TeacherPage_Load_1(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TeacherPage
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "TeacherPage";
            this.Load += new System.EventHandler(this.TeacherPage_Load_2);
            this.ResumeLayout(false);

        }

        private void TeacherPage_Load_2(object sender, EventArgs e)
        {

        }
    }

    // class created named course to store course info
    public class Course
    {
        // properties with getters and setters for each course attribute
        public string Crn { get; private set; }

        public string Subj { get; private set; }

        public string Cnum { get; private set; }

        public string Name { get; private set; }

        // parametized constructor
        public Course(string c, string s, string cn, string n)
        {
            Crn = c;
            Subj = s;
            Cnum = cn;
            Name = n;
        }

    }

   
}
