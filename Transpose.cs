/*
 * Developer: Pramod Kokadwar
 * File Description: This program transposes a table from a CSV file to a new CSV file
 * Created Date: 10.05.2023
 */

using System;
using System.IO;

namespace TaskTranspose
{
    class Transpose
    {
        static void Main(string[] args)
        {
            string inputFileName = "";
            string pathToFile= @"C:\Users\pramodkokadwar\source\repos\TaskTranspose\TaskTranspose\files\";

            try
            {
                // Construct the input file path
                string[] fileArray = Directory.GetFiles(pathToFile, "*.csv", SearchOption.AllDirectories);

                // Extract filename from whole directory path
                if (fileArray.Length > 0)
                {
                    String[] listStrings = fileArray[0].Split(new string[] { "\\" }, StringSplitOptions.None);
                    inputFileName = listStrings[listStrings.Length - 1];

                    Console.Write("inputFileName is " + inputFileName);

                    // Prepare path for the input file 
                    string inputFilePath = pathToFile + inputFileName;

                    // Read all lines from the input file
                    string[] lines = File.ReadAllLines(inputFilePath);

                    // Calculate the number of rows and columns in the table
                    int numRows = lines.Length;
                    int numCols = lines[0].Split(';').Length;

                    // Create a 2D array to hold the table data
                    string[,] table = new string[numCols, numRows];

                    // Populate the table array by transposing the data
                    for (int rCount = 0; rCount < numRows; rCount++)
                    {
                        string[] row = lines[rCount].Split(';');
                        for (int cCount = 0; cCount < numCols; cCount++)
                        {
                            table[cCount, rCount] = row[cCount];
                        }
                    }

                    // Generate the output file name by appending "_transposed" to the input file name
                    string outputFileName = Path.GetFileNameWithoutExtension(inputFilePath) + "_transposed.csv";

                    // Construct the output file path by combining the directory path and the output file name
                    string outputFilePath = Path.Combine(Path.GetDirectoryName(inputFilePath), outputFileName);

                    // Write the transposed table data to the output file
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        for (int rCount = 0; rCount < numCols; rCount++)
                        {
                            for (int cCount = 0; cCount < numRows; cCount++)
                            {
                                writer.Write(table[rCount, cCount]);
                                if (cCount < numRows - 1)
                                {
                                    writer.Write(";");
                                }
                            }
                            writer.WriteLine();
                        }
                    }

                    // Print a success message with the output file path
                    Console.WriteLine("Table transposed successfully. Transposed table saved to " + outputFilePath);

                }
                else
                {
                    Console.Write("No file found in the folder, please correct it.");
                }

            }
            catch (Exception e)
            {
                Console.Write("Exception occurred : " + e.Message);
            }

        }
    }
}
