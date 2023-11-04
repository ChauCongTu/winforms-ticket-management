using Sunny.UI.Demo.DAO;
using Sunny.UI.Demo.Model;
using Sunny.UI.Demo.Views.UserCtrl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sunny.UI.Demo.Views.NForm.Tickets
{
    public partial class edit : Form
    {
        Ticket ticket;
        public edit(Ticket ticket)
        {
            InitializeComponent();
            this.ticket = ticket;
            lbTicketId.Text = "#" + ticket.TicketId;
            cbClass.DataSource = new DAO_TicketClass().getAll();
            cbClass.ValueMember = "ClassId";
            cbClass.DisplayMember = "ClassType";
            cbClass.SelectedValue = ticket.ClassId;
            txtPrice.Text = ticket.PriceVnd.ToString();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            int err = 0;
            if (txtPrice.TextLength <= 0)
            {
                lbErrPrice.Text = "Vui lòng nhập đơn giá.";
                lbErrPrice.ForeColor = Color.Red;
                err++;
            }
            else if (!ValidationHelper.IsNonNegativeInteger(txtPrice.Text))
            {
                lbErrPrice.Text = "Đơn giá phải là số nguyên dương.";
                lbErrPrice.ForeColor = Color.Red;
                err++;
            }
            if (err == 0)
            {
                ticket.PriceVnd = int.Parse(txtPrice.Text);
                ticket.ClassId = int.Parse(cbClass.SelectedValue.ToString());
                try
                {
                    new DAO_Ticket().add(ticket);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Lỗi");
                }
                MessageBox.Show("Cập nhật vé #" + ticket.TicketId + " thành công");
                this.Close();
                this.Hide();
            }
        }
    }
}
