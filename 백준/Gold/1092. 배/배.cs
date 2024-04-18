using System;
using System.Runtime.Intrinsics.Arm;

namespace Baekjoon
{
    class Progrma
    {
        static void Main(string[] args)
        {
            // 테스트 케이스 개수 입력 받기 (첫번째)
            int N = int.Parse(Console.ReadLine());  // N : 크레인
            // 입력 -> 공백에 따라 문자열 분리 -> 정수로 변환 후 리스트 요소로 변환 -> 내림차순 -> 리스트로 변환
            List<int> Cranes = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(n => n).ToList();

            int M = int.Parse(Console.ReadLine());  // M : 박스의 수
            List<int> Boxes = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(n => n).ToList();

            // 다 못 옮기는 경우
            if (Boxes[0]> Cranes[0])
            {
                Console.WriteLine("-1");
                return;
            }

            // 수행되는 시간 카운트
            int time = 0;
            while (Boxes.Count > 0)
            {
                int idx = 0;
                for(int i = 0; i < Cranes.Count;)
                {
                    // 다 옮기면 끝내기
                    if (idx == Boxes.Count) break;
                    if (Cranes[i] >= Boxes[idx])
                    {
                        // 조건 만족시 하나 삭제
                        Boxes.RemoveAt(idx);
                        i++;
                    }
                    else
                    {
                        // 카운트 증가
                        idx++;
                    }
                }
                // 크레인 다 사용했다면 1 증가
                time++;
            }

            Console.WriteLine(time);
        }
    }
}