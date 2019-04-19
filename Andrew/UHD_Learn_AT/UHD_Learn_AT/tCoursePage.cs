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
    public partial class tCoursePage : Form
    {
        public tCoursePage()
        {
            InitializeComponent();
        }

        private void tCoursePage_Load(object sender, EventArgs e)
        {
            //listBox1.Text = "CS 3321 Software Engineering";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            syllabusLabel.Show();
        }
    }
}
