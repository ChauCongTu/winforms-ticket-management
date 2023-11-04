using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunny.UI.Demo.DAO
{
    internal class DAO_Statistical_Ticket_Sales : DBConnection
    {
        SqlConnection _conn;

        public DAO_Statistical_Ticket_Sales()
        {
            _conn = new SqlConnection(_strConn);
        }

        public DataTable GetTicketClass_MonthData(DateTime startDate, DateTime endDate)
        {
            string query = "SELECT tc.class_type, COUNT(t.ticket_id) as ticket_count " +
                       "FROM ticket_classes tc " +
                       "LEFT JOIN tickets t ON tc.class_id = t.ticket_class " +
                       "LEFT JOIN transactions tr ON t.ticket_id = tr.ticket_id " +
                       "WHERE tr.booking_date BETWEEN @StartDate AND @EndDate " +
                       "GROUP BY tc.class_type";

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
