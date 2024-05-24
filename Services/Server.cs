using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Services
{
    public class Server
    {
        private static Server _instance;

        public static Server GetServer()
        {
            if (_instance == null)
            {
                _instance = new Server();
            }

            return _instance;
        }


    }
}
