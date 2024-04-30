using System;
using System.Linq;
using System.Runtime.Intrinsics.Arm;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int M = input[1];

            int[,] Map = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                var line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < M; j++)
                {
                    // 각 i라인으로 j 수 만큼 입력 받기
                    Map[i,j] = line[j];
                }
            }

            // DP 배열 초기화 및 계산
            int result = MinDP(N, M, Map);

            Console.WriteLine(result);
        }


        static int MinDP(int N, int M, int[,] map)
        {
            int[,,] DP = new int[N, M, 3];
            int INF = int.MaxValue;

            // DP 배열 초기화
            for(int i = 0;i < N;i++)
                for(int j = 0;j < M; j++)
                    for(int k = 0;k < 3; k++)
                        DP[i,j,k] = (i == 0) ? map[i,j] : INF;

            // DP로 사용하여 각 위치까지의 최소 연료 소비량 계산하기
            for(int i = 1; i < N; i++)
            {
                for(int j = 0; j < M; j++)
                {
                    /// 왼쪽 대각선에서 올 경우
                    if (j > 0) DP[i, j, 0] = Math.Min(DP[i, j, 0], map[i, j] + Math.Min(DP[i - 1, j - 1, 1], DP[i - 1, j - 1, 2]));
                    // 위에서 올 경우
                    DP[i, j, 1] = Math.Min(DP[i, j, 1], map[i, j] + Math.Min(DP[i - 1, j, 0], DP[i - 1, j, 2]));
                    // 오른쪽 대각선에서 올 경우
                    if (j < M - 1) DP[i, j, 2] = Math.Min(DP[i, j, 2], map[i, j] + Math.Min(DP[i - 1, j + 1, 0], DP[i - 1, j + 1, 1]));
                }
            }
            // 마지막 행에서의 최소값 찾기
            int minFuel = INF;
            for (int j = 0; j < M; j++)
                for (int k = 0; k < 3; k++)
                    minFuel = Math.Min(minFuel, DP[N - 1, j, k]);

            return minFuel;
        }
    }
}
