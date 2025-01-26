using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofMinMaxElements
{
    internal class Program
    {
        static int SumofMinMaxElements(int[] input)
        {
            int max = input[0];
            int min = input[0];
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > max)
                {
                    max = input[i];
                }
                if (input[i] < min)
                {
                    min = input[i];
                }
            }
    
            return (min +max);
        }
        static void Main(string[] args)
        {
            int[] array = { -14, 2, 5, 8, 17, 125, -3, -7 };

            int c = SumofMinMaxElements(array);

            Console.WriteLine("Massivin min ile max elementlerin cemi:" + c);

            Console.ReadLine();

        }
    }
}
