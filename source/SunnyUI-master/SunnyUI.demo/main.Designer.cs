namespace Sunny.UI.Demo
{
    partial class main
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Đặt vé");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Quản lý Sân bay");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Quản lý Hãng hàng không");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Quản lý Máy bay");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Quản lý Chuyến Bay");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Quản lý Vé");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Quản lý Nhân viên");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Báo cáo Thống kê");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.uiNavMenu1 = new Sunny.UI.UINavMenu();
            this.mainPanel = new Sunny.UI.UIPanel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.uiAvatar = new Sunny.UI.UIAvatar();
            this.ulbName = new Sunny.UI.UILabel();
            this.uiPanel1.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.mainPanel);
            this.uiPanel1.Controls.Add(this.uiNavMenu1);
            this.uiPanel1.Controls.Add(this.uiPanel2);
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(2, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1404, 771);
            this.uiPanel1.TabIndex = 1;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanel2
            // 
            this.uiPanel2.BackColor = System.Drawing.Color.White;
            this.uiPanel2.Controls.Add(this.ulbName);
            this.uiPanel2.Controls.Add(this.uiAvatar);
            this.uiPanel2.Controls.Add(this.pbLogo);
            this.uiPanel2.FillColor = System.Drawing.Color.White;
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(1, 0);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(1399, 152);
            this.uiPanel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel2.TabIndex = 2;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiNavMenu1
            // 
            this.uiNavMenu1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiNavMenu1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.uiNavMenu1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiNavMenu1.FullRowSelect = true;
            this.uiNavMenu1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.uiNavMenu1.ItemHeight = 50;
            this.uiNavMenu1.Location = new System.Drawing.Point(0, 154);
            this.uiNavMenu1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiNavMenu1.Name = "uiNavMenu1";
            treeNode1.Name = "datVe";
            treeNode1.Text = "Đặt vé";
            treeNode2.Name = "quanLySanBay";
            treeNode2.Text = "Quản lý Sân bay";
            treeNode3.Name = "quanLyHang";
            treeNode3.Text = "Quản lý Hãng hàng không";
            treeNode4.Name = "quanLyMayBay";
            treeNode4.Text = "Quản lý Máy bay";
            treeNode5.Name = "quanLyChuyenBay";
            treeNode5.Text = "Quản lý Chuyến Bay";
            treeNode6.Name = "quanLyVe";
            treeNode6.Text = "Quản lý Vé";
            treeNode7.Name = "quanLyNhanVien";
            treeNode7.Text = "Quản lý Nhân viên";
            treeNode8.Name = "baoCaoThongKe";
            treeNode8.Text = "Báo cáo Thống kê";
            this.uiNavMenu1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.uiNavMenu1.ShowLines = false;
            this.uiNavMenu1.Size = new System.Drawing.Size(298, 613);
            this.uiNavMenu1.TabIndex = 3;
            this.uiNavMenu1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiNavMenu1.MenuItemClick += new Sunny.UI.UINavMenu.OnMenuItemClick(this.uiNavMenu1_MenuItemClick);
            // 
            // mainPanel
            // 
            this.mainPanel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainPanel.Location = new System.Drawing.Point(298, 154);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1102, 613);
            this.mainPanel.TabIndex = 4;
            this.mainPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = global::Sunny.UI.Demo.Properties.Resources._387816921_3010352259098655_2780024891844508024_n;
            this.pbLogo.Location = new System.Drawing.Point(9, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(265, 136);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // uiAvatar
            // 
            this.uiAvatar.AvatarSize = 80;
            this.uiAvatar.BackColor = System.Drawing.Color.Transparent;
            this.uiAvatar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uiAvatar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiAvatar.Location = new System.Drawing.Point(1265, 45);
            this.uiAvatar.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar.Name = "uiAvatar";
            this.uiAvatar.Size = new System.Drawing.Size(60, 60);
            this.uiAvatar.Style = Sunny.UI.UIStyle.Custom;
            this.uiAvatar.TabIndex = 1;
            this.uiAvatar.Text = "uiAvatar1";
            this.uiAvatar.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ulbName
            // 
            this.ulbName.BackColor = System.Drawing.Color.Transparent;
            this.ulbName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ulbName.Location = new System.Drawing.Point(1201, 108);
            this.ulbName.Name = "ulbName";
            this.ulbName.Size = new System.Drawing.Size(198, 23);
            this.ulbName.TabIndex = 2;
            this.ulbName.Text = "Châu Quế Nhơn";
            this.ulbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ulbName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 771);
            this.Controls.Add(this.uiPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "Phần mềm quản lý đặt vé máy bay - MixiVivu";
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private UIPanel uiPanel1;
        private UIPanel uiPanel2;
        private UINavMenu uiNavMenu1;
        private UIPanel mainPanel;
        private UILabel ulbName;
        private UIAvatar uiAvatar;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}