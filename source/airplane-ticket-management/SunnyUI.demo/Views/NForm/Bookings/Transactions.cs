using Sunny.UI.Demo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunny.UI.Demo.Views.NForm.Bookings
{
    public partial class Transactions : Form
    {
        List<TransactionResponse> response;
        public Transactions(List<TransactionResponse> response)
        {
            InitializeComponent();
            this.response = response;
            if (response.Count > 0)
            {
                lbFrom.Text = response[0].flight.DeparturePoint.ToString();
                lbTo.Text = response[0].flight.Destination.ToString();
                lbDate.Text = response[0].flight.DepartureTime.Value.ToString("dd/MM/yyyy");
                lbHour.Text = response[0].flight.DepartureTime.Value.ToString("HH:mm");
                lbCode.Text = response[0].flight.Airplane.AirplaneNumber;
            }
            this.tableLoad();
        }

        private void tableLoad()
        {
            dgvTransaction.Rows.Clear();
            int i = 1;
            foreach (TransactionResponse response in response)
            {
                dgvTransaction.Rows.Add(i++, response.customer.CustomerName, response.Ticket.ticketClass, response.BookingDate.ToString("HH:mm dd/MM/yyyy"), response.Performed.UserName);
            }
        }

        private void dgvAirlines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uiMarkLabel1_Click(object sender, EventArgs e)
        {

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            this.tableLoad();
        }

        private void uiImageButton1_Click(object sender, EventArgs e)
        {
            if (txtSearch.TextLength <= 0 || txtSearch.Text == "Nhập mã đặt chỗ")
            {
                MessageBox.Show("Vui lòng nhập mã đặt chỗ để tra cứu!");
            }
            else
            {
                dgvTransaction.Rows.Clear();
                int i = 1;
                List<TransactionResponse> responseSearched = new List<TransactionResponse>();
                List<Transaction> transactions = new DAO.DAO_Transaction().getByBookingCode(txtSearch.Text);
                foreach (Transaction transaction in transactions)
                {
                    responseSearched.Add(new TransactionResponse(transaction));
                }
                foreach (TransactionResponse response in responseSearched)
                {
                    dgvTransaction.Rows.Add(i++, response.customer.CustomerName, response.Ticket.ticketClass, response.BookingDate.ToString("HH:mm dd/MM/yyyy"), response.Performed.UserName);
                }
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 0)
                txtSearch.Text = "Nhập mã đặt chỗ";
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Nhập mã đặt chỗ")
                txtSearch.Text = "";
        }
    }
}
