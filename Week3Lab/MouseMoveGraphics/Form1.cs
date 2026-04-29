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
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics paper = pictureBoxDisplay.CreateGraphics();
                SolidBrush brush = new SolidBrush(Color.Orange);
                Pen pen1 = new Pen(Color.Black, 2);
                paper.FillEllipse(brush, e.X, e.Y, 50, 50);
                paper.DrawEllipse(pen1, e.X, e.Y, 50, 50);

            }
        }
        //set color is not working now.
        private void buttonSetColour_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }
    }
}
