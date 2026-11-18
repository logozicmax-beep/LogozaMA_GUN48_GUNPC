using System;

namespace Netologia0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            Console.WriteLine("Фибоначчи");
            int current = 1;
            int previous = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(previous);
                int next = current + previous;
                previous = current;
                current = next;
            }
            //Задание 2
            for (int a = 2; a <= 20; a+=2)
            {
                Console.WriteLine("Чётные числа: " + a);
            }
            //Задание 3
            Console.WriteLine("Таблица умножения от 1 до 5");
            for (int row = 1;row <= 5; row++)
            {
                for (int column = 1; column <= 5; column++)
                {
                    Console.Write($"{row * column}\t");
                }
                Console.WriteLine();
            }

            //Задание 4
            string password = "qwerty";
            string input;
            int retrycount = 5;
            do
            {
                Console.Write("Введите пароль: ");
                input = Console.ReadLine();
                if (input != password)
                {
                    Console.WriteLine("Неверный пароль!");
                    retrycount--;
                }
                else if (input == password)
                {
                    Console.WriteLine("Добро пожаловать :)");
                }
                if (retrycount == 0)
                {
                    Console.WriteLine("Слишком много ошибок!!! Попробуйте снова через 30 минут.");
                }
            } while (input != password && retrycount != 0);
        }
    }
}
