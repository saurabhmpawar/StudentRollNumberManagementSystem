using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace StudentRollNumberManagementSystem
{
    class DatabaseConnection
    {
        
        public static SqlConnection getDatabaseConnection()
        {   
       SqlConnection con;
       con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StudentMgt.mdf;Integrated Security=True";
                //@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\StudentRollNumberManagementSystem\StudentRollNumberManagementSystem\StudentRollNumberManagementSystem\StudentMgt.mdf; Integrated Security = True";
       return con;
        }
    }
}
    