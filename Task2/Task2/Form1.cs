using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button1.Text) % 2 == 0 && int.Parse(button1.Text) != 0)
            {
                int a = int.Parse(button1.Text);
                int b = int.Parse(textBox1.Text);
                button1.Text = (a + 1).ToString();
                textBox1.Text=(b+1).ToString();

            }
            else
            {
                int a = int.Parse(button1.Text);
                button1.Text = (a + 1).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(button2.Text);
            if (int.Parse(button2.Text) % 2 == 0 && a!=0)
            {   
                int b = int.Parse(textBox1.Text);
                button2.Text = (a + 1).ToString();
                textBox1.Text = (b + 1).ToString();

            }
            else
            {
                button2.Text = (a + 1).ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int a = int.Parse(button7.Text);
            if (a % 2 == 0 && a != 0)
            {
                int b = int.Parse(textBox1.Text);
                button7.Text = (a + 1).ToString();
                textBox1.Text = (b + 1).ToString();

            }
            else
            {
                button7.Text = (a + 1).ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = int.Parse(button5.Text);
            if (a % 2 == 0 && a != 0)
            {
                int b = int.Parse(textBox1.Text);
                button5.Text = (a + 1).ToString();
                textBox1.Text = (b + 1).ToString();

            }
            else
            {
                button5.Text = (a + 1).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(button4.Text);
            if (a % 2 == 0 && a != 0)
            {
                int b = int.Parse(textBox1.Text);
                button4.Text = (a + 1).ToString();
                textBox1.Text = (b + 1).ToString();

            }
            else
            {
                button4.Text = (a + 1).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(button3.Text);
            if (a % 2 == 0 && a != 0)
            {
                int b = int.Parse(textBox1.Text);
                button3.Text = (a + 1).ToString();
                textBox1.Text = (b + 1).ToString();

            }
            else
            {
                button3.Text = (a + 1).ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = int.Parse(button6.Text);
            if (a % 2 == 0 && a != 0)
            {
                int b = int.Parse(textBox1.Text);
                button6.Text = (a + 1).ToString();
                textBox1.Text = (b + 1).ToString();

            }
            else
            {
                button6.Text = (a + 1).ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a = int.Parse(button8.Text);
            if (a % 2 == 0 && a != 0)
            {
                int b = int.Parse(textBox1.Text);
                button8.Text = (a + 1).ToString();
                textBox1.Text = (b + 1).ToString();

            }
            else
            {
                button8.Text = (a + 1).ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int a = int.Parse(button9.Text);
            if (a % 2 == 0 && a != 0)
            {
                int b = int.Parse(textBox1.Text);
                button9.Text = (a + 1).ToString();
                textBox1.Text = (b + 1).ToString();

            }
            else
            {
                button9.Text = (a + 1).ToString();
            }
        }
    }
}
