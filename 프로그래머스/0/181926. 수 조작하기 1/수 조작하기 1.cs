using System;

public class Solution {
    public int solution(int n, string control) {
        int answer = n;  // 초기값을 n으로 설정

        foreach (char c in control)
        {
            switch (c)
            {
                case 'w': answer += 1; break;
                case 's': answer -= 1; break;
                case 'd': answer += 10; break;
                case 'a': answer -= 10; break;
            }
        }

        return answer;
    }
}
