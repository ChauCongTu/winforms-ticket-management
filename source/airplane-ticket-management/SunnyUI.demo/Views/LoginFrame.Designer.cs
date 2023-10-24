namespace Sunny.UI.Demo.Views
{
    partial class LoginFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrame));
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.txtEmail = new Sunny.UI.UITextBox();
            this.txtPassword = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.btnLogin = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.lbMsgEmail = new Sunny.UI.UILabel();
            this.lbMsgPassword = new Sunny.UI.UILabel();
            this.lbForgotPassword = new Sunny.UI.UILabel();
            this.btnTooglePassword = new Sunny.UI.UIImageButton();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.txtPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTooglePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLabel2.Location = new System.Drawing.Point(472, 154);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(157, 42);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 14;
            this.uiLabel2.Text = "Địa chỉ Email:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(477, 199);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Radius = 10;
            this.txtEmail.ShowText = false;
            this.txtEmail.Size = new System.Drawing.Size(358, 46);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEmail.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtPassword
            // 
            this.txtPassword.Controls.Add(this.btnTooglePassword);
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtPassword.Location = new System.Drawing.Point(477, 319);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Radius = 10;
            this.txtPassword.ShowText = false;
            this.txtPassword.Size = new System.Drawing.Size(358, 46);
            this.txtPassword.Style = Sunny.UI.UIStyle.Custom;
            this.txtPassword.TabIndex = 17;
            this.txtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPassword.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLabel3.Location = new System.Drawing.Point(472, 276);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(119, 42);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 16;
            this.uiLabel3.Text = "Mật khẩu:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnLogin.Location = new System.Drawing.Point(577, 415);
            this.btnLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(149, 49);
            this.btnLogin.TabIndex = 18;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLabel1.Location = new System.Drawing.Point(504, 57);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(349, 75);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 13;
            this.uiLabel1.Text = "ĐĂNG NHẬP QUẢN TRỊ";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // lbMsgEmail
            // 
            this.lbMsgEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsgEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lbMsgEmail.Location = new System.Drawing.Point(472, 250);
            this.lbMsgEmail.Name = "lbMsgEmail";
            this.lbMsgEmail.Size = new System.Drawing.Size(358, 26);
            this.lbMsgEmail.Style = Sunny.UI.UIStyle.Custom;
            this.lbMsgEmail.TabIndex = 19;
            this.lbMsgEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMsgEmail.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.lbMsgEmail.Click += new System.EventHandler(this.lbMsgEmail_Click);
            // 
            // lbMsgPassword
            // 
            this.lbMsgPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsgPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lbMsgPassword.Location = new System.Drawing.Point(472, 370);
            this.lbMsgPassword.Name = "lbMsgPassword";
            this.lbMsgPassword.Size = new System.Drawing.Size(358, 26);
            this.lbMsgPassword.Style = Sunny.UI.UIStyle.Custom;
            this.lbMsgPassword.TabIndex = 20;
            this.lbMsgPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMsgPassword.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // lbForgotPassword
            // 
            this.lbForgotPassword.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForgotPassword.ForeColor = System.Drawing.Color.Red;
            this.lbForgotPassword.Location = new System.Drawing.Point(569, 482);
            this.lbForgotPassword.Name = "lbForgotPassword";
            this.lbForgotPassword.Size = new System.Drawing.Size(168, 42);
            this.lbForgotPassword.Style = Sunny.UI.UIStyle.Custom;
            this.lbForgotPassword.TabIndex = 21;
            this.lbForgotPassword.Text = "Quên mật khẩu?";
            this.lbForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbForgotPassword.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.lbForgotPassword.Click += new System.EventHandler(this.lbForgotPassword_Click);
            this.lbForgotPassword.MouseEnter += new System.EventHandler(this.lbForgotPassword_MouseEnter);
            this.lbForgotPassword.MouseLeave += new System.EventHandler(this.lbForgotPassword_MouseLeave_1);
            // 
            // btnTooglePassword
            // 
            this.btnTooglePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTooglePassword.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnTooglePassword.Image = global::Sunny.UI.Demo.Properties.Resources.eye;
            this.btnTooglePassword.Location = new System.Drawing.Point(310, 6);
            this.btnTooglePassword.Name = "btnTooglePassword";
            this.btnTooglePassword.Size = new System.Drawing.Size(41, 35);
            this.btnTooglePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTooglePassword.Style = Sunny.UI.UIStyle.Custom;
            this.btnTooglePassword.TabIndex = 3;
            this.btnTooglePassword.TabStop = false;
            this.btnTooglePassword.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnTooglePassword.Click += new System.EventHandler(this.btnTooglePassword_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.pbLogo.Image = global::Sunny.UI.Demo.Properties.Resources.download1;
            this.pbLogo.Location = new System.Drawing.Point(-2, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(455, 540);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 12;
            this.pbLogo.TabStop = false;
            // 
            // LoginFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 540);
            this.Controls.Add(this.lbForgotPassword);
            this.Controls.Add(this.lbMsgPassword);
            this.Controls.Add(this.lbMsgEmail);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.pbLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý đặt vé máy bay - MixiVivu";
            this.Load += new System.EventHandler(this.LoginFrame_Load);
            this.txtPassword.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnTooglePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private UILabel uiLabel2;
        private UITextBox txtEmail;
        private UITextBox txtPassword;
        private UILabel uiLabel3;
        private UIButton btnLogin;
        private UILabel uiLabel1;
        private UILabel lbMsgEmail;
        private UILabel lbMsgPassword;
        private UILabel lbForgotPassword;
        private UIImageButton btnTooglePassword;
    }
}