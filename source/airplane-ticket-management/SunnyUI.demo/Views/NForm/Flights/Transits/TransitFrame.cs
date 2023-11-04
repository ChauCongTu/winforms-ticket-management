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

namespace Sunny.UI.Demo.Views.NForm.Flights.Transits
{
    public partial class TransitFrame : Form
    {
        Flight flight;
        Transit transit;
        public TransitFrame(Flight flight)
        {
            InitializeComponent();
            this.flight = flight;
            lbFlight.Text = flight.DeparturePoint.ToString() + " - " + flight.Destination.ToString();
            lbTime.Text = flight.DepartureTime.Value.ToString("HH:mm dd/MM/yyyy");
            lbCode.Text = flight.Airplane.AirplaneNumber.ToString();
            if (flight.Transits > 0)
            {
                lbTransit.Text = "Chuyến sẽ quá cảnh " + flight.Transits.ToString() + " lần.";
                lbTransit.ForeColor = Color.Red;
            }
            else
            {
                lbTransit.Text = "Bay thẳng.";
                lbTransit.ForeColor = Color.Green;
            }
            table_load();
        }
        void table_load()
        {
            dgvTransit.Rows.Clear();
            DAO_Transit daoTransit = new DAO_Transit();
            List<Transit> transits = daoTransit.getByFlightId(flight.FlightId);
            foreach (Transit transit in transits)
            {
                dgvTransit.Rows.Add(transit.TransitId, transit.TransitAirport.AirportName, transit.TransitAirport.City);
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }

        private void dgvTransit_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvTransit.Rows[e.RowIndex];
            int id = 0;
            if (row.Cells[0].Value != null && ValidationHelper.IsNumber(row.Cells[0].Value.ToString()) == true)
            {
                id = (int)row.Cells[0].Value;
            }
            else
            {
                MessageBox.Show("Thao tác không hợp lệ, vui lòng thử lại!", "Lỗi");
                return;
            }
            if (e.ColumnIndex == dgvTransit.Columns["_xoa"].Index)
            {
                var result = MessageBox.Show("Bạn có chắc muốn xóa điểm quá cảnh này?",
                                                        "Xác nhận xóa",
                                                        MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow delRow = dgvTransit.Rows[e.RowIndex];
                    DAO_Transit daoTransit = new DAO_Transit();
                    try
                    {
                        daoTransit.delete(id);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại.", "Lỗi");
                        return;
                    }
                    MessageBox.Show("Xóa thành công", "Thành công");

                    table_load();
                }
                else
                {
                    table_load();
                }
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            Add addForm = new Add(flight);
            addForm.ShowDialog();
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            table_load();
        }

        private void TransitFrame_Load(object sender, EventArgs e)
        {
            if (flight.DepartureTime.Value < DateTime.Now)
            {
                uiButton2.Enabled = false;
                dgvTransit.Columns[3].Visible = false;
            }
        }
    }
}
