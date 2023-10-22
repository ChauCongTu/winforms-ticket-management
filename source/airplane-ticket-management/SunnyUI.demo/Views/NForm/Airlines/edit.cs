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

namespace Sunny.UI.Demo.Views.NForm.Airlines
{
    public partial class edit : Form
    {
        Airline airline;
        public edit()
        {
            InitializeComponent();
        }
        public edit(Airline airline)
        {
            this.airline = airline;
            InitializeComponent();
        }

        private void edit_Load(object sender, EventArgs e)
        {
            txtName.Text = this.airline.AirlineName;
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            DAO_Airline daoAirline = new DAO_Airline();
            airline.AirlineName = txtName.Text;

            // Validation
            if (txtName.Text.Length < 1)
            {
                lbErr.Text = "Vui lòng nhập tên hãng hàng không";
                return;
            }

            if (daoAirline.update(airline) == true)
            {
                MessageBox.Show("Cập nhật hãng hàng không thành công", "Thành công");
                this.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại", "Lỗi");
            }
        }
    }
}
