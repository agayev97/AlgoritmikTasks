using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstUniqueChar
{
    internal class Program
    {
        static char? firstUniqueChar(string s)
        {
            string lowerS = s.ToLower();
            for (int i = 0; i < lowerS.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < lowerS.Length; j++)
                {
                    if (i != j && lowerS[i] == lowerS[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if(isUnique)
                {
                    return s[i];
                }

            }

            return null;
        }
        static void Main(string[] args)
        {
            string str = "Tural";
            char? result = firstUniqueChar(str);

            if (result.HasValue)
                Console.WriteLine("İlk unikal simvol: " + result);
            else
                Console.WriteLine("Unikal simvol yoxdur.");

            Console.ReadLine();
        }
    }
}
