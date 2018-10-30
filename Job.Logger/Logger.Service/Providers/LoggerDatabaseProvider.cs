using System;
using System.Configuration;
using System.Data.SqlClient;
using Job.Logger.Service.Entities;

namespace Job.Logger.Service.Providers
{
    public class LoggerDatabaseProvider: ILoggerProvider
    {
        readonly string connectionString;

        public LoggerDatabaseProvider()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["joblogger"].ConnectionString;
        }

        public void WriteMessage(LoggerEntity loggerEntity)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                string commandText = "INSERT INTO Logger (message, type) VALUES (@message, @type)";
                SqlCommand cmd = new SqlCommand(commandText, connection);
                cmd.Parameters.AddWithValue("@message", loggerEntity.text);
                cmd.Parameters.AddWithValue("@type", loggerEntity.type);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
