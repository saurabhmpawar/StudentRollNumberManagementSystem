using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

// Or:
using Microsoft.Reporting.WinForms;
namespace StudentRollNumberManagementSystem
{
    public partial class MArkListRepoertViewer : Form
    {
        public MArkListRepoertViewer()
        {
            InitializeComponent();
        }

        private void MArkListRepoertViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'StudentMgtDataSet6.ViewMarks' table. You can move, or remove it, as needed.
            this.ViewMarksTableAdapter.Fill(this.StudentMgtDataSet6.ViewMarks);
            // TODO: This line of code loads data into the 'StudentMgtDataSet1.studentInfo' table. You can move, or remove it, as needed.
            this.studentInfoTableAdapter.Fill(this.StudentMgtDataSet1.studentInfo);

            this.reportViewer1.RefreshReport();
        }

        private void ViewMarksBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
