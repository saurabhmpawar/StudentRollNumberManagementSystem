﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRollNumberManagementSystem
{
    public partial class AddMarksInfo : Form
    {
        public AddMarksInfo()
        {
            InitializeComponent();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            FillMarks marks = new FillMarks();
            marks.Show();
            this.Hide();
        }
    }
}
