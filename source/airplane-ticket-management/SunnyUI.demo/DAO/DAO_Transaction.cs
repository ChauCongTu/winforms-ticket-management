using Sunny.UI.Demo.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sunny.UI.Demo.DAO
{
    public class DAO_Transaction : DBConnection
    {
        SqlConnection _conn;
        private SqlCommand command;
        private SqlDataReader reader;

        public DAO_Transaction()
        {
            _conn = new SqlConnection(_strConn);
        }

        public List<Transaction> getAll()
        {
            List<Transaction> transactionList = new List<Transaction>();
            _conn.Open();

            try
            {
                command = new SqlCommand($"SELECT * FROM transactions", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError();
                return transactionList;
            }

            while (reader.Read())
            {
                int transactionId = reader.GetInt32(0);
                string bookingCode = reader.GetString(1);
                int ticketId = reader.GetInt32(2);
                int customerId = reader.GetInt32(3);
                string note = reader.GetString(4);
                DateTime? bookingDate = null;
                if (!reader.IsDBNull(5))
                {
                    bookingDate = reader.GetDateTime(5);
                }
                int performedById = reader.GetInt32(6);

                // Lấy thông tin khách hàng
                DAO_Customer daoCustomer = new DAO_Customer();
                Customer customer = daoCustomer.getById(customerId);

                // Lấy thông tin người thực hiện
                DAO_User daoUser = new DAO_User();
                User performedBy = daoUser.getById(performedById);

                Transaction transaction = new Transaction(transactionId, bookingCode, ticketId, customer, note, bookingDate, performedBy);
                transactionList.Add(transaction);
            }

            _conn.Close();
            return transactionList;
        }

        public Transaction getById(int id)
        {
            Transaction transaction = new Transaction();
            _conn.Open();

            try
            {
                command = new SqlCommand($"SELECT * FROM transactions WHERE transaction_id = {id}", _conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                new Helper().dbError();
                return transaction;
            }

            while (reader.Read())
            {
                int transactionId = reader.GetInt32(0);
                string bookingCode = reader.GetString(1);
                int ticketId = reader.GetInt32(2);
                int customerId = reader.GetInt32(3);
                string note = reader.GetString(4);
                DateTime? bookingDate = null;
                if (!reader.IsDBNull(5))
                {
                    bookingDate = reader.GetDateTime(5);
                }
                int performedById = reader.GetInt32(6);

                // Lấy thông tin khách hàng
                DAO_Customer daoCustomer = new DAO_Customer();
                Customer customer = daoCustomer.getById(customerId);

                // Lấy thông tin người thực hiện
                DAO_User daoUser = new DAO_User();
                User performedBy = daoUser.getById(performedById);

                transaction = new Transaction(transactionId, bookingCode, ticketId, customer, note, bookingDate, performedBy);
            }

            _conn.Close();
            return transaction;
        }

        public void add(Transaction transaction)
        {
            _conn.Open();
            string bookingDateStr = transaction.BookingDate != null ? $"'{transaction.BookingDate.Value.ToString("yyyy-MM-dd HH:mm:ss")}'" : "NULL";
            command = new SqlCommand($"INSERT INTO transactions (booking_code, ticket_id, customer_id, note, booking_date, performed_by) " +
                $"VALUES (N'{transaction.BookingCode}', {transaction.TicketId}, {transaction.Customer.CustomerId}, " +
                $"N'{transaction.Note}', {bookingDateStr}, {transaction.Performed.UserId})", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void update(Transaction transaction)
        {
            _conn.Open();
            string bookingDateStr = transaction.BookingDate != null ? $"'{transaction.BookingDate.Value.ToString("yyyy-MM-dd HH:mm:ss")}'" : "NULL";
            command = new SqlCommand($"UPDATE transactions SET " +
                $"booking_code = N'{transaction.BookingCode}', " +
                $"ticket_id = {transaction.TicketId}, " +
                $"customer_id = {transaction.Customer.CustomerId}, " +
                $"note = N'{transaction.Note}', " +
                $"booking_date = {bookingDateStr}, " +
                $"performed_by = {transaction.Performed.UserId} " +
                $"WHERE transaction_id = {transaction.TransactionId}", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void delete(int id)
        {
            _conn.Open();
            command = new SqlCommand($"DELETE FROM transactions WHERE transaction_id = {id}", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
    }

}
