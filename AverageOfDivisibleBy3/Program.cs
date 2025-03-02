using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AverageOfDivisibleBy3
{
    internal class Program
    {
        static double averageOfDivisibleBy3(int[] input)
        {
            int sum = 0;
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 3 == 0)
                {
                    sum++;
                    count++;
                }
            }
            double average = sum / count;

            return average;
        }
        static void Main(string[] args)
        {
            int[] N = new int[40];
            Random rnd = new Random();

            for (int i = 0; i < N.Length; i++)
            {
                N[i] = rnd.Next(-22, 31);
            }

            foreach(var item in N)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            double c = averageOfDivisibleBy3(N);

            Console.WriteLine("3-ə bölünen elementlerin ededi ortası:" + c);

            Console.ReadLine();
        }
    }
}
