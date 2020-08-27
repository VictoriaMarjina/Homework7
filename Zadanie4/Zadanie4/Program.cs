using System;

namespace Zadanie4 //4) Написать функцию, которая получает в качестве параметров 2 целых числа и возвращает сумму чисел из диапазона между ними. Рекурсия. 
{
    class Program
    {
        static void Main()
        {
            try//два целых числа
            {
                Console.WriteLine("Ведите первое число");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ведите второе число");
                int num2 = Convert.ToInt32(Console.ReadLine());
                if (((num2-num1) != 0) && (Math.Abs(num2 - num1) != 1)){   //если они идут не подряд и не одинаковые числа
                    if (num1 < num2)          // находим меньшее, от меньшего до большего суммируем
                    {
                        int result = Sum(num1, num2) - num1;
                        Console.WriteLine($"Сумма = {result}");
                    }
                    else
                    {
                        int result = Sum(num2, num1) - num2;
                        Console.WriteLine($"Сумма = {result}");
                    }
                    //первое текущее в сумме не нужно, но без него не найдет последующее через +1
                }
                else
                {
                    Console.WriteLine("Числа идут подряд или одинаковы, складывать нечего. Попробуйте снова");
                    Main();
                }
            }
            catch
            {
                Console.WriteLine("Были введены неверные данные. Попробуйте снова");
                Main();

            }
        }
        static int Sum(int x, int y)
        {
            if (x == y)// до того пока не дойдет до большего числа будет делать +1 меньшего
            {
                return 0;
            }
            else
            {
                return x + Sum(x + 1, y); // складываю текущее и последующее

            }


        }

    }
}
