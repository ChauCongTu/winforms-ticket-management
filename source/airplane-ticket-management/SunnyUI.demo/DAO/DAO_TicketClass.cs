using Sunny.UI.Demo.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sunny.UI.Demo.DAO
{
    public class DAO_TicketClass : DBConnection
    {
        SqlConnection _conn;
        private SqlCommand command;
        private SqlDataReader reader;

        public DAO_TicketClass()
        {
            _conn = new SqlConnection(_strConn);
        }

        public List<TicketClass> getAll()
        {
            List<TicketClass> list = new List<TicketClass>();
            _conn.Open();

            try
            {
                command = new SqlCommand($"SELECT * FROM ticket_classes", _conn);
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
                string type = reader.GetString(1);
                TicketClass ticketClass = new TicketClass(id, type);
                list.Add(ticketClass);
            }

            _conn.Close();
            return list;
        }

        public TicketClass getById(int id)
        {
            TicketClass ticketClass = new TicketClass();
            _conn.Open();

            try
            {
                command = new SqlCommand($"SELECT * FROM ticket_classes WHERE class_id = {id}", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError();
                return ticketClass;
            }

            while (reader.Read())
            {
                int class_id = reader.GetInt32(0);
                string type = reader.GetString(1);
                ticketClass = new TicketClass(class_id, type);
            }

            _conn.Close();
            return ticketClass;
        }

        public void add(TicketClass ticketClass)
        {
            _conn.Open();

            command = new SqlCommand($"INSERT INTO ticket_classes (class_type) " +
                $"VALUES (N'{ticketClass.ClassType}')", _conn);

            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void update(TicketClass ticketClass)
        {
            _conn.Open();

            command = new SqlCommand($"UPDATE ticket_classes SET " +
                $"class_type = N'{ticketClass.ClassType}' " +
                $"WHERE class_id = {ticketClass.ClassId}", _conn);

            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void delete(int id)
        {
            _conn.Open();

            command = new SqlCommand($"DELETE FROM ticket_classes WHERE class_id = {id}", _conn);

            command.ExecuteNonQuery();
            _conn.Close();
        }
    }

}
