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

    

    public partial class StudentPage : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LY\\MSSQLSERVER01;Initial Catalog=\"UHD learn\";Integrated Security=True");
        public StudentPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void StudentPage_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * FROM Student where fname='Hung'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            string fname = "";
            string lname = "";
            

            if (rd.HasRows)
            {
                if(rd.Read())
                {
                    fname = rd.GetString(0).Trim();
                    lname = rd.GetString(1).Trim();
                }
            }

            this.label2.Text = fname + " " + lname;
            this.Text = "Welcome, " + fname;
        }
    }
}
