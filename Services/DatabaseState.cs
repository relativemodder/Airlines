using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Services
{
    public class DatabaseState
    {
        private static DatabaseState? _instance;

        public static DatabaseState GetDatabaseState() // I love Singleton
        {
            if (_instance == null)
            {
                _instance = new DatabaseState();
            }

            return _instance;
        }


    }
}
