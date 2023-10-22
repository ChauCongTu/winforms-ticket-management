using Sunny.UI.Demo.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sunny.UI.Demo.DAO
{
    public class DAO_Ticket : DBConnection
    {
        SqlConnection _conn;
        private SqlCommand command;
        private SqlDataReader reader;

        public DAO_Ticket()
        {
            _conn = new SqlConnection(_strConn);
        }

        public List<Ticket> getAll()
        {
            List<Ticket> ticketList = new List<Ticket>();
            _conn.Open();

            try
            {
                command = new SqlCommand($"SELECT t.*, c.class_type FROM tickets t JOIN ticket_classes c ON t.ticket_class = c.class_id", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError();
                return ticketList;
            }

            while (reader.Read())
            {
                int ticketId = reader.GetInt32(0);
                int flightId = reader.GetInt32(1);
                int classId = reader.GetInt32(2);
                int priceVnd = reader.GetInt32(3);
                float priceUsd = reader.GetFloat(4);
                string seatNumber = reader.GetString(5);
                string ticketClass = reader.GetString(6);

                Ticket ticket = new Ticket(ticketId, flightId, priceVnd, priceUsd, seatNumber, ticketClass, classId);
                ticketList.Add(ticket);
            }

            _conn.Close();
            return ticketList;
        }

        public Ticket getById(int id)
        {
            Ticket ticket = new Ticket();
            _conn.Open();

            try
            {
                command = new SqlCommand($"SELECT t.*, c.class_type FROM tickets t JOIN ticket_classes c ON t.ticket_class = c.class_id WHERE ticket_id = {id}", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError();
                return ticket;
            }

            while (reader.Read())
            {
                int ticketId = reader.GetInt32(0);
                int flightId = reader.GetInt32(1);
                int classId = reader.GetInt32(2);
                int priceVnd = reader.GetInt32(3);
                float priceUsd = reader.GetFloat(4);
                string seatNumber = reader.GetString(5);
                string ticketClass = reader.GetString(6);

                ticket = new Ticket(ticketId, flightId, priceVnd, priceUsd, seatNumber, ticketClass, classId);
            }

            _conn.Close();
            return ticket;
        }

        public void add(Ticket ticket)
        {
            _conn.Open();
            command = new SqlCommand($"INSERT INTO tickets (flight_id, ticket_class, price_vnd, seat_numb) " +
                $"VALUES ({ticket.FlightId}, {ticket.ClassId}, {ticket.PriceVnd}, N'{ticket.SeatNumber}')", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void update(Ticket ticket)
        {
            _conn.Open();
            command = new SqlCommand($"UPDATE tickets SET " +
                $"flight_id = {ticket.FlightId}, " +
                $"ticket_class = {ticket.ClassId}, " +
                $"price_vnd = {ticket.PriceVnd}, " +
                $"seat_numb = N'{ticket.SeatNumber}' " +
                $"WHERE ticket_id = {ticket.TicketId}", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void delete(int id)
        {
            _conn.Open();
            command = new SqlCommand($"DELETE FROM tickets WHERE ticket_id = {id}", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
