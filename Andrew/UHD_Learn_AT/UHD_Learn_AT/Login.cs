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

namespace UHD_Learn_AT
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ANDREW\\SQLEXPRESS;Initial Catalog=UHD_LEARN;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Login where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            string logType = "";
            if (rd.HasRows)
            {
                if (rd.Read())
                {
                    logType = rd.GetString(5);
                }
                
                if (logType.Trim().Equals("teacher"))
                {
                    TeacherPage teacherpage = new TeacherPage();
                    teacherpage.Show();
                    this.Hide();
                }
                else if (logType.Trim().Equals("student"))
                {
                    StudentPage studentpage = new StudentPage();
                    studentpage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username and Password.");
                }

            }
            
        }
    }
}
