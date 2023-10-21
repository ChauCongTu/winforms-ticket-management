using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sunny.UI.Demo.Model
{
    public class Transit
    {
        public Transit()
        {
        }

        public int TransitId { get; set; }
        public Airport TransitAirport { get; set; }
        public Flight Flight { get; set; }

        public Transit(int transitId, Airport transitAirport, Flight flight)
        {
            TransitId = transitId;
            TransitAirport = transitAirport;
            Flight = flight;
        }
    }
}
