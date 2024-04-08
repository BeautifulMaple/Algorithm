using System;
using System.Collections;
using System.Collections.Generic;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            // 최소 회의실 개수 입력하기
            int N = int.Parse(Console.ReadLine());

            // 시작 시간과 끝나는 시간를 저장할 리스트
            List<(int time, int type)> meetings = new List<(int time, int type)>();
            
            // N개의 회의 시간을 입력 받아 시간 메모하기
            for (int i = 0; i < N; i++) 
            {
                string[] T_Input = Console.ReadLine().Split();
                int T_start = int.Parse(T_Input[0]);
                int T_end = int.Parse(T_Input[1]);
                meetings.Add((T_start, 1)); // 시작 이벤트 (시간, 타입), 여기서 타입 1은 시작을 의미
                meetings.Add((T_end, -1)); // 종료 이벤트 (시간, 타입), 여기서 타입 -1은 종료를 의미
            }

            // 회의 시간순으로 정렬, 시간이 같다면 종료 회의 시간이 먼저 오도록
            meetings.Sort((a, b) => a.time == b.time ? a.type.CompareTo(b.type) : a.time.CompareTo(b.time));

            int MaxRooms = 0; // 필요한 최대 회의실 수
            int currentRooms = 0;  // 현재 사용 중인 회의실 수

            foreach (var meeting in meetings)
            {
                currentRooms += meeting.type; // 회의 시간이면 +1, 회의 시간이면 -1
                MaxRooms = Math.Max(MaxRooms, currentRooms); // 최대 회의실 수 갱신
            }
            // 출력하기
            Console.WriteLine(MaxRooms);
        }
    }
}