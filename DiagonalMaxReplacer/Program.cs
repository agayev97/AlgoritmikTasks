using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalMaxReplacer
{
    internal class Program
    {
        static void DiagonalMaxReplacer(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int max = matrix[i, 0];
                int maxIndex = 0;
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if( matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        maxIndex = j;
                    }
                }

                int temp = matrix[i, i];
                matrix[i, i] = max;
                matrix[i, maxIndex] = temp;

            }

            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");

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

            DiagonalMaxReplacer(A);

            Console.ReadLine();
        }
    }
}
