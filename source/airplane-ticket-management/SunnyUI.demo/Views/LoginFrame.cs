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

namespace Sunny.UI.Demo.Views
{
    public partial class LoginFrame : Form
    {
        int _showPass = 0;
        public LoginFrame()
        {
            InitializeComponent();
        }

        private void LoginFrame_Load(object sender, EventArgs e)
        {
            btnTooglePassword.BringToFront();
        }

        private void lbMsgEmail_Click(object sender, EventArgs e)
        {

        }

        private void lbForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Liên hệ bộ phận kỹ thuật để xác nhận lấy lại mật khẩu của bạn.", "Quên Mật Khẩu");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lbMsgEmail.Text = "";
            lbMsgPassword.Text = "";
            string usn = txtEmail.Text;
            string pwd = txtPassword.Text;

            if (usn.Length == 0)
            {
                lbMsgEmail.Text = "Địa chỉ Email không được để trống";
            }
            else if (Helper.IsEmail(usn) == false)
            {
                lbMsgEmail.Text = "Địa chỉ Email không hợp lệ";
            }
            else
            {
                User user = new DAO_User().getLogin(usn);
                if (user.EmailAddress != usn)
                {
                    lbMsgEmail.Text = "Địa chỉ Email không tồn tại";
                }
                else if (pwd.Length < 6)
                {
                    lbMsgPassword.Text = "Mật khẩu phải ít nhất 6 kí tự";
                }
                else if (Helper.GetMD5(pwd) != user.Password)
                {
                    lbMsgPassword.Text = "Mật khẩu không chính xác";
                }
                else
                {
                    this.Hide();
                    MainFrame main = new MainFrame(user);
                    main.ShowDialog();
                    this.Close();
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTooglePassword_Click(object sender, EventArgs e)
        {
            if (_showPass == 0)
            {
                txtPassword.PasswordChar = '*';
                _showPass = 1;
            }
            else
            {
                txtPassword.PasswordChar = '\0';
                _showPass = 0;
            }
        }
    }
}
