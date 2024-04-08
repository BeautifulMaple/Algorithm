using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace Baekjoon
{
    class Qucak
    {
        static void Main(string[] args)
        {
            // ex) quack, quackquackquackquack
            string quacksound = Console.ReadLine();
            // 입력 받은 문자열을 분석 후 오리 수를 계한하고 출력하기
            Console.WriteLine(Ducks(quacksound));
        }

        static int Ducks(string sound)
        {
            const string DuckSound = "quack"; //오리 소리
            // 오리 소리의 각 문자('q', 'u', 'a', 'c', 'k')가 몇 번 등장했는지 추적합니다.
            int[] soundCount = new int[DuckSound.Length];
            int duckCount = 0; // 오리 마리 수 
            int Maxduck = 0;   // 세고 있는 오리


            foreach (char c in sound)
            {
                // 현재 문자가 오리 소리에서 몇 번째 위치하는지 찾습니다.
                int soundIndex = DuckSound.IndexOf(c);

                // 현재 문자가 오리 소리에 포함되지 않으면 잘못된 문자가 입력된 것이므로 -1을 반환합니다.
                if (soundIndex == -1)
                    return -1;

                // 'q' 문자인 경우, 새로운 오리 소리가 시작됩니다
                if (soundIndex == 0)
                {
                    // quack에서 q가 시작일 때
                    soundCount[0]++;
                    duckCount++; // 세고 있는 오리 
                    // 현재 진행 중인 오리 소리의 수와 최대 오리 중 더 큰 오리 수로 갱신
                    Maxduck = Math.Max(duckCount, Maxduck);
                }
                else
                {
                    // 올바른 소리 순서인 경우 (예: 'u'는 'q' 다음에 나타남), 이전 소리의 발생 횟수를 감소시키고 현재 소리의 발생 횟수를 증가시킵니다.
                    if (soundCount[soundIndex - 1] > 0)
                    {
                        soundCount[soundIndex - 1]--;
                        soundCount[soundIndex]++;
                    }
                    else
                    {
                        // 올바르지 않은 소리 순서인 경우 -1을 반환합니다.
                        return -1;
                    }
                }
                // quack에서 'k'에 도달 할 때 
                if (soundIndex == DuckSound.Length - 1)
                {
                    // "quack" 완성, 진행중인 오리 감소
                    duckCount--;
                    soundCount[soundIndex]--;
                }
            }

            //모든 오리의 울음소리가 올바르게 끝났는지 확인
            for (int i = 0; i < DuckSound.Length - 1; i++)
            {
                // 'k'문자 혹은 모든 문자가 0아 아니면 오류
                if (soundCount[i] != 0) return -1; // 끝나지 않은 오리 소리가 있으면 오류
            }

            return Maxduck; // 계산된 최소 오리 수 반환
        }
    }
}