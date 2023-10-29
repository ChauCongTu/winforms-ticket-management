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
            this.flight = new Flight();
            btnAdd.BringToFront();
            btnBooking.Disabled();
            uiLabel11.Disabled();
            lbRemaingTicket.Disabled();
            cbFromDe.Enabled = true;
            cbFromDe.DataSource = Helper.LoadProvince();
            cbToDe.Enabled = true;
            cbToDe.DataSource = Helper.LoadProvince();
            cbFrom.Enabled = true;
            cbTo.Enabled = true;
            dtpTime.Enabled = true;
            txtTotalTicket.Enabled = true;
            cbAirline.Enabled = true;
            cbAirline.DataSource = new DAO_Airline().getAll();
            cbStatus.Text = "Hoạt động";
            cbAirline.ValueMember = "AirlineId";
            cbAirline.DisplayMember = "AirlineName";
            cbAirplane.Enabled = true;
        }
        public ShowDetail(Flight flight)
        {
            InitializeComponent();
            this.flight = flight;
            btnEdit.BringToFront();
            // Load data
            cbFromDe.Text = flight.DeparturePoint.ToString();
            cbToDe.Text = flight.Destination.ToString();
            cbFrom.DataSource = new DAO.DAO_Airport().getByCity(cbFromDe.Text);
            cbFrom.ValueMember = "AirportId";
            cbFrom.DisplayMember = "AirportName";
            cbFrom.SelectedValue = flight.DepartureAirport.AirportId;
            cbTo.DataSource = new DAO.DAO_Airport().getByCity(cbToDe.Text);
            cbTo.ValueMember = "AirportId";
            cbTo.DisplayMember = "AirportName";
            cbTo.SelectedValue = flight.DestinationAirport.AirportId;
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
            cbAirline.DataSource = new DAO_Airline().getAll();
            cbAirline.ValueMember = "AirlineId";
            cbAirline.DisplayMember = "AirlineName";
            cbAirline.SelectedValue = new DAO_Airline().getByPlaneId(flight.Airplane.AirplaneId).AirlineId;
            cbAirplane.DataSource = new DAO_Airplane().getAll();
            cbAirplane.ValueMember = "AirplaneId";
            cbAirplane.DisplayMember = "AirplaneNumber";
            cbAirplane.SelectedValue = flight.Airplane.AirplaneId;

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            int airlineId = (int)cbAirline.SelectedValue;
            cbAirplane.DataSource = new DAO_Airplane().getByAirline(airlineId);
            cbAirplane.ValueMember = "AirplaneId";
            cbAirplane.DisplayMember = "AirplaneNumber";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbFromDe.Text.Length <= 0 || cbToDe.Text.Length <= 0 || cbFrom.Text.Length <= 0 || cbTo.Text.Length <= 0 || txtTotalTicket.TextLength <= 0 || cbAirplane.Text.Length <= 0)
            {
                lbErr.Text = "Vui lòng nhập đầy đủ thông tin.";
            }
            else
            {
                int plane_id = (int)cbAirplane.SelectedValue;
                int totalTicket = 0;
                try
                {
                    totalTicket = Int32.Parse(txtTotalTicket.Text);
                }
                catch (Exception ex)
                {
                    lbErr.Text = "Tổng số vé của chuyến bay phải là số nguyên không âm.";
                    lbErr.ForeColor = Color.Red;
                }
                if (!ValidationHelper.IsNonNegativeInteger(txtTotalTicket.Text))
                {
                    lbErr.Text = "Tổng số vé của chuyến bay phải là số nguyên không âm.";
                    lbErr.ForeColor = Color.Red;
                }
                else if (cbFromDe.Text == cbToDe.Text || cbFrom.Text == cbTo.Text)
                {
                    lbErr.Text = "Điểm đi và điểm đến không được trùng nhau.";
                    lbErr.ForeColor = Color.Red;
                }
                else if (new DAO_Airplane().getById(plane_id).NumberOfSeats < totalTicket)
                {
                    lbErr.Text = "Số vé không được lớn hơn tổng số ghế của máy bay";
                    lbErr.ForeColor = Color.Red;
                }
                else
                {
                    lbErr.Text = "";
                    int fromAirport = (int)cbFrom.SelectedValue;
                    int toAirport = (int)cbTo.SelectedValue;
                    flight = new Flight(0, cbFromDe.Text, cbToDe.Text, new DAO_Airport().getById(fromAirport), new DAO_Airport().getById(toAirport), dtpTime.Value, dtpTime.Value, dtpTime.Value, Int32.Parse(txtTotalTicket.Text), Int32.Parse(txtTotalTicket.Text), 0, new DAO_Airplane().getById(plane_id), "Hoạt động");
                    try
                    {
                        new DAO_Flight().add(flight);
                    }
                    catch (Exception exception)
                    {
                        lbErr.Text = "Có lỗi xảy ra, vui lòng thử lại!";
                        lbErr.ForeColor = Color.Red;
                    }
                    MessageBox.Show("Thêm chuyến bay thành công");
                    this.Close();
                    this.Hide();
                }
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (cbFromDe.Text.Length <= 0 || cbToDe.Text.Length <= 0 || cbFrom.Text.Length <= 0 || cbTo.Text.Length <= 0 || txtTotalTicket.TextLength <= 0 || cbAirplane.Text.Length <= 0)
            {
                lbErr.Text = "Vui lòng nhập đầy đủ thông tin.";
            }
            else
            {
                int plane_id = (int)cbAirplane.SelectedValue;
                int totalTicket = 0;
                try
                {
                    totalTicket = Int32.Parse(txtTotalTicket.Text);
                }
                catch (Exception ex)
                {
                    lbErr.Text = "Tổng số vé của chuyến bay phải là số nguyên không âm.";
                    lbErr.ForeColor = Color.Red;
                }
                if (!ValidationHelper.IsNonNegativeInteger(txtTotalTicket.Text))
                {
                    lbErr.Text = "Tổng số vé của chuyến bay phải là số nguyên không âm.";
                    lbErr.ForeColor = Color.Red;
                }
                else if (cbFromDe.Text == cbToDe.Text || cbFrom.Text == cbTo.Text)
                {
                    lbErr.Text = "Điểm đi và điểm đến không được trùng nhau.";
                    lbErr.ForeColor = Color.Red;
                }
                else if (new DAO_Airplane().getById(plane_id).NumberOfSeats < totalTicket)
                {
                    lbErr.Text = "Số vé không được lớn hơn tổng số ghế của máy bay";
                    lbErr.ForeColor = Color.Red;
                }
                else
                {
                    lbErr.Text = "";
                    int fromAirport = (int)cbFrom.SelectedValue;
                    int toAirport = (int)cbTo.SelectedValue;
                    flight.DeparturePoint = cbFromDe.Text;
                    flight.Destination = cbToDe.Text;
                    flight.DepartureAirport = new DAO_Airport().getById(fromAirport);
                    flight.DestinationAirport = new DAO_Airport().getById(toAirport);
                    flight.DepartureTime = dtpTime.Value;
                    flight.ArrivalTime = dtpTime.Value;
                    flight.TotalTickets = totalTicket;
                    flight.Airplane = new DAO_Airplane().getById(plane_id);
                    try
                    {
                        new DAO_Flight().update(flight);
                    }
                    catch (Exception exception)
                    {
                        lbErr.Text = "Có lỗi xảy ra, vui lòng thử lại!";
                        lbErr.ForeColor = Color.Red;
                    }
                    MessageBox.Show("Cập nhật thông tin chuyến bay thành công", "Thành công");
                    this.Close();
                    this.Hide();
                }
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            btnSave.BringToFront();
            cbFromDe.Enabled = true;
            cbFromDe.DataSource = Helper.LoadProvince();
            cbFromDe.SelectedItem = flight.DeparturePoint.ToString();
            cbToDe.Enabled = true;
            cbToDe.DataSource = Helper.LoadProvince();
            cbToDe.SelectedItem = flight.Destination.ToString();
            cbFrom.Enabled = true;
            cbTo.Enabled = true;
            dtpTime.Enabled = true;
            txtTotalTicket.Enabled = true;
            cbAirline.Enabled = true;
            cbAirplane.Enabled = true;
        }

        private void uiButton4_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }
        private void uiButton4_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void lbErr_Click(object sender, EventArgs e)
        {

        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            if (cbAirplane.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng chọn máy bay trước!");
            }
            else
            {
                int plane_id = (int)cbAirplane.SelectedValue;
                txtTotalTicket.Text = new DAO_Airplane().getById(plane_id).NumberOfSeats.ToString();
            }
        }

        private void cbToDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTo.DataSource = new DAO.DAO_Airport().getByCity(cbToDe.Text);
            cbTo.ValueMember = "AirportId";
            cbTo.DisplayMember = "AirportName";
        }

        private void cbFromDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbFrom.DataSource = new DAO.DAO_Airport().getByCity(cbFromDe.Text);
            cbFrom.ValueMember = "AirportId";
            cbFrom.DisplayMember = "AirportName";
        }
    }
}
