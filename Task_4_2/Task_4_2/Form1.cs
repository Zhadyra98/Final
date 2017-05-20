using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4_2
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bmp;
        int y;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            y = 200;
            e.Graphics.FillEllipse(Brushes.Red, 200, y, 40, 40);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            y += 50;
            e.Graphics.FillEllipse(Brushes.Red, 200, y, 40, 40);
        }
    }
}
