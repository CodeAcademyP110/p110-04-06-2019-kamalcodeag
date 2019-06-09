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
            menu.Font = new Font("IDAutomationSHC39S", 12, FontStyle.Regular);
            foreach (var category in Market.GetCategory())
            {
                cmbCategory.Items.Add(category.Name);
            }
            cmbCategory.SelectedIndex = 0;
        }

        private void ResetFields()
        {
            txtName.Text = "";
            nmrCount.Value = 0;
            nmrPrice.Value = 0;
            chckDisc.Checked = false;
            nmrPercent.Value = 0;
        }
        private bool Validation(string txtName, decimal nmrCount, decimal nmrPrice)
        {
            if (txtName.Trim() != "" && nmrCount != 0 && nmrPrice != 0)
            {
                for (int i = 0; i < txtName.Length; i++)
                {
                    if ((char)txtName[i] >= 'a' && (char)txtName[i] <= 'z' || (char)txtName[i] >= 'A' && (char)txtName[i] <= 'Z')
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void ProductAdding()
        {
            string name = txtName.Text;
            string cat = cmbCategory.SelectedItem.ToString();
            decimal count = nmrCount.Value;
            decimal price = nmrPrice.Value;
            bool discount = chckDisc.Checked;
            decimal percent = nmrPercent.Value;

            if (Validation(name, count, price))
            {
                Product product = new Product(name, cat, count, price, discount, percent);
                Market.AddProduct(product);
                dtgridList.DataSource = null;
                dtgridList.DataSource = Market.GetProduct();

                //foreach (var pro in Market.GetProduct())
                //{

                //}
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa,boşluqları doldurun və məhsulun adını Azərbaycan Dilinin hərflərinə uyğun olaraq təyin edin","Səhv",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void ChckDisc_CheckedChanged(object sender, EventArgs e)
        {
            if (chckDisc.Checked == true)
            {
                lblPercent.Visible = true;
                nmrPercent.Visible = true;
            }
            else
            {
                lblPercent.Visible = false;
                nmrPercent.Visible = false;
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ProductAdding();
            ResetFields();
        }

        private void MenuDelete_Click(object sender, EventArgs e)
        {
            foreach (var product in Market.GetProduct())
            {
                if (product != null)
                {
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Zəhmət olmasa,boşluqları doldurun və məhsulun adını Azərbaycan Dilinin hərflərinə uyğun olaraq təyin edin", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

      
    }
}
