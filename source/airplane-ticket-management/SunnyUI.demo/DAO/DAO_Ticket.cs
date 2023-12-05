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
                command = new SqlCommand($"SELECT t.*, c.class_type FROM tickets t JOIN ticket_classes c ON t.ticket_class = c.class_id ORDER BY ticket_class", _conn);
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
                float priceUsd = (float)reader.GetDouble(4);
                string seatNumber = reader.GetString(5);
                string ticketClass = reader.GetString(6);

                Ticket ticket = new Ticket(ticketId, flightId, priceVnd, priceUsd, seatNumber, ticketClass, classId);
                ticketList.Add(ticket);
            }

            _conn.Close();
            return ticketList;
        }

        public List<Ticket> getByFlightClass(int inputClassId, int inputFlightId)
        {
            List<Ticket> ticketList = new List<Ticket>();
            _conn.Open();

            try
            {
                command = new SqlCommand($"SELECT t.*, c.class_type FROM tickets t JOIN ticket_classes c ON t.ticket_class = c.class_id LEFT JOIN transactions s ON t.ticket_id = s.ticket_id WHERE flight_id = {inputFlightId} AND ticket_class = {inputClassId} AND s.ticket_id IS NULL", _conn);
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
                float priceUsd = (float)reader.GetDouble(4);
                string seatNumber = reader.GetString(5);
                string ticketClass = reader.GetString(6);

                Ticket ticket = new Ticket(ticketId, flightId, priceVnd, priceUsd, seatNumber, ticketClass, classId);
                ticketList.Add(ticket);
            }

            _conn.Close();
            return ticketList;
        }

        public List<Ticket> getTicketOfFlight(int flight_id)
        {
            List<Ticket> ticketList = new List<Ticket>();
            _conn.Open();

            try
            {
                command = new SqlCommand($"SELECT t.*, c.class_type FROM tickets t JOIN ticket_classes c ON t.ticket_class = c.class_id WHERE flight_id = {flight_id} ORDER BY ticket_class", _conn);
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
                float priceUsd = (float)reader.GetDouble(4);
                string seatNumber = reader.GetString(5);
                string ticketClass = reader.GetString(6);

                Ticket ticket = new Ticket(ticketId, flightId, priceVnd, priceUsd, seatNumber, ticketClass, classId);
                ticketList.Add(ticket);
            }

            _conn.Close();
            return ticketList;
        }

        public List<Ticket> getByClass(int flight_id, int ticket_class)
        {
            List<Ticket> ticketList = new List<Ticket>();
            _conn.Open();

            try
            {
                command = new SqlCommand($"SELECT t.*, c.class_type FROM tickets t JOIN ticket_classes c ON t.ticket_class = c.class_id WHERE flight_id = {flight_id} AND ticket_class = {ticket_class}", _conn);
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
                float priceUsd = (float)reader.GetDouble(4);
                string seatNumber = reader.GetString(5);
                string ticketClass = reader.GetString(6);

                Ticket ticket = new Ticket(ticketId, flightId, priceVnd, priceUsd, seatNumber, ticketClass, classId);
                ticketList.Add(ticket);
            }

            _conn.Close();
            return ticketList;
        }

        public List<Ticket> getByStatus(int flight_id, int isSold)
        {
            List<Ticket> ticketList = new List<Ticket>();
            _conn.Open();

            try
            {
                if (isSold == 1)
                {
                    command = new SqlCommand($"SELECT t.*, c.class_type FROM tickets t JOIN ticket_classes c ON t.ticket_class = c.class_id JOIN transactions s ON t.ticket_id = s.ticket_id WHERE flight_id = {flight_id} ORDER BY ticket_class", _conn);
                }
                else
                {
                    command = new SqlCommand($"SELECT t.*, c.class_type FROM tickets t JOIN ticket_classes c ON t.ticket_class = c.class_id LEFT JOIN transactions s ON t.ticket_id = s.ticket_id WHERE flight_id = {flight_id} AND s.ticket_id IS NULL ORDER BY ticket_class", _conn);
                }
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
                float priceUsd = (float)reader.GetDouble(4);
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
                float priceUsd = (float)reader.GetDouble(4);
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

        public bool isSold(int ticketId)
        {
            int hasRow = 0;
            _conn.Open();
            try
            {
                command = new SqlCommand($"select count(tk.flight_id) as num from tickets tk join transactions ts on tk.ticket_id = ts.ticket_id where tk.ticket_id = {ticketId}", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError();
                return false;
            }

            while (reader.Read())
            {
                hasRow = reader.GetInt32(0);
            }
            _conn.Close();
            if (hasRow != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getTotalTicket(int flightid)
        {
            int hasRow = 0;
            _conn.Open();
            try
            {
                command = new SqlCommand($"SELECT count(ticket_id) as numb FROM tickets WHERE flight_id = {flightid}", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError();
                return 0;
            }

            while (reader.Read())
            {
                hasRow = reader.GetInt32(0);
            }
            _conn.Close();
            return hasRow;
        }
        public int getPriceByPlane(int plane_id)
        {
            int hasRow = 0;
            _conn.Open();
            try
            {
                command = new SqlCommand($"SELECT MIN(t.price_vnd) FROM airplanes a JOIN flights f ON a.airplane_id = f.aircraft_id JOIN tickets t ON f.flight_id = t.flight_id WHERE a.airplane_id = {plane_id}", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError();
                return 0;
            }

            while (reader.Read())
            {
                // Kiểm tra xem giá trị có phải là null hay không
                if (!reader.IsDBNull(0))
                {
                    hasRow = reader.GetInt32(0);
                }
                // Nếu giá trị là null, đặt hasRow thành 0
                else
                {
                    hasRow = 0;
                }
            }

            _conn.Close();
            return hasRow;
        }


        public int getRemainTicket(int flightid)
        {
            int hasRow = 0;
            _conn.Open();
            try
            {
                command = new SqlCommand($"SELECT count(*) FROM tickets t LEFT JOIN transactions s ON t.ticket_id = s.ticket_id WHERE flight_id = {flightid} AND transaction_id is null", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError();
                return 0;
            }

            while (reader.Read())
            {
                hasRow = reader.GetInt32(0);
            }
            _conn.Close();
            return hasRow;
        }

        public bool checkLower9(string id_number, int Flight_id)
        {
            int customer_id = new DAO_Customer().getByCustomerID(id_number).CustomerId;
            int hasRow = 0;
            _conn.Open();
            try
            {
                command = new SqlCommand($"SELECT count(s.customer_id) as num " +
                    $"FROM tickets t JOIN transactions s ON t.ticket_id = s.ticket_id JOIN flights f ON t.flight_id = f.flight_id " +
                    $"WHERE s.customer_id = {customer_id} AND f.flight_id = {Flight_id}", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError(e.Message);
                return false;
            }

            while (reader.Read())
            {
                hasRow = reader.GetInt32(0);
            }
            _conn.Close();
            if (hasRow <= 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
