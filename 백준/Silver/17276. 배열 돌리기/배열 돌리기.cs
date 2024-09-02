using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        BufferedStream bufferedInput = new BufferedStream(Console.OpenStandardInput());
        StreamReader sr = new StreamReader(bufferedInput);
        {
            using (BufferedStream bufferedOutput = new BufferedStream(Console.OpenStandardOutput()))
            using (StreamWriter sw = new StreamWriter(bufferedOutput))
            {
                int T = int.Parse(sr.ReadLine());  // 테스트 케이스 수 입력 받기
                for (int t = 0; t < T; t++)
                {
                    // 배열 크기와 회전 각도 입력 받기
                    string[] firstLine = sr.ReadLine().Split();
                    int n = int.Parse(firstLine[0]); // 배열의 크기 (n x n)
                    int d = int.Parse(firstLine[1]); // 회전 각도

                    // 배열 X 입력 받기
                    int[,] X = new int[n, n];
                    for (int i = 0; i < n; i++)
                    {
                        string[] row = sr.ReadLine().Split();
                        for (int j = 0; j < n; j++)
                        {
                            X[i, j] = int.Parse(row[j]); // 배열의 각 요소 입력 받기
                        }
                    }

                    // 회전 각도 최적화
                    d = d % 360; // 각도를 360도로 나눈 나머지로 변환
                    if (d < 0) d += 360; // d가 음수인 경우 양수로 변환

                    int rotationCount = d / 45; // 회전 횟수 계산

                    // 회전이 필요한 경우에만 회전 수행
                    if (rotationCount > 0)
                    {
                        X = Rotate(X, n, rotationCount); // 회전 수행
                    }

                    // 결과 출력
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            sw.Write(X[i, j] + " "); // 배열의 각 요소 출력
                        }
                        sw.WriteLine();
                    }
                    sw.Flush(); // 버퍼를 비워서 즉시 출력
                }
            }
        }
    }

    // 45도 시계 방향으로 회전하는 함수
    static int[,] Rotate(int[,] X, int n, int rotationCount)
    {
        int[,] result = (int[,])X.Clone(); // 배열을 복사하여 결과 배열 초기화
        for (int r = 0; r < rotationCount; r++)
        {
            int[] tempDiagonal = new int[n]; // 주 대각선 요소 저장용 배열
            int[] tempMiddleColumn = new int[n]; // 중간 열 요소 저장용 배열
            int[] tempAntiDiagonal = new int[n]; // 부 대각선 요소 저장용 배열
            int[] tempMiddleRow = new int[n]; // 중간 행 요소 저장용 배열

            // 주 대각선 -> 중간 열로 이동
            for (int i = 0; i < n; i++)
            {
                tempMiddleColumn[i] = X[i, i];
            }

            // 중간 열 -> 부 대각선으로 이동
            for (int i = 0; i < n; i++)
            {
                tempAntiDiagonal[i] = X[i, n / 2];
            }

            // 부 대각선 -> 중간 행으로 이동
            for (int i = 0; i < n; i++)
            {
                tempMiddleRow[i] = X[n - i - 1, i];
            }

            // 중간 행 -> 주 대각선으로 이동
            for (int i = 0; i < n; i++)
            {
                tempDiagonal[i] = X[n / 2, i];
            }

            // 결과 배열에 회전된 값 업데이트
            for (int i = 0; i < n; i++)
            {
                result[i, n / 2] = tempMiddleColumn[i]; // 중간 열 업데이트
                result[i, n - i - 1] = tempAntiDiagonal[i]; // 부 대각선 업데이트
                result[n / 2, i] = tempMiddleRow[i]; // 중간 행 업데이트
                result[i, i] = tempDiagonal[i]; // 주 대각선 업데이트
            }

            // 다음 회전을 위해 배열을 복사
            X = (int[,])result.Clone();
        }

        return result; // 회전된 배열 반환
    }
}
