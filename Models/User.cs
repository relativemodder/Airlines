namespace Airlines.Models
{
    public class User
    {
        public required int Id { get; set; }
        public required string Username { get; set; }
        public required string PasswordHash { get; set; }
        public required Role Role { get; set; }
        public required string Surname { get; set; }
        public required string Name { get; set; }
        public required string Middlename { get; set; }
    }
}
