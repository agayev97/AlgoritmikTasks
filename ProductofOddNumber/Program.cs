using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductofOddNumber
{
    internal class Program
    {
        static int ProductofOddNumber(int[] input)
        {
            int productOddNumber = 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]%2 == 0)
                {
                    productOddNumber *= input[i];
                    
                }
            }
            return productOddNumber;
        }
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 7, 14, 18, 25, 4 };

            int c = ProductofOddNumber(array);

            Console.WriteLine("Massivin cut elementlerin hasili:" + c);

            Console.ReadLine();
        }
    }
}
