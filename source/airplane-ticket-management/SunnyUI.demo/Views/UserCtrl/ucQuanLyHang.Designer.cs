﻿namespace Sunny.UI.Demo.Views.UserCtrl
{
    partial class ucQuanLyHang
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
            this.dgvAirlines = new Sunny.UI.UIDataGridView();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfPlane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._sua = new System.Windows.Forms.DataGridViewImageColumn();
            this._xoa = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirlines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAirlines
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvAirlines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAirlines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAirlines.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvAirlines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAirlines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAirlines.ColumnHeadersHeight = 32;
            this.dgvAirlines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAirlines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.name,
            this.numOfPlane,
            this._sua,
            this._xoa});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAirlines.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAirlines.EnableHeadersVisualStyles = false;
            this.dgvAirlines.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dgvAirlines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.dgvAirlines.Location = new System.Drawing.Point(3, 86);
            this.dgvAirlines.Name = "dgvAirlines";
            this.dgvAirlines.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAirlines.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAirlines.RowHeight = 0;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgvAirlines.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAirlines.SelectedIndex = -1;
            this.dgvAirlines.ShowGridLine = true;
            this.dgvAirlines.ShowRect = false;
            this.dgvAirlines.Size = new System.Drawing.Size(867, 360);
            this.dgvAirlines.TabIndex = 0;
            this.dgvAirlines.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.dgvAirlines.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAirlines_CellContentClick);
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiMarkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiMarkLabel1.Location = new System.Drawing.Point(210, 13);
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(418, 60);
            this.uiMarkLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiMarkLabel1.TabIndex = 3;
            this.uiMarkLabel1.Text = "QUẢN LÝ HÃNG HÀNG KHÔNG";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiMarkLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton1.Location = new System.Drawing.Point(715, 465);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(154, 35);
            this.uiButton1.TabIndex = 4;
            this.uiButton1.Text = "Thêm mới";
            this.uiButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Sunny.UI.Demo.Properties.Resources._3597075__1_;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.ToolTipText = "Sửa";
            this.dataGridViewImageColumn1.Width = 165;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Sunny.UI.Demo.Properties.Resources._6048190__1_;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.ToolTipText = "Xóa";
            this.dataGridViewImageColumn2.Width = 165;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sunny.UI.Demo.Properties.Resources.plane1;
            this.pictureBox1.Location = new System.Drawing.Point(584, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton2.Location = new System.Drawing.Point(564, 465);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(128, 35);
            this.uiButton2.TabIndex = 6;
            this.uiButton2.Text = "Tải lại";
            this.uiButton2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // STT
            // 
            this.STT.HeaderText = "ID";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // name
            // 
            this.name.HeaderText = "Tên Hãng Hàng Không";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // numOfPlane
            // 
            this.numOfPlane.HeaderText = "Số Lượng Máy Bay";
            this.numOfPlane.Name = "numOfPlane";
            this.numOfPlane.ReadOnly = true;
            // 
            // _sua
            // 
            this._sua.HeaderText = "";
            this._sua.Image = global::Sunny.UI.Demo.Properties.Resources._3597075__1_;
            this._sua.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this._sua.Name = "_sua";
            this._sua.ReadOnly = true;
            this._sua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._sua.ToolTipText = "Sửa";
            // 
            // _xoa
            // 
            this._xoa.HeaderText = "";
            this._xoa.Image = global::Sunny.UI.Demo.Properties.Resources._6048190__1_;
            this._xoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this._xoa.Name = "_xoa";
            this._xoa.ReadOnly = true;
            this._xoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._xoa.ToolTipText = "Xóa";
            // 
            // ucQuanLyHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.uiMarkLabel1);
            this.Controls.Add(this.dgvAirlines);
            this.Name = "ucQuanLyHang";
            this.Size = new System.Drawing.Size(873, 519);
            this.Load += new System.EventHandler(this.ucDatVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirlines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UIDataGridView dgvAirlines;
        private UIMarkLabel uiMarkLabel1;
        private UIButton uiButton1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UIButton uiButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfPlane;
        private System.Windows.Forms.DataGridViewImageColumn _sua;
        private System.Windows.Forms.DataGridViewImageColumn _xoa;
    }
}
