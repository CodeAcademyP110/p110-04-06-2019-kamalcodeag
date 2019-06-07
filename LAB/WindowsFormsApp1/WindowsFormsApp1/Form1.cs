using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            if(textBox1.Text == admin.Username && textBox2.Text == admin.Password)
            {
                Form2 form2 = new Form2();
                form2.Show();
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Please,enter a valid username and password");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
