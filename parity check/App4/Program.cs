using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число для проверки четности");
            string inputValue = Console.ReadLine();
            bool isValid = int.TryParse(inputValue, out int number);

            if (!isValid)
            {
                Console.WriteLine("некоректное число");
                Console.ReadKey();
                return;
            }

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} - чётное");
            }
            
            else
            {
                Console.WriteLine($"{number} - не чётное ");
            }
            Console.ReadKey();
        }
    }
}
