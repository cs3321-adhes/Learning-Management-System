using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UHD_Learn_AT
{
    public partial class passwordForm : Form
    {
        public passwordForm()
        {
            InitializeComponent2();
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
            Environment.Exit(0);
        }

        private void InitializeComponent2()
        {
            this.SuspendLayout();
            // 
            // passwordForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "passwordForm";
            this.Load += new System.EventHandler(this.passwordForm_Load);
            this.ResumeLayout(false);

        }

        private void passwordForm_Load(object sender, EventArgs e)
        {

        }
    }
}
