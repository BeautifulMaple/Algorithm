using System;

public class Solution {
    public bool solution(string s) {
        bool answer = true;
        int count = 0;
        
        foreach(char c in s)
        {
            if (c == '(')
                count++;
            else if (c == ')'){
                count--;
                if (count < 0) return false;
            }
            
        }
        if(count != 0)
            answer = false;
        else
            answer = true;
        return answer;
    }
}