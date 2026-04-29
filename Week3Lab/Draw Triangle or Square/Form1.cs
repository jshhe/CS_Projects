using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw_Triangle_or_Square
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void buttonDrawTriangle_Click(object sender, EventArgs e)
        {
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen PenBlack = new Pen(Color.Black);

            Point corner1 = new Point(50, 50);
            Point corner2 = new Point(100, 50);
            Point corner3 = new Point(100, 150);
            paper.DrawLine(PenBlack, corner1, corner2);
            paper.DrawLine(PenBlack, corner2, corner3);
            paper.DrawLine(PenBlack, corner3, corner1);

        }

        private void buttonDrawSquare_Click(object sender, EventArgs e)
        {
            int x = 200;
            int y = 80;
            int size = 60;
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen PenBlack = new Pen(Color.Black);
            paper.DrawRectangle(PenBlack, x, y, size, size);
        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            pictureBoxDisplay.Refresh();
        }
    }
}
