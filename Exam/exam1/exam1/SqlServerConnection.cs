using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace exam1
{
    class SqlServerConnection
    {
        public SqlServerConnection getData()
        {
            string connectionString = "Data source = localhost ; Initial Catalog = Dbtest ;  Integrated security = SSPI";
            SqlServerConnection connection = new SqlServerConnection();
            return connection;
        }
    }
}