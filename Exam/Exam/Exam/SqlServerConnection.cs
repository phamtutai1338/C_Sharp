﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Exam
{
    class SqlServerConnection
    {
        public SqlConnection getData()
        {
            string connectionString = "Data source = localhost ; Initial Catalog = Dbtest ;Integrated security = SSPI";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
