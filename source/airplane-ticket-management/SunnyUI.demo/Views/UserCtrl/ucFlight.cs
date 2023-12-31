﻿using Sunny.UI.Demo.DAO;
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
                dgvFlight.Rows.Add(flight.FlightId, flight.DeparturePoint, flight.Destination, flight.DepartureTime.Value.ToString("dd/MM/yyyy"), flight.DepartureTime.Value.ToString("HH:mm"), Helper.FormatVND(new DAO_Ticket().getPriceByPlane(flight.Airplane.AirplaneId).ToString()) +"đ");
            }
        }

        private void ucFlight_Load(object sender, EventArgs e)
        {
            cbFrom.DataSource = Helper.LoadProvince();
            cbTo.DataSource = Helper.LoadProvince();
            cbTo.SelectedItem = "Ho Chi Minh City";
            table_load();
        }

        private void dgvFlight_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            NForm.Flights.ShowDetail detail = new NForm.Flights.ShowDetail();
            detail.ShowDialog();
        }

        private void dgvFlight_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvFlight.Rows[e.RowIndex];
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
            if (e.ColumnIndex == dgvFlight.Columns["_detail"].Index)
            {
                Flight flight = new DAO_Flight().getById(id);
                NForm.Flights.ShowDetail detail = new NForm.Flights.ShowDetail(flight);
                detail.ShowDialog();
            }
            else if (e.ColumnIndex == dgvFlight.Columns["_quacanh"].Index)
            {
                Flight flight = new DAO_Flight().getById(id);
                NForm.Flights.Transits.TransitFrame detail = new NForm.Flights.Transits.TransitFrame(flight);
                detail.ShowDialog();
            }
            else if (e.ColumnIndex == dgvFlight.Columns["_xoa"].Index)
            {
                var result = MessageBox.Show("Bạn có chắc muốn xóa chuyến bay này?",
                                                        "Xác nhận xóa",
                                                        MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow delRow = dgvFlight.Rows[e.RowIndex];
                    DAO_Flight daoFlight = new DAO_Flight();
                    try
                    {
                        daoFlight.delete(id);
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

        private void uiButton1_Click(object sender, EventArgs e)
        {
            table_load();
        }

        private void uiImageButton2_Click(object sender, EventArgs e)
        {
            if (cbFrom.Text.Length <= 0 || cbTo.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng chọn điểm đi và điểm đến");
                return;
            }
            dgvFlight.Rows.Clear();
            DAO_Flight daoFlight = new DAO_Flight();
            List<Flight> flights = daoFlight.getByRoute(cbFrom.Text, cbTo.Text,dpDateArrive.Value.ToString("yyyy-MM-dd"));
            if (flights.Count > 0)
            {
                MessageBox.Show("Tìm thấy "+ flights.Count + " chuyến bay từ " + cbFrom.Text + " - " + cbTo.Text + " vào ngày " + dpDateArrive.Value.ToString("dd/MM/yyyy"));
            }
            else
            {
                MessageBox.Show("Không tìm thấy chuyến bay nào từ " + cbFrom.Text + " - " + cbTo.Text + " vào ngày " + dpDateArrive.Value.ToString("dd/MM/yyyy"));
            }
            foreach (Flight flight in flights)
            {
                dgvFlight.Rows.Add(flight.FlightId, flight.DeparturePoint, flight.Destination, flight.DepartureTime.Value.ToString("dd/MM/yyyy"), flight.DepartureTime.Value.ToString("HH:mm"), Helper.FormatVND(new DAO_Ticket().getPriceByPlane(flight.Airplane.AirplaneId).ToString()) + "đ");
            }
        }
    }
}
