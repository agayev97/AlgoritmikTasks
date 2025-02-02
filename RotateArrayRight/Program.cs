using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArrayRight
{
    internal class Program
    {
        static void rotateArrayRight(int[] input, int k)
        {
            k = k % input.Length;

            for (int i = 0; i < k; i++)
            {
                int t = input[input.Length - 1];
                for (int j = input.Length - 1; j > 0; j--)
                {
                    input[j] = input[j - 1];

                }
                input[0] = t;
            }

        }

        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;
            rotateArrayRight(nums, k);

            Console.WriteLine(string.Join(", ", nums));

            Console.ReadLine();
        }
    }
}
