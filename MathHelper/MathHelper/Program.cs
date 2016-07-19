using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, вас приветствует математическая программа");
            Console.WriteLine("Пожалуйста введите число.");
            string S = Console.ReadLine();

            if (S == "q")
            {
                return;
            }

            int M = Int32.Parse(S);
            long c1 = 1;
            int c2 = 0;
            int c3 = 0;

            for (int i = 1; i <= M; i++)
            {
                c1 *= i;
                c2 += i;
                if (i % 2 == 0)
                {
                    c3 = i;
                }
            }

            Console.WriteLine("Факториал числа {0} равен {1}", M, c1);
            Console.WriteLine("Сумма от 1 до {0} равна {1}", M, c2);
            Console.WriteLine("Максимальное четное число меньше {0} равно {1}", M, c3);

            Console.ReadKey();
        }
    }
}
