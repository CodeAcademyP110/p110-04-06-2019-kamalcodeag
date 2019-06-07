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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (var contact in PhoneBook.GetContact())
            {
                comboBox1.Items.Add(contact.Key);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox1.Text);
            PhoneBook.RemoveContact(comboBox1.Text);
            comboBox1.Items.Clear();
            foreach (var contact in PhoneBook.GetContact())
            {
                comboBox1.Items.Add(contact.Key);
            }
        }

        
    }
}
