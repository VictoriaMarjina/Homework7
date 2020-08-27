using System; //6)Написать игру «Быки и коровы». Программа "загадывает" четырёхзначное число и играющий должен угадать его. После ввода пользователем числа программа сообщает, сколько цифр числа угадано (быки) и сколько цифр угадано и стоит на нужном месте (коровы). После отгадывания числа на экран необходимо вывести количество сделанных пользователем попыток. В программе необходимо использовать рекурсию.
              // условия из интернета более понятные (https://ravesli.com/praktika-chast-22/) код не оттуда, можете сравнить))
namespace Zadanie6
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Попробуйте отгадать 4-значное число загаданное программой");
            Random rnd = new Random();
            int random_num = rnd.Next(1000, 10000); // выводит рандомное число в указанном диапазоне
            Console.WriteLine(random_num); // для проверки работы программы его нужно видеть, для игры нет
            int attempt = 1; // по умолчанию начинает с первой попытки запрашивать вариант числа у пользователя
            Level(random_num, attempt);//запускает ввод данных ользователем и их проверку
        }
        static void Level(int random_num, int attempt)
        {
            try// целое число в указанном диапазоне
            {
                Console.WriteLine($"Попытка № {attempt}. Введите число");
                int attempt_num = Convert.ToInt32(Console.ReadLine());
                if (attempt_num > 999 && attempt_num < 10000)
                {
                    GameData(random_num, attempt_num, attempt);
                }
                else
                {
                    Console.WriteLine("Вы должны найти 4-значное число. Попробуйте снова");
                    Level(random_num, attempt + 1);
                }
            }
            catch
            {
                Console.WriteLine("Были введены неверные данные. Попробуйте снова");
                Level(random_num, attempt + 1);//запускает след попытку
            }
        }
        static void GameData(int random_num, int attempt_num, int attempt) // подготовка доп данных(макс индекс, дефолдное значение быков и коров
        {

            string attempt_string = Convert.ToString(attempt_num);
            int i = attempt_string.Length - 1; // нужна не длина, а индекс последнего
            /* Console.WriteLine(i);*/
            int bulls = 0;
            int cows = 0;



            Game(bulls, cows, attempt_num, random_num, i, attempt);
        }
        static int Game(int bulls, int cows, int attempt_num, int random_num, int i, int attempt) // тип инт, поэтому сразу строку послать не могу, инт для рекурсии, войд не сработает
        {

            string random_string = Convert.ToString(random_num);//перевожу в строку рандомное число
            string attempt_string2 = Convert.ToString(attempt_num); // перевожу в строку число введенное пользователем

            if (i == -1) // уменьшаю индекс строкового массива на 1, когда массив закончится даст -1
            {
                return GetAnswer(bulls, cows, attempt, random_num);// рекурсия окончена.запускает формирование ответа

            }
            else if (attempt_string2[i] == random_string[i]) // проверяет сколько цифр угаданы на своих местах, если такие есть увеличивает число коров
            {
                return Game(bulls, cows + 1, attempt_num, random_num, i - 1, attempt);
            }
            else if (attempt_string2[i] != random_string[i]) //проверяет сколько цифр угаданы, но не на своих местах, если такие есть увеличивает число быков, если нет переходит к следующему
            {
                char ch = attempt_string2[i];

                int indexOfChar = random_string.IndexOf(ch);// когда не находит дает -1

                if (indexOfChar != -1)//нашел
                {
                    return Game(bulls + 1, cows, attempt_num, random_num, i - 1, attempt);
                }
                else if (indexOfChar == -1)//не нашел
                {
                    return Game(bulls, cows, attempt_num, random_num, i - 1, attempt);
                }

            }
            return 1;

        }


        static int GetAnswer(int bulls, int cows, int attempt, int random_num)
        {
            if (cows == 4)  // число угадано.конец игры
            {
                Console.WriteLine($"Вы угадали! Это число {random_num}");
                Console.WriteLine($"Общее количество попыток = {attempt}");
            }
            else // грамотные окончания
            {
                string bulls2 = "";
                string cows2 = "";
                if (bulls == 0)
                {
                    bulls2 = "быков";
                }
                if (cows == 0)
                {
                    cows2 = "коров";
                }
                if (bulls == 1)
                {
                    bulls2 = "бык";
                }
                if (cows == 1)
                {
                    cows2 = "корова";
                }
                if (cows != 1 && cows != 0)
                {
                    cows2 = "коровы";
                }
                if (bulls != 1 && bulls != 0)
                {
                    bulls2 = "быка";
                }
                PrintAnswer(bulls, bulls2, cows, cows2, attempt, random_num);//вывод ответа
            }
            return 1;

        }
        static void PrintAnswer(int bulls, string bulls2, int cows, string cows2, int attempt, int random_num)
        {
            Console.WriteLine($"{cows} {cows2}, {bulls} {bulls2}. Попробуте еще раз.");
            Console.WriteLine($"Общее количество попыток = {attempt}");
            Level(random_num, attempt + 1);//след попытка


        }


    }
}
