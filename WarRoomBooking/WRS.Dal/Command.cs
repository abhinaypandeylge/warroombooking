using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WRS.Dal
{
    public class CommandFactory
    {
        public SqlCommand createCommand()
        {
            SqlConnection con = ConnectionFactory.createConnection();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 2147483;
            return cmd;
        }
    }
}
