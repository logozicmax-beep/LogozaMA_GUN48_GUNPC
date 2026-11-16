using System;

namespace Netologia0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            int[] fibonacci = new int[] {0,1,1,2,3,5,8,13,21,34};
            for (int i = 0; i < fibonacci.Length; i++)
            {
                Console.WriteLine("Фиббоначи: " + fibonacci[i]);
            }
            //Задание 2
            int[] evenarray = new int[] {2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
            for (int a = 0; a < evenarray.Length; a++)
            {
                if (evenarray[a] % 2 == 0)
                {
                    Console.WriteLine("Чётные числа: " + a);
                }
            }
            //Задание 3
            Console.WriteLine("Таблица умножения от 1 до 5");
            for (int b = 1;b <= 5; b++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    Console.Write($"{b}*{c} = ");
                    Console.WriteLine(" " + b * c);
                }
            }
            //Задание 4
            string password = "qwerty";
            string input;
            do
            {
                Console.Write("Введите пароль: ");
                input = Console.ReadLine();
            } while (input != password);
        }
    }
}
