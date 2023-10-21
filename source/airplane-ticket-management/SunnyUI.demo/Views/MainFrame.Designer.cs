namespace Sunny.UI.Demo.Views
{
    partial class MainFrame
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Dashboard");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Đặt vé");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Quản lý Sân bay");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Quản lý Hãng hàng không");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Quản lý Máy bay");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Quản lý Chuyến Bay");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Quản lý Vé");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Quản lý Nhân viên");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.nmAside = new Sunny.UI.UINavMenu();
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.txtName = new Sunny.UI.UILabel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // nmAside
            // 
            this.nmAside.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nmAside.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.nmAside.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmAside.FullRowSelect = true;
            this.nmAside.ImeMode = System.Windows.Forms.ImeMode.On;
            this.nmAside.ItemHeight = 50;
            this.nmAside.Location = new System.Drawing.Point(-1, 135);
            this.nmAside.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.nmAside.Name = "nmAside";
            treeNode1.Name = "baoCaoThongKe";
            treeNode1.Tag = "BCTK";
            treeNode1.Text = "Dashboard";
            treeNode2.Name = "datVe";
            treeNode2.Tag = "DV";
            treeNode2.Text = "Đặt vé";
            treeNode3.Name = "quanLySanBay";
            treeNode3.Tag = "QLSB";
            treeNode3.Text = "Quản lý Sân bay";
            treeNode4.Name = "quanLyHang";
            treeNode4.Tag = "QLH";
            treeNode4.Text = "Quản lý Hãng hàng không";
            treeNode5.Name = "quanLyMayBay";
            treeNode5.Tag = "QLMB";
            treeNode5.Text = "Quản lý Máy bay";
            treeNode6.Name = "quanLyChuyenBay";
            treeNode6.Tag = "QLCB";
            treeNode6.Text = "Quản lý Chuyến Bay";
            treeNode7.Name = "quanLyVe";
            treeNode7.Tag = "QLV";
            treeNode7.Text = "Quản lý Vé";
            treeNode8.Name = "quanLyNhanVien";
            treeNode8.Tag = "QLNV";
            treeNode8.Text = "Quản lý Nhân viên";
            this.nmAside.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.nmAside.ShowLines = false;
            this.nmAside.Size = new System.Drawing.Size(259, 519);
            this.nmAside.Style = Sunny.UI.UIStyle.Custom;
            this.nmAside.TabIndex = 7;
            this.nmAside.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.nmAside.MenuItemClick += new Sunny.UI.UINavMenu.OnMenuItemClick(this.nmAside_MenuItemClick);
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.BackColor = System.Drawing.Color.Transparent;
            this.uiAvatar1.FillColor = System.Drawing.Color.White;
            this.uiAvatar1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiAvatar1.Location = new System.Drawing.Point(1007, 21);
            this.uiAvatar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(60, 60);
            this.uiAvatar1.Style = Sunny.UI.UIStyle.Custom;
            this.uiAvatar1.TabIndex = 10;
            this.uiAvatar1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(969, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(153, 23);
            this.txtName.Style = Sunny.UI.UIStyle.Custom;
            this.txtName.TabIndex = 12;
            this.txtName.Text = "Châu Quế Nhơn";
            this.txtName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Location = new System.Drawing.Point(258, 135);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(876, 519);
            this.mainPanel.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Sunny.UI.Demo.Properties.Resources.mixivivu2;
            this.pictureBox1.Location = new System.Drawing.Point(264, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(699, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = global::Sunny.UI.Demo.Properties.Resources.download1;
            this.pbLogo.Location = new System.Drawing.Point(-1, 6);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(259, 127);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 11;
            this.pbLogo.TabStop = false;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1133, 652);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.uiAvatar1);
            this.Controls.Add(this.nmAside);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrame";
            this.Text = "Phần mềm quản lý đặt vé máy bay - MixiVivu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UINavMenu nmAside;
        private UIAvatar uiAvatar1;
        private System.Windows.Forms.PictureBox pbLogo;
        private UILabel txtName;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}