using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = GetFullName("Семен", "Семенович", "Петров");
            string name_2 = GetFullName("Илья", "Владимирович", "Орлов");
            string name_3 = GetFullName("Артем", "Александрович", "Панфилов");
            string name_4 = GetFullName("Владислав", "Николаевич", "Шубин");
            string greeting = MakeGreeting();


            Print(greeting);
            Print(" ");
            Print(name);
            Print(name_2);
            Print( name_3);
            Print(name_4);
            


            Console.ReadKey();
        }

        static string GetFullName( string firstName, string patronymic, string lastName)
        { 
            return $" {firstName} {patronymic} {lastName} ";
        }

        static string MakeGreeting()
        {
            return $"Сотрудники : ";
        }

        static void Print (string x)
        {
           Console.WriteLine(x);
        }
    }
}
