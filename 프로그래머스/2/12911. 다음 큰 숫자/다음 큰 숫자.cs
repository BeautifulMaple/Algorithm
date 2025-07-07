using System;

class Solution 
{
    public int solution(int n) 
   {
        int answer = n;
        
        int bunary_number_cnt = 0;  // 현재 수의 2진수 값
        int result_cnt = 0;         // 다음 큰 수 
        
        bunary_number_cnt = ConvertDecimalToBinary(n);
        
        while(result_cnt != bunary_number_cnt)
        {
            answer++;
            result_cnt = ConvertDecimalToBinary(answer);
            
        }

        return answer;
    }
    public int ConvertDecimalToBinary(int number){
        int Binary = 0;
        
        while(number > 0){
            if (number % 2 == 1)
                Binary++;
            number /= 2;
        }
        return Binary;
    }
}