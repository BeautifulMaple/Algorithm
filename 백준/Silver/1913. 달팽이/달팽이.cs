using System;
using System.Text;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine()); // NxN 배열
            int target = int.Parse(Console.ReadLine()); // 찾고자 하는 수
            int[,] snail = new int[N, N];
            int x = 0, y = 0, dir = 0;

            // 방향 제어 (상, 오, 하, 좌)
            int[] dx = { 1, 0, -1, 0 }; 
            int[] dy = { 0, 1, 0, -1 };
            int num = N * N;

            while (num > 0)
            {
                snail[x, y] = num;
                int nx = x + dx[dir];
                int ny = y + dy[dir];
                if (nx >= 0 && nx < N && ny >= 0 && ny < N && snail[nx, ny] == 0)
                {
                    x = nx;
                    y = ny;
                }
                else
                {
                    dir = (dir + 1) % 4;
                    x += dx[dir];
                    y += dy[dir];
                }
                num--;
            }

            int targetX = 0, targetY = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    //Console.Write(snail[i, j] + " ");
                    if (snail[i, j] == target)
                    {
                        targetX = i + 1;
                        targetY = j + 1;
                    }
                    sb.Append(snail[i, j] + " ");
                }
                sb.Append("\n");
                //Console.WriteLine();
            }
            sb.Append(targetX+ " " +targetY);
            Console.Write(sb.ToString());
            //Console.WriteLine($"{targetX} {targetY}"); // 찾고자 하는 숫자의 위치 출력
        }
    }
}
