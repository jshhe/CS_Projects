using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chlorine_Cost_Calculater__GUIonly_
{
    public partial class Form1 : Form
    {
        const double Chlorine_Rate = 0.1;
        const int Bag_Weight = 2;
        const decimal Bag_Cost = 5.5m;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double radius = double.Parse(textBoxRadius.Text);
                double depth = double.Parse(textBoxDepth.Text);
                double volume = Math.PI * Math.Pow(radius, 2) * depth;
                double chlorineReq = volume * Chlorine_Rate;
                double bagsNeeded = Math.Ceiling(chlorineReq / Bag_Weight);
                decimal totalCost = (decimal)bagsNeeded * Bag_Cost;
                textBoxVolume.Text = volume.ToString("F3");
                textBoxKilo.Text = chlorineReq.ToString("F3");
                textBoxBag.Text = bagsNeeded.ToString();
                textBoxCost.Text = totalCost.ToString("C", new System.Globalization.CultureInfo("en-US"));
            }
            catch
            {
                MessageBox.Show("Please check your input!"); 
                buttonClear_Click(sender, e);
            }
        }
        

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxRadius.Text = "";
            textBoxDepth.Text = "";
            textBoxVolume.Text = "";
            textBoxKilo.Text = "";
            textBoxBag.Text = "";
            textBoxCost.Text = "";
            textBoxRadius.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}