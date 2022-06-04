using System;
using System.Linq;

namespace _01.diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int n = int.Parse(Console.ReadLine());
            int[,] numbers = new int[n, n];
            FillMatrix(numbers);
            int sumPrimaryDiagonal = 0;
            // sum from primary diagonal = row == cow
            int sumSecondaryDiagonal = 0;
            // sum secondary diagonal = row + col == n - 1
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    int number = numbers[row, col];
                    if (row == col)
                    {
                        sumPrimaryDiagonal += number;
                    }
                    if (row + col == n- 1)
                    {
                        sumSecondaryDiagonal += number;
                    }
                }
            }
            int sumDiagonals = Math.Abs(sumPrimaryDiagonal - sumSecondaryDiagonal);
            Console.WriteLine(sumDiagonals);
        }

        private static void FillMatrix(int[,] numbers)
        {
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                int[] rowData= Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    numbers[row, col] = rowData[col];
                }
            }
        }
    }
}
