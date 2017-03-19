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
    public partial class Sublistreport : Form
    {
        public Sublistreport()
        {
            InitializeComponent();
        }

        private void Sublistreport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'StudentMgtDataSet3.subjects' table. You can move, or remove it, as needed.
            this.subjectsTableAdapter.Fill(this.StudentMgtDataSet3.subjects);

            this.reportViewer1.RefreshReport();
        }
    }
}
