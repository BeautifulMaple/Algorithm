using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        // 약관 종류별 유효기간 저장
        Dictionary<string, int> termDurations = new Dictionary<string, int>();
        foreach (var term in terms) {
            var parts = term.Split(' ');
            termDurations[parts[0]] = int.Parse(parts[1]);
        }

        // 오늘 날짜 파싱
        DateTime todayDate = DateTime.Parse(today);

        List<int> expired = new List<int>();
        for (int i = 0; i < privacies.Length; i++) {
            var parts = privacies[i].Split(' ');
            DateTime startDate = DateTime.Parse(parts[0]);
            int durationMonths = termDurations[parts[1]];

            // 유효 기간 계산
            DateTime expirationDate = startDate.AddMonths(durationMonths);
            if (expirationDate <= todayDate) {
                // 만료된 경우
                expired.Add(i + 1);
            }
        }

        return expired.ToArray();
    }
}
