﻿using Sunny.UI.Demo.Views.NForm.Statistics;
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
            string selectedValue = cb_Chucnang.SelectedItem.ToString();
            if (selectedValue == "Thống kê khách hàng")
            {
                NForm.Statistics.Statistical_Customer SCForm = new NForm.Statistics.Statistical_Customer();
                SCForm.ShowDialog();
            }
            else if (selectedValue == "Thống kê chuyến bay")
            {
                NForm.Statistics.Statistical_Flight SFForm = new NForm.Statistics.Statistical_Flight();
                SFForm.ShowDialog();
            }
            else if (selectedValue == "Thống kê doanh số bán vé")
            {
                NForm.Statistics.Statistical_Ticket_Sales STSForm = new NForm.Statistics.Statistical_Ticket_Sales();
                STSForm.ShowDialog();
            }
            else if (selectedValue == "Thống kê lợi nhuận")
            {
                NForm.Statistics.Statistical_Profit SPForm = new NForm.Statistics.Statistical_Profit();
                SPForm.ShowDialog();
            }
        }
    }
}
