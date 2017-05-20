using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Task_4
{
    public class Circle
    {
        Pen p;
        Graphics g;
        public void draw (int x, int y)
        {
            g.FillEllipse(Brushes.Red, x, y, 40, 40);
        }
    }
}
