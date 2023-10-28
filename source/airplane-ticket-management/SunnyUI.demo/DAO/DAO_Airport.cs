using Sunny.UI.Demo.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sunny.UI.Demo.DAO
{
    public class DAO_Airport : DBConnection
    {
        SqlConnection _conn;
        private SqlCommand command;
        private SqlDataReader reader;
        public DAO_Airport()
        {
            _conn = new SqlConnection(_strConn);
        }
        public List<Airport> getAll()
        {
            List<Airport> list = new List<Airport>();
            _conn.Open();
            try
            {
                command = new SqlCommand($"SELECT * FROM airports", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError();
                return list;
            }

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string coor = reader.GetString(2);
                string address = reader.GetString(3);
                string city = reader.GetString(4);
                string country = reader.GetString(5);
                Airport airport = new Airport(id, name, coor, address, city, country);
                list.Add(airport);
            }
            return list;
        }

        public List<Airport> getByCity(string City)
        {
            List<Airport> list = new List<Airport>();
            _conn.Open();
            try
            {
                command = new SqlCommand($"SELECT * FROM airports WHERE city LIKE '%{City}%'", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError();
                return list;
            }

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string coor = reader.GetString(2);
                string address = reader.GetString(3);
                string city = reader.GetString(4);
                string country = reader.GetString(5);
                Airport airport = new Airport(id, name, coor, address, city, country);
                list.Add(airport);
            }
            return list;
        }

        public List<Airport> findByName(string airport_name)
        {
            List<Airport> list = new List<Airport>();
            _conn.Open();
            try
            {
                command = new SqlCommand($"SELECT * FROM airports WHERE airport_name LIKE '%{airport_name}%'", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError();
                return list;
            }

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string coor = reader.GetString(2);
                string address = reader.GetString(3);
                string city = reader.GetString(4);
                string country = reader.GetString(5);
                Airport airport = new Airport(id, name, coor, address, city, country);
                list.Add(airport);
            }
            return list;
        }
        public Airport getById(int airport_id)
        {
            Airport airport = new Airport();
            _conn.Close();
            _conn.Open();
            try
            {
                command = new SqlCommand($"SELECT * FROM airports WHERE airport_id = {airport_id}", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError();
                return airport;
            }

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string coor = reader.GetString(2);
                string address = reader.GetString(3);
                string city = reader.GetString(4);
                string country = reader.GetString(5);
                airport = new Airport(id, name, coor, address, city, country);
            }
            return airport;
        }
        public void add(Airport airport)
        {
            _conn.Open();
            command = new SqlCommand($"INSERT INTO airports (airport_name, coordinates, address, city, country) " +
                                     $"VALUES (N'{airport.AirportName}', N'{airport.Coordinates}', N'{airport.Address}', " +
                                     $"N'{airport.City}', N'{airport.Country}')", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void update(Airport airport)
        {
            _conn.Open();
            command = new SqlCommand($"UPDATE airports SET " +
                                     $"airport_name = N'{airport.AirportName}', " +
                                     $"coordinates = N'{airport.Coordinates}', " +
                                     $"address = N'{airport.Address}', " +
                                     $"city = N'{airport.City}', " +
                                     $"country = N'{airport.Country}' " +
                                     $"WHERE airport_id = {airport.AirportId}", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public void delete(int id)
        {
            _conn.Open();
            command = new SqlCommand($"DELETE FROM airports WHERE airport_id = '{id}'", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
