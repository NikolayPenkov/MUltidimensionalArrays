using System;
using System.Linq;

namespace matrix_shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[size[0], size[1]];
            FillMatrix(matrix);
            int squares = 0;
            string command = Console.ReadLine();
            while (command != "END")
            {
                 string[] split = command.Split();
               

                if (split[0] == "swap")
                {
                    int row1 = int.Parse(split[1]);
                    int col1 = int.Parse(split[2]);
                    int row2 = int.Parse(split[3]);
                    int col2 = int.Parse(split[4]);
                    if (row1 >= 0 && row1<= size[0] && row2 >= 0 && row2 <= size[0] &&
                        col1 >= 0 && col1 <= size[1] && col1 >= 0 && col2 <= size[1])
                    {
                        string first = matrix[row1, col1];
                        string second = matrix[row2, col2];
                        matrix[row1, col1] = second;
                        matrix[row2, col2] = first;
                        PrintMatrix(matrix);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                //метод doesExist
                command = Console.ReadLine();
            }
           
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
              
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void FillMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }
    }
    
}
