using Sunny.UI.Demo.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sunny.UI.Demo.DAO
{
    public class DAO_Airplane : DBConnection
    {
        SqlConnection _conn;
        private SqlCommand command;
        private SqlDataReader reader;
        public DAO_Airplane()
        {
            _conn = new SqlConnection(_strConn);
        }
        public List<Airplane> getAll()
        {
            List<Airplane> list = new List<Airplane>();
            _conn.Open();
            try
            {
                command = new SqlCommand($"SELECT * FROM airplanes", _conn);
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
                string desc = reader.GetString(2);
                string code = reader.GetString(3);
                int numb = reader.GetInt32(4);
                Airplane airplane = new Airplane(id, name, desc, code, numb);
                list.Add(airplane);
            }
            return list;
        }
        public List<Airplane> getByAirline(int airline_id)
        {
            List<Airplane> list = new List<Airplane>();
            _conn.Open();
            try
            {
                command = new SqlCommand($"SELECT * FROM airplanes WHERE airline_id = {airline_id}", _conn);
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
                string desc = reader.GetString(2);
                string code = reader.GetString(3);
                int numb = reader.GetInt32(4);
                Airplane airplane = new Airplane(id, name, desc, code, numb);
                list.Add(airplane);
            }
            return list;
        }
        public Airplane getById(int id)
        {
            Airplane airplane = new Airplane();
            _conn.Open();
            try
            {
                command = new SqlCommand($"SELECT * FROM airplanes WHERE airplane_id = {id}", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError();
                return airplane;
            }
            while (reader.Read())
            {
                int plane_id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string desc = reader.GetString(2);
                string code = reader.GetString(3);
                int numb = reader.GetInt32(4);
                airplane = new Airplane(plane_id, name, desc, code, numb);
            }
            return airplane;
        }
        public void add(Airplane airplane, int airline_id)
        {
            _conn.Open();
            command = new SqlCommand($"INSERT INTO airplanes (airplane_type, description, airplane_number, number_of_seats, airline_id)" +
                $"VALUES (N'{airplane.AirplaneType}', N'{airplane.Description}', N'{airplane.AirplaneNumber}', {airplane.NumberOfSeats}, {airline_id})", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void update(Airplane airplane)
        {
            _conn.Open();
            command = new SqlCommand($"UPDATE airplanes SET " +
                $"airplane_type = N'{airplane.AirplaneType}', " +
                $"description = N'{airplane.Description}', " +
                $"airplane_number = N'{airplane.AirplaneNumber}', " +
                $"number_of_seats = {airplane.NumberOfSeats}" +
                $"WHERE airplane_id = {airplane.AirplaneId}", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void delete(int id)
        {
            _conn.Open();
            command = new SqlCommand($"DELETE FROM airplanes WHERE airplane_id = '{id}'", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
