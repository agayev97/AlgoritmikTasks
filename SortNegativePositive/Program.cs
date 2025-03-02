using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNegativePositive
{
    internal class Program
    {
        static int[] SortNegativePositive(int[] input)
        {
            List<int> negatives = new List<int>();
            List<int> positives = new List<int>();

            foreach(var num in input)
            {
                if(num < 0)
                {
                    negatives.Add(num);
                }
                else
                {
                    positives.Add(num);
                }

            }

            negatives.AddRange(positives);
            return negatives.ToArray();
        }
        static void Main(string[] args)
        {
            int[] Z = new int[40];
            Random rnd = new Random();

            for (int i = 0; i < Z.Length; i++)
            {
                Z[i] = rnd.Next(-20, 30);
            }

            Console.WriteLine("Evvelki massiv:");
            foreach (var item in Z)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            int[] Y = SortNegativePositive(Z);
            Console.WriteLine("\nDeyisdirilmis massiv:");
            foreach (var item in Y)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
