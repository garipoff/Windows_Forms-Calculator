using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float a, b;
        int count;
        bool znak = true;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
            textBox1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
            textBox1.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
            textBox1.Focus();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
            textBox1.Focus();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
            textBox1.Focus();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
            textBox1.Focus();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
            textBox1.Focus();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            znak = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            znak = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            znak = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            znak = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            calculate();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = textBox1.Text.Length;
            textBox1.Focus();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            if (textBox1.Text.IndexOf(",") == -1)
            {
                textBox1.Text += ",";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.Text = Math.Sqrt(double.Parse(textBox1.Text)).ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.Text = Math.Pow(double.Parse(textBox1.Text),2).ToString();
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add)
            {
                textBox1.Focus();
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 5;
                znak = true;
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                textBox1.Focus();
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 6;
                znak = true;
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                textBox1.Focus();
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 7;
                znak = true;
            }
            else if (e.KeyCode == Keys.Divide)
            {
                textBox1.Focus();
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 8;
                znak = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                calculate1();
            }

            else if (e.KeyCode == Keys.Clear)
            {
                textBox1.Focus();
                int lenght = textBox1.Text.Length - 1;
                string text = textBox1.Text;
                textBox1.Clear();
                for (int i = 0; i < lenght; i++)
                {
                    textBox1.Text = textBox1.Text + text[i];
                }
            }
            else if (e.KeyCode == Keys.Delete)
            {
                textBox1.Text="0";
                textBox1.SelectionStart = 0;
                textBox1.SelectionLength = textBox1.Text.Length;
                textBox1.Focus();
            }

            }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 44)
            {
                if (textBox1.Text.IndexOf(",") != -1)
                {
                    e.Handled = true;
                }
            }
            
            else if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && e.KeyChar != 47 && e.KeyChar != 61)             {
                e.Handled = true;
            }
        }

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;

                default:
                    break;
            }

        }

        private void calculate1()
        {
            switch (count)
            {
                case 5:
                    
                    b = a + float.Parse(textBox1.Text.Trim(new char[] { '+' }));
                    textBox1.Text = b.ToString();
                    break;
                case 6:
                    
                    b = a - float.Parse(textBox1.Text.Trim(new char[] { '-' }));
                    textBox1.Text = b.ToString();
                    break;
                case 7:
                    b = a * float.Parse(textBox1.Text.Trim(new char[] { '*' }));
                    textBox1.Text = b.ToString();
                    break;
                case 8:
                    b = a / float.Parse(textBox1.Text.Trim(new char[] { '/' }));
                    textBox1.Text = b.ToString();
                    break;

                default:
                    break;
            }

        }
    }
}
