using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseMoveGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            //Create the graphics and pen objects 
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen pen1 = new Pen(Color.Blue, 2);
            //Draw with the mouse from 0,0
            paper.DrawLine(pen1, 0, 0, e.X, e.Y);
            //if anyone want to replace 0,0 with the center,please del "//" and add "//" in the line above
            //int centerX = pictureBoxDisplay.Width / 2;
            //int centerY = pictureBoxDisplay.Height / 2;
            //paper.DrawLine(pen1, centerX, centerY, e.X, e.Y);
        }
    }
}
