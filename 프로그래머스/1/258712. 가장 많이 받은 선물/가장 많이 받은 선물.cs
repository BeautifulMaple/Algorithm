using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public int solution(string[] friends, string[] gifts)
    {
        // 선물 주고받은 내역 저장을 위한 딕셔너리
        Dictionary<(string, string), int> giftExchanges = new Dictionary<(string, string), int>();
        // 각 친구의 선물지수 저장을 위한 딕셔너리
        Dictionary<string, int> giftIndex = new Dictionary<string, int>();
        // 다음 달 받을 선물 개수 계산을 위한 딕셔너리
        Dictionary<string, int> nextMonthGifts = new Dictionary<string, int>();

        // 딕셔너리 초기화
        foreach (var friend in friends)
        {
            giftIndex[friend] = 0;
            nextMonthGifts[friend] = 0;
            foreach (var other in friends)
            {
                if (friend != other)
                {
                    giftExchanges[(friend, other)] = 0;
                }
            }
        }

        // 선물 주고받은 내역 기록
        foreach (var gift in gifts)
        {
            var parts = gift.Split(' ');
            var giver = parts[0];
            var receiver = parts[1];
            if (giver != receiver)
            {
                giftExchanges[(giver, receiver)]++;
            }
        }

        // 선물지수 계산
        foreach (var friend in friends)
        {
            var sentGifts = giftExchanges.Where(g => g.Key.Item1 == friend).Sum(g => g.Value);
            var receivedGifts = giftExchanges.Where(g => g.Key.Item2 == friend).Sum(g => g.Value);
            giftIndex[friend] = sentGifts - receivedGifts;
        }

        // 다음 달 선물 개수 계산
        foreach (var exchange in giftExchanges)
        {
            var giver = exchange.Key.Item1;
            var receiver = exchange.Key.Item2;
            var count = exchange.Value;
            var reverseCount = giftExchanges[(receiver, giver)];

            if (count > reverseCount || (count == reverseCount && giftIndex[giver] > giftIndex[receiver]))
            {
                nextMonthGifts[giver]++;
            }
        }

        return nextMonthGifts.Values.Max();
    }
}