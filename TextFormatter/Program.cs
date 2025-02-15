using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFormatter
{
    internal class Program
    {
        static string textFormatter(string text)
        {
            string result = "";
            bool capitalizeNext = true;

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                
                if(capitalizeNext && Char.IsLetter(c))
                {
                    c = Char.ToUpper(c);
                    capitalizeNext = false;
                }

                result += c;

                if(c == '.')
                {
                    capitalizeNext = true;
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            string txt = "C# obyekt yonumlu dildir. bu dilin bir cox tetbiq saheleri var. masaustu tetbiqler. veb inkisaf. oyun inkisaf. mobil tətbiqlər";

            string result = textFormatter(txt);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
