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
    public partial class Dashboard : Form
    {
        private int childFormNumber = 0;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            AddLoginDetails ld = new AddLoginDetails();
            ld.Show();

        }

        private void StudInfo(object sender, EventArgs e)
        {
            StudInfo ld1 = new StudInfo();
            ld1.Show();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudInfo ld1 = new StudInfo();
            ld1.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
           
        }

        private void studentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudInfo stu = new StudInfo();
            stu.Show();

        }

        private void studentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentReport rpt = new StudentReport();
            rpt.Show();
        }

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLoginDetails adl = new AddLoginDetails();
            adl.Show();
        }

        private void subjectInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSubject sub = new AddSubject();
            sub.Show();
        }

        private void subjectReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sublistreport subje= new Sublistreport();
            subje.Show();
        }
    }
}
