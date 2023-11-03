namespace Sunny.UI.Demo.Views.NForm.Airport
{
    partial class add
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbCountry = new Sunny.UI.UIComboBox();
            this.cbCity = new Sunny.UI.UIComboBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.lbErrDC = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.txtDiaChiSanBay = new Sunny.UI.UITextBox();
            this.lbErrName = new Sunny.UI.UILabel();
            this.btnAddAirPort = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.btnCloseAirPort = new Sunny.UI.UIButton();
            this.txtTenSanBay = new Sunny.UI.UITextBox();
            this.uiMarkLabel2 = new Sunny.UI.UIMarkLabel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.cbCountry);
            this.panel1.Controls.Add(this.cbCity);
            this.panel1.Controls.Add(this.uiLabel7);
            this.panel1.Controls.Add(this.uiLabel5);
            this.panel1.Controls.Add(this.lbErrDC);
            this.panel1.Controls.Add(this.uiLabel3);
            this.panel1.Controls.Add(this.txtDiaChiSanBay);
            this.panel1.Controls.Add(this.lbErrName);
            this.panel1.Controls.Add(this.btnAddAirPort);
            this.panel1.Controls.Add(this.uiLabel1);
            this.panel1.Controls.Add(this.btnCloseAirPort);
            this.panel1.Controls.Add(this.txtTenSanBay);
            this.panel1.Location = new System.Drawing.Point(6, 128);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 649);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbCountry
            // 
            this.cbCountry.DataSource = null;
            this.cbCountry.FillColor = System.Drawing.Color.White;
            this.cbCountry.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCountry.Items.AddRange(new object[] {
            "Vietnam"});
            this.cbCountry.Location = new System.Drawing.Point(34, 520);
            this.cbCountry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCountry.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbCountry.ReadOnly = true;
            this.cbCountry.Size = new System.Drawing.Size(615, 46);
            this.cbCountry.TabIndex = 15;
            this.cbCountry.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbCountry.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbCity
            // 
            this.cbCity.DataSource = null;
            this.cbCity.FillColor = System.Drawing.Color.White;
            this.cbCity.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCity.Location = new System.Drawing.Point(34, 385);
            this.cbCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCity.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbCity.Name = "cbCity";
            this.cbCity.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbCity.Size = new System.Drawing.Size(615, 46);
            this.cbCity.TabIndex = 14;
            this.cbCity.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbCity.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel7.Location = new System.Drawing.Point(30, 476);
            this.uiLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(163, 39);
            this.uiLabel7.TabIndex = 12;
            this.uiLabel7.Text = "Quốc Gia: ";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel7.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.Location = new System.Drawing.Point(30, 338);
            this.uiLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(163, 39);
            this.uiLabel5.TabIndex = 9;
            this.uiLabel5.Text = "Thành Phố: ";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiLabel5.Click += new System.EventHandler(this.uiLabel5_Click);
            // 
            // lbErrDC
            // 
            this.lbErrDC.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrDC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lbErrDC.Location = new System.Drawing.Point(35, 291);
            this.lbErrDC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErrDC.Name = "lbErrDC";
            this.lbErrDC.Size = new System.Drawing.Size(615, 26);
            this.lbErrDC.Style = Sunny.UI.UIStyle.Custom;
            this.lbErrDC.TabIndex = 7;
            this.lbErrDC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbErrDC.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.Location = new System.Drawing.Point(29, 183);
            this.uiLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(117, 39);
            this.uiLabel3.TabIndex = 6;
            this.uiLabel3.Text = "Địa chỉ: ";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtDiaChiSanBay
            // 
            this.txtDiaChiSanBay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChiSanBay.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiSanBay.Location = new System.Drawing.Point(35, 238);
            this.txtDiaChiSanBay.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDiaChiSanBay.MinimumSize = new System.Drawing.Size(1, 20);
            this.txtDiaChiSanBay.Name = "txtDiaChiSanBay";
            this.txtDiaChiSanBay.ShowText = false;
            this.txtDiaChiSanBay.Size = new System.Drawing.Size(615, 46);
            this.txtDiaChiSanBay.TabIndex = 5;
            this.txtDiaChiSanBay.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDiaChiSanBay.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // lbErrName
            // 
            this.lbErrName.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lbErrName.Location = new System.Drawing.Point(35, 139);
            this.lbErrName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErrName.Name = "lbErrName";
            this.lbErrName.Size = new System.Drawing.Size(615, 26);
            this.lbErrName.Style = Sunny.UI.UIStyle.Custom;
            this.lbErrName.TabIndex = 4;
            this.lbErrName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbErrName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnAddAirPort
            // 
            this.btnAddAirPort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAirPort.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAirPort.Location = new System.Drawing.Point(160, 597);
            this.btnAddAirPort.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAirPort.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddAirPort.Name = "btnAddAirPort";
            this.btnAddAirPort.Size = new System.Drawing.Size(133, 43);
            this.btnAddAirPort.TabIndex = 3;
            this.btnAddAirPort.Text = "Thêm";
            this.btnAddAirPort.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnAddAirPort.Click += new System.EventHandler(this.btnAddAirPort_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(29, 31);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(264, 39);
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "Tên Sân Bay: ";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnCloseAirPort
            // 
            this.btnCloseAirPort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseAirPort.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseAirPort.Location = new System.Drawing.Point(421, 597);
            this.btnCloseAirPort.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseAirPort.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCloseAirPort.Name = "btnCloseAirPort";
            this.btnCloseAirPort.Size = new System.Drawing.Size(133, 43);
            this.btnCloseAirPort.TabIndex = 1;
            this.btnCloseAirPort.Text = "Đóng";
            this.btnCloseAirPort.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnCloseAirPort.Click += new System.EventHandler(this.btnCloseAirPort_Click);
            // 
            // txtTenSanBay
            // 
            this.txtTenSanBay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSanBay.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSanBay.Location = new System.Drawing.Point(35, 86);
            this.txtTenSanBay.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTenSanBay.MinimumSize = new System.Drawing.Size(1, 20);
            this.txtTenSanBay.Name = "txtTenSanBay";
            this.txtTenSanBay.ShowText = false;
            this.txtTenSanBay.Size = new System.Drawing.Size(615, 46);
            this.txtTenSanBay.TabIndex = 0;
            this.txtTenSanBay.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTenSanBay.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiMarkLabel2
            // 
            this.uiMarkLabel2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiMarkLabel2.ForeColor = System.Drawing.Color.White;
            this.uiMarkLabel2.Location = new System.Drawing.Point(184, 34);
            this.uiMarkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiMarkLabel2.MarkColor = System.Drawing.Color.White;
            this.uiMarkLabel2.Name = "uiMarkLabel2";
            this.uiMarkLabel2.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.uiMarkLabel2.Size = new System.Drawing.Size(404, 74);
            this.uiMarkLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiMarkLabel2.TabIndex = 16;
            this.uiMarkLabel2.Text = "THÊM THÔNG TIN SÂN BAY";
            this.uiMarkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiMarkLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = global::Sunny.UI.Demo.Properties.Resources.download1;
            this.pbLogo.Location = new System.Drawing.Point(2, 2);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(197, 126);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 15;
            this.pbLogo.TabStop = false;
            // 
            // add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(692, 783);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiMarkLabel2);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add";
            this.Load += new System.EventHandler(this.add_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UILabel lbErrName;
        private UIButton btnAddAirPort;
        private UILabel uiLabel1;
        private UIButton btnCloseAirPort;
        private UITextBox txtTenSanBay;
        private UIMarkLabel uiMarkLabel2;
        private System.Windows.Forms.PictureBox pbLogo;
        private UILabel uiLabel5;
        private UILabel lbErrDC;
        private UILabel uiLabel3;
        private UITextBox txtDiaChiSanBay;
        private UILabel uiLabel7;
        private UIComboBox cbCountry;
        private UIComboBox cbCity;
    }
}