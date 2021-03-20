using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public string no1;
        String num = "";
        Double result;
        bool oper = false;
        bool showresult = false;
        public Form1()
        {
            InitializeComponent();
            no1 = "";
            result = 0;
            operation.Text = "";
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (oper))
            {
                textBox1.Clear();
            }

            if (showresult)
            {
                textBox1.Clear();
                showresult = false;
            }

            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
            oper = false;
        }

        private void operator_c(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = 0;
            textBox1.Text = "0";
            operation.Text = "";
        }

        private void operator_ce(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void operator_bp(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            int n = no1.Length;
            if (n > 0)
            {
                textBox1.Text = (no1.Substring(0, n - 1));
            }
        }

        private void plusminus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("-"))
            {
                textBox1.Text = textBox1.Text.Remove(0, 1);
            }
            else
            {
                textBox1.Text = "-" + textBox1.Text;
            }
        }

        private void operator_current(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            result = Double.Parse(textBox1.Text);
            num = button.Text;
            operation.Text = result + " " + num;
            oper = true;
            textBox1.Text = "";
        }

        private void operator_calculation(object sender, EventArgs e)
        {

            switch (num)
            {
                case "+":
                    operation.Text = result + " " + num + " " + Double.Parse(textBox1.Text) + " =";
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "−":
                    operation.Text = result + " " + num + " " + Double.Parse(textBox1.Text) + " =";
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "÷":
                    operation.Text = result + " " + num + " " + Double.Parse(textBox1.Text) + " =";
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
                case "×":
                    operation.Text = result + " " + num + " " + Double.Parse(textBox1.Text) + " =";
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            oper = false;
            result = Double.Parse(textBox1.Text);
            showresult = true;
        }
    }
}