using Sunny.UI.Demo.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sunny.UI.Demo.Views.NForm.Statistics
{
    public partial class Statistical_Profit : Form
    {       

        public Statistical_Profit()
        {
            InitializeComponent();          

        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            DateTime startDate = Time_Start.Value;
            DateTime endDate = Time_End.Value;

            DAO_Statistical_Profit dao = new DAO_Statistical_Profit();
            DataTable dataTable = dao.GetTransaction_MonthData(startDate, endDate);

            chart1.Series.Clear();
            Series series = new Series("Doanh thu");
            series.ChartType = SeriesChartType.Column;

            foreach (DataRow row in dataTable.Rows)
            {
                int month = Convert.ToInt32(row["Tháng"]);
                double revenue = Convert.ToDouble(row["Doanh thu"]);
                series.Points.AddXY(month, revenue);
            }

            chart1.Series.Add(series);
            chart1.ChartAreas[0].AxisX.Title = "Tháng";
            chart1.ChartAreas[0].AxisY.Title = "Doanh thu";
        }


        private void btn_Chon_Click(object sender, EventArgs e)
        {
            DateTime startDate;
            DateTime endDate = DateTime.Now;

            string selectedValue = cb_Thoigian.SelectedItem.ToString();

            if (selectedValue == "Hôm nay")
            {
                startDate = DateTime.Now.Date;

                DAO_Statistical_Profit dao = new DAO_Statistical_Profit();
                DataTable dataTable = dao.GetTransaction_DayData(startDate, endDate);

                chart1.Series.Clear();
                Series series = new Series("Doanh thu");
                series.ChartType = SeriesChartType.Column;

                foreach (DataRow row in dataTable.Rows)
                {
                    int month = Convert.ToInt32(row["Ngày"]);
                    double revenue = Convert.ToDouble(row["Doanh thu"]);
                    series.Points.AddXY(month, revenue);
                }

                chart1.Series.Add(series);
                chart1.ChartAreas[0].AxisX.Title = "Ngày";
                chart1.ChartAreas[0].AxisY.Title = "Doanh thu";

            }
            else if (selectedValue == "Tuần trước")
            {
                startDate = endDate.AddDays(-7);

                DAO_Statistical_Profit dao = new DAO_Statistical_Profit();
                DataTable dataTable = dao.GetTransaction_DayData(startDate, endDate);

                chart1.Series.Clear();
                Series series = new Series("Doanh thu");
                series.ChartType = SeriesChartType.Column;

                foreach (DataRow row in dataTable.Rows)
                {
                    int month = Convert.ToInt32(row["Ngày"]);
                    double revenue = Convert.ToDouble(row["Doanh thu"]);
                    series.Points.AddXY(month, revenue);
                }

                chart1.Series.Add(series);
                chart1.ChartAreas[0].AxisX.Title = "Ngày";
                chart1.ChartAreas[0].AxisY.Title = "Doanh thu";


            }
            else if (selectedValue == "Tháng trước")
            {
                startDate = endDate.AddMonths(-1);

                DAO_Statistical_Profit dao = new DAO_Statistical_Profit();
                DataTable dataTable = dao.GetTransaction_MonthData(startDate, endDate);

                chart1.Series.Clear();
                Series series = new Series("Doanh thu");
                series.ChartType = SeriesChartType.Column;

                foreach (DataRow row in dataTable.Rows)
                {
                    int month = Convert.ToInt32(row["Tháng"]);
                    double revenue = Convert.ToDouble(row["Doanh thu"]);
                    series.Points.AddXY(month, revenue);
                }

                chart1.Series.Add(series);
                chart1.ChartAreas[0].AxisX.Title = "Tháng";
                chart1.ChartAreas[0].AxisY.Title = "Doanh thu";

            }
            else if (selectedValue == "3 Tháng trước")
            {
                startDate = endDate.AddMonths(-3);

                DAO_Statistical_Profit dao = new DAO_Statistical_Profit();
                DataTable dataTable = dao.GetTransaction_MonthData(startDate, endDate);

                chart1.Series.Clear();
                Series series = new Series("Doanh thu");
                series.ChartType = SeriesChartType.Column;

                foreach (DataRow row in dataTable.Rows)
                {
                    int month = Convert.ToInt32(row["Tháng"]);
                    double revenue = Convert.ToDouble(row["Doanh thu"]);
                    series.Points.AddXY(month, revenue);
                }

                chart1.Series.Add(series);
                chart1.ChartAreas[0].AxisX.Title = "Tháng";
                chart1.ChartAreas[0].AxisY.Title = "Doanh thu";

            }

        }

       
    }
}
