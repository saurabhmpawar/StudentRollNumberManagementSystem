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
    public partial class StudentReport : Form
    {
        public StudentReport()
        {
            InitializeComponent();
        }

        private void StudentReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'StudentMgtDataSet1.studentInfo' table. You can move, or remove it, as needed.
            this.studentInfoTableAdapter.Fill(this.StudentMgtDataSet1.studentInfo);

            this.reportViewer1.RefreshReport();
        }
    }
}
