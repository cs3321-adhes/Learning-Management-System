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
    public partial class GPA : Form
    {

        SqlConnection con = new SqlConnection("Data Source=ASUSVIVOBOOK\\SQLEXPRESS;Initial Catalog=UHD_Learn;Integrated Security=True");

        string fname = "";
        string lname = "";
        string course1 = "";
        string course2 = "";
        string course3 = "";
        string course4 = "";
        List<Course> courseNames = new List<Course>();

        public string gatorID { get; protected internal set; }

        public GPA()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * FROM Student where gatorID='" + gatorID + "'", con);

            SqlDataReader rd = cmd.ExecuteReader();
            

            string name = fname + " " + lname;

            if (rd.HasRows)
            {
                if (rd.Read())
                {
                    fname = rd.GetString(0).Trim();
                    lname = rd.GetString(1).Trim();
                    course1 = rd.IsDBNull(4) ? null : rd.GetString(4).Trim();
                    course2 = rd.IsDBNull(5) ? null : rd.GetString(5).Trim();
                    course3 = rd.IsDBNull(6) ? null : rd.GetString(6).Trim();
                    course4 = rd.IsDBNull(7) ? null : rd.GetString(7).Trim();
                }
            }

            this.label1.Text = fname + " " + lname;

            //ChangeLabel(name);

            this.Text = "GPA Calculator";
            rd.Close();

            SqlCommand cmd1 = new SqlCommand("Select * FROM Course where CRN IN ('" + course1 + "','" + course2 + "','" + course3 + "','" + course4 + "')", con);

            rd = cmd1.ExecuteReader();

            

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    courseNames.Add(new Course(rd.GetString(0).Trim(), rd.GetString(1).Trim(), rd.GetString(2).Trim(), rd.GetString(3).Trim(), rd.GetString(4).Trim(), rd.GetInt32(5)));

                }
            }
            var numOfCourse = courseNames.Count;
            switch (numOfCourse)
            {
                case 1:
                    courseLabel1.Text = courseNames[0].Subj + "_" + courseNames[0].Cnum + " - Credit hours: " + courseNames[0].creditHr;
                    courseLabel1.Show();
                    text2.Hide();
                    text3.Hide();
                    text4.Hide();
                    break;
                case 2:
                    courseLabel1.Text = courseNames[0].Subj + "_" + courseNames[0].Cnum + " - Credit hours: " + courseNames[0].creditHr; ;
                    courseLabel2.Text = courseNames[1].Subj + "_" + courseNames[1].Cnum + " - Credit hours: " + courseNames[1].creditHr; ;
                    courseLabel1.Show();
                    courseLabel2.Show();
                    text3.Hide();
                    text4.Hide();
                    break;
                case 3:
                    courseLabel1.Text = courseNames[0].Subj + "_" + courseNames[0].Cnum + " - Credit hours: " + courseNames[0].creditHr; ; ;
                    courseLabel2.Text = courseNames[1].Subj + "_" + courseNames[1].Cnum + " - Credit hours: " + courseNames[1].creditHr; ; ;
                    courseLabel3.Text = courseNames[2].Subj + "_" + courseNames[2].Cnum + " - Credit hours: " + courseNames[2].creditHr; ; ;
                    courseLabel1.Show();
                    courseLabel2.Show();
                    courseLabel3.Show();
                    text4.Hide();
                    break;
                case 4:
                    courseLabel1.Text = courseNames[0].Subj + "_" + courseNames[0].Cnum + " - Credit hours: " + courseNames[0].creditHr; ; ;
                    courseLabel2.Text = courseNames[1].Subj + "_" + courseNames[1].Cnum + " - Credit hours: " + courseNames[1].creditHr; ; ;
                    courseLabel3.Text = courseNames[2].Subj + "_" + courseNames[2].Cnum + " - Credit hours: " + courseNames[2].creditHr; ; ;
                    courseLabel4.Text = courseNames[3].Subj + "_" + courseNames[3].Cnum + " - Credit hours: " + courseNames[3].creditHr; ; ;
                    courseLabel1.Show();
                    courseLabel2.Show();
                    courseLabel3.Show();
                    courseLabel4.Show();
                    break;
                default:
                    break;

            }
            rd.Close();
        }

        public class Course
        {
            public string Crn { get; private set; }

            public string Subj { get; private set; }

            public string Cnum { get; private set; }

            public string Name { get; private set; }

            public string tName { get; private set; }

            public int creditHr { get; private set; }

            public Course(string c, string s, string cn, string n, string t, int h)
            {
                Crn = c;
                Subj = s;
                Cnum = cn;
                Name = n;
                tName = t;
                creditHr = h;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Login"].Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Application.OpenForms["StudentPage"].Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double[] courseGrades;
            courseGrades = new double[4];
            int numOfCourses = courseNames.Count;

            double final, sumCredit = 1, total = 0;

           
            if (String.IsNullOrEmpty(text1.Text))
                courseGrades[0] = 0;
            else
                courseGrades[0] = double.Parse(text1.Text);
            if (String.IsNullOrEmpty(text2.Text))
                courseGrades[1] = 0;
            else
                courseGrades[1] = double.Parse(text2.Text);
            if (String.IsNullOrEmpty(text3.Text))
                courseGrades[2] = 0;
            else
                courseGrades[2] = double.Parse(text3.Text);
            if (String.IsNullOrEmpty(text4.Text))
                courseGrades[3] = 0;
            else
                courseGrades[3] = double.Parse(text4.Text);

            //sumCredit = courseGrades[0] + courseGrades[1] + courseGrades[2] + courseGrades[3];


            //int i = 5, j = 0;
            //if (rd.HasRows)
            //{
            //    while (rd.Read())
            //    {
            //        double n = double.Parse(rd.GetInt32(i).ToString().Trim());
            //        total = total + n * courseGrades[j];
            //        j++;
            //        n++;
            //    }
            //}
            

            for (int i = 0; i < numOfCourses; i++)
            {
                total += courseGrades[i] * courseNames[i].creditHr;
            }

            final = total / (3* numOfCourses);

            text5.Text = final.ToString("0.00");
            text5.Show();

        }
      
    }
}
