using System;

class Program
{
    static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine($"{N} * {i} = {N * i}");
        }
    }
}
