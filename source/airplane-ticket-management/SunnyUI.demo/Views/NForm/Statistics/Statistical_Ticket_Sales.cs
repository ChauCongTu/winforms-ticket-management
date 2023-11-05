using Sunny.UI.Demo.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sunny.UI.Demo.Views.NForm.Statistics
{
    public partial class Statistical_Ticket_Sales : Form
    {
        public Statistical_Ticket_Sales()
        {
            InitializeComponent();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            int economyCount = 0;
            int businessCount = 0;
            int firstClassCount = 0;

            DateTime startDate = Time_Start.Value;
            DateTime endDate = Time_End.Value;

            DAO_Statistical_Ticket_Sales dao = new DAO_Statistical_Ticket_Sales();
            DataTable dataTable = dao.GetTicketClass_MonthData(startDate, endDate);

            chart1.Series.Clear();
            chart1.Series.Add("Loại Vé");
            chart1.Series["Loại Vé"].Points.DataBind(dataTable.AsEnumerable(), "class_type", "ticket_count", "");
            chart1.Series["Loại Vé"].ChartType = SeriesChartType.Pie;

            foreach (DataRow row in dataTable.Rows)
            {
                string classType = row["class_type"].ToString();
                int ticketCount = Convert.ToInt32(row["ticket_count"]);

                if (classType == "Economy")
                {
                    economyCount = ticketCount;
                }
                else if (classType == "Business")
                {
                    businessCount = ticketCount;
                }
                else if (classType == "FirstClass")
                {
                    firstClassCount = ticketCount;
                }

            }

            lbl_Economy.Text = economyCount.ToString() +" vé";
            lbl_Business.Text = businessCount.ToString() + " vé";
            lbl_FirstClass.Text = firstClassCount.ToString() + " vé";
        }

        private void btn_Chon_Click(object sender, EventArgs e)
        {
            DateTime startDate;
            DateTime endDate = DateTime.Now;

            string selectedValue = cb_Thoigian.SelectedItem.ToString();
            if(selectedValue == "Hôm nay")
            {
                startDate = DateTime.Now.Date;

                int economyCount = 0;
                int businessCount = 0;
                int firstClassCount = 0;

                DAO_Statistical_Ticket_Sales dao = new DAO_Statistical_Ticket_Sales();
                DataTable dataTable = dao.GetTicketClass_MonthData(startDate, endDate);

                chart1.Series.Clear();
                chart1.Series.Add("Loại Vé");
                chart1.Series["Loại Vé"].Points.DataBind(dataTable.AsEnumerable(), "class_type", "ticket_count", "");
                chart1.Series["Loại Vé"].ChartType = SeriesChartType.Pie;

                foreach (DataRow row in dataTable.Rows)
                {
                    string classType = row["class_type"].ToString();
                    int ticketCount = Convert.ToInt32(row["ticket_count"]);

                    if (classType == "Economy")
                    {
                        economyCount = ticketCount;
                    }
                    else if (classType == "Business")
                    {
                        businessCount = ticketCount;
                    }
                    else if (classType == "FirstClass")
                    {
                        firstClassCount = ticketCount;
                    }

                }

                lbl_Economy.Text = economyCount.ToString() + " vé";
                lbl_Business.Text = businessCount.ToString() + " vé";
                lbl_FirstClass.Text = firstClassCount.ToString() + " vé";
            }
            else if(selectedValue == "Tuần trước")
            {
                startDate = endDate.AddDays(-7);

                int economyCount = 0;
                int businessCount = 0;
                int firstClassCount = 0;

                DAO_Statistical_Ticket_Sales dao = new DAO_Statistical_Ticket_Sales();
                DataTable dataTable = dao.GetTicketClass_MonthData(startDate, endDate);

                chart1.Series.Clear();
                chart1.Series.Add("Loại Vé");
                chart1.Series["Loại Vé"].Points.DataBind(dataTable.AsEnumerable(), "class_type", "ticket_count", "");
                chart1.Series["Loại Vé"].ChartType = SeriesChartType.Pie;

                foreach (DataRow row in dataTable.Rows)
                {
                    string classType = row["class_type"].ToString();
                    int ticketCount = Convert.ToInt32(row["ticket_count"]);

                    if (classType == "Economy")
                    {
                        economyCount = ticketCount;
                    }
                    else if (classType == "Business")
                    {
                        businessCount = ticketCount;
                    }
                    else if (classType == "FirstClass")
                    {
                        firstClassCount = ticketCount;
                    }

                }

                lbl_Economy.Text = economyCount.ToString() + " vé";
                lbl_Business.Text = businessCount.ToString() + " vé";
                lbl_FirstClass.Text = firstClassCount.ToString() + " vé";
            }
            else if(selectedValue == "Tháng trước")
            {
                startDate = endDate.AddMonths(-1);

                int economyCount = 0;
                int businessCount = 0;
                int firstClassCount = 0;              

                DAO_Statistical_Ticket_Sales dao = new DAO_Statistical_Ticket_Sales();
                DataTable dataTable = dao.GetTicketClass_MonthData(startDate, endDate);

                chart1.Series.Clear();
                chart1.Series.Add("Loại Vé");
                chart1.Series["Loại Vé"].Points.DataBind(dataTable.AsEnumerable(), "class_type", "ticket_count", "");
                chart1.Series["Loại Vé"].ChartType = SeriesChartType.Pie;

                foreach (DataRow row in dataTable.Rows)
                {
                    string classType = row["class_type"].ToString();
                    int ticketCount = Convert.ToInt32(row["ticket_count"]);

                    if (classType == "Economy")
                    {
                        economyCount = ticketCount;
                    }
                    else if (classType == "Business")
                    {
                        businessCount = ticketCount;
                    }
                    else if (classType == "FirstClass")
                    {
                        firstClassCount = ticketCount;
                    }

                }

                lbl_Economy.Text = economyCount.ToString() + " vé";
                lbl_Business.Text = businessCount.ToString() + " vé";
                lbl_FirstClass.Text = firstClassCount.ToString() + " vé";
            }
            else if(selectedValue == "3 Tháng trước")
            {
                startDate = endDate.AddMonths(-3);

                int economyCount = 0;
                int businessCount = 0;
                int firstClassCount = 0;

                DAO_Statistical_Ticket_Sales dao = new DAO_Statistical_Ticket_Sales();
                DataTable dataTable = dao.GetTicketClass_MonthData(startDate, endDate);

                chart1.Series.Clear();
                chart1.Series.Add("Loại Vé");
                chart1.Series["Loại Vé"].Points.DataBind(dataTable.AsEnumerable(), "class_type", "ticket_count", "");
                chart1.Series["Loại Vé"].ChartType = SeriesChartType.Pie;

                foreach (DataRow row in dataTable.Rows)
                {
                    string classType = row["class_type"].ToString();
                    int ticketCount = Convert.ToInt32(row["ticket_count"]);

                    if (classType == "Economy")
                    {
                        economyCount = ticketCount;
                    }
                    else if (classType == "Business")
                    {
                        businessCount = ticketCount;
                    }
                    else if (classType == "FirstClass")
                    {
                        firstClassCount = ticketCount;
                    }

                }

                lbl_Economy.Text = economyCount.ToString() + " vé";
                lbl_Business.Text = businessCount.ToString() + " vé";
                lbl_FirstClass.Text = firstClassCount.ToString() + " vé";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }
    }
}
