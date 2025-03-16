using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegativeLowerDiagonalSum
{
    internal class Program
    {
        static void LowerDiagonalSum(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int lowerNegativDiognalSum = 0;
                int count = 0;
                for (int j = 0; j < i; j++)
                {
                    if(matrix[i,j] < 0)
                    {
                        lowerNegativDiognalSum += matrix[i,j];
                        count++;
                    }
                }

                Console.WriteLine($"Setirin nomresi = {i}, Say = {count}, Cem = {lowerNegativDiognalSum}");

            }
        }
        static void Main(string[] args)
        {
            int[,] Y = new int[6, 6]
            {
                {1, 4, -4, -8, 8, 7 },
                {-2, 4, -4, -11, 6, -7},
                {3, 4, -4, -8, 5, 9  },
                {-5, 4, -4, -8, 8, 12},
                {6, 4, -4, -8, 8, 7  },
                {-8, 4, -4, -8, 8, 7 }
            };

            LowerDiagonalSum(Y);

            Console.ReadLine();
        }
    }
}
