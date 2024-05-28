using Airlines.Models;

namespace Airlines.Services.ServerServices
{
    public class Admins
    {
        public SalesAnalysis GetSalesAnalysis()
        {
            var connection = DatabaseState.GetDatabaseState().GetConnection();

            var command = connection.CreateCommand();
            command.CommandText = "SELECT COUNT(*) AS `count` FROM `flight` WHERE `destination_timestamp` > 0";
            var reader = command.ExecuteReader();
            reader.Read();
            int flightCount = reader.GetInt32("count");
            reader.Close();

            var command1 = connection.CreateCommand();
            command1.CommandText = "SELECT SUM(`price`) AS `revenue` FROM `load`";
            var reader1 = command1.ExecuteReader();
            reader1.Read();
            float revenue = reader1.GetFloat("revenue");
            reader1.Close();

            var command2 = connection.CreateCommand();
            command2.CommandText = "SELECT SUM(`price`) / COUNT(*) AS `average_ship_cost` FROM `load`";
            var reader2 = command2.ExecuteReader();
            reader2.Read();
            float averageShipCost = reader2.GetFloat("average_ship_cost");
            reader2.Close();

            var command3 = connection.CreateCommand();
            command3.CommandText = "SELECT COUNT(*) AS `count` FROM `user` WHERE `role_id` = 1";
            var reader3 = command3.ExecuteReader();
            reader3.Read();
            int usersCount = reader3.GetInt32("count");
            reader3.Close();


            connection.Close();

            return new SalesAnalysis()
            {
                AllFlightsCount = flightCount,
                AverageFlightCountPerClient = flightCount / usersCount,
                UsersCount = usersCount,
                AverageShipCost = averageShipCost,
                RevenueOfAllShips = revenue
            };
        }
    }
}
