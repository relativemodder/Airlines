namespace Airlines.Models
{
    public class UserComboBoxElement : User
    {
        public override string ToString()
        {
            return $"Пользователь №{Id} - {Surname} {Name} {Middlename} - {Role}";
        }
    }
}
