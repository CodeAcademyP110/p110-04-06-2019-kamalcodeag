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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //---Simple way---
            //string name = txtName.Text;
            //string number = txtNumber.Text;
            //lstContacts.Items.Add(name + " " + number);
            //txtName.Text = "";
            //txtNumber.Text = "";


            //---Class way---
            
            PhoneBook.AddContact(txtName.Text, txtNumber.Text);

            //--Loop--
            foreach (KeyValuePair<string, string> contact in PhoneBook.GetContact())
            {
                if(contact.Key != null && contact.Value != null)
                {
                    lstContacts.Items.Add(contact.Key + " " + contact.Value);
                    txtName.Text = txtNumber.Text = "";
                }
                else
                {
                    MessageBox.Show("xxx");
                }
                
            }

            //--DataSource--
            //lstContacts.DataSource = null;
            //lstContacts.DataSource = PhoneBook.GetContact();
        }

        private void FindNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
