public class Solution {
    List<int> possible = new List<int>();
    int target;
    int[] baseCosts;
    int[] toppingCosts;
    public int ClosestCost(int[] baseCosts, int[] toppingCosts, int target) {
        this.baseCosts = baseCosts;
        this.toppingCosts = toppingCosts;
        this.target = target;

        dfs(0, 0);
        int best = int.MaxValue;
        foreach(var baseCost in baseCosts){
            //loop through the base IceCream at i
                foreach(var toppingSum in possible){
                    //Possible is the array of values that aligns with the target or covered all the toppings cost
                    int total = baseCost + toppingSum;
                    if((Math.Abs(total - target) < Math.Abs(best - target)) || (Math.Abs(total - target) == Math.Abs(best - target)) && total < best){
                        best = total;
                    }
                }
        }
        return best;
    }

    private void dfs(int index, int current){
        if(current > target){
            return;
        }
        //to consider all the types of toppings given if so return
        if (index == toppingCosts.Length){
            possible.Add(current);
            return;
        }

        dfs(index+1, current); //only consider base
        dfs(index+1, current+toppingCosts[index]); //Add the cost of one type of coding once
        dfs(index+1, current+ 2*toppingCosts[index]); // Add the cost of 2 toppings added into the icecream
    }
}