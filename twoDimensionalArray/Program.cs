using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoDimensionalArray
{
    internal class Program
    {
        static (int firstDiognalSum, int secondDiognalSum) SumArrayDiognalElement(int[,] array)
        {
            int firstDiognalSum = 0;
            int secondDiognalSum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                firstDiognalSum += array[i, i];

                secondDiognalSum += array[i, array.GetLength(0) - 1 - i];
            }
            return (firstDiognalSum, secondDiognalSum);
            
        }
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]
            {
                {10, 15, 25 } ,
                {12, 20, 21 },
                {45, 54, 73 }
            };

            var (firstDiognalSum, secondDiognalSum) = SumArrayDiognalElement(matrix);
            Console.WriteLine("Birinci dioqnal elementinin cemi:" + firstDiognalSum);
            Console.WriteLine("Ikinci dioqnal elementinin cemi:" + secondDiognalSum);

            Console.ReadLine();
        }
    }
}
