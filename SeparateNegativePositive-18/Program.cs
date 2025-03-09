using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparateNegativePositive_18
{
    internal class Program
    {
        static int[] SeparateNegativeElement(int[] input)
        {
            List<int> negatives = new List<int>();
            foreach (var num in input)
            {
                if (num < 0)
                    negatives.Add(num);
            }
            return negatives.ToArray();
        }

        static int[] SeparatePositivElement(int[] input) 
        {
            List<int> positives = new List<int>();

            foreach (var num in input)
            {
                if (num > 0)
                    positives.Add(num);
            }
            return positives.ToArray();
        }

        static void Main(string[] args)
        {
            int[] X = new int[40];
            Random rnd = new Random();

            for (int i = 0; i < X.Length; i++) X[i] = rnd.Next(-20, 25);

            Console.WriteLine("Daxil edilmiş massiv:" + string.Join(", ", X));

            int[] Y = SeparateNegativeElement(X);
            int[] Z = SeparatePositivElement(X);

            Console.WriteLine("\nMenfi elementlerden ibaret Y massivi: " + string.Join(", ", Y));

            Console.WriteLine("\nMusbet elementlerden ibaret Y massivi: " + string.Join(", ", Z));

            Console.ReadLine();
        }
    }
}
