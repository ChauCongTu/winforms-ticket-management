using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sunny.UI.Demo.Model
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string DeparturePoint { get; set; }
        public string Destination { get; set; }
        public Airport DepartureAirport { get; set; }
        public Airport DestinationAirport { get; set; }
        public DateTime? DepartureTime { get; set; }
        public DateTime? ArrivalTime { get; set; }
        public DateTime? FlightDate { get; set; }
        public int TotalTickets { get; set; }
        public int RemainingTickets { get; set; }
        public int Transits { get; set; }
        public Airplane Airplane { get; set; }
        public string Status { get; set; }

        public Flight()
        {
        }

        public Flight(int flightId, string departurePoint, string destination, Airport departureAirport, Airport destinationAirport, DateTime? departureTime, DateTime? arrivalTime, DateTime? flightDate, int totalTickets, int remainingTickets, int transits, Airplane airplane, string status)
        {
            FlightId = flightId;
            DeparturePoint = departurePoint;
            Destination = destination;
            DepartureAirport = departureAirport;
            DestinationAirport = destinationAirport;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            FlightDate = flightDate;
            TotalTickets = totalTickets;
            RemainingTickets = remainingTickets;
            Transits = transits;
            Airplane = airplane;
            Status = status;
        }
    }
}
