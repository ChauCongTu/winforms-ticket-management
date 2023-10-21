using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sunny.UI.Demo.Model
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public string BookingCode { get; set; }
        public int TicketId { get; set; }
        public Customer Customer { get; set; }
        public string Note { get; set; }
        public DateTime? BookingDate { get; set; }
        public User Performed { get; set; }


        public Transaction(int transactionId, string bookingCode, int ticketId, Customer customer, string note, DateTime? bookingDate, User performed)
        {
            TransactionId = transactionId;
            BookingCode = bookingCode;
            TicketId = ticketId;
            Customer = customer;
            Note = note;
            BookingDate = bookingDate;
            Performed = performed;
        }

        public Transaction()
        {
        }
    }
}
