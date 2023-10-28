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

namespace Sunny.UI.Demo.Views.NForm.Flights
{
    public partial class ShowDetail : Form
    {
        private Flight flight;
        public ShowDetail()
        {
            InitializeComponent();
            btnSave.BringToFront();
        }
        public ShowDetail(Flight flight)
        {
            InitializeComponent();
            this.flight = flight;
            btnEdit.BringToFront();
            // Load data
            txtFrom.Text = flight.DeparturePoint.ToString();
            txtTo.Text = flight.Destination.ToString();
            cbFrom.Text = flight.DepartureAirport.AirportName;
            cbTo.Text = flight.DestinationAirport.AirportName;
            dtpTime.Text = flight.DepartureTime.Value.ToString("HH:mm dd/MM/yyyy");
            txtTotalTicket.Text = flight.TotalTickets.ToString();
            cbStatus.Text = flight.Status.ToString();
            List<String> listStatus = new List<string>();
            listStatus.Add("Hoạt động");
            listStatus.Add("Delay");
            listStatus.Add("Cancel");
            cbStatus.DataSource = listStatus;
            if (flight.RemainingTickets > 0)
            {
                lbRemaingTicket.Text = "Còn " + flight.RemainingTickets.ToString() + " vé.";
                lbRemaingTicket.ForeColor = Color.Green;
            }
            else
            {
                lbRemaingTicket.Text = "Hết vé.";
                lbRemaingTicket.ForeColor = Color.Red;
            }
            cbAirline.Text = new DAO_Airline().getByPlaneId(flight.Airplane.AirplaneId).AirlineName;
            cbAirplane.Text = flight.Airplane.AirplaneNumber.ToString();
        }

        private void uiLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnSwitchPlane_Click(object sender, EventArgs e)
        {

        }

        private void ShowDetail_Load(object sender, EventArgs e)
        {

        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();    
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.BringToFront();
            txtFrom.Enabled = true;
            txtTo.Enabled = true;
            cbFrom.Enabled = true;
            cbTo.Enabled = true;
            dtpTime.Enabled = true;
            txtTotalTicket.Enabled = true;
            cbAirline.Enabled = true;
            cbAirplane.Enabled = true;
        }

        private void txtFrom_TextChanged(object sender, EventArgs e)
        {
            cbFrom.DataSource = new DAO.DAO_Airport().getByCity(txtFrom.Text);
            cbFrom.ValueMember = "AirportId";
            cbFrom.DisplayMember = "AirportName";
        }

        private void txtTo_TextChanged(object sender, EventArgs e)
        {
            cbTo.DataSource = new DAO.DAO_Airport().getByCity(txtTo.Text);
            cbTo.ValueMember = "AirportId";
            cbTo.DisplayMember = "AirportName";
        }

        private void lbPlaneCode_Click(object sender, EventArgs e)
        {

        }
    }
}
