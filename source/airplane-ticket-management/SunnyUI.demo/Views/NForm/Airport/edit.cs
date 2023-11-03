using Sunny.UI.Demo.DAO;
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

namespace Sunny.UI.Demo.Views.NForm.Airport
{
    public partial class edit : Form
    {
        Model.Airport airports;
        public edit()
        {
            InitializeComponent();
        }
        public edit(Model.Airport airport)
        {
            this.airports = airport;
            InitializeComponent();
        }

        private void edit_Load(object sender, EventArgs e)
        {
            txtTenSanBay.Text = airports.AirportName;
            txtDiaChiSanBay.Text = airports.Address;
            cbCity.DataSource = Helper.LoadProvince();
            cbCity.SelectedItem = airports.City;
            cbCountry.SelectedItem = "Vietnam";

        }

        private void btnUpdateAirPort_Click(object sender, EventArgs e)
        {
            lbErrName.Text = string.Empty;
            lbErrAddress.Text = string.Empty;

            DAO_Airport airport = new DAO_Airport();
            int err = 0;
            //Validation
            if (txtTenSanBay.Text.Length <= 0)
            {
                lbErrName.Text = "Vui lòng nhập tên sân bay";
                lbErrName.ForeColor = Color.Red;
                err++;
            }
            else if (txtTenSanBay.Text.Length > 20)
            {
                lbErrName.Text = "Nhập quá ký tự giới hạn ";
                lbErrName.ForeColor = Color.Red;
                err++;
            }

            if (txtDiaChiSanBay.Text.Length <= 0)
            {
                lbErrAddress.Text = "Vui lòng nhập địa chỉ";
                lbErrAddress.ForeColor = Color.Red;
                err++;
            }
            else if (txtDiaChiSanBay.Text.Length > 50)
            {
                lbErrAddress.Text = "Nhập quá ký tự giới hạn ";
                lbErrAddress.ForeColor = Color.Red;
                err++;
            }
            if (err == 0)
            {
                airports.AirportName = txtTenSanBay.Text;
                airports.Address = txtDiaChiSanBay.Text;
                airports.City = cbCity.Text;
                airports.Country = cbCountry.Text;
                try
                {
                    new DAO_Airport().update(airports);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chỉnh sửa thông tin sân bay không thành công!", "Lỗi");
                }

                MessageBox.Show("Thay đổi thông tin thành công ");
                this.Hide();
                this.Close();
            }
        }
        private void btnCloseAirPort_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
