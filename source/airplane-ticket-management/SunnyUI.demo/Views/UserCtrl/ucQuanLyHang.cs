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
                Airline airline = new DAO_Airline().getById(id);
                NForm.Airlines.edit editForm = new NForm.Airlines.edit(airline);
                editForm.ShowDialog();
            }
            else
            {
                var result = MessageBox.Show("Bạn có chắc muốn xóa hãng hàng không này?",
                                                        "Xác nhận xóa",
                                                        MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow delRow = dgvAirlines.Rows[e.RowIndex];
                    DAO_Airline daoAirline = new DAO_Airline();
                    try
                    {
                        daoAirline.delete(id);
                    }
                    catch(Exception exception)
                    {
                        MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại.", "Lỗi");
                        return;
                    }
                    MessageBox.Show("Xóa thành công hãng hàng không", "Thành công");

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
            NForm.Airlines.add addForm = new NForm.Airlines.add();
            addForm.ShowDialog();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            table_load();
        }
    }
}
