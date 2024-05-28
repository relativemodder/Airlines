using Airlines.Models;

namespace Airlines.Services.ServerServices
{
    public class Loads
    {
        public Load GetLoad(int loadID)
        {
            var connection = DatabaseState.GetDatabaseState().GetConnection();
            var command = connection.CreateCommand();
            command.CommandText = "SELECT `id`, `flight_id`, `weight`, " +
                "`description`, `customer_user_id`, `price` " +
                "FROM `load` WHERE `id` = @id";
            command.Parameters.AddWithValue("@id", loadID);

            var reader = command.ExecuteReader();

            reader.Read();

            int flightID = reader.GetInt32("flight_id");
            int weight = reader.GetInt32("weight");
            string description = reader.GetString("description");
            int customerUserID = reader.GetInt32("customer_user_id");
            float price = reader.GetFloat("price");

            reader.Close();
            connection.Close();

            var flight = Server.GetServer().GetFlight(flightID);
            var customer = Server.GetServer().GetUser(customerUserID);

            return new Load()
            {
                Id = loadID,
                Weight = weight,
                Description = description,
                Customer = customer,
                Flight = flight,
                Price = price
            };
        }

        public List<Load> GetLoads()
        {
            var connection = DatabaseState.GetDatabaseState().GetConnection();
            var command = connection.CreateCommand();
            command.CommandText = "SELECT `id` FROM `load`";

            var reader = command.ExecuteReader();

            List<Load> loads = new List<Load>();
            List<int> loadIDs = new List<int>();

            while (reader.Read())
            {
                int loadID = reader.GetInt32("id");
                loadIDs.Add(loadID);
            }

            reader.Close();
            connection.Close();

            foreach (var loadID in loadIDs)
            {
                loads.Add(GetLoad(loadID));
            }

            return loads;
        }
    }
}
