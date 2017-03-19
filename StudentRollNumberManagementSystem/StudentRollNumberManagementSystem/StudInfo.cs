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

        private void button2_Click(object sender, EventArgs e)
        {

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
                cmd.Parameters.AddWithValue("@roll", textBox1.Text);
                cmd.Parameters.AddWithValue("@seat", textBox2.Text);
                cmd.Parameters.AddWithValue("@name", textBox3.Text);
                cmd.Parameters.AddWithValue("@prn", textBox4.Text);
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
    }
}
