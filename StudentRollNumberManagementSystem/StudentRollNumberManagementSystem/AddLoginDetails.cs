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

    public partial class AddLoginDetails : Form
    {
        public AddLoginDetails()
        {
            InitializeComponent();
            DisplayData();
        }


        String username = null;
        private void DisplayData()
        {
            SqlConnection con = DatabaseConnection.getDatabaseConnection();

            SqlDataAdapter adapt;

            con = DatabaseConnection.getDatabaseConnection();

            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from userLogin", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void AddLoginDetails_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'studentMgtDataSet.userLogin' table. You can move, or remove it, as needed.
                //this.userLoginTableAdapter.Fill(this.studentMgtDataSet.userLogin);

                if(txt_Password.Text!="" && text_username.Text!=""      )
                {

                

                SqlConnection con = DatabaseConnection.getDatabaseConnection();

                con = DatabaseConnection.getDatabaseConnection();

                SqlCommand cmd = new SqlCommand("INSERT INTO userLogin (userId, password, role) VALUES (@Name, @password, @role)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@Name", text_username.Text);
                cmd.Parameters.AddWithValue("@password", txt_Password.Text);
                cmd.Parameters.AddWithValue("@role", comboBox1_role.Text);
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
            }
            catch (Exception ss)
            {
                MessageBox.Show("opps error occured \n\n" + ss.GetBaseException());
            }

        }


        private void cleardata()
        {
            txt_Password.Clear();
            text_username.Clear();
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }



     
        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            username = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            text_username.Text = username;
            txt_Password.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox1_role.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

        }

        private void butn_delete_Click(object sender, EventArgs e)
        {
            if (username != null)
            {
                SqlCommand cmd;
                SqlConnection con = DatabaseConnection.getDatabaseConnection();

                con = DatabaseConnection.getDatabaseConnection();

                cmd = new SqlCommand("delete userLogin where userId=@userName", con);
                con.Open();
                cmd.Parameters.AddWithValue("@userName", username);
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
    }
}
