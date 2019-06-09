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

        private void MenuHome_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (var product in Market.GetProduct())
            {
                cmbProduct.Items.Add(product.Ad);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seçilmiş məhsulu silməyə əminsiniz ?", "Təsdiq", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                Market.RemoveProduct(cmbProduct.SelectedItem.ToString());
                cmbProduct.Items.Clear();
                foreach (var product in Market.GetProduct())
                {
                    cmbProduct.Items.Add(product.Ad);
                }
                MessageBox.Show("Məhsul silindi");
            }
        }
    }
}
