
using System.Configuration;
using System.Data.SqlClient;

namespace DataService.ModelServices
{
    public class DbFactory
    {
        private static string _connectionString = string.Empty;

        private static int _commandTimeout = 30;

        public static string GetConnectionString()
        {
            if (string.IsNullOrWhiteSpace(_connectionString))
                _connectionString = ConfigurationManager.ConnectionStrings["EquisApp"].ConnectionString;

            return _connectionString;
        }

        public static int CommandTimeout
        {
            get
            {
                try
                {
                    return int.Parse(ConfigurationManager.AppSettings["CommandTimeoutForDb"]);
                }
                catch
                {
                    return _commandTimeout;
                }
            }
        }

        public static SqlConnection CreateConnection()
        {
            return new SqlConnection(GetConnectionString());
        }
    }
}
