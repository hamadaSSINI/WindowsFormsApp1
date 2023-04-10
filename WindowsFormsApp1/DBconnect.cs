using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    /*
     * In this class Create the connection between application and mysql database
     * we need to install xampp na mysql connector to this project
     * we need to create the patients database
     */

    public class DBconnect

    {
        // to create connection
        
        MySqlConnection connect = new MySqlConnection("datasource=localhost;port=3308;username=root;password=;database=patientsdb;SSL Mode=None");

       
        public MySqlConnection GetConnection
        {
            get
            {
                return connect;
            }
        }
       
        public void openConnect()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();

        }
        
        public void closeConnect()
        {
            if (connect.State == System.Data.ConnectionState.Open)
                connect.Close();
        }
    }
}
