﻿using System;
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
            int number;
            if (TryGetNumberFromUser(out number))
            {
                //CalculateFactorialAndSummAndMaxEvenNumber(number, out fact, out summ, out maxEvenNumber);
                GetFactorialAndOutput(number);
                GetSummFrom1ToNAndOutput(number);
                GetMaxEvanNumberAndOutput(number);

                Console.ReadKey();
            }


        }

        private static void GetMaxEvanNumberAndOutput(int number)
        {
            int maxEvenNumber = 0;
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    maxEvenNumber = i;
                }
            }
            Console.WriteLine("Максимальное четное число меньше {0} равно {1}", number, maxEvenNumber);
        }

        private static void GetSummFrom1ToNAndOutput(int number)
        {
            int summ = 0;
            for (int i = 1; i <= number; i++)
            {
                summ += i;
            }
            Console.WriteLine("Сумма от 1 до {0} равна {1}", number, summ);
        }

        private static void GetFactorialAndOutput(int number)
        {
            long fact = 1;           
            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }
            Console.WriteLine("Факториал числа {0} равен {1}", number, fact);
        }

        private static void CalculateFactorialAndSummAndMaxEvenNumber(int number, out long fact, out int summ, out int maxEvenNumber)
        {
            
            fact = 1;
            summ = 0;
            maxEvenNumber = 0;

            for (int i = 1; i <= number; i++)
            {
                fact *= i;
                summ += i;
                if (i % 2 == 0)
                {
                    maxEvenNumber = i;
                }
            }
        }

        private static bool TryGetNumberFromUser(out int number)
        {
            Console.WriteLine("Здравствуйте, вас приветствует математическая программа");
            Console.WriteLine("Пожалуйста, введите число.");
            string userInput = Console.ReadLine();
            if (userInput == "q")
            {
                number = -1;
                return false;
            }
            number = Int32.Parse(userInput);
            return true;
        }
    }
}
