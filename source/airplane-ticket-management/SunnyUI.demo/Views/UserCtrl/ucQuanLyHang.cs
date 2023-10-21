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
    public partial class ucQuanLyHang : UserControl
    {
        public ucQuanLyHang()
        {
            InitializeComponent();
        }
        void table_load()
        {
            dgvAirlines.Rows.Clear();
            int i = 1;
            DAO_Airline daoAirline = new DAO_Airline();
            List<Airline> airlines = daoAirline.getAll();
            foreach (Airline airline in airlines)
            {
                dgvAirlines.Rows.Add(airline.AirlineId, airline.AirlineName, airline.numbOfPlane);
            }
        }

        private void ucDatVe_Load(object sender, EventArgs e)
        {
            table_load();
        }

        private void dgvAirlines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvAirlines.Rows[e.RowIndex];
            int id = (int)row.Cells[0].Value;
            if (e.ColumnIndex == dgvAirlines.Columns["_sua"].Index)
            {
                MessageBox.Show("Chỉnh sửa hãng số: " + id);
            }
            else
            {
                MessageBox.Show("Xóa hãng số: "+ id);
            }
        }
    }
}
