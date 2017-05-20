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

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            g.DrawEllipse(new Pen(Color.Red), e.Location.X, e.Location.Y, 40, 40);
            //Circle c = new Circle();
            //c.draw(e.Location.X, e.Location.Y);


            pictureBox1.Refresh();
        }
        public void move(int x)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
