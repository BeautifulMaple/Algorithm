using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(string begin, string target, string[] words)
    {
        int answer = 0;
        // 로직 구현 필요

        // words 배열에 target이 있는지 확인
        if (Array.IndexOf(words, target) == -1)
        {
            return 0; // target이 words에 없으면 변환 불가능
        }
        BFS(begin, target, words, ref answer);

        return answer;
    }

    public void BFS(string begin, string target, string[] words, ref int answer)
    {
        // 큐를 사용하여 BFS 탐색을 구현   
        Queue<(string, int)> queue = new Queue<(string, int)>();
        queue.Enqueue((begin, 0)); // 시작 단어와 깊이 0을 큐에 추가
        // 방문한 경우 배열에 저장
        bool[]visited = new bool[words.Length];

        while (queue.Count > 0)
        {
            var (currentWord, currentDepth) = queue.Dequeue();

            if (currentWord == target)
            {
                answer = currentDepth;
                return; // 시작 단어가 이미 target과 같으면 0 반환
            }

            // 단어가 다를 경우 알파벨 변경
            for (int j = 0; j < words.Length; j++)
            {
                // 방문을 안하고 알파벳이 다른 경우
                if (!visited[j] && IsChange(currentWord, words[j]))
                {
                    visited[j] = true; // 방문 처리
                    queue.Enqueue((words[j], currentDepth + 1)); // 다음 단어와 깊이를 큐에 추가
                }
            }
        }
    }

    private bool IsChange(string currentWord, string worods)
    {
        int diffCount = 0;
        for (int i = 0; i < currentWord.Length; i++)
        {
            if (currentWord[i] != worods[i])
            {
                diffCount++;
            }
            if (diffCount > 1) // 한 글자만 다르면 true
            {
                return false;
            }
        }
        return diffCount == 1; // 정확히 한 글자만 다르면 true, 아니면 false
    }
}