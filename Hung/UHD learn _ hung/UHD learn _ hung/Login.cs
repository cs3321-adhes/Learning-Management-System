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

namespace UHD_learn___hung
{
    public partial class Login : Form
    {
        // Initializes Sql Connection.  Input is from Connection String from DB properties
        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-ANDREW\\SQLEXPRESS;Initial Catalog=UHD_LEARN;Integrated Security=True");

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\keens\\Documents\\UHD Learn.mdf\";Integrated Security=True;Connect Timeout=30");

        public Login()
        {
            InitializeComponent1();
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
                this.userBox.Text = "";
                this.pwBox.Text = "";
            }

            // closes DB connection
            con.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
          
        }

        // Opens forget pw page
        private void forgetPW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            passwordForm passwordForm = new passwordForm();
            passwordForm.Show();
            this.Hide();

        }

        private void InitializeComponent1()
        {
            this.SuspendLayout();
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load_1);
            this.ResumeLayout(false);

        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }

        //private void InitializeComponent1()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // Login
        //    // 
        //    this.ClientSize = new System.Drawing.Size(284, 261);
        //    this.Name = "Login";
        //    this.Load += new System.EventHandler(this.Login_Load_2);
        //    this.ResumeLayout(false);

        //}

        private void Login_Load_2(object sender, EventArgs e)
        {

        }

        //private void InitializeComponent1()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // Login
        //    // 
        //    this.ClientSize = new System.Drawing.Size(284, 261);
        //    this.Name = "Login";
        //    this.Load += new System.EventHandler(this.Login_Load_3);
        //    this.ResumeLayout(false);

        //}

        private void Login_Load_3(object sender, EventArgs e)
        {

        }

        //private void InitializeComponent1()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // Login
        //    // 
        //    this.ClientSize = new System.Drawing.Size(284, 261);
        //    this.Name = "Login";
        //    this.Load += new System.EventHandler(this.Login_Load_4);
        //    this.ResumeLayout(false);

        //}

        private void Login_Load_4(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load_5);
            this.ResumeLayout(false);

        }

        private void Login_Load_5(object sender, EventArgs e)
        {

        }
    }
}
