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
    public partial class passwordForm : Form
    {
        public passwordForm()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            userText.Text = "";
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A password reset link has been sent to your email.");
        }

        private void windowClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Login"].Show();
        }
    }
}
