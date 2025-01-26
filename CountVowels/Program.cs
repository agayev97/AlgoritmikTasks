using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountVowels
{
    internal class Program
    {
        static (int vowelsCount, int consonantCount) CountVowels(string input)
        {
            string vowels = "aeiouəöüı";
            int vowelsCount = 0;
            int consonantCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = Char.ToLower(input[i]);
                if (Char.IsLetter(currentChar) )
                {
                    if (vowels.Contains(currentChar))
                    {
                        vowelsCount++;
                    }
                    else
                    {
                        consonantCount++;
                    }
                }          
            }
            return (vowelsCount, consonantCount); 
        }

        static void Main(string[] args)
        {
            string ipt = "Salam Azərbaycan";

            var (vowelsCount, consonantCount) = CountVowels(ipt);

            Console.WriteLine("Saitlerin sayi:" + vowelsCount);
            Console.WriteLine("Samitlerin sayi:" + consonantCount);

            Console.ReadKey();

        }
    }
}
