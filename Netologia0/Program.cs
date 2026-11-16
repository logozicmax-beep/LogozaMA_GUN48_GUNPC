using System;

namespace Netologia0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Здесь массивы заданий 1-4

            int[] fibonacci = new int[8] { 0, 1, 1, 2, 3, 5, 8, 13 };
            string[] twelvemonths = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int[,] matrix = {
            {2, 3, 4},
            {2*2, 3*3 ,4*4},
            {2*2*2, 3*3*3 ,4*4*4},
            };
            double[][] jaggedArray = new double[3][];
            jaggedArray[0] = new double[5] { 1, 2, 3, 4, 5 };
            jaggedArray[1] = new double[2] { Math.E, Math.PI };
            jaggedArray[2] = new double[4] { Math.Log(1, 10), Math.Log(10, 10), Math.Log(100, 10), Math.Log(1000, 10) };

            // массивы для заданий 5 и 6
            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };
            Array.Copy(array, array2, 3);
            Array.Resize(ref array, 10);
            // Выведите результат
            Console.WriteLine("Первый массив: ");
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[4]);
            Console.WriteLine(array[5]);
            Console.WriteLine(array[6]);
            Console.WriteLine(array[7]);
            Console.WriteLine(array[8]);
            Console.WriteLine(array[9]);
            Console.WriteLine("Второй массив: ");
            Console.WriteLine(array2[0]);
            Console.WriteLine(array2[1]);
            Console.WriteLine(array2[2]);
            Console.WriteLine(array2[3]);
            Console.WriteLine(array2[4]);
            Console.WriteLine(array2[5]);
            Console.WriteLine(array2[6]);
        }
    }
}
