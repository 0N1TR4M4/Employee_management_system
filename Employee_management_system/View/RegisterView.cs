using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_management_system.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
           Employee employee = new Employee();
           if(txtUserName.Text == String.Empty)
            {
                MessageBox.Show("Please fill the username");
            }
           else if (txtPassword.Text == String.Empty)
            {
                MessageBox.Show("Please fill the password");
            }
           else
            {
                employee.UserName = txtUserName.Text;
                employee.Password = txtPassword.Text;
                registerController.AddUser(employee);
                MessageBox.Show ("User is registered")
                RegisterView RegisterView = new RegisterView();
                this.Hide();
                RegisterView.Show();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
