using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sunny.UI.Demo.Model
{
    public class Airport
    {
        public int AirportId { get; set; }
        public string AirportName { get; set; }
        public string Coordinates { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public Airport()
        {
        }

        public Airport(int airportId, string airportName, string coordinates, string address, string city, string country)
        {
            AirportId = airportId;
            AirportName = airportName;
            Coordinates = coordinates;
            Address = address;
            City = city;
            Country = country;
        }
    }
}
