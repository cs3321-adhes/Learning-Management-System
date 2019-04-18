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
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\keens\\Documents\\UHD Learn.mdf\";Integrated Security=True;Connect Timeout=30");
        public StudentPage()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void ChangeLabel(string s)
        {
            label2.Text = s;
        }

        private void StudentPage_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * FROM Student where fname='Hung'", con);
            
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

            this.label2.Text = fname + " " + lname;

            //ChangeLabel(name);

            this.Text = "Welcome, " + fname;
            rd.Close();

            SqlCommand cmd1 = new SqlCommand("Select * FROM Course where CRN IN ('23924','24776')", con);

            rd = cmd1.ExecuteReader();

            List<Course> courseNames = new List<Course>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    courseNames.Add(new Course(rd.GetString(0).Trim(), rd.GetString(1).Trim(), rd.GetString(2).Trim(), rd.GetString(3).Trim(), rd.GetString(4).Trim()));

                }
            }
            var numOfCourse = courseNames.Count;
            switch (numOfCourse)
            {
                case 1:
                    courseLabel1.Text = courseNames[0].Crn + " " + courseNames[0].Subj + "_" + courseNames[0].Cnum + ": " + courseNames[0].Name + "-" + courseNames[0].tName;
                    courseLabel1.Show();
                    break;
                case 2:
                    courseLabel1.Text = courseNames[0].Crn + " " + courseNames[0].Subj + "_" + courseNames[0].Cnum + ": " + courseNames[0].Name + "-" + courseNames[0].tName;
                    courseLabel2.Text = courseNames[1].Crn + " " + courseNames[1].Subj + "_" + courseNames[1].Cnum + ": " + courseNames[1].Name + "-" + courseNames[0].tName;
                    courseLabel1.Show();
                    courseLabel2.Show();
                    break;
                case 3:
                    courseLabel1.Text = courseNames[0].Crn + " " + courseNames[0].Subj + "_" + courseNames[0].Cnum + ": " + courseNames[0].Name + "-" + courseNames[0].tName;
                    courseLabel2.Text = courseNames[1].Crn + " " + courseNames[1].Subj + "_" + courseNames[1].Cnum + ": " + courseNames[1].Name + "-" + courseNames[0].tName;
                    courseLabel3.Text = courseNames[2].Crn + " " + courseNames[2].Subj + "_" + courseNames[2].Cnum + ": " + courseNames[2].Name + "-" + courseNames[0].tName;
                    courseLabel1.Show();
                    courseLabel2.Show();
                    courseLabel3.Show();
                    break;
                case 4:
                    courseLabel1.Text = courseNames[0].Crn + " " + courseNames[0].Subj + "_" + courseNames[0].Cnum + ": " + courseNames[0].Name + "-" + courseNames[0].tName;
                    courseLabel2.Text = courseNames[1].Crn + " " + courseNames[1].Subj + "_" + courseNames[1].Cnum + ": " + courseNames[1].Name + "-" + courseNames[0].tName;
                    courseLabel3.Text = courseNames[2].Crn + " " + courseNames[2].Subj + "_" + courseNames[2].Cnum + ": " + courseNames[2].Name + "-" + courseNames[0].tName;
                    courseLabel4.Text = courseNames[3].Crn + " " + courseNames[3].Subj + "_" + courseNames[3].Cnum + ": " + courseNames[3].Name + "-" + courseNames[0].tName;
                    courseLabel1.Show();
                    courseLabel2.Show();
                    courseLabel3.Show();
                    courseLabel4.Show();
                    break;
                default:
                    break;

            }

        }

        public class Course
        {
            public string Crn { get; private set; }

            public string Subj { get; private set; }

            public string Cnum { get; private set; }

            public string Name { get; private set; }

            public string tName { get; private set; }

            public Course(string c, string s, string cn, string n, string t)
            {
                Crn = c;
                Subj = s;
                Cnum = cn;
                Name = n;
                tName = t;
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GPA gpa = new GPA();
            gpa.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyGrades mygrades = new MyGrades();
            mygrades.Show();
            this.Hide();
        }
    }
}
