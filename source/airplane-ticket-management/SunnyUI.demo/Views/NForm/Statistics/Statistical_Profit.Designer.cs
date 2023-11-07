namespace Sunny.UI.Demo.Views.NForm.Statistics
{
    partial class Statistical_Profit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.cb_Thoigian = new Sunny.UI.UIComboBox();
            this.btn_Chon = new Sunny.UI.UIButton();
            this.btn_XuatBC = new Sunny.UI.UIButton();
            this.uiMarkLabel2 = new Sunny.UI.UIMarkLabel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.Time_Start = new Sunny.UI.UIDatePicker();
            this.Time_End = new Sunny.UI.UIDatePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Load = new Sunny.UI.UIButton();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(7, 124);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 545);
            this.panel1.TabIndex = 16;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(194, 18);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Tháng";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(808, 511);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.Red;
            title1.Name = "Title1";
            title1.Text = "BIỂU ĐỒ LỢI NHUẬN";
            this.chart1.Titles.Add(title1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.uiLabel1);
            this.panel2.Controls.Add(this.cb_Thoigian);
            this.panel2.Controls.Add(this.btn_Chon);
            this.panel2.Controls.Add(this.btn_XuatBC);
            this.panel2.Location = new System.Drawing.Point(7, 673);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1166, 123);
            this.panel2.TabIndex = 17;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1049, 43);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 43);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Đóng";
            this.btnClose.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(120, 47);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(119, 33);
            this.uiLabel1.TabIndex = 6;
            this.uiLabel1.Text = "Thống kê:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cb_Thoigian
            // 
            this.cb_Thoigian.DataSource = null;
            this.cb_Thoigian.FillColor = System.Drawing.Color.White;
            this.cb_Thoigian.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Thoigian.Items.AddRange(new object[] {
            "Hôm nay",
            "Tuần trước",
            "Tháng trước",
            "3 Tháng trước"});
            this.cb_Thoigian.Location = new System.Drawing.Point(248, 43);
            this.cb_Thoigian.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cb_Thoigian.MinimumSize = new System.Drawing.Size(84, 0);
            this.cb_Thoigian.Name = "cb_Thoigian";
            this.cb_Thoigian.Padding = new System.Windows.Forms.Padding(0, 0, 40, 2);
            this.cb_Thoigian.Size = new System.Drawing.Size(287, 43);
            this.cb_Thoigian.TabIndex = 5;
            this.cb_Thoigian.Text = "Hôm nay";
            this.cb_Thoigian.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cb_Thoigian.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btn_Chon
            // 
            this.btn_Chon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Chon.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Chon.Location = new System.Drawing.Point(544, 43);
            this.btn_Chon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Chon.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Chon.Name = "btn_Chon";
            this.btn_Chon.Size = new System.Drawing.Size(133, 43);
            this.btn_Chon.TabIndex = 3;
            this.btn_Chon.Text = "Chọn";
            this.btn_Chon.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btn_Chon.Click += new System.EventHandler(this.btn_Chon_Click);
            // 
            // btn_XuatBC
            // 
            this.btn_XuatBC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_XuatBC.Enabled = false;
            this.btn_XuatBC.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatBC.Location = new System.Drawing.Point(877, 43);
            this.btn_XuatBC.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XuatBC.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_XuatBC.Name = "btn_XuatBC";
            this.btn_XuatBC.Size = new System.Drawing.Size(157, 43);
            this.btn_XuatBC.TabIndex = 2;
            this.btn_XuatBC.Text = "Xuất báo cáo";
            this.btn_XuatBC.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiMarkLabel2
            // 
            this.uiMarkLabel2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiMarkLabel2.ForeColor = System.Drawing.Color.White;
            this.uiMarkLabel2.Location = new System.Drawing.Point(177, 22);
            this.uiMarkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiMarkLabel2.MarkColor = System.Drawing.Color.White;
            this.uiMarkLabel2.Name = "uiMarkLabel2";
            this.uiMarkLabel2.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.uiMarkLabel2.Size = new System.Drawing.Size(308, 74);
            this.uiMarkLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiMarkLabel2.TabIndex = 18;
            this.uiMarkLabel2.Text = "THỐNG KÊ DOANH THU";
            this.uiMarkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiMarkLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.Time_Start);
            this.uiPanel1.Controls.Add(this.Time_End);
            this.uiPanel1.Controls.Add(this.label3);
            this.uiPanel1.Controls.Add(this.btn_Load);
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(618, 9);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(555, 110);
            this.uiPanel1.TabIndex = 19;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Time_Start
            // 
            this.Time_Start.DateFormat = "dd/MM/yyyy";
            this.Time_Start.FillColor = System.Drawing.Color.White;
            this.Time_Start.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_Start.Location = new System.Drawing.Point(8, 57);
            this.Time_Start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Time_Start.MaxLength = 10;
            this.Time_Start.MinimumSize = new System.Drawing.Size(63, 0);
            this.Time_Start.Name = "Time_Start";
            this.Time_Start.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.Time_Start.Size = new System.Drawing.Size(200, 35);
            this.Time_Start.SymbolDropDown = 61555;
            this.Time_Start.SymbolNormal = 61555;
            this.Time_Start.TabIndex = 27;
            this.Time_Start.Text = "05/11/2023";
            this.Time_Start.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Time_Start.Value = new System.DateTime(2023, 11, 5, 0, 0, 0, 0);
            this.Time_Start.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Time_End
            // 
            this.Time_End.DateFormat = "dd/MM/yyyy";
            this.Time_End.FillColor = System.Drawing.Color.White;
            this.Time_End.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_End.Location = new System.Drawing.Point(223, 57);
            this.Time_End.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Time_End.MaxLength = 10;
            this.Time_End.MinimumSize = new System.Drawing.Size(63, 0);
            this.Time_End.Name = "Time_End";
            this.Time_End.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.Time_End.Size = new System.Drawing.Size(200, 35);
            this.Time_End.SymbolDropDown = 61555;
            this.Time_End.SymbolNormal = 61555;
            this.Time_End.TabIndex = 26;
            this.Time_End.Text = "05/11/2023";
            this.Time_End.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Time_End.Value = new System.DateTime(2023, 11, 5, 0, 0, 0, 0);
            this.Time_End.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tùy chỉnh:";
            // 
            // btn_Load
            // 
            this.btn_Load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Load.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Load.Location = new System.Drawing.Point(434, 57);
            this.btn_Load.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(109, 35);
            this.btn_Load.TabIndex = 22;
            this.btn_Load.Text = "Thống kê";
            this.btn_Load.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = global::Sunny.UI.Demo.Properties.Resources.download1;
            this.pbLogo.Location = new System.Drawing.Point(9, 7);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(152, 107);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 20;
            this.pbLogo.TabStop = false;
            // 
            // Statistical_Profit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1178, 802);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.uiMarkLabel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Statistical_Profit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistical_Profit";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel2;
        private UIMarkLabel uiMarkLabel2;
        private UIButton btn_XuatBC;
        private UIButton btn_Chon;
        private UIPanel uiPanel1;
        private System.Windows.Forms.PictureBox pbLogo;
        private UIButton btn_Load;
        private UIDatePicker Time_Start;
        private UIDatePicker Time_End;
        private System.Windows.Forms.Label label3;
        private UIButton btnClose;
        private UILabel uiLabel1;
        private UIComboBox cb_Thoigian;
    }
}