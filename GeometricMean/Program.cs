using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricMean
{
    internal class Program
    {   

        static double GeometricMean(int[] input)
        {
            double product = 1;
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
               
                if (input[i] > 0)
                {
                    product *= input[i];

                    count++;
                }

                else
                {
                    Console.WriteLine("Kok alti ifade menfi ola bilmez:");
                }
            }
            double a = Math.Pow(product, 1.0 / count);

            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Massivin elementelerini daxil edin:");
            int[] ipt = { -2, 1, 2, 4, 2 };

            double c = GeometricMean(ipt);

            Console.WriteLine("Massivin elementlerin hendesi ortasi:" + c);

            Console.ReadKey();
        }
    }
}
