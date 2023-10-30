using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sunny.UI.Demo.DAO
{
    public class DBConnection
    {
        public string _strConn = "Data Source=./;Initial Catalog=airplane_ticket_management;Integrated Security=True";
        public DBConnection()
        {

        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_strConn);
        }
    }
}
