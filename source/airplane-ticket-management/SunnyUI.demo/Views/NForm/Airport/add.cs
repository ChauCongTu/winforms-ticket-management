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
    public partial class add : Form
    {
        Model.Airport airport;
        public add()
        {
            InitializeComponent();
        }

        private void uiLabel5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddAirPort_Click(object sender, EventArgs e)
        {
            lbErrName.Text = string.Empty;
            lbErrDC.Text = string.Empty;
            DAO_Airport daoAirport = new DAO_Airport();
            int err = 0;
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
                lbErrDC.Text = "Vui lòng nhập Địa chỉ sân bay";
                lbErrDC.ForeColor = Color.Red;
                err++;
            }
            else if (txtDiaChiSanBay.Text.Length > 50)
            {
                lbErrDC.Text = "Nhập quá ký tự giới hạn ";
                lbErrDC.ForeColor = Color.Red;
                err++;
            }
            if (err == 0)
            {
                airport = new Model.Airport(0, txtTenSanBay.Text, Helper.GetCoordinates(txtDiaChiSanBay.Text + cbCity.Text), txtDiaChiSanBay.Text, cbCity.Text, cbCountry.Text);
                try
                {
                    new DAO_Airport().add(airport);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm thông tin sân bay không thành công!", "Lỗi");
                }

                MessageBox.Show("Thêm sân bay thành công ");
                this.Hide();
                this.Close();
            }

        }

        private void btnCloseAirPort_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void add_Load(object sender, EventArgs e)
        {
            cbCity.DataSource = Helper.LoadProvince();

            cbCountry.Text = "Vietnam";
        }
    }
}
