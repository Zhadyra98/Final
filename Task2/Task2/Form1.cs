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
            if (int.Parse(button1.Text) % 2 == 0)
            {
                int a = int.Parse(button1.Text);
                int b = int.Parse(textBox1.Text);
                button1.Text = (a + 1).ToString();
                textBox1.Text=(b+1).ToString();

            }
        }
    }
}
