using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    class Program
    {
        static void Main(string[] args)
        {
            string storeNam = "ТОВ МЕТРО";
            string address = "м.Харків";
            string tin = "320491926543";
            int cash = 844;
            int idNum = 53;

            DateTime date = new DateTime(2021, 07, 28, 18, 57, 09);

            (string title, int quant, double price)[] purchases =
            {
                ("NESVITA каша ", 2, 26.7),
                ("Gourmet паштет ", 1, 52.0),
                ("Грузинтский Букет лимонад ", 1, 14.08),
                ("Coca-Cola ", 1, 8.17)
            };

            double result = 0.0;

            Console.WriteLine($"{storeNam, 52}");
            Console.WriteLine($"{"",-30}BYY {tin}");
            Console.WriteLine($"{"", -40}Магазин");
            Console.WriteLine($"{address,70}");
            Console.WriteLine($"{"",-35}кассовый чек. Приход");
            Console.WriteLine($"{}");
            Console.WriteLine($"{}");
            Console.WriteLine($"{}");
            Console.WriteLine($"{}");

            Console.WriteLine();
            for (int i=0; i< purchases.Length; i++)
            {
                double sum = purchases[i].quant * purchases[i].price;
                Console.WriteLine($"{}";
                Console.WriteLine($"{}");
                Console.WriteLine($"{}");
                Console.WriteLine($"{}");
                result += sum;
            }

            Console.WriteLine($"{}");
            Console.WriteLine($"{}";
            Console.WriteLine($"{}");

            Console.ReadKey();
        }
    }
}
