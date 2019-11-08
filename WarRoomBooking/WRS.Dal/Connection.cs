using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WRS.Dal
{
    public class ConnectionFactory
    {
        public static SqlConnection createConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBSM"].ConnectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                throw new Exception("Server database is inaccessible.", ex);
            }
        }
    }
}
