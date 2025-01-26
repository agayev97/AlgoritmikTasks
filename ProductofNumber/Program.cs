using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductofNumber
{
    internal class Program
    {
        static int ProductofNumber(int[] input)
        { int product = 1;
            for (int i = 0; i <input.Length; i++)
            {
                product *= input[i];
            }
            return product;
        }
        static void Main(string[] args)
        {
            int[] ipt = { -8, -9, -5, 2, 6, 7 };

            int c = ProductofNumber(ipt);

            Console.WriteLine("Massivin elementlerin hasili:" + c);

            Console.ReadKey();
        } 
    }
}
