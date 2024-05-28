namespace Airlines.Models
{
    public class Role
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required RoleLevel Level { get; set; }
        public override string ToString()
        {
            Dictionary<RoleLevel, string> roleNames = new Dictionary<RoleLevel, string>()
            {
                [RoleLevel.PASSENGER] = "Пассажир",
                [RoleLevel.EXPEDITOR] = "Экспедитор",
                [RoleLevel.FLIGHT_OPERATOR] = "Диспетчер",
                [RoleLevel.STAFF] = "Руководитель"
            };

            return roleNames[Level];
        }
    }
}
