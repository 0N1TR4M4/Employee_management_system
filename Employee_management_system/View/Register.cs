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
            if (txt.UserName.Text == "" && txtPassword.Text == "" && txtComPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields  are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtComPassword.Text) 
            {
                con.Open();
                stirng register  = "INSER INTO tbl.users VALUES ('" + txtUsername )
            }
        } 
    }
}
