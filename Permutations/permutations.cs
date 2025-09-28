public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        var result = new List<IList<int>>();
        var temp = new List<int>();

        void Backtrack(){
            if(temp.Count == nums.Length){
                result.Add(new List<int>(temp));
                return;
            }

            foreach(int num in nums){
                if(temp.Contains(num)) continue;
                temp.Add(num);
                Backtrack();
                temp.RemoveAt(temp.Count - 1);
            }
        }
        Backtrack();
        return result;
    }
}