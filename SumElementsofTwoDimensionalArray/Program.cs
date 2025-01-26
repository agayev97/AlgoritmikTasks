using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumElementsofTwoDimensionalArray
{
    internal class Program
    {
        static int sumArrayElements(int[,] input)
        {
            int sum = 0;
            int rows = input.GetLength(0);
            int cols = input.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sum += input[i, j];

                }
            }

            return sum;
        }
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]
            {
                {10, 15, -8 },
                {12, 16, 11 },
                {24, 2, -4 }
            };

            int c = sumArrayElements(matrix);

            Console.WriteLine("Massivin elementlerin cemi:" + c);

            Console.ReadLine();
        }    
    }
}
