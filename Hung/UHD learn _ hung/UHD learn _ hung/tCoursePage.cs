using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UHD_learn___hung
{
    public partial class tCoursePage : Form
    {
        public tCoursePage()
        {
            InitializeComponent4();
        }

        private void tCoursePage_Load(object sender, EventArgs e)
        {
            listBox1.Text = "CS 3321 Software Engineering";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            syllabusLabel.Show();
        }

        private void InitializeComponent4()
        {
            this.SuspendLayout();
            // 
            // tCoursePage
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "tCoursePage";
            this.Load += new System.EventHandler(this.tCoursePage_Load_1);
            this.ResumeLayout(false);

        }

        private void tCoursePage_Load_1(object sender, EventArgs e)
        {

        }
    }
}
