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
            string userInput = Console.ReadLine();

            if (userInput == "q")
            {
                return;
            }

            int number = Int32.Parse(userInput);
            long fuct = 1;
            int summ = 0;
            int maxEvenNumber = 0;

            for (int i = 1; i <= number; i++)
            {
                fuct *= i;
                summ += i;
                if (i % 2 == 0)
                {
                    maxEvenNumber = i;
                }
            }

            Console.WriteLine("Факториал числа {0} равен {1}", number, fuct);
            Console.WriteLine("Сумма от 1 до {0} равна {1}", number, summ);
            Console.WriteLine("Максимальное четное число меньше {0} равно {1}", number, maxEvenNumber);

            Console.ReadKey();
        }
    }
}
