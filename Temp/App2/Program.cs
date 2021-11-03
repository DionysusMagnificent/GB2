using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимакльную температуру за сутки");
            string minTempStr = Console.ReadLine().Replace('.','.') ;
            Console.WriteLine("Введите максимальную температуру за сутки");
            string maxTempStr = Console.ReadLine().Replace('.', '.');

            bool isValidMinTemp = float.TryParse(minTempStr, out float minTemp );
            bool isValidMaxTemp = float.TryParse(maxTempStr, out float maxTemp);

            if (isValidMinTemp && isValidMaxTemp ) 
            {
                Console.WriteLine($"Средняя температура равна: {(minTemp + maxTemp) / 2.0f:f2}");
            }

            else if (!isValidMinTemp)
            {
                Console.WriteLine("Введена неправильная минимальня температура. Невозможно вычеслить температуру");
            }

            else if (!isValidMinTemp)
            {
                Console.WriteLine("Введена неправильная максимальная температура. Невозможно вычеслить температуру"); ;
            }

            Console.ReadKey();
        }
    }
}
