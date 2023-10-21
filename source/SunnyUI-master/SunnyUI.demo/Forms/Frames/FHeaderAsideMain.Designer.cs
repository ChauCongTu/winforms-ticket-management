namespace Sunny.UI.Demo
{
    partial class FHeaderAsideMain
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
            this.uiLogo1 = new Sunny.UI.UILogo();
            this.SuspendLayout();
            // 
            // Aside
            // 
            this.Aside.LineColor = System.Drawing.Color.Black;
            this.Aside.Size = new System.Drawing.Size(250, 575);
            // 
            // Header
            // 
            this.Header.Size = new System.Drawing.Size(1024, 110);
            // 
            // uiLogo1
            // 
            this.uiLogo1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLogo1.Location = new System.Drawing.Point(3, 65);
            this.uiLogo1.MaximumSize = new System.Drawing.Size(300, 80);
            this.uiLogo1.MinimumSize = new System.Drawing.Size(300, 80);
            this.uiLogo1.Name = "uiLogo1";
            this.uiLogo1.Size = new System.Drawing.Size(300, 80);
            this.uiLogo1.TabIndex = 1;
            this.uiLogo1.Text = "uiLogo1";
            this.uiLogo1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // FHeaderAsideMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1024, 720);
            this.Controls.Add(this.uiLogo1);
            this.Name = "FHeaderAsideMain";
            this.Text = "FHeaderAsideMain";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 1024, 720);
            this.Controls.SetChildIndex(this.Header, 0);
            this.Controls.SetChildIndex(this.Aside, 0);
            this.Controls.SetChildIndex(this.uiLogo1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private UILogo uiLogo1;
    }
}