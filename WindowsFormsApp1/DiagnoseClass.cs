using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    internal class DiagnoseClass
    {
        DBconnect connect = new DBconnect();

        public bool insertdiagnose(int ptid, string dn, string diag, string desc)
        {
            // Create a function add diagnose
            MySqlCommand command = new MySqlCommand("INSERT INTO `diagnose`(`patientsId`, `Doctorsname`, `Diagnose`, `Description`) VALUES (@ptid,@dn,@diag,@desc)", connect.GetConnection);
            //@ptid, @dn, @diag, @desc
            command.Parameters.Add("@ptid", MySqlDbType.Int32).Value = ptid;
            command.Parameters.Add("@dn", MySqlDbType.VarChar).Value = dn;
            command.Parameters.Add("@diag", MySqlDbType.VarChar).Value = diag;
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
        //create a fucntion to get list
        public DataTable getList(MySqlCommand command)
        {

            command.Connection = connect.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        // create a function to check already doctors diagnose
        public bool checkdiagnose(int ptid, string dn)
        {
            DataTable table = getList(new MySqlCommand("SELECT * FROM `diagnose` WHERE `patientsId`=" + ptid + "  AND`Doctorsname`='" + dn + "'"));
            if (table.Rows.Count > 0)
            { return true; }
            else
            { return false; }
        }
        // create a function to edit diagnose data
        public bool updatediagnose(int ptid, string dn, string diag, string desc)
        {
            // Create a function add diagnose
            MySqlCommand command = new MySqlCommand("UPDATE `diagnose` SET `Diagnose`=@diag,`Description`=@desc WHERE `patientsId`=@ptid AND`Doctorsname`=@dn", connect.GetConnection);
            //@ptid, @dn, @diag, @desc
            command.Parameters.Add("@dn", MySqlDbType.VarChar).Value = dn;
            command.Parameters.Add("@ptid", MySqlDbType.Int32).Value = ptid;
            command.Parameters.Add("@diag", MySqlDbType.VarChar).Value = diag;
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
        // create a fucntion to delete  diagnose data
        public bool deletediagnose(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `patients` WHERE `PTId`=@id", connect.GetConnection);

            //@id
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
