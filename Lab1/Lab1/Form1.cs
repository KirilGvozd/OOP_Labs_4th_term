using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int firstNumber, secondNumber;
        private int opeation;
        private bool positiveOrNegativeNumber = true;

        private void Calculate()
        {
            switch (opeation)
            {
                case 1:
                    secondNumber = firstNumber & int.Parse(TextBox.Text);
                    TextBox.Text = secondNumber.ToString();
                    break;
                case 2:
                    secondNumber = firstNumber | int.Parse(TextBox.Text);
                    TextBox.Text = secondNumber.ToString();
                    break;
                case 3:
                    secondNumber = firstNumber ^ int.Parse(TextBox.Text);
                    TextBox.Text = secondNumber.ToString();
                    break;
                case 4:
                    firstNumber = ~firstNumber;
                    TextBox.Text = firstNumber.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TextBox.Text = TextBox.Text + 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TextBox.Text = TextBox.Text + 2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TextBox.Text = TextBox.Text + 3;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TextBox.Text = TextBox.Text + 4;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TextBox.Text = TextBox.Text + 5;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            TextBox.Text = TextBox.Text + 6;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            TextBox.Text = TextBox.Text + 7;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            TextBox.Text = TextBox.Text + 8;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            TextBox.Text = TextBox.Text + 9;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            TextBox.Text = TextBox.Text + 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (positiveOrNegativeNumber == true)
            {
                TextBox.Text = "-" + TextBox.Text;
                positiveOrNegativeNumber = false;
            }
            else if (positiveOrNegativeNumber == false)
            {
                TextBox.Text = TextBox.Text.Replace("-", "");
                positiveOrNegativeNumber = true;
            }
        }
    }
}