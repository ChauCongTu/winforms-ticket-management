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
    public partial class edit : Form
    {
        User user;
        public edit()
        {
            InitializeComponent();
        }
        public edit(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void edit_Load(object sender, EventArgs e)
        {
            txtName.Text = user.UserName;
            txtEmail.Text = user.EmailAddress;
            cbRole.Text = user.Role;
            cbGender.SelectedItem= user.Gender;
            txtSDT.Text = user.PhoneNumber;
            cbStatus.SelectedItem = user.Status;
            rtxtAddress.Text = user.Address;

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {

            lbErrName.Text = string.Empty;
            lbErrEmail.Text = string.Empty;
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
                lbErrEmail.Text = "Vui lòng nhập đúng cú pháp. Ví dụ abc@gmail.com";
                lbErrEmail.ForeColor = Color.Red;
                err++;
            }

            if (txtSDT.Text.Length <= 0)
            {
                lbErrPhoneNumb.Text = "Vui lòng nhập Số điện thoại";
                lbErrPhoneNumb.ForeColor = Color.Red;
                err++;
            }
            else if (txtSDT.Text.Length <= 8 || txtSDT.Text.Length > 12)
            {
                lbErrPhoneNumb.Text = "Số điện thoại không phù hợp";
                lbErrPhoneNumb.ForeColor = Color.Red;
                err++;
            }
            if (rtxtAddress.Text.Length <= 0)
            {
                lbErrAddress.Text = "Vui lòng nhập Số hiệu máy bay";
                lbErrAddress.ForeColor = Color.Red;
                err++;
            }
            else if (rtxtAddress.Text.Length > 200)
            {
                lbErrAddress.Text = "Nhập quá ký tự giới hạn";
                lbErrAddress.ForeColor = Color.Red;
                err++;
            }
            if (err == 0)
            {
                user.UserName = txtName.Text;
                user.EmailAddress = txtEmail.Text;
                user.Role = cbRole.SelectedItem.ToString();
                user.Gender = cbGender.SelectedItem.ToString();
                user.PhoneNumber = txtSDT.Text;
                user.Status = cbStatus.Text;
                user.Address = rtxtAddress.Text;
                try
                {
                    new DAO_User().update(user);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thay đổi thông tin nhân viên không thành công!", "Lỗi");
                }

                MessageBox.Show("Thay đổi thành công ");
                this.Hide();
                this.Close();
            }
        }

        private void lbErrAddress_Click(object sender, EventArgs e)
        {

        }

        private void rtxtAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
