﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UHD_Learn_Grades
{
    public partial class Form1 : Form
    {
        public Form1()
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
            Hw3lbl.Show();
            Midterm1lbl.Show();
            Midterm2lbl.Show();
            TotalGradelbl.Show();
            Hw1Gradetxt.Show();
            Hw2Gradetxt.Show();
            Hw3Gradetxt.Show();
            Midterm1Gradetxt.Show();
            Midterm2Gradetxt.Show();
            TotalGradetxt.Show();
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
            Hw3lbl.Show();
            Midterm1lbl.Show();
            Midterm2lbl.Show();
            TotalGradelbl.Show();
            Hw1Gradetxt.Show();
            Hw2Gradetxt.Show();
            Hw3Gradetxt.Show();
            Midterm1Gradetxt.Show();
            Midterm2Gradetxt.Show();
            TotalGradetxt.Show();
        }
    }
}
