﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sunny.UI.Demo.DAO;
using Sunny.UI.Demo.Model;
using Sunny.UI.Demo.Views.UserCtrl;

namespace Sunny.UI.Demo.Views
{
    public partial class MainFrame : Form
    {
        User myProfile;
        public MainFrame()
        {
            InitializeComponent();
            myProfile = new DAO.DAO_User().getById(1);
        }

        public MainFrame(User loginUser)
        {
            InitializeComponent();
            myProfile = loginUser;
        }

        private void nmAside_MenuItemClick(TreeNode node, NavMenuItem item, int pageIndex)
        {
            if (node.Tag.ToString() == "QLH")
            {
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(new ucQuanLyHang());
            }
            else if (node.Tag.ToString() == "DV")
            {
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(new ucBooking());
            }
            else if (node.Tag.ToString() == "QLCB")
            {
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(new ucFlight());
            }
            else if (node.Tag.ToString() == "QLSB")
            {
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(new ucQuanLySanBay());
            }
            else if (node.Tag.ToString() == "QLMB")
            {
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(new ucQuanlymaybay());
            }
            else if (node.Tag.ToString() == "QLV")
            {
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(new ucTicket());
            }
            else if (node.Tag.ToString() == "QLNV")
            {
                if (myProfile.Role == "admin")
                {
                    mainPanel.Controls.Clear();
                    mainPanel.Controls.Add(new ucEmployee());
                }
                else
                {
                    MessageBox.Show("Bạn không đủ thẩm quyền để truy cập vào đây!", "Warning");
                }
            }
            else
            {
                mainPanel.Controls.Clear();
            }
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            txtName.Text = myProfile.UserName;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn thoát phiên làm việc?",
                                                        "Đăng xuất",
                                                        MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginFrame login = new LoginFrame();
                login.ShowDialog();
                this.Close();
            }
        }
    }
}
