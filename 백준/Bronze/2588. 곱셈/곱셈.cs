using System;

namespace BaekJoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            int n1 = int.Parse(num1);
            int n2 = int.Parse(num2);

            Console.WriteLine(n1 * ((n2 % 100) % 10));
            Console.WriteLine(n1 * ((n2 % 100) / 10));
            Console.WriteLine(n1 * ((n2 / 100)));
            Console.WriteLine(n1 * n2);
        }
    }
}