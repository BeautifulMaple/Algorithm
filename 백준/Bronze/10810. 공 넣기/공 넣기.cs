using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' '); //입력값
        int N = int.Parse(inputs[0]);   // 바구니
        int M = int.Parse(inputs[1]);   // 공

        // N 크기의 배열 생성, 초기값은 0
        int[] basketnum = new int[N];

        for (int j = 0; j < M; j++)
        {
            string[] basket = Console.ReadLine().Split(' ');
            int inum = int.Parse(basket[0]) -1;
            int jnum = int.Parse(basket[1]) -1;
            int knum = int.Parse(basket[2]);
            for(int i = inum; i <= jnum; i++)
            {
                basketnum[i] = knum;
            }
        }
        Console.WriteLine(string.Join(" ", basketnum));
        
    }
}
