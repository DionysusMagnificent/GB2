using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] phoneBook =
            {
                {"Nykolay ", "+380634313735" },
                {"Nadezda ", "+380636303685" },
                {"Natalya ", "+380935671413" },
                {"Igor    ", "+380574153645" },
                {"Elizabet", "+380955554368" }
            };

            Console.WriteLine("PHONEBOOK: ");
            for (int i=0; i<phoneBook.GetLength(0); i++)
            {
                Console.WriteLine($"{phoneBook[i, 0]}, {phoneBook[i, 1]}");
            }
            Console.ReadKey();
        }

    }
}
