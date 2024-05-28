namespace Airlines.Models
{
    public class SalesAnalysis
    {
        public required int AllFlightsCount { get; set; }
        public required float RevenueOfAllShips { get; set; }
        public required float AverageShipCost { get; set; }
        public required int UsersCount { get; set; }
        public required int AverageFlightCountPerClient { get; set; }
    }
}
