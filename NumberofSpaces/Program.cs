using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberofSpaces
{
    internal class Program
    {
        
        static int NumberofSpaces(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    count++;
                }             
            }

            return count;
        }
        static void Main(string[] args)
        {
            string text = "Men C# dilini oyrenirem.";

            int spaceCount = NumberofSpaces(text);

            Console.WriteLine($"Bosluqlarin syai: {spaceCount}");

            Console.ReadLine();
            
        }
    }
}
