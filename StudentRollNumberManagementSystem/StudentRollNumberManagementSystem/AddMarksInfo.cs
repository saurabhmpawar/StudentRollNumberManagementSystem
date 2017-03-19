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

namespace StudentRollNumberManagementSystem
{
    public partial class AddMarksInfo : Form
    {
        public String selectedValue = null;
        public int selectedSubjectid = 0;
        public AddMarksInfo()
        {
            InitializeComponent();
            fillSubjectCombo();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {

            selectedValue = comboBox1.Text;
            selectedSubjectid = (int)comboBox1.SelectedValue;
            FillMarks marks = new FillMarks(this);
            marks.Show();

            this.Hide();
        }


        private void fillSubjectCombo()
        {
            try
            {
                SqlConnection con = DatabaseConnection.getDatabaseConnection();


                string query = "select subjet_name,subject_id from subjects";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "subjet_name");
                comboBox1.DisplayMember = "subjet_name";
                comboBox1.ValueMember = "subject_id";
                comboBox1.DataSource = ds.Tables["subjet_name"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }
        private void AddMarksInfo_Load(object sender, EventArgs e)
        {
            
        }
    }
}
