using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper
{
    class Program

    {
        const string symbolForExit = "q";

        static void Main(string[] args)
        {
            try
            {
                int number;
                if (TryGetNumberFromUser(out number))
                {
                    long fact = GetFactorial(number);
                    int summ = GetSummFrom1ToN(number);
                    int maxEvenNumber = GetMaxEvanNumber(number);

                    Console.WriteLine("Факториал числа {0} равен {1}", number, fact);
                    Console.WriteLine("Сумма от 1 до {0} равна {1}", number, summ);
                    Console.WriteLine("Максимальное четное число меньше {0} равно {1}", number, maxEvenNumber);
                    
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Что-то пошло не так. Экстренный выход.");
            }
            Console.ReadKey();


        }

        private static int GetMaxEvanNumber(int number)
        {
            int maxEvenNumber = 0;
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    maxEvenNumber = i;
                }
            }
            return maxEvenNumber;
        }

        private static int GetSummFrom1ToN(int number)
        {
            int summ = 0;
            for (int i = 1; i <= number; i++)
            {
                summ += i;
            }
            return summ;
        }

        private static long GetFactorial(int number)
        {
            long fact = 1;           
            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }
            return fact;
        }

        private static bool TryGetNumberFromUser(out int number)
        {
            Console.WriteLine("Здравствуйте, вас приветствует математическая программа");
            Console.WriteLine("Пожалуйста, введите число. Для выхода введите " + symbolForExit);
            string userInput = Console.ReadLine();
            while (!Int32.TryParse(userInput, out number))
            {
                if (userInput == symbolForExit)
                {
                    number = -1;
                    return false;
                }
                else
                {
                    Console.WriteLine("Вы ввели неправильное значение. Пожалуйста, введите именно число. Для выхода нажмите {0}.",symbolForExit);
                    userInput = Console.ReadLine();
                }
            }
            return true;
        }
    }
}
