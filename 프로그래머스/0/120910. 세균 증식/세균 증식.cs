using System;

public class Solution {
    public int solution(int n, int t) {
        int answer = (int)Math.Pow(2, t);
        return n * answer;
    }
}