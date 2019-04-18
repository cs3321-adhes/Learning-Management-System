using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
            HomePanel.Show();
        }

        private void SyllabusBtt_Click(object sender, EventArgs e)
        {
            HomePanel.Hide();
            CourseConPanel.Hide();
            SyllabusPanel.Show();
        }

        private void CourseConBtt_Click(object sender, EventArgs e)
        {
            SyllabusPanel.Hide();
            HomePanel.Hide();
            CourseConPanel.Show();
        }

        private void AssignmentBtt_Click(object sender, EventArgs e)
        {
            HomePanel.Hide();
            CourseConPanel.Hide();
            SyllabusPanel.Hide();
            label3.Text = "Assignments";


        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = "Another one";
        }

        private void GradeBtt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form grades = new grades();
            grades.Show();
        }
    }
}
