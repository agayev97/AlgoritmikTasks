using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceDiagonalWithSumOfDivisibleBy3Elements_12
{
    internal class Program
    {
        static void ReplaceDiagonalWithSumOfDivisibleBy3Elements(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] % 3 == 0)
                    {
                        sum += matrix[i, j];
                    }
                }

                matrix[i, i] = sum;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");

                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] K = new int[8, 8]
            {
                { 1, 3, 6, 2, 4, 9, 8, 7 },
                { 5, 6, 3, 12, 15, 1, 0, 8 },
                { 9, 2, 7, 3, 6, 18, 21, 24 },
                { 0, 3, 6, 5, 9, 15, 12, 6 },
                { 8, 4, 2, 6, 3, 9, 0, 3 },
                { 7, 6, 3, 0, 18, 2, 5, 6 },
                { 3, 9, 12, 6, 0, 1, 4, 6 },
                { 5, 15, 3, 6, 9, 0, 12, 3 }
            };

            ReplaceDiagonalWithSumOfDivisibleBy3Elements(K);

            Console.ReadLine();
        }
    }
}
