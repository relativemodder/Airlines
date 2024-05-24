namespace Airlines.Models
{
    public class Flight
    {
        public required int Id { get; set; }
        public required string Departure { get; set; }
        public required string Destination { get; set; }
        public required int Passengers { get; set; }
        public required Plane Plane { get; set; }
        public required int SuggestedTimestamp { get; set; }
        public required int DepartureTimestamp { get; set; }
        public required int DestinationTimestamp { get; set; }
    }
}
