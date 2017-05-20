using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bmp;
        
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
        }
        int x, x1;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.Location.Y;
            x1 = e.Location.X;
            
           g.FillEllipse(Brushes.Red, e.Location.X, e.Location.Y, 40, 40);
            
            //move(e.Location.X);
            
            // c = new Circle(e.Location.X, e.Location.Y);
            
            pictureBox1.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = x + 10;

            //g.DrawEllipse(new Pen(Color.Red), x1, x, 40, 40);
  
        }
    }
}
