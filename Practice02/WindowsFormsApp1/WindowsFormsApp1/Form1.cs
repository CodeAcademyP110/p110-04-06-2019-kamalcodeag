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
        private int divideResult;
        private int divideNumber1;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblScreen.Text) != 0)
            {
                lblScreen.Text += btnZero.Text;
            }
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == btnZero.Text)
            {
                lblScreen.Text = "";
            };
            lblScreen.Text += btnOne.Text;


        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == btnZero.Text)
            {
                lblScreen.Text = "";
            }

            lblScreen.Text += btnTwo.Text;

        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == btnZero.Text)
            {
                lblScreen.Text = "";
            };
            lblScreen.Text += btnThree.Text;
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == btnZero.Text)
            {
                lblScreen.Text = "";
            };
            lblScreen.Text += btnFour.Text;
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == btnZero.Text)
            {
                lblScreen.Text = "";
            };
            lblScreen.Text += btnFive.Text;
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == btnZero.Text)
            {
                lblScreen.Text = "";
            };
            lblScreen.Text += btnSix.Text;
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == btnZero.Text)
            {
                lblScreen.Text = "";
            };
            lblScreen.Text += btnSeven.Text;
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == btnZero.Text)
            {
                lblScreen.Text = "";
            }

            lblScreen.Text += btnEight.Text;

        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == btnZero.Text)
            {
                lblScreen.Text = "";
            };
            lblScreen.Text += btnNine.Text;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            lblScreen.Text = btnZero.Text;
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {

            //int divideResult = int.Parse(lblScreen.Text) / int.Parse(lblScreen.Text);
            int divideNumber1 = int.Parse(lblScreen.Text);
            int divideNumber2 = int.Parse(lblScreen.Text);



        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {

            if (divideResult >= 0)
            {
                lblScreen.Text = divideResult.ToString();
            }

        }
    }
}
