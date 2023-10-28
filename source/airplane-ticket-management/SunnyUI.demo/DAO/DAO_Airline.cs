using Sunny.UI.Demo.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sunny.UI.Demo.DAO
{
    public class DAO_Airline:DBConnection
    {
        SqlConnection _conn;
        private SqlCommand command;
        private SqlDataReader reader;
        public DAO_Airline()
        {
            _conn = new SqlConnection(_strConn);
        }
        public List<Airline> getAll()
        {
            List<Airline> list = new List<Airline>();
            _conn.Open();
            try
            {
                command = new SqlCommand($"SELECT l.airline_id, l.airline_name, COUNT(p.airplane_id) as numb_of_plane " +
                    $"FROM airlines l LEFT JOIN airplanes p ON l.airline_id = p.airline_id " +
                    $"GROUP BY l.airline_id, l.airline_name", _conn);
                reader = command.ExecuteReader();
            }
            catch(Exception e)
            {
                new Helper().dbError();
                return list;
            }
            
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                int numb = reader.GetInt32(2);
                Airline airline = new Airline(id, name, numb);
                list.Add(airline);
            }
            return list;
        }
        public Airline getById(int id)
        {
            Airline airline = new Airline();
            _conn.Open();
            try
            {
                command = new SqlCommand($"SELECT l.airline_id, l.airline_name, COUNT(p.airplane_id) as numb_of_plane " +
                    $"FROM airlines l LEFT JOIN airplanes p ON l.airline_id = p.airline_id " +
                    $"WHERE l.airline_id = "+ id +
                    $"GROUP BY l.airline_id, l.airline_name", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError();
                return airline;
            }
            while(reader.Read())
            {
                int airline_id = reader.GetInt32(0);
                string name = reader.GetString(1);
                int numb = reader.GetInt32(2);
                airline = new Airline(id, name, numb);
            }
            return airline;
        }
        public Airline getByPlaneId(int Planeid)
        {
            Airline airline = new Airline();
            _conn.Open();
            try
            {
                command = new SqlCommand($"SELECT l.airline_id, l.airline_name, COUNT(p.airplane_id) as numb_of_plane " +
                    $"FROM airlines l LEFT JOIN airplanes p ON l.airline_id = p.airline_id " +
                    $"WHERE p.airplane_id = " + Planeid +
                    $"GROUP BY l.airline_id, l.airline_name", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError();
                return airline;
            }
            while (reader.Read())
            {
                int airline_id = reader.GetInt32(0);
                string name = reader.GetString(1);
                int numb = reader.GetInt32(2);
                airline = new Airline(airline_id, name, numb);
            }
            return airline;
        }
        public List<Airline> findByName(string name)
        {
            List<Airline> list = new List<Airline>();
            _conn.Open();
            try
            {
                command = new SqlCommand($"SELECT l.airline_id, l.airline_name, COUNT(p.airplane_id) as numb_of_plane " +
                     $"FROM airlines l LEFT JOIN airplanes p ON l.airline_id = p.airline_id " +
                     $"WHERE l.airline_name LIKE '%" + name + "%'" +
                     $"GROUP BY l.airline_id, l.airline_name", _conn);
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
                string airline_name = reader.GetString(1);
                int numb = reader.GetInt32(2);
                Airline airline = new Airline(id, airline_name, numb);
                list.Add(airline);
            }
            return list;
        }
        public Boolean add(Airline airline)
        {
            _conn.Open();
            try
            {
                command = new SqlCommand($"INSERT INTO airlines (airline_name) VALUES(N'{airline.AirlineName}')", _conn);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }
            _conn.Close();
            return true;
        }
        public Boolean update(Airline airline)
        {
            _conn.Open();
            try
            {
                command = new SqlCommand($"UPDATE airlines SET airline_name = N'{airline.AirlineName}' WHERE airline_id = {airline.AirlineId}", _conn);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }
            _conn.Close();
            return true;
        }
        public void delete(int id)
        {
            _conn.Open();
            command = new SqlCommand($"DELETE FROM airlines WHERE airline_id = {id}", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
