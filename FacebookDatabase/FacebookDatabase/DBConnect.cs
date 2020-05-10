using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookDatabase
{
    class DBConnect
    {
        //MySqlConnection connectionstring = new MySqlConnection("");

        //public void OpenConnection()
        //{
        //    connectionstring.Open();
        //}

        //public void CloseConnection()
        //{
        //    connectionstring.Close();
        //}

        //public DataTable ReadValue()
        //{
        //    DataTable table = new DataTable();
        //    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM details", connectionstring);

        //    adapter.Fill(table);
        //    return table;
        //}


        internal const string USER_NAME = "ISAD157_LHumphries";
        internal const string SERVER = "proj-mysql.uopnet.plymouth.ac.uk";
        internal const string DATABASE_NAME = "isad157_lhumphries";
        internal const string PASSWORD = "ISAD157_22222199";
        internal const string SslMode = "none";
    }
}
