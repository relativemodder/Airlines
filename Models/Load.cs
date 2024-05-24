namespace Airlines.Models
{
    public class Load
    {
        public required int Id { get; set; }
        public required Flight Flight { get; set; }
        public required int Weight { get; set; }
        public required string Description { get; set; }
        public required User Customer { get; set; }
        public required float Price { get; set; }
    }
}
