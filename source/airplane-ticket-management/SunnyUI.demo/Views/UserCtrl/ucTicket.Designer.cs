namespace Sunny.UI.Demo.Views.UserCtrl
{
    partial class ucTicket
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.pnFlightSelection = new System.Windows.Forms.Panel();
            this.lbMsgFlight = new Sunny.UI.UILabel();
            this.txtFlightId = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.dgvTicket = new Sunny.UI.UIDataGridView();
            this.pnMain = new System.Windows.Forms.Panel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.cbClass = new Sunny.UI.UIComboBox();
            this.btnFiltByClass = new Sunny.UI.UIButton();
            this.btnFiltByStatus = new Sunny.UI.UIButton();
            this.cbStatus = new Sunny.UI.UIComboBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.lbFlightInfo = new Sunny.UI.UILabel();
            this.btnBack = new Sunny.UI.UIButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this._stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfPlane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._sua = new System.Windows.Forms.DataGridViewImageColumn();
            this._order = new System.Windows.Forms.DataGridViewImageColumn();
            this._xoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnFlightSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiMarkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiMarkLabel1.Location = new System.Drawing.Point(396, 10);
            this.uiMarkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(407, 74);
            this.uiMarkLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiMarkLabel1.TabIndex = 14;
            this.uiMarkLabel1.Text = "QUẢN LÝ VÉ MÁY BAY";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiMarkLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // pnFlightSelection
            // 
            this.pnFlightSelection.Controls.Add(this.lbMsgFlight);
            this.pnFlightSelection.Controls.Add(this.txtFlightId);
            this.pnFlightSelection.Controls.Add(this.uiLabel1);
            this.pnFlightSelection.Controls.Add(this.uiButton1);
            this.pnFlightSelection.Location = new System.Drawing.Point(3, 113);
            this.pnFlightSelection.Name = "pnFlightSelection";
            this.pnFlightSelection.Size = new System.Drawing.Size(1158, 523);
            this.pnFlightSelection.TabIndex = 15;
            // 
            // lbMsgFlight
            // 
            this.lbMsgFlight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsgFlight.Location = new System.Drawing.Point(335, 218);
            this.lbMsgFlight.Name = "lbMsgFlight";
            this.lbMsgFlight.Size = new System.Drawing.Size(509, 55);
            this.lbMsgFlight.TabIndex = 23;
            this.lbMsgFlight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMsgFlight.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtFlightId
            // 
            this.txtFlightId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFlightId.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtFlightId.Location = new System.Drawing.Point(340, 160);
            this.txtFlightId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFlightId.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtFlightId.Name = "txtFlightId";
            this.txtFlightId.ShowText = false;
            this.txtFlightId.Size = new System.Drawing.Size(378, 53);
            this.txtFlightId.TabIndex = 22;
            this.txtFlightId.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtFlightId.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtFlightId.TextChanged += new System.EventHandler(this.txtFlightId_TextChanged);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(335, 100);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(291, 55);
            this.uiLabel1.TabIndex = 21;
            this.uiLabel1.Text = "Nhập mã chuyến bay:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton1.Location = new System.Drawing.Point(725, 160);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(119, 53);
            this.uiButton1.TabIndex = 20;
            this.uiButton1.Text = "Chọn";
            this.uiButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiButton2.Location = new System.Drawing.Point(750, 466);
            this.uiButton2.Margin = new System.Windows.Forms.Padding(4);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(171, 43);
            this.uiButton2.TabIndex = 27;
            this.uiButton2.Text = "Tải lại";
            this.uiButton2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiButton3.Location = new System.Drawing.Point(951, 466);
            this.uiButton3.Margin = new System.Windows.Forms.Padding(4);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Size = new System.Drawing.Size(205, 43);
            this.uiButton3.TabIndex = 26;
            this.uiButton3.Text = "Thêm mới";
            this.uiButton3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton3.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // dgvTicket
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvTicket.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTicket.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvTicket.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTicket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvTicket.ColumnHeadersHeight = 32;
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._stt,
            this.STT,
            this.name,
            this.numOfPlane,
            this._status,
            this._sua,
            this._order,
            this._xoa});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTicket.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvTicket.EnableHeadersVisualStyles = false;
            this.dgvTicket.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dgvTicket.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.dgvTicket.Location = new System.Drawing.Point(2, 141);
            this.dgvTicket.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTicket.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvTicket.RowHeadersWidth = 51;
            this.dgvTicket.RowHeight = 0;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgvTicket.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvTicket.SelectedIndex = -1;
            this.dgvTicket.ShowGridLine = true;
            this.dgvTicket.ShowRect = false;
            this.dgvTicket.Size = new System.Drawing.Size(1156, 306);
            this.dgvTicket.TabIndex = 25;
            this.dgvTicket.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.dgvTicket.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTicket_CellContentDoubleClick);
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.lbFlightInfo);
            this.pnMain.Controls.Add(this.uiLabel4);
            this.pnMain.Controls.Add(this.btnFiltByStatus);
            this.pnMain.Controls.Add(this.cbStatus);
            this.pnMain.Controls.Add(this.uiLabel3);
            this.pnMain.Controls.Add(this.btnFiltByClass);
            this.pnMain.Controls.Add(this.cbClass);
            this.pnMain.Controls.Add(this.uiLabel2);
            this.pnMain.Controls.Add(this.dgvTicket);
            this.pnMain.Controls.Add(this.uiButton3);
            this.pnMain.Controls.Add(this.uiButton2);
            this.pnMain.Location = new System.Drawing.Point(3, 113);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1161, 523);
            this.pnMain.TabIndex = 24;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.Location = new System.Drawing.Point(141, 15);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(165, 34);
            this.uiLabel2.TabIndex = 28;
            this.uiLabel2.Text = "Hạng vé:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbClass
            // 
            this.cbClass.DataSource = null;
            this.cbClass.FillColor = System.Drawing.Color.White;
            this.cbClass.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClass.Items.AddRange(new object[] {
            ""});
            this.cbClass.Location = new System.Drawing.Point(146, 54);
            this.cbClass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbClass.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbClass.Name = "cbClass";
            this.cbClass.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbClass.Size = new System.Drawing.Size(308, 41);
            this.cbClass.TabIndex = 29;
            this.cbClass.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbClass.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnFiltByClass
            // 
            this.btnFiltByClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltByClass.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnFiltByClass.Location = new System.Drawing.Point(457, 54);
            this.btnFiltByClass.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltByClass.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnFiltByClass.Name = "btnFiltByClass";
            this.btnFiltByClass.Size = new System.Drawing.Size(99, 42);
            this.btnFiltByClass.TabIndex = 30;
            this.btnFiltByClass.Text = "Lọc";
            this.btnFiltByClass.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnFiltByClass.Click += new System.EventHandler(this.btnFiltByClass_Click);
            // 
            // btnFiltByStatus
            // 
            this.btnFiltByStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltByStatus.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltByStatus.Location = new System.Drawing.Point(912, 54);
            this.btnFiltByStatus.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltByStatus.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnFiltByStatus.Name = "btnFiltByStatus";
            this.btnFiltByStatus.Size = new System.Drawing.Size(99, 41);
            this.btnFiltByStatus.TabIndex = 33;
            this.btnFiltByStatus.Text = "Lọc";
            this.btnFiltByStatus.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnFiltByStatus.Click += new System.EventHandler(this.btnFiltByStatus_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.DataSource = null;
            this.cbStatus.FillColor = System.Drawing.Color.White;
            this.cbStatus.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.Items.AddRange(new object[] {
            "Chưa bán",
            "Đã bán"});
            this.cbStatus.Location = new System.Drawing.Point(601, 54);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStatus.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbStatus.Size = new System.Drawing.Size(308, 41);
            this.cbStatus.TabIndex = 32;
            this.cbStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbStatus.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.Location = new System.Drawing.Point(596, 15);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(165, 34);
            this.uiLabel3.TabIndex = 31;
            this.uiLabel3.Text = "Tình trạng vé: ";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.Location = new System.Drawing.Point(3, 469);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(142, 34);
            this.uiLabel4.TabIndex = 34;
            this.uiLabel4.Text = "Chuyến bay:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // lbFlightInfo
            // 
            this.lbFlightInfo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFlightInfo.Location = new System.Drawing.Point(141, 451);
            this.lbFlightInfo.Name = "lbFlightInfo";
            this.lbFlightInfo.Size = new System.Drawing.Size(537, 72);
            this.lbFlightInfo.TabIndex = 35;
            this.lbFlightInfo.Text = "Chuyến bay:";
            this.lbFlightInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbFlightInfo.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(11, 30);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(38, 43);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "<";
            this.btnBack.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Sunny.UI.Demo.Properties.Resources._3597075__1_;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.ToolTipText = "Sửa";
            this.dataGridViewImageColumn1.Width = 184;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Sunny.UI.Demo.Properties.Resources._6048190__1_;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.ToolTipText = "Xóa";
            this.dataGridViewImageColumn2.Width = 184;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::Sunny.UI.Demo.Properties.Resources._6048190__1_;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.ToolTipText = "Xóa";
            this.dataGridViewImageColumn3.Width = 158;
            // 
            // _stt
            // 
            this._stt.HeaderText = "STT";
            this._stt.MinimumWidth = 6;
            this._stt.Name = "_stt";
            this._stt.ReadOnly = true;
            // 
            // STT
            // 
            this.STT.HeaderText = "Số vé";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // name
            // 
            this.name.HeaderText = "Hạng vé";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // numOfPlane
            // 
            this.numOfPlane.HeaderText = "Giá vé";
            this.numOfPlane.MinimumWidth = 6;
            this.numOfPlane.Name = "numOfPlane";
            this.numOfPlane.ReadOnly = true;
            // 
            // _status
            // 
            this._status.HeaderText = "Tình trạng";
            this._status.MinimumWidth = 6;
            this._status.Name = "_status";
            this._status.ReadOnly = true;
            // 
            // _sua
            // 
            this._sua.HeaderText = "";
            this._sua.Image = global::Sunny.UI.Demo.Properties.Resources._3597075__1_;
            this._sua.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this._sua.MinimumWidth = 6;
            this._sua.Name = "_sua";
            this._sua.ReadOnly = true;
            this._sua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._sua.ToolTipText = "Sửa";
            // 
            // _order
            // 
            this._order.HeaderText = "";
            this._order.Image = global::Sunny.UI.Demo.Properties.Resources.order_ticket;
            this._order.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this._order.MinimumWidth = 6;
            this._order.Name = "_order";
            this._order.ReadOnly = true;
            // 
            // _xoa
            // 
            this._xoa.HeaderText = "";
            this._xoa.Image = global::Sunny.UI.Demo.Properties.Resources._6048190__1_;
            this._xoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this._xoa.MinimumWidth = 6;
            this._xoa.Name = "_xoa";
            this._xoa.ReadOnly = true;
            this._xoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._xoa.ToolTipText = "Xóa";
            // 
            // ucTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnFlightSelection);
            this.Controls.Add(this.uiMarkLabel1);
            this.Name = "ucTicket";
            this.Size = new System.Drawing.Size(1164, 639);
            this.pnFlightSelection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UIMarkLabel uiMarkLabel1;
        private System.Windows.Forms.Panel pnFlightSelection;
        private UILabel lbMsgFlight;
        private UITextBox txtFlightId;
        private UILabel uiLabel1;
        private UIButton uiButton1;
        private UIButton uiButton2;
        private UIButton uiButton3;
        private UIDataGridView dgvTicket;
        private System.Windows.Forms.Panel pnMain;
        private UIButton btnFiltByClass;
        private UIComboBox cbClass;
        private UILabel uiLabel2;
        private UIButton btnFiltByStatus;
        private UIComboBox cbStatus;
        private UILabel uiLabel3;
        private UILabel lbFlightInfo;
        private UILabel uiLabel4;
        private UIButton btnBack;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn _stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfPlane;
        private System.Windows.Forms.DataGridViewTextBoxColumn _status;
        private System.Windows.Forms.DataGridViewImageColumn _sua;
        private System.Windows.Forms.DataGridViewImageColumn _order;
        private System.Windows.Forms.DataGridViewImageColumn _xoa;
    }
}
