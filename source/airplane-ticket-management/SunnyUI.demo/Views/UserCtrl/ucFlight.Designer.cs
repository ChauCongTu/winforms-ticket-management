namespace Sunny.UI.Demo.Views.UserCtrl
{
    partial class ucFlight
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.dgvFlight = new Sunny.UI.UIDataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.dpDateArrive = new Sunny.UI.UIDatePicker();
            this.btnSearch = new Sunny.UI.UIImageButton();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLine2 = new Sunny.UI.UILine();
            this.cbFrom = new Sunny.UI.UIComboBox();
            this.cbTo = new Sunny.UI.UIComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgviName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgviEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._quacanh = new System.Windows.Forms.DataGridViewImageColumn();
            this._detail = new System.Windows.Forms.DataGridViewImageColumn();
            this._xoa = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiButton2.Location = new System.Drawing.Point(953, 576);
            this.uiButton2.Margin = new System.Windows.Forms.Padding(4);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(205, 43);
            this.uiButton2.TabIndex = 11;
            this.uiButton2.Text = "Thêm mới";
            this.uiButton2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiMarkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiMarkLabel1.Location = new System.Drawing.Point(277, 20);
            this.uiMarkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(635, 74);
            this.uiMarkLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiMarkLabel1.TabIndex = 10;
            this.uiMarkLabel1.Text = "QUẢN LÝ THÔNG TIN CHUYẾN BAY";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiMarkLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // dgvFlight
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvFlight.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFlight.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFlight.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvFlight.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlight.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFlight.ColumnHeadersHeight = 32;
            this.dgvFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFlight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dgviName,
            this.dgviEmail,
            this._date,
            this._time,
            this.Column1,
            this._quacanh,
            this._detail,
            this._xoa});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFlight.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFlight.EnableHeadersVisualStyles = false;
            this.dgvFlight.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dgvFlight.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.dgvFlight.Location = new System.Drawing.Point(4, 268);
            this.dgvFlight.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFlight.Name = "dgvFlight";
            this.dgvFlight.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlight.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFlight.RowHeadersWidth = 51;
            this.dgvFlight.RowHeight = 0;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgvFlight.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFlight.SelectedIndex = -1;
            this.dgvFlight.ShowGridLine = true;
            this.dgvFlight.ShowRect = false;
            this.dgvFlight.Size = new System.Drawing.Size(1156, 285);
            this.dgvFlight.TabIndex = 9;
            this.dgvFlight.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.dgvFlight.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFlight_CellContentClick);
            this.dgvFlight.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFlight_CellContentDoubleClick);
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
            this.dataGridViewImageColumn1.Width = 75;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Sunny.UI.Demo.Properties.Resources.transit;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 75;
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
            this.dataGridViewImageColumn3.Width = 123;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiButton1.Location = new System.Drawing.Point(752, 576);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(4);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(171, 43);
            this.uiButton1.TabIndex = 12;
            this.uiButton1.Text = "Tải lại";
            this.uiButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // dpDateArrive
            // 
            this.dpDateArrive.DateFormat = "dd/MM/yyyy";
            this.dpDateArrive.FillColor = System.Drawing.Color.White;
            this.dpDateArrive.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDateArrive.Location = new System.Drawing.Point(308, 197);
            this.dpDateArrive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpDateArrive.MaxLength = 10;
            this.dpDateArrive.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpDateArrive.Name = "dpDateArrive";
            this.dpDateArrive.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpDateArrive.Size = new System.Drawing.Size(457, 43);
            this.dpDateArrive.SymbolDropDown = 61555;
            this.dpDateArrive.SymbolNormal = 61555;
            this.dpDateArrive.TabIndex = 15;
            this.dpDateArrive.Text = "28/10/2023";
            this.dpDateArrive.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpDateArrive.Value = new System.DateTime(2023, 10, 28, 0, 0, 0, 0);
            this.dpDateArrive.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(798, 197);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnSearch.Size = new System.Drawing.Size(125, 43);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearch.TabIndex = 16;
            this.btnSearch.TabStop = false;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnSearch.Click += new System.EventHandler(this.uiImageButton2_Click);
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel6.Location = new System.Drawing.Point(550, 105);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(173, 32);
            this.uiLabel6.TabIndex = 32;
            this.uiLabel6.Text = "Điểm đến:";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.Location = new System.Drawing.Point(304, 105);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(173, 32);
            this.uiLabel4.TabIndex = 31;
            this.uiLabel4.Text = "Điểm đi:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLine2
            // 
            this.uiLine2.FillColor = System.Drawing.Color.White;
            this.uiLine2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine2.Location = new System.Drawing.Point(525, 150);
            this.uiLine2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(14, 29);
            this.uiLine2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine2.TabIndex = 30;
            this.uiLine2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbFrom
            // 
            this.cbFrom.DataSource = null;
            this.cbFrom.FillColor = System.Drawing.Color.White;
            this.cbFrom.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFrom.Location = new System.Drawing.Point(308, 142);
            this.cbFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFrom.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbFrom.Size = new System.Drawing.Size(211, 43);
            this.cbFrom.TabIndex = 33;
            this.cbFrom.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbFrom.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbTo
            // 
            this.cbTo.DataSource = null;
            this.cbTo.FillColor = System.Drawing.Color.White;
            this.cbTo.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTo.Location = new System.Drawing.Point(554, 142);
            this.cbTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTo.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbTo.Name = "cbTo";
            this.cbTo.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbTo.Size = new System.Drawing.Size(211, 43);
            this.cbTo.TabIndex = 34;
            this.cbTo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbTo.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 48.12834F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgviName
            // 
            this.dgviName.FillWeight = 175.1621F;
            this.dgviName.HeaderText = "Điểm khởi hành";
            this.dgviName.MinimumWidth = 6;
            this.dgviName.Name = "dgviName";
            this.dgviName.ReadOnly = true;
            // 
            // dgviEmail
            // 
            this.dgviEmail.FillWeight = 96.67277F;
            this.dgviEmail.HeaderText = "Điểm đến";
            this.dgviEmail.MinimumWidth = 6;
            this.dgviEmail.Name = "dgviEmail";
            this.dgviEmail.ReadOnly = true;
            // 
            // _date
            // 
            this._date.FillWeight = 96.67277F;
            this._date.HeaderText = "Ngày bay";
            this._date.MinimumWidth = 6;
            this._date.Name = "_date";
            this._date.ReadOnly = true;
            // 
            // _time
            // 
            this._time.FillWeight = 96.67277F;
            this._time.HeaderText = "Giờ bay";
            this._time.MinimumWidth = 6;
            this._time.Name = "_time";
            this._time.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Giá vé";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // _quacanh
            // 
            this._quacanh.FillWeight = 96.67277F;
            this._quacanh.HeaderText = "";
            this._quacanh.Image = global::Sunny.UI.Demo.Properties.Resources.transit;
            this._quacanh.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this._quacanh.MinimumWidth = 6;
            this._quacanh.Name = "_quacanh";
            this._quacanh.ReadOnly = true;
            // 
            // _detail
            // 
            this._detail.FillWeight = 96.67277F;
            this._detail.HeaderText = "";
            this._detail.Image = global::Sunny.UI.Demo.Properties.Resources.view_details_4__1_;
            this._detail.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this._detail.MinimumWidth = 6;
            this._detail.Name = "_detail";
            this._detail.ReadOnly = true;
            // 
            // _xoa
            // 
            this._xoa.FillWeight = 96.67277F;
            this._xoa.HeaderText = "";
            this._xoa.Image = global::Sunny.UI.Demo.Properties.Resources._6048190__1_;
            this._xoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this._xoa.MinimumWidth = 6;
            this._xoa.Name = "_xoa";
            this._xoa.ReadOnly = true;
            this._xoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._xoa.ToolTipText = "Xóa";
            // 
            // ucFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbTo);
            this.Controls.Add(this.cbFrom);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLine2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dpDateArrive);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.uiMarkLabel1);
            this.Controls.Add(this.dgvFlight);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucFlight";
            this.Size = new System.Drawing.Size(1164, 639);
            this.Load += new System.EventHandler(this.ucFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UIButton uiButton2;
        private UIMarkLabel uiMarkLabel1;
        private UIDataGridView dgvFlight;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private UIButton uiButton1;
        private UIDatePicker dpDateArrive;
        private UIImageButton btnSearch;
        private UILabel uiLabel6;
        private UILabel uiLabel4;
        private UILine uiLine2;
        private UIComboBox cbFrom;
        private UIComboBox cbTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgviName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgviEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn _date;
        private System.Windows.Forms.DataGridViewTextBoxColumn _time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn _quacanh;
        private System.Windows.Forms.DataGridViewImageColumn _detail;
        private System.Windows.Forms.DataGridViewImageColumn _xoa;
    }
}
