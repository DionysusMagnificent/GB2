using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            String str = Console.ReadLine();
            for (int i =str.Length - 1; i>=0; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
