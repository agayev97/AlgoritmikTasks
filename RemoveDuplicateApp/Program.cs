using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesApp
{
    internal class Program
    {
        static List<int> RemoveDuplicates(int[] input)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!result.Contains(input[i]))
                {
                    result.Add(input[i]);
                }
                //bool existsInBag = false;
                //for (int j = 0; j < result.Count; j++)
                //{
                //    if (result[j] == input[i])
                //    {
                //        existsInBag = true;
                //    }

                //}

                //if (!existsInBag)
                //{
                //    result.Add(input[i]);
                //}
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 2, 3, 4, 4 };

            var r = RemoveDuplicates(array);

            foreach (var item in r)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();


        }
    }
}
