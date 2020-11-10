using NLog;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

namespace Task_DelLine.BDSQLServer
{
    class DBUtils
    {
        private static readonly Logger log = LogManager.GetCurrentClassLogger();
        /// <summary>
        /// parameters for connecting to database
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"COMPUTER\SQLEXPRESS";

            string database = "CarService";
            //string username = "";
            //string password = "";

            return DBSQLServerUtils.GetDBConnection(datasource, database);
        }
        /// <summary>
        /// Task for async request to database
        /// </summary>
        /// <param name="command">SQL query</param>
        /// <param name="con">Sql connection</param>
        /// <param name="name">table name</param>
        /// <returns>DataSet</returns>
        public static Task<DataSet> GetDataSetAsync(string command, SqlConnection con, string name)
        {
            log.Debug("GetDataSetAsync starting...");
            DataSet ds = new DataSet();
            return Task<DataSet>.Factory.StartNew(() =>
            {
                try
                {
                    log.Trace($"SQL request:{command}, table name:{name}");
                    SqlDataAdapter da = new SqlDataAdapter(command, con);
                    int ans = da.Fill(ds, name);
                    log.Debug($"SQL request complete. Recorded {ans} lines:");
                }
                catch(Exception ex)
                {
                    log.Error($"Error from GetDataAsync: {ex.Message}");
                }
                log.Trace($"Thread: {Thread.CurrentThread.Name}");

                return ds;
            });

        }
    }
}
