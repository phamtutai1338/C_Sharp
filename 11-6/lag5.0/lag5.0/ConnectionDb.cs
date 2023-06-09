using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lag5._0
{
      public  class ConnectionDb
    {
        public  SqlConnection GetConnection()
        {

            string connectionString = "Data source = localhost; " + " Initial Catalog = msdb ; Integrated Seurity = SSPI";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }
    }
}
