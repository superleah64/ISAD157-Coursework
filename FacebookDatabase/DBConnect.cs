/////////////////////////////////////////////////////////////////////////////////
//
//         FileName : DBConnect.cs
//           Author : Marco A. Palomino
//
//      Description : A class to introduce some basic principles for connecting
//                    to a MySQL database using C#. The solution employs the
//                    MySQL Connector/NET 8.0.
//
/////////////////////////////////////////////////////////////////////////////////

using System;
using MySql.Data.MySqlClient;

namespace SOFT562Week18
{
    class DBConnect
    {
        internal const string USER_NAME = "ISAD157_LHumphries";
        internal const string SERVER = "proj-mysql.uopnet.plymouth.ac.uk";
        internal const string DATABASE_NAME = "isad157_lhumphries";
        internal const string PASSWORD = "ISAD157_22222199";
        internal const string SslMode = "none";

    } // End of class DBConnect
}
