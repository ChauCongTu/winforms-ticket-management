namespace Sunny.UI.Demo.Views.UserCtrl
{
    partial class ucEmployee
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
            this.dgvEmployee = new Sunny.UI.UIDataGridView();
            this.txtSearch = new Sunny.UI.UITextBox();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.uiImageButton1 = new Sunny.UI.UIImageButton();
            this.dgviId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgviName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgviGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgviRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgviAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._sua = new System.Windows.Forms.DataGridViewImageColumn();
            this._details = new System.Windows.Forms.DataGridViewImageColumn();
            this._xoa = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("Times New Roman", 13.2F);
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
            this.uiMarkLabel1.Size = new System.Drawing.Size(522, 74);
            this.uiMarkLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiMarkLabel1.TabIndex = 10;
            this.uiMarkLabel1.Text = "QUẢN LÝ THÔNG TIN NHÂN VIÊN";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiMarkLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // dgvEmployee
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployee.ColumnHeadersHeight = 32;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgviId,
            this.dgviName,
            this.dgviGender,
            this.dgviRole,
            this.dgviAddress,
            this._sua,
            this._details,
            this._xoa});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployee.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmployee.EnableHeadersVisualStyles = false;
            this.dgvEmployee.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dgvEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.dgvEmployee.Location = new System.Drawing.Point(4, 110);
            this.dgvEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowHeight = 0;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgvEmployee.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEmployee.SelectedIndex = -1;
            this.dgvEmployee.ShowGridLine = true;
            this.dgvEmployee.ShowRect = false;
            this.dgvEmployee.Size = new System.Drawing.Size(1156, 443);
            this.dgvEmployee.TabIndex = 9;
            this.dgvEmployee.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.dgvEmployee.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellContentDoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.txtSearch.Location = new System.Drawing.Point(36, 576);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.ShowText = false;
            this.txtSearch.Size = new System.Drawing.Size(485, 43);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.Text = "Nhập tìm kiếm";
            this.txtSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSearch.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.uiButton1.Location = new System.Drawing.Point(734, 576);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(4);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(171, 43);
            this.uiButton1.TabIndex = 18;
            this.uiButton1.Text = "Tải lại";
            this.uiButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 71.3213F;
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
            this.dataGridViewImageColumn2.FillWeight = 71.3213F;
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
            this.uiImageButton1.Location = new System.Drawing.Point(521, 576);
            this.uiImageButton1.Margin = new System.Windows.Forms.Padding(4);
            this.uiImageButton1.Name = "uiImageButton1";
            this.uiImageButton1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.uiImageButton1.Size = new System.Drawing.Size(45, 43);
            this.uiImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uiImageButton1.TabIndex = 17;
            this.uiImageButton1.TabStop = false;
            this.uiImageButton1.Text = null;
            this.uiImageButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiImageButton1.Click += new System.EventHandler(this.uiImageButton1_Click);
            // 
            // dgviId
            // 
            this.dgviId.FillWeight = 83.2563F;
            this.dgviId.HeaderText = "ID";
            this.dgviId.MinimumWidth = 6;
            this.dgviId.Name = "dgviId";
            this.dgviId.ReadOnly = true;
            this.dgviId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgviName
            // 
            this.dgviName.FillWeight = 243.0842F;
            this.dgviName.HeaderText = "Tên Nhân Viên";
            this.dgviName.MinimumWidth = 6;
            this.dgviName.Name = "dgviName";
            this.dgviName.ReadOnly = true;
            // 
            // dgviGender
            // 
            this.dgviGender.FillWeight = 83.2563F;
            this.dgviGender.HeaderText = "Giới Tính";
            this.dgviGender.MinimumWidth = 6;
            this.dgviGender.Name = "dgviGender";
            this.dgviGender.ReadOnly = true;
            // 
            // dgviRole
            // 
            this.dgviRole.FillWeight = 83.2563F;
            this.dgviRole.HeaderText = "Chức Vụ";
            this.dgviRole.MinimumWidth = 6;
            this.dgviRole.Name = "dgviRole";
            this.dgviRole.ReadOnly = true;
            // 
            // dgviAddress
            // 
            this.dgviAddress.FillWeight = 224.7288F;
            this.dgviAddress.HeaderText = "Địa Chỉ";
            this.dgviAddress.MinimumWidth = 6;
            this.dgviAddress.Name = "dgviAddress";
            this.dgviAddress.ReadOnly = true;
            // 
            // _sua
            // 
            this._sua.FillWeight = 45.84798F;
            this._sua.HeaderText = "";
            this._sua.Image = global::Sunny.UI.Demo.Properties.Resources._3597075__1_;
            this._sua.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this._sua.MinimumWidth = 6;
            this._sua.Name = "_sua";
            this._sua.ReadOnly = true;
            this._sua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._sua.ToolTipText = "Sửa";
            // 
            // _details
            // 
            this._details.FillWeight = 45.86034F;
            this._details.HeaderText = "";
            this._details.Image = global::Sunny.UI.Demo.Properties.Resources.view_details_4__1_;
            this._details.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this._details.MinimumWidth = 6;
            this._details.Name = "_details";
            this._details.ReadOnly = true;
            // 
            // _xoa
            // 
            this._xoa.FillWeight = 48.06707F;
            this._xoa.HeaderText = "";
            this._xoa.Image = global::Sunny.UI.Demo.Properties.Resources._6048190__1_;
            this._xoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this._xoa.MinimumWidth = 6;
            this._xoa.Name = "_xoa";
            this._xoa.ReadOnly = true;
            this._xoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._xoa.ToolTipText = "Xóa";
            // 
            // ucEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.uiImageButton1);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.uiMarkLabel1);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "ucEmployee";
            this.Size = new System.Drawing.Size(1164, 639);
            this.Load += new System.EventHandler(this.ucEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UIButton uiButton2;
        private UIMarkLabel uiMarkLabel1;
        private UIDataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private UITextBox txtSearch;
        private UIImageButton uiImageButton1;
        private UIButton uiButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgviId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgviName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgviGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgviRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgviAddress;
        private System.Windows.Forms.DataGridViewImageColumn _sua;
        private System.Windows.Forms.DataGridViewImageColumn _details;
        private System.Windows.Forms.DataGridViewImageColumn _xoa;
    }
}
