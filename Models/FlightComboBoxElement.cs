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


            DateTimeOffset departureTime = DateTimeOffset.FromUnixTimeSeconds(DepartureTimestamp);
            DateTimeOffset destinationTime = DateTimeOffset.FromUnixTimeSeconds(DestinationTimestamp);
            string formattedDepartureTime = departureTime.ToString("dd.MM.yy H:mm");
            string formattedDestinationTime = destinationTime.ToString("dd.MM.yy H:mm");

            return $"№{Id} - {Departure}-{Destination} " +
                $"- {Passengers} пас. " +
                $"- самолёт {Plane.Model} (№{Plane.Id}) " +
                $"- {statusString} " +
                (
                    Status == FlightStatus.VERIFIED
                    ? $"- отправление в {formattedDepartureTime} (GMT)" +
                    $"- прибытие в {formattedDepartureTime}  (GMT)"
                    : ""
                )
                ;
        }
    }
}
