using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sunny.UI.Demo.Model
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public Flight flight { get; set; }
        public int PriceVnd { get; set; }
        public float PriceUsd { get; set; }
        public string SeatNumber { get; set; }
        public TicketClass ticketClass { get; set; }

        public Ticket(int ticketId, Flight flight, int priceVnd, float priceUsd, string seatNumber, TicketClass ticketClass)
        {
            TicketId = ticketId;
            this.flight = flight;
            PriceVnd = priceVnd;
            PriceUsd = priceUsd;
            SeatNumber = seatNumber;
            this.ticketClass = ticketClass;
        }

        public Ticket()
        {
        }
    }
}
