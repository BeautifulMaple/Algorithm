using System;

class Program
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            Console.WriteLine(A + B);
        }
    }
}
