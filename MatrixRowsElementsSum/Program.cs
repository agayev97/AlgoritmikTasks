using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixRowsElementsSum
{
    internal class Program
    {
        static void MatrixRowsElementsSum(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int rowSum = 0;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    rowSum += matrix[i, j];

                }

                matrix[i, i] = rowSum;

            }


           for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            
            int[,] A = new int[6, 6]
            {
                {1, 4, -4, -8, 8, 7 },
                {-2, 4, -4, -11, 6, -7},
                {3, 4, -4, -8, 5, 9  },
                {-5, 4, -4, -8, 8, 12},
                {6, 4, -4, -8, 8, 7  },
                {-8, 4, -4, -8, 8, 7 }
            };

            MatrixRowsElementsSum(A);

            Console.ReadLine();
        }
    }
}
