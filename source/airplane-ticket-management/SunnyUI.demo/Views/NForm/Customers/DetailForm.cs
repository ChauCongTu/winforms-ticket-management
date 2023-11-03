using Sunny.UI.Demo.DAO;
using Sunny.UI.Demo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunny.UI.Demo.Views.NForm.Customers
{
    public partial class DetailForm : Form
    {
        Customer customer; 
        public DetailForm()
        {
            InitializeComponent();
            btnAdd.BringToFront();
            lbCustomerId.Text = "";
        }
        /// <summary>
        /// Call detail or edit form
        /// Using "edit": Open edit form
        /// Using "detail": Open detail form
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="mode">"edit"|"detail"</param>
        public DetailForm(Customer customer, string mode)
        {
            InitializeComponent();
            this.customer = customer;
            if (mode == "detail")
            {
                btnEdit.BringToFront();
                this.setReadOnly();
                this.loadData(customer);
            }
            else if (mode == "edit")
            {
                btnEditSave.BringToFront();
                this.setAllowWrite();
                this.loadData(customer);
            }
        }
        private void DetailForm_Load(object sender, EventArgs e)
        {

        }
        private void btnEditSave_Click(object sender, EventArgs e)
        {
            lbErr.Text = "";
            if (txtName.TextLength <= 0 || txtPhone.TextLength <= 0 || txtEmail.TextLength <= 0 || txtIdNumber.TextLength <= 0)
            {
                lbErr.Text = "Vui lòng nhập đẩy đủ thông tin khách hàng!";
            }
            else if (cbGender.SelectedItem == null)
            {
                lbErr.Text = "Vui lòng chọn giới tính!";
            }
            else if (dpDob.Value > DateTime.Now)
            {
                lbErr.Text = "Ngày sinh không hợp lệ!";
            }
            else if (!ValidationHelper.IsNonNegativeInteger(txtPhone.Text))
            {
                lbErr.Text = "Số điện thoại phải là số!";
            }
            else if (!ValidationHelper.IsEmail(txtEmail.Text))
            {
                lbErr.Text = "Địa chỉ Email không đúng định dạng!";
            }
            else if (txtIdNumber.TextLength != 12 || !ValidationHelper.IsNonNegativeInteger(txtIdNumber.Text))
            {
                lbErr.Text = "Số căn cước bao gồm 12 số không chứa ký tự";
            }
            else
            {
                customer.CustomerName = txtName.Text;
                customer.PhoneNumber = txtPhone.Text;
                customer.EmailAddress = txtEmail.Text;
                customer.IdNumber = txtIdNumber.Text;
                customer.Gender = cbGender.SelectedItem.ToString();
                customer.DateOfBirth = dpDob.Value;
                try
                {
                    new DAO_Customer().update(customer);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chỉnh sửa thông tin không thành công, vui lòng kiểm tra lại!\nLưu ý: Số căn cước của mỗi người là duy nhất!", "Có lỗi xảy ra");
                    return;
                }
                MessageBox.Show("Chỉnh sửa thông tin khách hàng thành công.", "Thành công");
                this.Close();
                this.Hide();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEditSave.BringToFront();
            this.setAllowWrite();
            this.loadData(customer);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbErr.Text = "";
            if (txtName.TextLength <= 0 || txtPhone.TextLength <= 0 || txtEmail.TextLength <= 0 || txtIdNumber.TextLength <=0)
            {
                lbErr.Text = "Vui lòng nhập đẩy đủ thông tin khách hàng!";
            }
            else if (cbGender.SelectedItem == null)
            {
                lbErr.Text = "Vui lòng chọn giới tính!";
            }
            else if (dpDob.Value > DateTime.Now)
            {
                lbErr.Text = "Ngày sinh không hợp lệ!";
            }
            else if (!ValidationHelper.IsNonNegativeInteger(txtPhone.Text))
            {
                lbErr.Text = "Số điện thoại phải là số!";
            }
            else if (!ValidationHelper.IsEmail(txtEmail.Text))
            {
                lbErr.Text = "Địa chỉ Email không đúng định dạng!";
            }
            else if (txtIdNumber.TextLength != 12 || !ValidationHelper.IsNonNegativeInteger(txtIdNumber.Text))
            {
                lbErr.Text = "Số căn cước bao gồm 12 số không chứa ký tự";
            }
            else
            {
                try
                {
                    new DAO_Customer().add(new Customer(0, txtName.Text, txtPhone.Text, txtEmail.Text, txtIdNumber.Text, cbGender.SelectedItem.ToString(), dpDob.Value));
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Thêm thông tin không thành công, vui lòng kiểm tra lại!\nLưu ý: Số căn cước của mỗi người là duy nhất!", "Có lỗi xảy ra");
                    return;
                }
                MessageBox.Show("Thêm thông tin khách hàng thành công.", "Thành công");
                this.Close();
                this.Hide();
            }
        }
        private void loadData(Customer customer)
        {
            lbCustomerId.Text = "ID: " + customer.CustomerId.ToString();
            txtName.Text = customer.CustomerName;
            txtPhone.Text = customer.PhoneNumber;
            txtEmail.Text = customer.EmailAddress;
            txtIdNumber.Text = customer.IdNumber;
            cbGender.SelectedItem = customer.Gender.ToString();
            dpDob.Value = customer.DateOfBirth.Value;
        }
        private void setReadOnly()
        {
            txtName.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtIdNumber.ReadOnly = true;
            cbGender.ReadOnly = true;
            dpDob.ReadOnly = true;
        }
        private void setAllowWrite()
        {
            txtName.ReadOnly = false;
            txtPhone.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtIdNumber.ReadOnly = false;
            cbGender.ReadOnly = false;
            dpDob.ReadOnly = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }
    }
}
