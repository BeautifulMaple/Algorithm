using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        int sameCount = 0;
        int diffCount = 0;

        char x = s[0]; // 기준 문자

        for (int i = 0; i < s.Length; i++) {
            if (s[i] == x) {
                sameCount++;
            } else {
                diffCount++;
            }

            if (sameCount == diffCount) {
                answer++;

                // 다음 기준 문자 설정
                if (i + 1 < s.Length) {
                    x = s[i + 1];
                    sameCount = 0;
                    diffCount = 0;
                }
            }
        }

        // 끝났을 때 카운트가 서로 다르면 한 조각 더 추가
        if (sameCount != diffCount) {
            answer++;
        }

        return answer;
    }
}
