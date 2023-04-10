using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace WindowsFormsApp1
{
    internal class Patientclass
    {
        DBconnect connect = new DBconnect();
        public bool insertpatients(string fname, string lname, DateTime bdate, string gender, string contactnumber, string address, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `patients`(`PtFirstName`, `PtLastNmame`, `BirthDate`, `Gender`, `ContactNumber`, `Address`, `Photo`) VALUES (@fn, @ln, @bd, @gd, @cn, @adr, @img)", connect.GetConnection);

            //@fn, @ln, @bd, @gd, @cn, @adr, @img
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = contactnumber;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

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
        // to get patients table
        public DataTable GetPatientslist(MySqlCommand command)
        {
            command.Connection = connect.GetConnection;           
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        /// Create a function to execute the count query(total, male , female)
        public string exeCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, connect.GetConnection);
            connect.openConnect();
            string count = command.ExecuteScalar().ToString();
            connect.closeConnect();
            return count;

        }
        //to get the total patients
        public string totalpatients()
        {
            return exeCount("SELECT COUNT(*) FROM patients");
        }
        // to get the male student count
        public string malepatients()
        {
            return exeCount("SELECT COUNT(*) FROM patients WHERE`Gender`='male'");
        }
        // to get the female patients count
        public string femalepatients()
        {
            return exeCount("SELECT COUNT(*) FROM patients WHERE`Gender`='female'");

        }
        //create a function search for patients (first name, last name, address)
        public DataTable searchPatients(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `patients` WHERE CONCAT(`PtFirstName`,`PtLastNmame`,`Address`) LIKE '%" + searchdata + "%'", connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //create a function edit for patients
        public bool UpdatePatients(int id, string fname, string lname, DateTime bdate, string gender, string contactnumber, string address, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `patients` SET `PtFirstName`=@fn,`PtLastNmame`=@ln,`BirthDate`=@bd,`Gender`=@gd,`ContactNumber`=@cn,`Address`=@adr,`Photo`=@img WHERE `PTId`=@id; ", connect.GetConnection);

            //@id, @fn, @ln, @bd, @gd, @ph, @adr, @img
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = contactnumber;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

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
        //Create a function to delete data
        //we need only id 
        public bool deletePatients(int id)
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
        //create a function for any command in patientdata
        public DataTable getList(MySqlCommand command)
        {
            
            command.Connection = connect.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}


    
    

