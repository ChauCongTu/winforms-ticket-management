using Sunny.UI.Demo.DAO;
using Sunny.UI.Demo.Model;
using Sunny.UI.Demo.Views.NForm.Bookings;
using Sunny.UI.Demo.Views.NForm.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Sunny.UI.Demo.Views.UserCtrl
{
    public partial class ucBooking : UserControl
    {
        private Flight baseFlight;
        private Ticket baseTicket;
        private List<TicketShow> selectedTickets = new List<TicketShow>();
        private int flightId;
        private int errFlight = 1;
        private int errCustomer = 1;
        public ucBooking()
        {
            InitializeComponent();
        }
        public ucBooking(Flight Flight)
        {
            InitializeComponent();
            baseFlight = Flight;
            txtFlightId.ReadOnly = true;

        }

        public ucBooking(Ticket ticket)
        {
            InitializeComponent();
            baseTicket = ticket;
            txtFlightId.ReadOnly = true;
            cbClass.ReadOnly = true;
            cbTicket.ReadOnly = true;
        }


        private void ucBooking_Load(object sender, EventArgs e)
        {
            cbClass.DataSource = new DAO_TicketClass().getAll();
            cbClass.ValueMember = "ClassId";
            cbClass.DisplayMember = "ClassType";
            uiButton2.SetDisabled();
        }      

        private void txtFlightId_TextChanged(object sender, EventArgs e)
        {
            if (txtFlightId.Text.Length <= 0)
            {
                lbMsgFlight.Text = "Vui lòng nhập mã chuyến bay!";
                lbMsgFlight.ForeColor = Color.Red;
                errFlight++;
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
                        errFlight = 0;
                    }
                    else
                    {
                        lbMsgFlight.Text = "Chuyến bay: " + flight.Airplane.AirplaneNumber + "(" + flight.DeparturePoint + " - " + flight.Destination + ") (" + flight.DepartureTime.Value.ToString("HH:mm dd/MM/yyyy") + ")";
                        lbMsgFlight.ForeColor = Color.Red;
                        errFlight ++;
                    }
                }
                else
                {
                    lbMsgFlight.Text = "Không tìm thấy chuyến bay này! Vui lòng kiểm tra lại.";
                    lbMsgFlight.ForeColor = Color.Red;
                    errFlight++;
                }
            }
            else
            {
                lbMsgFlight.Text = "Mã chuyến bay phải là số!";
                lbMsgFlight.ForeColor = Color.Red;
                errFlight++;
            }
        }

        private void txtFlightId_Click(object sender, EventArgs e)
        {
            if (txtFlightId.Text == "Nhập ID chuyến bay")
                txtFlightId.Text = "";
        }

        private void txtFlightId_Leave(object sender, EventArgs e)
        {
            if (txtFlightId.Text.Length == 0)
                txtFlightId.Text = "Nhập ID chuyến bay";
        }

        private void txtCCCD_Leave(object sender, EventArgs e)
        {
            if (txtCCCD.Text.Length == 0)
                txtCCCD.Text = "Nhập số CCCD";
        }

        private void txtCCCD_Click(object sender, EventArgs e)
        {
            if (txtCCCD.Text == "Nhập số CCCD")
                txtCCCD.Text = "";
        }
        private int loadTicket(int inputFlightId, int inputClassId)
        {
            List<TicketShow> shows = new List<TicketShow>();
            List<Ticket> ticketList = new DAO_Ticket().getByFlightClass(inputClassId, inputFlightId);
            foreach (Ticket ticket in ticketList)
            {
                shows.Add(new TicketShow(ticket));
            }
            cbTicket.DataSource = shows;
            cbTicket.ValueMember = "TicketId";
            cbTicket.DisplayMember = "TicketDisplay";
            return shows.Count;
        }

        private void cbClass_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            string input = txtFlightId.Text;
            selectedTickets.Clear();

            if (int.TryParse(input, out flightId))
            {
                Flight flight = new DAO_Flight().getById(flightId);
                if (flight.Destination != null)
                {
                    DateTime now = DateTime.Now;
                    DateTime departureTime = flight.DepartureTime.Value;
                    if (now < departureTime)
                    {
                        int index = loadTicket(Int32.Parse(txtFlightId.Text), Int32.Parse(cbClass.SelectedValue.ToString()));
                        lbRemainTicket.Text = "(Còn "+index+" vé)";
                        if (index <= 0)
                        {
                            MessageBox.Show("Chuyến bay này đã hết vé hoặc đã khởi hành!\nHãy thử chọn vé hạng khác", "Không ổn rồi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chuyến bay này đã hết vé hoặc đã khởi hành!\nHãy thử chọn vé hạng khác", "Không ổn rồi");
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy chuyến bay này! Vui lòng kiểm tra lại.");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập id chuyến bay", "Có lỗi xảy ra");
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            DetailForm addForm = new DetailForm();
            addForm.ShowDialog();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            Customer customer = new DAO_Customer().getByIdNumber(txtCCCD.Text);
            if (customer.Gender == null)
            {
                MessageBox.Show("Thao tác không hợp lệ, hãy bấm vào biểu tượng kính lúp rồi thử lại!", "Có lỗi xảy ra");
                return;
            }
            DetailForm detailForm = new DetailForm(customer, "detail");
            detailForm.ShowDialog();
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            if (errCustomer != 0 || errFlight != 0)
            {
                MessageBox.Show("Khách hàng hoặc chuyến bay không hợp lệ", "Có lỗi xảy ra");
            }
            else if (cbTicket.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn vé cần đặt chỗ", "Có lỗi xảy ra");
            }
            else if (new DAO_Ticket().isSold(Int32.Parse(cbTicket.SelectedValue.ToString())))
            {
                MessageBox.Show("Vé này đã được đặt bởi một khách hàng khách!", "Có lỗi xảy ra");
            }
            else if (!new DAO_Ticket().checkLower9(txtCCCD.Text, Convert.ToInt32(txtFlightId.Text)))
            {
                MessageBox.Show("Mỗi khách hàng chỉ được mua tối đa 9 vé trong một chuyến bay", "Có lỗi xảy ra");
            }
            else
            {
                Customer customer = new DAO_Customer().getByIdNumber(txtCCCD.Text);
                Flight flight = new DAO_Flight().getById(Convert.ToInt32(txtFlightId.Text));
                string bookingCode = Helper.GenerateBookingCode();
                Transaction transaction = new Transaction(0, bookingCode, Convert.ToInt32(cbTicket.SelectedValue), customer, txtNote.Text, DateTime.Now, MainFrame.myProfile);
                try
                {
                    new DAO_Transaction().add(transaction);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại", "Có lỗi xảy ra");
                    return;
                }
                MessageBox.Show("Đặt chỗ thành công, mã đặt chỗ của bạn là: " + bookingCode + ".\nPhiếu đặt chỗ điện tử sẽ được gửi vào Email của bạn.", "Đặt vé thành công");
                NMailer.Send(customer.EmailAddress, "[MIXIVIVU] Vé Máy Bay Điện Tử - Mã Đặt Chỗ " + bookingCode, Helper.BookingTicketMailContent(new TransactionResponse(transaction)));
                int index = loadTicket(Int32.Parse(txtFlightId.Text), Int32.Parse(cbClass.SelectedValue.ToString()));
                lbRemainTicket.Text = "(Còn " + index + " vé)";
            }
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            string input = txtCCCD.Text;
            uiButton2.SetDisabled();

            if (!ValidationHelper.IsNonNegativeInteger(input))
            {
                lbCheckCustomer.Text = "Số căn cước ở Việt Nam không bao gồm chữ!";
                lbCheckCustomer.ForeColor = Color.Red;
                errCustomer++;
            }
            else
            {
                DAO_Customer daoCustomer = new DAO_Customer();
                Customer customer = daoCustomer.getByCustomerID(txtCCCD.Text);
                if (txtCCCD.TextLength != 12)
                {
                    lbCheckCustomer.Text = "Số căn cước ở Việt Nam phải có 12 số.";
                    lbCheckCustomer.ForeColor = Color.Red;
                    errCustomer++;
                }
                else if (customer.CustomerName != null)
                {
                    lbCheckCustomer.Text = "Khách hàng đã có thông tin: " + customer.CustomerName;
                    lbCheckCustomer.ForeColor = Color.Green;
                    uiButton2.SetEnabled();
                    errCustomer = 0;
                }
                else
                {
                    lbCheckCustomer.Text = "Khách hàng này chưa mua vé tại MixiVivu, hãy thêm thông tin khách hàng rồi thử lại.";
                    lbCheckCustomer.ForeColor = Color.Red;
                    errCustomer++;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

        private void btnTransactionManagement_Click(object sender, EventArgs e)
        {
            if (!ValidationHelper.IsNonNegativeInteger(txtFlightId.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại mã chuyến bay");
            }
            else
            {
                Flight flight = new DAO_Flight().getById(Convert.ToInt32(txtFlightId.Text));
                if (flight.Destination != null)
                {
                    List<Transaction> transactions = new DAO_Transaction().getByFlight(Convert.ToInt32(txtFlightId.Text));
                    List<TransactionResponse> responses = new List<TransactionResponse>();
                    foreach (Transaction transaction in transactions)
                    {
                        responses.Add(new TransactionResponse(transaction));
                    }
                    Transactions transactionForm = new Transactions(responses);
                    transactionForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại mã chuyến bay");
                }
            }
        }
    }
}
