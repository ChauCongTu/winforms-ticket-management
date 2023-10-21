using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sunny.UI.Demo.Model
{
    public class Airplane
    {
        public int AirplaneId { get; set; }
        public string AirplaneType { get; set; }
        public string Description { get; set; }
        public string AirplaneNumber { get; set; }
        public int NumberOfSeats { get; set; }

        public Airplane()
        {
        }

        public Airplane(int airplaneId, string airplaneType, string description, string airplaneNumber, int numberOfSeats)
        {
            AirplaneId = airplaneId;
            AirplaneType = airplaneType;
            Description = description;
            AirplaneNumber = airplaneNumber;
            NumberOfSeats = numberOfSeats;
        }
    }
}
