using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UHD_Learn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HomeBtt_Click(object sender, EventArgs e)
        {
            SyllabusPanel.Hide();
            CourseConPanel.Hide();
            AssignPanel.Hide();
            HomePanel.Show();
            label3.Text = "Course Home Page";
        }

        private void SyllabusBtt_Click(object sender, EventArgs e)
        {
            HomePanel.Hide();
            CourseConPanel.Hide();
            AssignPanel.Hide();
            SyllabusPanel.Show();
            label3.Text = "Syllabus";
        }

        private void CourseConBtt_Click(object sender, EventArgs e)
        {
            SyllabusPanel.Hide();
            HomePanel.Hide();
            AssignPanel.Hide();
            CourseConPanel.Show();
            label3.Text = "Course Content";
        }

        private void AssignmentBtt_Click(object sender, EventArgs e)
        {
            HomePanel.Hide();
            CourseConPanel.Hide();
            SyllabusPanel.Hide();
            AssignPanel.Show();
            label3.Text = "Assignments";


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GradeBtt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form grades = new grades();
            grades.Show();
        }

        private void CoursesHomeBtt_Click(object sender, EventArgs e)
        {
            SyllabusPanel.Hide();
            CourseConPanel.Hide();
            AssignPanel.Hide();
            HomePanel.Show();
            label3.Text = "Course Home Page";
        }
    }
}
