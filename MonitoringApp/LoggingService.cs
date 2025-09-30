using System;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace MonitoringApp
{
    public class LoggingService
    {
        private readonly string _connectionString;
        public LoggingService(string connectionString) => _connectionString = connectionString;

        public async Task<int> LogAsync(string userName, string action, string severity, string message)
        {
            using var conn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("dbo.AddLog", conn) { CommandType = CommandType.StoredProcedure };

            cmd.Parameters.AddWithValue("@UserName", (object)userName ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Action", (object)action ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Severity", severity);
            cmd.Parameters.AddWithValue("@Message", (object)message ?? DBNull.Value);

            await conn.OpenAsync();
            var result = await cmd.ExecuteScalarAsync();
            return Convert.ToInt32(result);
        }
    }
}
