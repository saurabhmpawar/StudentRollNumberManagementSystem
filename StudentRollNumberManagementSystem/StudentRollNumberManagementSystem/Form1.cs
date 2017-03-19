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
            if (userd == "admin" && password == "root")
            {
                return "Admin";
            }
            else if (userd == "staff" && password == "staff")
            {
                return "staff";
            }
            else
            {

                throw new Exception("invalid username or password");
            }
            
            
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (textPassword.Text != "" && text_username.Text != "")
            {

                try
                {

                    String role = getloginandRole(text_username.Text,textPassword.Text);

                    if (role == "Admin")
                    {
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                    else if(role=="staff")
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