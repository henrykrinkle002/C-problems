public class Solution {
    public long MaximumTotalDamage(int[] power) {
       //index = spell 
       // the solution is dependant on values not the indices so Counter reduces the complexity

        var count = new Dictionary<int, int>();
        foreach (int p in power) {
            if (!count.ContainsKey(p))
                count[p] = 0;
            count[p]++;
        }
       var unique = count.Keys.ToList();
       unique.Sort();
       int n = unique.Count;

       long[] dp = new long[n];

       dp[0] = (long)unique[0] * count[unique[0]];

    for(int i=1; i<n; i++){
        int damage = unique[i]; //after each iteration we add all the values that are the same cause that is allowed 
        long total = (long)damage * count[damage];

        //find the elements that +3, -3 from the target value. find the index
        int j = BinarySearch(unique, damage - 3);
        long take = total + (j >= 0 ? dp[j] : 0);

        long skip = dp[i-1]; //keep the previous element/sum  not the new iteration if it fails the condition
        dp[i] = Math.Max(take, skip); 
    }
    return dp[n-1];
    }

    public int BinarySearch(List<int> unique, int damage){
        int left = 0, right = unique.Count - 1, result = -1;

        while(left <= right){
            int mid = left + (right - left) / 2;
            if (unique[mid] <= damage){
                result = mid;
                left = mid + 1;
            }else
                right = mid - 1;
        }
        return result;
        }
}