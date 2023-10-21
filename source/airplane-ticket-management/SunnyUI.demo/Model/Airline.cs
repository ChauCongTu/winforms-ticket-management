using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sunny.UI.Demo.Model
{
    public class Airline
    {
        public int AirlineId { get; set; }
        public string AirlineName { get; set; }
        public int numbOfPlane { get; set; }

        public Airline()
        {
        }

        public Airline(int airlineId, string airlineName, int numbOfPlane)
        {
            AirlineId = airlineId;
            AirlineName = airlineName;
            this.numbOfPlane = numbOfPlane;
        }
    }
}
