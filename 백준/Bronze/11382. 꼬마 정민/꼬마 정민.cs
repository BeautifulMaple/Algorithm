using System;

namespace Baekjoon
{
    class Progrma
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            // 입력값 A, B, C
            long A = long.Parse(input[0]);
            long B = long.Parse(input[1]);
            long C = long.Parse(input[2]);

            Console.WriteLine(A + B + C);
        }
    }
}