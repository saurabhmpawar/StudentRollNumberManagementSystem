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
    public partial class SubjectListReport : Form
    {
        public SubjectListReport()
        {
            InitializeComponent();
        }

        private void SubjectListReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'StudentMgtDataSetsubject.subjects' table. You can move, or remove it, as needed.
            this.subjectsTableAdapter.Fill(this.StudentMgtDataSetsubject.subjects);

            this.reportViewer1.RefreshReport();
        }
    }
}
