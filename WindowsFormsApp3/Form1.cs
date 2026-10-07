using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1 ()
        {
            InitializeComponent();
        }
        double num1, num2;
        string oper;

        private void button2_Click (object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button3_Click (object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button4_Click (object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button5_Click (object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button6_Click (object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button7_Click (object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button8_Click (object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button9_Click (object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button10_Click (object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                textBox1.Text += 0;
            }
            else if (textBox1.Text.Contains("0."))
            {
                textBox1.Text += 0;
            }
            
        }

        private void btn_add_Click (object sender, EventArgs e)
        {
            //
            num1 = double.Parse(textBox1.Text);
            textBox1.Text = string.Empty;
            oper = "+";
           
        }

        private void btn_equal_Click (object sender, EventArgs e)
        {
            num2 = double.Parse(textBox1.Text);
            textBox1.Text = string.Empty;
            switch (oper)
            {
                case "+":
                    textBox1.Text += (num1 + num2);
                    break;
                case "-":
                    textBox1.Text += (num1 - num2);
                    break;
                case "x":
                    textBox1.Text += (num1 * num2);
                    break;
                case "/":
                    textBox1.Text += (num1 / num2);
                    break;

            }
        }

        private void btn_sub_Click (object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            textBox1.Text = string.Empty;
            oper = "-";
        }

        private void btn_mul_Click (object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            textBox1.Text = string.Empty;
            oper = "x";
        }

        private void btn_div_Click (object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            textBox1.Text = string.Empty;
            oper = "/";
        }

        private void button11_Click (object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        private void button12_Click (object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void button1_Click (object sender, EventArgs e)
        {
            textBox1.Text +=  1;
        }
    }
}
