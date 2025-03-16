using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixNegativetoZeroReplacement
{
    internal class Program
    {
        static void NegativElementstoZero(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] < 0)
                    {
                        matrix[i,j] = 0;

                    }

                }

            }

            Console.WriteLine("Deyisdirilmis matrix :");
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
                {-2, 4, -4, -11, -7},
                {3, 4, -4, -8,  9  },
                {-5, 4, -4, -8, 12},
                {6, 4, -4, -8, 7  },
                {-8, 4, -4, -8, 7 }
            };

            NegativElementstoZero(X);

            Console.ReadLine();
        }
    }
}
