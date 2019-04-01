using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        //StreamReader sr = new StreamReader("file.txt");
        //StreamWriter sw = new StreamWriter(@"C:\");

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hi, " + textBox1.Text);
            string user, pw;
            user = username.Text;
            pw = password.Text;
            if (user == "username" && pw == "123456")
            {
                Form f = new Form2();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username and Password");
            }
            

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
