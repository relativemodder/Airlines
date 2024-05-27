using Airlines.Services.ServerServices;

namespace Airlines.Services
{
    public class Server : Users
    {
        private static Server? _instance;

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
