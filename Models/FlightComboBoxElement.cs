using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Models
{
    public class FlightComboBoxElement : Flight
    {
        public override string ToString()
        {
            string statusString = Status == FlightStatus.PROCESSING 
                ? "рассм." 
                : "принято";

            return $"№{Id} - {Departure}-{Destination} " +
                $"- {Passengers} пас. " +
                $"- самолёт {Plane.Model} (№{Plane.Id}) " +
                $"- {statusString}";
        }
    }
}
