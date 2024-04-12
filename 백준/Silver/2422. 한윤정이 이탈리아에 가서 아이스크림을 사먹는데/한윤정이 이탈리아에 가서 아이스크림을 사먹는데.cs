using System;
using System.Linq;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            // N : 종류, M : 섞어먹으면 안 되는 조합의 개수
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            // 섞어먹으면 안 되는 조합 저장
            bool[,] forice = new bool[N+1, N+1];
            // 사용자로부터 M개의 조합을 입력받아 배열에 저장
            for (int i = 0; i < M; i++)
            {
                string[] NM_ice = Console.ReadLine().Split();
                int S_Mix = int.Parse(NM_ice[0]); // 섞으면 안 되는 조합의 첫 번째
                int E_Mix = int.Parse(NM_ice[1]); // 두 번째
                forice[S_Mix, E_Mix] = true; // 섞어먹으면 안 되는 조합
                forice[E_Mix, S_Mix] = true; // 양방향으로 표시 (대칭으로 저장)
            }

            int count = 0; // 조합 가능한 수 저장하기
            // 아이스크림 조합하기
            for (int i = 1; i <= N; i++)
            {
                for (int j = i + 1; j <= N; j++) 
                {
                    if (forice[i, j]) continue;  // i와 j가 섞어먹으면 안 되는 조합이면 건너뛰기
                    for (int k = j + 1; k <= N; k++)
                    {
                        // i와 k,j와 k가 모두 섞어먹어도 되는 조합
                        if (!forice[i, k] && !forice[j, k]) // 모든 아이스크림 조합이 가능
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}