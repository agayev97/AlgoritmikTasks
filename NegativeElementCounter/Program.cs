using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegativeElementCounter
{
    internal class Program
    {
        static void negativeElementCounter(int[,] input)
        {
            for (int i = 0; i < input.GetLength(0); i++)
            {
                int negativeSum = 0;
                int negativeCount = 0;
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    if (input[i,j] < 0)
                    {
                        negativeSum += input[i, j];
                        negativeCount++;
                    }
                }

                Console.WriteLine($"Setirin nomresi: {i}, Say = {negativeCount}, Cem = {negativeSum}");

            }
        }
        static void Main(string[] args)
        {
            int[,] V = new int[3, 4]
            {
                {-1, 8, -5, 3},
                {7,-10, -6, -4},
                {2, -3, 4, -5},
            };

            negativeElementCounter(V);

            Console.ReadLine();
        }
    }
}
