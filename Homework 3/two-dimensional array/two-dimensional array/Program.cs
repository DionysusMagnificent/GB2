using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_dimensional_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { {1, 2, 3}, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j< arr.GetLength(1); j++)
                {
                    if (i==j)
                    {
                        Console.Write($"{arr[i, j]}");
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
