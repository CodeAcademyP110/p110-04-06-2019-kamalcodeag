using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P110_WinForm_demo
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chShowPassword.Checked;
            //if(chShowPassword.Checked)
            //{
            //    txtPassword.UseSystemPasswordChar = false;
            //}
            //else
            //{
            //    txtPassword.UseSystemPasswordChar = true;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if(username == "" || password == "")
            {
                MessageBox.Show("Username or password is empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(username.ToLower() != "admin" || password.ToLower() != "admin123@")
            {
                MessageBox.Show("Username or password is wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Dashboard dashboard = new Dashboard();
            dashboard.Show();

        }
    }
}
