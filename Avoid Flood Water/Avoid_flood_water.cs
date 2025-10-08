public class Solution {
    public int[] AvoidFlood(int[] rains) {
        var lastrains = new Dictionary<int, int>();
        var drydays = new List<int>();
        int n = rains.Length;
        int[] ans = new int[n];
        for (int i = 0; i < n; i++){
            int lake = rains[i];
            if(lake > 0){
                ans[i] = -1;
                if(lastrains.ContainsKey(lake)){
                    int idx = drydays.BinarySearch(lastrains[lake]);
                    if(idx < 0) idx = ~idx;
                    if (idx == drydays.Count) //if len(drydays) == 0?
                    return new int[0];
                    int dryday = drydays[idx];
                    ans[dryday] = lake;
                    drydays.RemoveAt(idx);
                }
            lastrains[lake] = i; //rainy day
            }
                else{
                    drydays.Add(i);
                    ans[i] = 1;
                }

            }
            return ans;
    }
}