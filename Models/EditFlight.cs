namespace Airlines.Models
{
    public class EditFlight
    {
        public required int Id { get; set; }
        public required int DepartureTimestamp { get; set; }
        public required int DestinationTimestamp { get; set; }
    }
}
