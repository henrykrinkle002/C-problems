public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int sum=0, minlen=int.MaxValue, left=0;
        for(int right=0; right<nums.Length; right++){
            sum += nums[right];
            while(sum >= target){
                minlen = Math.Min(minlen, right - left + 1); //at the moment minlen
                sum -= nums[left];
                left++;
            }
        }
        return minlen == int.MaxValue? 0:minlen;
    }
}