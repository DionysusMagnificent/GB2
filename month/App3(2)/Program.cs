using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер месяца: ");
            string mount = Console.ReadLine();
            int x = Convert.ToInt32(mount);



            switch (x)
            {
                case 1:
                    Console.WriteLine("Весна Март");
                    break;
                case 2:
                    Console.WriteLine("Весна Апрель");
                    break;
                case 3:
                    Console.WriteLine("Весна Май");
                    break;
                case 4:
                    Console.WriteLine("Лето Июнь");
                    break;
                case 5:
                    Console.WriteLine("Лето Июль");
                    break;
                case 6:
                    Console.WriteLine("Лето Август");
                    break;
                case 7:
                    Console.WriteLine("Осень Сентябрь");
                    break;
                case 8:
                    Console.WriteLine("Осень Октябрь");
                    break;
                case 9:
                    Console.WriteLine("Осень Ноябрь");
                    break;
                case 10:
                    Console.WriteLine("Зима Декабрь");
                    break;
                case 11:
                    Console.WriteLine("Зима Январь");
                    break;
                case 12:
                    Console.WriteLine("Зима Февраль");
                    break;
                default:
                    Console.WriteLine("Ошибка ввода");
                    break;
            }

            Console.ReadKey();
        }
    }
}
