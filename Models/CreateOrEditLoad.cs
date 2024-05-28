namespace Airlines.Models
{
    public class CreateOrEditLoad
    {
        public int Id { get; set; }
        public required int FlightId { get; set; }
        public required int Weight { get; set; }
        public required string Description { get; set; }
        public required int CustomerUserId { get; set; }
        public required float Price { get; set; }
    }
}
