using Sunny.UI.Demo.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sunny.UI.Demo.DAO
{
    public class DAO_Customer : DBConnection
    {
        SqlConnection _conn;
        private SqlCommand command;
        private SqlDataReader reader;

        public DAO_Customer()
        {
            _conn = new SqlConnection(_strConn);
        }

        public List<Customer> getAll()
        {
            List<Customer> customerList = new List<Customer>();
            _conn.Open();

            try
            {
                command = new SqlCommand($"SELECT * FROM customers", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError();
                return customerList;
            }

            while (reader.Read())
            {
                int customerId = reader.GetInt32(0);
                string customerName = reader.GetString(1);
                string phoneNumber = reader.GetString(2);
                string emailAddress = reader.GetString(3);
                string idNumber = reader.GetString(4);
                string gender = reader.GetString(5);

                DateTime? dateOfBirth = null;
                if (!reader.IsDBNull(6))
                {
                    dateOfBirth = reader.GetDateTime(6);
                }

                Customer customer = new Customer(customerId, customerName, phoneNumber, emailAddress, idNumber, gender, dateOfBirth);
                customerList.Add(customer);
            }

            _conn.Close();
            return customerList;
        }

        public Customer getById(int id)
        {
            Customer customer = new Customer();
            _conn.Open();

            try
            {
                command = new SqlCommand($"SELECT * FROM customers WHERE customer_id = {id}", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError();
                return customer;
            }

            while (reader.Read())
            {
                int customerId = reader.GetInt32(0);
                string customerName = reader.GetString(1);
                string phoneNumber = reader.GetString(2);
                string emailAddress = reader.GetString(3);
                string idNumber = reader.GetString(4);
                string gender = reader.GetString(5);

                DateTime? dateOfBirth = null;
                if (!reader.IsDBNull(6))
                {
                    dateOfBirth = reader.GetDateTime(6);
                }

                customer = new Customer(customerId, customerName, phoneNumber, emailAddress, idNumber, gender, dateOfBirth);
            }

            _conn.Close();
            return customer;
        }

        public Customer getByIdNumber(string id_number)
        {
            Customer customer = new Customer();
            _conn.Open();

            try
            {
                command = new SqlCommand($"SELECT * FROM customers WHERE id_number = '{id_number}'", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError();
                return customer;
            }

            while (reader.Read())
            {
                int customerId = reader.GetInt32(0);
                string customerName = reader.GetString(1);
                string phoneNumber = reader.GetString(2);
                string emailAddress = reader.GetString(3);
                string idNumber = reader.GetString(4);
                string gender = reader.GetString(5);

                DateTime? dateOfBirth = null;
                if (!reader.IsDBNull(6))
                {
                    dateOfBirth = reader.GetDateTime(6);
                }

                customer = new Customer(customerId, customerName, phoneNumber, emailAddress, idNumber, gender, dateOfBirth);
            }

            _conn.Close();
            return customer;
        }

        public Customer getByCustomerID(string ID)
        {
            Customer customer = new Customer();
            _conn.Open();

            try
            {
                command = new SqlCommand($"SELECT * FROM customers WHERE id_number = '{ID}'", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError();
                return customer;
            }

            while (reader.Read())
            {
                int customerId = reader.GetInt32(0);
                string customerName = reader.GetString(1);
                string phoneNumber = reader.GetString(2);
                string emailAddress = reader.GetString(3);
                string idNumber = reader.GetString(4);
                string gender = reader.GetString(5);

                DateTime? dateOfBirth = null;
                if (!reader.IsDBNull(6))
                {
                    dateOfBirth = reader.GetDateTime(6);
                }

                customer = new Customer(customerId, customerName, phoneNumber, emailAddress, idNumber, gender, dateOfBirth);
            }

            _conn.Close();
            return customer;
        }

        public void add(Customer customer)
        {
            _conn.Open();
            string dateOfBirthStr = customer.DateOfBirth != null ? $"'{customer.DateOfBirth.Value.ToString("yyyy-MM-dd")}'" : "NULL";
            command = new SqlCommand($"INSERT INTO customers (customer_name, phone_number, email_address, id_number, gender, date_of_birth) " +
                $"VALUES (N'{customer.CustomerName}', N'{customer.PhoneNumber}', N'{customer.EmailAddress}', " +
                $"N'{customer.IdNumber}', N'{customer.Gender}', {dateOfBirthStr})", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void update(Customer customer)
        {
            _conn.Open();
            string dateOfBirthStr = customer.DateOfBirth != null ? $"'{customer.DateOfBirth.Value.ToString("yyyy-MM-dd")}'" : "NULL";
            command = new SqlCommand($"UPDATE customers SET " +
                $"customer_name = N'{customer.CustomerName}', " +
                $"phone_number = N'{customer.PhoneNumber}', " +
                $"email_address = N'{customer.EmailAddress}', " +
                $"id_number = N'{customer.IdNumber}', " +
                $"gender = N'{customer.Gender}', " +
                $"date_of_birth = {dateOfBirthStr} " +
                $"WHERE customer_id = {customer.CustomerId}", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void delete(int id)
        {
            _conn.Open();
            command = new SqlCommand($"DELETE FROM customers WHERE customer_id = {id}", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
