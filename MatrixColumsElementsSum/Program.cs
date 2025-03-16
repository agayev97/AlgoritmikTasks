using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixColumsElementsSum
{
    internal class Program
    {
        static void MatrixColumsElementsSum(int[,] matrix)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int rowSum = 0;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    rowSum += matrix[i, j];
                }

                matrix[j, j] = rowSum;
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
          
            int[,] X = new int[5, 5]
            {
                {-2, 4, -11, 6, -7},
                {3, 4, -8, 5, 9  },
                {-5, 4, -8, 8, 12},
                {6, 4, -8, 8, 7  },
                {-8, 4, -8, 8, 7 }
            };

            MatrixColumsElementsSum(X);

            Console.ReadLine();

        }
    }
}
