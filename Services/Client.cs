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

        public List<User> GetUsers()
        {
            return Server.GetServer().GetUsers();
        }

        public List<Flight> GetFlights()
        {
            return Server.GetServer().GetFlights();
        }

        public Flight GetFlight(int flightID)
        {
            return Server.GetServer().GetFlight(flightID);
        }

        public void DeleteFlight(int flightID)
        {
            Server.GetServer().DeleteFlight(flightID);
        }

        public List<Flight> GetVerifiedFlights()
        {
            return Server.GetServer().GetFlights(verified: true);
        }

        public Flight CreateFlight(CreateFlight flight)
        {
            return Server.GetServer().CreateFlight(flight);
        }

        public Flight EditFlight(EditFlight flight)
        {
            return Server.GetServer().EditFlight(flight);
        }

        public List<Plane> GetPlanes()
        {
            return Server.GetServer().GetPlanes();
        }

        public List<Load> GetLoads()
        {
            return Server.GetServer().GetLoads();
        }

        public Load GetLoad(int loadID)
        {
            return Server.GetServer().GetLoad(loadID);
        }

        public Load CreateOrEditLoad(CreateOrEditLoad load)
        {
            return Server.GetServer().CreateOrEditLoad(load);
        }

        public void DeleteLoad(int loadID)
        {
            Server.GetServer().DeleteLoad(loadID);
        }

        public SalesAnalysis GetSalesAnalysis()
        {
            return Server.GetServer().GetSalesAnalysis();
        }
    }
}
