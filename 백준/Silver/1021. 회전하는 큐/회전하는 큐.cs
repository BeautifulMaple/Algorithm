using System;

namespace BaekJoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Input = Console.ReadLine().Split();
            int N = int.Parse(Input[0]);
            int M = int.Parse(Input[1]);

            // 지민이가 뽑아내려고 하는 수의 위치
            string[] positions = Console.ReadLine().Split();

            // 양방향 큐 구현
            LinkedList<int> deque = new LinkedList<int>();

            // 1 <= N
            for(int i = 1; i <= N; i++)
            {
                deque.AddLast(i);
            }

            int count = 0; // 연산 횟수

            /*
                5 3
                1 2 3

                <- [1] 2 3 4 5
                <- [2] 3 4 5
                <- [3] 4 5
             */
            // 찾아본 코드
            for (int i = 0; i < M; i++)
            {
                int number = int.Parse(positions[i]);
                int index = 0;
                foreach (int item in deque)
                {
                    // 현재 위치와 뽑는 숫자가 같을 경우
                    if (item == number) break;
                    index++; // 찾지 못한 경우 인덱스를 증가
                }
                // 최소 연산을 위해 왼쪽과 오른쪽 중 더 적은 회전을 선택
                if(index <= deque.Count / 2)    // 덱의 중간 지점 계산
                {
                    // 왼쪽으로 회전 경우
                    for(; index > 0; index--)
                    {
                        deque.AddLast(deque.First.Value);
                        deque.RemoveFirst(); // 이동한 첫 번째 원소 삭제
                        count++; // 연산 횟수 증가
                    }
                }
                else
                {
                    // 오른쪽으로 회전 경우
                    for(index = deque.Count - index; index > 0; index--)
                    {
                        deque.AddFirst(deque.Last.Value); // 마지막 원소를 첫 번째로 이동
                        deque.RemoveLast(); // 이동한 마지막 원소 삭제
                        count++; //연산 횟수 증가
                    }
                }
                // 선택한 숫자를 삭제
                deque.RemoveFirst();
            }
            Console.WriteLine(count);
        }
    }
}