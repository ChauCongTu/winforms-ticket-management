using Sunny.UI.Demo.DAO;
using Sunny.UI.Demo.Model;
using Sunny.UI.Demo.Views.NForm.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sunny.UI.Demo.Views.UserCtrl
{
    public partial class ucCustomer : UserControl
    {
        public ucCustomer()
        {
            InitializeComponent();
        }
        void table_load()
        {
            dgvCustomer.Rows.Clear();
            int i = 1;
            DAO_Customer daoCustomer = new DAO_Customer();
            List<Customer> customers = daoCustomer.getAll();
            foreach (Customer customer in customers)
            {
                dgvCustomer.Rows.Add(i ++, customer.CustomerId, customer.CustomerName, customer.PhoneNumber, customer.DateOfBirth.Value.ToString("dd/MM/yyyy"));
            }
        }
        private void dgvCustomer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];
            int id = 0;
            try
            {
                id = (int)row.Cells[1].Value;
            }
            catch (Exception ex)
            {

            }
            if (e.ColumnIndex == dgvCustomer.Columns["_sua"].Index)
            {
                Customer customer = new DAO_Customer().getById(id);
                DetailForm editForm = new DetailForm(customer, "edit");
                editForm.ShowDialog();
            }
            else if (e.ColumnIndex == dgvCustomer.Columns["_detail"].Index)
            {
                Customer customer = new DAO_Customer().getById(id);
                DetailForm editForm = new DetailForm(customer, "detail");
                editForm.ShowDialog();
            }
            else if (e.ColumnIndex == dgvCustomer.Columns["_xoa"].Index)
            {
                var result = MessageBox.Show("Bạn có chắc muốn xóa thông tin khách hàng này?",
                                                        "Xác nhận xóa",
                                                        MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow delRow = dgvCustomer.Rows[e.RowIndex];
                    DAO_Customer daoCutomer = new DAO_Customer();
                    try
                    {
                        daoCutomer.delete(id);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại.", "Lỗi");
                        return;
                    }
                    MessageBox.Show("Xóa thông tin khách hàng thành công", "Thành công");

                    table_load();
                }
                else
                {
                    table_load();
                }
            }
        }

        private void ucCustomer_Load(object sender, EventArgs e)
        {
            dgvCustomer.DefaultCellStyle.Font = new Font("Times New Roman", 13);
            this.table_load();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            DetailForm detailForm = new DetailForm();
            detailForm.ShowDialog();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.table_load();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Số căn cước")
                txtSearch.Text = "";
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 0)
                txtSearch.Text = "Số căn cước";
        }

        private void uiImageButton1_Click(object sender, EventArgs e)
        {
            Customer customer = new DAO_Customer().getByIdNumber(txtSearch.Text);
            if (customer.Gender == null)
            {
                MessageBox.Show("Không tìm thấy khách hàng này!", "Có lỗi");
                return;
            }
            DetailForm detailForm = new DetailForm(customer, "detail");
            detailForm.ShowDialog();
        }
    }
}
