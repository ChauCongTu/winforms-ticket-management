using Sunny.UI.Demo.DAO;
using Sunny.UI.Demo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sunny.UI.Demo.Views.UserCtrl
{
    public partial class ucFlight : UserControl
    {
        DAO_Flight daoFlight;
        public ucFlight()
        {
            InitializeComponent();
            daoFlight = new DAO_Flight();
        }
        void table_load()
        {
            dgvFlight.Rows.Clear();
            int i = 1;
            DAO_Flight daoFlight = new DAO_Flight();
            List<Flight> flights = daoFlight.getAll();
            foreach (Flight flight in flights)
            {
                dgvFlight.Rows.Add(flight.FlightId, flight.DeparturePoint, flight.Destination, flight.RemainingTickets, flight.DepartureTime.Value.ToString("dd/MM/yyyy"), flight.DepartureTime.Value.ToString("hh:mm"));
            }
        }

        private void ucFlight_Load(object sender, EventArgs e)
        {
            table_load();
        }
    }
}
