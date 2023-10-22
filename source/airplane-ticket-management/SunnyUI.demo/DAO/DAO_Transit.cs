using Sunny.UI.Demo.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sunny.UI.Demo.DAO
{
    public class DAO_Transit : DBConnection
    {
        SqlConnection _conn;
        private SqlCommand command;
        private SqlDataReader reader;

        public DAO_Transit()
        {
            _conn = new SqlConnection(_strConn);
        }

        public List<Transit> getAll()
        {
            List<Transit> transitList = new List<Transit>();
            _conn.Open();

            try
            {
                command = new SqlCommand($"SELECT * FROM transits", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError();
                return transitList;
            }

            while (reader.Read())
            {
                int transitId = reader.GetInt32(0);
                int transitAirportId = reader.GetInt32(1);
                int flightId = reader.GetInt32(2);

                Airport transitAirport = new DAO_Airport().getById(transitAirportId);

                Transit transit = new Transit(transitId, transitAirport, flightId);
                transitList.Add(transit);
            }

            _conn.Close();
            return transitList;
        }
        public List<Transit> getByFlightId(int flight_id)
        {
            List<Transit> transitList = new List<Transit>();
            _conn.Open();

            try
            {
                command = new SqlCommand($"SELECT * FROM transits WHERE flight_id = {flight_id}", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError();
                return transitList;
            }

            while (reader.Read())
            {
                int transitId = reader.GetInt32(0);
                int transitAirportId = reader.GetInt32(1);
                int flightId = reader.GetInt32(2);

                Airport transitAirport = new DAO_Airport().getById(transitAirportId);

                Transit transit = new Transit(transitId, transitAirport, flightId);
                transitList.Add(transit);
            }

            _conn.Close();
            return transitList;
        }

        public Transit getById(int id)
        {
            Transit transit = new Transit();
            _conn.Open();

            try
            {
                command = new SqlCommand($"SELECT * FROM transits WHERE transit_id = {id}", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError();
                return transit;
            }

            while (reader.Read())
            {
                int transitId = reader.GetInt32(0);
                int transitAirportId = reader.GetInt32(1);
                int flightId = reader.GetInt32(2);

                // Lấy thông tin sân bay
                DAO_Airport daoAirport = new DAO_Airport();
                Airport transitAirport = daoAirport.getById(transitAirportId);

                transit = new Transit(transitId, transitAirport, flightId);
            }

            _conn.Close();
            return transit;
        }

        public void add(Transit transit)
        {
            _conn.Open();
            command = new SqlCommand($"INSERT INTO transits (transit_airport_id, flight_id) " +
                $"VALUES ({transit.TransitAirport.AirportId}, {transit.FlightId})", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void update(Transit transit)
        {
            _conn.Open();
            command = new SqlCommand($"UPDATE transits SET " +
                $"transit_airport_id = {transit.TransitAirport.AirportId}, " +
                $"flight_id = {transit.FlightId} " +
                $"WHERE transit_id = {transit.TransitId}", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void delete(int id)
        {
            _conn.Open();
            command = new SqlCommand($"DELETE FROM transits WHERE transit_id = {id}", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
    }

}
