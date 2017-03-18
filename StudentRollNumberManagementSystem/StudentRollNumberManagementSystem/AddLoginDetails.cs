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
        }

        
        
        private void AddLoginDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentMgtDataSet.userLogin' table. You can move, or remove it, as needed.
            this.userLoginTableAdapter.Fill(this.studentMgtDataSet.userLogin);
            SqlConnection con = DatabaseConnection.getDatabaseConnection();

            con = DatabaseConnection.getDatabaseConnection();

            SqlCommand cmd = new SqlCommand("INSERT INTO userLogin (userId, password, role) VALUES (@Name, @password, @role)");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            cmd.Parameters.AddWithValue("@role", comboBox1.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlConnection con = DatabaseConnection.getDatabaseConnection();

            con = DatabaseConnection.getDatabaseConnection();

            SqlCommand cmd = new SqlCommand("INSERT INTO userLogin (userId, password, role) VALUES (@Name, @password, @role)");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            cmd.Parameters.AddWithValue("@role", comboBox1.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("inserted Successfully");
            cleardata();
            con.Close();

        }


        private void cleardata()
        {
            textBox2.Clear();
            textBox1.Clear();
            
        }

        
    }
}
