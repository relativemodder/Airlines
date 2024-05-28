namespace Airlines.Models
{
    public class LoadComboBoxElement : Load
    {
        public override string ToString()
        {
            return $"№{Id} - рейс №{Flight.Id} - {Weight} кг у {Customer.Surname} {Customer.Name} {Customer.Middlename}";
        }
    }
}
