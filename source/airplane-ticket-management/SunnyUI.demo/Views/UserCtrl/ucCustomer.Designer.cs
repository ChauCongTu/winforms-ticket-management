namespace Sunny.UI.Demo.Views.UserCtrl
{
    partial class ucCustomer
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
            this.dgvCustomer = new Sunny.UI.UIDataGridView();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.txtSearch = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.uiImageButton1 = new Sunny.UI.UIImageButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgviName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgviPhone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgviDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._sua = new System.Windows.Forms.DataGridViewImageColumn();
            this._detail = new System.Windows.Forms.DataGridViewImageColumn();
            this._xoa = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiButton2.Location = new System.Drawing.Point(965, 576);
            this.uiButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(193, 43);
            this.uiButton2.TabIndex = 8;
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
            this.uiMarkLabel1.TabIndex = 7;
            this.uiMarkLabel1.Text = "QUẢN LÝ THÔNG TIN KHÁCH HÀNG";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiMarkLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // dgvCustomer
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomer.ColumnHeadersHeight = 32;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this._id,
            this.dgviName,
            this.dgviPhone_number,
            this.dgviDOB,
            this._sua,
            this._detail,
            this._xoa});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomer.EnableHeadersVisualStyles = false;
            this.dgvCustomer.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dgvCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.dgvCustomer.Location = new System.Drawing.Point(4, 110);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowHeight = 0;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgvCustomer.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCustomer.SelectedIndex = -1;
            this.dgvCustomer.ShowGridLine = true;
            this.dgvCustomer.ShowRect = false;
            this.dgvCustomer.Size = new System.Drawing.Size(1156, 443);
            this.dgvCustomer.TabIndex = 6;
            this.dgvCustomer.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.dgvCustomer.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentDoubleClick);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiButton1.Location = new System.Drawing.Point(752, 576);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(4);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(193, 43);
            this.uiButton1.TabIndex = 9;
            this.uiButton1.Text = "Tải lại";
            this.uiButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(209, 576);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.ShowText = false;
            this.txtSearch.Size = new System.Drawing.Size(346, 43);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.Text = "Số căn cước";
            this.txtSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSearch.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(4, 581);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(205, 33);
            this.uiLabel1.TabIndex = 12;
            this.uiLabel1.Text = "Tra cứu khách hàng:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.Description = "Chi tiết";
            this.dataGridViewImageColumn1.FillWeight = 95.26937F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Sunny.UI.Demo.Properties.Resources._3597075__1_;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.ToolTipText = "Sửa";
            this.dataGridViewImageColumn1.Width = 165;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.Description = "Chi tiết";
            this.dataGridViewImageColumn2.FillWeight = 95.26937F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Sunny.UI.Demo.Properties.Resources._6048190__1_;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.ToolTipText = "Xóa";
            this.dataGridViewImageColumn2.Width = 165;
            // 
            // uiImageButton1
            // 
            this.uiImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiImageButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiImageButton1.Image = global::Sunny.UI.Demo.Properties.Resources.searchicon;
            this.uiImageButton1.Location = new System.Drawing.Point(550, 576);
            this.uiImageButton1.Margin = new System.Windows.Forms.Padding(4);
            this.uiImageButton1.Name = "uiImageButton1";
            this.uiImageButton1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.uiImageButton1.Size = new System.Drawing.Size(45, 43);
            this.uiImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uiImageButton1.TabIndex = 11;
            this.uiImageButton1.TabStop = false;
            this.uiImageButton1.Text = null;
            this.uiImageButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiImageButton1.Click += new System.EventHandler(this.uiImageButton1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 88.72902F;
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // _id
            // 
            this._id.HeaderText = "Mã KH";
            this._id.MinimumWidth = 6;
            this._id.Name = "_id";
            this._id.ReadOnly = true;
            // 
            // dgviName
            // 
            this.dgviName.FillWeight = 144.385F;
            this.dgviName.HeaderText = "Họ tên";
            this.dgviName.MinimumWidth = 6;
            this.dgviName.Name = "dgviName";
            this.dgviName.ReadOnly = true;
            // 
            // dgviPhone_number
            // 
            this.dgviPhone_number.FillWeight = 95.26937F;
            this.dgviPhone_number.HeaderText = "SĐT";
            this.dgviPhone_number.MinimumWidth = 6;
            this.dgviPhone_number.Name = "dgviPhone_number";
            this.dgviPhone_number.ReadOnly = true;
            // 
            // dgviDOB
            // 
            this.dgviDOB.FillWeight = 95.26937F;
            this.dgviDOB.HeaderText = "Ngày Sinh";
            this.dgviDOB.MinimumWidth = 6;
            this.dgviDOB.Name = "dgviDOB";
            this.dgviDOB.ReadOnly = true;
            // 
            // _sua
            // 
            this._sua.Description = "Chi tiết";
            this._sua.FillWeight = 95.26937F;
            this._sua.HeaderText = "";
            this._sua.Image = global::Sunny.UI.Demo.Properties.Resources._3597075__1_;
            this._sua.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this._sua.MinimumWidth = 6;
            this._sua.Name = "_sua";
            this._sua.ReadOnly = true;
            this._sua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._sua.ToolTipText = "Sửa";
            // 
            // _detail
            // 
            this._detail.Description = "Chi tiết";
            this._detail.FillWeight = 95.26937F;
            this._detail.HeaderText = "";
            this._detail.Image = global::Sunny.UI.Demo.Properties.Resources.view_details_4__1_1;
            this._detail.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this._detail.MinimumWidth = 6;
            this._detail.Name = "_detail";
            this._detail.ReadOnly = true;
            this._detail.ToolTipText = "Chi tiết";
            // 
            // _xoa
            // 
            this._xoa.FillWeight = 95.26937F;
            this._xoa.HeaderText = "";
            this._xoa.Image = global::Sunny.UI.Demo.Properties.Resources._6048190__1_;
            this._xoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this._xoa.MinimumWidth = 6;
            this._xoa.Name = "_xoa";
            this._xoa.ReadOnly = true;
            this._xoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._xoa.ToolTipText = "Xóa";
            // 
            // ucCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiImageButton1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.uiMarkLabel1);
            this.Controls.Add(this.dgvCustomer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucCustomer";
            this.Size = new System.Drawing.Size(1164, 639);
            this.Load += new System.EventHandler(this.ucCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private UIButton uiButton2;
        private UIMarkLabel uiMarkLabel1;
        private UIDataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private UIButton uiButton1;
        private UIImageButton uiImageButton1;
        private UITextBox txtSearch;
        private UILabel uiLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgviName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgviPhone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgviDOB;
        private System.Windows.Forms.DataGridViewImageColumn _sua;
        private System.Windows.Forms.DataGridViewImageColumn _detail;
        private System.Windows.Forms.DataGridViewImageColumn _xoa;
    }
}
