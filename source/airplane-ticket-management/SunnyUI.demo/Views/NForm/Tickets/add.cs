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

namespace Sunny.UI.Demo.Views.NForm.Tickets
{
    public partial class add : Form
    {
        Flight flight;
        int ticketCount;
        public add(Flight flight)
        {
            InitializeComponent();
            this.flight = flight;
            ticketCount = new DAO_Ticket().getTicketOfFlight(flight.FlightId).Count();
            lbNumTicketAlready.Text = ticketCount + "/" + flight.Airplane.NumberOfSeats;
            cbClass.DataSource = new DAO_TicketClass().getAll();
            cbClass.ValueMember = "ClassId";
            cbClass.DisplayMember = "ClassType";
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            int err = 0;
            lbErr.Text = "";
            lbErrPrice.Text = "";
            if (txtNumOfTicket.TextLength <= 0)
            {
                lbErr.Text = "Vui lòng nhập số lượng vé cần thêm.";
                lbErr.ForeColor = Color.Red;
                err++;
            }
            else if (!ValidationHelper.IsNonNegativeInteger(txtNumOfTicket.Text))
            {
                lbErr.Text = "Số lượng vé phải là số nguyên dương.";
                lbErr.ForeColor = Color.Red;
                err++;
            }
            else if (Int32.Parse(txtNumOfTicket.Text) + ticketCount > flight.Airplane.NumberOfSeats)
            {
                lbErr.Text = "Tổng số lượng vé không được lớn hơn số ghế ngồi của máy bay";
                err++;
            }

            if (txtPrice.TextLength <= 0)
            {
                lbErrPrice.Text = "Vui lòng nhập đơn giá.";
                lbErrPrice.ForeColor = Color.Red;
                err++;
            }
            else if (!ValidationHelper.IsNonNegativeInteger(txtPrice.Text))
            {
                lbErrPrice.Text = "Đơn giá phải là số nguyên dương.";
                lbErrPrice.ForeColor = Color.Red;
                err++;
            }
            if (err == 0)
            {
                int success = 0;
                Ticket ticket;
                for (int i = 0; i < Int32.Parse(txtNumOfTicket.Text); i++)
                {
                    ticket = new Ticket(0, flight.FlightId, Int32.Parse(txtPrice.Text), 0.0F, null, null, Int32.Parse(cbClass.SelectedValue.ToString()));
                    try
                    {
                        new DAO_Ticket().add(ticket);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi");
                        continue;
                    }
                    success++;
                }
                MessageBox.Show("Thêm thành công " + success + " vé cho chuyến bay #" + flight.FlightId);
                this.Close();
                this.Hide();
            }
        }
    }
}
