namespace Airlines.Models
{
    public class PlaneComboBoxElement : Plane
    {
        public override string ToString()
        {
            return $"Самолёт №{Id} - {Model}";
        }
    }
}
