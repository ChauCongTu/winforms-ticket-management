using Sunny.UI.Demo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sunny.UI.Demo.Views.NForm.Flights.Transits
{
    public partial class Add : Form
    {
        Flight flight;
        public Add(Flight flight)
        {
            InitializeComponent();
            this.flight = flight;
        }

        private void Add_Load(object sender, EventArgs e)
        {
            cbProvince.DataSource = Helper.LoadProvince();
        }

        private void cbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbAirport.DataSource = new DAO.DAO_Airport().getByCity(cbProvince.Text);
            cbAirport.ValueMember = "AirportId";
            cbAirport.DisplayMember = "AirportName";
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            if (cbProvince.SelectedItem.ToString() == null)
            {
                lbErr.Text = "Vui lòng chọn Tỉnh Thành";
            }
            else if (cbAirport.SelectedValue == null)
            {
                lbErr2.Text = "Vui lòng chọn Sân Bay";
            }
            else if (cbProvince.SelectedItem.ToString() == flight.DeparturePoint || cbProvince.SelectedItem.ToString() == flight.Destination)
            {
                lbErr.Text = "Không thể quá cảnh cùng tỉnh/thành với điểm đi hoặc điểm đến.";
            }
            else if ((int)cbAirport.SelectedValue == flight.DepartureAirport.AirportId || (int)cbAirport.SelectedValue == flight.DestinationAirport.AirportId)
            {
                lbErr2.Text = "Không thể quá cảnh cùng sân bay với điểm đi hoặc điểm đến.";
            }
            else
            {
                int airportId = (int)cbAirport.SelectedValue;
                Transit transit = new Transit(0, new DAO.DAO_Airport().getById(airportId), flight.FlightId);
                try
                {
                    new DAO.DAO_Transit().add(transit);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Lỗi");
                    return;
                }
                MessageBox.Show("Thêm quá cảnh thành công, hãy load lại bảng lộ trình.", "Thành công");
                this.Close();
                this.Hide();
            }
        }
    }
}
