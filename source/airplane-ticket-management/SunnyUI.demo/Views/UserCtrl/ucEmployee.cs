using Sunny.UI.Demo.DAO;
using Sunny.UI.Demo.Model;
using Sunny.UI.Demo.Views.NForm.Airlines;
using Sunny.UI.Demo.Views.NForm.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using add = Sunny.UI.Demo.Views.NForm.Employees.add;

namespace Sunny.UI.Demo.Views.UserCtrl
{
    public partial class ucEmployee : UserControl
    {
        public ucEmployee()
        {
            InitializeComponent();
        }

        void table_load()
        {
            dgvEmployee.Rows.Clear();
            int i = 1;
            DAO_User daoUser = new DAO_User();
            List<User> users = daoUser.getAll();
            foreach (User user in users)
            {
                dgvEmployee.Rows.Add(user.UserId, user.UserName, user.Gender, user.Role, user.Address);
            }
        }

        private void ucEmployee_Load(object sender, EventArgs e)
        {
            table_load();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            table_load();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            add addForm = new add();
            addForm.ShowDialog();
        }

        private void dgvEmployee_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvEmployee.Rows[e.RowIndex];
            int id = 0;
            try
            {
                id = (int)row.Cells[0].Value;
            }
            catch (Exception ex)
            {

            }
            if (e.ColumnIndex == dgvEmployee.Columns["_sua"].Index)
            {
                User user = new DAO_User().getById(id);
                NForm.Employees.edit editForm = new NForm.Employees.edit(user);
                editForm.ShowDialog();
            }
            else if (e.ColumnIndex == dgvEmployee.Columns["_details"].Index || e.ColumnIndex == dgvEmployee.Columns["dgviId"].Index || e.ColumnIndex == dgvEmployee.Columns["dgviName"].Index || e.ColumnIndex == dgvEmployee.Columns["dgviGender"].Index || e.ColumnIndex == dgvEmployee.Columns["dgviRole"].Index || e.ColumnIndex == dgvEmployee.Columns["dgviAddress"].Index)
            {
                User user = new DAO_User().getById(id);
                NForm.Employees.detail detailForm = new NForm.Employees.detail(user);
                detailForm.ShowDialog();
            }
            else if (e.ColumnIndex == dgvEmployee.Columns["_xoa"].Index)
            {
                var result = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?",
                                                        "Xác nhận xóa",
                                                        MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow delRow = dgvEmployee.Rows[e.RowIndex];
                    DAO_User daoUser = new DAO_User();
                    try
                    {
                        daoUser.delete(id);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại.", "Lỗi");
                        return;
                    }
                    MessageBox.Show("Xóa nhân viên thành công", "Thành công");

                    table_load();
                }
                else
                {
                    table_load();
                }
            }
        }

        private void uiImageButton1_Click(object sender, EventArgs e)
        {
            dgvEmployee.Rows.Clear();
            int i = 1;
            DAO_User daoUser = new DAO_User();
            List<User> users = daoUser.findByName(txtSearch.Text);
            foreach(User user in users)
            {
                dgvEmployee.Rows.Add(user.UserId, user.UserName, user.Gender, user.Role, user.Address);
            }  
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Nhập tìm kiếm")
                txtSearch.Text = "";
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 0)
                txtSearch.Text = "Nhập tìm kiếm";
        }
    }
}
