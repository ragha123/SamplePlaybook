using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SamplePlaybook.Helpers
{
    public class LogToDatabaseHelper : ILoggingService
    {
        public void LogMessage(string message)
        {
            //Implement logging to DB
            string connectionString = "Data Source=.;Initial Catalog=SamplePlay;Integrated Security=True";
            SqlConnection connection = new SqlConnection(@connectionString);
            string query = "INSERT INTO SamplePlay (LogMessage) VALUES (@Message)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Message", message);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

