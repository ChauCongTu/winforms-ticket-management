using Sunny.UI.Demo.DAO;
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
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            DAO_Airline daoAirline = new DAO_Airline();

            // Validation
            if (txtName.Text.Length < 3)
            {
                lbErr.Text = "Vui lòng nhập tên hãng hàng không";
                return;
            }

            if (daoAirline.add(new Model.Airline(0, txtName.Text, 0)) == true)
            {
                MessageBox.Show("Thêm hãng hàng không thành công", "Thành công");
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
