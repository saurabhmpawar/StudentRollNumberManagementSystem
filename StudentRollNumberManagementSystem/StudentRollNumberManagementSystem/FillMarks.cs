using System;
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
    public partial class FillMarks : Form
    {
        public FillMarks()
        {
            InitializeComponent();
        }

        private void FillMarks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentMgtDataSet2.marks_details' table. You can move, or remove it, as needed.
            this.marks_detailsTableAdapter.Fill(this.studentMgtDataSet2.marks_details);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMarksInfo minfo = new AddMarksInfo();
            minfo.Show();
            this.Hide();
        }
    }
}
