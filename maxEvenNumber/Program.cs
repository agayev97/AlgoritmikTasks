using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxEvenNumber
{
    internal class Program
    {
        static int _maxEvenNumber(int[] input)
        {
            int evenMax = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    if (input[i] > evenMax)
                    {
                        evenMax = input[i];
                    }
                } 
            }

            return evenMax;
            
        } 
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 5,  7, 8, 19, 36, 37 };
            int result = _maxEvenNumber(nums);
            Console.WriteLine("Massivin en boyuk cut elementi: " + result);

            Console.ReadLine();


        }
    }
}
