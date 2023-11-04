using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sunny.UI.Demo.Model
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public int FlightId { get; set; }
        public int PriceVnd { get; set; }
        public float PriceUsd { get; set; }
        public string SeatNumber { get; set; }
        public string ticketClass { get; set; }
        public int ClassId { get; set; }

        public Ticket(int ticketId, int flightId, int priceVnd, float priceUsd, string seatNumber, string ticketClass, int classId)
        {
            TicketId = ticketId;
            FlightId = flightId;
            PriceVnd = priceVnd;
            PriceUsd = priceUsd;
            SeatNumber = seatNumber;
            this.ticketClass = ticketClass;
            ClassId = classId;
        }

        public Ticket()
        {
        }
    }
    public class TicketShow
    {
        public int TicketId { get; set; }
        public string TicketDisplay { get; set; }

        public TicketShow() { }

        public TicketShow(Ticket ticket)
        {
            this.TicketId = ticket.TicketId;
            this.TicketDisplay = ticket.ticketClass + " Ticket #" + ticket.TicketId + " - " + Helper.FormatVietnameseCurrency(ticket.PriceVnd.ToString()) ;
        }
    }
}
