using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticMean
{
    internal class Program
    {

        static double ArithmeticMean(int[] input)
        {
            int arithmeticMean = 0;
            for (int i = 0; i < input.Length; i++)
            {
                arithmeticMean += input[i] ;
            }
            double a = (double)arithmeticMean / input.Length;

            return a ;
           
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Massivi daxil et:");
            int[] ipt = { -9, 1, 2, 3, 4, 5, 8 };

            double c = ArithmeticMean(ipt);

            Console.WriteLine("Massivin elementlerin ededi ortasi:" + c);

            Console.ReadKey();


        }
    }
}
