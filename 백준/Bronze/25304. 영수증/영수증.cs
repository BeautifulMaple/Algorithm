using System;

class Program
{
    static void Main(string[] args)
    {
        int X = int.Parse(Console.ReadLine());  // 총 금액
        int N = int.Parse(Console.ReadLine());  // 종류의 수

        int sum = 0;

        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            sum += int.Parse(inputs[0]) * int.Parse(inputs[1]); // 가격 * 개수

        }
        Console.WriteLine(sum == X ? "Yes" : "No");
    }
}
