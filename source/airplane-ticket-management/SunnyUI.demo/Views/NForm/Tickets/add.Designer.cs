namespace Sunny.UI.Demo.Views.NForm.Tickets
{
    partial class add
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
            this.uiMarkLabel2 = new Sunny.UI.UIMarkLabel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.cbClass = new Sunny.UI.UIComboBox();
            this.lbErr = new Sunny.UI.UILabel();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPrice = new Sunny.UI.UITextBox();
            this.txtNumOfTicket = new Sunny.UI.UITextBox();
            this.lbErrPrice = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.lbNumTicketAlready = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiMarkLabel2
            // 
            this.uiMarkLabel2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiMarkLabel2.ForeColor = System.Drawing.Color.White;
            this.uiMarkLabel2.Location = new System.Drawing.Point(212, 31);
            this.uiMarkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiMarkLabel2.MarkColor = System.Drawing.Color.White;
            this.uiMarkLabel2.Name = "uiMarkLabel2";
            this.uiMarkLabel2.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.uiMarkLabel2.Size = new System.Drawing.Size(390, 81);
            this.uiMarkLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiMarkLabel2.TabIndex = 19;
            this.uiMarkLabel2.Text = "THÊM THÔNG TIN VÉ";
            this.uiMarkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiMarkLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = global::Sunny.UI.Demo.Properties.Resources.download1;
            this.pbLogo.Location = new System.Drawing.Point(26, 3);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(183, 118);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 18;
            this.pbLogo.TabStop = false;
            // 
            // cbClass
            // 
            this.cbClass.DataSource = null;
            this.cbClass.FillColor = System.Drawing.Color.White;
            this.cbClass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClass.Location = new System.Drawing.Point(33, 121);
            this.cbClass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbClass.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbClass.Name = "cbClass";
            this.cbClass.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbClass.Size = new System.Drawing.Size(300, 52);
            this.cbClass.TabIndex = 5;
            this.cbClass.Text = "-- Chọn tỉnh thành --";
            this.cbClass.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbClass.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // lbErr
            // 
            this.lbErr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lbErr.Location = new System.Drawing.Point(34, 178);
            this.lbErr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErr.Name = "lbErr";
            this.lbErr.Size = new System.Drawing.Size(635, 33);
            this.lbErr.Style = Sunny.UI.UIStyle.Custom;
            this.lbErr.TabIndex = 4;
            this.lbErr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbErr.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton2.Location = new System.Drawing.Point(219, 396);
            this.uiButton2.Margin = new System.Windows.Forms.Padding(4);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(119, 50);
            this.uiButton2.TabIndex = 3;
            this.uiButton2.Text = "Thêm";
            this.uiButton2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(28, 70);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(279, 46);
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "Hạng vé:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton1.Location = new System.Drawing.Point(346, 396);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(4);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(119, 50);
            this.uiButton1.TabIndex = 1;
            this.uiButton1.Text = "Đóng";
            this.uiButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtNumOfTicket);
            this.panel1.Controls.Add(this.lbErrPrice);
            this.panel1.Controls.Add(this.uiLabel5);
            this.panel1.Controls.Add(this.uiLabel4);
            this.panel1.Controls.Add(this.lbNumTicketAlready);
            this.panel1.Controls.Add(this.uiLabel2);
            this.panel1.Controls.Add(this.cbClass);
            this.panel1.Controls.Add(this.lbErr);
            this.panel1.Controls.Add(this.uiButton2);
            this.panel1.Controls.Add(this.uiLabel1);
            this.panel1.Controls.Add(this.uiButton1);
            this.panel1.Location = new System.Drawing.Point(2, 129);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 469);
            this.panel1.TabIndex = 17;
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(33, 275);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ShowText = false;
            this.txtPrice.Size = new System.Drawing.Size(636, 52);
            this.txtPrice.TabIndex = 12;
            this.txtPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPrice.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtNumOfTicket
            // 
            this.txtNumOfTicket.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumOfTicket.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOfTicket.Location = new System.Drawing.Point(346, 121);
            this.txtNumOfTicket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumOfTicket.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtNumOfTicket.Name = "txtNumOfTicket";
            this.txtNumOfTicket.ShowText = false;
            this.txtNumOfTicket.Size = new System.Drawing.Size(323, 52);
            this.txtNumOfTicket.TabIndex = 11;
            this.txtNumOfTicket.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNumOfTicket.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // lbErrPrice
            // 
            this.lbErrPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lbErrPrice.Location = new System.Drawing.Point(34, 332);
            this.lbErrPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErrPrice.Name = "lbErrPrice";
            this.lbErrPrice.Size = new System.Drawing.Size(635, 33);
            this.lbErrPrice.Style = Sunny.UI.UIStyle.Custom;
            this.lbErrPrice.TabIndex = 10;
            this.lbErrPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbErrPrice.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.Location = new System.Drawing.Point(28, 224);
            this.uiLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(279, 46);
            this.uiLabel5.TabIndex = 8;
            this.uiLabel5.Text = "Đơn giá:";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.Location = new System.Drawing.Point(341, 70);
            this.uiLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(279, 46);
            this.uiLabel4.TabIndex = 6;
            this.uiLabel4.Text = "Số lượng vé:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // lbNumTicketAlready
            // 
            this.lbNumTicketAlready.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumTicketAlready.Location = new System.Drawing.Point(331, 15);
            this.lbNumTicketAlready.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNumTicketAlready.Name = "lbNumTicketAlready";
            this.lbNumTicketAlready.Size = new System.Drawing.Size(165, 46);
            this.lbNumTicketAlready.TabIndex = 7;
            this.lbNumTicketAlready.Text = "2/300";
            this.lbNumTicketAlready.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbNumTicketAlready.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.Location = new System.Drawing.Point(196, 14);
            this.uiLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(142, 46);
            this.uiLabel2.TabIndex = 6;
            this.uiLabel2.Text = "Số lượng vé: ";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(705, 602);
            this.Controls.Add(this.uiMarkLabel2);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UIMarkLabel uiMarkLabel2;
        private System.Windows.Forms.PictureBox pbLogo;
        private UIComboBox cbClass;
        private UILabel lbErr;
        private UIButton uiButton2;
        private UILabel uiLabel1;
        private UIButton uiButton1;
        private System.Windows.Forms.Panel panel1;
        private UILabel uiLabel2;
        private UILabel lbNumTicketAlready;
        private UITextBox txtNumOfTicket;
        private UILabel lbErrPrice;
        private UILabel uiLabel5;
        private UILabel uiLabel4;
        private UITextBox txtPrice;
    }
}