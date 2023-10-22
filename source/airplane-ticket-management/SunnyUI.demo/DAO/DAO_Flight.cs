using Sunny.UI.Demo.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sunny.UI.Demo.DAO
{
    public class DAO_Flight : DBConnection
    {
        SqlConnection _conn;
        private SqlCommand command;
        private SqlDataReader reader;

        public DAO_Flight()
        {
            _conn = new SqlConnection(_strConn);
        }

        public List<Flight> getAll()
        {
            List<Flight> flightList = new List<Flight>();
            _conn.Open();

            try
            {
                command = new SqlCommand($"SELECT * FROM flights", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError();
                return flightList;
            }

            while (reader.Read())
            {
                int flightId = reader.GetInt32(0);
                string departurePoint = reader.GetString(1);
                string destination = reader.GetString(2);
                int departureAirportId = reader.GetInt32(3);
                int destinationAirportId = reader.GetInt32(4);
                DateTime? departureTime = null;
                if (!reader.IsDBNull(5))
                {
                    departureTime = reader.GetDateTime(5);
                }
                DateTime? arrivalTime = null;
                if (!reader.IsDBNull(6))
                {
                    arrivalTime = reader.GetDateTime(6);
                }
                DateTime? flightDate = null;
                if (!reader.IsDBNull(7))
                {
                    flightDate = reader.GetDateTime(7);
                }
                int totalTickets = reader.GetInt32(8);
                int remainingTickets = reader.GetInt32(9);
                int transits = reader.GetInt32(10);
                int airplaneId = reader.GetInt32(11);
                string status = reader.GetString(12);

                // Lấy thông tin sân bay
                DAO_Airport daoAirport = new DAO_Airport();
                Airport departureAirport = daoAirport.getById(departureAirportId);
                Airport destinationAirport = daoAirport.getById(destinationAirportId);

                // Lấy thông tin máy bay
                DAO_Airplane daoAirplane = new DAO_Airplane();
                Airplane airplane = daoAirplane.getById(airplaneId);

                Flight flight = new Flight(flightId, departurePoint, destination, departureAirport, destinationAirport, departureTime, arrivalTime, flightDate, totalTickets, remainingTickets, transits, airplane, status);
                flightList.Add(flight);
            }

            _conn.Close();
            return flightList;
        }

        public Flight getById(int id)
        {
            Flight flight = new Flight();
            _conn.Open();

            try
            {
                command = new SqlCommand($"SELECT * FROM flights WHERE flight_id = {id}", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError();
                return flight;
            }

            while (reader.Read())
            {
                int flightId = reader.GetInt32(0);
                string departurePoint = reader.GetString(1);
                string destination = reader.GetString(2);
                int departureAirportId = reader.GetInt32(3);
                int destinationAirportId = reader.GetInt32(4);
                DateTime? departureTime = null;
                if (!reader.IsDBNull(5))
                {
                    departureTime = reader.GetDateTime(5);
                }
                DateTime? arrivalTime = null;
                if (!reader.IsDBNull(6))
                {
                    arrivalTime = reader.GetDateTime(6);
                }
                DateTime? flightDate = null;
                if (!reader.IsDBNull(7))
                {
                    flightDate = reader.GetDateTime(7);
                }
                int totalTickets = reader.GetInt32(8);
                int remainingTickets = reader.GetInt32(9);
                int transits = reader.GetInt32(10);
                int airplaneId = reader.GetInt32(11);
                string status = reader.GetString(12);

                // Lấy thông tin sân bay
                DAO_Airport daoAirport = new DAO_Airport();
                Airport departureAirport = daoAirport.getById(departureAirportId);
                Airport destinationAirport = daoAirport.getById(destinationAirportId);

                // Lấy thông tin máy bay
                DAO_Airplane daoAirplane = new DAO_Airplane();
                Airplane airplane = daoAirplane.getById(airplaneId);

                flight = new Flight(flightId, departurePoint, destination, departureAirport, destinationAirport, departureTime, arrivalTime, flightDate, totalTickets, remainingTickets, transits, airplane, status);
            }

            _conn.Close();
            return flight;
        }

        public void add(Flight flight)
        {
            _conn.Open();
            string departureTimeStr = flight.DepartureTime != null ? $"'{flight.DepartureTime.Value.ToString("yyyy-MM-dd HH:mm:ss")}'" : "NULL";
            string arrivalTimeStr = flight.ArrivalTime != null ? $"'{flight.ArrivalTime.Value.ToString("yyyy-MM-dd HH:mm:ss")}'" : "NULL";
            string flightDateStr = flight.FlightDate != null ? $"'{flight.FlightDate.Value.ToString("yyyy-MM-dd")}'" : "NULL";
            command = new SqlCommand($"INSERT INTO flights (departure_point, destination, departure_airport, destination_airport, departure_time, arrival_time, flight_date, total_tickets, remaining_tickets, transits, aircraft_id, status) " +
                $"VALUES (N'{flight.DeparturePoint}', N'{flight.Destination}', {flight.DepartureAirport.AirportId}, {flight.DestinationAirport.AirportId}, " +
                $"{departureTimeStr}, {arrivalTimeStr}, {flightDateStr}, {flight.TotalTickets}, {flight.RemainingTickets}, {flight.Transits}, {flight.Airplane.AirplaneId}, N'{flight.Status}')", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void update(Flight flight)
        {
            _conn.Open();
            string departureTimeStr = flight.DepartureTime != null ? $"'{flight.DepartureTime.Value.ToString("yyyy-MM-dd HH:mm:ss")}'" : "NULL";
            string arrivalTimeStr = flight.ArrivalTime != null ? $"'{flight.ArrivalTime.Value.ToString("yyyy-MM-dd HH:mm:ss")}'" : "NULL";
            string flightDateStr = flight.FlightDate != null ? $"'{flight.FlightDate.Value.ToString("yyyy-MM-dd")}'" : "NULL";
            command = new SqlCommand($"UPDATE flights SET " +
                $"departure_point = N'{flight.DeparturePoint}', " +
                $"destination = N'{flight.Destination}', " +
                $"departure_airport = {flight.DepartureAirport.AirportId}, " +
                $"destination_airport = {flight.DestinationAirport.AirportId}, " +
                $"departure_time = {departureTimeStr}, " +
                $"arrival_time = {arrivalTimeStr}, " +
                $"flight_date = {flightDateStr}, " +
                $"total_tickets = {flight.TotalTickets}, " +
                $"remaining_tickets = {flight.RemainingTickets}, " +
                $"transits = {flight.Transits}, " +
                $"aircraft_id = {flight.Airplane.AirplaneId}, " +
                $"status = N'{flight.Status}' " +
                $"WHERE flight_id = {flight.FlightId}", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void delete(int id)
        {
            _conn.Open();
            command = new SqlCommand($"DELETE FROM flights WHERE flight_id = {id}", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
    }

}
