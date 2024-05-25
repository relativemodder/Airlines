using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Airlines.Services
{
    public class DatabaseState
    {
        private static DatabaseState? _instance;
        private MySqlConnection? _mySqlConnection;

        public static DatabaseState GetDatabaseState() // I love Singleton
        {
            if (_instance == null)
            {
                _instance = new DatabaseState();
            }

            return _instance;
        }

        public MySqlConnection GetConnection()
        {
            // if (_mySqlConnection != null)
            // {
            //     return _mySqlConnection;
            // }

            string server = Environment.GetEnvironmentVariable("AIRLINES_DATABASE_SERVER") ?? "localhost";
            string username = Environment.GetEnvironmentVariable("AIRLINES_DATABASE_USERNAME") ?? "root";
            string password = Environment.GetEnvironmentVariable("AIRLINES_DATABASE_PASSWORD") ?? "";
            string databaseName = Environment.GetEnvironmentVariable("AIRLINES_DATABASE_NAME") ?? "airlines";

            string myConnectionString = $"server={server};uid={username};pwd={password};database={databaseName}";

            var mySqlConnection = new MySqlConnection();
            mySqlConnection.ConnectionString = myConnectionString;
            mySqlConnection.Open();

            return mySqlConnection;
        }
    }
}
