using Sunny.UI.Demo.DAO;
using Sunny.UI.Demo.Model;
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
                dgvCustomer.Rows.Add(customer.CustomerId, customer.CustomerName, customer.PhoneNumber, customer.EmailAddress, customer.Gender, customer.DateOfBirth);
            }
        }

        private void ucCustomer_Load(object sender, EventArgs e)
        {
            table_load();
        }
    }
}
