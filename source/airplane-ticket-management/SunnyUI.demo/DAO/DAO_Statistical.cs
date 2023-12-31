﻿using Sunny.UI.Demo.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Sunny.UI.Demo.DAO
{
    public class DAO_Statistical : DBConnection
    {
        SqlConnection _conn;       

        public DAO_Statistical()
        {
            _conn = new SqlConnection(_strConn);
        }

        public int getUser_Count()
        {
            int userCount = 0;
            using (SqlConnection _conn = new SqlConnection(_strConn))
            {
                _conn.Open();

                try
                {
                    using (SqlCommand command = new SqlCommand("SELECT count(*) as user_count FROM users", _conn))
                    {
                        userCount = (int)command.ExecuteScalar();
                    }
                }
                catch (Exception e)
                {
                    new Helper().dbError();
                    return userCount;
                }
            }

            return userCount;
        }

        public int getTicket_Count()
        {
            DateTime a = DateTime.Now;
            int month = a.Month;
            int userCount = 0;
            using (SqlConnection _conn = new SqlConnection(_strConn))
            {
                _conn.Open();

                try
                {
                    using (SqlCommand command = new SqlCommand($"SELECT count(*) as ticket_count FROM transactions WHERE MONTH(booking_date) = {month}", _conn))
                    {
                        userCount = (int)command.ExecuteScalar();
                    }
                }
                catch (Exception e)
                {
                    new Helper().dbError();
                    return userCount;
                }
            }

            return userCount;
        }

        public int getCustomer_Count()
        {
            int customerCount = 0;
            using (SqlConnection _conn = new SqlConnection(_strConn))
            {
                _conn.Open();

                try
                {
                    using (SqlCommand command = new SqlCommand("SELECT count(*) as customer_count FROM customers", _conn))
                    {
                        customerCount = (int)command.ExecuteScalar();
                    }
                }
                catch (Exception e)
                {
                    new Helper().dbError();
                    return customerCount;
                }
            }
            return customerCount;
        }

        public int getFlight_Count()
        {
            int flightCount = 0;
            using (SqlConnection _conn = new SqlConnection(_strConn))
            {
                _conn.Open();

                try
                {
                    using (SqlCommand command = new SqlCommand("SELECT count(*) as flight_count FROM flights", _conn))
                    {
                        flightCount = (int)command.ExecuteScalar();
                    }
                }
                catch (Exception e)
                {
                    new Helper().dbError();
                    return flightCount;
                }
            }
            return flightCount;
        }

        public int getRevenue_Count()
        {
            DateTime a = DateTime.Now;
            int month = a.Month;
            int revenueCount = 0;
            using (SqlConnection _conn = new SqlConnection(_strConn))
            {
                _conn.Open();

                try
                {
                    using (SqlCommand command = new SqlCommand($"SELECT SUM(t.price_vnd) as revenue_count FROM transactions s JOIN tickets t ON s.ticket_id = t.ticket_id WHERE MONTH(s.booking_date) = {month}", _conn))
                    {
                        revenueCount = (int)command.ExecuteScalar();
                    }
                }
                catch (Exception e)
                {
                    new Helper().dbError();
                    return revenueCount;
                }
            }
            return revenueCount;
        }
             
    }
}

