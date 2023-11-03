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

namespace Sunny.UI.Demo.Views.NForm.Employees
{
    public partial class detail : Form
    {

        User user;
        public detail()
        {
            InitializeComponent();
        }
        public detail(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void detail_Load(object sender, EventArgs e)
        {
            txtName.Text = user.UserName;
            txtEmail.Text = user.EmailAddress;
            txtRole.Text = user.Role;
            txtGender.Text = user.Gender;
            txtSDT.Text = user.PhoneNumber;
            txtStatus.Text = user.Status;
            rtxtAddress.Text = user.Address;
        }

        private void uiTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            User users = new DAO_User().getById(user.UserId);
            NForm.Employees.edit editForm = new NForm.Employees.edit(users);
            editForm.ShowDialog();
            this.Hide();
            this.Close();
            
        }
    }
}
