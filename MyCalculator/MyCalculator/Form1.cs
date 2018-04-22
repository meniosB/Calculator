using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string num1 = string.Empty;
        string num2 = string.Empty;
        char operation;
        double result = 0.0;
        bool after_equal = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "0";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (after_equal)
            {
                if (input.Contains("-"))
                {
                    this.label1.Text = "";
                    input += "1";
                    this.label1.Text += input;
                    after_equal = false;
                }
                else
                {
                    input = string.Empty;
                    this.label1.Text = "";
                    input += "1";
                    this.label1.Text += input;
                    after_equal = false;
                }
            }
            else
            {
                this.label1.Text = "";
                input += "1";
                this.label1.Text += input;
            }

        }

        private void two_Click(object sender, EventArgs e)
        {
            if (after_equal)
            {
                if (input.Contains("-"))
                {
                    this.label1.Text = "";
                    input += "2";
                    this.label1.Text += input;
                    after_equal = false;
                }
                else
                {
                    input = string.Empty;
                    this.label1.Text = "";
                    input += "2";
                    this.label1.Text += input;
                    after_equal = false;
                }
            }
            else
            {
                this.label1.Text = "";
                input += "2";
                this.label1.Text += input;
            }

        }

        private void three_Click(object sender, EventArgs e)
        {
            if (after_equal)
            {
                if (input.Contains("-"))
                {
                    this.label1.Text = "";
                    input += "3";
                    this.label1.Text += input;
                    after_equal = false;
                }
                else
                {
                    input = string.Empty;
                    this.label1.Text = "";
                    input += "3";
                    this.label1.Text += input;
                    after_equal = false;
                }
            }
            else
            {
                this.label1.Text = "";
                input += "3";
                this.label1.Text += input;
            }

        }

        private void four_Click(object sender, EventArgs e)
        {
            if (after_equal)
            {
                if (input.Contains("-"))
                {
                    this.label1.Text = "";
                    input += "4";
                    this.label1.Text += input;
                    after_equal = false;
                }
                else
                {
                    input = string.Empty;
                    this.label1.Text = "";
                    input += "4";
                    this.label1.Text += input;
                    after_equal = false;
                }
            }
            else
            {
                this.label1.Text = "";
                input += "4";
                this.label1.Text += input;
            }

        }

        private void five_Click(object sender, EventArgs e)
        {
            if (after_equal)
            {
                if (input.Contains("-"))
                {
                    this.label1.Text = "";
                    input += "5";
                    this.label1.Text += input;
                    after_equal = false;
                }
                else
                {
                    input = string.Empty;
                    this.label1.Text = "";
                    input += "5";
                    this.label1.Text += input;
                    after_equal = false;
                }
            }
            else
            {
                this.label1.Text = "";
                input += "5";
                this.label1.Text += input;
            }

        }

        private void six_Click(object sender, EventArgs e)
        {
            if (after_equal)
            {
                if (input.Contains("-"))
                {
                    this.label1.Text = "";
                    input += "6";
                    this.label1.Text += input;
                    after_equal = false;
                }
                else
                {
                    input = string.Empty;
                    this.label1.Text = "";
                    input += "6";
                    this.label1.Text += input;
                    after_equal = false;
                }
            }
            else
            {
                this.label1.Text = "";
                input += "6";
                this.label1.Text += input;
            }

        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (after_equal)
            {
                if (input.Contains("-"))
                {
                    this.label1.Text = "";
                    input += "7";
                    this.label1.Text += input;
                    after_equal = false;
                }
                else
                {
                    input = string.Empty;
                    this.label1.Text = "";
                    input += "7";
                    this.label1.Text += input;
                    after_equal = false;
                }
            }
            else
            {
                this.label1.Text = "";
                input += "7";
                this.label1.Text += input;
            }

        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (after_equal)
            {
                if (input.Contains("-"))
                {
                    this.label1.Text = "";
                    input += "8";
                    this.label1.Text += input;
                    after_equal = false;
                }
                else
                {
                    input = string.Empty;
                    this.label1.Text = "";
                    input += "8";
                    this.label1.Text += input;
                    after_equal = false;
                }
            }
            else
            {
                this.label1.Text = "";
                input += "8";
                this.label1.Text += input;
            }

        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (after_equal)
            {
                if (input.Contains("-"))
                {
                    this.label1.Text = "";
                    input += "9";
                    this.label1.Text += input;
                    after_equal = false;
                }
                else
                {
                    input = string.Empty;
                    this.label1.Text = "";
                    input += "9";
                    this.label1.Text += input;
                    after_equal = false;
                }

            }
            else
            {
                this.label1.Text = "";
                input += "9";
                this.label1.Text += input;
            }

        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (after_equal)
            {
                if (input.Contains("-"))
                {
                    this.label1.Text = "";
                    input += "0";
                    this.label1.Text += input;
                    after_equal = false;
                }
                else
                {
                    input = string.Empty;
                    this.label1.Text = "";
                    input += "0";
                    this.label1.Text += input;
                    after_equal = false;
                }
            }
            else
            {
                this.label1.Text = "";
                input += "0";
                this.label1.Text += input;
            }

        }

        private void comma_Click(object sender, EventArgs e)
        {
            if (this.label1.Text.Equals("0"))
            {
                this.label1.Text = "";
                input = string.Empty;
                input += "0.";
                this.label1.Text += input;
            }
            else if (this.label1.Text.Equals("-0"))
            {
                this.label1.Text = "";
                input = string.Empty;
                input += "-0.";
                this.label1.Text += input;
            }
            else
            {
                if (this.input.Contains(".") || after_equal)
                {
                    this.label1.Text = input;
                }
                else
                {
                    this.label1.Text = "";
                    input += ".";
                    this.label1.Text += input;
                }
            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.label1.Text = "0";
            this.input = string.Empty;
            this.num1 = string.Empty;
            this.num2 = string.Empty;
            this.operation = '\0';
            this.after_equal = false;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (input != "")
            {
                input = input.Remove(input.Length - 1);
                if (input.Length == 0)
                {
                    label1.Text = "0";
                }
                else
                {
                    label1.Text = input;
                }
            }
            else
            {
                label1.Text = "0";
            }

        }

        private void division_Click(object sender, EventArgs e)
        {
            if (operation == '\0')
            {
                num1 = input;
                operation = '/';
                input = string.Empty;
            }
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            if (operation == '\0')
            {
                num1 = input;
                operation = '*';
                input = string.Empty;
            }
        }

        private void subtraction_Click(object sender, EventArgs e)
        {

            if (input == "")
            {
                input += "-";
                label1.Text = input + "0";
            }
            else if (operation == '\0')
            {
                num1 = input;
                operation = '-';
                input = string.Empty;
            }
        }

        private void addition_Click(object sender, EventArgs e)
        {
            if (operation == '\0')
            {
                num1 = input;
                operation = '+';
                input = string.Empty;
            }

        }

        private void equals_Click(object sender, EventArgs e)
        {
            num2 = input;
            double n1, n2;
            double.TryParse(num1, out n1);
            double.TryParse(num2, out n2);

            this.input = string.Empty;
            this.num1 = string.Empty;
            this.num2 = string.Empty;

            if (operation == '+')
            {
                result = n1 + n2;
                label1.Text = result.ToString();
                input = result.ToString();
                after_equal = true;
            }
            else if (operation == '-')
            {
                result = n1 - n2;
                label1.Text = result.ToString();
                input = result.ToString();
                after_equal = true;
            }
            else if (operation == '*')
            {
                result = n1 * n2;
                label1.Text = result.ToString();
                input = result.ToString();
                after_equal = true;
            }
            else if (operation == '/')
            {
                if (n2 != 0)
                {
                    result = n1 / n2;
                    label1.Text = result.ToString();
                    input = result.ToString();
                    after_equal = true;
                }
                else
                {
                    label1.Text = "DIV/Zero!";
                }
            }

            this.operation = '\0';
        }
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.D1 || keyData == Keys.NumPad1)
            {
                one.PerformClick();
                return true;
            }else if (keyData == Keys.D2 || keyData == Keys.NumPad2)
            {
                two.PerformClick();
                return true;
            }
            else if (keyData == Keys.D3 || keyData == Keys.NumPad3)
            {
                three.PerformClick();
                return true;
            }
            else if (keyData == Keys.D4 || keyData == Keys.NumPad4)
            {
                four.PerformClick();
                return true;
            }
            else if (keyData == Keys.D5 || keyData == Keys.NumPad5)
            {
                five.PerformClick();
                return true;
            }
            else if (keyData == Keys.D6 || keyData == Keys.NumPad6)
            {
                six.PerformClick();
                return true;
            }
            else if (keyData == Keys.D7 || keyData == Keys.NumPad7)
            {
                seven.PerformClick();
                return true;
            }
            else if (keyData == Keys.D8 || keyData == Keys.NumPad8)
            {
                eight.PerformClick();
                return true;
            }
            else if (keyData == Keys.D9 || keyData == Keys.NumPad9)
            {
                nine.PerformClick();
                return true;
            }
            else if (keyData == Keys.D0 || keyData == Keys.NumPad0)
            {
                zero.PerformClick();
                return true;
            }
            else if (keyData == Keys.OemPeriod || keyData == Keys.Decimal)
            {
                comma.PerformClick();
                return true;
            }
            else if (keyData == Keys.Clear || keyData == Keys.Delete)
            {
                clear.PerformClick();
                return true;
            }
            else if (keyData == Keys.Back )
            {
                delete.PerformClick();
                return true;
            }
            else if (keyData == Keys.Divide)
            {
                division.PerformClick();
                return true;
            }
            else if (keyData == Keys.Multiply)
            {
                multiplication.PerformClick();
                return true;
            }
            else if (keyData == Keys.Subtract)
            {
                subtraction.PerformClick();
                return true;
            }
            else if (keyData == Keys.Add)
            {
                addition.PerformClick();
                return true;
            }
            else if (keyData == Keys.Enter)
            {
                equals.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        
    }
}
