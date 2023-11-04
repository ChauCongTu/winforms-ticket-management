﻿namespace Sunny.UI.Demo.Views.NForm.Statistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Chon = new Sunny.UI.UIButton();
            this.btn_XuatBC = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.cb_Thoigian = new Sunny.UI.UIComboBox();
            this.uiMarkLabel2 = new Sunny.UI.UIMarkLabel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btn_Load = new Sunny.UI.UIButton();
            this.Time_End = new Sunny.UI.UIDatetimePicker();
            this.Time_Start = new Sunny.UI.UIDatetimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(5, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 443);
            this.panel1.TabIndex = 16;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(8, 4);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.LegendText = "Tháng";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1109, 415);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            title2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.Red;
            title2.Name = "Title1";
            title2.Text = "BIỂU ĐỒ LỢI NHUẬN";
            this.chart1.Titles.Add(title2);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_Chon);
            this.panel2.Controls.Add(this.btn_XuatBC);
            this.panel2.Controls.Add(this.uiLabel1);
            this.panel2.Controls.Add(this.cb_Thoigian);
            this.panel2.Location = new System.Drawing.Point(5, 547);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 100);
            this.panel2.TabIndex = 17;
            // 
            // btn_Chon
            // 
            this.btn_Chon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Chon.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btn_Chon.Location = new System.Drawing.Point(596, 28);
            this.btn_Chon.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Chon.Name = "btn_Chon";
            this.btn_Chon.Size = new System.Drawing.Size(100, 35);
            this.btn_Chon.TabIndex = 3;
            this.btn_Chon.Text = "Chọn";
            this.btn_Chon.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btn_Chon.Click += new System.EventHandler(this.btn_Chon_Click);
            // 
            // btn_XuatBC
            // 
            this.btn_XuatBC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_XuatBC.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btn_XuatBC.Location = new System.Drawing.Point(951, 32);
            this.btn_XuatBC.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_XuatBC.Name = "btn_XuatBC";
            this.btn_XuatBC.Size = new System.Drawing.Size(118, 32);
            this.btn_XuatBC.TabIndex = 2;
            this.btn_XuatBC.Text = "Xuất báo cáo";
            this.btn_XuatBC.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(215, 34);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(204, 27);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "Thời gian tùy chỉnh: ";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cb_Thoigian
            // 
            this.cb_Thoigian.DataSource = null;
            this.cb_Thoigian.FillColor = System.Drawing.Color.White;
            this.cb_Thoigian.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cb_Thoigian.Items.AddRange(new object[] {
            "Hôm nay",
            "Tuần trước",
            "Tháng trước",
            "3 Tháng trước"});
            this.cb_Thoigian.Location = new System.Drawing.Point(434, 32);
            this.cb_Thoigian.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_Thoigian.MinimumSize = new System.Drawing.Size(63, 0);
            this.cb_Thoigian.Name = "cb_Thoigian";
            this.cb_Thoigian.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cb_Thoigian.Size = new System.Drawing.Size(150, 29);
            this.cb_Thoigian.TabIndex = 0;
            this.cb_Thoigian.Text = "Hôm nay";
            this.cb_Thoigian.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cb_Thoigian.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiMarkLabel2
            // 
            this.uiMarkLabel2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiMarkLabel2.ForeColor = System.Drawing.Color.White;
            this.uiMarkLabel2.Location = new System.Drawing.Point(133, 18);
            this.uiMarkLabel2.MarkColor = System.Drawing.Color.White;
            this.uiMarkLabel2.Name = "uiMarkLabel2";
            this.uiMarkLabel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel2.Size = new System.Drawing.Size(134, 60);
            this.uiMarkLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiMarkLabel2.TabIndex = 18;
            this.uiMarkLabel2.Text = "LỢI NHUẬN";
            this.uiMarkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiMarkLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.btn_Load);
            this.uiPanel1.Controls.Add(this.Time_End);
            this.uiPanel1.Controls.Add(this.Time_Start);
            this.uiPanel1.Controls.Add(this.label3);
            this.uiPanel1.Controls.Add(this.label2);
            this.uiPanel1.Controls.Add(this.label1);
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(713, 8);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(416, 89);
            this.uiPanel1.TabIndex = 19;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btn_Load
            // 
            this.btn_Load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Load.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btn_Load.Location = new System.Drawing.Point(35, 51);
            this.btn_Load.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(72, 29);
            this.btn_Load.TabIndex = 22;
            this.btn_Load.Text = "Load";
            this.btn_Load.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // Time_End
            // 
            this.Time_End.FillColor = System.Drawing.Color.White;
            this.Time_End.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.Time_End.Location = new System.Drawing.Point(208, 50);
            this.Time_End.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Time_End.MaxLength = 19;
            this.Time_End.MinimumSize = new System.Drawing.Size(63, 0);
            this.Time_End.Name = "Time_End";
            this.Time_End.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.Time_End.Size = new System.Drawing.Size(200, 29);
            this.Time_End.SymbolDropDown = 61555;
            this.Time_End.SymbolNormal = 61555;
            this.Time_End.TabIndex = 21;
            this.Time_End.Text = "2023-12-01 20:13:11";
            this.Time_End.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Time_End.Value = new System.DateTime(2023, 12, 1, 20, 13, 11, 0);
            this.Time_End.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Time_Start
            // 
            this.Time_Start.FillColor = System.Drawing.Color.White;
            this.Time_Start.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.Time_Start.Location = new System.Drawing.Point(208, 11);
            this.Time_Start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Time_Start.MaxLength = 19;
            this.Time_Start.MinimumSize = new System.Drawing.Size(63, 0);
            this.Time_Start.Name = "Time_Start";
            this.Time_Start.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.Time_Start.Size = new System.Drawing.Size(200, 29);
            this.Time_Start.SymbolDropDown = 61555;
            this.Time_Start.SymbolNormal = 61555;
            this.Time_Start.TabIndex = 21;
            this.Time_Start.Text = "2023-01-01 20:09:48";
            this.Time_Start.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Time_Start.Value = new System.DateTime(2023, 1, 1, 20, 9, 48, 0);
            this.Time_Start.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thời gian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ: ";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = global::Sunny.UI.Demo.Properties.Resources.download1;
            this.pbLogo.Location = new System.Drawing.Point(7, 6);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(114, 87);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 20;
            this.pbLogo.TabStop = false;
            // 
            // Statistical_Profit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1133, 652);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.uiMarkLabel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Statistical_Profit";
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
        private UILabel uiLabel1;
        private UIComboBox cb_Thoigian;
        private UIButton btn_Chon;
        private UIPanel uiPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbLogo;
        private UIDatetimePicker Time_End;
        private UIDatetimePicker Time_Start;
        private UIButton btn_Load;
    }
}