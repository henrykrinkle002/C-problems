public class Solution {
    int count;
    int[] nums;
    int max_Or;
    public int CountMaxOrSubsets(int[] nums) {
        this.max_Or = 0;
        foreach(var num in nums){
            max_Or |= num;
        }
        this.nums = nums;
        this.count = 0;
        dfs(0, 0);
        return count;
    }

    public void dfs(int index, int current_Or){

        if(index == nums.Length){
            if(max_Or == current_Or){
                count++;
            }
            return;
        }
        

        //include the value from nums
        dfs(index+1, current_Or | nums[index]);
        //exclude the value from nums
        dfs(index+1, current_Or);
    }
}