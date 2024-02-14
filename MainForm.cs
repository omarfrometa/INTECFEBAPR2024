using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTEC.Solution
{
    public partial class MainForm : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;
        double saveResult;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            input += "0";
            txtResult.Text += input;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            input += "1";
            txtResult.Text += input;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            input += "2";
            txtResult.Text += input;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            input += "3";
            txtResult.Text += input;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            input += "4";
            txtResult.Text += input;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            input += "5";
            txtResult.Text += input;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            input += "6";
            txtResult.Text += input;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            input += "7";
            txtResult.Text += input;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            input += "8";
            txtResult.Text += input;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            input += "9";
            txtResult.Text += input;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            input += "+";
            txtResult.Text += input;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            input += "-";
            txtResult.Text += input;
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            input += "*";
            txtResult.Text += input;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            input += "/";
            txtResult.Text += input;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
        }

        private void btnClearPartial_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {

        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            input += ".";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            { 
                result = num1 + num2;
            }
            else if (operation == '-')
            {
                result = num1 - num2;
            }
            else if (operation == '*')
            {
                result = num1 * num2;
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    txtResult.Text = "Div/Zero";
                    return;
                }
            }

            txtResult.Text = result.ToString();
        }
    }
}
