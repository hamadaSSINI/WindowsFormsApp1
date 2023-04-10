using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data;

namespace WindowsFormsApp1
{
    internal class DoctorsClass
    {
        DBconnect connect = new DBconnect();
        // create a function to insert doctors
        public bool insertdoctors(string Dname, int dh, string desc)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `doctors`(`Doctorsname`, `DoctorsHours`, `Description`) VALUES (@dn, @dh, @desc)", connect.GetConnection);
            //@dn, @dh, @desc
            command.Parameters.Add("@dn", MySqlDbType.VarChar).Value = Dname;
            command.Parameters.Add("@dh", MySqlDbType.Int32).Value = dh;  
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;
            connect.openConnect();
            if(command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }
        //create a function to get doctors list
        public DataTable getdoctors(MySqlCommand command)
        {

            command.Connection = connect.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //create a update function for course edit
        public bool updateDoctors(int id, string Dname, int dh, string desc)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `doctors` SET `Doctorsname`=@dn,`DoctorsHours`=@dh,`Description`=@desc WHERE `DTId`=@id", connect.GetConnection);
            //@id,@dn,@dh,@desc
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@dn", MySqlDbType.VarChar).Value = Dname;
            command.Parameters.Add("@dh", MySqlDbType.Int32).Value = dh;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;
            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }
        //Create a function to delete a course
        //we only need course id
        public bool deletedoctors(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `doctors` WHERE `DTId`=@id", connect.GetConnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }
    }
}

    

