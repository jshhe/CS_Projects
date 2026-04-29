using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SalesReport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private decimal CalcCommission(decimal monthlySales, int commissionLevel)
        {
            const decimal LEVEL1 = 0.05m;
            const decimal LEVEL2 = 0.08m;
            const decimal LEVEL3 = 0.12m;
            const decimal LEVEL4 = 0.18m;

            decimal commissionRate = 0m;
            if (commissionLevel == 1)
            {
                commissionRate = LEVEL1;
            }
            else if (commissionLevel == 2)
            {
                commissionRate = LEVEL2;
            }
            else if (commissionLevel == 3)
            {
                commissionRate = LEVEL3;
            }
            else if (commissionLevel == 4)
            {
                commissionRate = LEVEL4;
            }
            return monthlySales * commissionRate;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonProcessFile_Click(object sender, EventArgs e)
        {
            string startupPath = Application.StartupPath;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = startupPath;
            openFileDialog.Title = "Please select the sales data file.";
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string inputDirectory = Path.GetDirectoryName(openFileDialog.FileName);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = inputDirectory;
                saveFileDialog.Title = "Please specify the location and name for the output file";
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        int totalSalespeople = 0;
                        decimal totalMonthlySales = 0m;
                        decimal totalCommission = 0m;
                        CultureInfo usCulture = CultureInfo.GetCultureInfo("en-US");
                        using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            string header = string.Format("{0,-20} {1,-15} {2,-10} {3,-15}", "Name", "Monthly Sales", "Level", "Commission");
                            Console.WriteLine(header);
                            writer.WriteLine(header);
                            writer.WriteLine(new string('-', 65));
                            Console.WriteLine(new string('-', 65));

                            while (!reader.EndOfStream)
                            {
                                string name = reader.ReadLine();
                                if (string.IsNullOrWhiteSpace(name)) continue;

                                decimal sales = decimal.Parse(reader.ReadLine(), usCulture);
                                int level = int.Parse(reader.ReadLine());

                                decimal commission = CalcCommission(sales, level);

                                totalSalespeople++;
                                totalMonthlySales += sales;
                                totalCommission += commission;

                                string line = string.Format("{0,-20} {1,-15} {2,-10} {3,-15}", name, sales, level, commission);

                                Console.WriteLine(line);
                                writer.WriteLine(line);
                            }

                            string footer = "\n--- SUMMARY ---\n" +
                                            $"Total Salespeople: {totalSalespeople}\n" +
                                            $"Total Monthly Sales: {totalMonthlySales:C}\n" +
                                            $"Total Commission to be paid: {totalCommission:C}";

                            Console.WriteLine(footer);
                            writer.WriteLine(footer);
                        }
                        MessageBox.Show("The report has been generated.", "Mission completed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = saveFileDialog.FileName,
                            UseShellExecute = true
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Errors：" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }
    }
}