using System;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());  // N 바이트

        

        int count = N / 4;  // 4바이트로 나누기

        string result = new string(' ', count).Replace(" ", "long ") + "int";

        Console.WriteLine(result);
    }
}
