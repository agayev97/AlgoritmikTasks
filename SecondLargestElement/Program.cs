using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLargestElement
{
    internal class Program
    {
        static int findSecondLargestElement(int[] input)
        {
            int max = 0;
            int secondMax = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > max)
                {
                    secondMax = max;
                    max = input[i];
                }

                if (input[i] > secondMax && input[i] < max)
                {
                    secondMax = input[i];
                }

            }

            return secondMax;
        }
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 4, 5, 0, 2 };

            int result = findSecondLargestElement(nums);

            Console.WriteLine("Ikinci en boyuk element:" + result);

            Console.ReadLine();
        }
    }
}
