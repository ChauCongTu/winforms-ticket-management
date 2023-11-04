namespace Sunny.UI.Demo.Views.UserCtrl
{
    partial class ucBooking
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.txtCCCD = new Sunny.UI.UITextBox();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.cbTicket = new Sunny.UI.UIComboBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.cbClass = new Sunny.UI.UIComboBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.lbCheckCustomer = new Sunny.UI.UILabel();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.txtNote = new Sunny.UI.UIRichTextBox();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.txtFlightId = new Sunny.UI.UITextBox();
            this.lbMsgFlight = new Sunny.UI.UILabel();
            this.btnTransactionManagement = new Sunny.UI.UIButton();
            this.lbRemainTicket = new Sunny.UI.UILabel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.btnReload = new Sunny.UI.UIImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiMarkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiMarkLabel1.Location = new System.Drawing.Point(455, 29);
            this.uiMarkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(311, 74);
            this.uiMarkLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiMarkLabel1.TabIndex = 13;
            this.uiMarkLabel1.Text = "ĐẶT VÉ MÁY BAY";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiMarkLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtCCCD
            // 
            this.txtCCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCCCD.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.Location = new System.Drawing.Point(748, 154);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCCCD.MinimumSize = new System.Drawing.Size(1, 20);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.ShowText = false;
            this.txtCCCD.Size = new System.Drawing.Size(368, 36);
            this.txtCCCD.Style = Sunny.UI.UIStyle.Custom;
            this.txtCCCD.TabIndex = 24;
            this.txtCCCD.Text = "Nhập số CCCD";
            this.txtCCCD.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtCCCD.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtCCCD.Click += new System.EventHandler(this.txtCCCD_Click);
            this.txtCCCD.TextChanged += new System.EventHandler(this.txtCCCD_TextChanged);
            this.txtCCCD.Leave += new System.EventHandler(this.txtCCCD_Leave);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiButton1.Location = new System.Drawing.Point(616, 309);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(4);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(239, 54);
            this.uiButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton1.TabIndex = 23;
            this.uiButton1.Text = "Thêm khách hàng";
            this.uiButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.Location = new System.Drawing.Point(611, 159);
            this.uiLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(155, 28);
            this.uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel5.TabIndex = 21;
            this.uiLabel5.Text = "Khách hàng:";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.Location = new System.Drawing.Point(48, 412);
            this.uiLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(155, 28);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 20;
            this.uiLabel4.Text = "Ghi chú:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbTicket
            // 
            this.cbTicket.DataSource = null;
            this.cbTicket.FillColor = System.Drawing.Color.White;
            this.cbTicket.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTicket.Location = new System.Drawing.Point(195, 327);
            this.cbTicket.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbTicket.MinimumSize = new System.Drawing.Size(84, 0);
            this.cbTicket.Name = "cbTicket";
            this.cbTicket.Padding = new System.Windows.Forms.Padding(0, 0, 40, 2);
            this.cbTicket.Size = new System.Drawing.Size(323, 36);
            this.cbTicket.Style = Sunny.UI.UIStyle.Custom;
            this.cbTicket.TabIndex = 19;
            this.cbTicket.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbTicket.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.Location = new System.Drawing.Point(48, 329);
            this.uiLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(155, 28);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 18;
            this.uiLabel3.Text = "Chọn vé:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbClass
            // 
            this.cbClass.DataSource = null;
            this.cbClass.FillColor = System.Drawing.Color.White;
            this.cbClass.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClass.Items.AddRange(new object[] {
            "First Class",
            "Busessness Class"});
            this.cbClass.Location = new System.Drawing.Point(195, 245);
            this.cbClass.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbClass.MinimumSize = new System.Drawing.Size(84, 0);
            this.cbClass.Name = "cbClass";
            this.cbClass.Padding = new System.Windows.Forms.Padding(0, 0, 40, 2);
            this.cbClass.Size = new System.Drawing.Size(352, 36);
            this.cbClass.Style = Sunny.UI.UIStyle.Custom;
            this.cbClass.TabIndex = 17;
            this.cbClass.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbClass.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.cbClass.SelectedValueChanged += new System.EventHandler(this.cbClass_SelectedValueChanged);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.Location = new System.Drawing.Point(48, 247);
            this.uiLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(155, 28);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 16;
            this.uiLabel2.Text = "Loại vé:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(48, 157);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(155, 28);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 14;
            this.uiLabel1.Text = "Chuyến bay:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // lbCheckCustomer
            // 
            this.lbCheckCustomer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckCustomer.Location = new System.Drawing.Point(616, 200);
            this.lbCheckCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCheckCustomer.Name = "lbCheckCustomer";
            this.lbCheckCustomer.Size = new System.Drawing.Size(500, 54);
            this.lbCheckCustomer.Style = Sunny.UI.UIStyle.Custom;
            this.lbCheckCustomer.TabIndex = 26;
            this.lbCheckCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCheckCustomer.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiButton2.Location = new System.Drawing.Point(891, 308);
            this.uiButton2.Margin = new System.Windows.Forms.Padding(4);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(225, 54);
            this.uiButton2.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton2.TabIndex = 27;
            this.uiButton2.Text = "Xem khách hàng";
            this.uiButton2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // txtNote
            // 
            this.txtNote.FillColor = System.Drawing.Color.White;
            this.txtNote.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(193, 412);
            this.txtNote.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNote.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNote.Name = "txtNote";
            this.txtNote.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNote.ShowText = false;
            this.txtNote.Size = new System.Drawing.Size(360, 182);
            this.txtNote.Style = Sunny.UI.UIStyle.Custom;
            this.txtNote.TabIndex = 28;
            this.txtNote.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtNote.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiButton3.Location = new System.Drawing.Point(891, 536);
            this.uiButton3.Margin = new System.Windows.Forms.Padding(4);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Size = new System.Drawing.Size(225, 54);
            this.uiButton3.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton3.TabIndex = 29;
            this.uiButton3.Text = "Đặt vé";
            this.uiButton3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton3.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // txtFlightId
            // 
            this.txtFlightId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFlightId.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightId.Location = new System.Drawing.Point(195, 154);
            this.txtFlightId.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtFlightId.MinimumSize = new System.Drawing.Size(1, 20);
            this.txtFlightId.Name = "txtFlightId";
            this.txtFlightId.ShowText = false;
            this.txtFlightId.Size = new System.Drawing.Size(359, 36);
            this.txtFlightId.Style = Sunny.UI.UIStyle.Custom;
            this.txtFlightId.TabIndex = 26;
            this.txtFlightId.Text = "Nhập ID chuyến bay";
            this.txtFlightId.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtFlightId.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtFlightId.Click += new System.EventHandler(this.txtFlightId_Click);
            this.txtFlightId.TextChanged += new System.EventHandler(this.txtFlightId_TextChanged);
            this.txtFlightId.Leave += new System.EventHandler(this.txtFlightId_Leave);
            // 
            // lbMsgFlight
            // 
            this.lbMsgFlight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsgFlight.Location = new System.Drawing.Point(47, 194);
            this.lbMsgFlight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMsgFlight.Name = "lbMsgFlight";
            this.lbMsgFlight.Size = new System.Drawing.Size(500, 45);
            this.lbMsgFlight.Style = Sunny.UI.UIStyle.Custom;
            this.lbMsgFlight.TabIndex = 30;
            this.lbMsgFlight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMsgFlight.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnTransactionManagement
            // 
            this.btnTransactionManagement.BackColor = System.Drawing.Color.White;
            this.btnTransactionManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransactionManagement.FillColor = System.Drawing.Color.Transparent;
            this.btnTransactionManagement.FillColor2 = System.Drawing.Color.Transparent;
            this.btnTransactionManagement.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTransactionManagement.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTransactionManagement.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTransactionManagement.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnTransactionManagement.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnTransactionManagement.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnTransactionManagement.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnTransactionManagement.Location = new System.Drawing.Point(891, 482);
            this.btnTransactionManagement.Margin = new System.Windows.Forms.Padding(4);
            this.btnTransactionManagement.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnTransactionManagement.Name = "btnTransactionManagement";
            this.btnTransactionManagement.RectColor = System.Drawing.Color.Transparent;
            this.btnTransactionManagement.Size = new System.Drawing.Size(225, 54);
            this.btnTransactionManagement.Style = Sunny.UI.UIStyle.Custom;
            this.btnTransactionManagement.TabIndex = 31;
            this.btnTransactionManagement.Text = "Xem danh sách đặt vé";
            this.btnTransactionManagement.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnTransactionManagement.Click += new System.EventHandler(this.btnTransactionManagement_Click);
            // 
            // lbRemainTicket
            // 
            this.lbRemainTicket.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemainTicket.Location = new System.Drawing.Point(48, 357);
            this.lbRemainTicket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRemainTicket.Name = "lbRemainTicket";
            this.lbRemainTicket.Size = new System.Drawing.Size(138, 28);
            this.lbRemainTicket.Style = Sunny.UI.UIStyle.Custom;
            this.lbRemainTicket.TabIndex = 35;
            this.lbRemainTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbRemainTicket.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLine1
            // 
            this.uiLine1.FillColor = System.Drawing.Color.White;
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine1.Location = new System.Drawing.Point(232, 114);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(686, 29);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 39;
            this.uiLine1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnReload.Image = global::Sunny.UI.Demo.Properties.Resources.Screenshot_2023_11_01_173330_removebg_preview;
            this.btnReload.Location = new System.Drawing.Point(515, 327);
            this.btnReload.Name = "btnReload";
            this.btnReload.Padding = new System.Windows.Forms.Padding(50);
            this.btnReload.Size = new System.Drawing.Size(38, 36);
            this.btnReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReload.TabIndex = 34;
            this.btnReload.TabStop = false;
            this.btnReload.Text = null;
            this.btnReload.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sunny.UI.Demo.Properties.Resources.flight_ticket_5370540_4492077;
            this.pictureBox1.Location = new System.Drawing.Point(352, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ucBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.lbRemainTicket);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTransactionManagement);
            this.Controls.Add(this.lbMsgFlight);
            this.Controls.Add(this.uiButton3);
            this.Controls.Add(this.txtFlightId);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.lbCheckCustomer);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.cbTicket);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiMarkLabel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucBooking";
            this.Size = new System.Drawing.Size(1164, 641);
            this.Load += new System.EventHandler(this.ucBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UIMarkLabel uiMarkLabel1;
        private UITextBox txtCCCD;
        private UIButton uiButton1;
        private UILabel uiLabel5;
        private UILabel uiLabel4;
        private UIComboBox cbTicket;
        private UILabel uiLabel3;
        private UIComboBox cbClass;
        private UILabel uiLabel2;
        private UILabel uiLabel1;
        private UILabel lbCheckCustomer;
        private UIButton uiButton2;
        private UIRichTextBox txtNote;
        private UIButton uiButton3;
        private UITextBox txtFlightId;
        private UILabel lbMsgFlight;
        private UIButton btnTransactionManagement;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UIImageButton btnReload;
        private UILabel lbRemainTicket;
        private UILine uiLine1;
    }
}
