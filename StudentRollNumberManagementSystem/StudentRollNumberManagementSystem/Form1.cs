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
    public partial class Form1 : Form
    {


        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
        }

        private String getloginandRole(String userd,String password)
        {
         //   MessageBox.Show(userd + password);
            //select * from userLogin where userId= and password=
            String roll = null;
            try
            {
                SqlConnection con = DatabaseConnection.getDatabaseConnection();

                con = DatabaseConnection.getDatabaseConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("select *  from userLogin where userId=@userId and  password=@password", con);

                cmd.Parameters.AddWithValue("@userId", userd);
                cmd.Parameters.AddWithValue("@password", password);

                Boolean flagfound = false;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        roll = reader["role"].ToString();
                        flagfound = true;
                    }
                }

                con.Close();

                if(!flagfound)
                {
                    throw new Exception("Wrong password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror Occured while fetching student resoard\n\n\n" + ex.GetBaseException());
            }
            return roll; 
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (textPassword.Text != "" && text_username.Text != "")
            {

                try
                {

                    String role = getloginandRole(text_username.Text,textPassword.Text);
                  //  MessageBox.Show("role"+role);
                    if (role == "Admin")
                    {
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                    else if(role=="Staff")
                    {
                        staffDashboard mystaffDashboard = new staffDashboard();

                        mystaffDashboard.Show();
                        this.Hide();
                    }

                }
                catch (Exception we)
                {
                    MessageBox.Show("Oppes ....\n\n" + we.GetBaseException());
                }

               }
            else
            {
                MessageBox.Show("Please fill All fields", "All Filed required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}