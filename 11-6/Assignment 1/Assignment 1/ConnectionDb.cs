using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace product
{
    public class ConnectionDb
    {
        public SqlConnection GetConnection()
        {

            string connectionString = "Data source = localhost; Initial Catalog = Dbtest ; Integrated security = SSPI";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }
    }
}