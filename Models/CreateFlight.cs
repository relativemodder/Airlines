using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Models
{
    public class CreateFlight
    {
        public required string Departure { get; set; }
        public required string Destination { get; set; }
        public required int Passengers { get; set; }
        public required int PlaneId { get; set; }
        public required int SuggestedTimestamp { get; set; }
    }
}
