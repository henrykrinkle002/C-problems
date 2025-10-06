public class Solution {
    public int SwimInWater(int[][] grid) {
        //make a priority queue for min heap
        var pq = new PriorityQueue<(int h, int x, int y), int>();
        int m = grid.Length;
        bool[,] visited = new bool[m,m];
        int[] directions = {1, 0, -1, 0 ,1}; //acts like down(1,0), up(0, -1), left(-1, 0), right(0, 1)

        pq.Enqueue((grid[0][0], 0, 0), grid[0][0]);
        visited[0, 0] = true;
        
       
        while(pq.Count > 0){
            var (h, x, y) = pq.Dequeue();
            //check boundary and return the same height
            if(x == m-1 && y == m-1) return h;
            //look for neighbouring blocks
            for(int d=0; d<4; d++){
                int nx = x+directions[d], ny = y+directions[d+1];
                //checking for boundaries
                if(nx < 0 ||ny < 0||nx > m-1||ny > m -1||visited[nx, ny]) continue;

                visited[nx, ny] = true;
                //add the new height into queue after being removed the previous one.
                int newH = Math.Max(h, grid[nx][ny]);
                pq.Enqueue((newH, nx, ny), newH);
            }
        }
return -1;
    }
}