using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositivSumCount
{
    internal class Program
    {
        static void positiveSum(int[,] input)
        {
       

            for (int i = 0; i < input.GetLength(0); i++)
            {
                int positivSum = 0;
                int positvCount = 0;
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    if (input[i,j] > 0)
                    {
                        positivSum = positivSum + input[i, j];

                        positvCount++;
                    }
                }

                Console.WriteLine($"Setirin nomresi = {i}, say = {positvCount}, Cem = {positivSum}");

            }


        }
        static void Main(string[] args)
        {
            int[,] A = new int[3, 3]
            {
                {8, -2, 2 },
                {9, -5, 4 },
                {2, -7, 14 }
            };

            positiveSum(A);
            Console.ReadLine();


        }


    }

}
