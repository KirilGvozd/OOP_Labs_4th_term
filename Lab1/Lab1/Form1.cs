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

        private int _firstNumber, _secondNumber;
        private int _operation;
        private bool _positiveOrNegativeNumber = true;

        private void Calculate()
        {
            switch (_operation)
            {
                case 1:
                    _secondNumber = _firstNumber & int.Parse(TextBox.Text);
                    TextBox.Text = _secondNumber.ToString();
                    break;
                case 2:
                    _secondNumber = _firstNumber | int.Parse(TextBox.Text);
                    TextBox.Text = _secondNumber.ToString();
                    break;
                case 3:
                    _secondNumber = _firstNumber ^ int.Parse(TextBox.Text);
                    TextBox.Text = _secondNumber.ToString();
                    break;
                case 4:
                    _firstNumber = ~_firstNumber;
                    TextBox.Text = _firstNumber.ToString();
                    break;
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
            if (_positiveOrNegativeNumber)
            {
                TextBox.Text = "-" + TextBox.Text;
                _positiveOrNegativeNumber = false;
            }
            else if (_positiveOrNegativeNumber == false)
            {
                TextBox.Text = TextBox.Text.Replace("-", "");
                _positiveOrNegativeNumber = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _firstNumber = int.Parse(TextBox.Text);
            TextBox.Clear();
            _operation = 1;
            label1.Text = _firstNumber + "AND";
            _positiveOrNegativeNumber = true;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            _firstNumber = int.Parse(TextBox.Text);
            TextBox.Clear();
            _operation = 2;
            label1.Text = _firstNumber + "OR";
            _positiveOrNegativeNumber = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _firstNumber = int.Parse(TextBox.Text);
            TextBox.Clear();
            _operation = 3;
            label1.Text = _firstNumber + "NOR";
            _positiveOrNegativeNumber = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _firstNumber = int.Parse(TextBox.Text);
            TextBox.Clear();
            _operation = 4;
            label1.Text = _firstNumber + "NOT";
            _positiveOrNegativeNumber = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Calculate();
            label1.Text = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            TextBox.Text = "";
            label1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int length = TextBox.Text.Length - 1;
            string text = TextBox.Text;
            TextBox.Clear();
            for (int i = 0; i < length; i++)
            {
                TextBox.Text = TextBox.Text + text[i];
            }
        }


        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            string text = TextBox.Text;
            if (text != "")
            {
                int i = Convert.ToInt32(TextBox.Text);
                textBox1.Text = Convert.ToString(i, 2);
                textBox2.Text = Convert.ToString(i, 8);
                textBox3.Text = Convert.ToString(i, 16);
            }
        }
    }
}