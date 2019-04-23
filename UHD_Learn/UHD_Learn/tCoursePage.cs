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
    public partial class tCoursePage : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ASUSVIVOBOOK\\SQLEXPRESS;Initial Catalog=UHD_Learn;Integrated Security=True");
        public tCoursePage()
        {
            InitializeComponent();
        }

        public void setLabel(string s)
        {
            label2.Text = s;
        }

        private void HomeBtt_Click(object sender, EventArgs e)
        {
            SyllabusPanel.Hide();
            CourseConPanel.Hide();
            AssignmentsPanel.Hide();
            AnnouncementsPanel.Hide();
            HomePanel.Show();
            label3.Text = "Home Page";
        }

        private void StudentsBttn_Click(object sender, EventArgs e)
        {
            HomePanel.Hide();
            CourseConPanel.Hide();
            SyllabusPanel.Hide();
            AnnouncementsPanel.Hide();
            AssignmentsPanel.Hide();
            StudentsPanel.Show();
            label3.Text = "Students";
        }


        private void SyllabusBttn_Click(object sender, EventArgs e)
        {
            HomePanel.Hide();
            CourseConPanel.Hide();
            AssignmentsPanel.Hide();
            AnnouncementsPanel.Hide();
            StudentsPanel.Hide();
            SyllabusPanel.Show();
            label3.Text = "Syllabus";
        }

        private void CourseConBtt_Click(object sender, EventArgs e)
        {
            SyllabusPanel.Hide();
            AssignmentsPanel.Hide();
            HomePanel.Hide();
            AnnouncementsPanel.Hide();
            StudentsPanel.Hide();
            CourseConPanel.Show();
            label3.Text = "Course Content";
        }

        private void AssignmentBtt_Click(object sender, EventArgs e)
        {
            HomePanel.Hide();
            CourseConPanel.Hide();
            SyllabusPanel.Hide();
            AnnouncementsPanel.Hide();
            StudentsPanel.Hide();
            AssignmentsPanel.Show();
            label3.Text = "Assignments";
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void GradeBtt_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form grades = new grades();
            //grades.Show();
        }

        private void AnnceBttn_Click(object sender, EventArgs e)
        {
            HomePanel.Hide();
            CourseConPanel.Hide();
            SyllabusPanel.Hide();
            AssignmentsPanel.Hide();
            AnnouncementsPanel.Show();
            label3.Text = "Announcements";
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e){}

        private void label2_Click(object sender, EventArgs e){}

        private void HomePanel_Paint(object sender, PaintEventArgs e){}

        private void SyllabusPanel_Paint(object sender, PaintEventArgs e){}

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e){}

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){}

        private void label4_Click(object sender, EventArgs e){}

        private void panel4_Paint(object sender, PaintEventArgs e){}

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){}

        private void label7_Click(object sender, EventArgs e){}

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form tGradesForm = new tGrades();
            tGradesForm.Show();
        }

        public void setTag(string s)
        {
            this.Tag = s;
        }

        private void LogOutBtt_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Login"].Show();
        }

        private void tCoursePage_Load(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Course where CRN='" + this.Tag + "'", con);

            SqlDataReader rd = cmd.ExecuteReader();

            Course course = new Course("", "", "", "");

            // If there are courses taught by this teacher
            if (rd.HasRows)
            {

                // reads the table
                while (rd.Read())
                {
                    // Add course info to course list
                    course.Crn = rd.GetString(0).Trim();
                    course.Subj = rd.GetString(1).Trim();
                    course.Cnum = rd.GetString(2).Trim();
                    course.Name = rd.GetString(3).Trim();

                }
            }

            textBox2.Text = course.Crn + " " + course.Subj + "" + course.Cnum + ": " + course.Name;

        }
    }
}
