using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Div4Array
{
    internal class Program
    {
        static List<int> divArray(int[] input, out int count)
        {
            List<int> K = new List<int>();
       
            foreach(int num in input)
            {
                if(num % 4 == 0)
                    K.Add(num);
              
                    
            }
            count = K.Count; 
            return K;
            
        }
        static void Main(string[] args)
        {
            int[] M = new int[30];
            Random rnd = new Random();

            for (int i = 0; i < M.Length; i++)
            {
                M[i] = rnd.Next(3, 34);
            }

            Console.WriteLine("İxtiyari daxil edilmiş massiv:");

            foreach(var item in M)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            int count;
            List<int> K = divArray(M, out count);

            Console.WriteLine("\n4-ə bölünən elementlərdən ibarət K massivi:");

            foreach (var item in K)
            {
                Console.Write(item + " ");
            }


            Console.WriteLine("\nK massivinin elementlərinin sayı: " + count);
            

            Console.ReadLine();

        }
    }
}
