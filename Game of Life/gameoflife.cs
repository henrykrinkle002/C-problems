public class Solution {
    public void GameOfLife(int[][] board) {
        int m = board.Length;
        int n = board[0].Length;
        int[][] directions = new int[][]{
            new int[] {-1, -1}, new int[] {-1, 0}, new int[] {-1, 1}, new int[] {0, -1},  new int[] {0, 1}, new int[]{1, -1}, new int[]{1, 0}, new int[] {1, 1}};

        for(int i=0; i<m; i++){
            for(int j=0; j<n; j++){
                int liveNeighbors = 0;
                
                foreach(var d in directions){
                    //checking neighbors
                    int ni = i+d[0], nj = j+d[1];
                    if(ni>=0 && ni < m && nj>=0 && nj < n && Math.Abs(board[ni][nj]) == 1)    liveNeighbors++;
                }

                //if block dies or not
                if(board[i][j] == 1 && (liveNeighbors < 2 || liveNeighbors > 3)) board[i][j] = -1;

                //if block lives
                if(board[i][j] == 0 && liveNeighbors == 3) board[i][j] = 2;
            }
        }

        //use the markers to assign live and dead cells
        for(int i=0; i<m; i++){
            for(int j=0; j<n; j++){
                board[i][j] = board[i][j] > 0 ? 1 : 0; 
            }
        }
    }
}