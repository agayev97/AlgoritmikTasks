using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixRowMinMax
{
    internal class Program
    {
        static void MatrixRowMinMax(int[, ] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int maxIndex = 0, minIndex = 0;
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < matrix[i, minIndex])
                    {
                        minIndex = j;
                    }

                    if(matrix[i, j] > matrix[i, maxIndex])
                    {
                        maxIndex = j;
                    }

                }

                int temp = matrix[i, 0];
                matrix[i, 0] = matrix[i, minIndex];
                matrix[i, minIndex] = temp;

                temp = matrix[i, matrix.GetLength(1) - 1];
                matrix[i, matrix.GetLength(1) - 1] = matrix[i, maxIndex];
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
            int[,] D = new int[5, 8]
            {
                {-2, 4, -11, 6, -7, 25,40, 8},
                {3, 4, -8, 5, 9, -14, 14, 12},
                {-5, 4, -8, 8, 12, 24, -25,3},
                {6, 4, -8, 8, 7, 22, 21, 20},
                {-8, 4, -8, 8, 7, 18, -20,2}
            };

            MatrixRowMinMax(D);

            Console.ReadLine();

        }
    }
}
