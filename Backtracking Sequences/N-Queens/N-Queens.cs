
    public static bool canPlaceSecurityCameras(int N, List<List<int>> grid)
    {
        HashSet<int> cols = new HashSet<int>();
        HashSet<int> diag1 = new HashSet<int>();
        HashSet<int> diag2 = new HashSet<int>();
        bool found = false;
        
        void Backtracking(int row){
            if(row == N){
                found = true; //able to reach the bottom
                return;
            }
            
            for(int col=0; col<N; col++){
                
                if(cols.Contains(col) || diag1.Contains(row-col) || diag2.Contains(row + col) || grid[row][col] == 1) continue;
                
                cols.Add(col); //Add to block the columns
                diag1.Add(row-col); //Add to block the diagonals
                diag2.Add(row+col); //Add to block the diagonals
                
                Backtracking(row+1); //Starting from this row to the corresponding columns. 
                //if row 1 corresponding cols
                //if row 3 corresponding cols
                // We use backtracking so that even if row 3 doesn't work we can still go back to row 2 or row 1 to retrace our path
               
                if(found) // if the track was successful we return early or continue to remove the columns.
                    return;
                
                cols.Remove(col);
                diag1.Remove(row-col);
                diag2.Remove(row+col);
                
            }
        }
        Backtracking(0);
        return found;   
    }
}