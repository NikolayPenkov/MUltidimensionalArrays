using System;
using System.Linq;

namespace _02.squaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int rols = int.Parse(input.Split()[0]);
            int cols = int.Parse(input.Split()[1]);
            string[,] matrix = new string[rols, cols];
            FillMatrix(matrix);
            int squaresInMatrix = 0;
            for (int rol = 0; rol < rols - 1; rol++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                   ;
                    if (matrix[rol, col] == matrix[rol + 1, col] 
                        && matrix[rol, col] == matrix[rol, col + 1]
                        && matrix[rol, col] == matrix[rol + 1, col + 1])
                    {
                        squaresInMatrix++;
                    }
                }
            }
           
                Console.WriteLine(squaresInMatrix);
            
           
        }

        private static void FillMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine().Split(" ");
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }
    }

}
