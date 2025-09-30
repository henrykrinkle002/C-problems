// bit wise operations are faster

public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new int[9];
        var cols = new int[9];
        var boxes = new int[9];

        for (int r = 0; r < 9; r++) {
            for (int c = 0; c < 9; c++) {
                char val = board[r][c];
                if (val == '.') continue;  // skip empty cells

                // Row check
                int bit =  1 << (val - '1');
                if ((rows[r] & bit) != 0) return false;
                rows[r] |= bit;

                // Column check
                if ((cols[c] & bit) != 0) return false; //duplicate found
                cols[c] |= bit;

                // Box check
                int boxIndex = (r / 3) * 3 + (c / 3);
                if ((boxes[boxIndex] & bit) != 0) return false;
                boxes[boxIndex] |= bit;
            }
        }

        return true;
    }
}
