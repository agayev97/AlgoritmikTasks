using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroesToEnd
{
    internal class Program
    {
        static void moveZeroesToEnd(int[] input)
        {
            int nonZeroIndex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != 0)
                {
                    int temp = input[nonZeroIndex];
                    input[nonZeroIndex] = input[i];
                    input[i] = temp;
                    nonZeroIndex++;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] nums = { 0, 0, 1, 0, 3, 12 };

            moveZeroesToEnd(nums);

            Console.WriteLine(string.Join(", ", nums));

            Console.ReadLine();
        }
    }
}
