using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Please, enter a valid number");
            }






            //try
            //{
            //    string first = textBox1.Text;
            //    string second = textBox2.Text;
            //    string result = textBox3.Text;
            //    result = (Convert.ToInt32(first) + Convert.ToInt32(second)).ToString();
            //}
            //catch
            //{
            //    MessageBox.Show("Please, enter a valid number");
            //}




            //for (int i = 0; i < first.Length; i++)
            //{
            //    if (first[i] >= 'a' && first[i] <= 'z' || first[i] >= 'A' && first[i] <= 'Z')
            //    {
            //        MessageBox.Show("1. Please, enter a valid number");
            //        break;
            //    }
            //    else
            //    {
            //        result = (int.Parse(first) + int.Parse(second)).ToString();
            //    }
            //}
            //for (int i = 0; i < second.Length; i++)
            //{
            //    if (second[i] >= 'a' && second[i] <= 'z' || second[i] >= 'A' && second[i] <= 'Z')
            //    {
            //        MessageBox.Show("2. Please, enter a valid number");
            //        break;
            //    }
            //    else
            //    {
            //        result = (int.Parse(first) + int.Parse(second)).ToString();
            //    }
            //}



            //int first = Convert.ToInt32(textBox1.Text);
            //int second = Convert.ToInt32(textBox2.Text);
            //textBox3.Text = (first + second).ToString();

        }

        
    }
}
