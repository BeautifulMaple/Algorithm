using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split();  // N 바이트
        int N = int.Parse(inputs[0]); // 문제 후보
        int M = int.Parse(inputs[1]); // 출제위원들

        int count = 0;
        for (int i = 0; i < N; i++)
        {
            string votes = Console.ReadLine();
            int countO = 0, countX = 0;
            foreach (char vote in votes)
            {
                if (vote == 'O')
                {
                    ++countO;
                }
                else if (vote == 'X')
                {
                    ++countX;
                }
            }
            if (countO >= countX)
            {
                count++;
            }
        }
        Console.WriteLine(count);

    }
}
