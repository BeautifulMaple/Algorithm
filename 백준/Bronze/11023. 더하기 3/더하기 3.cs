using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' '); //입력값
        // 띄어쓰기 제거 후 선택후 더하기
        int sum = inputs.Select(int.Parse).Sum();

        Console.WriteLine(sum);
        
    }
}
