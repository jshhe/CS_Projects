using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeightorNot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxHeight.Text, out double height))
            {
                if (height >= 6 && height <= 7)
                {
                    MessageBox.Show("You are very tall.");
                }
                else if (height > 5)
                {
                    MessageBox.Show("You are tall.");
                }
                else
                {
                    MessageBox.Show("You are of medium height");
                }
            }
            else
            {
                MessageBox.Show("Invalid input.");
            }
        }
    }
}