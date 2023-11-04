namespace Sunny.UI.Demo.Views.NForm.Statistics
{
    partial class Statistical_Ticket_Sales
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.uiMarkLabel2 = new Sunny.UI.UIMarkLabel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btn_Load = new Sunny.UI.UIButton();
            this.Time_End = new Sunny.UI.UIDatetimePicker();
            this.Time_Start = new Sunny.UI.UIDatetimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Chon = new Sunny.UI.UIButton();
            this.btn_XuatBC = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.cb_Thoigian = new Sunny.UI.UIComboBox();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.uiGroupBox3 = new Sunny.UI.UIGroupBox();
            this.lbl_Economy = new Sunny.UI.UILabel();
            this.lbl_Business = new Sunny.UI.UILabel();
            this.lbl_FirstClass = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.uiGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(7, 4);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(830, 424);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.ForeColor = System.Drawing.Color.Red;
            title3.Name = "Title1";
            title3.Text = "BIỂU ĐỒ DOANH THU BÁN VÉ";
            this.chart1.Titles.Add(title3);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = global::Sunny.UI.Demo.Properties.Resources.download1;
            this.pbLogo.Location = new System.Drawing.Point(7, 6);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(114, 87);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 22;
            this.pbLogo.TabStop = false;
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
            this.uiMarkLabel2.TabIndex = 21;
            this.uiMarkLabel2.Text = "DOANH THU BÁN VÉ";
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
            this.uiPanel1.TabIndex = 23;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.uiPanel2);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(5, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 443);
            this.panel1.TabIndex = 24;
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
            this.panel2.TabIndex = 25;
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
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.uiGroupBox3);
            this.uiPanel2.Controls.Add(this.uiGroupBox2);
            this.uiPanel2.Controls.Add(this.uiGroupBox1);
            this.uiPanel2.Controls.Add(this.uiLabel2);
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(844, 6);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(272, 432);
            this.uiPanel2.TabIndex = 1;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.Location = new System.Drawing.Point(94, 9);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(90, 24);
            this.uiLabel2.TabIndex = 0;
            this.uiLabel2.Text = "Số lượng";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.lbl_Economy);
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(20, 58);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(233, 109);
            this.uiGroupBox1.TabIndex = 1;
            this.uiGroupBox1.Text = "Economy";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.lbl_Business);
            this.uiGroupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiGroupBox2.Location = new System.Drawing.Point(20, 177);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(233, 109);
            this.uiGroupBox2.TabIndex = 2;
            this.uiGroupBox2.Text = "Business";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Controls.Add(this.lbl_FirstClass);
            this.uiGroupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiGroupBox3.Location = new System.Drawing.Point(20, 296);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox3.Size = new System.Drawing.Size(233, 109);
            this.uiGroupBox3.TabIndex = 2;
            this.uiGroupBox3.Text = "First Class";
            this.uiGroupBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // lbl_Economy
            // 
            this.lbl_Economy.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Economy.Location = new System.Drawing.Point(17, 48);
            this.lbl_Economy.Name = "lbl_Economy";
            this.lbl_Economy.Size = new System.Drawing.Size(200, 35);
            this.lbl_Economy.TabIndex = 0;
            this.lbl_Economy.Text = "0";
            this.lbl_Economy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Economy.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // lbl_Business
            // 
            this.lbl_Business.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Business.Location = new System.Drawing.Point(17, 48);
            this.lbl_Business.Name = "lbl_Business";
            this.lbl_Business.Size = new System.Drawing.Size(200, 35);
            this.lbl_Business.TabIndex = 1;
            this.lbl_Business.Text = "0";
            this.lbl_Business.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Business.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // lbl_FirstClass
            // 
            this.lbl_FirstClass.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FirstClass.Location = new System.Drawing.Point(17, 48);
            this.lbl_FirstClass.Name = "lbl_FirstClass";
            this.lbl_FirstClass.Size = new System.Drawing.Size(200, 35);
            this.lbl_FirstClass.TabIndex = 2;
            this.lbl_FirstClass.Text = "0";
            this.lbl_FirstClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_FirstClass.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Statistical_Ticket_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1133, 652);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.uiMarkLabel2);
            this.Name = "Statistical_Ticket_Sales";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.uiPanel2.PerformLayout();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pbLogo;
        private UIMarkLabel uiMarkLabel2;
        private UIPanel uiPanel1;
        private UIButton btn_Load;
        private UIDatetimePicker Time_End;
        private UIDatetimePicker Time_Start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private UIButton btn_Chon;
        private UIButton btn_XuatBC;
        private UILabel uiLabel1;
        private UIComboBox cb_Thoigian;
        private UIPanel uiPanel2;
        private UIGroupBox uiGroupBox3;
        private UILabel lbl_FirstClass;
        private UIGroupBox uiGroupBox2;
        private UILabel lbl_Business;
        private UIGroupBox uiGroupBox1;
        private UILabel lbl_Economy;
        private UILabel uiLabel2;
    }
}