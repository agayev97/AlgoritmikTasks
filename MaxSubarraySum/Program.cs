using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSubarraySum
{
    internal class Program
    {
        static int maxSubarraySum(int[] input)
        {
            int maxSum = input[0];
            int currentSum = input[0];

            for (int i = 1; i < input.Length; i++)
            {
                currentSum = Math.Max(input[i], currentSum + input[i]);

                maxSum = Math.Max(maxSum, currentSum);

            }
            return maxSum;

        }
        static void Main(string[] args)
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int maxSum = maxSubarraySum(nums);
            Console.WriteLine("Maksimum Subarray Cemi: " + maxSum);

            Console.ReadLine();
        }
    }
}
