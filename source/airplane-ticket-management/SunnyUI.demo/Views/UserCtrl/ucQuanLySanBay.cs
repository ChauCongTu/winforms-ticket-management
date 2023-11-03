using Sunny.UI.Demo.DAO;
using Sunny.UI.Demo.Model;
using Sunny.UI.Demo.Views.NForm.Airport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunny.UI.Demo.Views.UserCtrl
{
    public partial class ucQuanLySanBay : UserControl
    {
        public ucQuanLySanBay()
        {
            InitializeComponent();
        }
        void table_load()
        {
            dgvAirPort.Rows.Clear();
            int i = 1;
            DAO_Airport daoAirport = new DAO_Airport();
            List<Airport> airports = daoAirport.getAll();
            foreach (Airport airport in airports)
            {
                dgvAirPort.Rows.Add(airport.AirportId, airport.AirportName, airport.Address, airport.City, airport.Country);
            }    
        }
        private void ucQuanLySanBay_Load(object sender, EventArgs e)
        {
            table_load();
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            table_load();
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            add addForm = new add();
            addForm.ShowDialog();
        }

        private void dgvAirPort_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAirPort_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvAirPort.Rows[e.RowIndex];
            int id = 0;
            try
            {
                id = (int)row.Cells[0].Value;
            }
            catch (Exception ex)
            {

            }
            if (e.ColumnIndex == dgvAirPort.Columns["sua"].Index)
            {
                Airport airport = new DAO_Airport().getById(id);
                NForm.Airport.edit editForm = new NForm.Airport.edit(airport);
                editForm.ShowDialog();
            }
            else if (e.ColumnIndex == dgvAirPort.Columns["xoa"].Index)
            {
                var result = MessageBox.Show("Bạn có chắc muốn xóa sân bay này?",
                                                        "Xác nhận xóa",
                                                        MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow delRow = dgvAirPort.Rows[e.RowIndex];
                    DAO_Airport daoAirport = new DAO_Airport();
                    try
                    {
                        daoAirport.delete(id);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại.", "Lỗi");
                        return;
                    }
                    MessageBox.Show("Xóa sân bay thành công", "Thành công");

                    table_load();
                }
                else
                {
                    table_load();
                }
            }
        }

        private void uiImageButton2_Click(object sender, EventArgs e)
        {
            dgvAirPort.Rows.Clear();
            int i = 1;
            DAO_Airport daoAirport = new DAO_Airport();
            List<Airport> airports = daoAirport.findByName(txtTimKiem.Text);
            foreach (Airport airport in airports)
            {
                dgvAirPort.Rows.Add(airport.AirportId, airport.AirportName, airport.Address, airport.City, airport.Country);
            }

        }

        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Nhập tìm kiếm")
                txtTimKiem.Text = "";
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if(txtTimKiem.Text.Length == 0)
                txtTimKiem.Text = "Nhập tìm kiếm";
        }
    }
}
