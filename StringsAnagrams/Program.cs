using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAnagrams
{
    internal class Program
    {
        static bool stringAnagrams(string input1, string input2)
        {
           if(input1.Length != input2.Length)
            {
                return false;
            }

            char[] charArray1 = input1.ToCharArray();
            char[] charArray2 = input2.ToCharArray();

            Array.Sort(charArray1);
            Array.Sort(charArray2);

            for (int i = 0; i < charArray1.Length; i++)
            {
                if (charArray1[i] != charArray2[i])
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            string s1 = "listen";
            string s2 = "silent";

            bool result = stringAnagrams(s1, s2);

            Console.WriteLine($"\"{s1}\" Ve \"{s2}\" anagramdir? {result}");

            Console.ReadLine();
        }
    }
}
