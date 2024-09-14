using System;
using System.Collections.Generic;

/// <summary>
/// Implementation of A* algorithm: https://en.wikipedia.org/wiki/A*_search_algorithm
/// </summary>
public class PathFinderOneCanYouReachTheExit
{
    public static bool PathFinder(string maze)
    {
        var lines = maze.Split('\n');
        var n = lines.Length;
        var visited = new bool[n, n];
        var cost = new int[n, n];
        var directions = new[] { (0, 1), (1, 0), (0, -1), (-1, 0) };

        var priorityQueue = new PriorityQueue<(int, int), int>();

        var startX = 0;
        var startY = 0;

        var goalX = n - 1;
        var goalY = n - 1;

        priorityQueue.Enqueue((startX, startY), ManhattanDistance(startX, startY, goalX, goalY));
        visited[startX, startY] = true;
        cost[startX, startY] = 0;

        while (priorityQueue.Count > 0)
        {
            var current = priorityQueue.Dequeue();
            var x = current.Item1;
            var y = current.Item2;

            if (x == goalX && y == goalY)
            {
                return true;
            }

            foreach (var (dx, dy) in directions)
            {
                var nx = x + dx;
                var ny = y + dy;

                if (nx >= 0 && nx < n && ny >= 0 && ny < n && !visited[nx, ny] && lines[nx][ny] == '.')
                {
                    visited[nx, ny] = true;
                    int gCost = cost[x, y] + 1;
                    cost[nx, ny] = gCost;
                    int fCost = gCost + ManhattanDistance(nx, ny, goalX, goalY);
                    priorityQueue.Enqueue((nx, ny), fCost);
                }
            }
        }

        return false;
    }

    private static int ManhattanDistance(int x, int y, int targetX, int targetY)
    {
        return Math.Abs(x - targetX) + Math.Abs(y - targetY);
    }
}