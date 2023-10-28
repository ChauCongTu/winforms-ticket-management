namespace Sunny.UI.Demo.Views.NForm.Flights
{
    partial class ShowDetail
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
            this.uiButton4 = new Sunny.UI.UIButton();
            this.lbRemaingTicket = new Sunny.UI.UILabel();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.btnBooking = new Sunny.UI.UIButton();
            this.btnSave = new Sunny.UI.UIButton();
            this.btnEdit = new Sunny.UI.UIButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbStatus = new Sunny.UI.UIComboBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.txtTotalTicket = new Sunny.UI.UITextBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.dtpTime = new Sunny.UI.UIDatetimePicker();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.cbTo = new Sunny.UI.UIComboBox();
            this.cbFrom = new Sunny.UI.UIComboBox();
            this.txtTo = new Sunny.UI.UITextBox();
            this.txtFrom = new Sunny.UI.UITextBox();
            this.uiLine2 = new Sunny.UI.UILine();
            this.uiLine3 = new Sunny.UI.UILine();
            this.cbAirline = new Sunny.UI.UIComboBox();
            this.cbAirplane = new Sunny.UI.UIComboBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.uiButton4);
            this.panel1.Controls.Add(this.lbRemaingTicket);
            this.panel1.Controls.Add(this.uiLabel11);
            this.panel1.Controls.Add(this.btnBooking);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 700);
            this.panel1.TabIndex = 0;
            // 
            // uiButton4
            // 
            this.uiButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton4.Location = new System.Drawing.Point(683, 624);
            this.uiButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton4.Name = "uiButton4";
            this.uiButton4.Size = new System.Drawing.Size(117, 47);
            this.uiButton4.TabIndex = 25;
            this.uiButton4.Text = "Đóng";
            this.uiButton4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton4.Click += new System.EventHandler(this.uiButton4_Click);
            // 
            // lbRemaingTicket
            // 
            this.lbRemaingTicket.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemaingTicket.ForeColor = System.Drawing.Color.Red;
            this.lbRemaingTicket.Location = new System.Drawing.Point(654, 569);
            this.lbRemaingTicket.Name = "lbRemaingTicket";
            this.lbRemaingTicket.Size = new System.Drawing.Size(173, 32);
            this.lbRemaingTicket.Style = Sunny.UI.UIStyle.Custom;
            this.lbRemaingTicket.TabIndex = 24;
            this.lbRemaingTicket.Text = "Hết vé";
            this.lbRemaingTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbRemaingTicket.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel11
            // 
            this.uiLabel11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel11.Location = new System.Drawing.Point(496, 567);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(160, 32);
            this.uiLabel11.TabIndex = 21;
            this.uiLabel11.Text = "Tình trạng vé:";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel11.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnBooking
            // 
            this.btnBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBooking.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnBooking.Location = new System.Drawing.Point(437, 624);
            this.btnBooking.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(117, 47);
            this.btnBooking.TabIndex = 23;
            this.btnBooking.Text = "Đặt vé";
            this.btnBooking.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnSave.Location = new System.Drawing.Point(560, 624);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 47);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Lưu";
            this.btnSave.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnEdit.Location = new System.Drawing.Point(560, 624);
            this.btnEdit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(117, 47);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.uiLabel3);
            this.panel3.Controls.Add(this.uiLabel2);
            this.panel3.Controls.Add(this.uiLabel1);
            this.panel3.Controls.Add(this.cbAirplane);
            this.panel3.Controls.Add(this.cbAirline);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(655, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(528, 420);
            this.panel3.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sunny.UI.Demo.Properties.Resources.plane_mixivivu_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.uiLabel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(7, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 420);
            this.panel2.TabIndex = 18;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel5.ForeColor = System.Drawing.Color.White;
            this.uiLabel5.Location = new System.Drawing.Point(4, 9);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(278, 23);
            this.uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel5.TabIndex = 8;
            this.uiLabel5.Text = "Thông tin chuyến bay";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.uiLine3);
            this.panel4.Controls.Add(this.uiLine2);
            this.panel4.Controls.Add(this.cbStatus);
            this.panel4.Controls.Add(this.uiLabel9);
            this.panel4.Controls.Add(this.txtTotalTicket);
            this.panel4.Controls.Add(this.uiLabel8);
            this.panel4.Controls.Add(this.dtpTime);
            this.panel4.Controls.Add(this.uiLabel7);
            this.panel4.Controls.Add(this.uiLine1);
            this.panel4.Controls.Add(this.cbTo);
            this.panel4.Controls.Add(this.cbFrom);
            this.panel4.Controls.Add(this.txtTo);
            this.panel4.Controls.Add(this.txtFrom);
            this.panel4.Location = new System.Drawing.Point(2, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(625, 375);
            this.panel4.TabIndex = 0;
            // 
            // cbStatus
            // 
            this.cbStatus.DataSource = null;
            this.cbStatus.Enabled = false;
            this.cbStatus.FillColor = System.Drawing.Color.White;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cbStatus.Location = new System.Drawing.Point(246, 303);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStatus.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbStatus.Size = new System.Drawing.Size(252, 29);
            this.cbStatus.TabIndex = 13;
            this.cbStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbStatus.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel9.Location = new System.Drawing.Point(97, 303);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(124, 29);
            this.uiLabel9.TabIndex = 12;
            this.uiLabel9.Text = "Trạng thái:";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel9.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtTotalTicket
            // 
            this.txtTotalTicket.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalTicket.Enabled = false;
            this.txtTotalTicket.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtTotalTicket.Location = new System.Drawing.Point(246, 255);
            this.txtTotalTicket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalTicket.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTotalTicket.Name = "txtTotalTicket";
            this.txtTotalTicket.ShowText = false;
            this.txtTotalTicket.Size = new System.Drawing.Size(252, 29);
            this.txtTotalTicket.TabIndex = 6;
            this.txtTotalTicket.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTotalTicket.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel8.Location = new System.Drawing.Point(96, 252);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(173, 32);
            this.uiLabel8.TabIndex = 11;
            this.uiLabel8.Text = "Tổng số vé:";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel8.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // dtpTime
            // 
            this.dtpTime.DateFormat = "HH:mm dd/MM/yyyy";
            this.dtpTime.Enabled = false;
            this.dtpTime.FillColor = System.Drawing.Color.White;
            this.dtpTime.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dtpTime.Location = new System.Drawing.Point(246, 207);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTime.MaxLength = 16;
            this.dtpTime.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dtpTime.Size = new System.Drawing.Size(252, 29);
            this.dtpTime.SymbolDropDown = 61555;
            this.dtpTime.SymbolNormal = 61555;
            this.dtpTime.TabIndex = 10;
            this.dtpTime.Text = "12:24 28/10/2023";
            this.dtpTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtpTime.Value = new System.DateTime(2023, 10, 28, 12, 24, 25, 583);
            this.dtpTime.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel7.Location = new System.Drawing.Point(96, 204);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(173, 32);
            this.uiLabel7.TabIndex = 9;
            this.uiLabel7.Text = "Thời gian bay:";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel7.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLine1
            // 
            this.uiLine1.FillColor = System.Drawing.Color.White;
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine1.Location = new System.Drawing.Point(126, 155);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(360, 29);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 8;
            this.uiLine1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbTo
            // 
            this.cbTo.DataSource = null;
            this.cbTo.Enabled = false;
            this.cbTo.FillColor = System.Drawing.Color.White;
            this.cbTo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cbTo.Location = new System.Drawing.Point(334, 96);
            this.cbTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTo.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbTo.Name = "cbTo";
            this.cbTo.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbTo.Size = new System.Drawing.Size(267, 29);
            this.cbTo.TabIndex = 7;
            this.cbTo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbTo.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbFrom
            // 
            this.cbFrom.DataSource = null;
            this.cbFrom.Enabled = false;
            this.cbFrom.FillColor = System.Drawing.Color.White;
            this.cbFrom.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cbFrom.Location = new System.Drawing.Point(26, 96);
            this.cbFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFrom.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbFrom.Size = new System.Drawing.Size(280, 29);
            this.cbFrom.TabIndex = 6;
            this.cbFrom.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbFrom.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtTo
            // 
            this.txtTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTo.Enabled = false;
            this.txtTo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtTo.Location = new System.Drawing.Point(334, 43);
            this.txtTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTo.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTo.Name = "txtTo";
            this.txtTo.ShowText = false;
            this.txtTo.Size = new System.Drawing.Size(267, 29);
            this.txtTo.TabIndex = 5;
            this.txtTo.Text = "To";
            this.txtTo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTo.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtTo.TextChanged += new System.EventHandler(this.txtTo_TextChanged);
            // 
            // txtFrom
            // 
            this.txtFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFrom.Enabled = false;
            this.txtFrom.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtFrom.Location = new System.Drawing.Point(26, 43);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFrom.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.ShowText = false;
            this.txtFrom.Size = new System.Drawing.Size(280, 29);
            this.txtFrom.TabIndex = 4;
            this.txtFrom.Text = "From";
            this.txtFrom.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtFrom.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtFrom.TextChanged += new System.EventHandler(this.txtFrom_TextChanged);
            // 
            // uiLine2
            // 
            this.uiLine2.FillColor = System.Drawing.Color.White;
            this.uiLine2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine2.Location = new System.Drawing.Point(313, 44);
            this.uiLine2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(14, 29);
            this.uiLine2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine2.TabIndex = 14;
            this.uiLine2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLine3
            // 
            this.uiLine3.FillColor = System.Drawing.Color.White;
            this.uiLine3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine3.Location = new System.Drawing.Point(312, 97);
            this.uiLine3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine3.Name = "uiLine3";
            this.uiLine3.Size = new System.Drawing.Size(14, 29);
            this.uiLine3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine3.TabIndex = 15;
            this.uiLine3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbAirline
            // 
            this.cbAirline.DataSource = null;
            this.cbAirline.Enabled = false;
            this.cbAirline.FillColor = System.Drawing.Color.White;
            this.cbAirline.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cbAirline.Location = new System.Drawing.Point(195, 302);
            this.cbAirline.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbAirline.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbAirline.Name = "cbAirline";
            this.cbAirline.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbAirline.Size = new System.Drawing.Size(280, 29);
            this.cbAirline.TabIndex = 7;
            this.cbAirline.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbAirline.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbAirplane
            // 
            this.cbAirplane.DataSource = null;
            this.cbAirplane.Enabled = false;
            this.cbAirplane.FillColor = System.Drawing.Color.White;
            this.cbAirplane.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cbAirplane.Location = new System.Drawing.Point(196, 347);
            this.cbAirplane.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbAirplane.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbAirplane.Name = "cbAirplane";
            this.cbAirplane.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbAirplane.Size = new System.Drawing.Size(280, 29);
            this.cbAirplane.TabIndex = 8;
            this.cbAirplane.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbAirplane.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(70, 300);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(63, 32);
            this.uiLabel1.TabIndex = 16;
            this.uiLabel1.Text = "Hãng:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.Location = new System.Drawing.Point(69, 347);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(120, 32);
            this.uiLabel2.TabIndex = 17;
            this.uiLabel2.Text = "Máy bay:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(204)))));
            this.uiLabel3.Location = new System.Drawing.Point(161, 244);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(235, 32);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 18;
            this.uiLabel3.Text = "Thông Tin Máy Bay";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ShowDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1196, 705);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowDetail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowDetail";
            this.Load += new System.EventHandler(this.ShowDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UIButton uiButton4;
        private UILabel lbRemaingTicket;
        private UILabel uiLabel11;
        private UIButton btnBooking;
        private UIButton btnSave;
        private UIButton btnEdit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private UILabel uiLabel5;
        private System.Windows.Forms.Panel panel4;
        private UIComboBox cbStatus;
        private UILabel uiLabel9;
        private UITextBox txtTotalTicket;
        private UILabel uiLabel8;
        private UIDatetimePicker dtpTime;
        private UILabel uiLabel7;
        private UILine uiLine1;
        private UIComboBox cbTo;
        private UIComboBox cbFrom;
        private UITextBox txtTo;
        private UITextBox txtFrom;
        private UILine uiLine3;
        private UILine uiLine2;
        private UILabel uiLabel2;
        private UILabel uiLabel1;
        private UIComboBox cbAirplane;
        private UIComboBox cbAirline;
        private UILabel uiLabel3;
    }
}