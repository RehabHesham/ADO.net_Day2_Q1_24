using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.DataAccess
{
    public class DbContext
    {
        SqlConnection connection;
        public DbContext() { 
        connection = new SqlConnection("Server=.;Database=ITI;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        // Disconnected mode with select
        public DataTable GetData(string command)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = new SqlCommand(command, connection);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            return dataTable;
        }




        // connected mode with insert, update, delete
        public int ExecuteNonQuery(string command,SqlParameter[] parameters)
        {
            SqlCommand sqlCommand = new SqlCommand(command, connection);
            sqlCommand.Parameters.AddRange(parameters);

            connection.Open();
            int rowsAffected = sqlCommand.ExecuteNonQuery();
            connection.Close();


            return rowsAffected;
        }



    }
}
