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

        private static void ReadSingleRow(IDataRecord record)
        {
            MessageBox.Show(String.Format("{0}, {1}", record[0], record[1]));
        }
      
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
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Course where teacher='" + this.Text + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    ReadSingleRow((IDataRecord)rd);
                    //fname = rd.GetString(2).Trim();
                    //lname = rd.GetString(3).Trim();
                    //ID = rd.GetString(4).Trim();
                    //logType = rd.GetString(5).Trim();
                }
            }
        }
    }
}
