namespace Sunny.UI.Demo.Views.NForm.Flights.Transits
{
    partial class Add
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
            this.uiMarkLabel2 = new Sunny.UI.UIMarkLabel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbAirport = new Sunny.UI.UIComboBox();
            this.lbErr2 = new Sunny.UI.UILabel();
            this.cbProvince = new Sunny.UI.UIComboBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.lbErr = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiMarkLabel2
            // 
            this.uiMarkLabel2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiMarkLabel2.ForeColor = System.Drawing.Color.White;
            this.uiMarkLabel2.Location = new System.Drawing.Point(188, 31);
            this.uiMarkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiMarkLabel2.MarkColor = System.Drawing.Color.White;
            this.uiMarkLabel2.Name = "uiMarkLabel2";
            this.uiMarkLabel2.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.uiMarkLabel2.Size = new System.Drawing.Size(390, 81);
            this.uiMarkLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiMarkLabel2.TabIndex = 16;
            this.uiMarkLabel2.Text = "THÊM ĐIỂM QUÁ CẢNH";
            this.uiMarkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiMarkLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = global::Sunny.UI.Demo.Properties.Resources.download1;
            this.pbLogo.Location = new System.Drawing.Point(2, 3);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(183, 118);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 15;
            this.pbLogo.TabStop = false;
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton2.Location = new System.Drawing.Point(219, 361);
            this.uiButton2.Margin = new System.Windows.Forms.Padding(4);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(119, 50);
            this.uiButton2.TabIndex = 3;
            this.uiButton2.Text = "Thêm";
            this.uiButton2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(29, 31);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(279, 46);
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "Chọn tỉnh/thành phố:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton1.Location = new System.Drawing.Point(346, 361);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(4);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(119, 50);
            this.uiButton1.TabIndex = 1;
            this.uiButton1.Text = "Đóng";
            this.uiButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.cbAirport);
            this.panel1.Controls.Add(this.lbErr2);
            this.panel1.Controls.Add(this.cbProvince);
            this.panel1.Controls.Add(this.uiLabel3);
            this.panel1.Controls.Add(this.lbErr);
            this.panel1.Controls.Add(this.uiButton2);
            this.panel1.Controls.Add(this.uiLabel1);
            this.panel1.Controls.Add(this.uiButton1);
            this.panel1.Location = new System.Drawing.Point(6, 125);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 426);
            this.panel1.TabIndex = 14;
            // 
            // cbAirport
            // 
            this.cbAirport.DataSource = null;
            this.cbAirport.FillColor = System.Drawing.Color.White;
            this.cbAirport.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAirport.Location = new System.Drawing.Point(34, 226);
            this.cbAirport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbAirport.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbAirport.Name = "cbAirport";
            this.cbAirport.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbAirport.Size = new System.Drawing.Size(602, 52);
            this.cbAirport.TabIndex = 8;
            this.cbAirport.Text = "-- Chọn sân bay --";
            this.cbAirport.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbAirport.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // lbErr2
            // 
            this.lbErr2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErr2.Location = new System.Drawing.Point(35, 283);
            this.lbErr2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErr2.Name = "lbErr2";
            this.lbErr2.Size = new System.Drawing.Size(601, 33);
            this.lbErr2.TabIndex = 7;
            this.lbErr2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbErr2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbProvince
            // 
            this.cbProvince.DataSource = null;
            this.cbProvince.FillColor = System.Drawing.Color.White;
            this.cbProvince.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProvince.Location = new System.Drawing.Point(34, 82);
            this.cbProvince.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbProvince.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbProvince.Size = new System.Drawing.Size(602, 52);
            this.cbProvince.TabIndex = 5;
            this.cbProvince.Text = "-- Chọn tỉnh thành --";
            this.cbProvince.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbProvince.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.cbProvince.SelectedIndexChanged += new System.EventHandler(this.cbProvince_SelectedIndexChanged);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.Location = new System.Drawing.Point(29, 188);
            this.uiLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(279, 30);
            this.uiLabel3.TabIndex = 6;
            this.uiLabel3.Text = "Chọn sân bay quá cảnh:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // lbErr
            // 
            this.lbErr.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lbErr.Location = new System.Drawing.Point(35, 139);
            this.lbErr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErr.Name = "lbErr";
            this.lbErr.Size = new System.Drawing.Size(601, 33);
            this.lbErr.Style = Sunny.UI.UIStyle.Custom;
            this.lbErr.TabIndex = 4;
            this.lbErr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbErr.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(677, 555);
            this.Controls.Add(this.uiMarkLabel2);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UIMarkLabel uiMarkLabel2;
        private System.Windows.Forms.PictureBox pbLogo;
        private UIButton uiButton2;
        private UILabel uiLabel1;
        private UIButton uiButton1;
        private System.Windows.Forms.Panel panel1;
        private UILabel lbErr;
        private UIComboBox cbProvince;
        private UIComboBox cbAirport;
        private UILabel lbErr2;
        private UILabel uiLabel3;
    }
}