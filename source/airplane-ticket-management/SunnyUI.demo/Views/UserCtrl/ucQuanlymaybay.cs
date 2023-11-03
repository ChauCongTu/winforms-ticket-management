using Sunny.UI.Demo.DAO;
using Sunny.UI.Demo.Model;
using Sunny.UI.Demo.Views.NForm.Airplanes;
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
    public partial class ucQuanlymaybay : UserControl
    {
        public ucQuanlymaybay()
        {
            InitializeComponent();
        }
        void table_load()
        {
            dgvAirplanes.Rows.Clear();
            int i = 1;
            DAO_Airplane daoAirplane = new DAO_Airplane();
            List<Airplane> airplanes = daoAirplane.getAll();
            foreach (Airplane airplane in airplanes)
            {
                dgvAirplanes.Rows.Add(airplane.AirplaneId, airplane.AirplaneType, airplane.AirplaneNumber, airplane.NumberOfSeats, new DAO_Airline().getByPlaneId(airplane.AirplaneId).AirlineName);
            }    
           
        }

        private void ucQuanlymaybay_Load(object sender, EventArgs e)
        {
            table_load();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            table_load();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            add addForm = new add();
            addForm.ShowDialog();
        }

        private void dgvAirplanes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvAirplanes_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvAirplanes.Rows[e.RowIndex];
            int id = 0;
            try
            {
                id = (int)row.Cells[0].Value;
            }
            catch (Exception ex)
            {

            }
            if (e.ColumnIndex == dgvAirplanes.Columns["_sua"].Index)
            {
                Airplane airplane = new DAO_Airplane().getById(id);
                NForm.Airplanes.edit editForm = new NForm.Airplanes.edit(airplane);
                editForm.ShowDialog();
            }
            else if (e.ColumnIndex == dgvAirplanes.Columns["_xoa"].Index)
            {
                var result = MessageBox.Show("Bạn có chắc muốn xóa máy bay này?",
                                                        "Xác nhận xóa",
                                                        MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow delRow = dgvAirplanes.Rows[e.RowIndex];
                    DAO_Airplane daoAirplane = new DAO_Airplane();
                    try
                    {
                        daoAirplane.delete(id);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại.", "Lỗi");
                        return;
                    }
                    MessageBox.Show("Xóa máy bay thành công", "Thành công");

                    table_load();
                }
                else
                {
                    table_load();
                }
            }
        }

        private void uiImageButton1_Click(object sender, EventArgs e)
        {
            dgvAirplanes.Rows.Clear();
            int i = 1;
            DAO_Airplane daoAirplane = new DAO_Airplane();
            List <Airplane> airplanes = daoAirplane.GetByAirplaneNumb(txtSearch.Text);
            foreach (Airplane airplane in airplanes)
            {
                dgvAirplanes.Rows.Add(airplane.AirplaneId, airplane.AirplaneType, airplane.AirplaneNumber, airplane.NumberOfSeats, new DAO_Airline().getByPlaneId(airplane.AirplaneId).AirlineName);
            }

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text == "Nhập tìm kiếm")
                txtSearch.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if(txtSearch.Text.Length == 0)
                txtSearch.Text = "Nhập tìm kiếm";
        }
    }
}
