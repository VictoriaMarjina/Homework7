﻿using System;

namespace Zadanie1// 1) Найти сумму 22 + 23 + 24 + … + 210. Операцию возведения в степень не использовать.

{
    class Program
    {
        static void Main(string[] args)//так как все данные заданы по дефолду, нет необходимости в валидации. Иначе использовала бы ту же логику, что в задании 3.
        {
            int x = 2;
            int y = 1;
            int result = Sum(x, y) - x; // в конечном результате 2 в первой степени не нужно 
            Console.WriteLine( $"Сумма степеней двойки начиная со 2-й до 10-й равна {result}.");
        }
        static int Sum(int x, int y)
        {
            if (y == 11)// 11 шаг дает рез 0 и не влияет на сумму
            {
                return 0;
            }
            else
            {
                return x + x * Sum(x, y + 1); // суммирую начиная с х в первой степени каждый последующий результат

            }

        }

    }
}
