using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RunLengthEncoding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CancelKeyPress += (sender, e) =>
            {
                Environment.Exit(0);
            };

            string[] lines = null;

            while (true)
            {
                Console.Write("Enter the file path: ");
                string inputPath = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(inputPath))
                {
                    Console.WriteLine("Error: Path cannot be empty. Please try again.");
                    continue;
                }

                inputPath = inputPath.Trim(' ', '"');
                string filePath = Path.GetFullPath(inputPath);

                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"Error: File not found at {filePath}. Please try again.");
                    continue;
                }

                lines = File.ReadAllLines(filePath);

                if (lines.Length == 0)
                {
                    Console.WriteLine("Error: The file is empty. Please try again.");
                    continue;
                }

                break;
            }

            string[] firstLineStr = lines[0].Split(',');
            int width = 0;
            int height = 0;

            if (firstLineStr.Length >= 2)
            {
                int.TryParse(firstLineStr[0].Trim(), out width);
                int.TryParse(firstLineStr[1].Trim(), out height);
            }
            else
            {
                Console.WriteLine("Error: The first line does not contain valid <width>,<height>.");
                return;
            }

            List<int> pixelData = new List<int>();

            for (int rowIndex = 1; rowIndex < lines.Length; rowIndex++)
            {
                string line = lines[rowIndex];
                if (string.IsNullOrWhiteSpace(line)) continue;

                int[] counts = line.Split(',')
                                   .Select(s => int.Parse(s.Trim()))
                                   .ToArray();

                for (int i = 0; i < counts.Length; i++)
                {
                    int count = counts[i];
                    int color = i % 2;

                    for (int j = 0; j < count; j++)
                    {
                        pixelData.Add(color);
                    }
                }
            }

            int pixelsPrinted = 0;
            foreach (int pixel in pixelData)
            {
                if (pixel == 0)
                {
                    Console.Write(" ");
                }
                else if (pixel == 1)
                {
                    Console.Write("#");
                }

                pixelsPrinted++;

                if (pixelsPrinted == width)
                {
                    Console.WriteLine();
                    pixelsPrinted = 0;
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}