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
    public class TransactionResponse
    {
        public string BookingCode { get; set; }
        public DateTime BookingDate { get; set; }
        public Ticket Ticket { get; set; }
        public Flight flight { get; set; }
        public Customer customer { get; set; }
        public string note { get; set; }
        public User Performed { get; set; }

        public TransactionResponse() { }
        public TransactionResponse(Transaction transaction)
        {
            BookingCode = transaction.BookingCode;
            BookingDate = transaction.BookingDate.Value;
            Ticket = new DAO.DAO_Ticket().getById(transaction.TicketId);
            this.flight = new DAO.DAO_Flight().getById(this.Ticket.FlightId);
            this.customer = transaction.Customer;
            this.note = transaction.Note;
            Performed = transaction.Performed;
        }
    }
}
