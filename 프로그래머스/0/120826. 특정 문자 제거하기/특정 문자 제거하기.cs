using System;

public class Solution {
    public string solution(string my_string, string letter) {
        string answer = "";
        answer = my_string.Replace(letter,"");
        return answer;
    }
}