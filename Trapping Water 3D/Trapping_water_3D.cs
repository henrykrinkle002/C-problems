public class Solution {
    public int TrapRainWater(int[][] heightMap) {
        int n = heightMap.Length, m = heightMap[0].Length;
        if (n <= 2 || m <= 2) return 0;

        var visited = new bool[n, m];
        var pq = new PriorityQueue<Cell, int>();

        // push all boundary cells
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                if (i == 0 || j == 0 || i == n - 1 || j == m - 1) {
                    pq.Enqueue(new Cell(i, j, heightMap[i][j]), heightMap[i][j]);
                    visited[i, j] = true;
                }
            }
        }

        int water = 0;
        int[] dirs = { 1, 0, -1, 0, 1 };
        while (pq.Count > 0) {
            var cur = pq.Dequeue(); #remove the existing height and replace with mx height
            int x = cur.X, y = cur.Y, h = cur.H;

            for (int d = 0; d < 4; d++) {
                int nx = x + dirs[d], ny = y + dirs[d + 1];
                if (nx < 0 || ny < 0 || nx >= n || ny >= m || visited[nx, ny]) continue;

                visited[nx, ny] = true;
                water += Math.Max(0, h - heightMap[nx][ny]);
                pq.Enqueue(new Cell(nx, ny, Math.Max(h, heightMap[nx][ny])),
                           Math.Max(h, heightMap[nx][ny]));
            }
        }
        return water;
    }

    public record struct Cell(int X, int Y, int H);
}
