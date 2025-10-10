public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {

     int limit = 100001;
     int n = spells.Length;
     int[] result = new int[n];
     var prefixSum = new int[limit];

     for(int i=0; i<potions.Length; i++){
        // find the 
        long spellCost = success % potions[i] == 0? success/potions[i] : success/potions[i] + 1;
        // count the potions for each spell
        if(spellCost < limit)
            prefixSum[spellCost]++;
        }

        //find the culminative sum for each spell
        for(var i=1; i<prefixSum.Length; i++)
            prefixSum[i] += prefixSum[i-1];

        for(int i=0; i<spells.Length; i++)
            result[i] = prefixSum[spells[i]];    
     
     return result;   
    }
}