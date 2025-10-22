public class Solution {
    public int[] CountBits(int n) {
        int[] ans = new int[n+1];
      for(int i=0; i<=n; i++){
        ans[i] = ans[i>>1] + (i&1);
      }
      return ans;  
    }

    // n = 5 (i&1) means the last bit of i x 1 = 1 or 0, 0 if even 1 if odd.
    // i=0 0 + 0 = 0, i=1 0+1 = 1, i=2 1+0= 1, i=3 1+1 = 2
    // i=4 1+0 = 1, i=5 1+1 = 2 .. etc  

    // We want a subproblem smaller than i
// And we want a simple rule to relate ans[i] to that subproblem
// Removing the last bit is perfect: it’s a single step reduction, and we know its count already (ans[i >> 1])
// To count 1’s in a number, just look at all bits except the last (i >> 1) — we already know how many 1’s are there — then add 1 if the last bit is set.
}