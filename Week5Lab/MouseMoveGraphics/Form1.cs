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
        Random randomGenerator = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics paper = pictureBoxDisplay.CreateGraphics();
                int r = randomGenerator.Next(0, 256);
                int g = randomGenerator.Next(0, 256);
                int b = randomGenerator.Next(0, 256);
                SolidBrush br = new SolidBrush(Color.FromArgb(r, g, b));
                int numberOfCircles = randomGenerator.Next(1, 11);
                int counter = 1;
                int size = randomGenerator.Next(2, 11);
                int xPos = randomGenerator.Next(e.X - 10, e.X + 11);
                int yPos = randomGenerator.Next(e.Y - 10, e.Y + 11);
                while (counter < numberOfCircles)
                {
                    paper.FillEllipse(br, xPos, yPos, size, size);
                    counter++;
                }
            }
        }
    }
}
