using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace PracticalTest3
{
    public partial class Form1 : Form
    {
        //Name:
        //Id:

        //The number of columns in the grid
        const int NUM_COLUMNS = 26;

        //The number of rows in the grid
        const int NUM_ROWS = 50;

        //The size of each Tile in the grid
        const int TILE_SIZE = 10;

        //Colors for the various terrain tiles
        Color GROUND_COLOR = Color.SandyBrown;
        Color MOUNTAIN_COLOR = Color.LightGray;
        Color FOREST_COLOR = Color.ForestGreen;
        Color TOWN_COLOR = Color.Purple;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Converts the letter that represents a column into
        /// an x position in the grid.
        /// </summary>
        /// <param name="column">Letter of the column</param>
        /// <returns>The x position of the column in the grid</returns>
        private int CalculateX(string column)
        {
            int x = (column[0] - 'A') * TILE_SIZE;

            return x;
        }

        /// <summary>
        /// Display a tile in the grid at the given x and y position in
        /// the given colour.
        /// </summary>
        /// <param name="paper">Where to draw the tile</param>
        /// <param name="x">The x position of the tile</param>
        /// <param name="y">The y position of the tile</param>
        /// <param name="tileColor">The colour of the tile</param>
        private void DisplayTile(Graphics paper, int x, int y, Color tileColor)
        {
            SolidBrush br = new SolidBrush(tileColor);
            Pen pen1 = new Pen(Color.Gray, 1);
            paper.FillRectangle(br, x, y, TILE_SIZE, TILE_SIZE);
            paper.DrawRectangle(pen1, x, y, TILE_SIZE, TILE_SIZE);
        }

        /// <summary>
        /// Display the grid in the base ground colour.
        /// </summary>
        /// <param name="paper">Where to draw the grid</param>
        private void DisplayGrid(Graphics paper)
        {
            //x and y position of the current tile
            int x = 0;
            int y = 0;
            //For each row of tiles to draw
            for (int row = 1; row <= NUM_ROWS; row++)
            {
                //For each tile to draw in the current row
                for (int col = 1; col <= NUM_COLUMNS; col++)
                {
                    //Draw the tile at the current x and y position
                    //in the ground colour
                    DisplayTile(paper, x, y, GROUND_COLOR);
                    //Shift x to the right by width of tile
                    x += TILE_SIZE;
                }
                //Shift y down by height of tile
                y += TILE_SIZE;
                //Shift x back to start of row
                x = 0;
            }
        }

        private int CalculateY(int row)
        {
            return (row - 1) * TILE_SIZE;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            openFileDialog.InitialDirectory = Application.StartupPath;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Graphics paper = pictureBoxMap.CreateGraphics();
                listBoxData.Items.Clear();

                DisplayGrid(paper);

                int totalValue = 0;
                StreamReader reader = null;

                try
                {
                    reader = new StreamReader(openFileDialog.FileName);

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        try
                        {
                            string[] elements = line.Split(',');

                            if (elements.Length != 4)
                            {
                                Console.WriteLine("Error: Incorrect number of elements in line: " + line);
                            }
                            else
                            {
                                string column = elements[0].Trim();
                                int row = int.Parse(elements[1].Trim());
                                string terrain = elements[2].Trim();
                                int value = int.Parse(elements[3].Trim());

                                string displayStr = column.PadRight(5) +
                                                    row.ToString().PadRight(5) +
                                                    terrain.PadRight(15) +
                                                    value.ToString().PadRight(5);
                                listBoxData.Items.Add(displayStr);

                                totalValue += value;

                                int x = CalculateX(column);
                                int y = CalculateY(row);

                                Color tileColor = GROUND_COLOR;
                                if (terrain.ToLower() == "mountain") tileColor = MOUNTAIN_COLOR;
                                else if (terrain.ToLower() == "forest") tileColor = FOREST_COLOR;
                                else if (terrain.ToLower() == "town") tileColor = TOWN_COLOR;

                                DisplayTile(paper, x, y, tileColor);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error processing line: " + line + ". Exception: " + ex.Message);
                        }
                    }

                    MessageBox.Show("Total value of all tiles: " + totalValue, "Total Value");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening file: " + ex.Message);
                }
                finally
                {
                    if (reader != null)
                    {
                        reader.Close();
                    }
                }
            }
        }
    }
}