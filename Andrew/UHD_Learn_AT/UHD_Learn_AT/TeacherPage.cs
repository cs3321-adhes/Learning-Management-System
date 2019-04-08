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

namespace UHD_Learn_AT
{

    public partial class TeacherPage : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-ANDREW\\SQLEXPRESS;Initial Catalog=UHD_LEARN;Integrated Security=True");

        SqlConnection con = new SqlConnection("Data Source=ASUSVIVOBOOK\\SQLEXPRESS;Initial Catalog=UHD_Learn;Integrated Security=True");
        
        // Function to change the logout label based on info from log in screen.
        public void ChangeLabel(string s)
        {
            label1.Text = s;
            
        }

        public TeacherPage()
        {
            InitializeComponent();
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
            var numOfCourse = courseNames.Count;
            switch (numOfCourse)
            {
                case 1:
                    courseLabel1.Text = courseNames[0].Crn + " " + courseNames[0].Subj + "_" + courseNames[0].Cnum + ": " + courseNames[0].Name + "- Yu Chang";
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
    }
    public class Course
    {
        public string Crn { get; private set; }

        public string Subj { get; private set; }

        public string Cnum { get; private set; }

        public string Name { get; private set; }

        public Course(string c, string s, string cn, string n)
        {
            Crn = c;
            Subj = s;
            Cnum = cn;
            Name = n;
        }

    }

   
}
