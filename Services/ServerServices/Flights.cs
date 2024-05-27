using Airlines.Models;

namespace Airlines.Services.ServerServices
{
    public class Flights
    {
        public Plane GetPlane(int planeID)
        {
            var connection = DatabaseState.GetDatabaseState().GetConnection();
            var command = connection.CreateCommand();
            command.CommandText = "SELECT `id`, `model`" +
                "FROM `plane` WHERE `id` = @id";
            command.Parameters.AddWithValue("@id", planeID);

            var reader = command.ExecuteReader();

            reader.Read();

            string model = reader.GetString("model");

            reader.Close();

            return new Plane()
            {
                Id = planeID,
                Model = model
            };
        }

        public List<Plane> GetPlanes()
        {
            var connection = DatabaseState.GetDatabaseState().GetConnection();
            var command = connection.CreateCommand();
            command.CommandText = "SELECT `id` FROM `plane`";

            var reader = command.ExecuteReader();

            List<Plane> planes = new List<Plane>();
            List<int> planeIDs = new List<int>();

            while (reader.Read())
            {
                int planeID = reader.GetInt32("id");
                planeIDs.Add(planeID);
            }

            reader.Close();

            foreach (var planeID in planeIDs)
            {
                planes.Add(GetPlane(planeID));
            }

            return planes;
        }

        public Flight GetFlight(int flightID)
        {
            var connection = DatabaseState.GetDatabaseState().GetConnection();
            var command = connection.CreateCommand();
            command.CommandText = "SELECT `id`, `departure`, `destination`," +
                "`passengers`, `plane_id`, `suggested_timestamp`," +
                "`departure_timestamp`, `destination_timestamp` " +
                "FROM `flight` WHERE `id` = @id";
            command.Parameters.AddWithValue("@id", flightID);

            var reader = command.ExecuteReader();

            reader.Read();

            string departure = reader.GetString("departure");
            string destination = reader.GetString("destination");
            int passengers = reader.GetInt32("passengers");
            int planeID = reader.GetInt32("plane_id");
            int suggestedTimestamp = reader.GetInt32("suggested_timestamp");
            int departureTimestamp = reader.GetInt32("departure_timestamp");
            int destinationTimestamp = reader.GetInt32("destination_timestamp");

            reader.Close();
            connection.Close();

            return new Flight()
            {
                Id = flightID,
                Departure = departure,
                Destination = destination,
                Passengers = passengers,
                Plane = GetPlane(planeID),
                SuggestedTimestamp = suggestedTimestamp,
                DepartureTimestamp = departureTimestamp,
                DestinationTimestamp = destinationTimestamp
            };
        }

        public List<Flight> GetFlights()
        {
            var connection = DatabaseState.GetDatabaseState().GetConnection();
            var command = connection.CreateCommand();
            command.CommandText = "SELECT `id` FROM `flight`";

            var reader = command.ExecuteReader();

            List<Flight> flights = new List<Flight>();
            List<int> flightIDs = new List<int>();

            while (reader.Read())
            {
                int planeID = reader.GetInt32("id");
                flightIDs.Add(planeID);
            }

            reader.Close();

            foreach (var flightID in flightIDs)
            {
                flights.Add(GetFlight(flightID));
            }

            return flights;
        }
    }
}
