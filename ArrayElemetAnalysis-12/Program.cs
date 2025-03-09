using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayElemetAnalysis_12
{
    internal class Program
    {
        static (int count, int sum) arrayElemetAnalysis(int[] input)
        {
            int count = 0;
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 3 == 2)
                {
                    sum += input[i];
                    count++;                   
                }
            }
           
            return (count, sum);
        }
        static void Main(string[] args)
        {
            int[] Y = new int[30];
            Random rnd = new Random();

            for (int i = 0; i <  Y.Length; i++) Y[i] = rnd.Next(1, 35);


            Console.WriteLine("Massiv: " + string.Join(",", Y));


            var (count, sum) = arrayElemetAnalysis(Y);

            Console.WriteLine($"\n3-e bölundukde qalıqda 2 olan elementlerin sayı: {count}, cemi: {sum}");

            Console.ReadLine();
        }
    }
}
