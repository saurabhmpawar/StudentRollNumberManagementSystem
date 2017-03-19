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
    public partial class StudInfo : Form
    {
        int rollno = 0;

        public StudInfo()
        {
            InitializeComponent();
        }

        private void StudInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentMgtDataSet1.studentInfo' table. You can move, or remove it, as needed.
            this.studentInfoTableAdapter.Fill(this.studentMgtDataSet1.studentInfo);
            // TODO: This line of code loads data into the 'studentMgtDataSet.userLogin' table. You can move, or remove it, as needed.
            this.userLoginTableAdapter.Fill(this.studentMgtDataSet.userLogin);

        }

       
        private void DisplayData()
        {
            SqlConnection con = DatabaseConnection.getDatabaseConnection();
           
            SqlDataAdapter adapt;

            con = DatabaseConnection.getDatabaseConnection();

            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from studentInfo", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentMgtDataSet.userLogin' table. You can move, or remove it, as needed.
           // this.StudInfoTableAdapter.Fill(this.studentMgtDataSet.StudInfo);
            SqlConnection con = DatabaseConnection.getDatabaseConnection();
            try
            {
                con = DatabaseConnection.getDatabaseConnection();

                SqlCommand cmd = new SqlCommand("INSERT INTO studentInfo (roll_number, exam_seat_no, name, prn_number) VALUES (@roll, @seat, @name, @prn)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@roll", txt_rollno.Text);
                cmd.Parameters.AddWithValue("@seat", txt_seatno.Text);
                cmd.Parameters.AddWithValue("@name", txt_name.Text);
                cmd.Parameters.AddWithValue("@prn", txt_prn.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserted succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayData();
                    }
            catch (Exception da)
            {
                MessageBox.Show("opps something went wrong!!!"+da.GetBaseException());
            }

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rollno = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            txt_seatno.Text= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_name.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_prn.Text= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_rollno.Text = "" + rollno;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (rollno != 0)
            {
                try
                {
                    SqlCommand cmd;
                    SqlConnection con = DatabaseConnection.getDatabaseConnection();

                    con = DatabaseConnection.getDatabaseConnection();

                    cmd = new SqlCommand("delete studentInfo where roll_number=@roll_number", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@roll_number", rollno);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted Successfully!");
                    DisplayData();
                }catch (Exception hh)
                {
                    MessageBox.Show("Can't delete student if marks are entered \n","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                    MessageBox.Show("Error Details :\n\n"+hh.GetBaseException());
                }

            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void clearal()
        {
            txt_name.Clear();
            txt_prn.Clear();
            txt_rollno.Clear();
            txt_seatno.Clear();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_name.Text != "" && txt_prn.Text != "" && txt_seatno.Text!="")
                {
                    SqlCommand cmd;
                    SqlConnection con = DatabaseConnection.getDatabaseConnection();

                    con = DatabaseConnection.getDatabaseConnection();

                    cmd = new SqlCommand("update studentInfo set exam_seat_no=@exam_seat_no,name=@name,prn_number=@prn_number where roll_number=@roll_number", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@exam_seat_no", txt_seatno.Text);
                    cmd.Parameters.AddWithValue("@name", txt_name.Text);
                    cmd.Parameters.AddWithValue("@prn_number", txt_prn.Text);
                    cmd.Parameters.AddWithValue("@roll_number", rollno);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully");
                    con.Close();
                    DisplayData();
                    clearal();

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

        }
    }
}
