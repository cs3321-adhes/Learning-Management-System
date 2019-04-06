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
    public partial class TeacherPage : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ANDREW\\SQLEXPRESS;Initial Catalog=UHD_LEARN;Integrated Security=True");

        //SqlConnection con = new SqlConnection("Data Source=ASUSVIVOBOOK\\SQLEXPRESS;Initial Catalog=UHD_Learn;Integrated Security=True");
        

        public void ChangeLabel(string s)
        {
            label1.Text = s;
            
        }

        public TeacherPage()
        {
            InitializeComponent();
        }

        private void TeacherPage_Load(object sender, EventArgs e)
        {
            
            List<string[]> courseNames = new List<string[]>();
            string[] course = new string[4];
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Course where teacher='" + label1.Text + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    for (int i = 0; i < 4; i++)
                    {
                        course[i] = rd.GetString(i).Trim();
                    }
                    courseNames.Add(course);
                            
                    
                    

                }
            }

            courseLabel1.Text = courseNames[0][0] + " " + courseNames[0][1] + "_" + courseNames[0][2] + ": " + courseNames[0][3];
            

        }
    }
}
