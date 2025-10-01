public class Solution {
    public void SetZeroes(int[][] matrix) {
    int m = matrix.Length, n = matrix[0].Length;
    bool firstRowZero = false, firstColZero = false;

    // Step 1: check if first row/col need zeroing
    for (int j = 0; j < n; j++) {
        if (matrix[0][j] == 0)           
            firstRowZero = true;
    }
    for (int i = 0; i < m; i++) {
        if (matrix[i][0] == 0) 
            firstColZero = true;
    }

    // Step 2: mark rows/cols
    for (int i = 1; i < m; i++) {
        for (int j = 1; j < n; j++) {
            if (matrix[i][j] == 0) {
                matrix[i][0] = 0;
                matrix[0][j] = 0;
            }
        }
    }

    // Step 3: set zeroes using markers
    for (int i = 1; i < m; i++) {
        for (int j = 1; j < n; j++) {
            if (matrix[i][0] == 0 || matrix[0][j] == 0) {
                matrix[i][j] = 0;
            }
        }
    }

    // Step 4: zero first row/col if needed
    if (firstRowZero) {
        for (int j = 0; j < n; j++)             matrix[0][j] = 0;
    }
    if (firstColZero) {
        for (int i = 0; i < m; i++) 
            matrix[i][0] = 0;
    }
}
}