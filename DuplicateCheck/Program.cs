using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateCheck
{
    internal class Program
    {
        static bool duplicateElementsCheck(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        return true;
                    }
                }
               
            }
            return false;


        }
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 1 };

            bool result = duplicateElementsCheck(nums);

            Console.WriteLine(result);
         
            Console.ReadKey();
        }
    }
}
