﻿using System;
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
    public partial class sCoursePage : Form
    {

        SqlConnection con = new SqlConnection("Data Source=ASUSVIVOBOOK\\SQLEXPRESS;Initial Catalog=UHD_Learn;Integrated Security=True");
        public string gatorID { get; protected internal set; }
        public string Crn { get; protected internal set; }
        public string gradeLabel { get; protected internal set; }

        public sCoursePage()
        {
            InitializeComponent();
        }

        public void setTag(string s)
        {
            this.Tag = s;
        }

        public void setLabel2(string s)
        {
            label2.Text = s;
        }

        public void setLabel(string s)
        {
            CourseName.Text = s;
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
            sGrades studentGrades = new sGrades();

            studentGrades.course1 = gradeLabel;
            studentGrades.gatorID = gatorID;
            studentGrades.Crn1 = Crn;
            studentGrades.setName(label2.Text);

            this.Hide();

            studentGrades.Show();

        }

        private void CoursesHomeBtt_Click(object sender, EventArgs e)
        {
            SyllabusPanel.Hide();
            CourseConPanel.Hide();
            AssignPanel.Hide();
            HomePanel.Show();
            label3.Text = "Course Home Page";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LogOutBtt_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Login"].Show();
        }
    }
}
