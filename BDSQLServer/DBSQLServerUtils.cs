using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_DelLine.BDSQLServer
{
    class DBSQLServerUtils
    {
        public static SqlConnection GetDBConnection(string datasource, string database, string username, string password)
        {
            //
            // Data Source=COMPUTER\\SQLEXPRESS;Initial Catalog=CarService;Integrated Security=True
            //
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }

        public static SqlConnection GetDBConnection(string datasource, string database)
        {
            //
            // Data Source=COMPUTER\\SQLEXPRESS;Initial Catalog=CarService;Integrated Security=True
            //
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }
    }
}
