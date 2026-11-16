using System;

namespace Netologia0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            var input1 = Console.ReadLine();
            if (!Int32.TryParse(input1, out var a))
            {
                Console.WriteLine("Error! Could not recognize your number!");
                return;
            }
            Console.WriteLine("Enter second number");
            var input2 = Console.ReadLine();
            if (!Int32.TryParse(input2, out var b))
            {
                Console.WriteLine("Error! Could not recognize your number!");
                return;
            }

            Console.WriteLine("Enter type of operation (&, |, ^)");
            string operationType = Console.ReadLine();
            switch (operationType)
            {
                case "&":
                    var res1 = a & b;
                    Console.WriteLine(res1);
                    Console.WriteLine(Convert.ToString(res1, 2));
                    Console.WriteLine(Convert.ToString(res1, 16));
                    break;
                case "|":
                    var res2 = a | b;
                    Console.WriteLine(res2);
                    Console.WriteLine(Convert.ToString(res2, 2));
                    Console.WriteLine(Convert.ToString(res2, 16));
                    break;
                case "^":
                    var res3 = a ^ b;
                    Console.WriteLine(res3);
                    Console.WriteLine(Convert.ToString(res3, 2));
                    Console.WriteLine(Convert.ToString(res3, 16));
                    break;
                default:
                    Console.WriteLine("Wrong operation type!");
                    break;
            }
        }
    }
}
