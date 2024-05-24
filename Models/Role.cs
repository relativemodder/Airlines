namespace Airlines.Models
{
    public class Role
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required RoleLevel Level { get; set; }
    }
}
