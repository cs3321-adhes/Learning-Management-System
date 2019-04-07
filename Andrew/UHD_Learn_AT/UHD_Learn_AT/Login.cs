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
        // Initializes Sql Connection.  Input is from Connection String from DB properties
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ANDREW\\SQLEXPRESS;Initial Catalog=UHD_LEARN;Integrated Security=True");

        //SqlConnection con = new SqlConnection("Data Source=ASUSVIVOBOOK\\SQLEXPRESS;Initial Catalog=UHD_Learn;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // opens connection
            con.Open();
            // Sql command to find the row that matches the username and password the user inputs.
            SqlCommand cmd = new SqlCommand("SELECT * FROM Login where username='" + userBox.Text + "' and password='" + pwBox.Text + "'", con);

            // This is the sql data reader to read the data.
            SqlDataReader rd = cmd.ExecuteReader();

            // this is the initialization of varables to store info of the user to use later
            string logType = "";
            string ID = "";
            string fname = "";
            string lname = "";

            // if there is a row(meaning if the username and password matches)
            if (rd.HasRows)
            {
                // If the reader is able to read
                if (rd.Read())
                {
                    // This gets the string in the index of the columns.  We need to trim to get rid of the empty spaces
                    fname = rd.GetString(2).Trim();
                    lname = rd.GetString(3).Trim();
                    ID = rd.GetString(4).Trim();
                    logType = rd.GetString(5).Trim();
                }

                // closes reader
                rd.Close();
                
                // If the type of user matches teacher
                if (logType.Equals("teacher"))
                {
                    // This statement creates a new teacherpage form object
                    TeacherPage teacherpage = new TeacherPage();

                    // This statement sets the top of the window text to hello lname
                    teacherpage.Text = "Welcome, " + lname;

                    // This calls a method from teacherpage that changes the label to the first and last name of the user
                    teacherpage.ChangeLabel(fname + " " + lname); 

                    // this pops open the teacher page form
                    teacherpage.Show();

                    // this hides this form window
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
                // if username and password doesn't match, a message box will open and display this message
                MessageBox.Show("Invalid Username and Password.");
            }

            // closes DB connection
            con.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
          
        }
    }
}
