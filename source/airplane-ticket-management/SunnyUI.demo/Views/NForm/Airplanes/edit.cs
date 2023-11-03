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

namespace Sunny.UI.Demo.Views.NForm.Airplanes
{
    public partial class edit : Form
    {
        Airplane airplane;
        public edit()
        {
            InitializeComponent();
        }
        public edit(Airplane airplane)
        {
            this.airplane = airplane;
            InitializeComponent();
        }

        private void edit_Load(object sender, EventArgs e)
        {
            txtType.Text = airplane.AirplaneType;
            txtAirPlaneNumb.Text = airplane.AirplaneNumber;
            txtNumbOfSeats.Text = airplane.NumberOfSeats.ToString();
            cbHangMayBay.DataSource = new DAO_Airline().getAll();
            cbHangMayBay.ValueMember = "AirlineId";
            cbHangMayBay.DisplayMember = "AirlineName";
            cbHangMayBay.SelectedValue = new DAO_Airline().getByPlaneId(airplane.AirplaneId).AirlineId;
            rtbDescription.Text = airplane.Description;
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            lbErrType.Text = string.Empty;
            lbErrAirNumb.Text = string.Empty;
            lbErrNumbSeat.Text = string.Empty;
            lbErrDescr.Text = string.Empty;
            DAO_Airplane daoAirplane = new DAO_Airplane();
            int err = 0;
            //Validation
            if (txtType.Text.Length <= 0)
            {
                lbErrType.Text = "Vui lòng nhập Loại máy bay";
                lbErrType.ForeColor = Color.Red;
                err++;
            }
            else if (txtType.Text.Length > 20)
            {
                lbErrType.Text = "Nhập quá ký tự giới hạn ";
                lbErrType.ForeColor = Color.Red;
                err++;
            }

            if (txtNumbOfSeats.Text.Length <= 0)
            {
                lbErrNumbSeat.Text = "Vui lòng nhập Số lượng ghế";
                lbErrNumbSeat.ForeColor = Color.Red;
                err++;
            }
            else if (Int32.Parse(txtNumbOfSeats.Text) > 950 || Int32.Parse(txtNumbOfSeats.Text) < 10)
            {
                lbErrNumbSeat.Text = "Số lượng ghế không phù hợp";
                lbErrNumbSeat.ForeColor = Color.Red;
                err++;
            }
            if (txtAirPlaneNumb.Text.Length <= 0)
            {
                lbErrAirNumb.Text = "Vui lòng nhập Số hiệu máy bay";
                lbErrAirNumb.ForeColor = Color.Red;
                err++;
            }
            else if (txtAirPlaneNumb.Text.Length > 9)
            {
                lbErrAirNumb.Text = "Nhập quá ký tự giới hạn";
                lbErrAirNumb.ForeColor = Color.Red;
                err++;
            }
            else if (!ValidationHelper.IsPlaneCode(txtAirPlaneNumb.Text))
            {
                lbErrAirNumb.Text = "Vui lòng nhập đúng cú pháp. Ví dụ AZ-123456";
                lbErrAirNumb.ForeColor = Color.Red;
                err++;
            }
            if (rtbDescription.Text.Length <= 0)
            {
                lbErrDescr.Text = "Vui lòng nhập mô tả";
                lbErrDescr.ForeColor = Color.Red;
                err++;
            }
            if (err == 0)
            {
                airplane.AirplaneType = txtType.Text;
                airplane.Description = rtbDescription.Text;
                airplane.AirplaneNumber = txtAirPlaneNumb.Text;
                airplane.NumberOfSeats = Int32.Parse(txtNumbOfSeats.Text);
                try
                {
                    new DAO_Airplane().update(airplane);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chỉnh sửa thông tin máy bay không thành công!", "Lỗi");
                }

                MessageBox.Show("Thay đổi thông tin thành công ");
                this.Hide();
                this.Close();
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
