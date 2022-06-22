using System;
using System.Linq;

namespace _03.maximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);

            int[,] matrix = new int[rows, cols];
            FillMatrix(matrix);


            int biggestMatrixNumber = 0;
            int[,] smallMatrix = new int[3, 3];
            for (int row = 0; row <= rows - 3; row++)
            {
                for (int col = 0; col <= cols - 3; col++)
                {
                    int curNum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + 
                                 matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                                 matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (curNum > biggestMatrixNumber)
                    {
                        biggestMatrixNumber = curNum;
                        smallMatrix = new int[3,3]{ { matrix[row, col], matrix[row, col + 1], matrix[row, col + 2] },
                                        { matrix[row + 1, col],  matrix[row + 1, col + 1], matrix[row + 1, col + 2] },
                                        { matrix[row + 2, col], matrix[row + 2, col + 1], matrix[row + 2, col + 2]} };
                    }
                }
            }
            Console.Write($"Sum = {biggestMatrixNumber}");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(smallMatrix[i, j] + " ");
                }
            }
        }

        private static void FillMatrix(int [,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(rowData[col]);
                }
            }
        }
    }
}
