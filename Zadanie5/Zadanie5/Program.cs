using System;//5)Написать программу, которая выдает день недели на английском языке по номеру дня недели. (Вариант первый)


namespace Zadanie5
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Ведите номер дня недели "); // целое положительное 1-7
                int num = Convert.ToInt32(Console.ReadLine());
                if (num > 0 && num < 8)
                {
                    string day = Convert.ToString(num);
                    FindDaysName(day);
                }
                else
                {
                    Console.WriteLine("В неделе 7 дней, соответственно число должно быть в диапазоне от 1 до 7");
                    Main();
                }
            }
            catch
            {
                Console.WriteLine("Были введены неверные данные. Попробуйте снова");
                Main();
            }

        }
        enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void FindDaysName(string day)

        {
            DaysOfWeek op;
            switch (day)
            {

                case "1":
                    op = DaysOfWeek.Monday; //знаю имя

                    Console.WriteLine(op);
                    break;
                case "2":

                    op = DaysOfWeek.Tuesday;

                    Console.WriteLine(op);
                    break;
                case "3":
                    op = DaysOfWeek.Wednesday;

                    Console.WriteLine(op);
                    break;
                case "4":

                    op = DaysOfWeek.Thursday;

                    Console.WriteLine(op);
                    break;
                case "5":

                    op = DaysOfWeek.Friday;

                    Console.WriteLine(op);
                    break;

                case "6":

                    op = DaysOfWeek.Saturday;

                    Console.WriteLine(op);
                    break;
                case "7":

                    op = DaysOfWeek.Sunday;

                    Console.WriteLine(op);
                    break;



            }



        }


    }
}


/*using System;  //5)Написать программу, которая выдает день недели на английском языке по номеру дня недели. (Вариант второй, но мы это не прошли еще)


namespace ConsoleApp12
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Ведите номер дня недели ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num > 0 && num < 8)
                {

                    FindDaysName(num);

                }
                else
                {
                    Console.WriteLine("В неделе 7 дней, соответственно число должно быть в диапазоне от 1 до 7");
                    Main();
                }
            }
            catch
            {
                Console.WriteLine("Были введены неверные данные. Попробуйте снова");
                Main();
            }

        }


        enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void FindDaysName(int num)

        {
            DaysOfWeek day;

            day = (DaysOfWeek)Enum.GetValues(typeof(DaysOfWeek)).GetValue(num - 1);// знаю номер, -1 потомучто с 0 в энаме начинается счет

            Console.WriteLine(day);




        }


    }
}*/

