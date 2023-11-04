using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sunny.UI.Demo.DAO
{
    public class DAO_Statistical_Profit : DBConnection
    {
        SqlConnection _conn;

        public DAO_Statistical_Profit()
        {
            _conn = new SqlConnection(_strConn); 
        }

        public DataTable GetTransaction_MonthData(DateTime startDate, DateTime endDate)
        {
            string query = "SELECT MONTH(s.booking_date) AS [Tháng], SUM(t.price_vnd) AS [Doanh thu] " +
                               "FROM transactions s " +
                               "JOIN tickets t ON s.ticket_id = t.ticket_id " +
                               "WHERE s.booking_date >= @StartDate AND s.booking_date <= @EndDate " +
                               "GROUP BY MONTH(s.booking_date)";

            using (SqlCommand cmd = new SqlCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public DataTable GetTransaction_DayData(DateTime startDate, DateTime endDate)
        {
            string query = "SELECT DAY(s.booking_date) AS [Ngày], SUM(t.price_vnd) AS [Doanh thu] " +
                               "FROM transactions s " +
                               "JOIN tickets t ON s.ticket_id = t.ticket_id " +
                               "WHERE s.booking_date >= @StartDate AND s.booking_date <= @EndDate " +
                               "GROUP BY DAY(s.booking_date)";

            using (SqlCommand cmd = new SqlCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

    }
}



