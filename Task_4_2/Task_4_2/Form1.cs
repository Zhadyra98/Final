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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 1;
            int y = 1;
            for(int i=1; i<=3; i++)
            {
                for(int j=1; j<=3; j++)
                {
                    
                    Button btn = new Button();
                    btn.Size = new Size(40, 40);
                    btn.Text = "0";
                    btn.Location=new Point(x,y);
                    x = x  + 40;
                    
                    Controls.Add(btn);
                }
                y = y + 40;
                x = 1;
            }
        }
    }
}
