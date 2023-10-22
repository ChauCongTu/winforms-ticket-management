using Sunny.UI.Demo.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sunny.UI.Demo.DAO
{
    public class DAO_User : DBConnection
    {
        SqlConnection _conn;
        private SqlCommand command;
        private SqlDataReader reader;

        public DAO_User()
        {
            _conn = new SqlConnection(_strConn);
        }

        public List<User> getAll()
        {
            List<User> userList = new List<User>();
            _conn.Open();

            try
            {
                command = new SqlCommand($"SELECT * FROM users", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError();
                return userList;
            }

            while (reader.Read())
            {
                int userId = reader.GetInt32(0);
                string userName = reader.GetString(1);
                string emailAddress = reader.GetString(2);
                string password = reader.GetString(3);
                string role = reader.GetString(4);
                string gender = reader.GetString(5);
                string phoneNumber = reader.GetString(6);
                string address = reader.GetString(7);
                string status = reader.GetString(8);

                User user = new User(userId, userName, emailAddress, password, role, gender, phoneNumber, address, status);
                userList.Add(user);
            }

            _conn.Close();
            return userList;
        }

        public List<User> findByName(string user_name)
        {
            List<User> userList = new List<User>();
            _conn.Open();

            try
            {
                command = new SqlCommand($"SELECT * FROM users WHERE user_name LIKE '%{user_name}%'", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError();
                return userList;
            }

            while (reader.Read())
            {
                int userId = reader.GetInt32(0);
                string userName = reader.GetString(1);
                string emailAddress = reader.GetString(2);
                string password = reader.GetString(3);
                string role = reader.GetString(4);
                string gender = reader.GetString(5);
                string phoneNumber = reader.GetString(6);
                string address = reader.GetString(7);
                string status = reader.GetString(8);

                User user = new User(userId, userName, emailAddress, password, role, gender, phoneNumber, address, status);
                userList.Add(user);
            }

            _conn.Close();
            return userList;
        }

        public User getById(int id)
        {
            User user = new User();
            _conn.Open();

            try
            {
                command = new SqlCommand($"SELECT * FROM users WHERE user_id = {id}", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError();
                return user;
            }

            while (reader.Read())
            {
                int userId = reader.GetInt32(0);
                string userName = reader.GetString(1);
                string emailAddress = reader.GetString(2);
                string password = reader.GetString(3);
                string role = reader.GetString(4);
                string gender = reader.GetString(5);
                string phoneNumber = reader.GetString(6);
                string address = reader.GetString(7);
                string status = reader.GetString(8);

                user = new User(userId, userName, emailAddress, password, role, gender, phoneNumber, address, status);
            }

            _conn.Close();
            return user;
        }
        public User getLogin(string email)
        {
            User user = new User();
            _conn.Open();

            try
            {
                command = new SqlCommand($"SELECT * FROM users WHERE email_address = '{email}'", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError();
                return user;
            }

            while (reader.Read())
            {
                int userId = reader.GetInt32(0);
                string userName = reader.GetString(1);
                string emailAddress = reader.GetString(2);
                string password = reader.GetString(3);
                string role = reader.GetString(4);
                string gender = reader.GetString(5);
                string phoneNumber = reader.GetString(6);
                string address = reader.GetString(7);
                string status = reader.GetString(8);

                user = new User(userId, userName, emailAddress, password, role, gender, phoneNumber, address, status);
            }

            _conn.Close();
            return user;
        }

        public void add(User user)
        {
            _conn.Open();
            command = new SqlCommand($"INSERT INTO users (user_name, email_address, password, role, gender, phone_number, address, status) " +
                $"VALUES (N'{user.UserName}', N'{user.EmailAddress}', N'{user.Password}', N'user', " +
                $"N'{user.Gender}', N'{user.PhoneNumber}', N'{user.Address}', N'{user.Status}')", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void update(User user)
        {
            _conn.Open();
            command = new SqlCommand($"UPDATE users SET " +
                $"user_name = N'{user.UserName}', " +
                $"email_address = N'{user.EmailAddress}', " +
                $"password = N'{user.Password}', " +
                $"role = N'{user.Role}', " +
                $"gender = N'{user.Gender}', " +
                $"phone_number = N'{user.PhoneNumber}', " +
                $"address = N'{user.Address}', " +
                $"status = N'{user.Status}' " +
                $"WHERE user_id = {user.UserId}", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void delete(int id)
        {
            _conn.Open();
            command = new SqlCommand($"DELETE FROM users WHERE user_id = {id}", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
    }

}
