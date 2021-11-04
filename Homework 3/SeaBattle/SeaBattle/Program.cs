using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] arr =
            {
            {'0','x','0','x','0','x','0','x','0','0'},
            {'0','0','0','0','0','0','0','0','0','0'},
            {'0','x','x','0','x','x','x','0','x','0'},
            {'0','0','0','0','0','0','0','0','x','0'},
            {'0','x','x','0','x','x','x','0','0','0'},
            {'0','0','0','0','0','0','0','0','0','0'},
            {'0','0','0','0','0','0','0','x','0','0'},
            {'0','0','0','0','0','0','0','x','0','0'},
            {'0','x','x','x','x','0','0','x','0','0'},
            {'0','0','0','0','0','0','0','x','0','0'}
            };
            
           for (int i=0; i<arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    Console.Write($" {arr[i,j]}");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
