﻿using System;
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
    public partial class tGrades : Form
    {
        public tGrades()
        {
            InitializeComponent();
        }

        private void _23924BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this._23924BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uHD_LearnDataSet);

        }

        private void tGrades_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uHD_LearnDataSet._23924' table. You can move, or remove it, as needed.
            this._23924TableAdapter.Fill(this.uHD_LearnDataSet._23924);

        }
    }
}
