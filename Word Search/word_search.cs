public class Solution {
    public bool Exist(char[][] board, string word) {
        int rows = board.Length;
        int cols = board[0].Length;
        

        bool Backtrack(int i, int j, int index){
            if(index == word.Length) return true;

            if(i<0 || j<0 ||i>=rows || j>=cols||index >= word.Length||board[i][j]!=word[index] ) return false;

            char temp = board[i][j];
            board[i][j] = '#';
            
            if(Backtrack(i+1, j, index+1)||Backtrack(i-1, j, index+1) || Backtrack(i, j+1, index+1) || Backtrack(i, j-1, index+1)) return true;

            board[i][j] = temp;
            return false;
        }
        for(int i=0; i<=rows; i++){
            for(int j=0; j<=cols; j++){
                if(Backtrack(i, j, 0)) return true;
            }
        }
        return false;
    }
}
