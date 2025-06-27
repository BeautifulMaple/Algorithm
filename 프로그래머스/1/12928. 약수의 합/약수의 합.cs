
public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        // 약수 구하기
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                answer += i;
        }
        return answer;
    }
}