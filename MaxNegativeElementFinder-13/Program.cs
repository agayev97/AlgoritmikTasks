using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MaxNegativeElementFinder_13
{
    internal class Program
    {
        static (int, int) FindMaxNegativeElement(int[] input)
        {
            int maxNegative = int.MinValue;
            int index = -1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < 0 && input[i] > maxNegative)
                {
                    maxNegative = input[i];
                    index = i;
                }
            }
            return (maxNegative, index);
        }
        static void Main(string[] args)
        {
            int[] A = new int[40];
            Random rnd = new Random();

            for (int i = 0; i < A.Length; i++) A[i] = rnd.Next(-41, 20);
           
            Console.WriteLine("Massiv: " + string.Join(",", A));

            Console.WriteLine("\n");

            (int maxNegative, int index) = FindMaxNegativeElement(A);

            Console.WriteLine($"En boyuk menfi element: {maxNegative}, Indeksi: {index}");
            Console.ReadLine();
        }
    }
}
