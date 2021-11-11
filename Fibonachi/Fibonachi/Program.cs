using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = GetNum();
            Console.WriteLine(GetFeb(num));
            Console.ReadKey();
        }
        static int GetNum()
        {
            Console.WriteLine("Укажи порядок последовательности числа фибоначи");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int GetFeb(int n)
        {
            if (n>=2)
            {
                return (GetFeb(n - 1) + GetFeb(n - 2));
            }
            else if (n==1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
