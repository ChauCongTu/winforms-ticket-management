using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sunny.UI.Demo.Views.UserCtrl;

namespace Sunny.UI.Demo.Views
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void nmAside_MenuItemClick(TreeNode node, NavMenuItem item, int pageIndex)
        {
            if (node.Tag.ToString() == "DV")
            {
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(new ucDatVe());
            }
            else
            {
                mainPanel.Controls.Clear();
            }
        }
    }
}
