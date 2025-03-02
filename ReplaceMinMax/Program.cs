using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceMinMax
{
    internal class Program
    {
        static void replaceMinMax(int[] input)
        {
            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] < input[minIndex])
                    minIndex = i;
                if (input[i] > input[maxIndex])
                    maxIndex = i;
            }

            if(minIndex != maxIndex)
            {
                int temp = input[minIndex];
                input[minIndex] = input[maxIndex];
                input[maxIndex] = temp;
            }
            Console.WriteLine($"\nMinimum element ({input[maxIndex]}) ve maksimum element ({input[minIndex]}) yerlerini deyişdi!");

        }
        static void Main(string[] args)
        {
            int[] D = new int[50];
            Random rnd = new Random();

            for (int i =0; i < D.Length; i++)
            {
                D[i] = rnd.Next(1, 51);
            }

            Console.WriteLine("Evvelki massiv:");
            foreach(var item in D)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            replaceMinMax(D);
            Console.WriteLine("\nDeyisdirilmis massiv:");
            foreach(var item in D)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
