using MySql.Data.MySqlClient;

namespace Airlines.Services
{
    public class DatabaseState
    {
        private static DatabaseState? _instance;
        private MySqlConnection? _mySqlConnection;

        private string _server = Environment.GetEnvironmentVariable("AIRLINES_DATABASE_SERVER") ?? "localhost";
        private string _username = Environment.GetEnvironmentVariable("AIRLINES_DATABASE_USERNAME") ?? "root";
        private string _password = Environment.GetEnvironmentVariable("AIRLINES_DATABASE_PASSWORD") ?? "";
        private string _databaseName = Environment.GetEnvironmentVariable("AIRLINES_DATABASE_NAME") ?? "airlines";

        public static DatabaseState GetDatabaseState() // I love Singleton
        {
            if (_instance == null)
            {
                _instance = new DatabaseState();
            }

            return _instance;
        }

        public string GetHost()
        {
            return _server;
        }

        public MySqlConnection GetConnection()
        {
            // if (_mySqlConnection != null)
            // {
            //     return _mySqlConnection;
            // }

            string myConnectionString = $"server={_server};uid={_username};pwd={_password};database={_databaseName}";

            var mySqlConnection = new MySqlConnection();
            mySqlConnection.ConnectionString = myConnectionString;
            mySqlConnection.Open();

            return mySqlConnection;
        }
    }
}
