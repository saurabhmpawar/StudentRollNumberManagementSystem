using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentRollNumberManagementSystem
{
    public partial class AddSubject : Form
    {

        String subjectId = null;
        public AddSubject()
        {
            InitializeComponent();
            DisplayData();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            try
            {
                // TODO: This line of code loads data into the 'studentMgtDataSet.userLogin' table. You can move, or remove it, as needed.
                //this.userLoginTableAdapter.Fill(this.studentMgtDataSet.userLogin);

                if (txt_subjectName.Text != "" && txt_failMArk.Text != "" && txt_termworkMark.Text != "")
                {



                    SqlConnection con = DatabaseConnection.getDatabaseConnection();

                    con = DatabaseConnection.getDatabaseConnection();

                    SqlCommand cmd = new SqlCommand("INSERT INTO subjects (subjet_name, sem, tw_mark, min_mark) VALUES ( @name, @sem, @tw, @min)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    //cmd.Parameters.AddWithValue("@id", text_SUBJECT_ID.Text);
                    cmd.Parameters.AddWithValue("@name", txt_subjectName.Text);
                    cmd.Parameters.AddWithValue("@sem", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@tw", txt_termworkMark.Text);
                    cmd.Parameters.AddWithValue("@min", txt_failMArk.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please Provide Details!");
                }
                MessageBox.Show("Recoard added succssfully");
                DisplayData();
                clearall();
            }
            catch (Exception ss)
            {
                MessageBox.Show("opps error occured \n\n" + ss.GetBaseException());
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (subjectId != null)
            {
                SqlCommand cmd;
                SqlConnection con = DatabaseConnection.getDatabaseConnection();

                con = DatabaseConnection.getDatabaseConnection();

                cmd = new SqlCommand("delete from subjects where subject_id =@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", subjectId);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }


        private void DisplayData()
        {
            SqlConnection con = DatabaseConnection.getDatabaseConnection();

            SqlDataAdapter adapt;

            con = DatabaseConnection.getDatabaseConnection();

            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from subjects", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void clearall()
        {
            txt_failMArk.Clear();
            txt_subjectName.Clear();
            txt_termworkMark.Clear();
            comboBox1.Text = "";
        }

        private void AddSubject_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentMgtDataSet3.subjects' table. You can move, or remove it, as needed.
            this.subjectsTableAdapter.Fill(this.studentMgtDataSet3.subjects);

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            subjectId =
                    dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_subjectName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_termworkMark.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_failMArk.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();


        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'studentMgtDataSet.userLogin' table. You can move, or remove it, as needed.
                //this.userLoginTableAdapter.Fill(this.studentMgtDataSet.userLogin);

                if (txt_subjectName.Text != "" && txt_failMArk.Text != "" && txt_termworkMark.Text != "")
                {
                    SqlCommand cmd;
                    SqlConnection con = DatabaseConnection.getDatabaseConnection();

                    con = DatabaseConnection.getDatabaseConnection();

                    cmd = new SqlCommand("update subjects set subjet_name=@name,sem=@sem,tw_mark=@tw_mark,min_mark=@min_mark where subject_id=@subject_id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@subject_id", subjectId);
                    cmd.Parameters.AddWithValue("@name", txt_subjectName.Text);
                    cmd.Parameters.AddWithValue("@sem", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@tw_mark", txt_termworkMark.Text);
                    cmd.Parameters.AddWithValue("@min_mark", txt_failMArk.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully");
                    con.Close();
                    DisplayData();
                    clearall();

                }
            else  
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }
            catch (Exception es)
            {
                MessageBox.Show("error :\n\n" + es.GetBaseException());
            }

        }   }
    }

