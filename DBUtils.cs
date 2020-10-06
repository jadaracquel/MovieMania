using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MovieMania
{
    public static class DBUtils
    {
        public static string GetConnStr(string name)
        {
            //Connect the name of the connection string in the "App.config" file
            string connStr = "ConfigurationManager.ConnectionStrings[" + name + "].ConnectionString";
            return connStr;
        }

        public static SqlConnection GetSqlConnection(string name)
        {
            //Connect the name of the connection string in the "App.config" file
            string connStr = GetConnStr(name);

            SqlConnection sqlConn = new SqlConnection(connStr);

            return sqlConn;
        }

    }
}
