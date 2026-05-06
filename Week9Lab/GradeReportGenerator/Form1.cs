using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GradeReportGenerator
{
    public partial class Form1 : Form
    {
        const int MAX_STUDENTS = 100;
        string[] idArray = new string[MAX_STUDENTS];
        int[] marksArray = new int[MAX_STUDENTS];
        int studentCount = 0;


        public Form1()
        {
            InitializeComponent();
            DrawPicture.Enabled = false;
            ExportReport.Enabled = false;
        }

        private string Sorting(int mark)
        {
            if (mark >= 80) return "A";
            if (mark >= 65) return "B";
            if (mark >= 50) return "C";
            if (mark >= 35) return "D";
            return "E";
        }


        private int CalculateBarHeight(int mark)
        {
            int pbHeight = pictureBox.Height;
            int barHeight = (pbHeight * mark) / 100;
            return barHeight;
        }

        private void ChooseOriginFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files|*.csv";
            openFileDialog.Title = "Select a CSV File";
            openFileDialog.InitialDirectory = Application.StartupPath;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        studentCount = 0;
                        listBox.Items.Clear();

                        string line;
                        while ((line = reader.ReadLine()) != null && studentCount < MAX_STUDENTS)
                        {
                            string[] parts = line.Split(',');
                            if (parts.Length >= 2)
                            {
                                idArray[studentCount] = parts[0].Trim();
                                marksArray[studentCount] = int.Parse(parts[1].Trim());

                                listBox.Items.Add(idArray[studentCount].PadRight(15) + marksArray[studentCount].ToString());
                                studentCount++;
                            }
                        }
                    }
                    MessageBox.Show("File loaded successfully!");
                    DrawPicture.Enabled = true;
                    ExportReport.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading file: " + ex.Message);
                }
            }
        }

        private void clearPictureBox_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox.CreateGraphics();
            g.Clear(pictureBox.BackColor);
        }

        private void DrawPicture_Click(object sender, EventArgs e)
        {
            if (studentCount == 0)
            {
                MessageBox.Show("Please load data first!");
                return;
            }

            Graphics g = pictureBox.CreateGraphics();
            g.Clear(pictureBox.BackColor);
            int barWidth = 10;
            int xPos = 0;

            for (int i = 0; i < studentCount; i++)
            {
                int currentMark = marksArray[i];
                int currentBarHeight = CalculateBarHeight(currentMark);

                int yPos = pictureBox.Height - currentBarHeight;

                Rectangle barRect = new Rectangle(xPos, yPos, barWidth, currentBarHeight);

                g.FillRectangle(Brushes.SteelBlue, barRect);
                g.DrawRectangle(Pens.Black, barRect);
                xPos += barWidth;
            }
        }


        private void ExportReport_Click(object sender, EventArgs e)
        {
            if (studentCount == 0)
            {
                MessageBox.Show("Please load data first!");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.WriteLine("Student ID".PadRight(15) + "Mark".PadRight(10) + "Grade");

                        for (int i = 0; i < studentCount; i++)
                        {
                            string grade = Sorting(marksArray[i]);
                            writer.WriteLine(idArray[i].PadRight(15) + marksArray[i].ToString().PadRight(10) + grade);
                        }

                        writer.WriteLine("Total Students: " + studentCount);
                    }
                    MessageBox.Show("Report generated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error writing report: " + ex.Message);
                }
            }
        }

        private void Kill_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
