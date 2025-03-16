using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveUpperDiagonalSum
{
    internal class Program
    {
        static void UppreDiognalSum(int[,] nums)
        {
            for (int i = 0; i < nums.GetLength(0) ; i++)
            {
                int upperPostivDiognalSum = 0;
                int count = 0;
                for (int j = i + 1; j < nums.GetLength(1); j++)
                {
                    if (nums[i,j] > 0)
                    {
                        upperPostivDiognalSum += nums[i, j];
                        count++;
                    }
                }

                Console.WriteLine($"Setirin nomresi ={i}, Say = {count}, Cem = {upperPostivDiognalSum}");
            }
        }

        static void Main(string[] args)
        { 
            int[,] X = new int[6, 6]
            {
                {1, 4, -4, -8, 8, 7 },
                {-2, 4, -4, -11, 6, -7},
                {3, 4, -4, -8, 5, 9  },
                {-5, 4, -4, -8, 8, 12},
                {6, 4, -4, -8, 8, 7  },
                {-8, 4, -4, -8, 8, 7 }
            };

            UppreDiognalSum(X);

            Console.ReadLine();
        }
    }
}
