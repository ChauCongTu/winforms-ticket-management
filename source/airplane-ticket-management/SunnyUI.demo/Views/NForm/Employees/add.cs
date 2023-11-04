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

namespace Sunny.UI.Demo.Views.NForm.Employees
{
    public partial class add : Form
    {
        User user;
        public add()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            lbErrName.Text = string.Empty;
            lbErrEmail.Text = string.Empty;
            lbErrPassword.Text = string.Empty;
            lbErrPhoneNumb.Text = string.Empty;
            lbErrAddress.Text = string.Empty;

            DAO_User daoUser = new DAO_User();
            int err = 0;
            //Validation
            if (txtName.Text.Length <= 0)
            {
                lbErrName.Text = "Vui lòng nhập Tên nhân viên";
                lbErrName.ForeColor = Color.Red;
                err++;
            }
            else if (txtName.Text.Length > 100)
            {
                lbErrName.Text = "Nhập quá ký tự giới hạn ";
                lbErrName.ForeColor = Color.Red;
                err++;
            }

            if (txtEmail.Text.Length <= 0)
            {
                lbErrEmail.Text = "Vui lòng nhập Email";
                lbErrEmail.ForeColor = Color.Red;
                err++;
            }
            else if (txtEmail.Text.Length > 100)
            {
                lbErrEmail.Text = "Nhập quá ký tự giới hạn ";
                lbErrEmail.ForeColor = Color.Red;
                err++;
            }
            else if (!ValidationHelper.IsEmail(txtEmail.Text))
            {
                lbErrEmail.Text = "Vui lòng nhập đúng cú pháp (vd: abc@gmail.com)";
                lbErrEmail.ForeColor = Color.Red;
                err++;
            }

            if (txtPassword.Text.Length <= 0)
            {
                lbErrPassword.Text = "Vui lòng nhập Mật khẩu";
                lbErrPassword.ForeColor = Color.Red;
                err++;
            }
            else if (txtPassword.Text.Length > 100)
            {
                lbErrPassword.Text = "Nhập quá ký tự giới hạn ";
                lbErrPassword.ForeColor = Color.Red;
                err++;
            }

            if (txtSDT.Text.Length <= 0)
            {
                lbErrPhoneNumb.Text = "Vui lòng nhập Số điện thoại";
                lbErrPhoneNumb.ForeColor = Color.Red;
                err++;
            }
            else if (txtSDT.Text.Length <=8 || txtSDT.Text.Length > 11)
            {
                lbErrPhoneNumb.Text = "Số điện thoại không phù hợp";
                lbErrPhoneNumb.ForeColor = Color.Red;
                err++;
            }
            if (rtxtAddress.Text.Length <= 0)
            {
                lbErrAddress.Text = "Vui lòng nhập Địa chỉ";
                lbErrAddress.ForeColor = Color.Red;
                err++;
            }
            else if (rtxtAddress.Text.Length > 100)
            {
                lbErrAddress.Text = "Nhập quá ký tự giới hạn";
                lbErrAddress.ForeColor = Color.Red;
                err++;
            }
            if (err == 0)
            {
                user = new User(0, txtName.Text, txtEmail.Text, Helper.GetMD5(txtPassword.Text), cbRole.Text, cbGender.Text, txtSDT.Text, rtxtAddress.Text, cbStatus.Text);
                try
                {
                    new DAO_User().add(user);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm nhân viên không thành công!", "Lỗi");
                }

                MessageBox.Show("Thêm nhân viên thành công");
                this.Hide();
                this.Close();
            }
        }

        private void add_Load(object sender, EventArgs e)
        {
            rtxtAddress.Text = "";

        }
    }
}
