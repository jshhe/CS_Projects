using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDrawLine_Click(object sender, EventArgs e)
        {
            //Create the graphics and pen objects 
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen pen1 = new Pen(Color.Blue, 5);
            //Draw a line using the coordinates given 
            paper.DrawLine(pen1, 10, 10, 100, 100);
        }

        private void buttonDrawSquare_Click(object sender, EventArgs e)
        {
            //Create the graphics and pen objects 
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen pen1 = new Pen(Color.Blue, 5);
            //Draw a square using the coordinates given 
            paper.DrawLine(pen1, 50, 50, 150, 50);
            paper.DrawLine(pen1, 150, 50, 150, 150);
            paper.DrawLine(pen1, 150, 150, 50, 150);
            paper.DrawLine(pen1, 50, 150, 50, 50);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //Click this will kill this application
            this.Close();
        }
    }
}
