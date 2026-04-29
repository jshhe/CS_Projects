using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 姓名 (Name): 巫凯
// 学号 (ID): 20253000087
namespace TraficlightDrawer
{
    public partial class Form1 : Form
    {
        Graphics paper;
        public Form1()
        {
            InitializeComponent();
            paper = pictureBoxDefault.CreateGraphics();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            paper.Clear(pictureBoxDefault.BackColor);
            textBoxInputSize.Clear();
            textBoxInputSize.Focus();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            int size = 0;
            try
            {
                size = int.Parse(textBoxInputSize.Text);
            }
            catch
            {
                MessageBox.Show("Invaild input!");
                return;
            }

            const int distance = 20;
            int x = 0;
            int y = 0;

            Pen blackPen = new Pen(Color.Black, 2);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush greenBrush = new SolidBrush(Color.Green);

            paper.FillEllipse(redBrush, x, y, size, size);
            paper.DrawEllipse(blackPen, x, y, size, size);
            y = y + size + distance;
            paper.FillEllipse(yellowBrush, x, y, size, size);
            paper.DrawEllipse(blackPen, x, y, size, size);
            y = y + size + distance;
            paper.FillEllipse(greenBrush, x, y, size, size);
            paper.DrawEllipse(blackPen, x, y, size, size);
        }
        }
    }