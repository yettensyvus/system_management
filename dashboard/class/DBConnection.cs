using System;
using System.Data;
using System.Data.SqlClient;

namespace dashboard.Class
{
    class DBConnection
    {
        public SqlConnection connection;

        public SqlConnection ConnectionOpen()
        {
            connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = management_system; Integrated Security = True");

            if(connection.State==ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
            {
                connection.Open();
            }
            return connection;
        }

        public void ConnectionClose()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
            }
        }
    }
}
