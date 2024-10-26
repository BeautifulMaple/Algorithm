using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        bool[] DP = new bool[N + 1];

        //초기
        DP[0] = false; // 돌이 0일 때
        if (N >= 1) DP[1] = true; // 돌이 1일 때
        if (N >= 3) DP[3] = true; // 돌이 3일 때

        //DP 채우기
        for (int i = 4; i <= N; i++)
        {
            DP[i] = !DP[i-1] || !DP[i-3];
        }

        Console.WriteLine(DP[N] ? "SK" : "CY");
    }
}
