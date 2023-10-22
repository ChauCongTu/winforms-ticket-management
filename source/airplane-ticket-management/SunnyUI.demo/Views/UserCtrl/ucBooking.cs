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
    public partial class ucBooking : UserControl
    {
        private int flightId;
        public ucBooking()
        {
            InitializeComponent();
        }
        public ucBooking(int FlightId)
        {
            InitializeComponent();
            flightId = FlightId;
            txtFlightId.ReadOnly = true;
        }

        private void uiImageButton1_Click(object sender, EventArgs e)
        {
            string input = txtCCCD.Text;
            int number;
            uiButton2.SetDisabled();

            if (int.TryParse(input, out number))
            {
                DAO_Customer daoCustomer = new DAO_Customer();
                Customer customer = daoCustomer.getByCustomerID(txtCCCD.Text);
                if (customer.CustomerName != null)
                {
                    lbCheckCustomer.Text = "Khách hàng đã có thông tin: " + customer.CustomerName;
                    lbCheckCustomer.ForeColor = Color.Green;
                    uiButton2.SetEnabled();
                }
                else
                {
                    lbCheckCustomer.Text = "Khách hàng này chưa mua vé tại MixiVivu, hãy thêm thông tin khách hàng rồi thử lại.";
                    lbCheckCustomer.ForeColor = Color.Red;
                }
            }
            else
            {
                lbCheckCustomer.Text = "Số căn cước ở Việt Nam không bao gồm chữ!";
                lbCheckCustomer.ForeColor = Color.Red;
            }
            
        }

        private void ucBooking_Load(object sender, EventArgs e)
        {
            uiButton2.SetDisabled();
        }      

        private void txtFlightId_TextChanged(object sender, EventArgs e)
        {
            if (txtFlightId.Text.Length <= 0)
            {
                lbMsgFlight.Text = "Vui lòng nhập mã chuyến bay!";
                lbMsgFlight.ForeColor = Color.Red;
                return;
            }
            string input = txtFlightId.Text;

            if (int.TryParse(input, out flightId))
            {
                Flight flight = new DAO_Flight().getById(flightId);
                if (flight.Destination != null)
                {
                    DateTime now = DateTime.Now;
                    DateTime departureTime = flight.DepartureTime.Value;
                    if (now < departureTime)
                    {
                        lbMsgFlight.Text = "Chuyến bay: " + flight.Airplane.AirplaneNumber + "(" + flight.DeparturePoint + " - " + flight.Destination + ") (" + flight.DepartureTime.Value.ToString("HH:mm dd/MM/yyyy") + ")";
                        lbMsgFlight.ForeColor = Color.Green;
                    }
                    else
                    {
                        lbMsgFlight.Text = "Chuyến bay: " + flight.Airplane.AirplaneNumber + "(" + flight.DeparturePoint + " - " + flight.Destination + ") (" + flight.DepartureTime.Value.ToString("HH:mm dd/MM/yyyy") + ")";
                        lbMsgFlight.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lbMsgFlight.Text = "Không tìm thấy chuyến bay này! Vui lòng kiểm tra lại.";
                    lbMsgFlight.ForeColor = Color.Red;
                }
            }
            else
            {
                lbMsgFlight.Text = "Mã chuyến bay phải là số!";
                lbMsgFlight.ForeColor = Color.Red;
            }
        }
    }
}
