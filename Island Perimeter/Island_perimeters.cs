public class Solution {
    public int IslandPerimeter(int[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;
        for(int i=0; i<rows; i++)
            for(int j=0; j<cols; j++)
                if(grid[i][j] == 1) //if land
                   return DFS(grid, i, j);
    // int m = grid.Length;
    // int n = grid[0].Length;
    // int perimeter = 0;
    // for(int i=0; i<m; i++){
    //     for(int j=0; j<n; j++){
    //         if(grid[i][j] == 1){
    //             perimeter += 4;
    //             if(i>0 && grid[i-1][j] == 1)
    //                 perimeter -= 2;
    //             if(j>0 && grid[i][j-1] == 1)
    //                 perimeter -= 2;
    //         }
    //     }
    // }       
    // return perimeter;
    return 0;
        }
}

private int DFS(int[][] grid, int i, int j){   // if surrounded by water/edges
    if(i<0|| j<0 || i>grid.Length || j>grid[0].Length || grid[i][j] == 0) return 1;

    //already visited land
    if(grid[i][j] == -1) return 0;

    grid[i][j] = -1;

    return DFS(grid, i-1, j) + DFS(grid, i+1, j) + DFS(grid, i, j-1) + DFS(grid, i, j+1);
    //top + bottom + left + right of the current block

}
