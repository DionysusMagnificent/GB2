using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Укажи порядок последовательности числа фибоначи");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число Фибоначчи: " + Fibonachi(n));
            Console.ReadKey();
        }
        static int Fibonachi(int n)
        {
            return Fibonachi(n, out _);
        }
        static int Fibonachi(int n, out int f1)
        {
            f1 = 0;
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                int f2; //Число Фибоначчи n - 2
                f1 = Fibonachi(n - 1, out f2); //Число Фибоначчи n - 1
                return f1 + f2;
            }
        }

        static string GetCorrectString(string str)
        {

            string result = "";
            int countSentenses = 0;
            int begin = 0;
            int end = 0;
            for (int i = 0; i < str.Length; i++)
            {
                string tempStr = "";
                if (str[i] != ' ' && str[i].ToString() == str[i].ToString().ToUpper())
                {
                    tempStr += str[i];
                    i++;
                    while (i < str.Length && (str[i] == ' ' || str[i].ToString() != str[i].ToString().ToUpper()))
                    {
                        tempStr += str[i];
                        i++;
                    }
                    i--;
                    result += tempStr.Trim() + ". ";
                }
            }
            return result;
        }
    }
}
