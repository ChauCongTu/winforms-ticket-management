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
                    $"FROM airlines l JOIN airplanes p ON l.airline_id = p.airline_id " +
                    $"GROUP BY l.airline_id, l.airline_name", _conn);
                reader = command.ExecuteReader();
            }
            catch(Exception e)
            {
                string message = "Có lỗi xảy ra, vui lòng thử lại!\nNếu lỗi vẫn tiếp tục xảy ra, báo lỗi cho kỹ thuật";
                string title = "Có lỗi xảy ra";
                MessageBox.Show(message, title);
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
    }
}
