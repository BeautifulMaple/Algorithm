using System;
using System.Collections.Generic;


class Solution {
    public int solution(int[,] maps) {
        int n = maps.GetLength(0);
        int m = maps.GetLength(1);
        
        bool[,] visited = new bool[n, m];
        
        return BFS(n, m, maps, visited);
    }
    
    public int BFS (int n, int m, int [,] maps, bool[,] visited)
    {
        int[] dx = { -1, 1, 0, 0 }; // 행의 이동
        int[] dy = { 0, 0, -1, 1 }; // 열의 이동
        
        // 시작점 (0,0) 이동거리(1)
        Queue<(int x, int y, int dist)> queue = new Queue<(int, int, int)>();
        
        queue.Enqueue((0,0,1)); 
        visited[0,0] = true; // 시작점에서 시작(방문)
        
        while(queue.Count > 0)
        {
            // 큐에서 먼저 들어온 위치를 꺼냄
            var curr = queue.Dequeue();
            
            int cx = curr.x;
            int cy = curr.y;
            int dist = curr.dist;
                        
            // 목적지에 도착했는지 확인
            if(cx == n - 1 && cy == m - 1) return dist;
            
            for(int i = 0; i < 4; i++)
            {
                int nx = cx + dx[i];
                int ny = cy + dy[i];
                
                // 맵의 범위
                if (nx >= 0 && nx < n && ny >= 0 && ny < m)
                {
                    if(maps[nx, ny] == 1 && !visited[nx, ny])
                    {
                        visited[nx, ny] = true;
                        queue.Enqueue((nx, ny, dist + 1));
                    }
                }
            }
        }
        return -1;
    }
}