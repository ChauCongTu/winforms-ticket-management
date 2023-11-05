using Sunny.UI.Demo.DAO;
using Sunny.UI.Demo.Model;
using Sunny.UI.Demo.Views.NForm.Statistics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sunny.UI.Demo.Views.UserCtrl
{
    public partial class ucStatistical : UserControl
    {
        public ucStatistical()
        {
            InitializeComponent();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            
            
            if (cb_Chucnang.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn chức năng thống kê", "Lỗi");
            }
            else
            {
                string selectedValue = cb_Chucnang.SelectedItem.ToString();
                if (selectedValue == "Thống kê doanh số bán vé")
                {
                    NForm.Statistics.Statistical_Ticket_Sales STSForm = new NForm.Statistics.Statistical_Ticket_Sales();
                    STSForm.ShowDialog();
                }
                else if (selectedValue == "Thống kê doanh thu")
                {
                    NForm.Statistics.Statistical_Profit SPForm = new NForm.Statistics.Statistical_Profit();
                    SPForm.ShowDialog();
                }
            }
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            DAO_Statistical daoStatistical = new DAO_Statistical();

            int userCount = daoStatistical.getUser_Count();
            lbl_Nhanvien.Text = userCount.ToString();

            int customerCount = daoStatistical.getCustomer_Count();
            lbl_Khachhang.Text = customerCount.ToString();

            int flightCount = daoStatistical.getFlight_Count();
            lbl_Chuyenbay.Text = flightCount.ToString();

            int revenueCount = daoStatistical.getRevenue_Count();
            lbl_Doanhthu.Text = revenueCount.ToString();

        }

        private void ucStatistical_Load(object sender, EventArgs e)
        {
            DAO_Statistical daoStatistical = new DAO_Statistical();

            int userCount = daoStatistical.getUser_Count();
            lbl_Nhanvien.Text = userCount.ToString();

            int customerCount = daoStatistical.getCustomer_Count();
            lbl_Khachhang.Text = customerCount.ToString();

            int flightCount = daoStatistical.getFlight_Count();
            lbl_Chuyenbay.Text = flightCount.ToString();

            int revenueCount = daoStatistical.getRevenue_Count();
            lbl_Doanhthu.Text = Helper.FormatVND(revenueCount.ToString());

            int transactionCount = daoStatistical.getTicket_Count();
            lbTicket.Text = transactionCount.ToString();
        }

        private void uiPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
