using System;
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
        public static User myProfile;
        public MainFrame()
        {
            InitializeComponent();
            myProfile = new DAO.DAO_User().getById(1);
            nmAside.Nodes.Add("QLKH", "Thông tin Khách hàng");
            nmAside.Nodes[8].Tag = "QLKH";
        }

        public MainFrame(User loginUser)
        {
            InitializeComponent();
            myProfile = loginUser;
            nmAside.Nodes.Add("QLKH", "Quản lý khách hàng");
            nmAside.Nodes[8].Tag = "QLKH";
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
            else if (node.Tag.ToString() == "BCTK")
            {
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(new ucStatistical());
            }
            else if (node.Tag.ToString() == "QLV")
            {
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(new ucTicket());
            }
            else if (node.Tag.ToString() == "QLKH")
            {
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(new ucCustomer());
            }
            else if (node.Tag.ToString() == "QLNV")
            {
                if (myProfile.Role == "admin")
                {
                    mainPanel.Controls.Clear();
                    mainPanel.Controls.Add(new ucTicket());
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

        public void BookingTicket(Flight flight)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new ucBooking(flight));
        }

        public void BookingTicket(Ticket ticket)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new ucBooking(ticket));
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
