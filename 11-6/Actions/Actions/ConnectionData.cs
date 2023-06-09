using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Actions
{
    class ConnectionData
    {
        public SqlConnection GetDatabase()
        {
            string connectionString = "Data source = localhost; Initial Catalog = Dbtest ; Integrated security = SSPI";
            SqlConnection connect = new SqlConnection(connectionString);
            //Console.WriteLine("connection failed !");
            return connect;
        }
    }
}
