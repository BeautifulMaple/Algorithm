using System;
using System.Runtime.Intrinsics.Arm;

namespace Baekjoon
{
    class Progrma
    {
        static void Main(string[] args)
        {
            // 테스트 케이스 개수 입력 받기 (첫번째)
            int T = int.Parse(Console.ReadLine());

            for (int t = 0; t < T; t++)
            {
                int N = int.Parse(Console.ReadLine()); // 동전의 종류 수 입력 (첫 줄)
                // 동전의 가치를 배열로 저장하기
                string[] CoinsInput = Console.ReadLine().Split(); // 동전의 N가지 금액 (두 줄)
                int[] coins = new int[N]; // 코인을 받을 동전 배열
                for (int i = 0; i < N; i++)
                {
                    // 동전들 저장하기
                    coins[i] = int.Parse(CoinsInput[i]);
                }

                int M = int.Parse(Console.ReadLine()); // 목표 금액
                int[] dp = new int[M +1]; //M(1 ≤ M ≤ 10000)
                // 금액이 0인 경우 동전 하나도 사용하지 않은 가지 수
                // 찾아본 내용
                dp[0] = 1;

                // 동전 구하기 문제
                for (int i = 0; i < N; i++)
                {
                    for (int j = coins[i]; j <= M; j++)
                    {
                        dp[j] += dp[j - coins[i]];
                    }
                }
                Console.WriteLine(dp[M]); // 결과 출력
            }
        }
    }
}