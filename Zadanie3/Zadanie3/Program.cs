using System;

namespace Zadanie3 // 3) Написать рекурсивную функцию нахождения степени числа.
{
    class Program
    {
        static void Main()
        {
            try // в задаче не указано что число должно быть натуральным целым, поэтому в степень можно возвести также отрицательные и дробные числа. но сама степень должна быть целым числом.
            {

                Console.WriteLine("Введите число, которое необходимо возвести в степень. Если оно дробное, то после целой части поставьте точку, иначе программа не сможет найти корректный результат.");
                string num_string = Console.ReadLine();
                char ch = ','; // если вместо точки ввели запятую в дроби
                int indexOfChar = num_string.IndexOf(ch);// когда не находит дает -1
                /* Console.WriteLine(indexOfChar);*/
                if (indexOfChar != -1)
                {
                    Console.WriteLine("Введите дробное число, отделяя целую часть от дробной точкой.");
                    Main();
                }
                else
                {
                    decimal num = Convert.ToDecimal(num_string); //double дает погрешность при перемножении, приходится использовать decimal чтобы возводить в степень дробное число без погрешности
                    Console.WriteLine("Введите степень в которую нужно возвести число (положительное число от 0 до 255)");
                    int power1 = Convert.ToInt32(Console.ReadLine());
                    decimal power2 = Convert.ToDecimal(power1);
                    if (power2 >= 0)
                    {
                        decimal result = StepenPlus(num, power2);
                        Console.WriteLine(result);
                    }
                    else
                    {
                        decimal result = StepenMinus(num, power2);
                        Console.WriteLine(result);
                    }
                }

            }
            catch
            {
                Console.WriteLine("Были введены неверные данные. Попробуйте снова");
                Main();
            }


        }
        static decimal StepenPlus(decimal num, decimal power2)//полож степень шаг -1 до 0
        {
            if (power2 == 0)
            {
                return 1;
            }
            else
            {
                return num * StepenPlus(num, power2 - 1);


            }

        }

        static decimal StepenMinus(decimal num, decimal power2)//отриц степень шагом +1 до 0
        {
            if (power2 == 0)
            {
                return 1;
            }
            else
            {
                return 1 / num * StepenMinus(num, power2 + 1);// отриц степень это один разделить на число в той же самой положительной степени


            }

        }
    }

}