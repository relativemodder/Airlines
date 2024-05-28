using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airlines.Models;

namespace Airlines.Services
{
    public class Client
    {
        private static Client? _instance;

        public static Client GetClient()
        {
            if (_instance == null)
            {
                _instance = new Client();
            }

            return _instance;
        }

        public User Login(string username, string password)
        {
            return Server.GetServer().Login(username, password);
        }

        public User Register(CreateUser createUser)
        {
            return Server.GetServer().CreateUser(createUser);
        }

        public List<Flight> GetFlights()
        {
            return Server.GetServer().GetFlights();
        }

        public List<Flight> GetVerifiedFlights()
        {
            return Server.GetServer().GetFlights(verified: true);
        }

        public Flight CreateFlight(CreateFlight flight)
        {
            return Server.GetServer().CreateFlight(flight);
        }

        public List<Plane> GetPlanes()
        {
            return Server.GetServer().GetPlanes();
        }

        public List<Load> GetLoads()
        {
            return Server.GetServer().GetLoads();
        }
    }
}
