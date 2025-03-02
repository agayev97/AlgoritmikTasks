using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegativeElementsExtractor
{
    internal class Program
    {
        static int[] negativeElementsExtractor(int[] input)
        {
            List<int> negatives = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]  < 0)
                {
                    negatives.Add(input[i]);
                }

            }

            return negatives.ToArray();

        }
        static void Main(string[] args)
        {
            int[] X = new int[20];
            Random rnd = new Random();

            for (int i = 0; i < X.Length; i++)
            {
                X[i] = rnd.Next(-10, 15);
            }

            Console.WriteLine("Daxil edilmis massiv :");
            foreach(var item in X)
            {
                Console.Write(item + " ");
            }

            int[] Y = negativeElementsExtractor(X);
            Console.WriteLine("\nMenfi elementlerden ibaret massiv :");
            foreach(var item in  Y)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
