//Adrick Edinger

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _363_Calculator
{
    public partial class calc : Form
    {
        public calc()
        {
            InitializeComponent();
        }

        String operations;
        String displayTxt;
        double firstNum = 0.0;
        double secondNum;
        double result;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void display_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            this.display.Text += "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            this.display.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            this.display.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            this.display.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            this.display.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            this.display.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            this.display.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            this.display.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            this.display.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            this.display.Text += "9";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (firstNum == 0.0)
            {
                if (this.display.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a number.");
                }
                else
                {
                    firstNum = Convert.ToDouble(this.display.Text);
                }
            }
            this.display.Text = string.Empty;
            operations = "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (firstNum == 0.0)
            {
                if (this.display.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a number.");
                }
                else
                {
                    firstNum = Convert.ToDouble(this.display.Text);
                }
            }
            this.display.Text = string.Empty;
            operations = "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (firstNum == 0.0)
            {
                if (this.display.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a number.");
                }
                else
                {
                    firstNum = Convert.ToDouble(this.display.Text);
                }
            }
            this.display.Text = string.Empty;
            operations = "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (firstNum == 0.0)
            {
                if (this.display.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a number.");
                }
                else
                {
                    firstNum = Convert.ToDouble(this.display.Text);
                }
            }
            this.display.Text = string.Empty;
            operations = "/";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (this.display.Text == string.Empty) {
                secondNum = 0;
            }
            else {
                secondNum = Convert.ToDouble(this.display.Text);
            }

            calculate();
        }

        private void calculate()
        {
            if (operations == "+")
            {
                result = firstNum + secondNum;
                this.display.Text = Convert.ToString(result);
                firstNum = result;
            }
            else if (operations == "-")
            {
                result = firstNum - secondNum;
                this.display.Text = Convert.ToString(result);
                firstNum = result;
            }
            else if (operations == "*")
            {
                result = firstNum * secondNum;
                this.display.Text = Convert.ToString(result);
                firstNum = result;
            }
            else if (operations == "/")
            {
                result = firstNum / secondNum;
                this.display.Text = Convert.ToString(result);
                firstNum = result;
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            displayTxt = this.display.Text;

            if (!displayTxt.Contains(".")) {
                this.display.Text += ".";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.display.Text = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.display.Text = string.Empty;
            firstNum = 0;
            secondNum = 0;
            operations = "";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
