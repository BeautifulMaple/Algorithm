using System;

namespace BaekJoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split();
            int A = int.Parse(num[0]);
            int B = int.Parse(num[1]);
            int C = int.Parse(num[2]);

            Console.WriteLine((A + B) % C);
            Console.WriteLine(((A % C) + (B % C)) % C);
            Console.WriteLine((A * B) % C);
            Console.WriteLine(((A % C) * (B % C)) % C);
        }
    }
}