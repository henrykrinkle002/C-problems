public class Solution {
    public bool DivisorGame(int n) {
        //implementing dynamic programming
        bool[] dp = new bool[n+1];
        dp[1] = false;
        for(int i=2; i<=n; i++){
            for(int x=1; x<i; x++){ //finding divisbility
            //calculating subproblems for further processing
                if(i%x == 0 && !(dp[i-x])){
                    dp[i] = true;
                    break;
                }
            }
        }
        //Alice: 
        // i: 1 2 3 4 5 6
        // i%x == 0
        //(possible moves) x: 0 1 1 1,2 1 1,2,3
        //Pattern: Alice wins at 2, 4, 6
        // Can move more on their VALUE in those positions than at 1, 3, 5
        // Who can move more WINS. In this case Even gets more VALUES than ODD
        return n % 2 == 0;
    }
}