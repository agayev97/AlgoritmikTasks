using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SortedNegativeArray
{
    internal class Program
    {
        static int[] sortedNegativeArray(int[] input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < 0) count++;
                
            }

            int[] Y = new int[count];
            int index = 0;

            foreach(int num in input)
            {
                if(num < 0)
                {
                    Y[index] = num;
                    index++;
                }
            }

            for (int i = 0; i < Y.Length -1; i++)
            {
                for (int j = 0; j < Y.Length - 1 - i; j++)
                {
                    if (Y[j] > Y[j + 1])
                    {
                        int temp = Y[j];
                        Y[j] = Y[j + 1];
                        Y[j + 1] = temp;
                    }

                }
            }

            return Y;
        }

        static void Main(string[] args)
        {
            int[] Z = new int[30];
            Random rnd = new Random();

            for (int i = 0; i < Z.Length; i++) Z[i] = rnd.Next(-10, 30);

            Console.WriteLine("Massiv: " + string.Join(",", Z));

            int[] Y = sortedNegativeArray(Z);

            Console.WriteLine("\n");

            Console.WriteLine("Siralanan massivin elementleri :" + string.Join(", ", Y));

           

            Console.ReadLine();
        }
    }
}
