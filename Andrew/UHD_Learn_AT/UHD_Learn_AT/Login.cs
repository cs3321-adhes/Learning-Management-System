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
        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-ANDREW\\SQLEXPRESS;Initial Catalog=UHD_LEARN;Integrated Security=True");

        SqlConnection con = new SqlConnection(
                "Data Source=ASUSVIVOBOOK\\SQLEXPRESS;Initial Catalog=UHD_Learn;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Login where username='" + userBox.Text + "' and password='" + pwBox.Text + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            string logType = "";
            string ID = "";
            string fname = "";
            string lname = "";
            if (rd.HasRows)
            {
                if (rd.Read())
                {
                    fname = rd.GetString(2).Trim();
                    lname = rd.GetString(3).Trim();
                    ID = rd.GetString(4).Trim();
                    logType = rd.GetString(5).Trim();
                }
                rd.Close();
                
                if (logType.Equals("teacher"))
                {
                    TeacherPage teacherpage = new TeacherPage();
                    teacherpage.Text = "Welcome, " + lname;
                    teacherpage.ChangeLabel(fname + " " + lname); 
                    teacherpage.Show();
                    this.Hide();
                }
                else if (logType.Equals("student"))
                {
                    StudentPage studentpage = new StudentPage();
                    studentpage.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid Username and Password.");
            }
            con.Close();
        }
    }
}
