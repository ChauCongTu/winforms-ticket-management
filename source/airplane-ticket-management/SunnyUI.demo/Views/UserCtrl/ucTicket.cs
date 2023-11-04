using Sunny.UI.Demo.DAO;
using Sunny.UI.Demo.Model;
using Sunny.UI.Demo.Views.NForm.Tickets;
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
    public partial class ucTicket : UserControl
    {
        Flight flight;
        int successSelection = 0;
        int flightId = 0;
        public ucTicket()
        {
            InitializeComponent();
            pnFlightSelection.BringToFront();
            cbClass.DataSource = new DAO_TicketClass().getAll();
            cbClass.ValueMember = "ClassId";
            cbClass.DisplayMember = "ClassType";
            btnBack.Enabled = false;
        }

        private void txtFlightId_TextChanged(object sender, EventArgs e)
        {
            successSelection = 0;
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
                        successSelection = 1;
                    }
                    else
                    {
                        lbMsgFlight.Text = "Chuyến bay: " + flight.Airplane.AirplaneNumber + "(" + flight.DeparturePoint + " - " + flight.Destination + ") (" + flight.DepartureTime.Value.ToString("HH:mm dd/MM/yyyy") + ")";
                        lbMsgFlight.ForeColor = Color.Red;
                        successSelection = 1;
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

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (successSelection == 1)
            {
                flight = new DAO_Flight().getById(flightId);
                pnMain.BringToFront();
                table_load(flight.FlightId);
                lbFlightInfo.Text = flight.Airplane.AirplaneNumber + "\n" + flight.DeparturePoint + " - " + flight.Destination + " | Lúc: " + flight.DepartureTime.Value.ToString("HH:mm dd/MM/yyyy");
                btnBack.Enabled = true;
                if (flight.DepartureTime.Value < DateTime.Now)
                {
                    uiButton3.Enabled = false;
                    dgvTicket.Columns[5].Visible = false;
                    dgvTicket.Columns[6].Visible = false;
                    dgvTicket.Columns[7].Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng kiểm tra lại!");
            }
        }
        void table_load(int flightId)
        {
            dgvTicket.Rows.Clear();
            List<Ticket> tickets = new DAO_Ticket().getTicketOfFlight(flightId);
            int index = 0;
            foreach (Ticket ticket in tickets)
            {
                dgvTicket.Rows.Add(++index, ticket.TicketId, ticket.ticketClass, Helper.FormatVietnameseCurrency(ticket.PriceVnd.ToString()), (!new DAO_Ticket().isSold(ticket.TicketId)) ? "Chưa bán" : "Đã bán");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnFlightSelection.BringToFront();
            btnBack.Enabled = false;
        }

        private void btnFiltByClass_Click(object sender, EventArgs e)
        {
            dgvTicket.Rows.Clear();
            List<Ticket> tickets = new List<Ticket>();
            try
            {
                tickets = new DAO_Ticket().getByClass(flightId, Int32.Parse(cbClass.SelectedValue.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            int index = 0;
            foreach (Ticket ticket in tickets)
            {
                dgvTicket.Rows.Add(++index, ticket.TicketId, ticket.ticketClass, Helper.FormatVietnameseCurrency(ticket.PriceVnd.ToString()), (!new DAO_Ticket().isSold(ticket.TicketId)) ? "Chưa bán" : "Đã bán");
            }
        }

        private void btnFiltByStatus_Click(object sender, EventArgs e)
        {
            dgvTicket.Rows.Clear();
            List<Ticket> tickets = new List<Ticket>();
            int isSold = 0;
            if (cbStatus.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn trình trạng vé muốn lọc!", "Lỗi");
                table_load(flightId);
                return;
            }
            if (cbStatus.SelectedItem.ToString() == "Đã bán")
            {
                isSold = 1;
            }
            else if (cbStatus.SelectedItem.ToString() == "Chưa bán")
            {
                isSold = 0;
            }
            else
            {
                MessageBox.Show("Thao tác không hợp lệ!" + cbStatus.SelectedValue.ToString(), "Lỗi");
            }
            try
            {
                tickets = new DAO_Ticket().getByStatus(flightId, isSold);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            int index = 0;
            foreach (Ticket ticket in tickets)
            {
                dgvTicket.Rows.Add(++index, ticket.TicketId, ticket.ticketClass, Helper.FormatVietnameseCurrency(ticket.PriceVnd.ToString()), (!new DAO_Ticket().isSold(ticket.TicketId)) ? "Chưa bán" : "Đã bán");
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            table_load(flightId);
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            add addForm = new add(flight);
            addForm.ShowDialog();
        }

        private void dgvTicket_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvTicket.Rows[e.RowIndex];
            int id = 0;
            if (row.Cells[1].Value != null && ValidationHelper.IsNumber(row.Cells[1].Value.ToString()) == true)
            {
                id = (int)row.Cells[1].Value;
            }
            else
            {
                MessageBox.Show("Thao tác không hợp lệ, vui lòng thử lại!", "Lỗi");
                return;
            }
            if (e.ColumnIndex == dgvTicket.Columns["_sua"].Index)
            {
                Ticket ticket = new DAO_Ticket().getById(id);
                edit editForm = new edit(ticket);
                editForm.ShowDialog();
            }
            if (e.ColumnIndex == dgvTicket.Columns["_order"].Index)
            {
                Ticket ticket = new DAO_Ticket().getById(id);
                new MainFrame().BookingTicket(ticket);
            }
            else if (e.ColumnIndex == dgvTicket.Columns["_xoa"].Index)
            {
                var result = MessageBox.Show("Bạn có chắc muốn xóa vé này không?\nLưu ý: bạn không thể xóa các vé đã được bán!",
                                                        "Xác nhận xóa",
                                                        MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow delRow = dgvTicket.Rows[e.RowIndex];
                    DAO_Ticket daoTicket = new DAO_Ticket();
                    try
                    {
                        daoTicket.delete(id);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại.", "Lỗi");
                        return;
                    }
                    MessageBox.Show("Xóa thành công!", "Thành công");

                    table_load(flight.FlightId);
                }
                else
                {
                    table_load(flight.FlightId);
                }
            }
        }

        private void ucTicket_Load(object sender, EventArgs e)
        {
        }
    }
}
