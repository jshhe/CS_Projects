using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addition_Table_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            int additionNumber;
            int numberOfLines;
            bool isNumberValid = int.TryParse(textBoxAN.Text, out additionNumber);
            bool isLinesValid = int.TryParse(textBoxLines.Text, out numberOfLines);
            if (isNumberValid && isLinesValid && numberOfLines > 0)
            {
                for (int i = 1; i <= numberOfLines; i++)
                {
                    int result = additionNumber + i;
                    Console.WriteLine($"{additionNumber} + {i} = {result}");
                }
            }
            else
            {
                Console.WriteLine("Invaild input!");
            }
        }
    }
}
//Wukai 20253000087