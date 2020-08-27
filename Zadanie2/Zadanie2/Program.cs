using System; // 2)Написать рекурсивную функцию нахождения наибольшего общего делителя двух целых чисел.


namespace Zadanie2
{
    class Program
    {
        static void Main()
        {

            try //указано только что числа должны быть целыми, поэтому пропускаем отрицательные
            {
                Console.WriteLine("Введите первое число");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int num11 = Math.Abs(num1);//если введено отрицательное число, то НОД вычисляем по модулю
                int num22 = Math.Abs(num2);
                int result = Nod(num11, num22);
                Console.WriteLine($"НОД = {result}");
            }
            catch
            {
                Console.WriteLine("Были введены неверные данные. Попробуйте снова");
                Main();
            }
        }
        static int Nod(int x, int y)
        {
            if (x == 0 || y == 0) // пока разница не станет равной 0, из большего отнимаем меньшее
            {
                return 1;
            }
            else if (x > y)
            {
                return Nod(x - y, y);


            }
            else if (y > x)
            {

                return Nod(x, y - x);

            }

            return x; // последнее значение х и у и есть нод

        }

    }
}
